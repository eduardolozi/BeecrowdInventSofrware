var input = require("fs").readFileSync("/dev/stdin", "utf8");
let ddd = parseInt(input);

class Estado {
  constructor(ddd, nome) {
    this.ddd = ddd;
    this.nome = nome;
  }
}

let estadosDDD = [e1 = new Estado(61, "Brasilia"),
                  e2 = new Estado(71, "Salvador"),
                  e3 = new Estado(11, "Sao Paulo"),
                  e4 = new Estado(21, "Rio de Janeiro"),
                  e5 = new Estado(32, "Juiz de Fora"),
                  e6 = new Estado(19, "Campinas"),
                  e7 = new Estado(27, "Vitoria"),
                  e8 = new Estado(31, "Belo Horizonte")];

let aux = 0;
for (let i = 0; i < estadosDDD.length; i++) {
  if (ddd == estadosDDD[i].ddd) {
    console.log(estadosDDD[i].nome);
    aux++;
    break;
  }
} 

if (aux == 0) {
  console.log("DDD nao cadastrado");
}
