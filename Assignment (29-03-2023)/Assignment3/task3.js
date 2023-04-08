function myFunction(event){
    
    let firstName=document.getElementById('name').value;
//    console.log(firstName);
    let res='';
    const regex = /^[a-zA-Z]+$/;
    if(!regex.test(firstName) ){
        console.log('yes')
        res+="Please enter a String Value <br>";
    }
    let Age=document.getElementById('age').value;
    console.log(Age);
    if (isNaN(Age) || Age < 0 || Age=='') {
        res+= "Please Enter a Valid Age <br>";
      }
       
    let number=document.getElementById('mobile').value;
    if (isNaN(number) || number<1000000000 || number>= 100000000000 ) {
        res+= "Please Enter a Valid Mobile Number <br>";
      } 
    let gmail=document.getElementById('email').value;
    if (!gmail.endsWith("@gmail.com") ) {
        res+= "Please Enter a Valid Gmail (Ex: abc@gmail.com) <br>";
      } 
      document.getElementById('errors').innerHTML=res;
      if(res.length==0){
        document.getElementById('errors').innerHTML='Submitted';
        document.getElementById('errors').setAttribute('style','color:green; font-size:20px;')
      }
}