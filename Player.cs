namespace DeckOfCards
{
    public class Player{
        static public int [,]card=new int[9,3];
        static int serialNumber; 
        public static void AddCard(){
            Random rnd=new Random();
            Player.card[Player.serialNumber,0]=rnd.Next(2);
            Player.card[Player.serialNumber,1]=rnd.Next(2);
            Player.card[Player.serialNumber,2]=rnd.Next(1,14);
            Player.serialNumber++;
        }
        public static void Display(){
            int sn=1;
            for(int i=0; i<9;  i++,sn++){
                Console.Write(sn+")");
                if(card[i,0]==0){//Red or Black
                    Console.Write(" RED  ");
                    if(card[i,1]==0)
                        Console.Write(" DIAMOND ");
                    else
                        Console.Write(" HEARTS ");
                }else{
                    Console.Write(" BLACK ");
                    if(card[i,1]==0)
                        Console.Write(" SPADE ");
                    else
                        Console.Write(" CLUBS ");
                }
                switch(card[i,2]){
                    case 1:
                        Console.Write(" ACE ");
                        break;
                    case 11:
                        Console.Write(" JACK ");
                        break;
                    case 12:
                        Console.Write(" KING ");
                        break;
                    case 13:
                        Console.Write(" QUEEN ");
                        break;
                    default:
                        Console.Write(card[i,2]+1);
                        break;
                }
                Console.WriteLine();
            }
        }
        
    }
}