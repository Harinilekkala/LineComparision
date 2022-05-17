// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
LineComparision.lineclass linecomparison = new LineComparision.lineclass();
double length1 = linecomparison.getLength(2, 3, 2, 8);
double length2 = linecomparison.getLength(2, 5, 2, 6);  
Console.WriteLine("length of the given line is" + length1,length2);
Console.WriteLine(length1.Equals(length2));
Console.WriteLine(length1.CompareTo(length2));
if (length1.CompareTo(length2) > 0)
    Console.WriteLine("The line one is greater than line two");
else if (length1.CompareTo(length2) < 0)
    Console.WriteLine("The line 2 is greater than line 1");
else
    Console.WriteLine("Both lines are same");
