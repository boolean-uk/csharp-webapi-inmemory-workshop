using TodoApi.Data;
using TodoApi.Model;

namespace TodoApi.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private TodoContext _db;

        public TaskRepository(TodoContext db)
        {
            _db = db;
        }

        public List<TaskItem> GetAllTasks()
        {
            return _db.TaskItems.ToList();
        }

        public TaskItem AddTask(string taskTitle)
        {
            var taskItem = new TaskItem() { Title=taskTitle };
            _db.Add(taskItem);
            _db.SaveChanges();
            return  taskItem;
        }

        public TaskItem? GetTask(int id)
        {
            return _db.TaskItems.FirstOrDefault(t => t.Id==id);
        }

        public TaskItem? UpdateTask(int id, TaskItemUpdatePayload updateData)
        {
            // check if task exists
            var task = _db.TaskItems.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return null;
            }

            bool hasUpdate = false;

            if(updateData.Title != null)
            {
                task.Title = (string)updateData.Title;
                hasUpdate = true;
            }

            if(updateData.IsCompleted != null)
            {
                task.IsCompleted = (bool)updateData.IsCompleted;
                hasUpdate = true;
            }

            if(!hasUpdate) throw new Exception("No update data provided");
            _db.SaveChanges();
            return task;
        }

    }
}
