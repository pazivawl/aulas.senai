let numerodealunos = 10;

for (let contador = 0; contador <= numerodealunos; contador++){
    //console.log(contador)
    if(contador == 0){
        console.log("o numero atual é zero");
    }else if (contador % 2 == 0){
        console.log("o numero " + contador + " é par")
    }else {
        console.log("o numero " + contador + " é impar")
    }
}
let nomedealunos = ["Caique","Thiago","odirlei","Jessica"]
   
for (let nome of nomedealunos){
        console.log(`Esta pessoa se chama ${nome}`)
    }