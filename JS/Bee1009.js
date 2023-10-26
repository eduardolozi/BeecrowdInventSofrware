let input = require('fs').readFileSync('/dev/stdin', 'utf8');
let lines = input.split('\n');

let nome = lines[0];
let salarioInicial = parseFloat(lines[1]);
let vendas = parseFloat(lines[2]);
let salarioFinal = salarioInicial + (vendas * 0.15);
console.log(`TOTAL = R$ ${salarioFinal.toFixed(2)}`);
