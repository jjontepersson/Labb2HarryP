using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2HarryP
{
    abstract class House
    {
        public string Name;
        public string HouseGhost;
        public string Mascot;
        public string Password;
        public List<Wizard> members;

        public virtual bool LetterCount(string passwordChange)
        {
            int count = 0;
            bool rightLenght = true;

            foreach (char letter in passwordChange)
            {
                count++;
            }
            if (count >= 5)
            {
                rightLenght = true;
            }
            else
            {
                rightLenght = false;
            }
            return rightLenght;
        }
        public bool IsVowel(char character)
        {
            string allVowels = "aeiouyåäöAEIOUYÅÄÖ";
            bool isVowel = false;

            foreach (char vowel in allVowels)
            {
                if (vowel == character)
                {
                    isVowel = true;

                    break;
                }
            }
            return isVowel;
        }

        public bool IsConsonant(char character)
        {
            string allConsonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            bool isConsonant = false;

            foreach (char consonant in allConsonants)
            {
                if (consonant == character)
                {
                    isConsonant = true;

                    break;
                }
            }
            return isConsonant;
        }
        public virtual bool CheckPassword (string Passwordchange)
        {
            char LastChar = Passwordchange[Passwordchange.Length - 1];
            bool CorrectPassword = true;

            if (IsVowel(Passwordchange[0]) == true && LetterCount(Passwordchange) == true && IsConsonant(LastChar) == true)
            {
                CorrectPassword = true;
            }
            else
            {
                CorrectPassword = false;
            }
            return CorrectPassword;
        }
        public bool SetPassword (string oldPassword, string newPassword)
        {
            bool ChangedPassword = true;
            if (oldPassword == Password && CheckPassword(newPassword) == true)
            {
                Password = newPassword;
                ChangedPassword = true;
            }
            else
            {
                ChangedPassword = false;
            }
            return ChangedPassword;
        }

    }

}
