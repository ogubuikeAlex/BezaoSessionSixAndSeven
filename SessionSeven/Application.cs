using System.Collections;

namespace SessionSix.SessionSeven
{
    internal class Application
    {
    }

    public class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Bezao
    {
        static string[] memberNames = { "Rachel", "Nneka", "Zoba", "Chinenye", "Amara", "Amaka", "Goodness" };

        static ArrayList allMembers = new ArrayList(memberNames);

        public static void AddMembers(object member)
        {
            allMembers.Add(member);
        }

        public static void Display()
        {
            foreach (object item in allMembers)
            {
                Console.WriteLine(item);
                /*if (item is string _member)
                {                   
                    Console.WriteLine(_member);
                    continue;
                }
                //Member user = (Member)item;
                Member user = item as Member;
                Console.WriteLine(user.Name);*/
            }
        }

        public static void ChangeMemberAge(int member)
        {
            allMembers.Add(member);
        }

        public class BezaoCollection : IEnumerable
        {
            Member[] members = new Member[10];
            int count = 0;

            public int AddMembers(Member member)
            {
                if (count != members.Length)
                {
                    members[count] = member;
                    count++;
                    return count;
                }
                //var length = members.Length; //11
                //count 11
                Array.Resize(ref members, count);               
                members[count] = member; //members[11] = member
                count++;
                return count;
            }

            public IEnumerator GetEnumerator()
            {
                return members.GetEnumerator();
            }

            public void Display()
            {
                foreach (Member item in members)
                {
                    Member user = item as Member;
                    Console.WriteLine(user.Name);
                }
            }


        }

        public class BezaoCollection<T> : IEnumerable
        {
            T[] members = new T[10];
            int count = 0;

            public virtual int AddMembers(T member)
            {
                if (count != members.Length)
                {
                    members[count] = member;
                    count++;
                    return count;
                }
                //var length = members.Length; //11
                //count 11
                Array.Resize(ref members, count);
                members[count] = member; //members[11] = member
                count++;
                return count;
            }

            public IEnumerator GetEnumerator()
            {
                return members.GetEnumerator();
            }

            public void Display()
            {
                foreach (T item in members)
                {                   
                    Console.WriteLine(item);
                }
            }


        }

        public class IntCollection: BezaoCollection<int>
        {

        }

        public class StringCollection : BezaoCollection<string>
        {

        }
    }

    public class GenericClass<T> where T : Bezao
    {

    }

    public class GenericClassTwo<T> 
    {

    }

    public class BezaoTwo: Bezao { }

    public class Play
    {        
        public void Run()
        {
            GenericClass<BezaoTwo> genericClass = new GenericClass<BezaoTwo>();
        }

        public void RunTwo<T>(T t)
        {
            switch (t)
            {
                case GenericClassTwo<string> genericString:
                    Console.WriteLine("String");
                    break;
                case GenericClassTwo<int> genericInt:
                    Console.WriteLine("int");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }

        }
    }
}
