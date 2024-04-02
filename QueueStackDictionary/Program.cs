namespace QueueStackDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Queue<string> tasks = new();
            //tasks.Enqueue("Hello");
            //tasks.Enqueue("Hello");
            //tasks.Enqueue("Hello");
            //tasks.Enqueue("Hello");
            //AddTask("Create", tasks);
            //ShowAll(tasks);
            //Console.WriteLine();
            //ShowNext(tasks);
            //CompleteTask(tasks);
            //Console.WriteLine();
            //ShowAll(tasks);
            #endregion

            #region Task2
            Dictionary<int, int> Groups = new();
            //AddGroup(1, 10, Groups);
            //AddGroup(2, 10, Groups);
            //AddGroup(3, 50, Groups);
            //AddGroup(6, 30, Groups);
            //AddGroup(4, 70, Groups);
            //RemoveGroup(3, Groups);
            //ShowAllGroups(Groups);
            #endregion
        }
        #region Task1 Methods
        static void AddTask(string taskName, Queue<string> tasks)
        {
            tasks.Enqueue(taskName);
            Console.WriteLine($"{taskName} Task Added Successfully");
        }
        static void ShowAll(Queue<string> tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task Name: {task}");
            }
        }
        static void ShowNext(Queue<string> tasks)
        {
            Console.WriteLine($"Current Task: {tasks.Peek()}");
        }
        static void CompleteTask(Queue<string> tasks)
        {
            Console.WriteLine($"{tasks.Peek()} Task Completed Successfully");
            tasks.Dequeue();
        }
        #endregion

        #region Task2 Methods
        static void AddGroup(int groupNumber, int studentCount, Dictionary<int, int> groups)
        {
            if (!groups.ContainsKey(groupNumber))
            {
                groups.Add(groupNumber, studentCount);
                Console.WriteLine("New Group Added Successfully!");
            }
            else Console.WriteLine("Group Number Already Exists!");
        }
        static void RemoveGroup(int groupNumber, Dictionary<int, int> groups)
        {
            if (groups.ContainsKey(groupNumber))
            {
                groups.Remove(groupNumber);
                Console.WriteLine($"Group Number - {groupNumber} removed successfully.");
            }
            else Console.WriteLine($"Group Number - {groupNumber} not found.");
        }
        static void ShowAllGroups(Dictionary<int, int> groups)
        {
            foreach (var group in groups)
            {
                Console.WriteLine($"Group Number: {group.Key} || Student Count: {group.Value}");
            }
        }
        #endregion
    }
}
