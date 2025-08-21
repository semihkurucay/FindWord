using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeBulma
{
    internal class GameManeger
    {
        private string _keyword = "";
        private byte _heart = 3;
        private byte _allWrittenWords = 0;
        private string[] _newWord;
        private ArrayList _listWordsFound;
        private Random _random;
        private KeywordList keywords;

        public GameManeger()
        {
            _listWordsFound = new ArrayList();
            _random = new Random();
            keywords = new KeywordList();
        }

        public void startGame()
        {
            setHeart(3);
            addRandomKeyword();
            foundListRemoveAll();
            _newWord = new string[_keyword.Length];
        }

        private void addRandomKeyword()
        {
            _keyword = keywords.getKeyword(_random.Next(0, keywords.getKeywordCount()));
        }

        public string censeredKeyword()
        {
            string censor = "";

            for (int i = 0; i < _newWord.Length; i++)
            {
                _newWord[i] = "* ";
                censor += _newWord[i];
            }

            return censor;
        }

        public string getKeywords()
        {
            return _keyword;
        }

        public byte getHeart()
        {
            return _heart;
        }

        private void setHeart(byte heart)
        {
            _heart = heart;
        }

        public byte decreaseHeart()
        {
            return --_heart;
        }

        public int getDbKeywordsList()
        {
            return keywords.getKeywordCount();
        }

        public void foundListAdd(string word)
        {
            _listWordsFound.Add(word);
        }

        public void foundListRemoveAll()
        {
            _listWordsFound.Clear();
        }

        public void findWords(string word)
        {
            for (int i = 0; i < _keyword.Length; i++)
            {
                if (_keyword.IndexOf(Char.Parse(word)) >= 0)
                {
                    foundListAdd(word);
                }
            }
        }

        public string addFoundKeyword()
        {
            char[] word = _keyword.ToCharArray();
            censeredKeyword();

            for (int i = 0; i < word.Length; i++)
            {
                foreach (string foundWords in _listWordsFound)
                {
                    if (word[i].ToString().Equals(foundWords))
                    {
                        _newWord[i] = foundWords.ToString();
                    }
                }
            }

            return arrayToString(_newWord);
        }

        private string arrayToString(string[] array)
        {
            string newWord = "";

            for (int i = 0; i < array.Length; i++)
            {
                newWord += array[i].ToString();
            }
            return newWord;
        }

        public bool isItWordInGuess(string word)
        {
            if (word.Equals(_keyword))
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
