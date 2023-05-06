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
                if(!Program.turn){
                    if(Program.player+outcome<=100)
                        Program.player+=outcome;
                }else{
                    if(Program.playerB+outcome<=100)
                        Program.playerB+=outcome;
                }
            }
            else if(outcome==100){
                Console.WriteLine("Choice-Snake");
                if(!Program.turn)
                    Program.player=Math.Max(Program.player-outcome,0);
                else
                    Program.playerB=Math.Max(Program.playerB-outcome,0);
            }
            if(Program.turn)    
                Program.turn=false;
            else    
                Program.turn=true;
            Console.WriteLine("Player Positions: " + Program.player+" "+Program.playerB+"\n-------------------------");
        }

    }
}