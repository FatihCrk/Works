using System;
using System.Collections.Generic;
using System.Text;
using GameWork.Abstract;
using Microsoft.VisualBasic;

namespace GameWork
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1990 && gamer.FirstName == "Fatih" && gamer.Lastname == "ÇIRAK" && gamer.IdentityNumber == "1234567890")
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
