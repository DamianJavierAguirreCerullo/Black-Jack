using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

System.Random random = new System.Random();

int cardValue = 0;

string drawControlString = "yes";

string cardString = "";

string switchControl = "menu";

string finalMessage = "\nIf You want to play again type 21 and enter.\n" +
    "If you want to go to the menu type menu and enter\n" +
    "If quit type exit and enter";

int playerCards = 0;

int houseCards = 0;

int randomNumber = 0;

bool housePass = false; 

bool playerPass = false; 

List<string> newDeck = new List<string>
{
"As of Spades","As of Spades","2 of Spades","2 of Spades","3 of Spades","3 of Spades","4 of Spades","4 of Spades","5 of Spades","5 of Spades","6 of Spades","6 of Spades","7 of Spades","7 of Spades","8 of Spades","8 of Spades","9 of Spades","9 of Spades","10 of Spades","10 of Spades","Jack of Spades","Jack of Spades","Queen of Spades","Queen of Spades","King of Spades","King of Spades","As of Hearts","As of Hearts","2 of Hearts","2 of Hearts","3 of Hearts","3 of Hearts","4 of Hearts","4 of Hearts","5 of Hearts","5 of Hearts","6 of Hearts","6 of Hearts","7 of Hearts","7 of Hearts","8 of Hearts","8 of Hearts","9 of Hearts","9 of Hearts","10 of Hearts","10 of Hearts","Jack of Hearts","Jack of Hearts","Queen of Hearts","Queen of Hearts","King of Hearts","King of Hearts","As of Diamonds","As of Diamonds","2 of Diamonds","2 of Diamonds","3 of Diamonds","3 of Diamonds","4 of Diamonds","4 of Diamonds","5 of Diamonds","5 of Diamonds","6 of Diamonds","6 of Diamonds","7 of Diamonds","7 of Diamonds","8 of Diamonds","8 of Diamonds","9 of Diamonds","9 of Diamonds","10 of Diamonds","10 of Diamonds","Jack of Diamonds","Jack of Diamonds","Queen of Diamonds","Queen of Diamonds","King of Diamonds","King of Diamonds","As of Clubs","As of Clubs","2 of Clubs","2 of Clubs","3 of Clubs","4 of Clubs","4 of Clubs","5 of Clubs","5 of Clubs","6 of Clubs","6 of Clubs","7 of Clubs","7 of Clubs","8 of Clubs","8 of Clubs","9 of Clubs","9 of Clubs","10 of Clubs","10 of Clubs","Jack of Clubs","Jack of Clubs","Queen of Clubs","Queen of Clubs","King of Clubs","King of Clubs"
};

List<string> cardsToDraw = new List<string>
{
    "As of Spades",
    "As of Spades",
    "2 of Spades",
    "2 of Spades",
    "3 of Spades",
    "3 of Spades",
    "4 of Spades",
    "4 of Spades",
    "5 of Spades",
    "5 of Spades",
    "6 of Spades",
    "6 of Spades",
    "7 of Spades",
    "7 of Spades",
    "8 of Spades",
    "8 of Spades",
    "9 of Spades",
    "9 of Spades",
    "10 of Spades",
    "10 of Spades",
    "Jack of Spades",
    "Jack of Spades",
    "Queen of Spades",
    "Queen of Spades",
    "King of Spades",
    "King of Spades",
    "As of Hearts",
    "As of Hearts",
    "2 of Hearts",
    "2 of Hearts",
    "3 of Hearts",
    "3 of Hearts",
    "4 of Hearts",
    "4 of Hearts",
    "5 of Hearts",
    "5 of Hearts",
    "6 of Hearts",
    "6 of Hearts",
    "7 of Hearts",
    "7 of Hearts",
    "8 of Hearts",
    "8 of Hearts",
    "9 of Hearts",
    "9 of Hearts",
    "10 of Hearts",
    "10 of Hearts",
    "Jack of Hearts",
    "Jack of Hearts",
    "Queen of Hearts",
    "Queen of Hearts",
    "King of Hearts",
    "King of Hearts",
    "As of Diamonds",
    "As of Diamonds",
    "2 of Diamonds",
    "2 of Diamonds",
    "3 of Diamonds",
    "3 of Diamonds",
    "4 of Diamonds",
    "4 of Diamonds",
    "5 of Diamonds",
    "5 of Diamonds",
    "6 of Diamonds",
    "6 of Diamonds",
    "7 of Diamonds",
    "7 of Diamonds",
    "8 of Diamonds",
    "8 of Diamonds",
    "9 of Diamonds",
    "9 of Diamonds",
    "10 of Diamonds",
    "10 of Diamonds",
    "Jack of Diamonds",
    "Jack of Diamonds",
    "Queen of Diamonds",
    "Queen of Diamonds",
    "King of Diamonds",
    "King of Diamonds",
    "As of Clubs",
    "As of Clubs",
    "2 of Clubs",
    "2 of Clubs",
    "3 of Clubs",
    "4 of Clubs",
    "4 of Clubs",
    "5 of Clubs",
    "5 of Clubs",
    "6 of Clubs",
    "6 of Clubs",
    "7 of Clubs",
    "7 of Clubs",
    "8 of Clubs",
    "8 of Clubs",
    "9 of Clubs",
    "9 of Clubs",
    "10 of Clubs",
    "10 of Clubs",
    "Jack of Clubs",
    "Jack of Clubs",
    "Queen of Clubs",
    "Queen of Clubs",
    "King of Clubs",
    "King of Clubs"
};

