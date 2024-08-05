let classificar_Triangulo a b c =
    if a+b <= c || a+c <= b || b+c <= a then
        printfn "Nao forma um triângulo."

    elif a = b && b = c then
        printfn "Triângulo equilátero."

    elif a = b || b = c || a = c then
        printfn "Triângulo isósceles."

    else
        printfn "Triângulo escaleno."

let lado1 = 3
let lado2 = 5
let lado3 = 4

(* printfn "Digite o primeiro lado: "
    System.Console.ReadLine() |> float
printfn "Digite o segundo lado: "
    System.Console.ReadLine() |> float
printfn "Digite o terceiro lado: "
    System.Console.ReadLine() |> float *)

classificar_Triangulo lado1 lado2 lado3