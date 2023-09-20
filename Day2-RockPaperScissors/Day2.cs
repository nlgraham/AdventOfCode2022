/* Day2.cs
 * Author: Natasha Graham
 * Created 2023-09-19
 * Updated 2023-09-20
 */

String? match = Console.ReadLine();

int score = 0;

// x lose (0), y draw (3), z win (6)
// a rock, b paper, c scissors
// rock > scissors > paper > rock
// rock = 1, paper = 2, scissors = 3

while (!match.Equals("end"))
{
    switch(match)
    { 
        case "A X": // rock - scissors, lose
            score += 3 + 0;
            break;
        case "A Y": // rock - rock, tie
            score += 1 + 3;
            break;
        case "A Z": // rock - paper, win
            score += 2 + 6;
            break;
        case "B X": // paper - rock, lose
            score += 1 + 0;
            break;
        case "B Y": // paper - paper, tie
            score += 2 + 3;
            break;
        case "B Z": // paper - scissors, win
            score += 3 + 6;
            break;
        case "C X": // scissors - paper, lose
            score += 2 + 0;
            break;
        case "C Y": // scissors - scissors, tie
            score += 3 + 3;
            break;
        case "C Z": // scissors - rock, win
            score += 1 + 6;
            break;
    }

    match = Console.ReadLine();
}

Console.WriteLine(score);

// part 1 answer 9651
// part 2 answer 10560