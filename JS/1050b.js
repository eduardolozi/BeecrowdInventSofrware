var input = require("fs").readFileSync("/dev/stdin", "utf8");
let ddd = parseInt(input);

let estados = {
  61: "Brasilia",
  71: "Salvador",
  11: "Sao Paulo",
  21: "Rio de Janeiro",
  32: "Juiz de Fora",
  19: "Campinas",
  27: "Vitoria",
  31: "Belo Horizonte"
}

if (estados.hasOwnProperty(ddd)) {
  console.log(estados[ddd]);
} else console.log("DDD nao cadastrado");