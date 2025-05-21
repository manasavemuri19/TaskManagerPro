using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerPro.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public string Status { get; set; }
    }
}
