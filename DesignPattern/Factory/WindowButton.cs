namespace DesignPattern.Factory
{
    public class WindowButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Affichage du bouton pour Windows");
        }
    }
}
