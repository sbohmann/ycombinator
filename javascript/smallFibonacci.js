export default function(n) {
    let makeF = f => x => (x < 3 ? 1 : f(x - 1) + f(x - 2))

    let y = y => makeF(x => y(y)(x))

    return y(y)(n)
}
