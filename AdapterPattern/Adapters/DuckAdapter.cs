using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters
{
    public class DuckAdapter : Interfaces.Turkey
    {
        Duck duck;

        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public string Fly()
        {
            return duck.fly();
        }

        public string Gobble()
        {
            return duck.quack();
        }
    }
}
