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
using System.Windows.Shapes;

namespace DDSTraining
{
    /// <summary>
    /// Interaction logic for ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        ReplaceBooksClass rbc = new ReplaceBooksClass();
        ResultsClass rc = new ResultsClass();
        RepCallNumWindow rcn = new RepCallNumWindow();

        public ResultsWindow()
        {
            InitializeComponent();

            rc.DetermineResult();
            DisplayPoints();

            if (ResultsClass.dispMedal != "noMedal")
            {
                DisplayMedal();
            }
            

        }


        private void DisplayMedal()
        {
            string medal = ResultsClass.dispMedal;

            //--------------------------------code attribution-----------------------------------
            //Author:   Mahesh Chand
            //Link:     https://www.c-sharpcorner.com/UploadFile/mahesh/using-xaml-image-in-wpf/

            imgMedal.Source = new BitmapImage(new Uri(medal, UriKind.Relative));

            //--------------------------------------end------------------------------------------
        }

        private void DisplayPoints()
        {
            int points = ResultsClass.dispPts;

            lblPoints.Content = points;

            lblMsgBlk.Content = ResultsClass.dispMsg;
            lblMsgWht.Content = ResultsClass.dispMsg;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            rbc.RBCReset();
            new MainWindow().Show();
            rcn.Close();
            Close();
        }
    }
}
