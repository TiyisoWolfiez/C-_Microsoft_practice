// Code challenge - write code to implement the game rules

/*Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner. */

int hero = 10, monster = 10;

Random random= new Random();
// int attacks = random.Next(1,10);

do{
    int heroAttacks = random.Next(1, 11);
    monster -= heroAttacks; // monster = monster - heroAttacks;
    Console.WriteLine("Monster's remaining health is "+ monster +", and it lost "+heroAttacks);

    if(monster > 0){
        int monsterAttacks = random.Next(1,11);
        hero -= monsterAttacks; // monster = monster - heroAttacks;
    Console.WriteLine("Hero's remaining health is "+ hero +", and it lost "+monsterAttacks);
    }

} while(hero > 0 && monster > 0);

if(hero > monster){
    Console.WriteLine("Hero is the Winner");
} else{
    Console.WriteLine("Monster Won!");
}
