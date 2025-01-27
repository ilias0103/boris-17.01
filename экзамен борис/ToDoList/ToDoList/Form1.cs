using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Create columns
            todoList.Columns.Add("��������");
            todoList.Columns.Add("��������");

            // Point our datagridview to our datasource
            toDoListView.DataSource = todoList;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
       
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["��������"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["��������"] = descriptionTextbox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextbox.Text);
            }
            
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";
            isEditing = false;
        }
    }
}
