var input = require("fs").readFileSync("/dev/stdin", "utf8");
var lines = input.split(" ");

let a = parseFloat(lines[0]);
let b = parseFloat(lines[1]);
let c = parseFloat(lines[2]);

let areaTri = (a*c)/2.0;
let areaCir = 3.14159 * (c*c);
let areaTrap = ((a+b)*c)/2.0;
let areaQuad = b*b;
let areaRet = a*b;

console.log(`TRIANGULO: ${areaTri.toFixed(3)}`);
console.log(`CIRCULO: ${areaCir.toFixed(3)}`);
console.log(`TRAPEZIO: ${areaTrap.toFixed(3)}`);
console.log(`QUADRADO: ${areaQuad.toFixed(3)}`);
console.log(`RETANGULO: ${areaRet.toFixed(3)}`);