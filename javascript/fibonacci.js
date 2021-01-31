export default function fibonacci(n) {
    let makeF = f => x => {
        if (x < 3) {
            return 1
        } else {
            return f(x - 1) + f(x - 2)
        }
    }

    let y = y => makeF(x => y(y)(x))

    return y(y)(n)
}
