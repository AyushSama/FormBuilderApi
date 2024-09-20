using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBuilder.Data.ModelEntities
{
    public class QuestAnsModel
    {
        public string question { get; set; }
        public int answerOption { get; set; }
        public string answer { get; set; }
        public bool correct { get; set; }
    }
}
