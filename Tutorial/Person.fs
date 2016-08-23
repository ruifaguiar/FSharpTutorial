namespace Persons

module Person=
    type Person(name:string, age:int)=
        let mutable internalAge = age
   
        new (name:string)=Person(name,0)

        member this.Name=name

        member this.Age
            with get()=internalAge
            and set(value)=internalAge<-value
    
        member this.HasBirthday () = internalAge<- internalAge+1

        member this.IsOfAge targetAge=internalAge>=targetAge

        override this.ToString()=
            "Name: "+name + " Age: "+ string(internalAge)