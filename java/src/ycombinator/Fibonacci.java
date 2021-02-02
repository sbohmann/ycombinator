package ycombinator;

import java.util.function.Function;
import java.util.function.UnaryOperator;

public class Fibonacci {
    private UnaryOperator<Integer> makeF(Function<Integer, Integer> f) {
        return x -> {
            if (x == 0) {
                return 0;
            } else if (x <= 2) {
                return 1;
            } else {
                return f.apply(x - 1) + f.apply(x - 2);
            }
        };
    }
    
    private UnaryOperator<Integer> y(AutoFunction<Integer, Integer> y) {
        return makeF(x -> y.apply(y).apply(x));
    }
    
    public int call(int n) {
        return y(this::y).apply(n);
    }
}
