export default function yCombine(makeF) {
    return (y => y(y))(y => makeF(x => y(y)(x)))
}
