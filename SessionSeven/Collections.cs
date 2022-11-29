namespace SessionSix.SessionSeven
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Collections
    {
        public static void UseList()
        {
            List<Person> people = new List<Person>() 
            {
                new Person(),
                new Person() {Id = 2, Name = "Amos"},
            };
            
            people.Add(new Person() { Id = 3, Name = "Alex" });
            people.Add(new Person { Id = 4, Name = "Ebube" });
            //Check!!
            people.Append(new Person() { Id = 5, Name = "Amaka" });
            
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
        
       public static void UseStack()
       {
            Stack<Person> people = new Stack<Person>();

            people.Push(new Person() { Name = "Alex", Id = 1});
            people.Push(new Person() { Name = "Ebube", Id = 2});
            people.Push(new Person() { Name = "Nneka", Id = 3});

            Console.WriteLine(people.Peek().Name); 
            people.Pop();
            Console.WriteLine(people.Peek().Name);
            people.Pop();
            Console.WriteLine(people.Peek().Name);
            people.Pop();
            Console.WriteLine(people.Peek().Name);
            people.Pop();
        }
        
        public static void UseQueue()
        {
            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(new Person() { Name = "Alex", Id=1});
            queue.Enqueue(new Person() { Name = "Chuka", Id=2});
            queue.Enqueue(new Person() { Name = "Bello", Id=3});

            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);            
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
        }

        public static void UsePriorityQueue()
        {
            PriorityQueue<Person, int> queue = new PriorityQueue<Person, int>();

            queue.Enqueue(new Person() { Name = "Alex", Id = 1 }, 20);
            queue.Enqueue(new Person() { Name = "Stephen", Id = 3 }, 1);
            queue.Enqueue(new Person() { Name = "Zhuka", Id = 2 }, 1);
            queue.Enqueue(new Person() { Name = "Bello", Id = 3 }, 5);
            queue.Enqueue(new Person() { Name = "Nelson", Id = 3 }, 2);

            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Name);
            queue.Dequeue();
        }

        public static void UseDictionary ()
        {
            Dictionary<string, Person> dictionary = new ();
            Dictionary<string, int> dictionary2 = new ();
            Dictionary<int, int> dictionary3 = new ();

            dictionary.Add("KAlex", new Person() { Name = "Alex" });
            dictionary.Add("KGoody", new Person() { Name = "Goody" });
            dictionary.Add("KCharles", new Person() { Name = "Charles" });
            dictionary.Add("KIsrael", new Person() { Name = "Israel" });
            dictionary.Add("KKendrick", new Person() { Name = "Kendrick" });

            dictionary.Remove("KIsrael");

            KeyValuePair<string, Person> keyValuePair = new KeyValuePair<string, Person>();
        }

        public class SortPerson : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
               return y.Id.CompareTo(x.Id);
            }
        }
        public static void UseSortedSet()
        {            
            SortedSet<Person> set = new SortedSet<Person>(new SortPerson());

            set.Add(new Person() { Name = "Alex", Id = 6 });
            set.Add(new Person() { Name = "Alex", Id = 1 });
            set.Add(new Person() { Name = "Alex", Id = 4});
            set.Add(new Person() { Name = "Alex", Id = 2 });

            foreach(var person in set)
            {
                Console.WriteLine(person.Id);
            }
        }
    }
}
