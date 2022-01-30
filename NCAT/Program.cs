using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NCAT
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Console.Title = "NCAT CLI Enviornment"; //콘솔 창 제목
            string path = "C:/Users/Public/Documents/NCAT Saves"; //doc에 내 문서 /  경로 저장
            DirectoryInfo di = new DirectoryInfo(path); 
            if (di.Exists == false) //만약 내 문서에 NCAT Saves가 없다면 생성
            {
                di.Create();
            }
            var main = new Main();
            main.StartProgram();
        }
        
    }
}
