using System.Text;

namespace ConsoleApp1101
{



    class Person : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Heigth { get; set; }
        public string City { get; set; }

        public int CompareTo(object? obj)
        {
            Person p = obj as Person;

            //if (Age < p.Age)
            //{
            //    return -1;
            //}

            //if (Age > p.Age)
            //{
            //    return 1;
            //}

            //if (Salary < p.Salary)
            //{
            //    return 1;
            //}
            //if (Salary > p.Salary)
            //{
            //    return -1;
            //}

            //if (Heigth < p.Heigth)
            //{
            //    return 1;
            //}
            //if (Heigth > p.Heigth)
            //{
            //    return -1;
            //}
            //return 0;




            //if (Age>p.Age)
            //{
            //    return 1;
            //}
            //if (Age==p.Age && Salary<p.Salary)
            //{
            //    return 1;
            //}
            //if (Age==p.Age && Salary==p.Salary && Heigth<p.Heigth)
            //{
            //    return 1;
            //}
            //return -1;



            if (Age>p.Age || (Age==p.Age && Salary<p.Salary) || Age==p.Age && Salary==p.Salary && Heigth<p.Heigth)
            {
                return 1;
            }
            return -1;


        }

    }

    internal class Program
    {
        static List<Person> personList = new List<Person>();

        static String[] cities = new[]
        {
            "Ankara", "Istanbul", "Bursa", "Eskişehir", "Antalya", "Trabzon"
        };

        static void Main(string[] args)
        {
            //Person p1 = new Person { Age = 20 };
            //Person p2 = new Person { Age = 30 };

           for (int i = 0; i < 100; i++)
           {
            Random r = new Random();
            personList.Add
                    (new Person 
                    { Name = "Al", Age = r.Next(18, 90), Heigth = r.Next(170,190), Salary = r.Next(10000,60000), City = cities[r.Next(0, 6)] });
           }

            personList.Sort();
            IEnumerable<Person> people;
            people = personList.Where(x => x.Salary > 50000);
            people = personList.Where(x => x.City == "Ankara" && x.Age < 30);
            bool found = personList.Exists(x => x.City == "Berlin");
            personList.ForEach(x => x.Age = x.Age * 2);
            Person p1 = personList.Find(x => x.City == "Ankara");
            Person p2 = personList.SingleOrDefault(x => x.City == "Ankara", new Person { City="Ankara"});

            foreach (var p in personList)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("id : {0}; ", p.Id);
                sb.AppendFormat("Age : {0}; ", p.Age);
                sb.AppendFormat("Salary : {0}; ", p.Salary);
                sb.AppendLine("Height :" + p.Heigth);
                Console.WriteLine(sb.ToString());
               
            }
            
        }


    }



}