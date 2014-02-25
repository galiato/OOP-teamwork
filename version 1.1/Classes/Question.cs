namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Question  //в началото на Main метода да има StoreQuestion.Storage(); за да може да вкара въпросите в памета.
    {
        private static int number;
        public static string GetQuestion()
        {
            number = RandomNumber.generateNumber.Next(0, StoreQuestion.count);
            string newQuestion = StoreQuestion.getquestion[number].ToString();
            StoreQuestion.getquestion.Remove(StoreQuestion.getquestion[number]);
            StoreQuestion.count--;

            return newQuestion;
        }

        public static bool CheckQuestion(char value)
        {
            if (value.ToString() == StoreQuestion.answer[StoreQuestion.count])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
