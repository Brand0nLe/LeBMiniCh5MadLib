//Cuong Brandon Le
//10-18-22
//Mini Challenge 5 - Mad Lib


//need data validation


Console.Clear();

bool playAgain = true;

while (playAgain == true)
{
    Console.Write("Please enter a name: ");
    string nameOne = Console.ReadLine();

    Console.Write("Okay another name: ");
    string nameTwo = Console.ReadLine();

    Console.Write("What's something that tastes yummy? ");
    string yummyFlavor = Console.ReadLine();

    Console.Write("Okay how about something that tastes GROSS then? ");
    string nastyFlavor = Console.ReadLine();

    Console.Write("Okay gimme a number: ");
    string numberOne = Console.ReadLine();

    Console.Write("What's your favorite animal? ");
    string animal = Console.ReadLine();

    Console.Write("Hmmm what's a good color? ");
    string color = Console.ReadLine();

    Console.Write("Time for another number: ");
    string numberTwo = Console.ReadLine();

    Console.Write("Okay we're almost done... give me an emotion: ");
    string emotion = Console.ReadLine();

    Console.Write("Okay last one! Let's end it with another number: ");
    string numberThree = Console.ReadLine();



    Console.WriteLine("\n\n------------------------------------------------------------");
    Console.WriteLine("Alright good job! You're sooo creative! Here's your mad lib:");
    Console.WriteLine("------------------------------------------------------------\n");


    Console.WriteLine($"One day there were two friends named {nameOne} and {nameTwo}.");
    Console.WriteLine($"{nameOne} decided they wanted to bake a {yummyFlavor} cake and asked {nameTwo} to come over and help.");
    Console.WriteLine($"While they were mixing the ingredients {nameTwo} accidentally grabbed the wrong flavor and added in {nastyFlavor}!");
    Console.WriteLine($"Neither of them realized and just continued baking.");
    Console.WriteLine($"After {numberOne} hours they finally finished baking and were ready to decorate.");
    Console.WriteLine($"They shaped the cake into a {animal} and put {color} icing on it.");
    Console.WriteLine($"After {numberTwo} hours of decorating they finally finished and could taste it!");
    Console.WriteLine($"They both took a bite and immediately spat it out! Why did the cake taste like {nastyFlavor}?!");
    Console.WriteLine($"They were feeling very {emotion} after their huge failure so...");
    Console.WriteLine($"They decided to door dash {numberThree} orders of fries to make themselves feel better :)");


    Console.WriteLine("------------------------------------------------------------\n");
    Console.WriteLine("Wasn't that a bunch of fun?! Do you wanna play again? (YES/NO)");
    string lastInput = Console.ReadLine().ToUpper();
    if (lastInput == "NO")
    {
        playAgain = false;
    }else
        {
            Console.WriteLine("Oh you wanna do more mad libs? Nice! Let's do it.");
        }


    }

