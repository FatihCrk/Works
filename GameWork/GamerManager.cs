using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    class GamerManager:IGamerService
    {
        private IUserValidationService _userValidationService; //constructor bloğu

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }


        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate( gamer))
            {
                Console.WriteLine(gamer.FirstName + " İsimli Oyuncu Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Yapılamadı.");
            }
        }

        public void Update(Gamer gamer)
        {
            
            
                Console.WriteLine(gamer.FirstName + " İsimli Oyuncunun Kaydı Güncellendi.");
            
          
        }

        public void Deleted(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " İsimli Oyuncunun Kaydı Silindi.");
        }
    }
}
