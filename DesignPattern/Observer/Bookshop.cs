namespace DesignPattern.Observer
{
    public class Bookshop
    {
        public readonly Dictionary<Authors, BookShelf> Inventory;

        public Bookshop()
        {
            Inventory = new();
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
        }

        public int? GetCount(Authors authors)
        {
            return Inventory.GetValueOrDefault(authors)?.GetCount();
        }


    }
}
