namespace SnakeAndLadder{
    class Program{

        public static int player=0;
        public static void Main(string[] args){
            Program obj=new Program();
            Rolling roll=new Rolling();
            Choice choice=new Choice();
            Console.WriteLine("Player Position: "+Program.player+"\n---------------------");
            while(Program.player<100)
                choice.Decide(roll.Roll());
        }
    }
}