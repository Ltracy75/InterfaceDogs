using InterfaceDogs;

var fred = new Mut();
var roxy = new Bully();
var beans = new Boxer();

Idog[] dogs = { fred, roxy, beans};

foreach (var dog in dogs)
    {
    Console.WriteLine($"Name {dog.Name}, is {dog.Color} and {(dog.IsLarge ? "Large" : "small")} " +
        $" and makes the sound {dog.Bark()}");
    }
Console.WriteLine("Boxers really be loud with them barks");
