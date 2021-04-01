using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_2.Forms
{
    public partial class FormQuotation : Form
    {
        public FormQuotation()
        {
            InitializeComponent();
        }

        private void btmPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView.Height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView.Height = height;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(txtProductName.Text,txtPrice.Text,txtQuantity.Text,txtTotal.Text);
        }
        Bitmap bitmap;

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
