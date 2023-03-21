
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
					MessageBox.Show("Fields Should not be empty","Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return false;
		}
		public bool DeleteItem(int id)
		{
			return true;
		}
	}
	
}
