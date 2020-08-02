using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    //Cup is the fabricated class which does not represent any domain concept, 
    //but is responsible for delegating the tasks to other classes. 
    class Cup
    {
        private List<Die> dice = new List<Die>();

        private int getTotalFaceValue;
        public List<Die> Dice
        {
            get => this.dice;
            set => this.dice = value;
        }

        public Cup()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            dice.Add(die1);
            dice.Add(die2);
        }
        public void RollDie()
        {
            this.Dice[0].FaceValue = "0";
            this.Dice[1].FaceValue = "0";
            Random rollingDice = new Random();
            this.Dice[0].FaceValue = rollingDice.Next(1, 6).ToString();
            this.Dice[1].FaceValue = rollingDice.Next(1, 6).ToString();
            Console.WriteLine("Rolling the dice: {0}, {1} ",this.Dice[0].FaceValue,this.Dice[1].FaceValue);

        }

        public int GetTotalFaceValue()
        {
            int sum = int.Parse(this.Dice[0].FaceValue) + int.Parse(this.Dice[1].FaceValue);
            Console.WriteLine("Calculating the total face value after rolling the dice : {0}",sum);
            return sum;
        }





    }
}
