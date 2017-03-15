using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CustomLauncher
{
    public class CKTestClass
    {
        public int x, y;
        public string firstname;
        public int age;
        public string lastname;
        public string display;

        public CKTestClass()
        {
            x = 1;
            y = 2;
            firstname = "Curtis";
            age = 26;
            lastname = "Keilty";
            display = "Initialized";
        }

        public CKTestClass(int x)
        {
            x = 1;
            y = 2;
            firstname = "Curtis";
            age = 26;
            lastname = "Keilty";
        }

        public void SetFirstName(string input)
        {
            firstname = input;
        }

        public string GetName()
        {
            return firstname;
        }

        public string Display()
        {
            display = firstname + " " + lastname + ", age: " + age + "\nx: " + x + " y: " + y;
            return display;
        }

        public void innerAddX()
        {
            x = x + 1;

        }

        public void innerAddY()
        {
            y = y + 2;
        }

        public void IncreaseAge()
        {
            age = age + 1;
        }

        public void ChangeNames()
        {
            if (firstname == "Curtis")
            {
                firstname = "Bob";
                lastname = "Ross";
            } else
            {
                firstname = "Curtis";
                lastname = "Keilty";
            }
        }

        public static int myAdd(int a, int b)
        {
            int ret = a + b;
            return ret;
        }
    }
}
