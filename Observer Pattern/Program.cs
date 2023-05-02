namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football = new Football();

            Player player = new(football);
            football.Attach(player);
            football.SetBallPosition();


            Referee referee = new(football);
            football.Attach(referee);
            football.SetBallPosition();
        }
    }
}