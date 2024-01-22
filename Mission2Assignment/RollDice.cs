namespace Mission2Assignment
{
    public class RollDice
    {
        public int Roll()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            int totalOutput = dice1 + dice2;
            return totalOutput;
        }
    }
}