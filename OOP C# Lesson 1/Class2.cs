using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__Lesson_1
{
    struct Article
    {
        public int id;
        public string title;
        public int price;
        public ArticleType Type;
        public Article(int id,string title, int price, ArticleType type)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.Type = type;
        }
    }

    public enum ArticleType
    {
        Type1,
        Type2,
        Type3
    }
    public partial class Class
    {
        private int _num;
        public int Num { get { return _num; } set {  _num = value; } }

        public string Asd2 { get; set; }
        public void Der(int num = 12, params int [] cow) {
            Article article1 = new Article(1,"Товар",100,ArticleType.Type1);
        
        
        }
    }
}
