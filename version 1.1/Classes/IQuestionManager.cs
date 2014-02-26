using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public interface IQuestionManager
    {
        IQuestion GetQuestion();
        void PrintQuestion(IQuestion question);
        
    }
}
