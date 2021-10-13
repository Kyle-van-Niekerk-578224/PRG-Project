using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Module
    {
        string code, name, link, desc;

        public Module(string code, string name, string link, string desc)
        {
            this.code = code;
            this.name = name;
            this.link = link;
            this.desc = desc;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Link { get => link; set => link = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
