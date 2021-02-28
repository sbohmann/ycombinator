fun generic(makeF: (f: (Int) -> Int) -> (Int) -> Int): (Int) -> Int {
    data class Y(val call: (Y) -> (Int) -> Int)

    val y = { y: Y ->
        { x: Int ->
            makeF(y.call(y))(x)
        }
    }

    return y(Y(y))
}
