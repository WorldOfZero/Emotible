using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Emotible.ViewModels
{
    public class EmoteViewModel
    {
        public string Content { get; set; }
        public ICommand OnClick { get; set; }
    }
}
