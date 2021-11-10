using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class Morse
    {
        private const string Taah = "===";
        private const string Ti = "=";
        private const string Point = ".";
        private const string PointLetter = "...";
        private const string PointWord = ".....";

        private readonly Dictionary<string, char> _alphabet;

        public Morse()
        {
            _alphabet = new Dictionary<string, char>()
            {
                {$"{Ti}.{Taah}", 'A'},
                {$"{Taah}.{Ti}.{Ti}.{Ti}", 'B'},
                {$"{Taah}.{Ti}.{Taah}.{Ti}", 'C'},
                {$"{Taah}.{Ti}.{Ti}", 'D'},
                {$"{Ti}", 'E'},
                {$"{Ti}.{Ti}.{Taah}.{Ti}", 'F'},
                {$"{Taah}.{Taah}.{Ti}", 'G'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}", 'H'},
                {$"{Ti}.{Ti}", 'I'},
                {$"{Ti}.{Taah}.{Taah}.{Taah}", 'J'},
                {$"{Taah}.{Ti}.{Taah}", 'K'},//
                {$"{Ti}.{Taah}.{Ti}.{Ti}", 'L'},
                {$"{Taah}.{Taah}", 'M'},
                {$"{Taah}.{Ti}", 'N'},
                {$"{Taah}.{Taah}.{Taah}", 'O'},
                {$"{Ti}.{Taah}.{Taah}.{Ti}", 'P'},
                {$"{Taah}.{Taah}.{Ti}.{Taah}", 'Q'},
                {$"{Ti}.{Taah}.{Ti}", 'R'},
                {$"{Ti}.{Ti}.{Ti}", 'S'},
                {$"{Taah}", 'T'},
                {$"{Ti}.{Ti}.{Taah}", 'U'},
                {$"{Ti}.{Ti}.{Ti}.{Taah}", 'V'},
                {$"{Ti}.{Taah}.{Taah}", 'W'},
                {$"{Taah}.{Ti}.{Ti}.{Taah}", 'X'},
                {$"{Taah}.{Ti}.{Taah}.{Taah}", 'Y'},
                {$"{Ti}.{Taah}.{Taah}.{Taah}.{Taah}", '1'},
                {$"{Ti}.{Ti}.{Taah}.{Taah}.{Taah}", '2'},
                {$"{Ti}.{Ti}.{Ti}.{Taah}.{Taah}", '3'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}.{Taah}", '4'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}.{Ti}", '5'},
                {$"{Taah}.{Ti}.{Ti}.{Ti}.{Ti}", '6'},
                {$"{Taah}.{Taah}.{Ti}.{Ti}.{Ti}", '7'},
                {$"{Taah}.{Taah}.{Taah}.{Ti}.{Ti}", '8'},
                {$"{Taah}.{Taah}.{Taah}.{Taah}.{Ti}", '9'},
                {$"{Taah}.{Taah}.{Taah}.{Taah}.{Taah}", '0'},
            };
        }

        public int LettersCount(string code)
        {
            return code.Split(new string[] { PointLetter }, StringSplitOptions.RemoveEmptyEntries).Length;

        }

        public int WordsCount(string code)
        {
            return code.Split(new string[] { PointWord }, StringSplitOptions.RemoveEmptyEntries).Length;

        }

        public string MorseTranslation(string code)
        {
            string translation = "";

            //foreach split mot split lettre 
            string[] mots = code.Split(new string[] { PointWord }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var mot in mots)
            {
                string[] lettres = mot.Split(new string[] { PointLetter }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var lettre in lettres)
                {
                    translation += GetChar(lettre);
                }
                //translation = translation + " ";
                translation += " ";
            }

            //Console.WriteLine($"Mot: {translation}");
            return translation;
        }

        public string EfficientMorseTranslation(string code)
        {
            code = code.Trim('.');
            StringBuilder sb = new StringBuilder();
            int pointCount = 0;
            int startIndex = 0;
            int charLenght = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '.')
                {
                    pointCount++;
                    Console.WriteLine(pointCount);
                }
                else
                {
                    if (pointCount > 2)
                    {
                        string sub = code.Substring(startIndex, charLenght - pointCount).Replace("..", ".");
                        Console.WriteLine(sub);
                        sb.Append(GetChar(sub));
                        startIndex = i;
                        charLenght = 0;
                    }
                    if (pointCount > 4)
                    {
                        sb.Append(" ");
                    }
                    pointCount = 0;
                }
                charLenght++;
                Console.WriteLine(code[i]);
            }
            sb.Append(GetChar(code.Substring(startIndex, charLenght).Replace("..", ".")));

            return sb.ToString();
        }

        private char GetChar(string lettre)
        {
            if (_alphabet.ContainsKey(lettre))
            {
                return _alphabet[lettre];
            }
            return '+';
        }
        public string MorseEncryption(string sentence)
        {
            string code = "";
            foreach (char letter in sentence.ToUpper())
            {
                if (letter == ' ')
                    code += "..";
                var res = _alphabet.FirstOrDefault(x => x.Value == letter);
                if (!string.IsNullOrEmpty(res.Key))
                    code += res.Key + "...";
            }
            return code.Trim('.');
        }
    }
}

