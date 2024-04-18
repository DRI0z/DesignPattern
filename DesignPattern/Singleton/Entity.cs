namespace DesignPattern.Singleton
{
    public class Entity
    {
        public Entity() 
        {
            Console.WriteLine("Création de l'entité ...");
            Console.WriteLine("Sauvegarde de l'entité ...");
            var dbManager = DatabaseManager.GetInstance();
            dbManager.Save();
            Console.WriteLine("L'entité à été sauvegarder...");
        }
    }
}
