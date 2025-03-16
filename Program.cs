// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        // Memanggil method SapaUser dengan input String
        halo.SapaUser("Albert Febrian");
    }
}