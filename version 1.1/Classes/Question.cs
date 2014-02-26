namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public  class Question :IQuestion //в началото на Main метода да има StoreQuestion.Storage(); за да може да вкара въпросите в памета.
    {
        public static int number;
        public static string newQuestion;
        public Question()
        {
            StoreQuestion storeQuestion = new StoreQuestion();
            number = RandomNumber.generateNumber.Next(0, storeQuestion.count);
            newQuestion = StoreQuestion.getquestion[number].ToString();
            StoreQuestion.getquestion.Remove(StoreQuestion.getquestion[number]);
            storeQuestion.count--;
        }

        //public static bool CheckQuestion(char value)
        //{
        //    StoreQuestion storeQuestion = new StoreQuestion();
        //    if (value.ToString() == storeQuestion.answer[storeQuestion.count])
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public string InputForRightAnswer
        {
            get { return StoreQuestion.answer[Question.number]; }
        }
    }
}
