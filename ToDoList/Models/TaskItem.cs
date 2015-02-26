using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class TaskItem
    {
        [Key]
        public int TaskItemId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public int Priority { get; set; }

        public Category Category { get; set; }

        public DateTime PlanedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int SpentTimeInSeconds { get; set; }

        public List<Tag> Tags { get; set; }
    }
}