using System;
// 需要有這才能建立文件夾
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // 輸入文件開頭的英文
            Console.WriteLine("輸入一些英文");

            // 把輸入的數字帶入english內
            string english = Console.ReadLine(); 

            // 輸入文件結尾的數字/檔案數量
            Console.WriteLine("輸入你要建立的檔案數量");

            // 把輸入的數字帶入number內
            int number=int.Parse(Console.ReadLine());

            // i=0,如i小於number,i+1,並執行迴圈裡的指令一次,在檢查i是不是小於number,如果是，再執行一次並加1,一直循環直到i大於number
            for (int i = 0; i < number; i++)
            {
                //建立文件夾所需的指令，文件夾的名稱為english與i
                Directory.CreateDirectory(english+i); 
            }
        }
    }
}
