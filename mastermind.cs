using System;

class Mastermind {
  static void Main(string[] args) {
    Random random = new Random();

    Console.WriteLine("Welcome to Mastermind, you will have 10 attempts to guess my code");

    int[] code = new int[4];
    for (int i = 0; i < code.Length; i++){
        int randomNumber = random.Next(1,7);
        code[i] = randomNumber;
    }


    int attempt = 0;
    
    while (attempt < 10){
        
        int guessLength = 0;
        string guess = "";
        while (guessLength != 4){
            Console.WriteLine("Try to guess my 4 digit code (Numbers between 1 and 6) Attempt: " + (attempt + 1));
            guess = Console.ReadLine().Replace(" ","");
            guessLength = guess.Length;
            if (guessLength != 4){
                Console.WriteLine("Please enter 4 digits between 1 and 6");
            }
        }

        int[] guessArray = new int[4];
        for (int i = 0; i < guess.Length; i++){
            int guessNumber = (int)Char.GetNumericValue(guess[i]);
            guessArray[i] = guessNumber;
        }

        string[] outputStringArray = new string[4];

        for (int i = 0; i < guessArray.Length; i++){
            if (guessArray[i] == code[i]){
                outputStringArray[i] = "+";
            } else if (Array.Exists(code, element => element == guessArray[i])){
                outputStringArray[i] = "-";
            } else {
                outputStringArray[i] = " ";
            }
        }
        
        string outputString = String.Join(" ",outputStringArray);
        if (outputString == "+ + + +"){
            Console.WriteLine("You have cracked the code!! You Win!!!!");
            break;
        } else {
            Console.WriteLine("'+' is correct number & position, '-' is correct number wrong position, ' ' is an incorrect number");
            Console.WriteLine(outputString);
            Console.WriteLine("- - - -");
            attempt++;
        }

    }

    if (attempt == 10){
        Console.WriteLine("You have run out of guesses, the code was " + code[0] + code[1] + code[2] + code[3]);
    }
  }
}