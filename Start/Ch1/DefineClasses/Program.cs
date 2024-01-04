// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle r1= new Rectangle(20);
Rectangle r2= new Rectangle(20,15);

Console.WriteLine(r1.GetArea());
Console.WriteLine(r2.GetType());
// TODO: Change the values of width and height

r1.width=15;
r1.height=30;
Console.WriteLine(r1.GetArea());
