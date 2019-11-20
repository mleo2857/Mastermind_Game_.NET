using System;

class Mastermind {
  static void Main(string[] args) {
    int[] code = {4,7,2,9};
    Console.WriteLine(Array.Exists(code, element => element == 8));
  }
}