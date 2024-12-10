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
using TriangleApp;

namespace pr6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            double sideA = double.Parse(tb1.Text);
            double sideB = double.Parse(tb2.Text);
            double sideC = double.Parse(tb3.Text);
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            // Вычисление периметра и результат
            double perimeter = triangle.GetPerimeter();
            tbResult.Text = perimeter.ToString();
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            double sideA = double.Parse(tb1.Text);
            double sideB = double.Parse(tb2.Text);
            double sideC = double.Parse(tb3.Text);

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Увеличение треугольника в 2 раза
            triangle.SetParams(2);

            // Обновление
            tb1.Text = triangle.SideA.ToString();
            tb2.Text = triangle.SideB.ToString();
            tb3.Text = triangle.SideC.ToString();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 5;
            string task = "Использовать класс Triangle (треугольник) с полями-сторонами. Разработать \r\nоперацию для определения возможности существование треугольника с заданными \r\nсторонами true/false. Разработать операции для увеличения/уменьшения сторон на \r\n1. ";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }

        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btproverka_click(object sender, RoutedEventArgs e)
        {
            double sideA = double.Parse(tb1.Text);
            double sideB = double.Parse(tb2.Text);
            double sideC = double.Parse(tb3.Text);

            // Проверка условий существования треугольника
            if (sideA >= 0 && sideB >= 0 && sideC >= 0 &&
                sideA + sideB > sideC &&
                sideA + sideC > sideB &&
                sideB + sideC > sideA)
            {
                MessageBox.Show("Такой треугольник может существовать");
            }
            else
            {
                MessageBox.Show("Такой треугольник не существует");
            }
        }

        private void btmen_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(tb1.Text, out double sideA) &&
                double.TryParse(tb2.Text, out double sideB) &&
                double.TryParse(tb3.Text, out double sideC))
            {
                sideA = Math.Max(0, sideA - 1); // Уменьшение, но не меньше 0
                sideB = Math.Max(0, sideB - 1);
                sideC = Math.Max(0, sideC - 1);

                tb1.Text = sideA.ToString();
                tb2.Text = sideB.ToString();
                tb3.Text = sideC.ToString();
            }
        }

        private void btbig_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(tb1.Text, out double sideA) &&
                double.TryParse(tb2.Text, out double sideB) &&
                double.TryParse(tb3.Text, out double sideC))
            {
                sideA += 1;
                sideB += 1;
                sideC += 1;

                tb1.Text = sideA.ToString();
                tb2.Text = sideB.ToString();
                tb3.Text = sideC.ToString();
            }
        }
    }
}
  //unouo