/* Day10.cs
 * Author: Natasha Graham
 * Created: 2023-09-28
 */


int X = 1;  // register
int cycle = 0;  // clock
// int strengthSum = 0;
char[] visual = new char[240];

string[] input = Console.ReadLine().Split(' ');

while(true)
{
    cycle++;

    if(cycle % 40 == 0)
    {
        int temp = 40;
        if (X == (temp) || (X + 1) == (temp) || (X + 2) == (temp))
            visual[(cycle - 1) % 240] = '#';
        else
            visual[(cycle - 1) % 240] = '.';
    }
    else if(X == (cycle % 40) || (X + 1) == (cycle % 40) || (X + 2) == (cycle % 40))
        visual[(cycle - 1) % 240] = '#';
    else
        visual[(cycle - 1) % 240] = '.';

    /*
    if (cycle == 20 || cycle == 60 || cycle == 100 || cycle == 140 || cycle == 180 || cycle == 220)
        strengthSum += X * cycle;
    */

    if (input[0].Equals("end"))
        break;
    if (input[0].Equals("noop"))
    {
        input = Console.ReadLine().Split(' ');
        continue;
    }
    if(input[0].Equals("addx"))
    {
        cycle++;

        /*
        if (cycle == 20 || cycle == 60 || cycle == 100 || cycle == 140 || cycle == 180 || cycle == 220)
            strengthSum += X * cycle;
        */

        if (cycle % 40 == 0)
        {
            int temp = 40;
            if (X == (temp) || (X + 1) == (temp) || (X + 2) == (temp))
                visual[(cycle - 1) % 240] = '#';
            else
                visual[(cycle - 1) % 240] = '.';
        }
        else if (X == (cycle % 40) || (X + 1) == (cycle % 40) || (X + 2) == (cycle % 40))
            visual[(cycle - 1) % 240] = '#';
        else
            visual[(cycle - 1) % 240] = '.';

        X += Int32.Parse(input[1]);
    }

    input = Console.ReadLine().Split(' ');
}

// Console.WriteLine(strengthSum);

for(int i = 0; i < visual.Length; i++)
{
    if(i == 40 || i == 80 || i == 120 || i == 160 || i == 200)
    {
        Console.WriteLine();
    }
    Console.Write(visual[i]);
}

Console.WriteLine();