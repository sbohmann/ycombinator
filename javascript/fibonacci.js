export default function fibonacci(n) {
    let makeF = f => x => {
        if (x === 1) {
            return 1
        } else {
            return f(x - 1) + x
        }
    }

    let y = y => makeF(x => y(y)(x))

    return y(y)(n)
}
