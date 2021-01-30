export default function endRecursiveFibonacci(n) {
    let makeF = f => (x, acc) => {
        if (x === 1) {
            return acc + 1
        } else {
            return f(x - 1, acc + x)
        }
    }

    let y = y => makeF((x, acc) => y(y)(x, acc))

    return y(y)(n, 0)
}
