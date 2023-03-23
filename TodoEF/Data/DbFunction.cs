
using Microsoft.EntityFrameworkCore;
using TodoEF.Model;

namespace TodoEF.Data
{
	public class DbFunction : IDbFunction
	{

		TodoDbContext dbContext;

		public DbFunction()
		{
			dbContext = new TodoDbContext();

		}

		public bool AddItem(string title, string note)
		{
			try
			{
				if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(note))
				{
					MessageBox.Show("Fields Should not be empty", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					Todo todo = new Todo()
					{
						Title = title,
						Description = note,
						CreatedDate = DateTime.Now
					};
					dbContext.TodoApp.Add(todo);
					if (dbContext.SaveChanges() > 0)
					{
						MessageBox.Show("Record Added Successfully");
						return true;
					}
					else
					{
						MessageBox.Show("Record Not Added");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public bool DeleteItem(string id) 
		{
			try
			{
				if (string.IsNullOrWhiteSpace(id))
					throw new ArgumentNullException("Id Should not be empty");

				var todo = dbContext.TodoApp.FirstOrDefault(x => x.Id == int.Parse(id));
				if (todo != null)
				{
					var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
														   "Confirmation",
														   MessageBoxButtons.YesNo,
														   MessageBoxIcon.Warning);
					if (confirmResult == DialogResult.Yes)
					{
						dbContext.TodoApp.Remove(todo);
						if (dbContext.SaveChanges() > 0)
							return true;
					}
				}
				return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return false;
		}
		public bool UpdateItem(string id, string title, string note)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(id))
					throw new ArgumentNullException("Id Should not be empty");

				var update = dbContext.TodoApp.FirstOrDefault(x => x.Id == int.Parse(id));
				if (update != null)
				{
					update.Title = title;
					update.Description = note;
					if(dbContext.SaveChanges() > 0)
					return true;
				}
				else
				{
					title = string.Empty;
					note = string.Empty;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return false;
		}
			
	}
}
