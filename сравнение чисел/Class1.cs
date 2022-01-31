using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You
{
    class Numbers
    {
       private string number;
        public char[] sumbol;
        public bool znak = true;
        //public string Number
        //{
        //    get { return number != null ? number : "0"; }
        //    set { number = value; }     // подсматрел из учебника но почему тут постоянно всплывает value пока не понятно 
        //}

        public Numbers( string number) {
            this.number = number;

        }
        public bool Znak (char []sumbol,char a)
        {
            return znak = (int)sumbol[0] > (int) sumbol[2] ? true : false;
        }
        public bool Znak_1(char[] sumbol, char a)
        {
            return znak = (int)sumbol[0] < (int)sumbol[2] ? true : false;
        }
        public bool Znak_2(char[] sumbol, char a)
        {
            return znak = (int)sumbol[0] >= (int)sumbol[2] ? true : false;
        }
        public bool Znak_3(char[] sumbol, char a)
        {
            return znak = (int)sumbol[0] <= (int)sumbol[2] ? true : false;
        }


        public bool Print ()
        {
            return znak;
        }
    }
}
