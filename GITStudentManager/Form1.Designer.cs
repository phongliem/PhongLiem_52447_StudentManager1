namespace GITStudentManager
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
            delete = new Button();
            search = new Button();
            update = new Button();
            add = new Button();
            txtlop = new TextBox();
            gender = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            txtname = new TextBox();
            board = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)board).BeginInit();
            SuspendLayout();
            // 
            // delete
            // 
            delete.Location = new Point(158, 421);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(116, 49);
            delete.TabIndex = 10;
            delete.Text = "Xoá";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(29, 421);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(116, 49);
            search.TabIndex = 9;
            search.Text = "Tìm kiếm";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // update
            // 
            update.Location = new Point(158, 356);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(116, 49);
            update.TabIndex = 8;
            update.Text = "Cập nhật";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // add
            // 
            add.Location = new Point(22, 356);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(116, 49);
            add.TabIndex = 7;
            add.Text = "Thêm";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // txtlop
            // 
            txtlop.Font = new Font("Segoe UI", 13F);
            txtlop.Location = new Point(80, 289);
            txtlop.Margin = new Padding(3, 4, 3, 4);
            txtlop.Name = "txtlop";
            txtlop.Size = new Size(226, 36);
            txtlop.TabIndex = 6;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.ItemHeight = 20;
            gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            gender.Location = new Point(111, 227);
            gender.Margin = new Padding(3, 4, 3, 4);
            gender.Name = "gender";
            gender.Size = new Size(113, 28);
            gender.TabIndex = 5;
            gender.Text = "Nam/Nữ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(-4, 201);
            label2.Name = "label2";
            label2.Size = new Size(142, 36);
            label2.TabIndex = 4;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(-4, 272);
            label3.Name = "label3";
            label3.Size = new Size(142, 36);
            label3.TabIndex = 3;
            label3.Text = "Lớp";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(0, 129);
            label1.Name = "label1";
            label1.Size = new Size(142, 36);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(delete);
            splitContainer1.Panel1.Controls.Add(search);
            splitContainer1.Panel1.Controls.Add(update);
            splitContainer1.Panel1.Controls.Add(add);
            splitContainer1.Panel1.Controls.Add(txtlop);
            splitContainer1.Panel1.Controls.Add(gender);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtname);
            splitContainer1.Panel1.Controls.Add(label1);
            
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(board);
            
            splitContainer1.Size = new Size(854, 483);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 28);
            label4.Name = "label4";
            label4.Size = new Size(252, 38);
            label4.TabIndex = 11;
            label4.Text = "Thông tin sinh viên";
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 13F);
            txtname.Location = new Point(122, 110);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(226, 36);
            txtname.TabIndex = 1;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // board
            // 
            board.BackgroundColor = SystemColors.ControlLightLight;
            board.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            board.Location = new Point(3, 4);
            board.Margin = new Padding(3, 4, 3, 4);
            board.Name = "board";
            board.RowHeadersWidth = 51;
            board.Size = new Size(606, 581);
            board.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 483);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)board).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button delete;
        private Button search;
        private Button update;
        private Button add;
        private TextBox txtlop;
        private ComboBox gender;
        private Label label2;
        private Label label3;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label label4;
        private TextBox txtname;
        private DataGridView board;
    }
}
