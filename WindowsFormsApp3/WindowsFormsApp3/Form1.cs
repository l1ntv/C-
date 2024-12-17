using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        private FormModal formModal; // объект модальной формы
        public FormMain() // конструктор основной формы
        {
            formModal = new FormModal();
            InitializeComponent();
            comboBoxNutrionNature.SelectedIndex = 0;
        }

        /// <summary>
        /// Нажатие на "Добавить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonRecordAdder_Click(object sender, EventArgs e)
        {
            // Проверка, что поля текст-боксов не пустые
            if (textBoxAnimalName.Text.Length != 0  && textBoxLivingEnvironment.Text.Length != 0 && comboBoxNutrionNature.Text.Length != 0)
            {
                // Процесс добавления новой строки в таблицу
                int newRowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[newRowIndex].HeaderCell.Value = newRowIndex + 1;
                dataGridView.Rows[newRowIndex].Cells["ColumnAnimalName"].Value = textBoxAnimalName.Text;
                dataGridView.Rows[newRowIndex].Cells["ColumnIsInRussia"].Value = checkBoxIsInRussia.Checked;
                dataGridView.Rows[newRowIndex].Cells["ColumnLivingEnvironment"].Value = textBoxLivingEnvironment.Text;
                dataGridView.Rows[newRowIndex].Cells["ColumnNutrionNature"].Value = comboBoxNutrionNature.SelectedItem;
                dataGridView.Rows[newRowIndex].Cells["ColumnRedBook"].Value = checkBoxIsRedBook.Checked;
            }
            else
            {
                // Вывод сообщения об соответствующей ошибке
                MessageBox.Show("Недостаточно данных для записи", "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Нажатие на кнопку "Изменить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonRecordEditor_Click(object sender, EventArgs e)
        {
            // проверяем, выделены ли какие-то строки для изменений
            if (dataGridView.SelectedRows.Count < 1)
            {
                // выводим сообщение о соответствующей ошибке
                MessageBox.Show("Пожалуйста, выберите строку для изменения", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // начинаем собирать данные из текстбоксов, проверяя их на пустоту
                string columnAnimalName = textBoxAnimalName.Text;
                if (columnAnimalName.Length != 0)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        row.Cells["ColumnAnimalName"].Value = columnAnimalName;
                    }
                }

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    row.Cells["ColumnIsInRussia"].Value = checkBoxIsInRussia.Checked;
                }

                string livingEnvironment = textBoxLivingEnvironment.Text;
                if (livingEnvironment.Length != 0)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        row.Cells["ColumnLivingEnvironment"].Value = livingEnvironment;
                    }
                }
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    row.Cells["ColumnNutrionNature"].Value = comboBoxNutrionNature.SelectedItem;
                }
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    row.Cells["ColumnRedBook"].Value = checkBoxIsRedBook.Checked;
                }
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Удалить"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonRecordDeleter_Click(object sender, EventArgs e)
        {
            try
            {
                // проверяем, выделена ли какая-то строка
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // проходимся по всем выделенным строкам и удаляем их
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        dataGridView.Rows.Remove(row);
                    }
                    textBoxAnimalName.Text = dataGridView.SelectedRows[0].Cells["ColumnAnimalName"].Value.ToString();
                    checkBoxIsInRussia.Checked = (bool) dataGridView.SelectedRows[0].Cells["ColumnIsInRussia"].Value;
                    textBoxLivingEnvironment.Text = dataGridView.SelectedRows[0].Cells["ColumnLivingEnvironment"].Value.ToString();
                    comboBoxNutrionNature.SelectedItem = dataGridView.SelectedRows[0].Cells["ColumnNutrionNature"].Value;
                    checkBoxIsRedBook.Checked = (bool) dataGridView.SelectedRows[0].Cells["ColumnRedBook"].Value;

                }
                else
                {
                    // вывыд сообщения о соответствующей ошибке
                    MessageBox.Show("Пожалуйста, выберите строку для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {}

        }

        /// <summary>
        /// Нажатие на кнопку "Очистить таблицу"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonTableCleaner_Click(object sender, EventArgs e)
        {
            try
            {
                // очищаем таблицу
                dataGridView.Rows.Clear();

                textBoxAnimalName.Text = "";
                checkBoxIsInRussia.Checked = false;
                textBoxLivingEnvironment.Text = "";
                comboBoxNutrionNature.SelectedItem = 0;
                checkBoxIsRedBook.Checked = false;

            }
            catch (Exception ex)
            {
                // вывыд сообщения о соответствующей ошибке
                MessageBox.Show("Произошла очистки таблицы. Повторите попытку", "Ошибка очистки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Сохранить как XML файл"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonXmlSaver_Click(object sender, EventArgs e)
        {
            try
            {
                // создаем таблицу, в которую записываем данные из нашей таблицы
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Animal";

                // Добавляем столбцы с именами из DataGridView
                dt.Columns.Add("AnimalName");
                dt.Columns.Add("IsInRussia");
                dt.Columns.Add("LivingEnvironment");
                dt.Columns.Add("NutrionNature");
                dt.Columns.Add("RedBook");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dataGridView.Rows)
                {
                    if (r.Cells["ColumnAnimalName"].Value != null) // Проверка на null
                    {
                        DataRow row = ds.Tables["Animal"].NewRow();
                        // Используем правильные имена столбцов из DataGridView
                        row["AnimalName"] = r.Cells["ColumnAnimalName"].Value?.ToString();
                        row["IsInRussia"] = r.Cells["ColumnIsInRussia"].Value?.ToString();
                        row["LivingEnvironment"] = r.Cells["ColumnLivingEnvironment"].Value?.ToString();
                        row["NutrionNature"] = r.Cells["ColumnNutrionNature"].Value?.ToString();
                        row["RedBook"] = r.Cells["ColumnRedBook"].Value?.ToString();
                        ds.Tables["Animal"].Rows.Add(row);
                    }
                }
                // сохраняем dataSet в .xml файл
                ds.WriteXml("D:\\data.xml");
                // выводим сообщение об успешном сохранении .xml файла
                MessageBox.Show("Таблица была успешно сохранена в XML-файл", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                {
                    // вывыд сообщения о соответствующей ошибке (если поймали исключение)
                    MessageBox.Show($"Невозможно сохранить XML-файл: {ex.Message}", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Загрузить XML"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonXmlLoader_Click(object sender, EventArgs e)
        {
            // проверяем что таблица пустая перед загрузкой .xml файла
            if (dataGridView.Rows.Count > 1)
            {
                MessageBox.Show("Таблица непуста. Очистите строки таблицы", "Ошибка");
            }
            else
            {
                // проверяем существование data.xml файла
                if (File.Exists("D:\\data.xml"))
                {
                    // создаем dataSet, записываем в него информацию из data.xml
                    DataSet ds = new DataSet();
                    ds.ReadXml("D:\\data.xml");

                    // проходимся по строкам из dataSet и записываем их в нашу таблицу
                    if (ds.Tables.Contains("Animal"))
                    {
                        foreach (DataRow r in ds.Tables["Animal"].Rows)
                        {
                            int n = dataGridView.Rows.Add();
                            dataGridView.Rows[n].Cells["ColumnAnimalName"].Value = r["AnimalName"]?.ToString();
                            dataGridView.Rows[n].Cells["ColumnIsInRussia"].Value = Convert.ToBoolean(r["IsInRussia"]);
                            dataGridView.Rows[n].Cells["ColumnLivingEnvironment"].Value = r["LivingEnvironment"]?.ToString();
                            dataGridView.Rows[n].Cells["ColumnNutrionNature"].Value = r["NutrionNature"]?.ToString();
                            dataGridView.Rows[n].Cells["ColumnRedBook"].Value = Convert.ToBoolean(r["RedBook"]);
                        }
                    }
                }
                else
                {
                    // вывод сообщения о соответствующей ошибке
                    MessageBox.Show("Файл XML не может быть загружен. Проверьте наличие файла", "Ошибка");
                }
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Поиск"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonFromSearcher_Click(object sender, EventArgs e)
        {
                DataTable resultsTable = new DataTable();

                // Копируем структуры столбцов из dataGridView
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    // Убедимся, что тип данных не пустой
                    if (column.ValueType != null)
                    {
                        resultsTable.Columns.Add(column.Name, column.ValueType);
                    }
                    else
                    {
                        // Если тип данных не задан, используем string в качестве типа по умолчанию
                        resultsTable.Columns.Add(column.Name, typeof(string));
                    }
                }

            // Приводим к нижнему регистру для нечувствительного поиска
            bool isInRussia = checkBoxSearchInRussia.Checked;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Проверяем, не является ли строка новой или пустой
                    if (row.IsNewRow) continue;

                // Получаем значение из нужного столбца
                bool cellValue = (bool) row.Cells["ColumnRedBook"].Value;

                    // Сравниваем значения
                    if (cellValue != null && cellValue.Equals(isInRussia))
                    {
                        DataRow newRow = resultsTable.NewRow();
                        foreach (DataColumn column in resultsTable.Columns)
                        {
                            newRow[column.ColumnName] = row.Cells[column.ColumnName].Value;
                        }
                        resultsTable.Rows.Add(newRow);
                    }
                }

                // Проверим, найдем ли мы записи
                if (resultsTable.Rows.Count == 0)
                {
                    // вывод сообщения о соответствующей ошибке
                    MessageBox.Show("Записи не найдены", "Результаты поиска");
                    return;
                }

                // загружаем результат в таблицу модальной формы
                formModal.LoadResults(resultsTable);
                if (formModal.ShowDialog() == DialogResult.OK)
                {
                    formModal.Close();
                }
        }

        /// <summary>
        /// Нажатие на строку в таблице
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Проверка на null и безопасное приведение к строке
                textBoxAnimalName.Text = selectedRow.Cells["ColumnAnimalName"].Value?.ToString() ?? "";
                textBoxLivingEnvironment.Text = selectedRow.Cells["ColumnLivingEnvironment"].Value?.ToString() ?? "";

                // Безопасное приведение к bool
                if (selectedRow.Cells["ColumnIsInRussia"].Value != null)
                {
                    checkBoxIsInRussia.Checked = Convert.ToBoolean(selectedRow.Cells["ColumnIsInRussia"].Value);
                }
                else
                {
                    checkBoxIsInRussia.Checked = false;
                }

                // Безопасное приведение к bool
                if (selectedRow.Cells["ColumnRedBook"].Value != null)
                {
                    checkBoxIsRedBook.Checked = Convert.ToBoolean(selectedRow.Cells["ColumnRedBook"].Value);
                }
                else
                {
                    checkBoxIsRedBook.Checked = false;
                }
                // Безопасный выбор элемента в ComboBox
                string nutrionValue = selectedRow.Cells["ColumnNutrionNature"].Value?.ToString();
                if (nutrionValue != null)
                {
                    int index = comboBoxNutrionNature.FindStringExact(nutrionValue);
                    if (index != -1)
                    {
                        comboBoxNutrionNature.SelectedIndex = index;
                    }
                    else
                    {
                        comboBoxNutrionNature.SelectedIndex = -1;
                    }
                }
                else
                {
                    comboBoxNutrionNature.SelectedIndex = -1;
                }


            }
            else
            {
                // Очистка полей, если ничего не выбрано
                textBoxAnimalName.Text = "";
                checkBoxIsInRussia.Checked = false;
                textBoxLivingEnvironment.Text = "";
                comboBoxNutrionNature.SelectedIndex = 0;
            }
        }
    }
}