namespace DesignPattern.Factory
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public void Render()
        {
            var button = CreateButton();
            button.Render();
            Console.WriteLine("Affichage d'une boite de dialog");
        }
    }
}
