namespace Kur_ach
{
    partial class AddWorkerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkerLogin = new System.Windows.Forms.TextBox();
            this.txtWorkerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(12, 113);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 0;
            this.btnAddWorker.Text = "Додати";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть логін працівника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть пароль працівника";
            // 
            // txtWorkerLogin
            // 
            this.txtWorkerLogin.Location = new System.Drawing.Point(31, 35);
            this.txtWorkerLogin.Name = "txtWorkerLogin";
            this.txtWorkerLogin.Size = new System.Drawing.Size(124, 20);
            this.txtWorkerLogin.TabIndex = 4;
            // 
            // txtWorkerPassword
            // 
            this.txtWorkerPassword.Location = new System.Drawing.Point(31, 74);
            this.txtWorkerPassword.Name = "txtWorkerPassword";
            this.txtWorkerPassword.Size = new System.Drawing.Size(124, 20);
            this.txtWorkerPassword.TabIndex = 5;
            this.txtWorkerPassword.UseSystemPasswordChar = true;
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 141);
            this.Controls.Add(this.txtWorkerPassword);
            this.Controls.Add(this.txtWorkerLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddWorker);
            this.Name = "AddWorkerForm";
            this.Text = "Додати працівника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkerLogin;
        private System.Windows.Forms.TextBox txtWorkerPassword;
    }
}
