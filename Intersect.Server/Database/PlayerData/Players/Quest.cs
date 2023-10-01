using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.GameObjects;
using Intersect.Server.Entities;

using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace Intersect.Server.Database.PlayerData.Players
{

    public class Quest : IPlayerOwned
    {

        public Quest()
        {
        }

        public Quest(Guid id)
        {
            QuestId = id;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public Guid Id { get; private set; }

        [JsonIgnore]
        public Guid QuestId { get; private set; }

        public Guid TaskId { get; set; }

        public int TaskProgress { get; set; }

        public bool Completed { get; set; }

        [NotMapped] public Dictionary<Guid, int> TasksProgress = new Dictionary<Guid, int>();
        [JsonIgnore]
        [Column("TasksProgress")]
        public string TasksProgressJson
        {
            get => JsonConvert.SerializeObject(TasksProgress);
            set
            {
                TasksProgress = JsonConvert.DeserializeObject<Dictionary<Guid, int>>(value ?? "");
                if (TasksProgress == null)
                {
                    TasksProgress = new Dictionary<Guid, int>();
                }
            }
        }

        [JsonIgnore]
        public Guid PlayerId { get; private set; }

        [JsonIgnore]
        public virtual Player Player { get; private set; }

        public string Data()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void UpdateProgress(Guid taskId)
        {
            if (taskId == null || taskId == Guid.Empty)
            {
                return;
            }
                
            if (TasksProgress.ContainsKey(taskId))
            {
                // Update the already existing progression
                TasksProgress[taskId]++;
            }
            else
            {
                // Create the progression and initialise to 1
                TasksProgress.Add(taskId, 1);
            }
        }

        public void UpdateProgress(Guid taskId, int amount)
        {
            if (taskId == null || taskId == Guid.Empty)
            {
                return;
            }

            if (TasksProgress.ContainsKey(taskId))
            {
                // Update the already existing progression
                TasksProgress[taskId] = amount;
            }
            else
            {
                // Create the progression and initialise to amount parameter
                TasksProgress.Add(taskId, amount);
            }
        }
    }

}
