using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private FormConfig formConfig; // объект модальной формы
        public FormMain() // конструктор главной формы
        {
            formConfig = new FormConfig();
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Настроить" в главной формеs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeCheckBox_Click(object sender, MouseEventArgs e)
        {
            formConfig.ShowDialog();
            if (formConfig.DialogResult == DialogResult.OK) // если нажата кнопка "ОК" на модальной форме
            {
                this.myCheckBox.Cursor = formConfig.CursorParameter; // изменяем параметр Cursor у CheckBox на выбранный выриант в модальной
                this.myCheckBox.CheckState = formConfig.CheckState; // изменяем параметр CheckState у CheckBox согласно выбранному значению в модальной
                this.myCheckBox.FlatStyle = formConfig.FlatStyle; // изменяем параметр FlatStyle у CheckBox согласно выбранному значению в модальной
                this.myCheckBox.Enabled = formConfig.Enabled; // изменяем параметр Enabled у CheckBox согласно выбранному значению в модальной
            }
        }
    }
}