function myFunction(){
    var res=' ';
    for(let i=2014;i<=2050;i++){

        const result = new Date(`January 1, ${i} 23:15:30`);
        const day1=result.getDay();
        if(day1==0){
            res+=`1st January is being Sunday on ${i} <br>`;
            
        }

    }
    document.getElementById('out').innerHTML=res;
}

myFunction();