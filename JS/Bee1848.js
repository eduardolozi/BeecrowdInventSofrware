var input = require("fs").readFileSync("/dev/stdin", "utf8");
var lines = input.split("\n");

let numero = 0;
let index = 0;
let loteria = [];

for (let i = 0; i < lines.length; i++) {
  if (lines[i] === "--*") numero++;
  else if (lines[i] === "-*-") numero += 2;
  else if (lines[i] === "*--") numero += 4;
  else if (lines[i] === "-**") numero += 3;
  else if (lines[i] === "**-") numero += 6;
  else if (lines[i] === "*-*") numero += 5;
  else if (lines[i] === "***") numero += 7;
  else {
    loteria[index] = numero;
    index++;
    if (index == 3) break;
    numero = 0;
  }
}

console.log(loteria[0] + "\n" + loteria[1] + "\n" + loteria[2]);