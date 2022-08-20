namespace Basketball_OOP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sider_thread = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.user1 = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.Label();
            this.sider_track = new System.Windows.Forms.TrackBar();
            this.power_track = new System.Windows.Forms.TrackBar();
            this.power_thread = new System.Windows.Forms.Timer(this.components);
            this.move_thread = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1tablo = new System.Windows.Forms.Label();
            this.label2tablo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accept_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sider_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power_track)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sider_thread
            // 
            this.sider_thread.Tick += new System.EventHandler(this.sider_thread_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.user1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.user2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 119);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user1.ForeColor = System.Drawing.Color.Maroon;
            this.user1.Location = new System.Drawing.Point(6, 3);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(187, 113);
            this.user1.TabIndex = 0;
            this.user1.Text = "0";
            this.user1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user1_MouseClick);
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.user2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user2.ForeColor = System.Drawing.Color.Maroon;
            this.user2.Location = new System.Drawing.Point(225, 3);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(188, 113);
            this.user2.TabIndex = 1;
            this.user2.Text = "0";
            this.user2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user2_MouseClick);
            // 
            // sider_track
            // 
            this.sider_track.AutoSize = false;
            this.sider_track.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sider_track.Enabled = false;
            this.sider_track.Location = new System.Drawing.Point(65, 542);
            this.sider_track.Name = "sider_track";
            this.sider_track.Size = new System.Drawing.Size(279, 57);
            this.sider_track.TabIndex = 3;
            this.sider_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // power_track
            // 
            this.power_track.AutoSize = false;
            this.power_track.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.power_track.Enabled = false;
            this.power_track.Location = new System.Drawing.Point(12, 257);
            this.power_track.Name = "power_track";
            this.power_track.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.power_track.Size = new System.Drawing.Size(53, 284);
            this.power_track.TabIndex = 4;
            this.power_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // power_thread
            // 
            this.power_thread.Tick += new System.EventHandler(this.power_thread_Tick);
            // 
            // move_thread
            // 
            this.move_thread.Tick += new System.EventHandler(this.move_thread_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87593F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12407F));
            this.tableLayoutPanel2.Controls.Add(this.label1tablo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2tablo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 61);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label1tablo
            // 
            this.label1tablo.AutoEllipsis = true;
            this.label1tablo.AutoSize = true;
            this.label1tablo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1tablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1tablo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1tablo.ForeColor = System.Drawing.Color.Maroon;
            this.label1tablo.Location = new System.Drawing.Point(4, 1);
            this.label1tablo.Name = "label1tablo";
            this.label1tablo.Size = new System.Drawing.Size(201, 59);
            this.label1tablo.TabIndex = 0;
            this.label1tablo.Text = "ИГРОК 1";
            this.label1tablo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2tablo
            // 
            this.label2tablo.AutoEllipsis = true;
            this.label2tablo.AutoSize = true;
            this.label2tablo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2tablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2tablo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2tablo.ForeColor = System.Drawing.Color.Maroon;
            this.label2tablo.Location = new System.Drawing.Point(212, 1);
            this.label2tablo.Name = "label2tablo";
            this.label2tablo.Size = new System.Drawing.Size(203, 59);
            this.label2tablo.TabIndex = 1;
            this.label2tablo.Text = "ИГРОК 2";
            this.label2tablo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 175);
            this.panel1.TabIndex = 6;
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept_button.ForeColor = System.Drawing.Color.Maroon;
            this.accept_button.Location = new System.Drawing.Point(350, 542);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(177, 57);
            this.accept_button.TabIndex = 2;
            this.accept_button.Text = "Бросок";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 53);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.power_track);
            this.Controls.Add(this.sider_track);
            this.Controls.Add(this.accept_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(940, 667);
            this.MinimumSize = new System.Drawing.Size(940, 667);
            this.Name = "Form1";
            this.Text = "Basketball";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sider_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power_track)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sider_thread;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.TrackBar sider_track;
        private System.Windows.Forms.TrackBar power_track;
        private System.Windows.Forms.Timer power_thread;
        private System.Windows.Forms.Timer move_thread;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1tablo;
        private System.Windows.Forms.Label label2tablo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label1;
    }
}