List<string> cardsPlayer = new List<string>();

List<string> cardsHouse = new List<string>();

void ShowCards()
{
    Console.WriteLine("\nPlayer Cards\n");
    foreach (var item in cardsPlayer)
    {
        Console.WriteLine($"{item} player");
    }
    Console.WriteLine($"\nYou have: {playerCards}\n");

    Console.WriteLine("House Cards\n");
    foreach (var item in cardsHouse)
    {
        Console.WriteLine($"{item} house");
    }
    Console.WriteLine($"\nThe house have: {houseCards}\n");
}


void NeverTheSame()
{
    randomNumber = random.Next(0, cardsToDraw.Count);
}

void DrawACard()
{
    NeverTheSame();
    cardString = cardsToDraw[randomNumber];
    Converter();
    cardsToDraw.RemoveAt(randomNumber);
}

void Converter() 
{
    cardValue = 0;

    if (cardString.Contains("As"))
    {
        if( (playerCards + 11) > 21 )
        {
            cardValue = 1;
        }
        else
        {
            cardValue = 11;
        }
    }
    else if (cardString.Contains("Jack") || cardString.Contains("Queen") || cardString.Contains("King") || cardString.Contains("10"))
    {
        cardValue = 10;
    }
    else
    {
        string character = cardString.Substring(0, 1);
        cardValue = int.Parse(character);
    }
}

void BegginTheGame()
{
    var counter = 0;
    while (counter < 2)
    {
        DrawACard();
        cardsPlayer.Add(cardString);
        playerCards += cardValue;

        DrawACard();
        cardsHouse.Add(cardString);
        houseCards += cardValue;
        counter++;
    }

}

void TheWinnerIs() 
{
    if (houseCards == 21)
    {
        Console.WriteLine("\nthe house win agains you\n");
    }

    else if ((playerCards >= 22 || houseCards >= playerCards) && houseCards <= 20)
    {
        Console.WriteLine("\nthe house win agains you\n");
    }

    else
    {
        Console.WriteLine("\nyou win the game\n");
    }
}

void Cleaning()
{
    cardsToDraw = newDeck;
    cardsPlayer.Clear();
    cardsHouse.Clear();
    playerCards = 0;
    houseCards = 0;
    playerPass = false;
    housePass = false;
    drawControlString = "yes";
}


while (true)
{

    switch (switchControl)
    {

        case "menu":

            Console.WriteLine("Welcome to the C A S I N O");
            Console.WriteLine("Type 21 and enter to play black jack");
            Console.WriteLine("Or type exit and enter to quit");
            switchControl = Console.ReadLine();
            break;

        case "how to play":
            Console.WriteLine("\nTo play 21 black jack you have to know:\n" +
            "The one who has come the closes to the 21 without passing it wins the match\n" +
            "in a tie the house always wins\n" +
            "at the beggining of the match you and your opponent have 2 cards in the table\n" +
            "the score of the cards is: from 2 to 10 they have the value of the card\n" +
            "the cards jack,queen and king all 3 have the same value 10\n" +
            "the As equals 1 or 11 depend if you pass 21 with 11 their value going to be 1");

            Console.WriteLine("\nType 21 and enter to play black jack");
            Console.WriteLine("Or type exit and enter to quit");
            switchControl = Console.ReadLine();
            break;

        case "21":
            BegginTheGame();
            while (!housePass && !playerPass) {

                ShowCards();


                    while (playerCards <= 20 && drawControlString == "yes" && !housePass)
                    {
                        Console.WriteLine("You want to take another card? type yes to draw another card\n");
                        drawControlString = Console.ReadLine();



                            if (houseCards <= 15)
                            {
                                DrawACard();
                                cardsHouse.Add(cardString);
                                houseCards += cardValue;
                                ShowCards();
                    }
                            else
                            {
                                housePass = true;
                            }

                            if (drawControlString == "yes")
                            {
                                DrawACard();
                                cardsPlayer.Add(cardString);
                                playerCards += cardValue;
                                ShowCards();
                            }

                            else if (drawControlString != "yes")
                            {
                                playerPass = true;
                            }
                }






            }

            TheWinnerIs();
            Cleaning();
            Console.WriteLine($"{finalMessage}");
            switchControl = Console.ReadLine();
            break;



        case "exit":
            Environment.Exit(0);   
            break;
            
        default:
            Console.WriteLine("\nERROR GOING BACK TO THE MAIN MENU\n");
            switchControl = "menu";
            break;
    }
}


