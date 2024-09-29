using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhvorykhVA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            var words = value.Split(' '); 

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length % 2 != 0 && word.Length > 1)
                {
                    int middleIndex = word.Length / 2;
                    word = word.Remove(middleIndex, 1); 
                }

                words[i] = word; 
            }

            return string.Join(" ", words); 
        }
    }
}
