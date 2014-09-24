module FizzBuzz.Tests.``A game of bowling``

open NUnit.Framework
open FsUnit

[<Test>] 
let ``1 should return 1`` () =
    FB.fizzBuzz 1 |> should equal "1"

[<Test>] 
let ``2 should return 2`` () =
    FB.fizzBuzz 2 |> should equal "2"

[<Test>] 
let ``3 should return fizz`` () =
    FB.fizzBuzz 3 |> should equal "fizz"

[<Test>] 
let ``5 should return buzz`` () =
    FB.fizzBuzz 5 |> should equal "buzz"

[<Test>] 
let ``6 should return fizz`` () =
    FB.fizzBuzz 6 |> should equal "fizz"

[<Test>] 
let ``15 should return fizz buzz`` () =
    FB.fizzBuzz 15 |> should equal "fizz buzz"