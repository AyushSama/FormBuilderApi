using FormBuilder.Core.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBuilder.Data.ModelEntities
{
    public class MainModel
    {
        public QuestionsAyush questionsAyush { get; set; }
        public AnswersAyush[] answersAyush { get; set; }
    }
}
