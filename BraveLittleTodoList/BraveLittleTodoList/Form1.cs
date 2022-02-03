using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BraveLittleTodoList.Model;

namespace BraveLittleTodoList
{
    public partial class Form1 : Form
    {
        private tlDBContext tlContext;

        public Form1()
        {
            InitializeComponent();

            tlContext = new tlDBContext();

            var Statuses = tlContext.Statuses.ToList();

            foreach(Status s in Statuses)
            {
                cboStatus.Items.Add(s);
            }

        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTodo.Text !=String.Empty)
            {
                var newTask = new Model.Task
                {
                    Name = txtTodo.Text,
                    StatusId = (cboStatus.SelectedItem as Model.Status).Id,
                    DueDate = dateTimePicker1.Value
                };
                tlContext.Tasks.Add(newTask);
                tlContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Please make sure you entered a task in the Taskbox.");
            }
        }
    }
}
