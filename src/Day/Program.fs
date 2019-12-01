module Day.Program
open System

let line =
    String.replicate 80 "-"

[<EntryPoint>]
let main argv =
    printfn "%s" line
    printfn "# Day One:"
    printfn "%s" line
    printfn "## Input:"
    printfn "%A" <| Seq.toList Day.One.input
    printfn "%s" line
    printfn "## Part One:"
    // 3348430
    printfn "Output: %f" Day.One.PartOne.output
    printfn "%s" line
    printfn "Part Two:"
    // 5019767
    printfn "Output: %f" Day.One.PartTwo.output
    printfn "%s" line
    0
