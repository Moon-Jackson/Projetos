window.alert('Are you calculating?')

var n1 = document.querySelector('#n1')
var n2 = document.querySelector('#n2')
var resultado = document.querySelector('span')

function Somar(){
    resultado.innerHTML = parseFloat(n1.value) + parseFloat(n2.value)
}

function Subtrair(){
    resultado.innerHTML = parseFloat(n1.value) - parseFloat(n2.value)
}

function Multiplicar(){
    resultado.innerHTML = parseFloat(n1.value) * parseFloat(n2.value)
}

function Dividir(){
    resultado.innerHTML = parseFloat(n1.value) / parseFloat(n2.value)
}