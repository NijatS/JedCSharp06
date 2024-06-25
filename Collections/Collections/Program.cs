using System.Collections;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            //for (int i = 0; i < 7; i++)
            //{
            //    numbers.Add(3);
            //}

            //numbers.AddRange(new List<int>() { 4, 5, 7 });

            //List<string> names = new List<string>()
            //{
            //    "Azima","Yusif","Kenan"
            //};

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Insert(5, 6);

            //numbers.InsertRange(7,new List<int>() { 8,9, 7 });


            //numbers.Remove(7);

            //numbers.RemoveAt(0);

            //numbers.RemoveRange(0, 5);

            //numbers.Sort();

            //numbers.Reverse();

            //var result = numbers.Contains(7);


            //var result =   numbers.IndexOf(7);

            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Count);
            //numbers.TrimExcess();

            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(result);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //SortedList<int,string> namesCollection = new SortedList<int,string>();

            //namesCollection.Add(2, "Yusif");
            //namesCollection.Add(1, "Azima");
            //namesCollection.Add(3, "Nijat");


            //if(namesCollection.ContainsKey(1))
            //{
            //    Console.WriteLine("1 key-i vardir");
            //}

            //namesCollection[3] = "Kenan";

            //namesCollection.Remove()


            //foreach (var item in namesCollection)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(namesCollection[2]);


            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            //    Console.WriteLine(numbers.Pop());
            //Console.WriteLine("Size " +numbers.Count );
            //Console.WriteLine(numbers.Pop());
            //Console.WriteLine("Size " + numbers.Count);
            //Console.WriteLine(numbers.Pop());
            //Console.WriteLine("Size " + numbers.Count);

            //Console.WriteLine(numbers.Peek());


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Size " + queue.Count);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Size " + queue.Count);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Size " + queue.Count);
            //Console.WriteLine(queue);

            //HashSet<int> hashSet = new HashSet<int>();

            //hashSet.Add(1);
            //hashSet.Add(2);
            //hashSet.Add(3);
            //hashSet.Add(1);


            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("Azima");
            //arrayList.Add("Yusif");
            //arrayList.Add(true);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();
            //Stack stack1 = new Stack();

            //stack1.Push(1);

            //stack1.Push(2);
            //stack1.Push("Nijat");

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(5, 10);
            //hashtable.Add(6, "Nijat");
            //hashtable.Add("6", "Nijat");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}



            //2)Working with Dictionary<TKey, TValue>
            //Create a console application that does the following:

            //Create a dictionary to store student names(key) and their scores(value).
            //Add 5 students and their scores to the dictionary.
            //Display all students and their scores.
            //Update the score of a specific student.
            //Remove a student from the dictionary.
            //Display the updated dictionary.

            //Dictionary<string, double> dic = new Dictionary<string, double>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("telebe adini girin: ");
            //    string name = Console.ReadLine();
            //    Console.Write("bali daxil edin: ");
            //    double.TryParse(Console.ReadLine(), out double value);
            //    dic.Add(name, value);
            //}


            //foreach(KeyValuePair<string,double> item in dic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.Write("deyisdirmek ucun telebe adini daxil edin: ");
            //string studentName = Console.ReadLine();


            //if (dic.ContainsKey(studentName)) {
            //    Console.Write("yeni bali daxil edin: ");
            //    double.TryParse(Console.ReadLine(), out double newValue);
            //    dic[studentName] = newValue;
            //}
            //else
            //{
            //    Console.WriteLine("bele bir telebe movcud deyil");
            //}

            //foreach (KeyValuePair<string, double> item in dic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.Write("silinecek telebeni daxil edin: ");
            //string removedStudentName = Console.ReadLine();
            //dic.Remove(removedStudentName);
            //foreach (KeyValuePair<string, double> item in dic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //4)Write a method to find the most frequent element in a List<int> using a Dictionary< int, int>.

           List<int> list = new List<int>() { 4,4,5,7,5};
            Console.WriteLine("The most frequent element is:"+FindFrequent(list));
        }
        static int FindFrequent(List<int>numbers)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            foreach (int number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }
            int MaxCount = 0;
            int MaxElement = 0;
            foreach (var number in dict)
            {
                if (number.Value > MaxCount)
                {
                    MaxCount = number.Value ;
                    MaxElement = number.Key ;
                }
            }
            return MaxElement;
        }
    }
}
