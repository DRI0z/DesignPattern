using DesignPattern.Factory;
using DesignPattern.Singleton;

namespace DesignPattern;

public class Program
{
    static void Main(string[] args)
    {
        TestFactory();
    }

    private static void TestFactory()
    {
        var dialog = new WebDialog();
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