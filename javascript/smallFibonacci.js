export default function(n) {
    let makeF = f => x => (x === 1 ? 1 : f(x - 1) + x)

    let y = y => makeF(x => y(y)(x))

    return y(y)(n)
}
