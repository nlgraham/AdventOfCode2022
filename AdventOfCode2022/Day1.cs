/* Day1.cs
 * Author: Natasha Graham
 * Created 2023-09-19
 */


int[] maxCalories = { 0, 0, 0 };
int sum = 0;

String? input = Console.ReadLine();

while(input != null)
{
    Array.Sort(maxCalories);
    if (input.Equals("end"))
        break;
    if(input.Equals(""))
    {
        if (sum > maxCalories[0])
        {
            if (sum > maxCalories[1])
            {
                if(sum > maxCalories[2])
                {
                    maxCalories[0] = maxCalories[1];
                    maxCalories[1] = maxCalories[2];
                    maxCalories[2] = sum;
                }
                else
                {
                    maxCalories[0] = maxCalories[1];
                    maxCalories[1] = sum;
                }
            }
            else
            {
                maxCalories[0] = sum;
            }
        }
        sum = 0;
        input = Console.ReadLine();
        //Array.Sort(maxCalories);
        continue;
    }

    sum += Int32.Parse(input);
    input = Console.ReadLine();
}

Console.WriteLine(maxCalories[0] + maxCalories[1] + maxCalories[2]);


// part 1 answer: 70764
// part 2 answer 203905