def fibonacci(n):
    def make_f(f):
        def result(x):
            if x == 0:
                return 0
            elif x == 1:
                return 1
            else:
                return f(x - 1) + f(x-2)
        return result

    def y(y):
        return make_f(lambda x: make_f(y(y))(x))

    return y(y)(n)
