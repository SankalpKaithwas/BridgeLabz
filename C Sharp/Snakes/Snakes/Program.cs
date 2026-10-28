
using System;

namespace Snakes
{
    public class SnakesAndLadders
    {
        private int _playerOnePos = 0;
        private int _playerTwoPos = 0;
        public static int RollDice()
        {
            return new Random().Next(1, 7);
        }

        public static int PlayerTurns(int Position) //29
        {
            //  int position = 0;
            int rollDice = RollDice();

            int checkOption = new Random().Next(0, 3);
            switch (checkOption)    //Player checks an option
            {   // No play
                case 0:
                    Position += 0;
                    break;
                // Ladder
                case 1:
                    int rollAgain = RollDice();
                    int current = Position + rollAgain;
                    if (current <= 100)
                    {
                        Position += rollAgain;
                    }
                    break;
                // Snake bite
                case 2:
                    if (Position > 0)
                    {
                        Position -= rollDice;
                    }
                    break;
            }
            return Position;

        }

        public void CheckWin()
        {
            int playerOne;
            int playerTwo;
            while (_playerOnePos != 100 && _playerTwoPos != 100)
            {
                //Player One
                if (_playerOnePos <= 100)
                {
                    playerOne = PlayerTurns(_playerOnePos);
                    _playerOnePos = playerOne;
                }

                //Player two
                if (_playerTwoPos <= 100)
                {
                    playerTwo = PlayerTurns(_playerTwoPos);
                    _playerTwoPos = playerTwo;
                }

            }
            if (_playerOnePos == 100)
            {
                Console.WriteLine("Player One wins");
            }

            else if (_playerTwoPos == 100)
            {
                Console.WriteLine("Player Two wins");
            }
        }
    }

    internal class Program
    {
        public enum EnumDemo
        {
            summer = 1,
            spring = 10,
            Autumn,
            winter
        }
        static void Main(string[] args)
        {
            SnakesAndLadders winner = new SnakesAndLadders();
            winner.CheckWin();

            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);

        }
    }
}


