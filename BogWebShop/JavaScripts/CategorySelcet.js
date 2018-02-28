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
			console.log(res);
			categorys = res;
		});
};
function MakeSelcet() {
	for (var i in category) {
		var category = categorys[i];
		"<option value=" + category.ID + ">" + category.CategoryName + "</option>";
	}
}