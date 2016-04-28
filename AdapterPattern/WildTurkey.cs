namespace AdapterPattern
{
    public class WildTurkey : Interfaces.Turkey
    {
        public WildTurkey()
        {

        }

        public string Fly()
        {
            return "I'm flying a short distance!";
        }

        public string Gobble()
        {
            return "Gobble, gobble";
        }
    }
}