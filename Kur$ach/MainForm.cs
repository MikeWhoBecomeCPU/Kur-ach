using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kur_ach
{
    public partial class MainForm : Form
    {
        private ProductItem selectedItem;
        private Image tempSelectedImage = null;
        private string tempName = null;
        private User currentUser;
        private List<User> usersList = new List<User>();
        private Dictionary<string, string> workerTasks = new Dictionary<string, string>();
        private List<Product> savedProducts = new List<Product>();

        public MainForm(User user)
        {
            InitializeComponent();

            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;

            this.FormClosed += Form1_FormClosed;
            changeSavebtn.Click += ChangeSavebtn_Click;
            currentUser = user;
            btnOpenAddWorkerForm.Click += btnOpenAddWorkerForm_Click;

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);

            DataStorage.LoadProducts();
            savedProducts = DataStorage.Products;
            DataStorage.LoadUsers();
            usersList = DataStorage.Users;
            workerTasks = DataStorage.LoadTasks();

            // відобразити всі товари
            foreach (var product in savedProducts)
            {
                ProductItem item = new ProductItem();
                item.Setup(product);

                item.OnDeleteRequested = (pi) =>
                {
                    flowLayoutPanel1.Controls.Remove(pi);
                    savedProducts.Remove(pi.CurrentProduct);
                    DataStorage.SaveProducts(savedProducts);
                };

                flowLayoutPanel1.Controls.Add(item);
            }

            // якщо адмін — показати працівників
            if (currentUser.IsAdmin)
            {
                foreach (var usr in usersList.Where(u => !u.IsAdmin))
                {
                    AddWorkerToPanel(usr);
                }
            }

            if (currentUser.IsAdmin)
            {
                ShowAdminPanel();
            }
            else
            {
                ShowWorkerTaskPanel();
            }
        }
        private void btnOpenAddWorkerForm_Click(object sender, EventArgs e)
        {
            using (AddWorkerForm form = new AddWorkerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string login = form.WorkerLogin;
                    string password = form.WorkerPassword;
                    if (usersList.Any(u => u.Login == login))
                    {
                        MessageBox.Show("Користувач з таким логіном вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    User newWorker = new User(login, password, false);
                    usersList.Add(newWorker);
                    DataStorage.Users = usersList;
                    AddWorkerToPanel(newWorker);
                    DataStorage.Users = usersList;
                    DataStorage.SaveUsers();
                    DataStorage.SaveTasks(workerTasks);
                }
            }
        }

        private void AddWorkerToPanel(User worker)
        {
            Panel workerPanel = new Panel
            {
                Width = 260,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label loginLabel = new Label
            {
                Text = $"Логін: {worker.Login}",
                Location = new Point(5, 5),
                AutoSize = true
            };

            Button deleteButton = new Button
            {
                Text = "❌",
                ForeColor = Color.Red,
                Location = new Point(230, 5),
                Size = new Size(30, 25),
                Tag = worker
            };
            deleteButton.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити працівника?", "Підтвердження", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    usersList.Remove(worker);
                    workerTasks.Remove(worker.Login);
                    workerFlowLayoutPanel.Controls.Remove(workerPanel);
                    DataStorage.Users = usersList;
                    DataStorage.SaveUsers();
                    DataStorage.SaveTasks(workerTasks);
                }
            };

            TextBox taskBox = new TextBox
            {
                Multiline = true,
                Size = new Size(250, 50),
                Location = new Point(5, 35),
                Text = workerTasks.ContainsKey(worker.Login) ? workerTasks[worker.Login] : ""
            };
            taskBox.TextChanged += (s, e) =>
            {
                workerTasks[worker.Login] = taskBox.Text;
            };

            workerPanel.Controls.Add(loginLabel);
            workerPanel.Controls.Add(deleteButton);
            workerPanel.Controls.Add(taskBox);

            workerFlowLayoutPanel.Controls.Add(workerPanel);
        }
        private void ShowAdminPanel()
        {
            // Показати панель для керування працівниками
            label5.Text = "Список працівників";

        }
        private void ShowWorkerTaskPanel()
        {
            // Ховаємо елементи, що призначені лише для адміністратора
            btnOpenAddWorkerForm.Visible = false;
            workerFlowLayoutPanel.Visible = false;

            label5.Text = "Ваше завдання";
            panel1.Controls.Clear();

            if (workerTasks.TryGetValue(currentUser.Login, out string task))
            {
                TextBox taskBox = new TextBox
                {
                    Multiline = true,
                    Text = task,
                    ReadOnly = true,
                    Width = panel1.Width - 20,
                    Height = 300,
                    Location = new Point(10, 30),
                    ScrollBars = ScrollBars.Vertical // ← додати цю строку
                };
                panel1.Controls.Add(taskBox);
            }
            else
            {
                Label noTask = new Label
                {
                    Text = "Завдання не призначене.",
                    AutoSize = true,
                    Location = new Point(10, 30)
                };
                panel1.Controls.Add(noTask);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string name = addForm.ProductName;
                string description = addForm.ProductDescription;
                string price = addForm.ProductPrice;
                string imageSrc = addForm.ProductImageSrc;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Назва не додана!");
                    return;
                }

                if (!decimal.TryParse(price, out decimal priceValue))
                {
                    MessageBox.Show("Ціна введена неправильно!");
                    return;
                }

                if (!int.TryParse(description, out int quantity))
                {
                    MessageBox.Show("Кількість введена неправильно!");
                    return;
                }

                Image productImage = null;
                if (!string.IsNullOrEmpty(imageSrc) && System.IO.File.Exists(imageSrc))
                {
                    productImage = Image.FromFile(imageSrc);
                }

                Product newProduct = new Product
                {
                    Name = name,
                    Quantity = quantity,
                    Price = priceValue,
                    Image = productImage,
                    Author = currentUser.Login,
                    DateAdded = DateTime.Now,
                    Note = ""
                };

                ProductItem item = new ProductItem();
                item.Setup(newProduct);

                item.OnDeleteRequested = (pi) =>
                {
                    flowLayoutPanel1.Controls.Remove(pi);
                    savedProducts.Remove(pi.CurrentProduct); // ВИДАЛЕННЯ З БАЗИ
                    DataStorage.SaveProducts(savedProducts); // ЗБЕРЕЖЕННЯ
                };

                flowLayoutPanel1.Controls.Add(item);
                savedProducts.Add(newProduct); // список товарів
                DataStorage.SaveProducts(savedProducts);
            }
        }

        public void DisplayProductDetails(ProductItem item)
        {
            if (item == null || item.CurrentProduct == null)
                return;

            selectedItem = item;

            // Зберігаємо тимчасові дані
            tempName = item.CurrentProduct.Name;
            tempSelectedImage = item.CurrentProduct.Image;

            NameTextbox.TextChanged -= NameTextbox_TextChanged;
            quanitityChange.TextChanged -= QuantityChange_TextChanged;

            NameTextbox.Text = tempName;
            pictureBox1.Image = tempSelectedImage;
            quanitityChange.Text = item.CurrentProduct.Quantity.ToString();
            PriceChange.Text = item.CurrentProduct.Price.ToString();
            richTextBox1.Text = item.CurrentProduct.Note;
            autorLabel.Text = "Автор: " + item.CurrentProduct.Author;
            dateLabel.Text = "Дата: " + item.CurrentProduct.DateAdded.ToShortDateString();

            NameTextbox.TextChanged += NameTextbox_TextChanged;
            quanitityChange.TextChanged += QuantityChange_TextChanged;

            changePic.Click -= ChangePic_Click;
            changePic.Click += ChangePic_Click;
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            tempName = NameTextbox.Text;
        }

        private void QuantityChange_TextChanged(object sender, EventArgs e)
        {
            // кількість змінюється лише при збереженні
        }

        private void ChangePic_Click(object sender, EventArgs e)
        {
            if (selectedItem?.CurrentProduct != null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Image newImage = Image.FromFile(ofd.FileName);
                        tempSelectedImage = newImage;
                        pictureBox1.Image = newImage;
                    }
                }
            }
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            string filter = Input.Text.Trim().ToLower(); // Отримуємо текст і знижуємо регістр

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ProductItem item && item.CurrentProduct != null)
                {
                    string productName = item.CurrentProduct.Name.ToLower();

                    // Перевіряємо: чи починається назва з введеного тексту
                    bool matches = productName.StartsWith(filter);

                    // Відображаємо або ховаємо елемент
                    item.Visible = matches || string.IsNullOrEmpty(filter);
                }
            }
        }

        private enum SortType
        {
            Name,
            Price,
            Quantity,
            DateAdded
        }

        private SortType currentSort = SortType.Name;
        private bool reverseSort = false;

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) currentSort = SortType.Name;
            else if (radioButton2.Checked) currentSort = SortType.Price;
            else if (radioButton3.Checked) currentSort = SortType.Quantity;
            else if (radioButton4.Checked) currentSort = SortType.DateAdded;

            ApplySortingAndFiltering();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            reverseSort = radioButton5.Checked;
            ApplySortingAndFiltering();
        }

        private void ApplySortingAndFiltering()
        {
            string filter = Input.Text.Trim().ToLower();

            IEnumerable<Product> filtered = savedProducts
                     .Where(p => p.Name.ToLower().Contains(filter));

            switch (currentSort)
            {
                case SortType.Name:
                    filtered = filtered.OrderBy(p => p.Name);
                    break;
                case SortType.Price:
                    filtered = filtered.OrderBy(p => p.Price);
                    break;
                case SortType.Quantity:
                    filtered = filtered.OrderBy(p => p.Quantity);
                    break;
                case SortType.DateAdded:
                    filtered = filtered.OrderBy(p => p.DateAdded);
                    break;
            }

            if (reverseSort)
                filtered = filtered.Reverse();

            // Очистити і показати картки
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in filtered)
            {
                ProductItem item = new ProductItem();
                item.Setup(product);
                flowLayoutPanel1.Controls.Add(item);
            }
        }


        private void ChangeSavebtn_Click(object sender, EventArgs e)
        {
            if (selectedItem?.CurrentProduct != null)
            {
                // Назва
                selectedItem.CurrentProduct.Name = tempName ?? NameTextbox.Text;

                // Ціна
                if (decimal.TryParse(PriceChange.Text, out decimal newPrice))
                {
                    selectedItem.CurrentProduct.Price = newPrice;
                }

                // Кількість
                if (int.TryParse(quanitityChange.Text, out int newQty))
                {
                    selectedItem.CurrentProduct.Quantity = newQty;
                }

                // Нотатка
                selectedItem.CurrentProduct.Note = richTextBox1.Text;

                // Зображення
                if (tempSelectedImage != null)
                {
                    selectedItem.CurrentProduct.Image = tempSelectedImage;
                    tempSelectedImage = null;
                }

                selectedItem.UpdateUI();
                DataStorage.SaveProducts(savedProducts);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStorage.SaveProducts(savedProducts);
            DataStorage.Users = usersList;
            DataStorage.SaveUsers();
            DataStorage.SaveTasks(workerTasks);
            Application.Exit();
        }

    }
}
