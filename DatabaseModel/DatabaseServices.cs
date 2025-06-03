// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseServices.cs" company="No CompanyH">
// Project: TaskManager
// Last edit: 15.1.2025 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Dapper;

    /// <summary>
    ///     The database services.
    /// </summary>
    public class DatabaseServices
    {
        #region Public methods

        /// <summary>
        /// The add task.
        /// </summary>
        /// <param name="newTask">
        /// The new task.
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
        public List<Task> AddTask(Task newTask, string databaseName)
        {
            try
            {
                var connectionString = SetConnectionString(databaseName);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var insertQuery = @"
                            INSERT INTO TaskList (TaskId, TaskShortDescription, TaskDescription, TaskPriority, TaskStatus, TaskResponsible, TaskLocation) 
                            VALUES (@TaskId, @TaskShortDescription, @TaskDescription, @TaskPriority, @TaskStatus, @TaskResponsible, @TaskLocation)";
                    connection.Execute(insertQuery, newTask);

                    var selectQuery = "SELECT * FROM TaskList";
                    return connection.Query<Task>(selectQuery).ToList();
                }
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                throw new Exception(
                    $"{nameof(this.AddTask)} failed because the database file was not found: {fileNotFoundEx.Message}",
                    fileNotFoundEx);
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception($"{nameof(this.AddTask)} failed: {sqlEx.Message}", sqlEx);
            }
        }

        /// <summary>
        ///     The get locations.
        /// </summary>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        /// <returns>
        ///     The
        ///     <see>
        ///         <cref>IEnumerable</cref>
        ///     </see>
        ///     .
        /// </returns>
        public List<Locations> GetLocations(string databaseName)
        {
            try
            {
                var connectionString = SetConnectionString(databaseName);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var query = @"SELECT * FROM Locations";

                    return connection.Query<Locations>(query).ToList();
                }
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                throw new Exception(
                    $"{nameof(this.GetLocations)} failed because the database file was not found: {fileNotFoundEx.Message}",
                    fileNotFoundEx);
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception($"{nameof(this.GetLocations)} failed: {sqlEx.Message}", sqlEx);
            }
        }

        /// <summary>
        ///     The get tasks.
        /// </summary>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        /// <returns>
        ///     The
        ///     <see>
        ///         <cref>IEnumerable</cref>
        ///     </see>
        ///     .
        /// </returns>
        public List<Task> GetTasks(string databaseName)
        {
            try
            {
                var connectionString = SetConnectionString(databaseName);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var query = @"
                            SELECT 
                                *
                            FROM TaskList";

                    return connection.Query<Task>(query).ToList();
                }
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                throw new Exception(
                    $"{nameof(this.GetTasks)} failed because the database file was not found: {fileNotFoundEx.Message}",
                    fileNotFoundEx);
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception($"{nameof(this.GetTasks)} failed: {sqlEx.Message}", sqlEx);
            }
        }

        /// <summary>
        ///     The get users.
        /// </summary>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        /// <returns>
        ///     The
        ///     <see>
        ///         <cref>IEnumerable</cref>
        ///     </see>
        ///     .
        /// </returns>
        public List<UserData> GetUsers(string databaseName)
        {
            try
            {
                var connectionString = SetConnectionString(databaseName);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var query = @"
                            SELECT 
                                *
                            FROM UserData";

                    return connection.Query<UserData>(query).ToList();
                }
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                throw new Exception(
                    $"{nameof(this.GetUsers)} failed because the database file was not found: {fileNotFoundEx.Message}",
                    fileNotFoundEx);
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception($"{nameof(this.GetUsers)} failed: {sqlEx.Message}", sqlEx);
            }
        }

        /// <summary>
        ///     The update task.
        /// </summary>
        /// <param name="task">
        ///     The task.
        /// </param>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        public void UpdateTask(Task task, string databaseName)
        {
            var connectionString = SetConnectionString(databaseName);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = @"
            UPDATE TaskList 
            SET TaskShortDescription = @TaskShortDescription,
                TaskDescription = @TaskDescription,
                TaskPriority = @TaskPriority,
                TaskStatus = @TaskStatus,
                TaskResponsible = @TaskResponsible,
                TaskLocation = @TaskLocation
            WHERE TaskId = @TaskId";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", task.TaskId);
                    command.Parameters.AddWithValue("@TaskShortDescription", task.TaskShortDescription);
                    command.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                    command.Parameters.AddWithValue("@TaskPriority", task.TaskPriority);
                    command.Parameters.AddWithValue("@TaskStatus", task.TaskStatus);
                    command.Parameters.AddWithValue("@TaskResponsible", task.TaskResponsible);
                    command.Parameters.AddWithValue("@TaskLocation", task.TaskLocation);

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Extracts the embedded database.
        /// </summary>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        /// <returns>
        ///     The path of the embedded database path.
        /// </returns>
        /// <exception cref="FileNotFoundException">
        ///     The exception.
        /// </exception>
        private static string ExtractEmbeddedDatabase(string databaseName)
        {
            try
            {
                var resourceName = $"TaskManager.Database.{databaseName}";
                var assembly = Assembly.GetExecutingAssembly();
                var tempPath = Path.Combine(Path.GetTempPath(), databaseName);
                if (!File.Exists(tempPath))
                {
                    using (var resourceStream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (resourceStream == null || resourceStream.Length == 0)
                        {
                            throw new FileNotFoundException(
                                $"The embedded resource {resourceName} was not found or is empty.");
                        }

                        using (var fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                        {
                            resourceStream.CopyTo(fileStream);
                        }
                    }
                }

                return tempPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(ExtractEmbeddedDatabase)} failed: {ex.Message}");
            }
        }

        /// <summary>
        ///     Sets connection string for database interaction.
        /// </summary>
        /// <param name="databaseName">
        ///     The database name.
        /// </param>
        /// <returns>
        ///     The connection string.
        /// </returns>
        private static string SetConnectionString(string databaseName)
        {
            var extractedDatabasePath = ExtractEmbeddedDatabase(databaseName);
            return $"Data Source={extractedDatabasePath};";
        }

        #endregion

        public void DeleteTask(Task task, string databaseDb)
        {
            var connectionString = SetConnectionString(databaseDb);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = @"
                        DELETE FROM TaskList
                        WHERE TaskId = @TaskId";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", task.TaskId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}