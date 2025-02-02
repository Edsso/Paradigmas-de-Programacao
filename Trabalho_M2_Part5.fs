(*1*)
let rec produtoValoresImpares lista =
    match lista with
    | [] -> 1 // Se a lista estiver vazia, o produto é 1
    | head::tail when head % 2 <> 0 -> head * produtoValoresImpares tail // Se o primeiro elemento for ímpar, multiplicá-lo pelo produto do restante da lista
    | _::tail -> produtoValoresImpares tail // Se o primeiro elemento for par, ignorá-lo e continuar com o restante da lista

// Exemplo de uso
let lista = [1; 2; 3; 4; 5]
let produto = produtoValoresImpares lista
printfn "O produto dos valores ímpares em %A é %d" lista produto
(*1*)

(*2*)
let rec operacaoEspecial x y =
    match x, y with
    | _, 0 -> 1 // Qualquer número elevado a 0 é 1
    | _, 1 -> x // Qualquer número elevado a 1 é o próprio número
    | a, b when a = b -> 
        let rec multiplicacao valor n =
            if n = 0 then 0
            else if n = 1 then valor
            else valor + multiplicacao valor (n - 1)
        multiplicacao x y
    | a, b -> 
        let rec multiplicacao valor n =
            if n = 0 then 1
            else valor * multiplicacao valor (n - 1)
        multiplicacao a b

// Exemplo de uso
let resultado1 = operacaoEspecial 2 3 // Deve retornar 8 (2 * 2 * 2)
let resultado2 = operacaoEspecial 4 4 // Deve retornar 16 (4 * 4)
printfn "Resultado 1: %d" resultado1
printfn "Resultado 2: %d" resultado2
(*2*)

(*3*)
let isPrimo numero =
    // Função auxiliar para verificar se um número é divisível por algum outro número além de 1 e ele próprio
    let rec isDivisivelPor numero divisor =
        match numero, divisor with
        | n, d when d <= 1 -> false
        | n, d when d = 2 -> false
        | n, d when n % d = 0 -> true
        | n, d -> isDivisivelPor n (d - 1)

    // Função auxiliar para encontrar a raiz quadrada inteira de um número
    let rec raizQuadradaInteira n guess =
        match n, guess with
        | n, g when g * g <= n && (g + 1) * (g + 1) > n -> g
        | n, g -> raizQuadradaInteira n (g + 1)

    // Verifica se o número é divisível por algum número diferente de 1 e ele próprio
    match numero with
    | n when n <= 1 -> false // Números menores ou iguais a 1 não são primos
    | n when n = 2 -> true // 2 é um número primo
    | n -> not (isDivisivelPor n (raizQuadradaInteira n 1)) // Verifica se o número é divisível por algum número até a sua raiz quadrada

// Exemplo de uso
let numero1 = 17
let numero2 = 21
printfn "%d é primo? %b" numero1 (isPrimo numero1)
printfn "%d é primo? %b" numero2 (isPrimo numero2)
(*3*)

(*4*)
let rec somaPrimos lista =
    // Função auxiliar para filtrar os números primos em uma lista
    let rec filtrarPrimos listaPrimos listaOriginal =
        match listaOriginal with
        | [] -> listaPrimos
        | head::tail when isPrimo head -> filtrarPrimos (head::listaPrimos) tail
        | _::tail -> filtrarPrimos listaPrimos tail

    // Função auxiliar para calcular a soma dos elementos em uma lista
    let rec calcularSoma soma lista =
        match lista with
        | [] -> soma
        | head::tail -> calcularSoma (soma + head) tail

    // Filtra os números primos na lista original
    let primos = filtrarPrimos [] lista

    // Calcula a soma dos números primos filtrados
    calcularSoma 0 primos

// Exemplo de uso
let lista1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
let soma = somaPrimos lista
printfn "A soma dos valores primos em %A é %d" lista soma
(*4*)

