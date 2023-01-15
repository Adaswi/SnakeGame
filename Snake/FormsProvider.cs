namespace Snake
{
    public class FormProvider
    {
        public static MainMenu mainmenuForm
        {
            get
            {
                if (_mainmenuForm == null)
                {
                    _mainmenuForm = new MainMenu();
                }
                return _mainmenuForm;
            }
        }
        private static MainMenu _mainmenuForm;
    }
}
