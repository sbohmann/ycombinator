export default function endRecursiveFibonacci(n) {
    let makeF = f => (n, a, b) => {
        switch (n) {
            case 0:
                return a
            case 1:
                return b
            default:
                return f(n - 1, b, a + b)
        }
    }

    let y = y => makeF((n, a, b) => y(y)(n, a, b))

    return y(y)(n, 0, 1)
}
