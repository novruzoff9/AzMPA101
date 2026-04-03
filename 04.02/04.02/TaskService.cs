

namespace _04._02
{
    internal class TaskService : ITaskService
    {
        static MyTask[] tasks = new MyTask[0];
        public void AddTask(MyTask task)
        {
            var existsTask = GetTask(task.Title);
            if (existsTask != null)
            {
                Console.WriteLine("Bu adda tapshiriq artiq movcuddur.");
                return;
            }
            Array.Resize(ref tasks, tasks.Length + 1);
            tasks[tasks.Length - 1] = task;
        }

        public MyTask GetTask(string title)
        {
            foreach (var item in tasks)
            {
                if (item.Title == title )
                    return item;                                    
            }
            
            return null;
        }
    }
}
