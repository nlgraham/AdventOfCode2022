/* Day5.cs
 * Author: Natasha Graham
 * Created 2023-09-24
 */


Stack<char> stack1 = new Stack<char>(new char[] {'Q', 'S', 'W', 'C', 'Z', 'V', 'F', 'T'});
Stack<char> stack2 = new Stack<char>(new char[] {'Q', 'R', 'B'});
Stack<char> stack3 = new Stack<char>(new char[] {'B', 'Z', 'T', 'Q', 'P', 'M', 'S'});
Stack<char> stack4 = new Stack<char>(new char[] {'D', 'V', 'F', 'R', 'Q', 'H'});
Stack<char> stack5 = new Stack<char>(new char[] {'J', 'G', 'L', 'D', 'B', 'S', 'T', 'P'});
Stack<char> stack6 = new Stack<char>(new char[] {'W', 'R', 'T', 'Z'});
Stack<char> stack7 = new Stack<char>(new char[] {'H', 'Q', 'M', 'N', 'S', 'F', 'R', 'J'});
Stack<char> stack8 = new Stack<char>(new char[] {'R', 'N', 'F', 'H', 'W'});
Stack<char> stack9 = new Stack<char>(new char[] {'J', 'Z', 'T', 'Q', 'P', 'R', 'B'});

Stack<char>[] stacks = new Stack<char>[] { stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8, stack9 };


String[] input = Console.ReadLine().Split(' ');

while (input.Length > 1)
{
    int i = int.Parse(input[1]);
    int source = int.Parse(input[3]) - 1;
    int destination = int.Parse(input[5]) - 1;

    Stack<char> temp = new Stack<char>();

    while(i > 0)
    {
        temp.Push(stacks[source].Pop());

        i--;
    }

    while(temp.Count > 0)
    {
        stacks[destination].Push(temp.Pop());
    }

    input = Console.ReadLine().Split(' ');
}

foreach(Stack<char> stack in stacks)
{
    Console.Write(stack.Pop());
}

