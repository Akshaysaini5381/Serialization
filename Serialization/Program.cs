using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace testing__all_program
{
    [Serializable]

    class MyClass
    {
        private int empNo;
        private string empName;
        private double empSal;

        public void SetempNo(int empNo)
        {
            this.empNo = empNo;
        }
        public void SetempName(string empName)
        {
            this.empName = empName;

        }
        public void SetempSal(double empSal)
        {
            this.empSal = empSal;
        }
    }
    class chetu
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello :");
            MyClass obj1 = new MyClass();
            obj1.SetempNo(101);
            obj1.SetempName("akshay");
            obj1.SetempSal(56.98);

            FileStream fs = new FileStream("C:\\akshay125.txt", FileMode.OpenOrCreate);
            BinaryFormatter bt = new BinaryFormatter();
            bt.Serialize(fs, obj1);

            fs.Close();


            Console.WriteLine("Save :");
            Console.ReadLine();
            Console.Read();
        }
    }


}



