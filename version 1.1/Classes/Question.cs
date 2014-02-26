namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public  class Question :IQuestion //в началото на Main метода да има StoreQuestion.Storage(); за да може да вкара въпросите в памета.
    {
        private static int number;
        public static string GetQuestion()
        {
            StoreQuestion storeQuestion = new StoreQuestion();
            number = RandomNumber.generateNumber.Next(0, storeQuestion.count);
            string newQuestion = storeQuestion.getquestion[number].ToString();
            storeQuestion.getquestion.Remove(storeQuestion.getquestion[number]);
            storeQuestion.count--;

            return newQuestion;
        }

        public static bool CheckQuestion(char value)
        {
            StoreQuestion storeQuestion = new StoreQuestion();
            if (value.ToString() == storeQuestion.answer[storeQuestion.count])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string InputForRightAnswer
        {
            get { throw new NotImplementedException(); }
        }
    }
}
