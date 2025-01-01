namespace CompetitionApp.Model
{
    public class Question
    {
        public int Id { get; set; } // Sualın unikal ID-si
        public string Text { get; set; } // Sualın mətni
        public List<string> Options { get; set; } // Cavab variantları (əgər varsa)
        public string ImageUrl { get; set; } // Şəkil URL-si (əgər varsa)
        public string QuestionType { get; set; } // S

        public string? CorrectAnswer { get; set; } // Correct answer

    }
}
