using singleton;

public class Program
{
    public static void Main()
    {
        DatabaseConnection d1 = DatabaseConnection.Instance;
        DatabaseConnection d2 = DatabaseConnection.Instance;

        if (ReferenceEquals(d1, d2))
        {
            Console.WriteLine("Both instances are the same Singleton instance.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }

        d1.connect();
        d2.disconnect();
    }
}