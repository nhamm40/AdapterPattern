using System.Text;
using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    public class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public string fly()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < 5; i++)
            {
                sb.Append(turkey.Fly());
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public string quack()
        {
            return turkey.Gobble();
        }
    }
}