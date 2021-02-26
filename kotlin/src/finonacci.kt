data class Y(val call: (Y) -> (Int) -> Int)

fun fibonacci(n: Int): Int {
    fun makeF(f: (Int) -> Int) = fun (x: Int): Int {
        return if (x < 3) 1 else f(x - 1) + f(x - 2)
    }

    fun y(y: Y): (Int) -> Int {
        return fun(x: Int) = makeF(y(y))(x)
    }

    return y(Y(::y))(n)
}
