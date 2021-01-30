export default n => {
    return (y => y(y))(y => (f => (x, acc) => (x === 1 ? acc + 1 : f(x - 1, acc + x)))((x, acc) => y(y)(x, acc)))(n, 0)
}
