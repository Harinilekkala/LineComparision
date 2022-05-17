// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
LineComparision.lineclass linecomparison = new LineComparision.lineclass();
double length1 = linecomparison.getLength(2, 3, 2, 8);
double length2 = linecomparison.getLength(2, 5, 2, 6);  
Console.WriteLine("length of the given line is" + length1,length2);
Console.WriteLine(length1.Equals(length2));

