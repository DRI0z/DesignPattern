namespace DesignPattern.Singleton
{
    public class DatabaseManager
    {
        private static DatabaseManager? cachedInstance;
        private DatabaseManager() 
        {
            Console.WriteLine("Démarage du gestionnaire de BDD ...");
            Thread.Sleep(2000);
            Console.WriteLine("Destionnaire de BDD démaré...");
        }

        public void Save()
        {
            Console.WriteLine("Enregistrement effectué");
        }

        public static DatabaseManager GetInstance()
        {
            return cachedInstance ??= new();
        }

    }
}
