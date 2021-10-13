using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Students
    {
        string stuNum, stuName, stuSurname, stuImg, dob, gender, phone, addr, moduleCode;

        public Students(string stuNum, string stuName, string stuSurname, string stuImg, string dob, string gender, string phone, string addr, string moduleCode, string text)
        {
            this.stuNum = stuNum;
            this.stuName = stuName;
            this.stuSurname = stuSurname;
            this.stuImg = stuImg;
            this.dob = dob;
            this.gender = gender;
            this.phone = phone;
            this.addr = addr;
            this.moduleCode = moduleCode;
        }

        public string StuNum { get => stuNum; set => stuNum = value; }

        public string StuName { get => stuName; set => stuName = value; }

        public string StuSurname { get => stuSurname; set => stuSurname = value; }

        public string StuImg { get => stuImg; set => stuImg = value; }

        public string DOB { get => dob; set => dob = value; }

        public string Gender { get => gender; set => gender = value; }

        public string Phone { get => phone; set => phone = value; }

        public string Addr { get => addr; set => addr = value; }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }

    }
}
