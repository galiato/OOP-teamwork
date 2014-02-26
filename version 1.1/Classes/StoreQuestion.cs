namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public  class StoreQuestion : IQuestionManager
    {
        public  static List<StringBuilder> getquestion = new List<StringBuilder>();
        public  static List<string> answer = new List<string>();
        public  int count = 0;
        public  void Storage()
        {
            var lineCount = (File.ReadAllLines(@"Questions.txt").Length) / 5; //Трябва да се даде път до .txt файла

            using (StreamReader question = new StreamReader("Questions.txt"))
            {
                for (int i = 0; i < lineCount; i++)
                {
                    StringBuilder qs = new StringBuilder();
                    for (int index = 0; index < 4; index++)
                    {
                        qs.AppendLine(question.ReadLine());
                    }
                    answer.Add(question.ReadLine());
                    getquestion.Add(qs);
                    count++;
                }
            }
        }


        public IQuestion GetQuestion()
        {
            //throw new NotImplementedException();
            return new Question();
        }

        public void PrintQuestion(IQuestion question)
        {
           // throw new NotImplementedException();
            Console.WriteLine(Question.newQuestion);
        }

        public string InputForRightAnswer
        {
            get { return answer[Question.number]; }
        }
    }
}
