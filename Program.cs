// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T Data;

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);

    }
}

class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Albert Febrian");
    

        DataGeneric<long> dataNim = new DataGeneric<long>(103022300003);

        dataNim.PrintData();
    }
}

