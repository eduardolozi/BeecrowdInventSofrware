var input = require("fs").readFileSync("/dev/stdin", "utf8");
var lines = input.split(" ");

let a = parseFloat(lines[0]);
let b = parseFloat(lines[1]);
let c = parseFloat(lines[2]);

if (a + b > c && a + c > b && b + c > a) {
  let perimetro = a + b + c;
  console.log(`Perimetro = ${perimetro.toFixed(1)}`);
} else {
  let area = ((a + b) * c) / 2.0;
  console.log(`Area = ${area.toFixed(1)}`);
}