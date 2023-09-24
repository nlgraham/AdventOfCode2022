/* Day6.cs
 * Author: Natasha Graham
 * Created 2023-09-24
 */


// Get input from console, convert to ReadOnlySpan
ReadOnlySpan<char> stream = Console.ReadLine().AsSpan();

// initialize int for final result
int index = 0;


// Run through set of 14 characters in a row, starting with index 13 to the end
// Each set of 14 is added to a HashSet
// Which is then checked for 14 unique entries
// Upon which the current index + one is given to the answer int
// and the loop is broken
for(int i = 13; i < stream.Length; i++)
{
    HashSet<char> set = new HashSet<char>();

    foreach (char c in stream[(i - 13)..(i + 1)])
    {
        set.Add(c);
    }

    if(set.Count == 14)
    {
        index = i + 1;
        break;
    }
}

Console.WriteLine(index);