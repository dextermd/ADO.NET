using CreateReadADONET;

public class Program
{
    public static void Main(string[] args)
    {
        DBHelper db = new DBHelper();

        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        db.Add("Computer", "Gadgets", 15000.49m);
        
        Console.ReadKey();
    }
}
