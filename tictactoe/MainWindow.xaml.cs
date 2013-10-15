using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string xoro = "X";
        private int square = 0;
        private bool[] setornot = new bool[9];

        public MainWindow()
        {
            InitializeComponent();
            this.Title = xoro + "'s turn";
        }

        public void xo(Label sqr, int square)
        {
            if (setornot[square] == true) { return; }
            setornot[square] = true;

            if (xoro == "X")
            {
                sqr.Content = new tictactoe.Xes();
                xoro = "O";
            }
            else
            {
                sqr.Content = new tictactoe.Oes();
                xoro = "X";
            }

            this.Title = xoro + "'s turn";
        }
        private void lblSqrAA_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 0);
        }

        private void lblSqrAB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 1);
        }

        private void lblSqrAC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 2);
        }

        private void lblSqrBA_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 3);
        }

        private void lblSqrBB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 4);
        }

        private void lblSqrBC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 5);
        }

        private void lblSqrCA_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 6);
        }

        private void lblSqrCB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 7);
        }

        private void lblSqrCC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            xo((Label)sender, 8);
        }


    }
}
