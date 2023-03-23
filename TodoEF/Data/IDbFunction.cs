using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoEF.Model;

namespace TodoEF.Data
{
	public interface IDbFunction
	{
		public bool AddItem(string title, string note);
		public bool DeleteItem(string id);
		public bool UpdateItem(string id, string title, string note);
	}
}
