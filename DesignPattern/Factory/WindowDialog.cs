namespace DesignPattern.Factory
{
    public class WindowDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowButton();
        }
    }
}
