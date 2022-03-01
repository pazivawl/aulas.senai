let prompt = require('prompt-sync')();


console.log("escolha um evento: programacao, geografia, biologia")
var evento =prompt()
if(evento === "programacao"){
    console.log("você escolheu programação")
} else if(evento === "geografia"){
    console.log("você escolheu geografia")
}else if(evento === "biologia"){
    console.log("você escolheu biologia")
}else {
    console.log("evento nao existente")
    
}


var numerodeparticipamtes = 101 
if(numerodeparticipamtes < 100){
console.log("Permiti cadastro")
}else{
    console.log("cadastro nao sera permitido por ter excedido o limite de participantes")
}


console.log("qual a sua idade?")
var idade =prompt()
if(idade >=18){
console.log("idade permitida")
}else{
    console.log("você não tem idade suficiente para esse evento")
}


console.log("qual e a data atual?")
var data = 09/03/2022
var data1 = prompt()
if(data1 > data ){
    console.log("sinto muito o evento não esta mais disponivel")
}else{
    console.log( "cadastro confirmado",)
}


