namespace AdapterPattern
{
    internal class WildTurkey : Interfaces.Turkey
    {
        public WildTurkey()
        {

        }

        public string Fly()
        {
            return "I'm flying!";
        }

        public string Gobble()
        {
            return "Gobble";
        }
    }
}