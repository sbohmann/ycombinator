import fibonacci from './fibonacci.js'
import smallFibonacci from './smallFibonacci.js'
import tinyFibonacci from './tinyFibonacci.js'
import endRecursiveFibonacci from './endRecursiveFibonacci.js'
import endRecursiveTinyFibonacci from './endRecursiveTinyFibonacci.js'

import yCombine from './generic.js'
import tinyYCombine from './tinyGeneric.js'

console.log(fibonacci(6))
console.log(smallFibonacci(7))
console.log(tinyFibonacci(8))

// Attention! For demonstration purposes only.
// To my knowledge, end recursion optimization is not
// currently widespread among javascript engines.
// please, use loops for large numbers in real projects.
console.log(endRecursiveFibonacci(9))
console.log(endRecursiveTinyFibonacci(10))

let makeF = f => x => (x < 3 ? 1 : f(x - 1) + f(x - 2))
console.log(yCombine(makeF)(11))
console.log(tinyYCombine(makeF)(12))
