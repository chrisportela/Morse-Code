using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code
{
    enum CodeTypes
    {
        American,
        Continential,
        International
    };

    class MorseCode
    {
        Dictionary<char, string> code = new Dictionary<char, string>();

        public MorseCode(CodeTypes type)
        {
            switch (type)
            {
                case CodeTypes.American:
                    LoadAmerican();
                    break;
                case CodeTypes.Continential:
                    LoadContinential();
                    break;
                case CodeTypes.International:
                    LoadInternational();
                    break;
            }
        }

        public void LoadAmerican()
        {
            throw new NotImplementedException();
        }

        public void LoadContinential()
        {
            throw new NotImplementedException();
        }

        public void LoadInternational()
        {
            code.Add('A', ".-");
            code.Add('B', "-...");
            code.Add('C', "-.-.");
            code.Add('D', "-..");
            code.Add('E', ".");
            code.Add('F', "..-.");
            code.Add('G', "--.");
            code.Add('H', "....");
            code.Add('I', "..");
            code.Add('J', ".---");
            code.Add('K', "-.-");
            code.Add('L', ".-..");
            code.Add('M', "--");
            code.Add('N', "-.");
            code.Add('O', "---");
            code.Add('P', ".--.");
            code.Add('Q', "--.-");
            code.Add('R', ".-.");
            code.Add('S', "...");
            code.Add('T', "-");
            code.Add('U', "..-");
            code.Add('V', "...-");
            code.Add('W', ".--");
            code.Add('X', "-..-");
            code.Add('Y', "-.--");
            code.Add('Z', "--..");
            code.Add('1', ".----");
            code.Add('2', "..---");
            code.Add('3', "...--");
            code.Add('4', "....-");
            code.Add('5', ".....");
            code.Add('6', "-....");
            code.Add('7', "--...");
            code.Add('8', "---..");
            code.Add('9', "----.");
            code.Add('0', "-----");
            code.Add(' ', "/");
        }

        public string ConvertToMorseCode(string text)
        {
            char[] t = text.ToArray();
            string morseCode = "";
            for (int i = 0; i < t.Length; i++)
            {
                morseCode += code[t[i]] + " ";
            }
            return morseCode;
        }

        public string ConvertToNormal(string text)
        {
            string[] words = text.Split('/');
            string normal = "";
            foreach (string w in words)
            {
                foreach (string s in w.Split(' '))
                {
                    foreach (KeyValuePair<char, string> pair in code)
                    {
                        if (s == pair.Value)
                            normal += pair.Key;
                    }
                }
                normal += " ";
            }
            return normal;
        }
    }
}
