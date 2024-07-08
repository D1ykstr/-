using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        Point Last;
        //обработчик нажатия на панель
        private void MD(object sender, MouseEventArgs e)
        {
            Last = new Point(e.X, e.Y);
        }
        //обработчик перемещения панели
        private void MV(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Last.X;
                this.Top += e.Y - Last.Y;
            }
        }
        //закрытие формы
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
