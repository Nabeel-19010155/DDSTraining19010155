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
    /// Interaction logic for RepCallNumWindow.xaml
    /// </summary>
    public partial class RepCallNumWindow : Window
    {
        ReplaceBooksClass rbc = new ReplaceBooksClass();

        public RepCallNumWindow()
        {
            InitializeComponent();

            rbc.GenerateCallNumbers();
            DisplayCallNumbers();
            rbc.SortGeneratedCallNums();
            

            radOne.IsChecked = false;
            radTwo.IsChecked = false;
            radThree.IsChecked = false;
            radFour.IsChecked = false;
            radFive.IsChecked = false;
            radSix.IsChecked = false;
            radSeven.IsChecked = false;
            radEight.IsChecked = false;
            radNine.IsChecked = false;
            radTen.IsChecked = false;

        }

        private void DisplayCallNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                lstDisplay.Items.Add(ReplaceBooksClass.callNums[i]);
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            ReplaceBooksClass.enteredCallNums.Add(txt1.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt2.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt3.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt4.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt5.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt6.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt7.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt8.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt9.Text);
            ReplaceBooksClass.enteredCallNums.Add(txt10.Text);

            rbc.CompareCallNums();
            new ResultsWindow().Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string selectItem = lstDisplay.SelectedValue.ToString();
            int selectIndex = lstDisplay.SelectedIndex;

            if (radOne.IsChecked == true)
            {
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt1.Text = selectItem;
            } 
            //----------------------------------------------------------------------
            else if (radTwo.IsChecked == true)
            {
                radOne.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt2.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radThree.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt3.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radFour.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt4.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radFive.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt5.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radSix.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt6.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radSeven.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt7.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radEight.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt8.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radNine.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt9.Text = selectItem;
            }
            //----------------------------------------------------------------------
            else if (radTen.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;

                lstDisplay.Items.RemoveAt(selectIndex);
                txt10.Text = selectItem;
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            if (radOne.IsChecked == true)
            {
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;


                lstDisplay.Items.Add(txt1.Text);
                txt1.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radTwo.IsChecked == true)
            {
                radOne.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;


                lstDisplay.Items.Add(txt2.Text);
                txt2.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radThree.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt3.Text);
                txt3.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radFour.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt4.Text);
                txt4.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radFive.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt5.Text);
                txt5.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radSix.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt6.Text);
                txt6.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radSeven.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt7.Text);
                txt7.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radEight.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radNine.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt8.Text);
                txt8.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radNine.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radTen.IsChecked = false;

                lstDisplay.Items.Add(txt9.Text);
                txt9.Text = "";
            }
            //----------------------------------------------------------------------
            else if (radTen.IsChecked == true)
            {
                radOne.IsChecked = false;
                radTwo.IsChecked = false;
                radThree.IsChecked = false;
                radFour.IsChecked = false;
                radFive.IsChecked = false;
                radSix.IsChecked = false;
                radSeven.IsChecked = false;
                radEight.IsChecked = false;
                radNine.IsChecked = false;

                lstDisplay.Items.Add(txt10.Text);
                txt10.Text = "";
            }
        }

        
    }
}
