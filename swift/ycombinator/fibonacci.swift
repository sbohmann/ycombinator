import Foundation

struct AutoFunction {
    let y: (AutoFunction) -> (Int) -> Int
}

func fibonacci(n: Int) -> Int {
    func makeF(f: @escaping (Int) -> Int) -> (Int) -> Int {
        {x in
            switch x {
            case 0: return 0
            case 1: return 1
            default: return f(x - 1) + f(x - 2)
            }
        }
    }

    func y(y: AutoFunction) -> (Int) -> Int {
        makeF {x in y.y(y)(x)}
    }

    return y(y: AutoFunction(y: y))(n)
}
