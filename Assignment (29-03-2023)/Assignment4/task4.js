function myFunction(){
    let content=document.getElementsByTagName('input');
    var array=[]
    var total=0;
    for(let i=0;i<content.length;i++){
        array.push(parseInt(content[i].value));
       
    }
    for(let i=0;i<content.length;i++){
        total+=array[i];
    }
    document.getElementById('total').innerHTML=total;
    const avg=total/content.length;
    document.getElementById('avg').innerHTML=avg;
    const percent=(total/(100*content.length))*100;
    switch(true){
        case percent>=0 && percent<=70: document.getElementById('grade').innerHTML='D Grade';
        break;
        case percent>=71 && percent<=80: document.getElementById('grade').innerHTML='C Grade';
        break;
        case percent>=81 && percent<=90: document.getElementById('grade').innerHTML='B Grade';
        break;
        case percent>=91 && percent<=100: document.getElementById('grade').innerHTML='A Grade';
        break;
        default: document.getElementById('grade').innerHTML='Failed';
    }

    
}