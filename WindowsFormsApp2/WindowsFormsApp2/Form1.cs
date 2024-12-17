using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {

        // конструктор главной формы
        public FormMain()
        {
            InitializeComponent();
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = this.fetchRandomColor();
            }
        }

        /// <summary>
        /// Функция получения случайного цвета
        /// </summary>
        private Color fetchRandomColor()
        {
            Random r = new Random(); // создание объекта Random
            Color color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)); // получение случайного цвета по случайным значениям RGB
            return color; // вернули Color
        }

        /// <summary>
        /// Нажание на "Выход"
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Нажание вкладку объекта TabControl
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                tabControl1.SelectedTab.BackColor = this.fetchRandomColor();
            }
        }

        /// <summary>
        /// Нажание "Создать" в форме
        /// </summary>
        /// <param name="sender">объект, вызвавший событие</param>
        /// <param name="e">служебный объект, содержащий информацию о событии</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // добавление вкладки
            TabPage newTabPage = new TabPage(); // создание объекта-вкладки
            newTabPage.Text = "Новая вкладка";   // Заголовок вкладки
            newTabPage.BackColor = this.fetchRandomColor();
            tabControl1.TabPages.Add(newTabPage); // добавление вкладки в коллекцию
        }
    }
}