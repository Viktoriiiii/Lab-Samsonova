namespace Lab01_Samsonova
{
    partial class FormLab01Samsonova
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
            this.panelUpr = new System.Windows.Forms.Panel();
            this.labelNames = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.labelFigure = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelRes = new System.Windows.Forms.Panel();
            this.pictureBoxPict = new System.Windows.Forms.PictureBox();
            this.panelUpr.SuspendLayout();
            this.panelRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPict)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpr
            // 
            this.panelUpr.Controls.Add(this.labelNames);
            this.panelUpr.Controls.Add(this.buttonAdd);
            this.panelUpr.Controls.Add(this.textBoxLength);
            this.panelUpr.Controls.Add(this.comboBoxFigure);
            this.panelUpr.Controls.Add(this.labelFigure);
            this.panelUpr.Controls.Add(this.labelLength);
            this.panelUpr.Controls.Add(this.listBoxNames);
            this.panelUpr.Controls.Add(this.buttonDelete);
            this.panelUpr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpr.Location = new System.Drawing.Point(0, 0);
            this.panelUpr.Name = "panelUpr";
            this.panelUpr.Size = new System.Drawing.Size(681, 86);
            this.panelUpr.TabIndex = 11;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(546, 9);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(39, 13);
            this.labelNames.TabIndex = 8;
            this.labelNames.Text = "Figure:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(340, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 43);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(207, 42);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(75, 20);
            this.textBoxLength.TabIndex = 7;
            this.textBoxLength.Text = "40";
            this.textBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLength_KeyPress);
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "circle",
            "square",
            "triangle"});
            this.comboBoxFigure.Location = new System.Drawing.Point(35, 42);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigure.TabIndex = 4;
            this.comboBoxFigure.Text = "circle";
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(32, 20);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(39, 13);
            this.labelFigure.TabIndex = 3;
            this.labelFigure.Text = "Figure:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(204, 20);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length:";
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(549, 34);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxNames.Size = new System.Drawing.Size(90, 43);
            this.listBoxNames.TabIndex = 5;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(435, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 43);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelRes
            // 
            this.panelRes.Controls.Add(this.pictureBoxPict);
            this.panelRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRes.Location = new System.Drawing.Point(0, 83);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(681, 367);
            this.panelRes.TabIndex = 10;
            // 
            // pictureBoxPict
            // 
            this.pictureBoxPict.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPict.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPict.Name = "pictureBoxPict";
            this.pictureBoxPict.Size = new System.Drawing.Size(681, 367);
            this.pictureBoxPict.TabIndex = 0;
            this.pictureBoxPict.TabStop = false;
            this.pictureBoxPict.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPict_Paint);
            this.pictureBoxPict.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPict_MouseDown);
            this.pictureBoxPict.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPict_MouseMove);
            // 
            // FormLab01Samsonova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.panelUpr);
            this.Controls.Add(this.panelRes);
            this.Name = "FormLab01Samsonova";
            this.Text = "Lab01-Samsonova";
            this.panelUpr.ResumeLayout(false);
            this.panelUpr.PerformLayout();
            this.panelRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpr;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.PictureBox pictureBoxPict;
    }
}

