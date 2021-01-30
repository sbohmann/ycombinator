export default n => {
    return (y => y(y))(y => (f => x => (x === 1 ? 1 : f(x - 1) + x))(x => y(y)(x)))(n)
}
