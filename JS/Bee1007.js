let input = require("fs").readFileSync("/dev/stdin", "utf8");
let lines = input.split("\n");

let a = lines[0];
let b = lines[1];
let c = lines[2];
let d = lines[3];

console.log(`DIFERENCA = ${a * b - c * d}`);
