using FormBuilder.Core.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBuilder.Application.BuisnessInterfaces
{
    public interface IQuestionsAyushService
    {
        public void insertQuestion(QuestionsAyush question);
    }
}
