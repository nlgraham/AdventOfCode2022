/* Day4.cs
 * Author: Natasha Graham
 * Created 2023-09-20
 */


int compContained = 0;

String[] input = Console.ReadLine().Split(',');
String[] elf1 = input[0].Split('-');
String[] elf2 = input[1].Split('-');

while(input.Length != 1)
{
    if((Int32.Parse(elf1[0]) <= Int32.Parse(elf2[0])) && (Int32.Parse(elf2[1]) <= Int32.Parse(elf1[1])))
    {
        compContained++;
    }
    else if((Int32.Parse(elf2[0]) <= Int32.Parse(elf1[0])) && (Int32.Parse(elf1[1]) <= Int32.Parse(elf2[1])))
    {
        compContained++;
    }
    else if(((Int32.Parse(elf1[0]) >= Int32.Parse(elf2[0])) && (Int32.Parse(elf1[0]) <= Int32.Parse(elf2[1]))) ||
        ((Int32.Parse(elf2[0]) >= Int32.Parse(elf1[0])) && (Int32.Parse(elf2[0]) <= Int32.Parse(elf1[1]))) ||
        ((Int32.Parse(elf1[1]) >= Int32.Parse(elf2[0])) && (Int32.Parse(elf1[1]) <= Int32.Parse(elf2[1]))) ||
        ((Int32.Parse(elf2[1]) >= Int32.Parse(elf1[0])) && (Int32.Parse(elf2[1]) <= Int32.Parse(elf1[1]))))
    {
        compContained++;
    }

    input = Console.ReadLine().Split(',');
    if(input.Length == 1)
    {
        break;
    }

    elf1 = input[0].Split('-');
    elf2 = input[1].Split('-');
}


Console.WriteLine(compContained);


// part 1 answer 424
// part 2 answer 804