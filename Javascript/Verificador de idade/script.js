
function executar(){

    let data= new Date();
    var anoAct= data.getFullYear();
    let ano = document.getElementById("ano");

    let generos = document.getElementsByName("genero");
    let imagem= document.getElementById("pic");
    let res = document.getElementById("frase");

    imagem.style.display= "none";
    res.innerHTML="Preencha os dados acima para ver o resultado!";


    if(ano.value.length == 0)
        alert("Prencha os dados para continuar!");

    else if(ano.value > anoAct || ano.value <0)
        alert("Ano de nascimento invalido!\nVerifique e tente novamente")

    else
    {
        let idade= anoAct - ano.value;

        for(let i=0;i< generos.length;i++)
        {
            if(generos[i].checked)
            {   
                imagem.style.display= "block";
                
                if(generos[i].value =="h")
                {
                    res.innerHTML="Detectamos um homem com "+idade+" de idade";
                    
                    if(idade < 10){
                        imagem.style.backgroundImage="url(img/h5.jpg)";
                    }
                    else if(idade < 20)
                        imagem.style.backgroundImage="url(img/h10.jpg)";

                    else if(idade < 40)
                        imagem.style.backgroundImage="url(img/h25.jpg)";
                        
                    else if(idade < 110)
                        imagem.style.backgroundImage="url(img/h50.jpg)";
                else
                    imagem.style.backgroundImage="url(img/question.jpg)";

                }
                else if(generos[i].value =="m")
                {
                    res.innerHTML="Detectamos uma mulher com "+idade+" de idade";
                    
                    if(idade < 10){
                        imagem.style.backgroundImage="url(img/m5.jpg)";
                    }
                    else if(idade < 22)
                        imagem.style.backgroundImage="url(img/m15.jpg)";
                    else if(idade < 30)
                        imagem.style.backgroundImage="url(img/m10.jpg)";

                    else if(idade < 40)
                        imagem.style.backgroundImage="url(img/m25.jpg)";
                    
                    else if(idade < 60)
                        imagem.style.backgroundImage="url(img/m40.jpg)";
                    else if(idade < 100)
                        imagem.style.backgroundImage="url(img/m50.jpg)";
                    else
                        imagem.style.backgroundImage="url(img/question.jpg)";
                }
            }
        }
    }

}