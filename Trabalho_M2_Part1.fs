let divisor a b =
    if a > b then
        a/b
    elif b > a then
        b/a
    else
        1

let a = 5
let b = 2

(* printfn "Digite o primeiro valor: "
let a = Console.ReadLine()

printfn "Digite o segundo valor: "
let b = Console.ReadLine() *)

let resultado = divisor a b
printfn "A divisão do maior pelo menor é: %i" resultado