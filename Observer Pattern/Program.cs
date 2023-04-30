namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football = new Football();

            Player player = new(football);
            Referee referee = new(football);

            player.Update();
            referee.Update();
        }
    }
}