using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genres_Movie_RepositoryExample
{
   public static class Utility
    {
        public static void  Eraser (GroupBox groupbox)
        {
            foreach (Control item in groupbox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
            
        }
    }
}
