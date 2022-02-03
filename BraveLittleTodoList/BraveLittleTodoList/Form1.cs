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

    }
}
