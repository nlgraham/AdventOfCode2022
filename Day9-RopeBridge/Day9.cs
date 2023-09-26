/* Day9.cs
 * Author: Natasha Graham
 * Created 2023-09-25
 */

using Day9_RopeBridge;


OrderedPair head = new OrderedPair(0, 0);
OrderedPair tail = new OrderedPair(0, 0);
HashSet<OrderedPair> visited = new HashSet<OrderedPair>();

visited.Add(new OrderedPair(tail.X, tail.Y));

string[] input = Console.ReadLine().Split(' ');

while(input.Length > 1)
{
    char direction = input[0][0];
    int times = Int32.Parse(input[1]);

    for(int i = times; i > 0; i--)
    {
        switch(direction)
        {
            case 'R':
                head.UpdateX(1);
                break;
            case 'L':
                head.UpdateX(-1);
                break;
            case 'U':
                head.UpdateY(1);
                break;
            case 'D':
                head.UpdateY(-1);
                break;
        }

        if (!isNextTo(head, tail))
        {
            if ((tail.X - head.X) < -1)
            {
                if ((tail.Y - head.Y) == 1)
                {
                    tail.UpdateY(-1);
                    tail.UpdateX(1);
                }
                else if ((tail.Y - head.Y) == -1)
                {
                    tail.UpdateY(1);
                    tail.UpdateX(1);
                }
                else
                    tail.UpdateX(1);
            }
            else if ((tail.X - head.X) > 1)
            {
                if ((tail.Y - head.Y) == 1)
                {
                    tail.UpdateY(-1);
                    tail.UpdateX(-1);
                }
                else if ((tail.Y - head.Y) == -1)
                {
                    tail.UpdateY(1);
                    tail.UpdateX(-1);
                }
                else
                    tail.UpdateX(-1);
            }
            else if ((tail.Y - head.Y) > 1)
            {
                if((tail.X - head.X) == 1)
                {
                    tail.UpdateY(-1);
                    tail.UpdateX(-1);
                }
                else if ((tail.X - head.X) == -1)
                {
                    tail.UpdateY(-1);
                    tail.UpdateX(1);
                }
                else
                    tail.UpdateY(-1);
            }
            else if ((tail.Y - head.Y) < -1)
            {
                if((tail.X - head.X) == 1)
                {
                    tail.UpdateY(1);
                    tail.UpdateX(-1);
                }
                else if ((tail.X - head.X) == -1)
                {
                    tail.UpdateY(1);
                    tail.UpdateX(1);
                }
                else
                    tail.UpdateY(1);
            }
        }

        visited.Add(new OrderedPair(tail.X, tail.Y));
    }

    input = Console.ReadLine().Split(' ');
}




bool isNextTo(OrderedPair head, OrderedPair tail)
{
    if (Math.Abs(tail.X - head.X) <= 1 && Math.Abs(tail.Y - head.Y) <= 1)
        return true;

    return false;
}

Console.WriteLine(visited.Count);