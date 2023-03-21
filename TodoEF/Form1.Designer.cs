namespace TodoEF
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			label2 = new Label();
			sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			txtTitle = new TextBox();
			label3 = new Label();
			txtNote = new RichTextBox();
			label4 = new Label();
			txtSearch = new TextBox();
			dataGridView1 = new DataGridView();
			todoBindingSource = new BindingSource(components);
			btnSave = new Button();
			Id = new DataGridViewTextBoxColumn();
			Title = new DataGridViewTextBoxColumn();
			Description = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			todoDbContextBindingSource = new BindingSource(components);
			lblRecord = new Label();
			btnDelete = new Button();
			btnUpdate = new Button();
			dataGridViewId = new DataGridViewTextBoxColumn();
			titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			CreatedDate = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)todoBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)todoDbContextBindingSource).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(234, 4);
			label1.Name = "label1";
			label1.Size = new Size(298, 34);
			label1.TabIndex = 0;
			label1.Text = "My Todo Application";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(10, 48);
			label2.Name = "label2";
			label2.Size = new Size(62, 22);
			label2.TabIndex = 1;
			label2.Text = "Title: ";
			// 
			// sqlCommand1
			// 
			sqlCommand1.CommandTimeout = 30;
			sqlCommand1.Connection = null;
			sqlCommand1.Notification = null;
			sqlCommand1.Transaction = null;
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(78, 51);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(239, 23);
			txtTitle.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(8, 80);
			label3.Name = "label3";
			label3.Size = new Size(64, 22);
			label3.TabIndex = 3;
			label3.Text = "Note: ";
			// 
			// txtNote
			// 
			txtNote.Location = new Point(78, 83);
			txtNote.Name = "txtNote";
			txtNote.Size = new Size(239, 192);
			txtNote.TabIndex = 4;
			txtNote.Text = "";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(381, 38);
			label4.Name = "label4";
			label4.Size = new Size(83, 22);
			label4.TabIndex = 5;
			label4.Text = "Search:";
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(470, 37);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(325, 23);
			txtSearch.TabIndex = 6;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewId, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, CreatedDate });
			dataGridView1.DataSource = todoBindingSource;
			dataGridView1.Location = new Point(323, 63);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(472, 361);
			dataGridView1.TabIndex = 7;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// todoBindingSource
			// 
			todoBindingSource.DataSource = typeof(Model.Todo);
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Green;
			btnSave.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSave.ForeColor = SystemColors.ActiveCaptionText;
			btnSave.Location = new Point(251, 288);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(66, 40);
			btnSave.TabIndex = 8;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// Id
			// 
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.Visible = false;
			// 
			// Title
			// 
			Title.HeaderText = "Title";
			Title.Name = "Title";
			// 
			// Description
			// 
			Description.HeaderText = "Description";
			Description.Name = "Description";
			// 
			// Column1
			// 
			Column1.HeaderText = "Column1";
			Column1.Name = "Column1";
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "Id";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "Title";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.HeaderText = "Description";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// todoDbContextBindingSource
			// 
			todoDbContextBindingSource.DataSource = typeof(Data.TodoDbContext);
			// 
			// lblRecord
			// 
			lblRecord.AutoSize = true;
			lblRecord.Location = new Point(326, 430);
			lblRecord.Name = "lblRecord";
			lblRecord.Size = new Size(78, 15);
			lblRecord.TabIndex = 9;
			lblRecord.Text = "Total Record: ";
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.Red;
			btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnDelete.ForeColor = SystemColors.ActiveCaptionText;
			btnDelete.Location = new Point(167, 287);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(66, 36);
			btnDelete.TabIndex = 10;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.Yellow;
			btnUpdate.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
			btnUpdate.Location = new Point(78, 287);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(69, 35);
			btnUpdate.TabIndex = 11;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			// 
			// dataGridViewId
			// 
			dataGridViewId.DataPropertyName = "Id";
			dataGridViewId.HeaderText = "Id";
			dataGridViewId.Name = "dataGridViewId";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			titleDataGridViewTextBoxColumn.HeaderText = "Title";
			titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// CreatedDate
			// 
			CreatedDate.DataPropertyName = "CreatedDate";
			CreatedDate.HeaderText = "CreatedDate";
			CreatedDate.Name = "CreatedDate";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(lblRecord);
			Controls.Add(btnSave);
			Controls.Add(dataGridView1);
			Controls.Add(txtSearch);
			Controls.Add(label4);
			Controls.Add(txtNote);
			Controls.Add(label3);
			Controls.Add(txtTitle);
			Controls.Add(label2);
			Controls.Add(label1);
			ForeColor = SystemColors.ControlDarkDark;
			Name = "Form1";
			Text = "TodoApp";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)todoBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)todoDbContextBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private TextBox txtTitle;
		private Label label3;
		private RichTextBox txtNote;
		private Label label4;
		private TextBox txtSearch;
		private DataGridView dataGridView1;
		private Button btnSave;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Title;
		private DataGridViewTextBoxColumn Description;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private BindingSource todoBindingSource;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private BindingSource todoDbContextBindingSource;
		private Label lblRecord;
		private Button btnDelete;
		private Button btnUpdate;
		private DataGridViewTextBoxColumn dataGridViewId;
		private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn CreatedDate;
	}
}