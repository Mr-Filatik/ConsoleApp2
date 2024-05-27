namespace ConsoleApp2.LessonTen
{
    internal class Program
    {
        internal static void Start()
        {
            Task.Run(StartAsync).Wait();
        }

        internal static async Task StartAsync()
        {
            //Варка пельменей
            DateTime dateTime = DateTime.UtcNow;
            TakePan();
            PourWater();
            await PutWaterToBoilAsync();
            ThrowDumplings();
            var task = PutWaterToBoilAsync();
            var task2 = PrepareSauseAsync();
            //await Task.WhenAll(task, task2);
            await task;
            var nameSause = await task2;
            Eat();
            Console.WriteLine($"{DateTime.UtcNow.Second - dateTime.Second} {nameSause}");
            //метод сравнения времени плохой, иногда может выдавать отрицательные секунды)

            //DateTime dateTime = DateTime.UtcNow;
            //var task = MethodAsync();
            //Thread.Sleep(2000);
            //var number = await task;
            //Console.WriteLine($"{DateTime.UtcNow.Second - dateTime.Second}");
        }

        internal static void TakePan() //взять кастрюлю
        {
            Console.WriteLine("взять кастрюлю");
            Task.Delay(1000).Wait();
        }

        internal static void PourWater() //налить воду
        {
            Console.WriteLine("налить воду");
            Task.Delay(1000).Wait();
        }

        internal static async Task PutWaterToBoilAsync() //дождаться закипания
        {
            Console.WriteLine("дождаться закипания");
            await Task.Delay(3000);
        }

        internal static void ThrowDumplings() //бросить пельмени
        {
            Console.WriteLine("бросить пельмени");
            Task.Delay(1000).Wait();
        }

        internal static void Eat() //кушать
        {
            Console.WriteLine("кушать");
            Task.Delay(1000).Wait();
        }

        internal static async Task<string> PrepareSauseAsync() //приготовить соус
        {
            Console.WriteLine("приготовить соус");
            await Task.Delay(2000);
            return "Sause";
        }

        //internal static async Task<int> MethodAsync()
        //{
        //    Console.WriteLine("Method run");
        //    await Task.Delay(2000);
        //    return 0;
        //}
    }
}