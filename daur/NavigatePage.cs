using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    public class NavigatePage
    {
        public static void OpenForm<T>(Form currentForm = null) where T : Form, new()
        {
            T newForm = new T();
            newForm.Show();

            // Optionally close the current form if provided
            currentForm?.Hide();
        }
    }
}
