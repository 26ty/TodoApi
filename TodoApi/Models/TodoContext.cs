//using System;
//namespace TodoApi.Models
//{
//	public class TodoContext
//	{
//		public TodoContext()
//		{
//		}
//	}
//}

using System;

using Microsoft.EntityFrameworkCore; /* to work with a database */

namespace TodoApi.Models;

/* TodoContext 繼承自 DbContext(Entity Framework Core 中的一個類別) */
public class TodoContext : DbContext 
{
    /* TodoContext類別的建構函式，
     * 接受一個 DbContextOptions<TodoContext> 類型的參數，
     * 並且呼叫基類的建構函式，將這個參數傳遞給基類的建構函式。 */
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {

    }

    /* 定義了一個 DbSet<表名>，用於在資料庫中存取 TodoItem 表的對象。*/
    public DbSet<TodoItem> TodoItems { get; set; } = null;
}


