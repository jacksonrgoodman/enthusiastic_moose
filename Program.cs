using System;
Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("I really am enthusiastic");

    string[] questions = { "Are meese real", "Are you enthusiastic?", "Do you love C# yet?", "Do you want to know a secret?" };
    string[] trueAnswers = { "Really? It seems very unlikely.", "Yay!", "Good job sucking up to your instructor!", "ME TOO!!!! I love secrets...tell me one!" };
    string[] falseAnswers = { "I  K N E W  I T !!!", "You should try it!", "You will...oh, yes, you will...", "Oh, no...secrets are the best, I love to share them!" };
    for (int i = 0; i < 4; i++)

    //! I need to map the array of True and False answers, as well as the questions into the foreach statement 

    //? single function call, that will do all that, called in the loop

    //* call a function question, get the text data in to new function


    {
        bool isTrue = MooseAsks(questions[i]);
        if (isTrue)
        {
            //MooseSays("Really? It seems very unlikely.");
            MooseSays(trueAnswers[i]);

        }
        else
        {
            //MooseSays("I  K N E W  I T !!!");
            MooseSays(falseAnswers[i]);
        }
    }

}

bool MooseAsks(string question)
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
        return true;
    }
    else
    {
        return false;
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
