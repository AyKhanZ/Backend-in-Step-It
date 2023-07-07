using LoginPassSql.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace LoginPassSql
{
    public partial class Form1 : Form
    {
        UserDbContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new();

            dbContext.Users.Load();

            dataGridView.DataSource = dbContext.Users.Local.ToBindingList();
            this.Closing += Home_Closing;
        }

        private void Home_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dbContext.Dispose();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        { 
            Dictionary<string, string> LogPass = new();
            foreach (var item in dbContext.Users.Local.ToBindingList())
            {
                LogPass[item.Login] = item.Password;
            }
            if (LogPass.ContainsKey(textBoxLogin.Text))
            {
                if (LogPass[textBoxLogin.Text] == textBoxPassword.Text) MessageBox.Show("You are our user!\nCongratulations!");
                else MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("We don\'t have user with login like this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}