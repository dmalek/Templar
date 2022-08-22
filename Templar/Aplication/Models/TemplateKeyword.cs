namespace Templar.Aplication.Models
{
    public class TemplateKeyword
    {
        public string Name { get; set; } = String.Empty;
        public string Value { get; set; } = string.Empty;

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return $"{Name}:{Value}";    
            }

            return "empty";
        }
    }
}
