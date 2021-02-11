open System

open fibonacci

[<EntryPoint>]
let main argv =
    for n in 0..9 do
        Console.WriteLine $"{n} {fibonacci n}"
    0
