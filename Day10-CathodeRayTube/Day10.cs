/* Day10.cs
 * Author: Natasha Graham
 * Created: 2023-09-28
 */


int X = 1;  // register
int cycle = 0;  // clock
int strengthSum = 0;

string[] input = Console.ReadLine().Split(' ');

while(true)
{
    cycle++;

    if (cycle == 20 || cycle == 60 || cycle == 100 || cycle == 140 || cycle == 180 || cycle == 220)
        strengthSum += X * cycle;

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

        if (cycle == 20 || cycle == 60 || cycle == 100 || cycle == 140 || cycle == 180 || cycle == 220)
            strengthSum += X * cycle;

        X += Int32.Parse(input[1]);
    }

    input = Console.ReadLine().Split(' ');
}

Console.WriteLine(strengthSum);