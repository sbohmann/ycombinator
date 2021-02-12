open System

open fibonacci
open generic

let makeFibonacci f: int -> int =
    fun x ->
        if x = 0 then 0 else if x = 1 then 1 else f(x - 1) + f(x - 2)

[<EntryPoint>]
let main argv =
    for n in 0..9 do
        Console.WriteLine $"{n} {fibonacci n} {(combine makeFibonacci) n}"
    0
