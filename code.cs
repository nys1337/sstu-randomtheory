using System;
using System.Linq;
class Aplication
{
  static void Main(string[] args)
        {
            int state = 1;
            int b = 0;
            Console.WriteLine("введите строку и нажмите Enter");
         
            string str = Console.ReadLine();
            
            char[] ch = new char[str.Length];
            
            while(b<str.Length)
            {
                switch(state)
                {
                    
                    case 1:
                    {
                        if (str[b]=='(') { state=2; b++;break;   }
                        
                        else{ch[b]=str[b]; b++; break;}
                    }
                    case 2:
                    {
                        if (str[b]==')'){ state=1;b++;  break; }
                        
                        else { b++;break;}
                    }
                }
            
            }
                
              Console.WriteLine(ch); 
        }
           
}
