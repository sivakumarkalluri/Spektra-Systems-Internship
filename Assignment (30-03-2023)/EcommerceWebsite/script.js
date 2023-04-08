let carts=document.querySelectorAll('.add-cart');


// Products Information
let products = [
    {
        productName: 'ROVER PACK CLASSIC',
        tag: 'product_1',
        price:99,
        inCart:0
    },
    {
        productName: 'ROVER PACK MINI',
        tag: 'product_2',
        price:99,
        inCart:0
    },
    {
        productName: 'H & M GREY SHIRT',
        tag: 'product_3',
        price:45,
        inCart:0
    },
    {
        productName: 'ZARA SWEAT JACKET',
        tag: 'product_4',
        price:25.99,
        inCart:0
    }
]

// Loop through Add to cards and adding event Listener

for (let i=0; i<carts.length;i++){
    carts[i].addEventListener('click',() =>{
        
        var cartMsg=carts[i].getElementsByTagName('span');
        cartMsg[0].innerHTML="ADDED TO CART";
        cartNumbers(products[i]);
        totalCost(products[i]);

    })
}

function onLoadCartNumbers(){
    let productNumbers = localStorage.getItem('cartNumbers');
    if(productNumbers){
        document.getElementById('cartLen').textContent=productNumbers;
    }
}
onLoadCartNumbers();
function cartNumbers(product){
    let productNumbers=localStorage.getItem('cartNumbers');
    // console.log(product);
    console.log(productNumbers);
    productNumbers = parseInt(productNumbers);
    if(productNumbers){
        localStorage.setItem('cartNumbers',productNumbers+1);
        document.getElementById('cartLen').textContent= productNumbers+1;
    }
    else{
        localStorage.setItem('cartNumbers',1)
        document.getElementById('cartLen').textContent=1
    }
    setItems(product);

}

function setItems(product){
    let cartItems=localStorage.getItem('productsInCart');
    cartItems =JSON.parse(cartItems);
    if(cartItems != null){
        if(cartItems[product.tag]==undefined){
            cartItems = {
                ...cartItems,
                [product.tag]:product

            }

        }
        cartItems[product.tag].inCart +=1
    }
    else{
        product.inCart =1;
    cartItems={
        [product.tag]:product
    }
    
    }
    localStorage.setItem("productsInCart",JSON.stringify(cartItems));
}

function totalCost(product){
    let cartCost = localStorage.getItem('totalCost');
    
    if(cartCost != null){
        cartCost = parseInt(cartCost);
        localStorage.setItem("totalCost",cartCost + product.price);
    }
    else{
        localStorage.setItem('totalCost',product.price);

    }
}

function displayCart(){
    var cartMessage=document.getElementById("cartMessage")
    let cartItems=localStorage.getItem('productsInCart');
    cartItems = JSON.parse(cartItems);
    let productContainer = document.querySelector(".products");
    let cartCost = localStorage.getItem('totalCost');

    if(cartItems && productContainer){
        productContainer.innerHTML='';
        Object.values(cartItems).map(item => {
            productContainer.innerHTML += `
            <div class="product">
            <i class="fa-solid fa-circle-xmark remove-item"></i>
                <img src="images/${item.tag}.jpg" width="200px">
                <span style="font-weight: bold;">${item.productName}</span>
                <div class="price" style="font-weight: bold; ">$${item.price}</div>
            <div class="quantity" >
            <select name="list" id="Quantlist" data-tag="${item.tag}">
              <option value="1" ${item.inCart === 1 ? 'selected' : ''}>1</option>
              <option value="2" ${item.inCart === 2 ? 'selected' : ''}>2</option>
              <option value="3" ${item.inCart === 3 ? 'selected' : ''}>3</option>
              <option value="4" ${item.inCart === 4 ? 'selected' : ''}>4</option>
              <option value="5" ${item.inCart === 5 ? 'selected' : ''}>5</option>
            </select> 
                           
               
            </div>
            <div class="total" style="font-weight: bold; ">
            $${item.inCart* item.price}
            </div>

             `;
        
        });
  
        document.querySelector(".products-container").innerHTML += `
        <div class="cartTotalContainer">
            <h4 class="cartTotalTitle">Cart Total</h4>
            <h4 class="cartTotal">$${cartCost}</h4>
        </div>`
        document.querySelector(".products-container").innerHTML+=`
        <div class="purchase"> Purchase
        </div>`
        console.log(productContainer.querySelectorAll('select'));
        productContainer.querySelectorAll('select').forEach((select) => {
            
            select.addEventListener("change", () => {
                console.log("yes");
                const tag = select.dataset.tag;
                const quantity = parseInt(select.value);
                updateItemQuantity(tag, quantity);
                displayCart();
              });
              
          });
      
          document.querySelector('.cartTotalContainer').innerHTML = `
            <h4 class="cartTotalTitle">Cart Total</h4>
            <h4 class="cartTotal" id="cartTotal">$${cartCost}</h4>
          `;
      
          updateCartLength();
        }
      }
      
      function updateItemQuantity(tag, quantity) {
        let cartItems = localStorage.getItem("productsInCart");
        cartItems = JSON.parse(cartItems);
        let product = cartItems[tag];
        product.inCart = quantity;
        localStorage.setItem("productsInCart", JSON.stringify(cartItems));
        updateCartTotal();
        updateCartLength();
      }
      
      
      function updateCartTotal() {
        let cartItems = localStorage.getItem("productsInCart");
        cartItems = JSON.parse(cartItems);
        let cartCost = localStorage.getItem("totalCost");
        let total = 0;
        Object.values(cartItems).map((item) => {
          total += item.inCart * item.price;
        });
        localStorage.setItem("totalCost", total.toFixed(2));
        document.getElementById("cartTotal").innerHTML = `$${total.toFixed(2)}`;
      }
      
      function updateCartLength() {
        let productNumbers = localStorage.getItem("cartNumbers");
        document.getElementById("cartLen").textContent = productNumbers;
      }
      
      
      displayCart();
      
      
      
      
      
      
      