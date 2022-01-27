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
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //doc에 내 문서 경로 저장
            string folpath = doc + "/NCAT Saves"; //내 문서 폴더에 NCAT Saves라는 폴더를 만들기 위해 folpath에 경로 지정
            DirectoryInfo di = new DirectoryInfo(folpath); 
            if (di.Exists == false) //만약 내 문서에 NCAT Saves가 없다면 생성
            {
                di.Create();
            }
            var main = new Main();
            main.StartProgram();
        }
        
    }
}
