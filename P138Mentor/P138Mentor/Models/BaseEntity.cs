﻿namespace P138Mentor.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get;}
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }


    }
}
