using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
   public interface IGamerService
   {

       public void Add(Gamer gamer);

       public void Update(Gamer gamer);

       public void Deleted(Gamer gamer);

    }
}
