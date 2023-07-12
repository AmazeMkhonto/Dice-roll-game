using System;

class Game{
    public static void Main(string[] args)
    {
       int number = numberGenerator();
       System.Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries."); 
       string userInput = Console.ReadLine();
       int guess = int.Parse(userInput);
        int count = 1;
        while (guess != number){
             

            if(count > 3){
                System.Console.WriteLine("ran out of guesses");
                break;
            }
            System.Console.WriteLine("guess is wrong, guess again");
            System.Console.WriteLine("this is what count is: "+count);
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            count++;
       }
       if(guess == number){
        System.Console.WriteLine("you won");
       } else {
        System.Console.WriteLine("you lost bitch");
       }
    }

    public static int numberGenerator(){
        Random random = new Random();
        int number = random.Next(1,7);
        return number;
    }


}