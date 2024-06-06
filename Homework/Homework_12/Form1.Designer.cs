
namespace Homework_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            BookTitle = new DataGridViewTextBoxColumn();
            Lender = new DataGridViewTextBoxColumn();
            Returned = new DataGridViewCheckBoxColumn();
            btnSaveValues = new Button();
            btnChooseFolder = new Button();
            btnLoadFromFile = new Button();
            txtFileName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookTitle, Lender, Returned });
            dataGridView1.Location = new Point(26, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(724, 194);
            dataGridView1.TabIndex = 0;
            // 
            // BookTitle
            // 
            BookTitle.HeaderText = "Book title";
            BookTitle.MinimumWidth = 8;
            BookTitle.Name = "BookTitle";
            // 
            // Lender
            // 
            Lender.HeaderText = "Lender";
            Lender.MinimumWidth = 8;
            Lender.Name = "Lender";
            // 
            // Returned
            // 
            Returned.HeaderText = "Returned?";
            Returned.MinimumWidth = 8;
            Returned.Name = "Returned";
            // 
            // btnSaveValues
            // 
            btnSaveValues.Location = new Point(26, 243);
            btnSaveValues.Name = "btnSaveValues";
            btnSaveValues.Size = new Size(164, 34);
            btnSaveValues.TabIndex = 1;
            btnSaveValues.Text = "Save values";
            btnSaveValues.UseVisualStyleBackColor = true;
            btnSaveValues.Click += btnSaveValues_Click;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(26, 313);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(164, 34);
            btnChooseFolder.TabIndex = 2;
            btnChooseFolder.Text = "Choose folder";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(26, 378);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(164, 34);
            btnLoadFromFile.TabIndex = 3;
            btnLoadFromFile.Text = "Load form file";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(283, 243);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(307, 31);
            txtFileName.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFileName);
            Controls.Add(btnLoadFromFile);
            Controls.Add(btnChooseFolder);
            Controls.Add(btnSaveValues);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSaveValues_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn Lender;
        private DataGridViewCheckBoxColumn Returned;
        private Button btnSaveValues;
        private Button btnChooseFolder;
        private Button btnLoadFromFile;
        private TextBox txtFileName;
    }
}