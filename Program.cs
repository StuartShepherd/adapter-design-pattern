using AdapterDesignPattern;

Console.WriteLine("Adapter Design Pattern");
Console.WriteLine("Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.");
Console.WriteLine();

var target = new Adapter(new Adaptee());

Console.WriteLine(target.DoRequest());
