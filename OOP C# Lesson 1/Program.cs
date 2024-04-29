using System.Runtime.CompilerServices;
using Russia;
using France;
using Germany; 

namespace OOP_C__Lesson_1
{   
   

    struct Client
    {
        public int id;
        public string name;
        public string adress;
        public int phone;
        public int numbersoforders;
        public double summOrders;
        public ClientType type;
        public Client(int id,string name,string adress,int phone,int numbersoforders,double summOrders,ClientType type)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.type = type;
        }
    }

   public enum ClientType {
        VIP,
        Medium,
        Low
    }

    
    

    internal class Program
    {   
        
        static void Main(string[] args)
        {
            int a = 3;int b;
            Class cl = new Class();
            cl.Method3(ref a, out b);
            Console.WriteLine(b);


            cl.Asd2 = "asd";
            Console.WriteLine(cl.Asd2);

            var Moscow = new Moscow(13149803);
            var Berlin = new Berlin(3000000);
            var Paris  = new Paris(2000000);

            Console.WriteLine($"Москва,Россия:{Moscow.Population} человек");
            Console.WriteLine($"Берлин,Германия:{Berlin.Population} человек");
            Console.WriteLine($"Париж,Франция:{Paris.Population} человек");
        }
    }
}
