/* Day9.cs
 * Author: Natasha Graham
 * Created 2023-09-25
 */

using Day9_RopeBridge;


OrderedPair[] rope = new OrderedPair[] { new OrderedPair(0,0), new OrderedPair(0, 0) , new OrderedPair(0, 0),
            new OrderedPair(0,0), new OrderedPair(0,0), new OrderedPair(0,0), new OrderedPair(0,0), new OrderedPair(0,0),
            new OrderedPair(0,0), new OrderedPair(0,0) };
HashSet<OrderedPair> visited = new HashSet<OrderedPair>();

visited.Add(new OrderedPair(rope[9].X, rope[9].Y));

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
                rope[0].UpdateX(1);
                break;
            case 'L':
                rope[0].UpdateX(-1);
                break;
            case 'U':
                rope[0].UpdateY(1);
                break;
            case 'D':
                rope[0].UpdateY(-1);
                break;
        }

        for (int j = 1; j < rope.Length; j++)
        {
            OrderedPair head = rope[j - 1];
            OrderedPair tail = rope[j];

            if (!isNextTo(head, tail))
            {
                if ((tail.X - head.X) < -1)
                {
                    if ((tail.Y - head.Y) == 0)
                        tail.UpdateX(1);
                    else if ((tail.Y - head.Y) >= 1)
                    {
                        tail.UpdateY(-1);
                        tail.UpdateX(1);
                    }
                    else if ((tail.Y - head.Y) <= -1)
                    {
                        tail.UpdateY(1);
                        tail.UpdateX(1);
                    }                    
                }
                else if ((tail.X - head.X) > 1)
                {
                    if ((tail.Y - head.Y) == 0)
                        tail.UpdateX(-1);
                    if ((tail.Y - head.Y) >= 1)
                    {
                        tail.UpdateY(-1);
                        tail.UpdateX(-1);
                    }
                    else if ((tail.Y - head.Y) <= -1)
                    {
                        tail.UpdateY(1);
                        tail.UpdateX(-1);
                    }
                }
                else if ((tail.Y - head.Y) > 1)
                {
                    if ((tail.X - head.X) == 0)
                        tail.UpdateY(-1);
                    if ((tail.X - head.X) >= 1)
                    {
                        tail.UpdateY(-1);
                        tail.UpdateX(-1);
                    }
                    else if ((tail.X - head.X) <= -1)
                    {
                        tail.UpdateY(-1);
                        tail.UpdateX(1);
                    }
                }
                else if ((tail.Y - head.Y) < -1)
                {
                    if ((tail.X - head.X) == 0)
                        tail.UpdateY(1);
                    if ((tail.X - head.X) >= 1)
                    {
                        tail.UpdateY(1);
                        tail.UpdateX(-1);
                    }
                    else if ((tail.X - head.X) <= -1)
                    {
                        tail.UpdateY(1);
                        tail.UpdateX(1);
                    }
                }
            }
        }

        visited.Add(new OrderedPair(rope[9].X, rope[9].Y));
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


// 2553 too high