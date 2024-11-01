using System.ComponentModel.DataAnnotations;

namespace DiceRoller
{
    public class DiceRoll
    {
        private int num {  get; set; }
        private int val { get; set; }

        private int mod { get; set; }
        public DiceRoll() { }

        public DiceRoll(int num, int val, int mod)
        {
            this.num = num;
            this.val = val;
            this.mod = mod;
        }
        public DiceRoll(int num, int val) 
        { 
            this.num = num;
            this.val = val;
            this.mod = 0;
        }
        public DiceRoll(int val)
        {
            this.num = 1;
            this.val = val;
            this.mod = 0;
        }

        public int Roll()
        {
            var rand = new Random();
            int sum = mod;
            for(int i = 0; i < num; i++)
            {
                sum += rand.Next(1, val);
            }
            return sum;
        }
        public static int Roll(int val)
        {
            var rand = new Random();
            return rand.Next(1,val);
        }

        public static int Roll(int num, int val)
        {
            var rand = new Random();
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += rand.Next(1, val);
            }
            return sum;
        }

        public int Maximum() { return num * val + mod; }

        public int Minimum() { return num + mod; }

        public float Mean() { return ((num * (val-1)) / 2) + num + mod; }



    }
}