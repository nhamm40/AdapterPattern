namespace AdapterPattern
{
    class Program
    {
        public class DuckTestDrive
        {
            public static void main(string[] args)
            {
                MallardDuck duck = new MallardDuck();

                WildTurkey turkey = new WildTurkey();
                duck turkeyAdapter = new TurkeyAdapter(turkey);

                System.Console.WriteLine("The Turkey says...");
                turkey.Gobble();
                turkey.Fly();

                System.Console.WriteLine("\n The Duck says...");
                testDuck(duck);

                System.Console.WriteLine("\n The TurkeyAdapter says...");
                testDuck(turkeyAdapter);
            }

            static void testDuck(Duck duck)
            {
                duck.quack();
                duck.fly();
            }
        }
    }
}
