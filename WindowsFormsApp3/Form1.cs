using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Створюємо MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Файл -> Вихід
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Файл");
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Вихід", null, (s, e) => Application.Exit());
            fileMenu.DropDownItems.Add(exitItem);

            // Налаштування -> відкриває SettingsForm модально
            ToolStripMenuItem settingsMenu = new ToolStripMenuItem("Налаштування");
            settingsMenu.Click += (s, e) => new SettingsForm().ShowDialog();

            // Довідка -> відкриває InfoForm немодально
            ToolStripMenuItem infoMenu = new ToolStripMenuItem("Довідка");
            infoMenu.Click += (s, e) => new InfoForm().Show();

            // Додаємо меню у MenuStrip
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(settingsMenu);
            menuStrip.Items.Add(infoMenu);

            // Встановлюємо головне меню
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
