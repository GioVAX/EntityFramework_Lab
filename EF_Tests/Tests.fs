module Tests

open System
open Xunit
open EF_Lab
open FsUnit.Xunit

type EF_Lab() =
    let db = LabContext.CreateContext @"Data Source=.\SQLEXPRESS;Initial Catalog=EF_Lab;Integrated Security=True"

    [<Fact>]
    let ``I can Find a Principal`` () =
        let p = db.Principals.Find 1

        p.Name |> should equal "First"
