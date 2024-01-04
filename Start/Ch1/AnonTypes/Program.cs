// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var Obj=new{
    name="reem",
    Age=25,
    Address=new{
        country="Jordan",
        city="Amman",
        street="hidaia"
    }
};

// Anonymous types are read-only and cannot be modified
// Obj.Name = "Jane Doe"; # will cause an error (you can't change it)
Console.WriteLine($"{Obj.name},{Obj.Address.city}");
Console.WriteLine($"{Obj}");
// TODO: To change a value, use non-destructive mutation and "with" clause
var Obj2= Obj with{name="hiba Abd"};//it'll copy the obj and change the variable in with
Console.WriteLine($"{Obj2}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{Obj2.GetType()}");
Console.WriteLine($"{Obj2.GetType().GetProperty("name")}");
Console.WriteLine($"{Obj2.GetType().GetProperty("job")}");//it won't print anything cause job doesn't exist
Console.WriteLine($"{Obj2.GetType().GetProperty("job")!= null}");//if st to check
