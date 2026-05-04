const image = document.getElementById("product-image");
const title = document.getElementById("product-title");
const price = document.getElementById("product-price");
const description = document.getElementById("product-description");
const category = document.getElementById("product-category");
const brand = document.getElementById("product-brand");
const sku = document.getElementById("product-sku");
const stock = document.getElementById("product-stock");
const productReviews = document.getElementById("product-reviews");
const productStars = document.getElementById("product-stars");

const urlId = new URLSearchParams(window.location.search).get("id") || 1;

fetch(`https://fakestoreapi.com/products/${urlId}`)
  .then((response) => response.json())
  .then((data) =>{
    image.src = data.image;
    title.textContent = data.title;
    price.textContent = `$${data.price.toFixed(2)}`;
    description.textContent = data.description;
    category.textContent = `Category: ${data.category}`;
    brand.textContent = "Brand: N/A";
    sku.textContent = "SKU: N/A";
    stock.textContent = "Stock: N/A";
    productReviews.textContent = `Reviews: ${data.rating.count} (${data.rating.rate} avg)`;
    productStars.innerHTML = "";
    for (let i = 0; i < Math.round(data.rating.rate); i++) {
      productStars.innerHTML += "★";
    }
  });