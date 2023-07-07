using EFHW1_CRUDWpfApp.Data.DbContexts;
using EFHW1_CRUDWpfApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Windows;

namespace EFHW1_CRUDWpfApp
{
    public partial class MainWindow : Window
    {
        UniversityContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new();
            db.Groups.Load();

            Info_Grid.ItemsSource = db.Students.Include(x => x.Group).ToList();
            ComboBox_GroupId.ItemsSource = db.Groups.Local.ToBindingList();
            this.Closing += Home_Closing;

        }
        private void Home_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            if (Textbox_Name.Text.Trim() != "" && Textbox_Surname.Text.Trim() != "" && !ComboBox_GroupId.Text.IsNullOrEmpty())
            {
                db.Add(new Student { Name = Textbox_Name.Text, Surname = Textbox_Surname.Text, GroupId = Int32.Parse(ComboBox_GroupId.Text) });
                db.SaveChanges();
                Textbox_Name.Text = "";
                Textbox_Surname.Text = "";
                ComboBox_GroupId.SelectedItem = null;
                Info_Grid.ItemsSource = db.Students.Include(x => x.Group).ToList();
            }
            else MessageBox.Show("All fields are require!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Btn_Update_Click(object sender, RoutedEventArgs e)
        {
            if (Info_Grid.SelectedItem != null && Info_Grid.SelectedItems.Count == 1)
            {
                db.Students.Update((Student)Info_Grid.SelectedItem);
                db.SaveChanges(); 
                Info_Grid.ItemsSource = db.Students.Include(x => x.Group).ToList();
            }
            else MessageBox.Show("Select one row");
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Info_Grid.SelectedItems.Count >= 0)
            {
                int count = Info_Grid.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    db.Students.Remove((Student)Info_Grid.SelectedItems[0]);
                    db.SaveChanges();
                }
                Info_Grid.ItemsSource = db.Students.Include(x => x.Group).ToList();
            }
            else MessageBox.Show("Select row(s)!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
