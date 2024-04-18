namespace DesignPattern.Observer
{
    public class Client
    {
        public readonly string Name;
        public readonly Authors FavoriteAuthors;

        public Client(string name, Authors favoriteAuthors)
        {
            Name = name;
            FavoriteAuthors = favoriteAuthors;
        }
    }
}
