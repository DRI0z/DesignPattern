namespace DesignPattern.Factory
{
    public class HtmlButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Affichage du bouton pour le Web");
        }
    }
}
