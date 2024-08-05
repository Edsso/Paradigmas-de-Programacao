let vetor = [0..20]

let resultado =
    vetor
    |> List.filter (fun x -> x % 2 = 0)     // Filtra os valores pares
    |> List.map (fun x -> x * 2)            // Multiplica cada valor por 2
    |> List.filter (fun x -> x % 6 = 0)     // Filtra os múltiplos de 6

printfn "Resultado: %A" resultado