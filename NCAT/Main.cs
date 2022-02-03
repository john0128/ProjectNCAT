using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NCAT
{
    class Main
    {
        public string id;
        public string password;
        public string wgetextention;
        public string wgetfilename;
        public void fileDownload(String path, String url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        public void defaultfiledwn(String url)
        {
            var wc = new WebClient();
            try
            {
                wc.DownloadFile(url, $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/NCAT Saves/Downloads/{System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}{wgetextention}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e); 
            }
        }

        string versionName = "2022 LTS";
        string versionYear = "NCAT C# 9.0";
        public void blank()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Developed By NineJuan N913");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            blank();
            blank();
            Commands();
        }
        public void Commands()
        {
            for (; ; )
            { //for문을 사용한 이유 : for문이 if문에 있는 내용에 해당되지 않을 때 console이 강제 종료되는 것을 막기 위해서
                string username = string.Empty;
                username = Dns.GetHostName();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("nine@" + username);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" $ ");
                string command = Console.ReadLine();


                if (command == "")
                {
                    Commands();
                }
                if (command == "help")
                {

                }
                if (command == "whoami")
                {
                    String cptname = string.Empty;
                    cptname = Dns.GetHostName();
                    Console.WriteLine("I am, " + cptname);
                    IPHostEntry ipEntry = Dns.GetHostEntry(cptname);
                    IPAddress[] addr = ipEntry.AddressList;
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "hostname -I")
                {
                    string localIP = string.Empty;
                    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                    {
                        socket.Connect("8.8.8.8", 65530);
                        IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                        localIP = endPoint.Address.ToString();
                    }
                    Console.WriteLine("Your IP V4 Address = " + localIP);
                    Commands();
                }
                if (command == "hostname -i")
                {
                    string localIP = string.Empty;
                    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                    {
                        socket.Connect("8.8.8.8", 65530);
                        IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                        localIP = endPoint.Address.ToString();
                    }
                    Console.WriteLine("Your IP V4 Address = " + localIP);
                    Commands();
                }
                if (command == "ip -6 addr show")
                {
                    string localIP = "Not available, please check your network seetings!";

                    IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                        {
                            localIP = ip.ToString();
                            Console.WriteLine(localIP);
                            Console.WriteLine("");
                            Commands();
                        }
                    }
                    Commands();
                }
                if (command == "server(web)")
                {
                    webserver ws = new webserver();
                    ws.subain();
                }
                if (command == "ifconfig") //버그수정
                {
                    System.Diagnostics.Process.Start("ipconfig");
                    System.Threading.Thread.Sleep(1000);
                }
                if (command == "ip addr show")
                {
                    System.Diagnostics.Process.Start("ipconfig");
                    Commands();
                }
                if (command == "date")
                {
                    DateTime dtn = DateTime.Now;
                    Console.WriteLine(dtn);
                    Commands();
                }
                if (command == "clear")
                {
                    Console.Clear();
                    Commands();
                }
                if (command == "version")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("NCAT Version");
                    Console.WriteLine("Version Year: " + versionYear);
                    Console.WriteLine("Version Name: " + versionName);
                    blank();
                    Commands();
                }
                if (command.StartsWith("echo "))
                {
                    string echotext = command.Substring(5);
                    Console.WriteLine(echotext);
                }
                if (command == "tasklist")
                {
                    System.Diagnostics.Process.Start("tasklist");
                    System.Threading.Thread.Sleep(2000);
                    Commands();
                }
                if (command == "999999999")
                {
                    System.Drawing.Color lime = System.Drawing.Color.FromArgb(51, 255, 51);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" _____ ");
                    Console.WriteLine("|  _  |");
                    Console.WriteLine("| |_| |");
                    Console.WriteLine("|____ |");
                    Console.WriteLine(".___/ /");
                    Console.WriteLine("/____/ ");
                    Console.WriteLine("");
                }
                if (command == "NjOtter")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string meme = @"

 _   _    _  _____  _    _               
| \ | |  (_)|  _  || |  | |              
|  \| |   _ | | | || |_ | |_   ___  _ __ 
| . ` |  | || | | || __|| __| / _ \| '__|
| |\  |  | |\ \_/ /| |_ | |_ |  __/| |   
\_| \_/  | | \___/  \__| \__| \___||_|   
        _/ |                             
       |__/                              

";
                    Console.WriteLine(meme);
                    Console.WriteLine("");
                }
                if (command == "WhoIsDeveloper")
                {
                    string title = @"
______                     _                                 _   _  _                 ___                      
|  _  \                   | |                            _  | \ | |(_)               |_  |                     
| | | |  ___ __   __  ___ | |  ___   _ __    ___  _ __  (_) |  \| | _  _ __    ___     | | _   _   __ _  _ __  
| | | | / _ \\ \ / / / _ \| | / _ \ | '_ \  / _ \| '__|     | . ` || || '_ \  / _ \    | || | | | / _` || '_ \ 
| |/ / |  __/ \ V / |  __/| || (_) || |_) ||  __/| |     _  | |\  || || | | ||  __//\__/ /| |_| || (_| || | | |
|___/   \___|  \_/   \___||_| \___/ | .__/  \___||_|    (_) \_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|
                                    | |                                                                        
                                    |_|                                                                        
