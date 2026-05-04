// axios, fetch, ajax

const products = document.getElementById("products");

fetch("https://fakestoreapi.com/products")
  .then((response) => response.json())
  .then((data) => {
    console.log(data);

    data.forEach((product) => {
      products.innerHTML += `
        <div class="card" style="width: 18rem">
        <img src="${product.image}" class="card-img-top" alt="..." />
        <div class="card-body">
          <h5 class="card-title">${product.title}</h5>
          <p class="card-text">
            ${product.description}
          </p>
          <a href="productDetails.html?id=${product.id}" class="btn btn-primary">$${product.price.toFixed(2)}</a>
        </div>
      </div>`;
    });
  });
