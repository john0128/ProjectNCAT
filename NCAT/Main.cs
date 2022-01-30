using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NCAT
{
    internal class Main
    {
        public string mainpath = "C:/Users/Public/Documents/NCAT Saves";
        public int shutdownminute;
        public int rebootminute;
        public string mkdir;
        public void StartProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Developed By NineJuan N913"); //제작자 표시
            Console.ForegroundColor= ConsoleColor.Green; 
            Console.Write("|"); 
            Console.WriteLine("");
            Console.WriteLine("");//한칸 띄기
            Command();
        }
        public void Command()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530); //
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            Console.Write($"{Environment.MachineName}@{localIP}>"); //PC이름@자신의 IP주소> 로 출력된다
            var Input = Console.ReadLine();
            for (; ; )
            {
                if (Input == "help")
                {
                    Console.WriteLine("help");
                    Command();
                }
                else if (Input == "exit") //나가기 명령어
                {
                    Environment.Exit(0);
                    Command();
                }

                else if (Input == "pwd") //현재 경로를 나타내는 명령어
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("C:\\Users\\Default User\\Documents\\NCAT Saves");
                    Command();
                }
                else if (Input == "shutdown -h now")
                {
                    System.Diagnostics.Process.Start("cmd", "shutdown -s -t 00");
                    Command();
                }
                else if (Input == $"shutdown -h +{shutdownminute}")
                {
                    System.Diagnostics.Process.Start("cmd", $"shutdown -s -t {shutdownminute * 60} -c NCAT에 의한 종료");
                    Command();
                }
                else if (Input == $"shutdown -r +{rebootminute}")
                {
                    System.Diagnostics.Process.Start("cmd", $"shutdown -r -t {rebootminute*60} -c NCAT에 의한 재부팅");
                    Command();
                }
                else if (Input == "reboot")
                {
                    System.Diagnostics.Process.Start("cmd", "shutdown -r -t 00");
                }
                else if (Input == $"mkdir {mkdir}")
                {
                    string dirname = "C:/Users/Public/Documents/NCAT Saves/" + mkdir;
                    DirectoryInfo di = new DirectoryInfo(dirname);
                    if (di.Exists == false) //만약 내 문서에 NCAT Saves가 없다면 생성
                    {
                        di.Create();
                        Command();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cannot Create Directory!\nAlready Exists!");
                    }
                }
                /*else if (Input == "d")
                {

                }
                else if (Input == "d")
                {

                }
                else if (Input == "d")
                {

                }*/

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unavailable Command!\nPlease Use Another Command");
                    Command(); //만약 지정된 명령어가 아닐 경우 빨간 글씨로 위 문구 출력
                }
            }
        }
    }
}
