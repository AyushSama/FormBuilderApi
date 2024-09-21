using System.ComponentModel.DataAnnotations;

namespace FormBuilder.Core.DBEntities
{
    public class QuestionsAyush
    {
        [Key]
        public int questionId {  get; set; }

        public string question {  get; set; }
        
        public string questionType {  get; set; }
    }
}
