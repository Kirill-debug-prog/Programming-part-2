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
using EmployeeDLL;

namespace Lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee employee;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Full_name.Text) && !string.IsNullOrWhiteSpace(Job_title.Text) &&
                 !string.IsNullOrWhiteSpace(Education.Text) && !string.IsNullOrWhiteSpace(Year.Text) &&
                 !string.IsNullOrWhiteSpace(Experience.Text) && !string.IsNullOrWhiteSpace(Salary.Text))
            {
                try
                {
                    string name = Full_name.Text;
                    string position = Job_title.Text;
                    string education = Education.Text;
                    int hireYear = int.Parse(Year.Text);
                    int experience = int.Parse(Experience.Text);
                    int salary = int.Parse(Salary.Text);
                    bool knowForeinnLanguage = Language.IsChecked.Value;

                    employee = new Employee(name, position, education, hireYear,
                experience, salary, knowForeinnLanguage);

                    MessageBox.Show("Сотрудник успешно добавлен.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Пожалуйста заполнить все поля.");
            }
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            int newSalary = int.Parse(Increase_salary.Text) + int.Parse(Salary.Text);

            employee.IncreaseSalary(newSalary);

            MessageBox.Show($"Зарплата измениена {newSalary} ");
        }

        private void Transfer__Click(object sender, RoutedEventArgs e)
        {
            string newposition = Transfer.Text;

            employee.ChangePosition(newposition);

            MessageBox.Show($"Сотрудник перевеленн на другую должность '{newposition}'. ");
        }

        private void _Write_Click(object sender, RoutedEventArgs e)
        {
            double bonus = employee.GetBonus();

            MessageBox.Show($"Премия: {bonus}");
        }

        private void Fire_Click(object sender, RoutedEventArgs e)
        {
            employee.Fire();

            MessageBox.Show("Сотрудник уволен!!!");
        }

        private void Data_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(employee.GetImployeeData());
        }

        private void _Fule_name_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(employee.GetFull_Name());
        }

        private void ValidateInput(string inputText)
        {
            try
            {
                int inputValue = Convert.ToInt32(inputText);
                if (inputValue <= 0)
                {
                    throw new Exception("Число должно быть больше 0");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите коректное число");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateInput(Year.Text);
        }

        private void Experience_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateInput(Experience.Text);
        }

        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateInput(Salary.Text);
        }

        private void Increase_salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateInput(Increase_salary.Text);
        }
    }
}
