namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine($"Full Collection: {string.Join(", ", grades)}");
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}\n");

            //grades.Sort();
            //Console.WriteLine($"Sorted Grades (Ascending): {string.Join(", ", grades)}\n");

            //int firstAbove90 = grades.First(g => g > 90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}\n");

            //var failingGrades = grades.Where(g => g < 75);
            //Console.WriteLine($"Failing grades (< 75): {string.Join(", ", failingGrades)}\n");

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine($"Grades after removing failing grades: {string.Join(", ", grades)}\n");

            //bool hasPerfectScore = grades.Any(g => g == 100);
            //Console.WriteLine($"Has grade equal to 100? {hasPerfectScore}\n");

            //List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("Formatted Grades List:");
            //foreach (var formattedGrade in formattedGrades)
            //{
            //    Console.WriteLine($" - {formattedGrade}");
            //}





            #endregion

            #region Q2
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //    { 350, "Mona" }
            //};

            //Console.WriteLine("Leaderboard Entries (Automatically sorted by score):");
            //foreach (KeyValuePair<int, string> entry in leaderboard)
            //{
            //    Console.WriteLine($" Score: {entry.Key} -> Player: {entry.Value}");
            //}
            //Console.WriteLine();

            //KeyValuePair<int, string> firstEntry = leaderboard.First();
            //Console.WriteLine($"First Key: {firstEntry.Key}");
            //Console.WriteLine($"First Value: {firstEntry.Value}\n");

            //bool hasScore500 = leaderboard.ContainsKey(500);
            //Console.WriteLine($"Check if score 500 exists: {hasScore500}\n");

            //if (leaderboard.TryGetValue(999, out string player999))
            //{
            //    Console.WriteLine($"Player with score 999: {player999}");
            //}
            //else
            //{
            //    Console.WriteLine("Safely checked score 999: Player Not Found (No Exception thrown).\n");
            //}

            //leaderboard.Remove(200);
            //Console.WriteLine("Updated Leaderboard after removing score 200:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($" Score: {entry.Key} -> Player: {entry.Value}");
            //}


            #endregion







        }
    }
}
