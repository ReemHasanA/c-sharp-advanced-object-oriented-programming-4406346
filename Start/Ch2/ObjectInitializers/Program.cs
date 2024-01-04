// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers
    Dog dog=new Dog{Name="popy",Age=4,IsTrained=true};
    Cat cat=new Cat{Name="me",Age=4,IsDeclawed=false};
    Console.WriteLine($"Dog:{dog.Name}");
    Console.WriteLine(dog.Name);
// TODO: Use the initializer syntax to create new objects
   

// TODO: Initializers can be used on anonymous types
    var pet =new {Name="coco"};
    Console.WriteLine(pet.Name);
// TODO: Collections can also be initialized this way
 int[] numbers= new int[]{1,2,3,4};
    Console.WriteLine(numbers.Length);


// TODO: Initialize a collection with a set of objects
    PetOwner owner= new PetOwner {
        Name="roro",
        Pets= new List<Pet>{
            new Dog{Name="John",Age=3,IsTrained=false},
            new Dog{Name="lolo"}
        }
    };
    Console.WriteLine(owner.Name+"'s pet:");
    foreach(Pet p in owner.Pets){
        Console.WriteLine(p.Name);
    }
