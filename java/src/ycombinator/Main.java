package ycombinator;

import java.util.function.Function;

class Main {
    public static void main(String[] args) {
        new Main().run();
    }
    
    private void run() {
        Fibonacci fibonacci = new Fibonacci();
        Generic<Integer, Integer> generic = new Generic<>(this::makeFibonacci);
        for (int n = 0; n < 10; ++n) {
            System.out.println(n + " " + fibonacci.call(n) + " " + generic.call(n));
        }
    }
    
    Function<Integer, Integer> makeFibonacci(Function<Integer, Integer> f) {
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
}
