namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Question
    {
        private static int number;
        public static string GetQuestion()
        {
            number = RandomNumber.generateNumber.Next(0, StoreQuestion.count);

            return StoreQuestion.getquestion[number].ToString();
        }

        public static bool CheckQuestion(string value)
        {
            if (value == StoreQuestion.answer[StoreQuestion.count])
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
