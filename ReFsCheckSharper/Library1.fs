namespace ReFsCheckSharper

open FsCheck
open FsCheck.Xunit


/// This is the single FsCheck property test in the project.

[<Properties>]
module ReproProperty =

    [<Property>]
    let anyOldIntTest (x:int) =
        x > 10
