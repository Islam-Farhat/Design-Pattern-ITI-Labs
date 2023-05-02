using Strategy_Pattern.Strategy_Pattern;

namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Team team = new(new Attack());

            team.Play();

            team = new(new Defend());

            team.Play();
        }
    }
}