import Foundation

typealias F = (Int) -> Int

func makeFibonacci(f: @escaping F) -> F {
    { x in
        switch x {
        case 0: return 0
        case 1: return 1
        default: return f(x - 1) + f(x - 2)
        }
    }
}

for n in 0..<10 {
    print(n, fibonacci(n: n), generic(makeF: makeFibonacci)(n))
}
