using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Choice
    {
        public void Decide(int outcome){
            if(outcome==0)
                Console.WriteLine("Choice-No Plays!");
            else if(outcome==1){
                Console.WriteLine("Choice-Ladder!");
                Program.player+=outcome;
            }else{
                Console.WriteLine("Choice-Snake");
                Program.player=Math.Max(Program.player-outcome,0);
            }
            Console.WriteLine("Player Position: " + Program.player+"\n-------------------------");
        }

    }
}