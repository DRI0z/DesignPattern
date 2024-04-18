namespace DesignPattern.Factory
{
    public class MobileDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new FingerButton();
        }
    }
}
