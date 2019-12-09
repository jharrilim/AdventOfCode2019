module Day.Two

open System
open System.IO

let dayPath = __SOURCE_DIRECTORY__

let txt =
    Path.Combine [| dayPath; "ProgramCodes.txt" |]
    |> File.ReadLines
    |> Seq.item 0

let input =
    txt.Split(",")
    |> Seq.map Convert.ToInt32
    |> List.ofSeq

let codeBuilder codes resultPtr result =
    // if resultPtr = 0 then
    //     (seq {
    //         yield result
    //         yield! List.skip 1 codes
    //      }
    //      |> Seq.toList)
    // else
    (seq {
        yield! List.truncate resultPtr codes
        yield result
        yield! List.skip (resultPtr + 1) codes
     }
     |> Seq.toList)


let computer program =
    let rec calc (codes: list<int>) i =
        if i < codes.Length - 3 then
            let p1 = codes.[codes.[i + 1]]
            let p2 = codes.[codes.[i + 2]]
            let resultPtr = codes.[codes.[i + 3]]
            match codes.[i] with
            // 1: add the values in position 1 and 2, and then put them into 3
            | code when code = 1 -> calc <| codeBuilder codes resultPtr (p1 + p2) <| (i + 4)
            // 2: multiply the values in position 1 and 2, and then put them into 3
            | code when code = 2 -> calc <| codeBuilder codes resultPtr (p1 * p2) <| (i + 4)
            | _ -> calc codes (i + 1)
        else
            codes
    calc program 0


let output =
    let inp =
        Seq.toList
            (seq {
                yield! List.take 1 input
                yield 12
                yield 2
                yield! List.skip 3 input
             })
    computer inp
