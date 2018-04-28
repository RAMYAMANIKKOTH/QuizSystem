using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    class Question
    {
        public int QuestionNo { get; set; }
        public string QuestionText { get; set; }
        public List<Option> OptionList;

       
    }
}
