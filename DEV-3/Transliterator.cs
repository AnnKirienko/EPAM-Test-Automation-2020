using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DEV_3
{
    // class Transliterator to make transliteration between russian and english strings
    public class Transliterator
    {
        Dictionary<string, string> ruEnMapping;
        Dictionary<string, string> enRuMappingSingle;
        Dictionary<string, string> enRuMappingMultiple;

        Regex validStringRegex = new Regex(@"^[\p{L}\s]+$");
        Regex containsRussianLettersRegex = new Regex(@"[а-яА-Я]+");
        Regex containsEnglishLettersRegex = new Regex(@"[a-zA-Z]+");
        public Transliterator()
        {
            ruEnMapping = new Dictionary<string, string>()
            {
                {"а", "a"},
                {"б", "b"},
                {"в", "v"},
                {"г", "g"},
                {"д", "d"},
                {"е", "ye"},
                {"ё", "yo"},
                {"ж", "zh"},
                {"з", "z"},
                {"и", "i"},
                {"й", "yi"},
                {"к", "k"},
                {"л", "l"},
                {"м", "m"},
                {"н", "n"},
                {"о", "o"},
                {"п", "p"},
                {"р", "r"},
                {"с", "s"},
                {"т", "t"},
                {"у", "u"},
                {"ф", "f"},
                {"х", "kh"},
                {"ц", "ts"},
                {"ч", "ch"},
                {"ш", "sh"},
                {"щ", "sch"},
                {"ъ", ""},
                {"ы", "y"},
                {"ь", ""},
                {"э", "e"},
                {"ю", "yu"},
                {"я", "ya"}
            };

            enRuMappingSingle = new Dictionary<string, string>()
            {
                {"a", "а"},
                {"b", "б"},
                {"v", "в"},
                {"g", "г"},
                {"d", "д"},
                {"z", "з"},
                {"i", "и"},
                {"k", "к"},
                {"l", "л"},
                {"m", "м"},
                {"n", "н"},
                {"o", "о"},
                {"p", "п"},
                {"r", "р"},
                {"s", "c"},
                {"t", "т"},
                {"u", "у"},
                {"f", "ф"},
                {"y", "ы"},
                {"e", "э"}
            };

            enRuMappingMultiple = new Dictionary<string, string>()
            {   {"sch", "щ"},
                {"ye", "е"},
                {"yo", "ё"},
                {"yi", "й"},
                {"zh", "ж"},
                {"kh", "x"},
                {"ts", "ц"},
                {"ch", "ч"},
                {"sh", "ш"},
                {"yu", "ю"},
                {"ya", "я"}
            };
        }

        private string TransliterateRuEng(string str)
        {
            string result = string.Copy(str).ToLower();

            return ReplaceAllKeys(result, ruEnMapping);
        }

        private string TransliterateEngRu(string str)
        {
            string result = string.Copy(str).ToLower();

            result = ReplaceAllKeys(result, enRuMappingMultiple);
            result = ReplaceAllKeys(result, enRuMappingSingle);

            return result;
        }

        // transliterates received string. only accepts letters and whitespaces 
        public string Transliterate(string str)
        {
            if (!IsValidString(str))
            {
                throw new ArgumentException($"String [{str}] is invalid");
            }

            return IsEnglishAlphabetLetter(str[0])
                     ? TransliterateEngRu(str)
                     : TransliterateRuEng(str);
        }

        private string ReplaceAllKeys(string str, Dictionary<string, string> mapping)
        {
            foreach (var item in mapping)
            {
                str = str.Replace(item.Key, item.Value);
            }

            return str;
        }

        private bool IsEnglishAlphabetLetter(char c)
        {
            c = char.ToLower(c);
            return c >= 'a' && c <= 'z';
        }

        private bool ContainsRussianAndEnglishCharacters(string str)
        {
            return containsRussianLettersRegex.IsMatch(str) && containsEnglishLettersRegex.IsMatch(str);
        }

        private bool IsValidString(string str)
        {
            return !ContainsRussianAndEnglishCharacters(str) && validStringRegex.IsMatch(str);
        }
        
    }
}
