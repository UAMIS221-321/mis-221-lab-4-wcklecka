//main

int userChoice = GetUserChoice();   


while(userChoice != 3)  
{
     RouteEm(userChoice);
     userChoice = GetUserChoice();   
}


static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}


//menu
static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("TRIANGLE GENERATOR\n\n-ENTER 1- Mint Condition Triangle (full)\n-ENTER 2- Modern Day Condition Triangle (partial)\n-ENTER 3- Exit");
}


static bool IsValidChoice(string userInput) {
    if(userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    return false;
}


//full triangle 
static void GetFull() {
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    for(int i = 1; i <= number; i++) {
        for(int j = 1; j<= i; j++) {
            System.Console.Write("0");
        }
        System.Console.WriteLine(" ");
    }
    PauseAction();
}


//partial triangle
static void GetPartial() {
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    for(int i = 1; i <= number; i++) {
        for(int j = 1; j<= i; j++)  {
            int decomp = rnd.Next(2);
            if(decomp != 1) {
                System.Console.Write("0");
            }
        }
        System.Console.WriteLine(" ");
    }
    PauseAction();
}


static void SayInvalid() {
    System.Console.WriteLine("Invaild\nPlease -ENTER- correct number");
}


static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2) {
        GetPartial();
    }
    else if(menuChoice!=3) {
        SayInvalid();
        PauseAction();
    }
}


static void PauseAction() {
    System.Console.WriteLine("\nPress any key to go back...");
    Console.ReadKey();
}
