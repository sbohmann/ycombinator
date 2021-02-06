(defn fibonacci [n]
  (let [makeF (fn [f]
                (fn [x]
                  (cond
                   (= x 0) 0
                   (= x 1) 1
                   :else   (+ (f (- x 1)) (f (- x 2))))))]
    (let [y (fn [y] (fn [x] ((makeF (y y)) x)))]
      ((y y) n))))

(doseq [n (range 0 10)]
  (.println System/out (str n \space (fibonacci n))))
