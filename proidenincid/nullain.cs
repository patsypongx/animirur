// Create a new TaskManager instance if one doesn't already exist
TaskManager taskManager = new TaskManager();

// Add a new task to the task manager
taskManager.AddTask(new Task(2, "Prepare presentation", "Prepare slides for the upcoming meeting", new DateTime(2024, 3, 20)));

// Assuming the Task constructor is defined as follows:
public Task(int id, string title, string description, DateTime dueDate)
{
    // Initialize properties
    this.Id = id;
    this.Title = title;
    this.Description = description;
    this.DueDate = dueDate;
}

// And the AddTask method is defined within the TaskManager class as:
public void AddTask(Task task)
{
    // Add the task to the internal collection of tasks
    // ...
}
