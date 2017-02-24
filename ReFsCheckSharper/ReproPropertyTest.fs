namespace ReFsCheckSharper

open System
open FsCheck
open FsCheck.Xunit

[<Properties>]
module ReproPropertyTest =

    [<Property>]
    let anyOldIntTest (x:int) =
        // This is the sole test in this project.
        x <= Int32.MaxValue && x >= Int32.MinValue
