using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
// Let the moose speak!
// MooseSays("H I, I'M  E N T H U S I A S T I C !");
// MooseSays("I really am enthusiastic");
MooseSays("I have questions!");
}

MooseQuestions();

void MooseQuestions()
{
//ask a question
MooseQuestion("is Canada Real?", "Really? It seems very unlikely.", "I  K N E W  I T  !!!");
MooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
MooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
MooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

MooseAnswers();

void MooseAnswers()
{
MooseAnswer("Ask again later.");
MooseAnswer("Better not tell you now.");
MooseAnswer("Cannot predict now.");
MooseAnswer("Concentrate and ask again.");
MooseAnswer("Don’t count on it.");
MooseAnswer("It is certain.");
MooseAnswer("It is decidedly so.");
MooseAnswer("Most likely.");
MooseAnswer("My reply is no.");
MooseAnswer("My sources say no.");
MooseAnswer("Outlook not so good.");
MooseAnswer("Outlook good.");
MooseAnswer("Reply hazy, try again.");
MooseAnswer("Signs point to yes.");
MooseAnswer("Very doubtful.");
MooseAnswer("Without a doubt.");
MooseAnswer("Yes.");
MooseAnswer("Yes – definitely.");
MooseAnswer("You may rely on it.");
}

void MooseAnswer(string answer)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();
}

void MooseQuestion(string question, string AnswerTrue, string AnswerFalse)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {   
       MooseSays(AnswerTrue);
    }
    else 
    {
       MooseSays(AnswerFalse);
    }
}





void MooseSays(string message)
{
    Console.WriteLine($@"
                                           _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


