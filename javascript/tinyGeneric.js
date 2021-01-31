export default makeF => (y => y(y))(y => makeF((...x) => y(y)(...x)))
