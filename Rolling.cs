using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Rolling
    {
        public int Roll(){
            Random rnd=new Random();
            int outcome=rnd.Next(1,7);
            return outcome;
        }
    }
}