using System.Collections.Generic;
using System;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        private static char[] SplitSymbols = new char[7] { '.', '!', '?', ';', ':', '(', ')' };
        public static List<List<string>> ParseSentences(string text)
        {
            var sentenceIndex = 0;
            var wordIndex = -1;

            var sentencesList = new List<List<string>>();

            bool nextWord = true;

            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol) || symbol.Equals('\''))
                {
                    if (sentencesList.Count == 0)
                        sentencesList.Add(new List<string>());

                    if (nextWord)
                    {                        
                        sentencesList[sentenceIndex].Add("");
                        nextWord = false;
                        wordIndex++;
                    }
                    sentencesList[sentenceIndex][wordIndex] += symbol.ToString().ToLower(); //add a symbol to curr sentence to curr word
                }
                else
                {
                    foreach (var splitSymbol in SplitSymbols)
                    {
                        if (symbol.Equals(splitSymbol) &&
                            sentencesList.Count != 0 &&
                            sentencesList[sentenceIndex].Count != 0 )
                        {
                            wordIndex = -1;
                            sentencesList.Add(new List<string>());
                            sentenceIndex++;
                            break;
                        }
                    }
                    nextWord = true;
                }
            }

            return sentencesList;
        }
    }
}