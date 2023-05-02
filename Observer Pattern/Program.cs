namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football = new Football();

            Player player = new();
            football.Attach(player);
            football.SetBallPosition();


            Referee referee = new();
            football.Attach(referee);
            football.SetBallPosition();
        }
    }
}