namespace STI_Join.MenuOptions
{
    partial class StudentList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgvStudentList = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Button();
            txtSearchBar = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgvStudentList
            // 
            dtgvStudentList.AllowUserToAddRows = false;
            dtgvStudentList.AllowUserToDeleteRows = false;
            dtgvStudentList.AllowUserToOrderColumns = true;
            dtgvStudentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgvStudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvStudentList.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 48, 110);
            dataGridViewCellStyle2.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 26, 59);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvStudentList.ColumnHeadersHeight = 45;
            dtgvStudentList.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvStudentList.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvStudentList.GridColor = Color.FromArgb(249, 207, 88);
            dtgvStudentList.Location = new Point(29, 102);
            dtgvStudentList.MultiSelect = false;
            dtgvStudentList.Name = "dtgvStudentList";
            dtgvStudentList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(223, 223, 223);
            dataGridViewCellStyle4.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 26, 31);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 84, 197);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvStudentList.RowHeadersVisible = false;
            dtgvStudentList.RowHeadersWidth = 50;
            dtgvStudentList.RowTemplate.Height = 50;
            dtgvStudentList.RowTemplate.ReadOnly = true;
            dtgvStudentList.RowTemplate.Resizable = DataGridViewTriState.False;
            dtgvStudentList.Size = new Size(1004, 511);
            dtgvStudentList.TabIndex = 3;
            dtgvStudentList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgvStudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgvStudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgvStudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgvStudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgvStudentList.ThemeStyle.BackColor = Color.FromArgb(250, 250, 250);
            dtgvStudentList.ThemeStyle.GridColor = Color.FromArgb(249, 207, 88);
            dtgvStudentList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dtgvStudentList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvStudentList.ThemeStyle.HeaderStyle.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtgvStudentList.ThemeStyle.HeaderStyle.ForeColor = SystemColors.Window;
            dtgvStudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvStudentList.ThemeStyle.HeaderStyle.Height = 45;
            dtgvStudentList.ThemeStyle.ReadOnly = true;
            dtgvStudentList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgvStudentList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvStudentList.ThemeStyle.RowsStyle.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            dtgvStudentList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgvStudentList.ThemeStyle.RowsStyle.Height = 50;
            dtgvStudentList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dtgvStudentList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dtgvStudentList.CellDoubleClick += dtgvStudentList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 35, 53);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(25, 26, 31);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(29, 629);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.BackColor = Color.FromArgb(232, 237, 249);
            txtSearchBar.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBar.Location = new Point(29, 52);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(922, 35);
            txtSearchBar.TabIndex = 6;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(28, 84, 197);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.refreshIcon;
            btnRefresh.Location = new Point(975, 45);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 42);
            btnRefresh.TabIndex = 9;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(89, 93, 105);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(29, 21);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 8;
            label2.Text = "Search";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.searchBlack;
            pictureBox1.Location = new Point(109, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(txtSearchBar);
            Controls.Add(btnDelete);
            Controls.Add(dtgvStudentList);
            Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "StudentList";
            Size = new Size(1050, 693);
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dtgvStudentList;
        private Button btnDelete;
        private TextBox txtSearchBar;
        private Button btnRefresh;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
