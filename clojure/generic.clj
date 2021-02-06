(defn generic [makeF]
  (let [y (fn [y] (fn [x] ((makeF (y y)) x)))]
    (y y)))
