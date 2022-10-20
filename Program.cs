//Brandon Le
//10-20-22
//Mini Challenge 5 - Mad Lib
//Project will save 10 user inputs as strings and print them out into a mad lib story. 
//The user has the option to play again or end. Also has data validation for both words and numbers in the user inputs and play again.


Console.Clear();

bool canParse = true;
bool playAgain = true;
int validNum;

while (playAgain == true)
{
    Console.Write("Please enter a name: ");
    string nameOne = Console.ReadLine();
    canParse = Int32.TryParse(nameOne, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please enter a name:");
        nameOne = Console.ReadLine();
        canParse = Int32.TryParse(nameOne, out validNum);
    }


    Console.Write("Okay another name: ");
    string nameTwo = Console.ReadLine();
    canParse = Int32.TryParse(nameTwo, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please enter another name:");
        nameTwo = Console.ReadLine();
        canParse = Int32.TryParse(nameTwo, out validNum);
    }

    Console.Write("What's something that tastes yummy? ");
    string yummyFlavor = Console.ReadLine();
    canParse = Int32.TryParse(yummyFlavor, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Enter a yummy taste:");
        yummyFlavor = Console.ReadLine();
        canParse = Int32.TryParse(yummyFlavor, out validNum);
    }

    Console.Write("Okay how about something that tastes GROSS then? ");
    string nastyFlavor = Console.ReadLine();
    canParse = Int32.TryParse(nastyFlavor, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Enter a gross flavor:");
        nastyFlavor = Console.ReadLine();
        canParse = Int32.TryParse(nastyFlavor, out validNum);
    }

    Console.Write("Okay gimme a number: ");
    string numberOne = Console.ReadLine();
    canParse = Int32.TryParse(numberOne, out validNum);
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY. Use a number:");
        numberOne = Console.ReadLine();
        canParse = Int32.TryParse(numberOne, out validNum);
    }

    Console.Write("What's your favorite animal? ");
    string animal = Console.ReadLine();
    canParse = Int32.TryParse(animal, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please enter an animal:");
        animal = Console.ReadLine();
        canParse = Int32.TryParse(animal, out validNum);
    }

    Console.Write("Hmmm what's a good color? ");
    string color = Console.ReadLine();
    canParse = Int32.TryParse(color, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Enter a color:");
        color = Console.ReadLine();
        canParse = Int32.TryParse(color, out validNum);

    }

    Console.Write("Time for another number: ");
    string numberTwo = Console.ReadLine();
    canParse = Int32.TryParse(numberTwo, out validNum);
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY. Use a number:");
        numberTwo = Console.ReadLine();
        canParse = Int32.TryParse(numberTwo, out validNum);
    }

    Console.Write("Okay we're almost done... give me an emotion: ");
    string emotion = Console.ReadLine();
    canParse = Int32.TryParse(emotion, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. I asked for an emotion:");
        emotion = Console.ReadLine();
        canParse = Int32.TryParse(emotion, out validNum);
    }

    Console.Write("Okay last one! Let's end it with another number: ");
    string numberThree = Console.ReadLine();
    canParse = Int32.TryParse(numberThree, out validNum);
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY. Use a number:");
        numberThree = Console.ReadLine();
        canParse = Int32.TryParse(numberThree, out validNum);
    }




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
    while (lastInput != "YES" && lastInput != "NO")
    {
        Console.WriteLine("INVALID ENTRY! PLEASE CHOOSE YES OR NO.");
        lastInput = Console.ReadLine().ToUpper();
    }
    if (lastInput == "NO")
    {
        Console.WriteLine("So sad to see you go! Come back when you want to do some more mad libs :)");
        playAgain = false;
    }
    if (lastInput == "YES")
        {
            playAgain = true;
            Console.WriteLine("Oh you wanna do more mad libs? Nice! Let's do it.");
        }


    }

