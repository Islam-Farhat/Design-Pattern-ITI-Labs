using Decorator_Pattern.Decorator_Pattern;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComponentPlayer FieldPlayer = new ConcreteFieldPlayer();
            FieldPlayer = new Defender(FieldPlayer);
            FieldPlayer = new Forward(FieldPlayer);
            FieldPlayer.PassBall();

            Console.WriteLine("-----------------------------------");

            ComponentPlayer GoalKeeper = new ConcreteGoalKeeper();
            GoalKeeper = new Defender(GoalKeeper);
            GoalKeeper = new MidFielder(GoalKeeper);
            GoalKeeper.PassBall();

        }
    }
}