using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Hyper
{
    public class Worker
    {
        #region Properties

        public bool loggedIn = false;

        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //private string surname;
        //public string Surname
        //{
        //    get
        //    {
        //        return surname;
        //    }
        //    set
        //    {
        //        surname = value;
        //    }
        //}

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        //private string position;
        //public string Position
        //{
        //    get
        //    {
        //        return position;
        //    }
        //    set
        //    {
        //        position = value;
        //    }
        //}

        //private int empNumber;
        //public int EmpNumber
        //{
        //    get
        //    {
        //        return EmpNumber;
        //    }
        //    set
        //    {
        //        EmpNumber = value;
        //    }
        //}

        //private int balance = 0;
        //public int Balance
        //{
        //    get
        //    {
        //        return balance;
        //    }
        //    set
        //    {
        //        balance = value;
        //    }
        //}

        #endregion

        #region Constructor

        public Worker(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        #endregion

        #region Methods

        public bool ChangePass(string oldPass, string newPass)
        {
            if (oldPass == newPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
