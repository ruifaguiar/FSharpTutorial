

//Square
printfn("-----------------Square function ------------------------")
let anInt = 5
let square n = n * n
//Call the function to calculate the square of a number
let result = square anInt
printfn "The result of square of %d is %d" anInt result

printfn("-----------------Recursive function ------------------------")

//Factorial -> See that the rec indicates that this function is recursive
let rec factorial n = 
    if n=0
    then 1
    else n * factorial (n-1)
printfn "The result of Factorial of 15 is %d" (factorial 15)

printfn("-----------------Tuple ------------------------")
//Tuple
let turnChoices = ("right","left")
printfn "%O" turnChoices

printfn("-----------------Lists ------------------------")
//List
let friends = ["João";"Pedro";"Rita";"Berta";"Raquel"]
printfn "My friends list are: %A" friends
//add element to the head of the list
let newFriends = "Luisa" :: friends
printfn "My new friends list is %A" newFriends

let firstHundred = [0..100]
let doubledList = List.map(fun x->x*2)firstHundred
printfn "The new List is %A" doubledList
let evenList = List.filter(fun x->x%2=0)doubledList
printfn "The Module List is %A" (evenList)

printfn("-----------------Pipes ------------------------")
//Pipe Operator
let resultWithPipeOperator=
    [0..100]
    |>List.map(fun x->x*2)
    |>List.filter(fun x->x%2=0)
printfn "The result of pipe operator is %A" resultWithPipeOperator

printfn("-----------------Using Classes and Namespaces ------------------------")
//using Class and namespace located in another file
open Persons.Person
let p1 = Person("John",43)
let p2 = Person("Carie")
p2.Age<-15
p2.HasBirthday()
p1.HasBirthday()
System.Console.WriteLine(p1.ToString())
System.Console.WriteLine(p2.ToString())

printfn("-----------------Lambda Functions ------------------------")
//Lambda Functions
let addLambda = (fun x y -> x+y)
printfn "the addLambda of 2+2 is %d" (addLambda 2 2)

//Passing a anonymous function to twotest function
let twotest test = 
    test 2
printfn "Is 2 > 0? %b"( twotest (fun x-> x > 0))

printfn("-----------------Currying ------------------------")

//Currying
let add x y = x+y
let inc = add 1
let anotherInc x = add 1 x
printfn "%d is the same as %d" (inc 1) (anotherInc 1)


let searchEven = Seq.filter (fun v -> v % 2 = 0)
printfn "%d even numbers in [1, 100]" 
    ([ 1 .. 100] |> searchEven |> Seq.length)
printfn "%d even numbers in [1, 1000]" 
    ([ 1 .. 1000] |> searchEven |> Seq.length)

open System.Text.RegularExpressions
//test match
let (^?) a b = Regex.IsMatch(a, b)
// perform a match and returns match info
let (^!) a b = Regex.Match(a, b)
// Query the number of matches
let (!@) (a:Match) = a.Groups.Count - 1
// Access the nth match (1 based, equivalent of $1..$n notation)
let (^@) (a:Match) (b:int) = a.Groups.[b].Value

let input = "F# 3.0 is a very cool programming language"
if input ^? @"F# [\d\.]+" then
  let m = input ^! @"F# ([\d\.]+)"
  printfn "matched %d groups and the F# version is %s" 
     !@m (m^@1)



let x = System.Console.ReadLine()
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0
     // return an integer exit code
