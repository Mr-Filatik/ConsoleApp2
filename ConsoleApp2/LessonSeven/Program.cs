using System.Collections;

namespace ConsoleApp2.LessonSeven
{
    internal class Program
    {
        internal static void Start()
        {
            Console.WriteLine("Seven");

            //массив
            string[] array = new string[10];
            array[2] = "a";
            //array[11] = "b"; ERROR
            Console.WriteLine(array[2]);
            Console.WriteLine();

            //список
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Insert(1, "c");
            list.Remove("b");
            Console.WriteLine(list[1]);
            Console.WriteLine();

            //двусвязанный список
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("a");
            linkedList.AddLast("b");
            linkedList.AddAfter(linkedList.Find("a"), "c");
            linkedList.RemoveLast();
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //очередь
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            Console.WriteLine($"Peek: {queue.Peek()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            if (queue.Count > 1)
            {
                Console.WriteLine($"Dequeue: {queue.Dequeue()}");
                Console.WriteLine($"Peek: {queue.Peek()}");
            }
            Console.WriteLine();

            //стек
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine();

            //словарь
            Dictionary<string, int> settings = new Dictionary<string, int>();
            //settings["ScreenHeight"] = 1080;
            settings["ScreenWidth"] = 1920;
            if (settings.ContainsKey("ScreenHeight"))
            {
                Console.WriteLine(settings["ScreenHeight"]);
            }
            else
            {
                settings["ScreenHeight"] = 1080;
            }
            Console.WriteLine(settings["ScreenHeight"]);

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Test", "basa-001-12-368746487");
            profile.Add("Develop", "basa-002-12-368746487");
            profile.Add("Production", "basa-003-12-368746487");

            foreach (var key in settings)
            {
                Console.WriteLine(key.Key + key.Value);
            }

            //IEnumerable
            //MyCustomForEach(settings);
            //MyCustomForEach(array);
            //MyCustomForEach(queue);
            //MyCustomForEach(new MyList());

            Application application = new Application();
            application.Load(Exit);
        }

        public static void Exit()
        {
            Console.WriteLine("LoadExit");
        }

        public static void MyCustomForEach(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class MyList : IEnumerable, IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    //делегаты
    class Application
    {
        int count = 3;

        public Action action { get; private set; }

        public Application()
        {
            action = Click;
        }

        public void Click()
        {
            if (count > 0)
            {
                count--;
                Console.WriteLine("Click");
            }
            else
            {
                action = ClickError;
            }
        }

        public void ClickError()
        {
            Console.WriteLine("ClickError");
        }

        public void Load(Action callback)
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine("cvshbkjc");
            Console.WriteLine("csjcb");
            Console.WriteLine("...");
            Console.WriteLine(1);
            callback?.Invoke();
        }
    }
}