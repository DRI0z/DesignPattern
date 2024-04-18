using DesignPattern.Factory;
using DesignPattern.Observer;
using DesignPattern.Singleton;
using Faker;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPattern;

public class Program
{
    static void Main(string[] args)
    {
        TestObserver();
        //TestFactory();
        //TestSingleton();
    }

    private static void TestObserver()
    {
        var bookshop = new Bookshop();
        var clients = new List<Client>();

        for (int i = 0; i < 20; i++)
        {
            Client client = null;
            if (i % 2 == 0)
                client = new(NameFaker.Name(), Authors.Levy);
            else
                client = new(NameFaker.Name(), Authors.Marx);

            bookshop.AddListener(client);
            clients.Add(client);
        }

        bookshop.Supply(Authors.Levy, 1);
        bookshop.Supply(Authors.Marx, 10);

    }

    private static void TestFactory()
    {
        Dialog dialog = new WebDialog();
        dialog.Render();

        dialog = new WindowDialog();
        dialog.Render();
        
        dialog = new MobileDialog();
        dialog.Render();
    }

    private static List<Entity> TestSingleton()
    {
        var entities = new List<Entity>();

        for (int i = 0; i < 10; i++)
        {
            entities.Add(new Entity());
        }

        return entities;
    }
}