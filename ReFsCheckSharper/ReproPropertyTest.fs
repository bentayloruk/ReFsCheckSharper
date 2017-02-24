namespace ReFsCheckSharper

open System
open Xunit
open FsCheck
open FsCheck.Xunit

module PlainOldXunitFacts = 

    [<Fact>]
    let assertSomething () =
        Assert.Equal(1,1)

[<Properties>]
module ReproPropertyTest =

    [<Property>]
    let anyOldIntTest (x:int) =
        // This is the sole test in this project.
        x <= Int32.MaxValue && x >= Int32.MinValue