";
                    Console.WriteLine(title);
                    Console.WriteLine("https://github.com/john0128/NjOtter/");
                }
                if (command == "random.number")
                {
                    Console.Write("Please Write Max Value: ");
                    string rinput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var random = new Random();
                    int rinputToint = Int32.Parse(rinput);
                    int maxrdnum = rinputToint + 1;
                    int result = random.Next(1, maxrdnum);
                    Console.Write("Result: ");
                    Console.WriteLine(result);
                    blank();
                }
                if (command == "random.number.repeat10")
                {
                    Console.Write("Please Write Max Value: ");
                    string rinput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var random = new Random();
                    int rinputToint = Int32.Parse(rinput);
                    int maxrdnum = rinputToint + 1;
                    int result = random.Next(1, maxrdnum);
                    Console.Write("Result: ");
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    blank();
                }
                if (command == "welcome")
                {
                    blank();
                    string anana = @"
 _    _  _____  _      _____  _____ ___  ___ _____ 
| |  | ||  ___|| |    /  __ \|  _  ||  \/  ||  ___|
| |  | || |__  | |    | /  \/| | | || .  . || |__  
| |/\| ||  __| | |    | |    | | | || |\/| ||  __| 
\  /\  /| |___ | |____| \__/\\ \_/ /| |  | || |___ 
 \/  \/ \____/ \_____/ \____/ \___/ \_|  |_/\____/ 
";
                    string bababa = @"

";
                }
                if (command == "the_end?")
                {
                    blank();
                    string developerletter = @"

______                     _                                
|  _  \                   | |                               
| | | |  ___ __   __  ___ | |  ___   _ __    ___  _ __  ___ 
| | | | / _ \\ \ / / / _ \| | / _ \ | '_ \  / _ \| '__|/ __|
| |/ / |  __/ \ V / |  __/| || (_) || |_) ||  __/| |   \__ \
|___/   \___|  \_/   \___||_| \___/ | .__/  \___||_|   |___/
                                    | |                     
                                    |_|                     
";
                    string devnamesshwend = @"
 _   _  _                 ___                        __ _____                                           ___  ___              __  
