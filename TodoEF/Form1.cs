using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;
using TodoEF.Data;
using TodoEF.Model;

namespace TodoEF
{
	public partial class Form1 : Form
	{
		private readonly IDbFunction _dbFunction;
		private TodoDbContext _dbContext = new TodoDbContext();
		Todo todo = new Todo();

		public Form1()
		{
			InitializeComponent();
			_dbFunction = new Data.DbFunction();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string title = txtTitle.Text;
				string note = txtNote.Text;
				txtTitle.Focus();
				txtNote.Focus();
				_dbFunction.AddItem(title, note);
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string search = txtSearch.Text;
			dataGridView1.DataSource = _dbContext.TodoApp
						 .Where(x => x.Title.Contains(search)).ToList();
			lblRecord.Text = $"Total Records: {dataGridView1.RowCount}";
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{ 
				var t = _dbContext.TodoApp.Find((int)dataGridView1.SelectedCells[0].Value);
				_dbContext.TodoApp.Remove(t);
				_dbContext.SaveChanges(true);
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}