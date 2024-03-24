using VectorLibrary;

Console.WriteLine("Hello, Vectors!");
Vector3 one = new Vector3(1, 1, 1);
Vector3 two = new Vector3(2, 2, 2);


Vector3 three = Vector3.Add(one, two);
Console.WriteLine("one.X " + one.X + ",one.Y " + one.Y + ",one.Z " + one.Z);
Console.WriteLine($"two.X: {two.X},two.y:{two.Y}, two.z:{two.Z}");
Console.WriteLine($"<{three.X},{three.Y},{three.Z}>");
Console.WriteLine($"Magnitude of three: {Vector3.Length(three)}");

one.Subtract(two);
Console.WriteLine("one.X " + one.X + ",one.Y " + one.Y + ",one.Z " + one.Z);

one.Add(two);

Console.WriteLine($"Magnitude of three: {three.Magnitude}");
