namespace Rpg.src.Entities{
    class Program{
        static void Main(string[] args){
            Knight arus = new Knight("Arus", 23, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            WhiteWizard jenica = new WhiteWizard("Jenica", 28, "White Wizard");
            BlackWizard topapa = new BlackWizard("Topapa", 19, "Black Wizard");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack(8));
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(topapa.Attack(6));
        }
    }
}
