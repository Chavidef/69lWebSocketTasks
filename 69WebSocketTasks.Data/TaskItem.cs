using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _69WebSocketTasks.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
