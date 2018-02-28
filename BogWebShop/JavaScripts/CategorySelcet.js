document.addEventListener("DOMContentLoaded", start);
var categorys;

function start() {
	var LS = localStorage.getItem("cart");
	cart = JSON.parse(LS);
	fetch('/api/APICategory/GetCategorys', {
		method: 'Get'
	})
		.then(Response => Response.json())
		.then(res => {
			categorys = res;
			MakeSelcet();
		});
};
function MakeSelcet() {
	var html = "";
	for (var i in categorys) {
		var category = categorys[i];
		html += "<option value=" + category.ID + ">" + category.CategoryName + "</option>";
	}
	document.getElementsByName("CategorySelect")[0].innerHTML += html;
	document.getElementsByName("CategorySelect")[0].addEventListener("change", function (e) {
		var val = e.target.value;
		var prod = document.querySelectorAll("div.products")
		for (var i in products) {
			var product = prod[i];
			var pVal = product.getAttribute("data-category");
			if (pVal == val || val == "*") {
				product.style.display = "block";
			} else {
				product.style.display = "none";
			}
		}
	});
}