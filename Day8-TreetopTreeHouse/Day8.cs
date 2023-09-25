/* Day8.cs
 * Author: Natasha Graham
 * Created 2023-09-25
 */

List<List<int>> forest = new List<List<int>>();

int count = 0;

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
        bool isVis = true;

        for (int y = 0; y < j; y++)
        {
            if (forest[i][y] >= forest[i][j])
            {
                isVis = false;
                break;
            }
        }
        if (isVis)
        {
            count++;
            continue;
        }
        isVis = true;

        for (int y = j + 1; y < forest[i].Count; y++)
        {
            if (forest[i][y] >= forest[i][j])
            {
                isVis = false;
                break;
            }
        }
        if (isVis)
        {
            count++;
            continue;
        }
        isVis = true;

        for (int x = 0; x < i; x++)
        {
            if (forest[x][j] >= forest[i][j])
            {
                isVis = false;
                break;
            }
        }
        if (isVis)
        {
            count++;
            continue;
        }
        isVis = true;

        for (int x = i + 1; x < forest.Count; x++)
        {
            if (forest[x][j] >= forest[i][j])
            {
                isVis = false;
                break;
            }
        }
        if (isVis)
        {
            count++;
            continue;
        }
    }

}

count += forest.Count * 2;
count += forest[0].Count * 2 - 4;

Console.WriteLine(count);
