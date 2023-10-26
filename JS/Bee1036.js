var input = require("fs").readFileSync("/dev/stdin", "utf8");
var lines = input.split(" ");

let a = parseFloat(lines[0]);
let b = parseFloat(lines[1]);
let c = parseFloat(lines[2]);
let delta = (b * b) - (4 * a * c);


if (a===0 || delta < 0) {
  console.log("Impossivel calcular");
} else {
  let raiz1 = (-b + Math.sqrt(delta)) / (2 * a);
  let raiz2 = (-b - Math.sqrt(delta)) / (2 * a);
  console.log(`R1 = ${raiz1.toFixed(5)}`);
  console.log(`R2 = ${raiz2.toFixed(5)}`);
}