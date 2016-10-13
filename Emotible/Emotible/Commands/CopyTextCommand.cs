using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.DataTransfer;

namespace Emotible.Commands
{
    public class CopyTextCommand : ICommand
    {
        public static event EventHandler<String> TextCopied;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string content = parameter as string;
            if (content != null)
            {
                DataPackage clipContents = new DataPackage();
                clipContents.SetText(content);
                Clipboard.SetContent(clipContents);

                TextCopied?.Invoke(this, content);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
