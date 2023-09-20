/* Day2.cs
 * Author: Natasha Graham
 * Created 2023-09-19
 */

String? match = Console.ReadLine();

int score = 0;

while (!match.Equals("end"))
{
    switch(match)
    { 
        case "A X": // rock = rock tie
            score += 1 + 3;
            break;
        case "A Y": // rock < paper win
            score += 2 + 6;
            break;
        case "A Z": // rock > scissors loss
            score += 3 + 0;
            break;
        case "B X": // paper > rock loss
            score += 1 + 0;
            break;
        case "B Y": // paper = paper tie
            score += 2 + 3;
            break;
        case "B Z": // paper < scissors win
            score += 3 + 6;
            break;
        case "C X": // scissors < rock win
            score += 1 + 6;
            break;
        case "C Y": // scissors > paper loss
            score += 2 + 0;
            break;
        case "C Z": // scissors = scissors tie
            score += 3 + 3;
            break;
    }

    match = Console.ReadLine();
}

Console.WriteLine(score);

// part 1 answer 9651