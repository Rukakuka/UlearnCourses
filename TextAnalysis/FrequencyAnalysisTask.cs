using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {

        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string>();

            result = GetBigrams(text, result);


            return result;
        }

        private static Dictionary<string, string> GetBigrams(List<List<string>> text,
             Dictionary<string, string> result)
        {
            var frequency = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < text.Count; i++)
            {
                var sentence = text[i];
                for (int j = 0; j < sentence.Count - 1; j++)
                {
                    var word = sentence[j];
                    var nextWord = sentence[j + 1];

                    frequency = GetFrequency(frequency, word, nextWord);

                    if (result.TryGetValue(word, out _)) // theres already such word 
                    {
                        if (string.CompareOrdinal(nextWord, result[word]) < 0 && IsMaxFrequency(frequency, word, nextWord)) // -> check what word is less & is strict more frequently than all others
                            result[word] = nextWord;
                    }
                    else // no matching words -> add new pair
                        result.Add(word, nextWord);
                }
            }
            return result;
        }
        public static bool IsMaxFrequency(Dictionary<string, Dictionary<string, int>> frequency, string word, string nextWord)
        {
            var maxFreq = System.Int32.MinValue;
            foreach (var item in frequency[word])
                if (item.Value >= maxFreq)
                    maxFreq = item.Value;
            if (frequency[word][nextWord] > maxFreq)
                return true;
            return false;
        }
        private static Dictionary<string, Dictionary<string, int>> GetFrequency(Dictionary<string, Dictionary<string, int>> frequency, string word, string nextWord)
        {
            if (frequency.TryGetValue(word, out _))
            {
                if (frequency[word].TryGetValue(nextWord, out _))
                    frequency[word][nextWord]++;
                else
                    frequency[word].Add(nextWord, 1);
            }
            else
                frequency.Add(word, new Dictionary<string, int> { { nextWord, 1 } });
            return frequency;
        }
    }
}
