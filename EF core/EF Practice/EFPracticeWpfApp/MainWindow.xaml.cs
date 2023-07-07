using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows; 
namespace EFPracticeWpfApp;
public partial class MainWindow : Window
{
    private List<string> tableList = new() { "Faculty", "Subject", "Group" ,"Teacher","Department"};
    public MainWindow()
    {
        InitializeComponent();  

        comboBox.ItemsSource = tableList;

        this.Closing += Window_Closing!;
    }
    private void Search_Btn_Click(object sender, RoutedEventArgs e)
    {
        ObservableCollection<string> list = new();
        if (comboBox.Text == tableList[0])
        {
            list = TablesInfo.ShowFaculty();
            tableTextBlock.Text = "Faculty";
        }
        else if (comboBox.Text == tableList[1])
        {
            list = TablesInfo.ShowSubjects();
            tableTextBlock.Text = "Subject";
        }
        else if (comboBox.Text == tableList[2])
        {
            list = TablesInfo.ShowGroup();
            tableTextBlock.Text = "Group";
        }
        else if (comboBox.Text == tableList[3]) { 
            list = TablesInfo.ShowTeachers();
            tableTextBlock.Text = "Teacher";
        }
        else if (comboBox.Text == tableList[4]) {
            list = TablesInfo.ShowDepartment();
            tableTextBlock.Text = "Department";
        }
        listBox.ItemsSource = list;
    }
    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        TablesInfo.context.Dispose();
    } 
}