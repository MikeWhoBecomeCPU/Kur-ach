using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kur_ach
{
    public partial class AddWorkerForm : Form
    {
        public string WorkerLogin { get; private set; }
        public string WorkerPassword { get; private set; }

        public AddWorkerForm()
        {
            InitializeComponent();

            // Задаємо розмір явно
            this.Size = new Size(200, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Прив'язка обробників
            btnAddWorker.Click += BtnAddWorker_Click;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        private void BtnAddWorker_Click(object sender, EventArgs e)
        {
            string login = txtWorkerLogin.Text.Trim();
            string password = txtWorkerPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, введіть логін і пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (login == "admin")
            {
                MessageBox.Show("Ви не можете створити другого адміна", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WorkerLogin = login;
            WorkerPassword = password;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
