using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExam
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

       
    }
}

namespace UserAccountNamespace 
{

    abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;  
            user_password = password;
        }

        abstract public bool validateLogin(string uName, string password);

        public string getFullName() 
        {
            return full_name;
        }

    }


    class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            if (uName == user_name && password == user_password)
            {
                return true;
            }
            else { return false; }
        }

        public string getDepartment()
        {
            return department;
        }
    }

}


