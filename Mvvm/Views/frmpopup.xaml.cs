using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mvvm.Views
{
    /// <summary>
    /// Interaction logic for frmpopup.xaml
    /// </summary>
    public partial class frmpopup : Window
    {
        public frmpopup()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private frmpopup.enmAction action;

        private int x, y;


        private bool CheckOpened(string name)
        {
            FormCollection fc = System.Windows.Forms.Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {

        }

        public void showAlert(string msg)//, enmType type)
        {
            this.Opacity = 0.0;

            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                //CheckOpened(fname);
                frmpopup frm = new frmpopup();

                if (CheckOpened(fname) == false)
                {
                    this.Name = fname;
                    this.x = (int)(Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15);
                    this.y = (int)(Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i);
                    //this.Location = new Point(this.x, this.y);
                    frm.Left = this.x;
                    frm.Top = this.y;
                    //frm.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
                    //this.WindowStartupLocation = m
                    break;
                }
                this.x = (int)(Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5);

                //switch (type)
                //{
                //    case enmType.Success:
                //        this.pictureBox1.Image = Resources.success;
                //        this.BackColor = Color.SeaGreen;
                //        break;
                //    case enmType.Error:
                //        this.pictureBox1.Image = Resources.error;
                //        this.BackColor = Color.DarkRed;
                //        break;
                //    case enmType.Info:
                //        this.pictureBox1.Image = Resources.info;
                //        this.BackColor = Color.RoyalBlue;
                //        break;
                //    case enmType.Warning:
                //        this.pictureBox1.Image = Resources.warning;
                //        this.BackColor = Color.DarkOrange;
                //        break;
                //}
                this.txtmessage.Text = msg;
                this.Show();
                this.action = enmAction.start;
                //this.timer1.Interval = 1;
                //this.timer1.Start();
            }

            //private void timer1_Tick(object sender, EventArgs e)
            //{
            //    switch (this.action)
            //    {
            //        case enmAction.wait:
            //            timer1.Interval = 5000;
            //            action = enmAction.close;
            //            break;
            //        case frmAlert.enmAction.start:
            //            this.timer1.Interval = 1;
            //            this.Opacity += 0.1;
            //            if (this.x < this.Location.X)
            //            {
            //                this.Left--;
            //            }
            //            else
            //            {
            //                if (this.Opacity == 1.0)
            //                {
            //                    action = frmAlert.enmAction.wait;
            //                }
            //            }
            //            break;
            //        case enmAction.close:
            //            timer1.Interval = 1;
            //            this.Opacity -= 0.1;

            //            this.Left -= 3;
            //            if (base.Opacity == 0.0)
            //            {
            //                base.Close();
            //            }
            //            break;
            //    }
            //}

            //private void button1_Click(object sender, EventArgs e)
            //{
            //    timer1.Interval = 1;
            //    action = enmAction.close;
            //}
        }
    }
}