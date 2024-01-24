﻿using TodoApi.Model;

namespace TodoApi.Repository
{
    public interface ITaskRepository
    {
        public List<TaskItem> GetAllTasks();

        public TaskItem AddTask(string taskTitle);

        public TaskItem? GetTask(int id);

        public TaskItem? UpdateTask(int id, TaskItemUpdatePayload updateData);
    }
}
