using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Emotible.Commands;
using Emotible.Controller;
using Emotible.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Emotible
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataAccessController dal = new DataAccessController();
            var emote = dal.AddEmote();

            hamburger.OptionsItemsSource = new List<MenuItemViewModel>()
            {
                new MenuItemViewModel() { Icon = Symbol.Add, Name = "New Emoticon" },
                new MenuItemViewModel() { Icon = Symbol.Help, Name = "Help and About" },
            };

            CopyTextCommand.TextCopied += (obj, text) =>
            {
                var textCopied = new TextCopiedConfirmationControl();
                textCopied.Text = text;
                applicationFrame.Children.Add(textCopied);
            };
        }
    }
}
