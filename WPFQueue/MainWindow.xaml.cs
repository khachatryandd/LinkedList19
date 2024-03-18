using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyQueue;

namespace WPFQueue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyQueue<int> queue = new MyQueue<int>();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(rnd.Next(1, 999));
            UpdateGrid();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (queue.Count > 0)
            {
                listBox.Items.Add(queue.Dequeue().ToString());
                UpdateGrid();
            }
        }
        public void UpdateGrid()
        {
            label1.Content = string.Empty;
            label2.Content = string.Empty;
            label3.Content = string.Empty;
            label4.Content = string.Empty;
            label5.Content = string.Empty;
            label6.Content = string.Empty;

            int index = 0;
            foreach (var item in queue)
            {
                switch (index)
                {
                    case 0:
                        label1.Content = item.ToString();
                        break;
                    case 1:
                        label2.Content = item.ToString();
                        break; 
                    case 2:
                        label3.Content = item.ToString();
                        break; 
                    case 3:
                        label4.Content = item.ToString();
                        break; 
                    case 4:
                        label5.Content = item.ToString();
                        break; 
                    case 5:
                        label6.Content = item.ToString();
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    break;
                }
            }
        }

      
    }
}