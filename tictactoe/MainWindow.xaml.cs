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
        private string[] setornot = new string[9];

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        public void StartGame()
        {
            this.xoro = "X";
            this.Title = xoro + "'s turn";
            ClearBoard();
        }

        public void FinishGame()
        {
            this.Title = "Game over!";
            MessageBox.Show("Game Over!");
        }

        public void ClearBoard()
        {
            lblSqrAA.Content = null; lblSqrAB.Content = null; lblSqrAC.Content = null;
            lblSqrBA.Content = null; lblSqrBB.Content = null; lblSqrBC.Content = null;
            lblSqrCA.Content = null; lblSqrCB.Content = null; lblSqrCC.Content = null;
            for (int c = 0; c < setornot.Length; c++) { setornot[c] = ""; }
        }

        public void xo(Label sqr, int square)
        {
            if (setornot[square] != "") { return; }
            setornot[square] = xoro;

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

            CheckGameState();
        }

        public void CheckGameState()
        {
            int count = 0;
            foreach (string c in setornot)
            {
                if (c != "") { count++; }
            }
            if (count == 9) { FinishGame(); }
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

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

    }
}
