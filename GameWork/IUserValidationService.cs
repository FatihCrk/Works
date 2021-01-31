using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    interface IUserValidationService
    {
        public bool Validate(Gamer gamer);
    }
}
