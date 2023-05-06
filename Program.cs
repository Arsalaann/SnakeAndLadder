namespace SnakeAndLadder{
    class Program{

        public int player=0;
        public static void Main(string[] args){
            Console.WriteLine("Player Position: 0");
            Rolling roll=new Rolling();
            Choice choice=new Choice();
            choice.Decide(roll.Roll());
        }
    }
}