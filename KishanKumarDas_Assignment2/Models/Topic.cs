namespace KishanKumarDas_Assignment2.Models
{
    public class Topic
    {
        public string TopicId { get; set; }
        public string Name { get; set; }

        public List<Faq> Faqs { get; set; }
    }
}
