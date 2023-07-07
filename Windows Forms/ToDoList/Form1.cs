using System.Text.RegularExpressions;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void IsImportant_checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void desc_label_Click(object sender, EventArgs e)
        {

        }

        private void IsImportant_checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            Regex regex = new("[a-z,A-Z,0-9,/,.!]");
            int NameLen = name_textBox.Text.Length;
            int DescLen = desc_textBox1.Text.Length;
            if ( NameLen > 0 && DescLen > 0 && regex.IsMatch(name_textBox.Text) && regex.IsMatch(desc_textBox1.Text))
            {
                ToDo newtodo = new()
                {
                    Name = name_textBox.Text,
                    Desc = desc_textBox1.Text,
                    IsImportant = IsImportant_checkBox1.Checked,
                    Date = dateTimePicker1.Value
                };
                task_listBox1.Items.Add(newtodo);
            }
            else
            {
                MessageBox.Show(
                    "Name and description length should be more than 1 simbol!",
                    "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
            name_textBox.Text = null;
            desc_textBox1.Text = null;
            IsImportant_checkBox1.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void task_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDo SelectedToDo = task_listBox1.SelectedItem as ToDo;
            MessageBox.Show(SelectedToDo.ShowFull());

            
        }

        private void df(object sender, EventArgs e)
        {

        }
    }
}