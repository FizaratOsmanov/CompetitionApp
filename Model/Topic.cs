namespace CompetitionApp.Model
{
    public class Topic
    {
        public int Id { get; set; } // Mövzunun unikal ID-si
        public string Name { get; set; } // Mövzunun adı
        public List<Question> Questions { get; set; } // 
    }
}
