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
using System.Windows.Threading;

namespace CustomLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int globalX = 2;
        int globalY = 1;

        //CKTestClass myObj = new CKTestClass();
        //CKTestClass myObjTwo = new CKTestClass();

        //do one as lists and other as hardcoded array size 2
        List<CKTestClass> myList = new List<CKTestClass>();
        int val = 0;

        DispatcherTimer myTimerThread = new DispatcherTimer();
        int timerVal = 0;

        public MainWindow()
        {
            InitializeComponent();

            myList.Add(new CKTestClass());
            myList.Add(new CKTestClass());

            labelListInfo.Content = myList[0].Display() + "\n" + myList[1].Display();


            myTimerThread.Tick += new EventHandler(myTimerThread_Tick);
            myTimerThread.Interval = new TimeSpan(0, 0, 1);
            myTimerThread.Start();

            /*
            new Thread(() =>
            {
                while(true)
                {
                    //secondsPassed = System.ctim
                }
            }).Start();
            */
        }

        public void myTimerThread_Tick(object sender, EventArgs e)
        {
            if (myList.Count == 2)
            {
                timerVal = timerVal + 1;
            }

            labelMiscInfo.Content = timerVal;
        }

        private string DisplayListValues()
        {
            string ret = "";
            foreach (CKTestClass item in myList)
            {
                ret += item.Display() + "\n";
            }
            return ret;
        }

        /**
         * List Functions
         ***/

        private void buttonListAddNewListItem_Click(object sender, RoutedEventArgs e)
        {
            myList.Add(new CKTestClass());
            labelListInfo.Content = DisplayListValues();
        }

        private void buttonListAddX_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(textInputListEntry.Text, out val))
            {
                myList[val].innerAddX();
                labelListInfo.Content = DisplayListValues();
            }

            //myTimerThread.
        }

        private void buttonListAddY_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textInputListEntry.Text, out val))
            {
                myList[val].innerAddY();
                labelListInfo.Content = DisplayListValues();
            }
        }

        private void buttonListAddAge_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textInputListEntry.Text, out val))
            {
                myList[val].IncreaseAge();
                labelListInfo.Content = DisplayListValues();
            }
        }

        private void buttonListChangeName_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textInputListEntry.Text, out val))
            {
                myList[val].SetFirstName(textInputName.Text);
                labelListInfo.Content = DisplayListValues();
            }
        }
    }

}
