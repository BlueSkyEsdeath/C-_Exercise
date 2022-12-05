string name = "Tuan";
Console.WriteLine("Hello," + name + " : " + name.Length);
Console.WriteLine(string.Format("Hello, {0} : {1} - {2}" , name, name.Length, "sa"));
Console.WriteLine($"Hello, {name} : {name.Length} - {name}");
name = name + $" : {name.Length}";
Console.WriteLine(name);
