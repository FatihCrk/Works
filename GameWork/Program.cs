using System;
using GameWork.Abstract;

namespace GameWork
{
    class Program
    {
        static void Main(string[] args)
        {
           GamerManager gamerManager = new GamerManager( new UserValidationManager());
           
           gamerManager.Add(new Gamer{Id = 1, BirthYear = 1990, FirstName = "Fatih", Lastname = "ÇIRAK", IdentityNumber = "1234567890"});


           gamerManager.Update(new Gamer());
        }
    }
}
