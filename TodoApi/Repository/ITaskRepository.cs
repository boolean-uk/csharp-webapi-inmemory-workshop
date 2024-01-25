using TodoApi.Model;

namespace TodoApi.Repository
{
    public interface ITaskRepository<T>
    {
        public List<T> GetAll();

        public T Add(string taskTitle);

        public T? GetSingle(int id);

        public T? Update(int id, TaskItemUpdatePayload updateData);
    }
}
