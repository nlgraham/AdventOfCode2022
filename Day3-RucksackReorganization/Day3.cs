/* Day3.cs
 * Author: Natasha Graham
 * Created 2023-09-20
 */

char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
    'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


char[] bag1 = Console.ReadLine().ToCharArray();
char[] bag2 = Console.ReadLine().ToCharArray();
char[] bag3 = Console.ReadLine().ToCharArray();

int sum = 0;

/*
while(!input.Equals("end"))
{
    int halfPoint = input.Length / 2;

    char[] side1 = input.Substring(0, halfPoint).ToCharArray();
    String side2 = input.Substring(halfPoint);

    //Console.WriteLine(side1.Length);
    //Console.WriteLine(side2.Length);

    foreach(char c in side1)
    {
        if(side2.Contains(c))
        {
            sum += Array.IndexOf(letters, c) + 1;
            break;
        }
    }

    input = Console.ReadLine();
}
*/

while(true)
{
    foreach(char c in bag1)
    {
        if(bag2.Contains(c))
        {
            if(bag3.Contains(c))
            {
                sum += Array.IndexOf(letters, c) + 1;
                break;
            }
        }
    }

    bag1 = Console.ReadLine().ToCharArray();
    if(bag1.Length == 3 && bag1[0] == 'e')
    {
        break;
    }
    bag2 = Console.ReadLine().ToCharArray();
    bag3 = Console.ReadLine().ToCharArray();
}

Console.WriteLine(sum);

// 7616 too low - part 1 answer 7990
// 2602 for part 2