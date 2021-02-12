module delegateFibonacci

type Y = delegate of Y -> (int -> int)

let delegateFibonacci n =
    let makeF f: int -> int =
        fun x ->
            if x = 0 then 0 else if x = 1 then 1 else f(x - 1) + f(x - 2)
    let y (y: Y) = fun x -> (makeF (y.Invoke  y)) x
    (y (Y y)) n
