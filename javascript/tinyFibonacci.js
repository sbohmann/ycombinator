export default n => {
    return (y => y(y))(y => (f => x => (x < 3 ? 1 : f(x - 1) + f(x - 2)))(x => y(y)(x)))(n)
}
