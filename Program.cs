namespace DeckOfCards{
    class Program{
        public static void Main(string [] args){
            Random rnd=new Random();
            for(int i=1;i<=9;i++)
                Player.AddCard();
            Player.Display();
        }
    }
}