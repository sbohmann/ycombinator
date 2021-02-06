(load-file "./fibonacci.clj")
(load-file "./generic.clj")

(defn makeFibonacci [f]
              (fn [x]
                (cond
                 (= x 0) 0
                 (= x 1) 1
                 :else   (+ (f (- x 1)) (f (- x 2))))))

(doseq [n (range 0 10)]
  (.println System/out (str n \space (fibonacci n) \space ((generic makeFibonacci) n))))
