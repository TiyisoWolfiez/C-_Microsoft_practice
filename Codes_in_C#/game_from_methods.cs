/*------------------GAME--------------------*/
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay(){

    string answer = Console.ReadLine();
    return answer.ToLower().Equals("y");
}

int GetTarget(){
    int target = random.Next(1,6);
    return target;
    // return random.Next(1,6);
}

int RollDice(){
    int roll = random.Next(1,7);
    return roll;
    // return random.Next(1,7);
}

string WinOrLose(int roll, int target){
    if(roll > target){
        return "You win!";
    }
    return "You lose!";
}

/*-------------------END-GAME--------------------*/
