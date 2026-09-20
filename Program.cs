using System;
using System.Windows.Forms;
                    
namespace QuizApp
{
    internal static class Program
    {
        [STAThread]
        static void Main(string args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length > 0)
            {
                if(args[0] == "/create") Application.Run(new CreateQuiz()); // from Home.cs line:14
                else Application.Run(new PlayQuiz(args[0].Replace('*', ' '))); // from Home.cs line:108
            
                return;
            }

            Application.Run(new Home());
        }
    }
}