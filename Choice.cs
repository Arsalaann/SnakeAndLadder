using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Choice
    {
        public void Decide(int outcome){
            Program obj=new Program();
            if(outcome==0)
                Console.WriteLine("Choice-No Plays!");
            else if(outcome==1){
                Console.WriteLine("Choice-Ladder!");
                obj.player+=outcome;
            }else{
                Console.WriteLine("Choice-Snake");
                obj.player-=outcome;
            }
            Console.WriteLine("Player Position: " + obj.player);
        }

    }
}