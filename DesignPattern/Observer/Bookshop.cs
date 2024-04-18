namespace DesignPattern.Observer
{
    public class Bookshop
    {
        public readonly Dictionary<Authors, BookShelf> Inventory;
        public readonly List<IAuthorListener> AuthorListeners;

        public Bookshop()
        {
            Inventory = [];
            AuthorListeners = [];
        }

        public void Supply(Authors authors, int count)
        {
            if(Inventory.Any(x => x.Key == authors))
            {
                Inventory.FirstOrDefault(x => x.Key == authors).Value.AddBooks(count);
            }
            else
            {
                var bookShelf = new BookShelf();
                bookShelf.AddBooks(count);
                Inventory.Add(authors, bookShelf);
            }

            foreach(var authorListener in AuthorListeners)
            {
                authorListener.OnBookAdded(count);
            }
        }

        public int? GetCount(Authors authors)
        {
            return Inventory.GetValueOrDefault(authors)?.GetCount();
        }

        public void AddListener(Client client)
        {
            AuthorListeners.Add(client);
        }

        public void RemoveListener(Client client)
        {
            AuthorListeners?.Remove(client);
        }


    }
}
