const h1 = document.querySelector('.container h1');

const data = new Date();

let options = {dateStyle: 'full'};

h1.innerHTML = data.toLocaleDateString('pt-BR', options);