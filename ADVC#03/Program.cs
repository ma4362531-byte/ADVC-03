using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Timers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Q3
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    { "Omar", "01011111111" },
            //    { "Khaled", "01122222222" },
            //    { "Nour", "01233333333" },
            //    { "Mariam", "01544444444" }
            //};

            //phoneBook["Youssef"] = "01055555555"; 
            //phoneBook["Omar"] = "01099999999";    

            //try
            //{
            //    phoneBook.Add("Omar", "01000000000");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"[Exception caught on .Add()]: {ex.Message}\n");
            //}

            //bool isAdded = phoneBook.TryAdd("Omar", "01000000000");
            //Console.WriteLine($"Did .TryAdd() duplicate succeed? {isAdded}\n");

            //bool contactExists = phoneBook.ContainsKey("Hassan");
            //Console.WriteLine($"Does contact 'Hassan' exist? {contactExists}\n");

            //string searchedContact = phoneBook.GetValueOrDefault("Hassan", "Not Found");
            //Console.WriteLine($"Get 'Hassan' with fallback: {searchedContact}\n");

            //Console.WriteLine($"Keys  : {string.Join(", ", phoneBook.Keys)}");
            //Console.WriteLine($"Values: {string.Join(", ", phoneBook.Values)}");



            #endregion

            #region Q4
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //Console.WriteLine($"Stored Emails Count: {emails.Count}");
            //Console.WriteLine("Explanation: The count is 2 because StringComparer.OrdinalIgnoreCase forces the HashSet to ignore character casing when evaluating uniqueness. Therefore, 'AHMED@test.com' and 'Sara@Test.Com' were treated as duplicate entries and ignored.\n");

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine($"UnionWith (Set A U Set B) : {{ {string.Join(", ", union)} }}");

            //HashSet<int> intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);
            //Console.WriteLine($"IntersectWith (Set A ∩ Set B) : {{ {string.Join(", ", intersect)} }}");

            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine($"ExceptWith (Set A - Set B) : {{ {string.Join(", ", except)} }}\n");

            //HashSet<int> subSet = new HashSet<int> { 1, 2 };
            //bool isSubset = subSet.IsSubsetOf(setA);
            //Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSubset}");


            #endregion

            #region Search

            //Generic Collection - Span<T>

            //Span<T> is a high - performance, stack - only type(ref struct) introduced in .NET to represent a contiguous region of arbitrary memory.It provides type-safe and memory-safe
            //access to elements in arrays, unmanaged memory, or stack-allocated memory without creating extra memory allocations on the Managed Heap.Because it prevents unnecessary data 
            //copying(such as string slicing or sub-array creation), it drastically reduces Garbage Collection(GC) overhead and improves throughput in low-latency backend applications.Its
            //main limitation is that it cannot be used across asynchronous await boundaries or stored as a field in standard classes due to its stack-bound nature.


            //SortedList<T>

            //SortedList<TKey, TValue> is a generic collection that maintains key/ value pairs sorted automatically
            //    by key based on an IComparer implementation. Internally, it is implemented using two parallel arrays:
            //one for keys and one for values.It features $O(\log n)$ lookup time using Binary Search on the sorted keys
            //    array and allows fast $O(1)$ index - based access.However, inserting or removing elements requires shifting 
            //    items in the internal arrays, making those operations relatively slow at $O(n)$. It is best suited for small 
            //to medium - sized datasets where lookups and reads are frequent, but additions and deletions are rare.



            //SortedDictionary<>



            //SortedDictionary<TKey, TValue> is a generic collection that stores key/ value pairs sorted by key, backed 
            //    internally by a self-balancing binary search tree(a Red - Black Tree).Because of its tree - based structure, 
            //    search, insertion, and deletion operations all run in predictable logarithmic time $O(\log n)$. Compared to SortedList, 
            //    it offers significantly faster insertions and deletions for large datasets, though it incurs slightly higher memory overhead 
            //    per entry due to tree node pointers and lacks fast index - based element access.It is the ideal choice when dealing with dynamic
            //    datasets that undergo frequent insertions, updates, and removals while requiring continuous sorting.


            #endregion


        }
    }
}
