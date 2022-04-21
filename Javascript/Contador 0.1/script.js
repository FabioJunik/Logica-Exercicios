
function executar()
{


    let inicio= document.getElementById("inicio").value;
    let fim= document.getElementById("fim").value;
    let passo= document.getElementById("passo").value;
    
    let ini = Number (inicio);
    let fi= Number(fim);
    let pass = Number (passo);
    
    
    let frase= document.getElementById("p");
    let res= document.getElementById("res");

    res.innerText= "";

    if(inicio.length ==0 || fim.length ==0 || passo.length ==0)
        alert("Por favor preencha todos os dados para continuar");

    else
    {
        frase.innerText ="Contando:";
        
        if(ini<fi)
            for(var i= ini; i<=fi ; i+=pass)
            {
                res.innerText+= i+"\u{1f449}";
                console.log(i);
            
            }
        else
            for(var i= fi; i<=ini ; i-=pass)
            {
                res.innerText+= i+"\u{1f449}";
                console.log(i);
            
            }
        
    }


}