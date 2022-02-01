using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You
{
    class Numbers
    {
       private string stroka;
        
        public bool znak = true;
       
        //public string Number
        //{
        //    get { return number != null ? number : "0"; }
        //    set { number = value; }     // подсматрел из учебника но почему тут постоянно всплывает value пока не понятно 
        //}

        public Numbers( string stroka) {
            this.stroka = stroka;
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
            return znak = (int)sumbol[0] == (int)sumbol[2] ? true : false;
        }
      

        public bool Print ()
        {
            return znak;
        }
       
        
        public void Metoddd(string stroka, char asd, Numbers One)
        {
            char[] sumbol = stroka.ToCharArray();
            for (int i = 0; i < stroka.Length; i++)
            {

                if (sumbol[i] == '<')
                {
                    asd = sumbol[i];
                    One.Znak_1(sumbol, asd);
                    Console.WriteLine(One.Print());
                }
                else if (sumbol[i] == '>')
                {
                    asd = sumbol[i];
                    One.Znak(sumbol, asd);
                    Console.WriteLine(One.Print());
                }
                else if (sumbol[i] == '=')
                {
                    asd = sumbol[i];
                    One.Znak_2(sumbol, asd);
                    Console.WriteLine(One.Print());
                }

            }
        }
    }
}
