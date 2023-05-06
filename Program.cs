namespace SnakeAndLadder{
    class Program{

        public static int player=0,diceRolled=0,playerB=0;
        public static bool turn=false;
        public static void Main(string[] args){
            
            Program obj=new Program();
            Rolling roll=new Rolling();
            Choice choice=new Choice();
            Console.WriteLine("Player Position: "+Program.player+" "+Program.playerB+"\n---------------------");
            while(Program.player<100 && Program.playerB<100){
                choice.Decide(roll.Roll());
                Program.diceRolled++;
            }
            Console.WriteLine("PlayerA Position: "+Program.player+"\nPlayerB position: "+Program.playerB);
            if(Program.player==100)
                Console.WriteLine("Player A Won by "+(Program.player-Program.playerB)+" points");
            else
                Console.WriteLine("Player B Won by "+(Program.playerB-Program.player)+" points");
            Console.WriteLine("Total Dice Rolled: "+Program.diceRolled);
        }
    }
}