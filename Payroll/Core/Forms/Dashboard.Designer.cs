namespace Payroll.Core.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameUser = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.calculateSalary = new System.Windows.Forms.Button();
            this.viewSubordinates = new System.Windows.Forms.Button();
            this.hz = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelNav);
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.hz);
            this.panel1.Controls.Add(this.viewSubordinates);
            this.panel1.Controls.Add(this.calculateSalary);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.nameUser.Location = new System.Drawing.Point(53, 98);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(78, 16);
            this.nameUser.TabIndex = 1;
            this.nameUser.Text = "Username";
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.buttonDashboard.Location = new System.Drawing.Point(0, 144);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(186, 42);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            this.buttonDashboard.Leave += new System.EventHandler(this.buttonDashboard_Leave);
            // 
            // calculateSalary
            // 
            this.calculateSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.calculateSalary.FlatAppearance.BorderSize = 0;
            this.calculateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateSalary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.calculateSalary.Location = new System.Drawing.Point(0, 186);
            this.calculateSalary.Name = "calculateSalary";
            this.calculateSalary.Size = new System.Drawing.Size(186, 42);
            this.calculateSalary.TabIndex = 2;
            this.calculateSalary.Text = "Calculate Salary";
            this.calculateSalary.UseVisualStyleBackColor = true;
            this.calculateSalary.Click += new System.EventHandler(this.calculateSalary_Click);
            this.calculateSalary.Leave += new System.EventHandler(this.calculateSalary_Leave);
            // 
            // viewSubordinates
            // 
            this.viewSubordinates.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewSubordinates.FlatAppearance.BorderSize = 0;
            this.viewSubordinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSubordinates.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSubordinates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.viewSubordinates.Location = new System.Drawing.Point(0, 228);
            this.viewSubordinates.Name = "viewSubordinates";
            this.viewSubordinates.Size = new System.Drawing.Size(186, 42);
            this.viewSubordinates.TabIndex = 3;
            this.viewSubordinates.Text = "View subordinates";
            this.viewSubordinates.UseVisualStyleBackColor = true;
            this.viewSubordinates.Click += new System.EventHandler(this.viewSubordinates_Click);
            this.viewSubordinates.Leave += new System.EventHandler(this.viewSubordinates_Leave);
            // 
            // hz
            // 
            this.hz.Dock = System.Windows.Forms.DockStyle.Top;
            this.hz.FlatAppearance.BorderSize = 0;
            this.hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hz.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.hz.Location = new System.Drawing.Point(0, 270);
            this.hz.Name = "hz";
            this.hz.Size = new System.Drawing.Size(186, 42);
            this.hz.TabIndex = 4;
            this.hz.Text = "Hz";
            this.hz.UseVisualStyleBackColor = true;
            // 
            // signOut
            // 
            this.signOut.FlatAppearance.BorderSize = 0;
            this.signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.signOut.Location = new System.Drawing.Point(0, 535);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(186, 42);
            this.signOut.TabIndex = 5;
            this.signOut.Text = "Sign out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(0, 193);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 100);
            this.panelNav.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll.Properties.Resources.ffa09aec412db3f54deadf1b3781de2a;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Базовая заработная плата";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(662, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(659, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текущая заработная плата";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button hz;
        private System.Windows.Forms.Button viewSubordinates;
        private System.Windows.Forms.Button calculateSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}