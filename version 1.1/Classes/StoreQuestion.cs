namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public static class StoreQuestion
    {
        public static List<StringBuilder> getquestion = new List<StringBuilder>();
        public static List<string> answer = new List<string>();
        public static int count = 0;
        public static void Storage()
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

    }
}
