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
printfn "My friends list are: %O" friends
//add element to the head of the list
let newFriends = "Luisa" :: friends
printfn "My new friends list is %O" newFriends




let x = System.Console.ReadLine()
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0
     // return an integer exit code
