using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kur_ach
{
    public partial class ProductItem : UserControl
    {
        public Product CurrentProduct { get; private set; }
        public Action<ProductItem> OnDeleteRequested;

        public ProductItem()
        {
            InitializeComponent();

            // Створюємо кнопку "X" (видалення)
            Button buttonDelete = new Button
            {
                Text = "X",
                Size = new Size(24, 24),
                Location = new Point(this.Width - 30, 5),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            buttonDelete.FlatAppearance.BorderSize = 0;

            buttonDelete.Click += (s, e) =>
            {
                var confirm = MessageBox.Show("Видалити товар?", "Підтвердження", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    OnDeleteRequested?.Invoke(this); // Передаємо сигнал на видалення
                }
            };


            this.Controls.Add(buttonDelete);
            buttonDelete.BringToFront();

            this.BackColor = Color.LightGray;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new Size(200, 200);
        }

        // Подія (не обов’язкова, але може знадобитися)


        // Метод прив’язки товару
        public void Setup(Product product)
        {
            CurrentProduct = product;

            label1.Text = product.Name;
            label2.Text = $"{product.Quantity} шт.";
            label3.Text = $"{product.Price} грн";

            if (product.Image != null)
            {
                pictureBox1.Image = product.Image;
            }

            AttachClickHandlers(this);
            foreach (Control ctrl in this.Controls) 
            {
                ctrl.Click += ProductItem_Click;
            }
        }
        private void AttachClickHandlers(Control parent)
        {
            parent.Click += ProductItem_Click;

            foreach (Control ctrl in parent.Controls)
            {
                AttachClickHandlers(ctrl); // рекурсія
            }
        }

        // Оновлення вмісту елементів керування
        public void UpdateUI()
        {
            if (CurrentProduct == null) return;

            label1.Text = CurrentProduct.Name;
            label2.Text = $"{CurrentProduct.Quantity} шт.";
            label3.Text = $"{CurrentProduct.Price} грн";

            if (CurrentProduct.Image != null)
            {
                pictureBox1.Image = CurrentProduct.Image;
            }
        }

        private void ProductItem_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                mainForm.DisplayProductDetails(this);
            }
        }

    }
}
