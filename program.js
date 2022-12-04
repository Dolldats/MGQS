let words = 'African Journal';

let a = words.substring(0, 7);
let b = words.substring(7);


var newA = '';
var newB = '';

for (let i = 0; i < a.length - 1; i++) {

    if (i % 2 == 0) {
        newA += a[i];
        newA += b[i];
    }
}
newA += a[a.length - 1];

for (let i = 0; i < b.length - 1; i++) {

    if (i % 2 != 0) {
        newB += a[i];
        newB += b[i];
    }
}
newB += b[b.length - 1];


let encode = newB.concat(newA);
console.log(encode);

let c = encode.substring(7);
let d = encode.substring(0, 7);

var newC = '';
var newD = '';

for (let i = 0; i < c.length - 1; i++) {
    if (i % 2 == 0) {
        newC += c[i];
        newC += d[i];
    }
}
newC += c[c.length - 1];



let decode = newC.concat(newD);
console.log(decode);
