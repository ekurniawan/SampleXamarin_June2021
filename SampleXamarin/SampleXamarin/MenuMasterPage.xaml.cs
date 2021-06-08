using SampleXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMasterPage : ContentPage
    {
        private ObservableCollection<MyMenuItem> menuItem;
        public ListView ListView { get; set; }
        public MenuMasterPage()
        {
            InitializeComponent();
            menuItem = new ObservableCollection<MyMenuItem>
            {
                new MyMenuItem{Id=0,Title="Main Menu",TargetType=typeof(MainPage),ImageIcon="ic_add.png"},
                new MyMenuItem{Id=1,Title="Simple List",TargetType=typeof(ContohListView),ImageIcon="ic_add.png"},
                new MyMenuItem{Id=2,Title="List Image",TargetType=typeof(ListViewImagePage),ImageIcon="ic_add.png"},
                new MyMenuItem{Id=3,Title="Custom List",TargetType=typeof(ListViewWithViewCellPage),ImageIcon="ic_add.png"},
                new MyMenuItem{Id=4,Title="Tabbed Page",TargetType=typeof(MyTabbedPage),ImageIcon="ic_add.png"}
            };

            menuItemListView.ItemsSource = menuItem;
            ListView = menuItemListView;
        }
    }
}