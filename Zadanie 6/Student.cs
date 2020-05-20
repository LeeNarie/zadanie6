using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zadanie5
{
    class Student
    {
        static int id;
        static string Fio;
        static string group;
        static string data;

         public ArrayList studinfo = new ArrayList(4);
         static public List<Student> students = new List<Student>();
        public  int Id
        {
            get
            {
                return id;
            }

            set
            {
               if (value>=0) id = value;
            }
        }

       public string FIO
        {
            get
            {
                return Fio;
            }

            set
            {
                if (!value.Trim().Equals("")) Fio = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                if (!value.Trim().Equals("")) group = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public void AddStudent(int id,string Fio, string group,string data)
        {

            studinfo.Add(id);
            studinfo.Add(Fio);
            studinfo.Add(group);
            studinfo.Add(data);
            students.Add(this);
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void StudentWrite()
        {
            foreach (object o in studinfo)
            {
                Console.WriteLine(o + " ");
            }
        }
        static public void StudentWriteFio(Student s)
        {

            Console.WriteLine(s.studinfo[1]);
            
        }

       static public void StudentWriteAge(Student s)
        {

            DateTime Date = DateTime.ParseExact(s.studinfo[3].ToString(), "dd.mm.yyyy", null);
            DateTime now = DateTime.Now;
            TimeSpan age = now.Subtract(Date);
            int years = (int)age.TotalDays;
            years = years / 365;
            Console.WriteLine(years);

        }
        public void ChangeId(int id)
        {
            studinfo[0] = id;
        }

         public void ChangeFio(string Fio)
        {
            studinfo[1] = Fio;
        }
         public void ChangeGroup(string group)
        {
            studinfo[2] = group;
        }
         public void ChangeData(string data)
        {
            studinfo[3] = data;
        }

         public void RemoveStudent()
        {
            students.Remove(this);
            studinfo.Clear();

        }
        static public void WriteAll()
        {
            
            foreach ( Student o in students)
            {
                StudentWriteFio(o);
            }
        }

        static public void WriteAllId(int id_)
        {
            foreach (Student o in students)
            {
                if ( id_ == (int)o.studinfo[0])
                {
                    o.StudentWrite();
                }

            }
        }

       static public void WriteAge(int id_)
        {
            foreach (Student o in students)
            {
                if (id_ == (int)o.studinfo[0])
                {
                    StudentWriteAge(o);
                }

            }
        }

    }
}
