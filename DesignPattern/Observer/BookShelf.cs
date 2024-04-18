namespace DesignPattern.Observer
{
    public class BookShelf
    {
        private int Count { get; set; }

        public BookShelf() 
        {
            Count = 0;
        }

        public void AddBooks(int count)
        {
            Count += count;
        }

        public int GetCount()
        {
            return Count;
        }
    }
}
