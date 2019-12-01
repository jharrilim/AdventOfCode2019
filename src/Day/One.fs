module Day.One

open System
open System.IO

let kestrel x y =
    y x
    x

let dayPath = __SOURCE_DIRECTORY__

let input =
    Path.Combine [| dayPath; "ModuleMasses.txt" |]
    |> File.ReadAllLines
    |> Seq.map Convert.ToDouble

let moduleFuel mass =
    mass / 3.0
    |> floor
    |> fun m -> m - 2.0

/// G)
///     Elves = {e| e is elf and e is Go until Fuel Counter-Upper} 
///     ModuleMasses = {m| m is ℝ and m > 0}
/// U)
///     SumOfFuelRequirementsForAllModules = ?
/// E)
///     ModuleFuel = Floor(mass / 3) - 2
module PartOne =
    let output = Seq.sumBy moduleFuel input


module PartTwo =
    let rec calc mass =
        let tot = moduleFuel mass
        match tot with
        | tot when tot > 0.0 -> tot + calc tot
        | _ -> 0.0

    let output = Seq.sumBy calc input
