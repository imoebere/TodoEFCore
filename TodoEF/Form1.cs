
using Microsoft.EntityFrameworkCore;
using TodoEF.Data;
using TodoEF.Model;

namespace TodoEF
{
	public partial class Form1 : Form
	{
		private readonly IDbFunction _dbFunction;
		private readonly TodoDbContext _dbContext;

		public Form1()
		{
			InitializeComponent();
			_dbFunction = new DbFunction();
			_dbContext = new TodoDbContext();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string title = txtTitle.Text;
				string note = txtNote.Text;
				await Task.Run(()=>_dbFunction.AddItem(title, note));
				txtNote.Clear();
				txtTitle.Clear();
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		public void display()
		{
			dataGridView1.DataSource = _dbContext.TodoApp.ToList();
			lblRecord.Text = $"Total Records: {dataGridView1.RowCount}";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			display();
		}

		private async void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string search = txtSearch.Text;
			var result = await _dbFunction.SearchItem(search);
			if (result != null && result.Any())
			{
				dataGridView1.DataSource = result;
				lblRecord.Text = $"Total Records: {dataGridView1.RowCount}";
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (id == null) return;
				var todo = _dbContext.TodoApp.Find(int.Parse(id));
				if (todo == null)
				{
					txtTitle.Text = string.Empty;
					txtNote.Text = string.Empty;
				}
				else
				{
					txtTitle.Text = todo.Title;
					txtNote.Text = todo.Description;
				}
				txtTitle.Focus();
				txtNote.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
				var id = dataGridView1.SelectedCells[0].Value.ToString();
				await Task.Run(()=> _dbFunction.DeleteItem(id));
				display();
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
				var id = dataGridView1.SelectedCells[0].Value.ToString();
				string title = txtTitle.Text;
			    string note = txtNote.Text;
				await Task.Run(()  =>  _dbFunction.UpdateItem(id, title, note));
				display();
			txtTitle.Clear();
			txtNote.Clear();
				
				

		}
	}
}