﻿namespace CompetitionApp.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } 
        public List<string> Options { get; set; } 
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
        public string QuestionType { get; set; }        
        public string? CorrectAnswer { get; set; } 
    }
}
