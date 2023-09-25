/* Day7.cs
 * Author: Natasha Graham
 * Created 2023-09-24
 */

using Day7_NoSpaceLeftOnDevice;



String[] input = Console.ReadLine().Split(' ');
TreeNode currentNode = new TreeNode(input[2]);

TreeNode root = currentNode;

int totalSystemSize = 70000000;
int minUpdateSpace = 30000000;


while(input.Length > 1)
{
    input = Console.ReadLine().Split(' ');

    if (input.Length == 1)
        break;

    if (input[0].Equals("$"))
    {
        if(input[1].Equals("ls"))
        {
            continue;
        }

        if (input[2].Equals(".."))
        {
            currentNode = currentNode.Parent;
            continue;
        }

        currentNode = currentNode.Children.First(c => c.Name == input[2]);
    }
    else if(input[0].Equals("dir"))
    {
        currentNode.AddChild(new TreeNode(input[1], currentNode));
    }
    else
    {
        currentNode.AddChild(new TreeNode(input[1], Int32.Parse(input[0]), currentNode));
    }
}

List<int> sizes = new List<int>();

int rootSize = root.FindDirSize(100000, sizes);

int sumOfSizes = 0;

foreach(int s in sizes)
{
    sumOfSizes += s;
}

Console.WriteLine(sumOfSizes);