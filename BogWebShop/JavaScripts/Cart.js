document.addEventListener("DOMContentLoaded", start);
//var template = document.querySelector("#Template").innerHTML;
var CartItem = document.querySelector("#Template-cartItem").innerHTML;
var TotalPrice = document.querySelector("#Template-TotalPrice").innerHTML;
var products;
var cart;

function start() {
	var LS = localStorage.getItem("cart");
	cart = JSON.parse(LS);
	fetch('/api/APIProducts/GetAll', {
		method: 'Get'
	})
		.then(Response => Response.json())
		.then(res => {
			console.log(res);
			products = res;
			viewCart("#Cart");
			try {
				start2()
			} catch (e) {
			}
		});
};
function getProduct(id) {
	for (var prod in products) {
		prod = products[prod];
		if (id == prod.ID)
			return prod
	}
}

function viewCart(selector,totalPrice) {
	var html = "";
	var totalPrice = 0;
	var totalCount = 0;
	for (var id in cart) {
		var prod = getProduct(id);
		if (prod != null) {
			totalPrice += prod.Price * cart[id];
			totalCount += Number(cart[id]);
			html += CartItem
				.replace(/{{Name}}/g, prod.ProductName)
				.replace(/{{ID}}/g, id)
				.replace(/{{Amount}}/g, cart[id])
				.replace(/{{Price}}/g, prod.Price);
		}else
			delete cart[id];
	}
	if (totalCount > 0) {
		document.querySelector("#counter").style.display = "block";
		document.querySelector("#counter").innerHTML = totalCount;
	} else {
		document.querySelector("#counter").style.display = "none";
	}
	html += TotalPrice
		.replace(/{{Total}}/g, totalPrice)
	document.querySelector(selector).innerHTML = html;
}

function addCart(id) {
	if (Number(id)) {
		if (cart == null)
			cart = {}
		if (!Number(cart[id]))
			cart[id] = 1;
		else
			cart[id]++;
		localStorage.setItem("cart", JSON.stringify(cart));
	}
	viewCart("#Cart");
}
function updateCart(id, elm) {
	if (Number(id)) {
		cart[id] = elm.value;

		localStorage.setItem("cart", JSON.stringify(cart));
	}

	var totalPrice = 0;
	var totalCount = 0;
	for (var id in cart) {
		var prod = getProduct(id);
		if (prod != null) {
			totalPrice += prod.Price * cart[id];
			totalCount += Number(cart[id]);
		}
		else
			delete cart[id];
	}
	if (totalCount > 0) {
		document.querySelector("#counter").style.display = "block";
		document.querySelector("#counter").innerHTML = totalCount;
		document.querySelector("#totalPrice").innerHTML = "Total Price " + totalPrice + "kr.";
	} else {
		document.querySelector("#counter").style.display = "none";
	}
}
function clearCart() {
	localStorage.setItem("cart", null);
	viewCart("#Cart");
}
function removeCart(id) {
	if (Number(id)) {
		delete cart[id];

		localStorage.setItem("cart", JSON.stringify(cart));
	}
	viewCart("#Cart");
}