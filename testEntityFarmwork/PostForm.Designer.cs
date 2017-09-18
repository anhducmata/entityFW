﻿namespace testEntityFarmwork
{
    partial class PostForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvPost = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSavePost = new System.Windows.Forms.Button();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPublish = new System.Windows.Forms.CheckBox();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnAddPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPost
            // 
            this.dgvPost.AutoGenerateColumns = false;
            this.dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.posttitleDataGridViewTextBoxColumn,
            this.postcontentDataGridViewTextBoxColumn,
            this.postauthorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datecreatedDataGridViewTextBoxColumn,
            this.dateupdatedDataGridViewTextBoxColumn});
            this.dgvPost.DataSource = this.postsBindingSource;
            this.dgvPost.Location = new System.Drawing.Point(12, 269);
            this.dgvPost.Name = "dgvPost";
            this.dgvPost.Size = new System.Drawing.Size(746, 247);
            this.dgvPost.TabIndex = 0;
            this.dgvPost.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPost_CellValueChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posttitleDataGridViewTextBoxColumn
            // 
            this.posttitleDataGridViewTextBoxColumn.DataPropertyName = "post_title";
            this.posttitleDataGridViewTextBoxColumn.HeaderText = "post_title";
            this.posttitleDataGridViewTextBoxColumn.Name = "posttitleDataGridViewTextBoxColumn";
            // 
            // postcontentDataGridViewTextBoxColumn
            // 
            this.postcontentDataGridViewTextBoxColumn.DataPropertyName = "post_content";
            this.postcontentDataGridViewTextBoxColumn.HeaderText = "post_content";
            this.postcontentDataGridViewTextBoxColumn.Name = "postcontentDataGridViewTextBoxColumn";
            // 
            // postauthorDataGridViewTextBoxColumn
            // 
            this.postauthorDataGridViewTextBoxColumn.DataPropertyName = "post_author";
            this.postauthorDataGridViewTextBoxColumn.HeaderText = "post_author";
            this.postauthorDataGridViewTextBoxColumn.Name = "postauthorDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // datecreatedDataGridViewTextBoxColumn
            // 
            this.datecreatedDataGridViewTextBoxColumn.DataPropertyName = "date_created";
            this.datecreatedDataGridViewTextBoxColumn.HeaderText = "date_created";
            this.datecreatedDataGridViewTextBoxColumn.Name = "datecreatedDataGridViewTextBoxColumn";
            // 
            // dateupdatedDataGridViewTextBoxColumn
            // 
            this.dateupdatedDataGridViewTextBoxColumn.DataPropertyName = "date_updated";
            this.dateupdatedDataGridViewTextBoxColumn.HeaderText = "date_updated";
            this.dateupdatedDataGridViewTextBoxColumn.Name = "dateupdatedDataGridViewTextBoxColumn";
            //          
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            // usersTableAdapter
            // 
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnSavePost);
            this.panel1.Controls.Add(this.btnDeletePost);
            this.panel1.Location = new System.Drawing.Point(12, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 30);
            this.panel1.TabIndex = 9;
            // 
            // btnSavePost
            // 
            this.btnSavePost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSavePost.Enabled = false;
            this.btnSavePost.Location = new System.Drawing.Point(368, 4);
            this.btnSavePost.Name = "btnSavePost";
            this.btnSavePost.Size = new System.Drawing.Size(98, 23);
            this.btnSavePost.TabIndex = 3;
            this.btnSavePost.Text = "Save Change";
            this.btnSavePost.UseVisualStyleBackColor = false;
            this.btnSavePost.Click += new System.EventHandler(this.BtnSavePost_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeletePost.Location = new System.Drawing.Point(279, 4);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePost.TabIndex = 2;
            this.btnDeletePost.Text = "Delete";
            this.btnDeletePost.UseVisualStyleBackColor = false;
            this.btnDeletePost.Click += new System.EventHandler(this.BtnDeletePost_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.cbPublish);
            this.panel2.Controls.Add(this.cbbUser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbContent);
            this.panel2.Controls.Add(this.tbTitle);
            this.panel2.Controls.Add(this.btnAddPost);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 251);
            this.panel2.TabIndex = 10;
            // 
            // cbPublish
            // 
            this.cbPublish.AutoSize = true;
            this.cbPublish.BackColor = System.Drawing.Color.Linen;
            this.cbPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublish.Location = new System.Drawing.Point(74, 219);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(85, 17);
            this.cbPublish.TabIndex = 17;
            this.cbPublish.Text = "Publish Now";
            this.cbPublish.UseVisualStyleBackColor = false;
            // 
            // cbbUser
            // 
            this.cbbUser.BackColor = System.Drawing.Color.Linen;
            this.cbbUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "id", true));
            this.cbbUser.DataSource = this.usersBindingSource;
            this.cbbUser.DisplayMember = "username";
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(74, 190);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(121, 21);
            this.cbbUser.TabIndex = 16;
            this.cbbUser.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.Linen;
            this.tbContent.Location = new System.Drawing.Point(74, 40);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(546, 144);
            this.tbContent.TabIndex = 11;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.Linen;
            this.tbTitle.Location = new System.Drawing.Point(74, 14);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(546, 20);
            this.tbTitle.TabIndex = 10;
            // 
            // btnAddPost
            // 
            this.btnAddPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost.Location = new System.Drawing.Point(635, 14);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(103, 98);
            this.btnAddPost.TabIndex = 9;
            this.btnAddPost.Text = "Post";
            this.btnAddPost.UseVisualStyleBackColor = false;
            this.btnAddPost.Click += new System.EventHandler(this.BtnAddPost_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPost);
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPost;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posttitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbPublish;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Button btnSavePost;
        private System.Windows.Forms.Button btnDeletePost;
    }
}

