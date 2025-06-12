using System.Drawing;
using System.Windows.Forms;

namespace Kur_ach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.changeSavebtn = new System.Windows.Forms.Button();
            this.changePic = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.autorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceChange = new System.Windows.Forms.TextBox();
            this.quanitityChange = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoragePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Input = new System.Windows.Forms.TextBox();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.AddLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.Shitlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenAddWorkerForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StoragePanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LeftPanel.Controls.Add(this.changeSavebtn);
            this.LeftPanel.Controls.Add(this.changePic);
            this.LeftPanel.Controls.Add(this.dateLabel);
            this.LeftPanel.Controls.Add(this.autorLabel);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.PriceChange);
            this.LeftPanel.Controls.Add(this.quanitityChange);
            this.LeftPanel.Controls.Add(this.NameTextbox);
            this.LeftPanel.Controls.Add(this.richTextBox1);
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Location = new System.Drawing.Point(34, 112);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(619, 738);
            this.LeftPanel.TabIndex = 2;
            // 
            // changeSavebtn
            // 
            this.changeSavebtn.Location = new System.Drawing.Point(192, 701);
            this.changeSavebtn.Name = "changeSavebtn";
            this.changeSavebtn.Size = new System.Drawing.Size(245, 34);
            this.changeSavebtn.TabIndex = 13;
            this.changeSavebtn.Text = "Зберегти зміни";
            this.changeSavebtn.UseVisualStyleBackColor = true;
            // 
            // changePic
            // 
            this.changePic.Location = new System.Drawing.Point(437, 448);
            this.changePic.Name = "changePic";
            this.changePic.Size = new System.Drawing.Size(152, 23);
            this.changePic.TabIndex = 12;
            this.changePic.Text = "Змінити картинку";
            this.changePic.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(426, 491);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Дата";
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(546, 491);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(43, 13);
            this.autorLabel.TabIndex = 10;
            this.autorLabel.Text = "Автор: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ціна грн";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість шт.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(277, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Назва";
            // 
            // PriceChange
            // 
            this.PriceChange.Location = new System.Drawing.Point(235, 450);
            this.PriceChange.Name = "PriceChange";
            this.PriceChange.Size = new System.Drawing.Size(152, 20);
            this.PriceChange.TabIndex = 5;
            // 
            // quanitityChange
            // 
            this.quanitityChange.Location = new System.Drawing.Point(30, 450);
            this.quanitityChange.Name = "quanitityChange";
            this.quanitityChange.Size = new System.Drawing.Size(152, 20);
            this.quanitityChange.TabIndex = 4;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameTextbox.Location = new System.Drawing.Point(182, 34);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(255, 30);
            this.NameTextbox.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 518);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 166);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StoragePanel
            // 
            this.StoragePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StoragePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StoragePanel.Controls.Add(this.flowLayoutPanel1);
            this.StoragePanel.Location = new System.Drawing.Point(682, 112);
            this.StoragePanel.Name = "StoragePanel";
            this.StoragePanel.Size = new System.Drawing.Size(852, 814);
            this.StoragePanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 785);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Berlin Sans FB", 17F);
            this.Input.Location = new System.Drawing.Point(14, 56);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(194, 32);
            this.Input.TabIndex = 8;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.label1);
            this.UpperPanel.Controls.Add(this.radioButton5);
            this.UpperPanel.Controls.Add(this.radioButton4);
            this.UpperPanel.Controls.Add(this.radioButton3);
            this.UpperPanel.Controls.Add(this.radioButton2);
            this.UpperPanel.Controls.Add(this.radioButton1);
            this.UpperPanel.Controls.Add(this.AddLabel);
            this.UpperPanel.Controls.Add(this.InputLabel);
            this.UpperPanel.Controls.Add(this.buttonAddProduct);
            this.UpperPanel.Controls.Add(this.Input);
            this.UpperPanel.Location = new System.Drawing.Point(682, 12);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(854, 94);
            this.UpperPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(435, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Сортувати за ";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(733, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(119, 30);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Встановити \nзворотній порядок";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(629, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 17);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Датою додавання";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(629, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Кількістю";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(557, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ціною";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(557, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Назвою";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.AddLabel.Location = new System.Drawing.Point(251, 24);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(153, 20);
            this.AddLabel.TabIndex = 12;
            this.AddLabel.Text = "Додати предмет";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.InputLabel.Location = new System.Drawing.Point(14, 24);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(102, 20);
            this.InputLabel.TabIndex = 12;
            this.InputLabel.Text = "Пошуковик";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAddProduct.Location = new System.Drawing.Point(234, 54);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(184, 34);
            this.buttonAddProduct.TabIndex = 12;
            this.buttonAddProduct.Text = "➕";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Shitlabel
            // 
            this.Shitlabel.AutoSize = true;
            this.Shitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Shitlabel.Location = new System.Drawing.Point(161, 71);
            this.Shitlabel.Name = "Shitlabel";
            this.Shitlabel.Size = new System.Drawing.Size(373, 29);
            this.Shitlabel.TabIndex = 12;
            this.Shitlabel.Text = "Інформація про обраний товар";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.workerFlowLayoutPanel);
            this.panel1.Controls.Add(this.btnOpenAddWorkerForm);
            this.panel1.Location = new System.Drawing.Point(1561, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 348);
            this.panel1.TabIndex = 13;
            // 
            // workerFlowLayoutPanel
            // 
            this.workerFlowLayoutPanel.AutoScroll = true;
            this.workerFlowLayoutPanel.Location = new System.Drawing.Point(10, 56);
            this.workerFlowLayoutPanel.Name = "workerFlowLayoutPanel";
            this.workerFlowLayoutPanel.Size = new System.Drawing.Size(295, 278);
            this.workerFlowLayoutPanel.TabIndex = 1;
            // 
            // btnOpenAddWorkerForm
            // 
            this.btnOpenAddWorkerForm.Location = new System.Drawing.Point(19, 16);
            this.btnOpenAddWorkerForm.Name = "btnOpenAddWorkerForm";
            this.btnOpenAddWorkerForm.Size = new System.Drawing.Size(276, 23);
            this.btnOpenAddWorkerForm.TabIndex = 0;
            this.btnOpenAddWorkerForm.Text = "Додати працівника";
            this.btnOpenAddWorkerForm.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(1610, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Список Робітників";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Shitlabel);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.StoragePanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "Form1";
            this.Text = "Storage_App";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StoragePanel.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel StoragePanel;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label AddLabel;
        private Label Shitlabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Label autorLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox PriceChange;
        private TextBox quanitityChange;
        private TextBox NameTextbox;
        private Label dateLabel;
        private Button changePic;
        private Button changeSavebtn;
        private Panel panel1;
        private Label label5;
        private Button btnOpenAddWorkerForm;
        private FlowLayoutPanel workerFlowLayoutPanel;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
    }
}

