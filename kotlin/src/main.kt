private fun makeFibonacci(f: (Int) -> Int): (Int) -> Int {
    return { x ->
        when (x) {
            0 -> 0
            1 -> 1
            else -> f(x - 1) + f(x - 2)
        }
    }
}

fun main() {
    for (n in 0..10) {
        println("" + n + ": " + fibonacci(n) + " " + generic(::makeFibonacci)(n))
    }
}
