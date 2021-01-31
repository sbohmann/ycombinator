export default function yCombine(makeF) {
    let y = y => makeF((...x) => y(y)(...x))
    return y(y)
}
