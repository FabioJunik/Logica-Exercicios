
function gerarTabuada()
{

    let numero= document.getElementById("num");
    let sel= document.getElementById('selTabuada');

    if(numero.value.length == 0)
        alert("Informe o númrero para poder continuar");
    
    else
    {
        let num= Number(numero.value);

        sel.innerText="";
        for(var i=1; i < 11; i++)
        {
            let item= document.createElement("option");
            item.text=`${num} x ${i} = ${num*i}`;

            sel.appendChild(item);
        }
    }
}