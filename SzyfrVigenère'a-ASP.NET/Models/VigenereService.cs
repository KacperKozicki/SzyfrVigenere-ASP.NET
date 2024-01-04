using System.Text;

namespace SzyfrVigenère_a_ASP.NET.Models
{
    public class VigenereService
    {
        private const string Alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

        public string Encrypt(string text, string key)
        {
            return Vigenere(text, key, true);
        }

        public string Decrypt(string text, string key)
        {
            return Vigenere(text, key, false);
        }

        private string Vigenere(string text, string key, bool encrypting)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0, j = 0; i < text.Length; i++)
            {
                char c = text[i];
                int textIndex = Alphabet.IndexOf(char.ToLower(c));
                if (textIndex != -1)
                {
                    int keyIndex = Alphabet.IndexOf(key[j % key.Length]);
                    int shiftIndex;

                    if (encrypting)
                    {
                        shiftIndex = (textIndex + keyIndex) % Alphabet.Length;
                    }
                    else
                    {
                        shiftIndex = (textIndex - keyIndex + Alphabet.Length) % Alphabet.Length;
                    }

                    result.Append(Alphabet[shiftIndex]);
                    j++;
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }



    }
}