| \ | |(_)               |_  |                      / //  __ \                                          |  \/  |              \ \ 
|  \| | _  _ __    ___     | | _   _   __ _  _ __  | | | /  \/  ___   _ __ ___   _ __    __ _  ___  ___ | .  . |  __ _  _ __   | |
| . ` || || '_ \  / _ \    | || | | | / _` || '_ \ | | | |     / _ \ | '_ ` _ \ | '_ \  / _` |/ __|/ __|| |\/| | / _` || '_ \  | |
| |\  || || | | ||  __//\__/ /| |_| || (_| || | | || | | \__/\| (_) || | | | | || |_) || (_| |\__ \\__ \| |  | || (_| || | | | | |
\_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|| |  \____/ \___/ |_| |_| |_|| .__/  \__,_||___/|___/\_|  |_/ \__,_||_| |_| | |
                                                    \_\                         | |                                           /_/ 
                                                                                |_|                                               

";
                    string copyrighletter = @"

 _____                             _         _      _        
/  __ \                           (_)       | |    | |       
| /  \/  ___   _ __   _   _  _ __  _   __ _ | |__  | |_  ___ 
| |     / _ \ | '_ \ | | | || '__|| | / _` || '_ \ | __|/ __|
| \__/\| (_) || |_) || |_| || |   | || (_| || | | || |_ \__ \
 \____/ \___/ | .__/  \__, ||_|   |_| \__, ||_| |_| \__||___/
              | |      __/ |           __/ |                 
              |_|     |___/           |___/                  

";
                    string copyrightsend = @"
  __ _____ __    _   _  _                 ___                      
 / //  __ \\ \  | \ | |(_)               |_  |                     
| | | /  \/ | | |  \| | _  _ __    ___     | | _   _   __ _  _ __  
| | | |     | | | . ` || || '_ \  / _ \    | || | | | / _` || '_ \ 
| | | \__/\ | | | |\  || || | | ||  __//\__/ /| |_| || (_| || | | |
| |  \____/ | | \_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|
 \_\       /_/                                                     
                                                                   

";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(developerletter);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(devnamesshwend);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(copyrighletter);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(copyrightsend);
                }
                if (command == "copyrights")
                {
                    blank();
                    Console.WriteLine("(c)GuNine, https://github.com/john0128/NjOtter/");
                    Console.WriteLine("All Rights Reversed");
                }
                if (command == "exit")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "close")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "Exit")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "pwd")
                {

                    Console.WriteLine($"C:/Users/{Environment.UserName}/Documents/NCAT Saves");
                }
                if (command.StartsWith("mkdir "))
                {
                    string mkdir = command.Substring(6);
                    string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string folpath = doc + "/NCAT Saves/";
                    string path = folpath + mkdir;
                    DirectoryInfo di = new DirectoryInfo(path);
                    if (di.Exists == false)
                    {
                        di.Create();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Success!");
                        Commands();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Already Exists!");
                        Commands();
                    }
                }
                if (command.StartsWith("rmdir "))
                {
                    string rmdir = command.Substring(6);
                    string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string folpath = doc + "/NCAT Saves/";
                    string path = folpath + rmdir;
                    DirectoryInfo di = new DirectoryInfo(path);
                    if (di.Exists == true)
                    {
                        di.Delete();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Success!");
                        Commands();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Already Deleted!");
                        Commands();
                    }
                }
                if (command.StartsWith("wget "))
                {
                    string downloadlink = command.Substring(5);
                    try
                    {
                        wgetextention = Path.GetExtension(command);
                        defaultfiledwn(downloadlink);
                        Commands();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Commands();
                    }
                }
                if (command.StartsWith("wget -0 "))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not Support!");
                    Commands(); 
                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
                if (command == "")
                {

                }
            }
        }
        class webserver
        {
            public static HttpListener listener;
            public static string url = "http://localhost:9999/";
            public static int pageViews = 0;
            public static int requestCount = 0;
            public static string pageData =
                "<!DOCTYPE>" +
                "<html>" +
                "  <head>" +
                "    <title>HttpListener Example</title>" +
                "  </head>" +
                "  <body>" +
                "    <p>Page Views: {0}</p>" +
                "    <form method=\"post\" action=\"shutdown\">" +
                "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
                "    </form>" +
                "  </body>" +
                "</html>";


            public static async Task HandleIncomingConnections()
            {
                bool runServer = true;

                // While a user hasn't visited the `shutdown` url, keep on handling requests
                while (runServer)
                {
                    // Will wait here until we hear from a connection
                    HttpListenerContext ctx = await listener.GetContextAsync();

                    // Peel out the requests and response objects
                    HttpListenerRequest req = ctx.Request;
                    HttpListenerResponse resp = ctx.Response;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // Print out some info about the request
                    Console.WriteLine("Request #: {0}", ++requestCount);
                    Console.WriteLine(req.Url.ToString());
                    Console.WriteLine(req.HttpMethod);
                    Console.WriteLine(req.UserHostName);
                    Console.WriteLine(req.UserAgent);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                    if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
                    {
                        Console.WriteLine("Shutdown requested");
                        runServer = false;
                        Console.WriteLine("");
                        Main main = new Main();
                        main.Commands();
                    }

                    // Make sure we don't increment the page views counter if `favicon.ico` is requested
                    if (req.Url.AbsolutePath != "/favicon.ico")
                        pageViews += 1;

                    // Write the response info
                    string disableSubmit = !runServer ? "disabled" : "";
                    byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
                    resp.ContentType = "text/html";
                    resp.ContentEncoding = Encoding.UTF8;
                    resp.ContentLength64 = data.LongLength;

                    // Write out to the response stream (asynchronously), then close it
                    await resp.OutputStream.WriteAsync(data, 0, data.Length);
                    resp.Close();
                }
            }


            public void subain()
            {
                Console.WriteLine("Opening Server...");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("Server Address:");
                Console.WriteLine("   127.0.0.1:9999");
                Console.WriteLine("   0.0.0.0:9999");
                Console.WriteLine("   localhost:9999");
                Console.WriteLine("");
                // Create a Http server and start listening for incoming connections
                listener = new HttpListener();
                listener.Prefixes.Add(url);
                listener.Start();
                Console.WriteLine("Listening for connections on {0}", url);
                WebComd();

                // Handle requests
                Task listenTask = HandleIncomingConnections();
                listenTask.GetAwaiter().GetResult();

                // Close the listener
                listener.Close();
            }

            public void WebComd()
            {
                Console.WriteLine("");
                Console.Write(">> ");
                var WebCmd = Console.ReadKey();
                if (WebCmd.Key == ConsoleKey.Z)
                {
                    listener.Close();
                    var main = new Main();
                    main.Commands();
                }

            }
        }
    }
}

/*
 *Developed by NineJuan
 *Designed by NineJuan
 *copyrights on NineJuan
 *All rights Reserved
 *https://github.com/john0128/NjOtter/
 */
