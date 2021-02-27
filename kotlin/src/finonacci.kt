fun fibonacci(n: Int): Int {
    data class Y(val call: (Y) -> (Int) -> Int)

    val makeF = { f: (Int) -> Int ->
        { x: Int ->
            when (x) {
                0 -> 0
                1 -> 1
                else -> f(x - 1) + f(x - 2)
            }
        }
    }

    val y = { y: Y ->
        { x: Int -> makeF(y.call(y))(x) }
    }

    return y(Y(y))(n)
}
