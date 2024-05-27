using Serilog;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("Logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true)
                .CreateLogger();

            //LessonOne.Program.Start();
            //LessonTwo.Program.Start();
            //LessonThree.Program.Start();
            //StudyThree.Program.Start();
            //LessonFour.Program.Start();
            //LessonFive.Program.Start();
            //LessonSix.Program.Start();
            //LessonSeven.Program.Start();
            //LessonEight.Program.Start();
            //LessonNine.Program.Start();
            LessonTen.Program.Start();
        }
    }
}
