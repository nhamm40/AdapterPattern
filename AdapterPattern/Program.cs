using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    public class DuckTestDrive
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            System.Console.WriteLine("The Turkey says...");
            System.Console.WriteLine(turkey.Gobble());
            System.Console.WriteLine(turkey.Fly());

            System.Console.WriteLine("\n The Duck says...");
            testDuck(duck);

            System.Console.WriteLine("\n The TurkeyAdapter says...");
            testDuck(turkeyAdapter);

            System.Console.ReadKey();
        }

        static void testDuck(Duck duck)
        {
            System.Console.WriteLine(duck.quack());
            System.Console.WriteLine(duck.fly());
        }
    }
}
