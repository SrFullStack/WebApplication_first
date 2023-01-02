window.addEventListener("load", GetProduct());
window.addEventListener("load", GetCategory());


async function GetProduct(){
    const res = await fetch(`https://localhost:44354/api/Products`)
    const res1 = await res.json();
    ShowProduct(res1)

}
function ShowProduct(products) {
    products.forEach(product => ShowProducts(product))
}
function ShowProducts(product) {
    var price = String(product.price);
    var tmp = document.getElementById("temp-card");
    var clon = tmp.content.cloneNode(true);
    clon.querySelector("h1").innerText = product.name;
    clon.querySelector(".price").innerText =price;
    clon.querySelector(".description").innerText = product.description;
    clon.querySelector("button").addEventListener("click", ()=>ToBasket(product))
   
   clon.querySelector("img").src = "./image/"+product.imageUrl;

   
    document.body.appendChild(clon);    

}
async function GetCategory(){
    const res = await fetch(`https://localhost:44354/api/Category`)
    const res1 = await res.json();
    ShowCategory(res1)
}
function ShowCategory(Category) {
    Category.forEach(category => ShowCategorys(category))
}
function ShowCategorys(category) {
    var tmp = document.getElementById("temp-category");
    var clon = tmp.content.cloneNode(true);
    clon.querySelector(".opt").id = category.id;
    clon.querySelector(".opt").value = category.id;
    clon.querySelector(".OptionName").innerText = category.company;
    document.getElementById("categoryList").appendChild(clon);
}
async function FilterProduct() {
    var name = document.getElementById("nameSearch").value;
    var categoryList = document.getElementsByClassName("opt");
    var minPrice = document.getElementById("minPrice").value;
    var maxPrice = document.getElementById("maxPrice").value;
    var categoryIds = "";
    for (var i = 0; i <= categoryList.length; i++) {
        if (categoryList[i].checked) {
            categoryIds += `&categoryIds=${categoryList[i].value}`

        }
        const url = await fetch(`https://localhost:44354/api/Products/?name=${name}&minPrice=${minPrice}&maxPrice=${maxPrice}${categoryIds}`)
      
        const res1 = await url.json();

        RemoveProduct();
        ShowProduct(res1);
    }
    function RemoveProduct() {
        var rem = document.getElementsByClassName("card");
        for (var i = rem.length - 1; i >= 0; i--) {
            document.body.removeChild(rem[i]);
        }
    }

}
const basket = [];
 totalsum = 0;
function ToBasket(product) {
    basket.push(product)
   
    localStorage.setItem('basket', JSON.stringify(basket));


    totalsum += product.price
    localStorage.setItem('totalsum', JSON.stringify(totalsum));
    document.getElementById("ItemsCountText").innerHTML = basket.length;
}

