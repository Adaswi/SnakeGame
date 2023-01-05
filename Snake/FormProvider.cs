using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
