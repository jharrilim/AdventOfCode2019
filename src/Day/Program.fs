module Day.Program

open System

let line = fun () -> String.replicate 80 "-" |> printfn "%s"

let dayOne =
    fun () ->
        line()
        printfn "# Day One:"
        line()
        printfn "## Input (%d):" <| Seq.length Day.One.input
        printfn "%A" <| Seq.toList Day.One.input
        line()
        printfn "## Part One:"
        // 3348430
        printfn "Output: %f" Day.One.PartOne.output
        line()
        printfn "Part Two:"
        // 5019767
        printfn "Output: %f" Day.One.PartTwo.output

let dayTwo =
    fun () ->
        line()
        printfn "# Day Two:"
        line()
        printfn "## Input (%d):" <| Day.Two.input.Length
        Seq.toList Day.Two.input |> Seq.iter (printf "%d ")
        printfn ""
        line()
        printfn "## Part One:"
        printfn "Output (%d):" <| Day.Two.output.Length
        Seq.toList Day.Two.output |> Seq.iter (printf "%d ")
        printfn ""
        line()

[<EntryPoint>]
let main argv =
    dayOne()
    dayTwo()

    0
