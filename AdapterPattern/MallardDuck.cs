namespace AdapterPattern
{
    public class MallardDuck : Interfaces.Duck
    {
        public MallardDuck()
        {

        }

        public string quack()
        {
            return "Quack";
        }

        public string fly()
        {
            return "I'm flying!";
        }
    }
}