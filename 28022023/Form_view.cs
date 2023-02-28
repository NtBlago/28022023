using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28022023
{
    public partial class Form_view : Form
    {
        public Form_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "product_view.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.product_view.Product);

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form_redakt fm = new Form_redakt();
            fm.Show();
        }

        private void Dellete_button_Click(object sender, EventArgs e)
        {
            Form_redakt fm = new Form_redakt();
                fm.Show();
        }
    }
}
