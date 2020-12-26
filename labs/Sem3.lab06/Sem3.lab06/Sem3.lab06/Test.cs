using System;
using System.Collections.Generic;
using System.Text;

namespace Sem3.lab06
{
    class Test
    {
        public Test() { }
        public Test(int res = 0, int code=0, string name="", string new_topic="" )
        {
            result = res;
            topic = new_topic;
            student_code = code;
            student_name = name;
        }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }

        [MyAttribute("Тема теста")]
        public string topic
        {
            get { return _topic; }
            set { _topic = value; }
        }
        private string _topic;

        public int result { get; set; }

        [MyAttribute(Desc= "Код студента, написавшего тест")]
        public double student_code { get; private set; }

        public string student_name;
        public void Print()
        {
            string test_report = string.Format("Студент: " + student_code.ToString() + ' ' + student_name +
                " сдал тест на тему " + topic + " с результатом " + result.ToString());
            Console.WriteLine(test_report);
        }
    }
}
