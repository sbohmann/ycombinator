def generic(make_f):
    def y(y):
        return make_f(lambda x: make_f(y(y))(x))
    return y(y)
