using System.ComponentModifierel.DataAnnotations;
using System.Windows.Controls;

namespace DiceRoller
{
    public class DiceRoll
    {
        private int NumOfDice {  get; set; }
        private int Sides { get; set; }

        private int Modifier { get; set; }

        private void ParameterExceptionCatcher(int NumOfDice, int Sides)
        {
            if(NumOfDice < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(NumOfDice), NumOfDice, "NumOfDice must be an integer with a value of at least 1");
            }

            if (Sides < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Sides), Sides, "Sides must be an integer with a value of at least 1");
            }
            
        }
        //public DiceRoll() { }

        public DiceRoll(int NumOfDice, int Sides, int Modifier)
        {
            ParameterExceptionCatcher(NumOfDice, Sides);
            this.NumOfDice = NumOfDice;
            this.Sides = Sides;
            this.Modifier = Modifier;
        }
        public DiceRoll(int NumOfDice, int Sides) 
        {
            ParameterExceptionCatcher(NumOfDice, Sides);
            this.NumOfDice = NumOfDice;
            this.Sides = Sides;
            Modifier = 0;
        }
        public DiceRoll(int Sides)
        {
            ParameterExceptionCatcher(1, Sides);
            NumOfDice = 1;
            this.Sides = Sides;
            Modifier = 0;
        }

        public int Roll()
        {
            var rand = new Random();
            int sum = Modifier;
            for(int i = 0; i < NumOfDice; i++)
            {
                sum += rand.Next(1, Sides);
            }
            return sum;
        }
        public static int Roll(int Sides)
        {
            if (Sides < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Sides), Sides, "Sides must be an integer with a value of at least 1");
            }
            var rand = new Random();
            return rand.Next(1,Sides);
        }

        public static int Roll(int NumOfDice, int Sides)
        {
            if (NumOfDice < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(NumOfDice), NumOfDice, "NumOfDice must be an integer with a value of at least 1");
            }

            if (Sides < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Sides), Sides, "Sides must be an integer with a value of at least 1");
            }
            var rand = new Random();
            int sum = 0;
            for (int i = 0; i < NumOfDice; i++)
            {
                sum += rand.Next(1, Sides);
            }
            return sum;
        }

        public int Maximum() { return NumOfDice * Sides + Modifier; }

        public int Minimum() { return NumOfDice + Modifier; }

        public float Mean() { return ((NumOfDice * (Sides-1)) / 2) + NumOfDice + Modifier; }



    }
}