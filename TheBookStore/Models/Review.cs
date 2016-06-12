﻿namespace TheBookStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string FeedBack { get; set; }
        public virtual Book Book { get; set; }
    }
}