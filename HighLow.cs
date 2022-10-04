private static Random rnd = new Random();

class cards {
    List<int> deck = new List<int>();

    public cards() {
        for (int i=1; i<=13; i++) {
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
        }
    }

    public void refill(){
        
    }

}

class game {
    int points = 300;

    cards cards = new cards();


    public int DrawCard(List<int> cards){

        Random r = new Random();
        int amount= cards.Count();
        if (amount == 0)
        {
            Console.WriteLine("Need Card refill");
            
        }
        int genRand = r.Next(1,amount);
        int chosen = cards[genRand];
        cards.RemoveAt(genRand);

        return chosen;
    }



    public int draw(int points, int last, List<int> cards){
        Console.WriteLine($"Points: {points}");
        Console.WriteLine($"Last card is: {last}");
        Console.WriteLine($"Higher or Lower? [h/n]");

        Console.Read();
        int card = DrawCard(cards);
        Console.WriteLine($"The card was {card}");
        Console.WriteLine($"You now have {points} points");
        return card;
    }
}