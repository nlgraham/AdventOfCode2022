/* Day3.cs
 * Author: Natasha Graham
 * Created 2023-09-20
 */

char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
    'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


String? input = Console.ReadLine();

int sum = 0;

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

Console.WriteLine(sum);

// 7616 too low - part 1 answer 7990