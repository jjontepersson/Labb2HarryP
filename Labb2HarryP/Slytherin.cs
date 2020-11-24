using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2HarryP
{
    class Slytherin : House
    {
        public Slytherin()
        {
            Name = "Slytherin";
            HouseGhost = "the Bloody Baron";
            Mascot = "The Serpent";
            Password = "Len ensam trollkarl";
        }
        public override bool LetterCount(string passwordChange)
        {
            int count = 0;
            bool rightLenghtSlyt = true;

            foreach (char letter in passwordChange)
            {
                count++;
            }
            if (count >= 8)
            {
                rightLenghtSlyt = true;
            }
            else
            {
                rightLenghtSlyt = false;
            }
            return rightLenghtSlyt;
        }
        public override bool CheckPassword(string Passwordchange)
        {
            char LastChar = Passwordchange[Passwordchange.Length - 1];
            bool CorrectPassword = true;

            if (IsConsonant(Passwordchange[0]) == true && LetterCount(Passwordchange) == true && IsConsonant(LastChar) == true)
            {
                CorrectPassword = true;
            }
            else
            {
                CorrectPassword = false;
            }
            return CorrectPassword;
        }
    }
}
