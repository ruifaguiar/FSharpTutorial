

//Square
let anInt = 5
let square n = n * n
//Call the function to calculate the square of a number
let result = square anInt
printfn "The result of square of %d is %d" anInt result

//Factorial -> See that the rec indicates that this function is recursive
let rec factorial n = 
    if n=0
    then 1
    else n * factorial (n-1)
printfn "The result of Factorial of 15 is %d" (factorial 15)


//Tuple
let turnChoices = ("right","left")
printfn "%O" turnChoices

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

//Pipe Operator
let resultWithPipeOperator=
    [0..100]
    |>List.map(fun x->x*2)
    |>List.filter(fun x->x%2=0)
printfn "The result of pipe operator is %A" resultWithPipeOperator

//using Class and namespace located in another file
let p1 = Persons.Person.Person("John",43)
let p2 = Persons.Person.Person("Carie")
p2.Age<-15
p2.HasBirthday()
p1.HasBirthday()
System.Console.WriteLine(p1.ToString())
System.Console.WriteLine(p2.ToString())

//Lambda Functions
let add = (fun x y -> x+y)
printfn "the add of 2+2 is %d" (add 2 2)

//Passing a anonymous function to twotest function
let twotest test = 
    test 2
printfn "Is 2 > 0? %b"( twotest (fun x-> x > 0))






let x = System.Console.ReadLine()
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0
     // return an integer exit code
