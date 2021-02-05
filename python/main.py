from fibonacci import fibonacci
from generic import generic


def make_fibonacci(f):
    def result(x):
        if x == 0:
            return 0
        elif x == 1:
            return 1
        else:
            return f(x - 1) + f(x - 2)
    return result


for n in range(0, 10):
    print(n, fibonacci(n), generic(make_fibonacci)(n))