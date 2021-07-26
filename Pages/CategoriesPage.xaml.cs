using System.Windows;
using System.Windows.Controls;
using NavigationDBExample;
using NavigationDBExample.Models;

namespace NavigationDBExample.Pages
{
    /// <summary>
    /// Interaction logic for CategoriesPage.xaml
    /// </summary>
    public partial class CategoriesPage : Page
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            _ = this.NavigationService.Navigate(new MainPage());
        }

        private void AddCategory(object sender, RoutedEventArgs e)
        {
            if(NewCategoryName.Text != "")
            {
                using var dbContext = new SqliteDBContext();
                dbContext.Categories.Add(new() { CategoryName = NewCategoryName.Text });
                dbContext.SaveChanges();
                NewCategoryName.Text = "";
                _ = this.NavigationService.Navigate(new MainPage());
            }
        }
    }
}
