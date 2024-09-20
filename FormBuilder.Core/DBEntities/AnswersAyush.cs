using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormBuilder.Core.DBEntities
{
    public class AnswersAyush
    {
        [Key]
        public int ansId {  get; set; }

        [ForeignKey("QuestionsAyush")]
        public int questionId { get; set; }
        public int answerOption { get; set; }
        public string answer { get; set; }
        public bool correct {  get; set; }
    }
}
