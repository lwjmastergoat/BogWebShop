﻿document.addEventListener("DOMContentLoaded", start);
//var template = document.querySelector("#Template").innerHTML;
var CartItem = document.querySelector("#Template-cartItem").innerHTML;
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
		});
};
function getProduct(id) {
	for (var prod in products) {
		prod = products[prod];
		if (id == prod.ID)
			return prod
	}
}

function viewCart(selector) {
	var html = "";
	for (var id in cart) {
		var prod = getProduct(id);
		if(prod != null)
			html +=
				CartItem
					.replace(/{{Name}}/g, prod.ProductName)
					.replace(/{{ID}}/g, id)
					.replace(/{{Amount}}/g, cart[id]);
		else
			delete cart[id];
	}
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
	viewCart("#Cart");
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