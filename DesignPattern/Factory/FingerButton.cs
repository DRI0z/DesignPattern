namespace DesignPattern.Factory
{
    public class FingerButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Affichage du bouton pour le Mobile");
        }
    }
}
