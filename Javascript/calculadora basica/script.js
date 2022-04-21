
calc =()=>{

    let valores = document.getElementsByName("valor");
    let sinal = document.getElementById("operacao").value;
    

    let n1= Number(valores[0].value);
    let n2= Number(valores[1].value);


    if(sinal=="+")
        alert("A soma sera de: "+(n1+n2));

    else if(sinal=="-")
        alert("A subtração sera de: "+(n1-n2));
    else if(sinal=="*" || sinal =="x")
        alert("A multiplicação sera de: "+n1*n2);
    else if(sinal=="/")
        alert("A divisão sera de: "+n1/n2);
    else 
        alert("Sinal invalido!\nTente novamente.");

} 