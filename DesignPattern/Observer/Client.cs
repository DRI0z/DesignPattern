namespace DesignPattern.Observer
{
    public class Client : IAuthorListener
    {
        public readonly string Name;
        public readonly Authors FavoriteAuthors;

        public Client(string name, Authors favoriteAuthors)
        {
            Name = name;
            FavoriteAuthors = favoriteAuthors;
        }

        public void OnBookAdded(int added)
        {
            Console.WriteLine($"Mon nom est {Name}, j'aime {FavoriteAuthors} et je suis content d'apprendre que j'ai {added} nouveaux livre(s) à lire");
        }
    }
}
