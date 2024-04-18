using DesignPattern.Factory;
using DesignPattern.Observer;
using DesignPattern.Singleton;

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