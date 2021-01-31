export default n => {
    return (y => y(y))(y => (f => (n, a, b) => (n === 0 ? a : n === 1 ? b : f(n - 1, b, a + b)))((n, a, b) => y(y)(n, a, b)))(n, 0, 1)
}
