// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10,20);
Square s =new Square(10);
// TODO: Exercise the ToString() method
Console.WriteLine($"{c}");
Console.WriteLine($"{r}");

// TODO: Use the "is" operator to test an object type

Console.WriteLine($"{c is Shape2D}");
Console.WriteLine($"{c is Rectangle}");

// TODO: Call the GetArea() function on each one
Console.WriteLine(s.getArea());
Console.WriteLine(c.getArea());
Console.WriteLine(r.getArea());

// TODO: Print the area of each shape-->this will be used instead of the call in ln:18-20
void PrintArea(Shape2D sh){
    Console.WriteLine($"{sh.getArea()}");
}

// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 
PrintArea(c);
PrintArea(r);
PrintArea(s);
