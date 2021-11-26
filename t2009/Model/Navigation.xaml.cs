using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2009.Model
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Navigation : Page
    {
        public Navigation()
        {
        private bool IsAdmin = false;
        private object contentFrame;

        public Navigation()
        {
            IsAdmin = App.CurrentAccount != null && App.CurrentAccount.role == 99;
            this.InitializeComponent();
            this.contentFrame.Navigation(typeof(Page.Add_Contact));
        }

        private void NavigationView_SelectionChanged(NavigationView sender,
            NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                // click nút setting.
                Debug.WriteLine("Select setting.");
            }
            var navigationViewItem = args.SelectedItem as NavigationViewItem;
            switch (navigationViewItem.Tag)
            {
                case "Login":
                    this.contentFrame.Navigation(typeof(Page.Add_Contact));
                    break;
                case "Seech":
                    this.contentFrame.Navigate(typeof(Page.Seech_Contact));
                    break;
              }
        }
    }
}
