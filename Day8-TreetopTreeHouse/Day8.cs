/* Day8.cs
 * Author: Natasha Graham
 * Created 2023-09-25
 */

List<List<int>> forest = new List<List<int>>();

int max = 0;

string input = Console.ReadLine();

while(!input.Equals("end"))
{
    List<int> newList = new List<int>();
    foreach(char c in input)
    {
        newList.Add(c - '0');
    }
    forest.Add(newList);
    input = Console.ReadLine();
}

for (int i = 1; i < forest.Count - 1; i++)
{
    for (int j = 1; j < forest[i].Count - 1; j++)
    {
        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;
        int temp;

        for (int y = j - 1; y >= 0; y--)
        {
            up++;
            if (forest[i][y] >= forest[i][j])
            {
                break;
            }
        }

        for (int y = j + 1; y < forest[i].Count; y++)
        {
            down++;
            if (forest[i][y] >= forest[i][j])
            {
                break;
            }
        }

        for (int x = i - 1; x >= 0; x--)
        {
            left++;
            if (forest[x][j] >= forest[i][j])
            {
                break;
            }
        }

        for (int x = i + 1; x < forest.Count; x++)
        {
            right++;
            if (forest[x][j] >= forest[i][j])
            {
                break;
            }
        }

        temp = up * down * left * right;

        if(temp > max)
        {
            max = temp;
        }
    }

}

Console.WriteLine(max);
