class Board {
// use camel case. ThisIsCamelCase. Snake case is this_is_snake_case

    List<string> board = new List<string>();
    //type        name        brand new list of strings is the property

    public Board() {
        for (int i=1; i<=9; i++) {
            board.Add(i.ToString());
        }
    }

    // method
    // void is the return type, which is void aka nothing, then print is the NAME, just a name
    public void print() {
            Console.WriteLine($"{board[0]}│{board[1]}│{board[2]}\n──┼──┼── \n{board[3]}│{board[4]}│{board[5]}\n──┼──┼── \n{board[6]}│{board[7]}│{board[8]}");
    }
}