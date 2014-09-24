module FB

    let fizzBuzz (x) =
        let fizzable (y) = y % 3 = 0
        let buzzable (y) = y % 5 = 0

        match x with
        | _ when (fizzable x && buzzable x) -> "fizz buzz"
        | _ when (fizzable x) -> "fizz"
        | _ when (buzzable x) -> "buzz"
        | _ -> x.ToString()