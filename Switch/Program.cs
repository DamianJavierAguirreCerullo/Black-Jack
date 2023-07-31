

// var cards = [1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13];

//string message = "";

//var myCards = 2;

//switch(myCards)
//{
//    case 1:
//        message = "one";
//        break;

//    case 2:
//        message = "two";
//        break;

//    case 3:
//        message = "error";
//        break;
//}


//Console.WriteLine($"the number is {message}");


using static System.Net.Mime.MediaTypeNames;

string message;

var myCards = 20;

var houseCards = 20;

string switchControl = "menu";

int num = 0;

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


System.Random random = new System.Random();
//num = random.Next(0,103);
//cardsToDraw.RemoveAt(num);
//num = random.Next(0,103);
//cardsToDraw.RemoveAt(num);
cardsToDraw.RemoveAt(0);
cardsToDraw.RemoveAt(0);

Console.WriteLine("there are : {0} in the deck\n", cardsToDraw.Count);


foreach (var item in cardsToDraw)
{
    Console.WriteLine(item);
}

cardsToDraw = newDeck;
Console.WriteLine("\nthere are : {0} in the deck",cardsToDraw.Count);
Console.WriteLine(cardsToDraw.Contains("Jack of Spades"));



/*
while (true)
{
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Welcome to the C A S I N O ");
            Console.WriteLine("type 21 to play black jack");
            Console.WriteLine("or type exit to quit");
            switchControl = Console.ReadLine();
            break;

        case "21":
            do
            {
                
                System.Random random = new System.Random();
                num = random.Next(0, 103);
                Console.WriteLine("Take your card");
                Console.WriteLine($"Your card is : {num}");

            } while (Console.ReadLine() == "yes");

            if (myCards <= 21 && (myCards > houseCards))
            {
                message = "you win the game";
                switchControl = "menu";
            }

            else if (myCards >= 22)
            {
                message = "you have exceed the limit";
                switchControl = "menu";
            }

            else
            {
                message = "the house win agains you";
                switchControl = "menu";
            }

            Console.WriteLine(message);
            break;

        case "exit":
            Environment.Exit(0);   
            break;
            
        default:
            Console.WriteLine("error");
            break;
    }
}
*/

