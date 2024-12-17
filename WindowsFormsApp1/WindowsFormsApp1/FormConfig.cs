using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormConfig : Form
    {

        /// <summary>
        /// Функция геттер для свойства .Cursor CheckBox
        /// </summary>
        public Cursor CursorParameter
        {
            get { return (Cursor) cursorComboBox.SelectedItem; }
        }

        /// <summary>
        /// Функция геттер для свойства .CheckState CheckBox
        /// </summary>
        public CheckState CheckState
        {
            get
            {
                if (radioButtonIndeterminate.Checked) return CheckState.Indeterminate;
                if (radioButtonChecked.Checked) return CheckState.Checked;
                return CheckState.Unchecked;
            }   
        }

        /// <summary>
        /// Функция геттер для свойства .FlatStyle CheckBox
        /// </summary>
        public FlatStyle FlatStyle
        {
            get
            {
                if (radioButtonStandart.Checked) return FlatStyle.Standard;
                if (radioButtonSystem.Checked) return FlatStyle.System;
                if (radioButtonFlat.Checked) return FlatStyle.Flat;
                return FlatStyle.Popup;
            }
        }

        /// <summary>
        /// Функция геттер для свойства .Enabled CheckBox
        /// </summary>
        public bool Enabled
        {
            get
            {
                if (radioButtonTrue.Checked) return true;
                return false;
            }
        }

        // конструктор модальной формы
        public FormConfig()
        {
            InitializeComponent();
            InitializeCursorComboBox();
        }

        /// <summary>
        /// Функция для заполнения ComboBox значениями для Cursor
        /// </summary>
        private void InitializeCursorComboBox()
        {
            List<Cursor> cursorList = new List<Cursor>(); // Создали лист
            var cursorProperties = typeof(Cursors).GetProperties(BindingFlags.Static | BindingFlags.Public); // получили все значения

            foreach (var property in cursorProperties) // записываем значения в наш лист
            {
                if (property.PropertyType == typeof(Cursor))
                {
                    cursorList.Add((Cursor)property.GetValue(null));
                }
            }

            cursorComboBox.DisplayMember = "FriendlyName";
            cursorComboBox.ValueMember = "Name";
            cursorComboBox.DataSource = cursorList;

            if (cursorComboBox.Items.Count > 0) // установили изначальное значение Cursor
            {
                Cursor selectedCursor = (Cursor)cursorComboBox.SelectedItem;
                this.Cursor = selectedCursor;
            }
        }

    }
}