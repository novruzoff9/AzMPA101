const createProductForm = document.getElementById('createProductForm');

createProductForm.addEventListener('submit', function(event){
    event.preventDefault();

    const formData = new FormData(createProductForm);
    const productData = {
        name: formData.get('name'),
        price: parseFloat(formData.get('price')),
        description: formData.get('description'),
        category: formData.get('category')
    };
    console.log('Creating product with data:', productData);

    fetch('https://fakestoreapi.com/products', {
        method: 'POST',
        body: JSON.stringify(productData)       
    })
});