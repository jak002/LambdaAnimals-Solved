
Dog d1 = new Dog("King", 25);
Dog d2 = new Dog("Tiny", 95);
Dog d3 = new Dog("Rufus", 36);
Dog d4 = new Dog("Spot", 55);
Dog d5 = new Dog("Daisy", 8);
List<Dog> dogs = new List<Dog> { d1, d2, d3, d4, d5 };

// Print out all Dogs with a weight larger than 40 kg.
Predicate<Dog> chonkyboi = d => d.Weight > 40;
//ConditionalPrint<Dog>(dogs, chonkyboi);

// Print out all Dogs with a weight smaller than Rufus' weight.
Predicate<Dog> smollerThanRufus = d => d.Weight < d3.Weight;
//ConditionalPrint<Dog>(dogs, smollerThanRufus);

// Print out all Dogs with a name that contains an "i"
Predicate<Dog> pupperHasAnI = d => d.Name.Contains('i');
//ConditionalPrint<Dog>(dogs, pupperHasAnI);

List<Predicate<Dog>> motherfuckers = new List<Predicate<Dog>> { smollerThanRufus, pupperHasAnI };
ConditionalPrint2(dogs, pupperHasAnI, smollerThanRufus);
MotherfuckerMethod<Dog>(dogs, motherfuckers);


static void ConditionalPrint<T>(List<T> objects, Predicate<T> pred)
{
    Console.WriteLine();
    foreach (var item in objects.FindAll(pred))
    {
        Console.WriteLine(item);
    }
}

static void ConditionalPrint2<T>(List<T> objects, Predicate<T> pred1, Predicate<T> pred2)
{
    Console.WriteLine();
    foreach (var item in objects.FindAll(pred1))
    {
        if(pred2(item))
        Console.WriteLine(item);
    }
}

static void MotherfuckerMethod<T>(List<T> objects, List<Predicate<T>> predilist)
{
    Console.WriteLine();
    foreach (var item in objects)
    {
        bool pass = true;
        foreach (var pred in  predilist)
        {
            if (!pred(item))
            { pass = false; break; }
        }
        if (pass) Console.WriteLine(item);
    }
}