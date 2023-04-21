namespace CountShortestWayToFindNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 25, 10, 5, 1 }; // Доступные монеты
            int target = 60; // Целевая сумма

            List<int> result = new List<int>(); // Результат
            int total = 0; // Общая сумма монет

            foreach (int coin in coins)
            {
                while (total + coin <= target)
                {
                    result.Add(coin);
                    total += coin;
                }
            }
            Console.WriteLine("Минимальное количество монет: " + result.Count);
            Console.WriteLine("Монеты: " + string.Join(", ", result));

        }

    }
}