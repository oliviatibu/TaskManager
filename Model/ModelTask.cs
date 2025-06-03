// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelTask.cs" company="Olivia">
// Project: TaskManager
// Last edit: 27.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.Model
{
    using System.Collections.Generic;

    using TaskManager.DatabaseModel;

    /// <summary>
    /// The model task.
    /// </summary>
    public class ModelTask
    {
        #region Public methods

        /// <summary>
        /// The add new task.
        /// </summary>
        /// <param name="newTaskObject">
        /// The new task object.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> AddNewTask(Task newTaskObject, List<Task> data, string databaseName)
        {
            var databaseService = new DatabaseServices();
            List<Task> newData;
            if (!data.Contains(newTaskObject))
            {
                newData = databaseService.AddTask(newTaskObject, databaseName);
            }
            else
            {
                return null;
            }

            return newData;
        }

        /// <summary>
        /// The get locations.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Locations> GetLocations(string databaseName)
        {
            var databaseService = new DatabaseServices();
            var locations = databaseService.GetLocations(databaseName);

            return locations;
        }

        /// <summary>
        /// The get tasks.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> GetTasks(string databaseName)
        {
            var databaseService = new DatabaseServices();
            var tasks = databaseService.GetTasks(databaseName);

            return tasks;
        }

        /// <summary>
        /// The get users.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<UserData> GetUsers(string databaseName)
        {
            var databaseService = new DatabaseServices();
            var users = databaseService.GetUsers(databaseName);

            return users;
        }

        /// <summary>
        /// The go back to tasks.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>List</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> GoBackToTasks(IEnumerable<Task> data, string location)
        {
            var listOfData = new List<Task>();
            foreach (var task in data)
            {
                if (task.TaskLocation == location)
                {
                    listOfData.Add(task);
                }

                if (location == "All Locations")
                {
                    listOfData.Add(task);
                }
            }

            return listOfData;
        }

        /// <summary>
        /// The load detailed task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task LoadDetailedTask(string task, List<Task> data)
        {
            var taskToReturn = new Task();
            foreach (var taskData in data)
            {
                if (taskData.TaskShortDescription == task)
                {
                    taskToReturn.TaskShortDescription = task;
                    taskToReturn.TaskDescription = taskData.TaskDescription;
                    taskToReturn.TaskPriority = taskData.TaskPriority;
                    taskToReturn.TaskResponsible = taskData.TaskResponsible;
                    taskToReturn.TaskStatus = taskData.TaskStatus;
                    taskToReturn.TaskLocation = taskData.TaskLocation;
                    break;
                }
            }

            return taskToReturn;
        }

        /// <summary>
        /// The update task in db.
        /// </summary>
        /// <param name="newFind">
        /// The new find.
        /// </param>
        /// <param name="databaseDb">
        /// The database db.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> UpdateTaskInDb(Task newFind, string databaseDb)
        {
            var databaseService = new DatabaseServices();

            databaseService.UpdateTask(newFind, "Database.db");

            var tasks = databaseService.GetTasks(databaseDb);
            return tasks;
        }

        /// <summary>
        /// The update tasks.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>List</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> UpdateTasks(string location, List<Task> data)
        {
            var taskToReturn = new List<Task>();
            foreach (var taskData in data)
            {
                if (taskData.TaskLocation == location)
                {
                    var task = new Task
                                   {
                                       TaskShortDescription = taskData.TaskShortDescription,
                                       TaskDescription = taskData.TaskDescription,
                                       TaskPriority = taskData.TaskPriority,
                                       TaskResponsible = taskData.TaskResponsible,
                                       TaskStatus = taskData.TaskStatus,
                                       TaskLocation = taskData.TaskLocation
                                   };
                    taskToReturn.Add(task);
                }

                if (location == "All Locations")
                {
                    var task = new Task
                                   {
                                       TaskShortDescription = taskData.TaskShortDescription,
                                       TaskDescription = taskData.TaskDescription,
                                       TaskPriority = taskData.TaskPriority,
                                       TaskResponsible = taskData.TaskResponsible,
                                       TaskStatus = taskData.TaskStatus,
                                       TaskLocation = taskData.TaskLocation
                                   };
                    taskToReturn.Add(task);
                }
            }

            return taskToReturn;
        }

        #endregion

        public void DeleteTask(Task task, string databaseDb)
        {
            var databaseService = new DatabaseServices();

            databaseService.DeleteTask(task, "Database.db");
        }
    }
}