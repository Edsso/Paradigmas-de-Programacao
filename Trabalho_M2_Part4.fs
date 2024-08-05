let resultadoNotas () =
    let lerNotas () =
        printfn "Digite a primeira nota: "
            let nota1 = 8  // float (System.Console.ReadLine())
        printfn "Digite a segunda nota: "
            let nota2 = 6  // float (System.Console.ReadLine())
        printfn "Digite a terceira nota: "
            let nota3 = 7  // float (System.Console.ReadLine())
        nota1, nota2, nota3

    let calcularMedia nota1 nota2 nota3 =
        (nota1 + nota2 + nota3) / 3.0

    let verificarNota media =
        if media >= 6.0 then
            true
        else
            false

    let escreverMensagem aprovado =
        if aprovado then
            printfn "Aluno aprovado."
        else
            printfn "Aluno reprovado."

    let nota1, nota2, nota3 = lerNotas()
    let media = calcularMedia nota1 nota2 nota3
    let aprovado = verificarNota media
    escreverMensagem aprovado

resultadoNotas()
