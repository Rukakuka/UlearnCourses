using System.Collections.Generic;
using System;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        private enum Ngrams
        {
            Bigramm = 1,
            Trigramm = 2
        };
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string>();
            result = GetNgrams2(text, result, Ngrams.Bigramm);
            result = GetNgrams2(text, result, Ngrams.Trigramm);

            return result;
        }
        private static Dictionary<string, string> GetNgrams2(List<List<string>> text,
          Dictionary<string, string> result,
          Ngrams gramma)
        {
            var resultWithFrequency = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < text.Count; i++)
            {
                var sentence = text[i];
                for (int j = 0; j < sentence.Count - (int)gramma; j++)
                {
                    string firstWord;
                    string nextWord;

                    switch (gramma)
                    {
                        case Ngrams.Bigramm:
                            firstWord = sentence[j];
                            nextWord = sentence[j + 1];
                            break;
                        case Ngrams.Trigramm:
                            firstWord = String.Join(" ", new string[2] { sentence[j], sentence[j + 1] });
                            nextWord = sentence[j + 2];
                            break;
                        default:
                            throw new ArgumentException();
                    }
                    resultWithFrequency = GetFrequency(resultWithFrequency, firstWord, nextWord);
                }
            }
            foreach (var pairs in resultWithFrequency)
            {
                var min = 1;
                foreach (var pair in pairs.Value)
                {
                    if (!result.TryGetValue(pairs.Key, out _))
                        result.Add(pairs.Key, pair.Key);
                    // This is more frequent pair - add to result with this key
                    if (pair.Value > min || (pair.Value >= min && string.CompareOrdinal(pair.Key, result[pairs.Key]) < 0))
                    {
                            result[pairs.Key] = pair.Key;
                            min = pair.Value;
                    }
                }
            }

            return result;
        }

        private static Dictionary<string, string> GetNgrams(List<List<string>> text,
             Dictionary<string, string> result,
             Ngrams gramma)
        {
            var resultWithFrequency = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < text.Count; i++)
            {
                var sentence = text[i];
                for (int j = 0; j < sentence.Count - (int)gramma; j++)
                {
                    string firstWord;
                    string nextWord;

                    switch (gramma)
                    {
                        case Ngrams.Bigramm:
                            firstWord = sentence[j];
                            nextWord = sentence[j + 1];
                            break;
                        case Ngrams.Trigramm:
                            firstWord = String.Join(" ", new string[2] { sentence[j], sentence[j + 1] });
                            nextWord = sentence[j + 2];
                            break;
                        default:
                            throw new ArgumentException();
                    }

                    resultWithFrequency = GetFrequency(resultWithFrequency, firstWord, nextWord);

                    if (result.TryGetValue(firstWord, out _)) // theres already such word 
                    {
                        if (string.CompareOrdinal(nextWord, result[firstWord]) < 0 && IsMaxFrequency(resultWithFrequency, firstWord, nextWord)) // -> check what word is less & is strict more frequently than all others
                            result[firstWord] = nextWord;
                    }
                    else // no matching words -> add new pair
                        result.Add(firstWord, nextWord);
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
            if (frequency[word][nextWord] >= maxFreq)
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
    }
}
