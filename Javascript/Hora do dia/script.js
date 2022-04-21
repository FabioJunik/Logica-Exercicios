var hora= document.getElementById("hora");
var tempo= document.getElementById("tempo");

let horaAct= new Date().getHours()

hora.innerText= "Agora são "+horaAct+".";

if(horaAct >5 && horaAct <12)
    tempo.style.backgroundImage= "url(img/dia.jpg)";

else if(horaAct >11 && horaAct <18)
    tempo.style.backgroundImage= "url(img/tarde.jpg)";

else 
    tempo.style.backgroundImage= "url(img/noite.jpg)";