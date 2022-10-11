using System;
using System.ComponentModel.DataAnnotations;

namespace Lunafit.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }        
        public string Title { get; set; }
        public bool Completed { get; set; }

    }
}
