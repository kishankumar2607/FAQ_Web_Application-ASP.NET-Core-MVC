namespace KishanKumarDas_Assignment2.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }

        public List<Faq> Faqs { get; set; }
    }
}
