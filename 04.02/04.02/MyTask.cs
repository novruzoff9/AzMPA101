
using System.Security.Cryptography.X509Certificates;

namespace _04._02
{
    internal class MyTask
    {
        private static int _idCounter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
        public string TaskStatus { get; set; }
        public MyTask()
        {
            Id = ++_idCounter;
            Created = DateTime.Now;

        }
        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}, Created: {Created}, DeadLine: {DeadLine}, TaskStatus: {TaskStatus}";
        }

    }
}
