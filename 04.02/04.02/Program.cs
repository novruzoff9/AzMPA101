using _04._02;

MyTask task1 = new MyTask
{
    Title = "Task 1",
    Description = "Description for Task 1",
    DeadLine = DateTime.Now.AddDays(7),
    TaskStatus = "Open"
};
MyTask task2 = new MyTask
{
    Title = "Task 2",
    Description = "Description for Task 2",
    DeadLine = DateTime.Now.AddDays(14),
    TaskStatus = "In Progress"
};
//Console.WriteLine(task1.Id );
//Console.WriteLine(task2.Id );
//Console.WriteLine(task1);
TaskService taskService = new TaskService();
taskService.AddTask(task1);

MyTask task3 = new MyTask
{
    Title = "Task 1",
    Description = "Description for Task 1",
    DeadLine = DateTime.Now.AddDays(7),
    TaskStatus = "Open"
};
taskService.AddTask(task3);