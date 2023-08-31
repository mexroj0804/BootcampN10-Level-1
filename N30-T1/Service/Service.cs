using N30_T1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N30_T1.Service
{
    public class Service
    {
        List<TaskItem> tasks = new();
        public async Task AddTaskAsync(TaskItem task)
        {
            Task.Run(async () =>
            {
                tasks.Add(task);
                await SaveTasksAsync(task);

            });
        }

        public async Task SaveTasksAsync(TaskItem task)
        {
            Task.Run(() =>
            {
                var fileName = $"{task.Id}.json";
                var folderName = Path.Combine(Directory.GetCurrentDirectory(), "Storage");
                var filePath = Path.Combine(folderName, fileName);
                if (!File.Exists(filePath))
                    return;

                // file ichidagi ma'lutmolarni json shaklida o'qib, listga o'girib  va posts ga o'zlashtirish
                var fileStream = File.Open(filePath, FileMode.Open);
                var previousData = JsonSerializer.Serialize(fileStream);
                

                

                //Clear();
                //AddRange(previousData);

                fileStream.Flush();
                fileStream.Close();
            };
        }
    }
}
