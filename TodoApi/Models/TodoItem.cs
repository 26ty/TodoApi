//using System;
//namespace TodoApi.Models
//{
//	public class TodoItem
//	{
//        public long Id { get; set; }
//        public string? Name { get; set; }
//        public bool IsComplete { get; set; }
//    }
//}

using System;
namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; } //關聯式資料庫中的唯一索引鍵
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}

