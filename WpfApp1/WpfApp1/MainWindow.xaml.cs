using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;

namespace WpfApp1
{
    [Serializable]
    public class Animal
    {
        [XmlElement("AnimalName")]
        public string AnimalName { get; set; }

        [XmlElement("IsInRussia")]
        public string IsInRussia { get; set; }

        [XmlElement("LivingEnvironment")]
        public string LivingEnvironment { get; set; }

        [XmlElement("NutritionNature")]
        public string NutritionNature { get; set; }

        [XmlElement("IsRedBook")]
        public string IsRedBook { get; set; }
    }

    [Serializable]
    [XmlRoot("Animal")]
    public class AnimalList
    {
        [XmlElement("Animal")]
        public ObservableCollection<Animal> Items { get; set; }
        public AnimalList()
        {
            Items = new ObservableCollection<Animal>();
        }
    }

    public partial class MainWindow : Window
    {

        public AnimalList animalList = new AnimalList();

        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.ItemsSource = this.animalList.Items;
        }

        /// <summary>
        /// Нажатие на кнопку "Загрузить XML"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void loadXMLButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var formatter = new XmlSerializer(typeof(AnimalList));

                using (var fs = new FileStream("D:\\data.xml", FileMode.OpenOrCreate))
                {
                    animalList = (AnimalList)formatter.Deserialize(fs);
                    dataGrid.ItemsSource = animalList.Items;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Сохранить как XML файл"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void saveXMLButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(AnimalList));
                FileStream fs = new FileStream("D:\\data.xml", FileMode.Create);
                formatter.Serialize(fs, this.animalList);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Очистить таблицу"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            this.animalList.Items.Clear();
            clearTextBoxes();
        }

        /// <summary>
        /// Нажатие на "Добавить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (animalNameTextBox.Text.Length != 0 && livingEnvironmentTextBox.Text.Length != 0 && nutritionNatureComboBox.Text.Length != 0)
            {
                Animal animal = new Animal();
                animal.AnimalName = animalNameTextBox.Text;

                // Используем свойство IsChecked и преобразуем в строку с обработкой null
                animal.IsInRussia = isInRussiaCheckBox.IsChecked?.ToString() ?? "false";
                animal.LivingEnvironment = livingEnvironmentTextBox.Text;
                animal.NutritionNature = nutritionNatureComboBox.Text;

                // Используем свойство IsChecked и преобразуем в строку с обработкой null
                animal.IsRedBook = isRedBookCheckBox.IsChecked?.ToString() ?? "false";

                this.animalList.Items.Add(animal);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку "Очистить таблицу"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void clearTextBoxes()
        {
            animalNameTextBox.Text = "";

            // Используем свойство IsChecked
            isInRussiaCheckBox.IsChecked = false;

            livingEnvironmentTextBox.Text = "";

            nutritionNatureComboBox.SelectedIndex = -1; // сбрасываем ComboBox

            // Используем свойство IsChecked
            isRedBookCheckBox.IsChecked = false;
        }

        /// <summary>
        /// Нажатие на кнопку "Изменить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("Ни одна запись не выделена", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                animalList.Items[i].AnimalName = animalNameTextBox.Text;
                animalList.Items[i].IsInRussia = isInRussiaCheckBox.IsChecked?.ToString() ?? "false";
                animalList.Items[i].LivingEnvironment = livingEnvironmentTextBox.Text;
                animalList.Items[i].NutritionNature = nutritionNatureComboBox.Text;
                animalList.Items[i].IsRedBook = isRedBookCheckBox.IsChecked?.ToString() ?? "false";
            dataGrid.Items.Refresh();

        }

        /// <summary>
        /// Нажатие на кнопку "Удалить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("Ни одна запись не выделена", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            animalList.Items.RemoveAt(i);
            dataGrid.SelectedIndex = -1;
            clearTextBoxes();
        }

        /// <summary>
        /// Выделение строки в таблице
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        private void dataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.SelectedIndex;
            if (i < 0)
            {
                return;
            }
            animalNameTextBox.Text = animalList.Items[i].AnimalName;
            isInRussiaCheckBox.IsChecked = Convert.ToBoolean(animalList.Items[i].IsInRussia);
            livingEnvironmentTextBox.Text = animalList.Items[i].LivingEnvironment;
            nutritionNatureComboBox.Text = animalList.Items[i].NutritionNature;
            isRedBookCheckBox.IsChecked = Convert.ToBoolean(animalList.Items[i].IsRedBook);
        }
    }
}