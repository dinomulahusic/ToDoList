using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Tag
    {
        [Key]
        public int TaskItemId { get; set; }

        [Required]
        public string Title { get; set; }
    }
}