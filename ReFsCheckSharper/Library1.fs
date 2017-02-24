namespace ReFsCheckSharper

open FsCheck
open FsCheck.Xunit


[<Properties>]
module ReproProperty =

    [<Property>]
    let anyOldIntTest (x:int) =
        x > 10
