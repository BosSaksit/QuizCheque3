using System;

namespace testThes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = new int[4];
            string f = "";
            int countprice = 4;
            int total = 0;
            for (int i = 0; i < countprice; i++)
            {
                int aa = i + 1;
                Console.WriteLine("Enter amount #" + aa + ":");
                f = Console.ReadLine();
                price[i] = int.Parse(f);
            }
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] % 5 == 0 && price[i] % 10 == 0)
                {
                    if (price[i].Equals(5))
                    {
                        
                    }
                }
            }

        }
        /* static int a5(string a,int t){
             int b5 =0;
             t = b5;
             if(a.Equals("5")){
                 return t=+1;
             }else{
                 return t;
             }

         }
         public void a10(int a){            
         }
         public void a15(int a){            
         }
         public void a20(int a){            
         }
         public void a25(int a){           
         }
         public void a30(int a){            
         }*/
    }
}

