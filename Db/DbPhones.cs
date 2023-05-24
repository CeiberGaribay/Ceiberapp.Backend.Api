using Ceiberapp.Backend.Api.Models;

namespace Ceiberapp.Backend.Api.Db
{
    public class DbPhones
    {
        public static List<Phone> Phones = new List<Phone>
        {
            new Phone{ Brand = "Samsung", Model="S9", Number="+5151962268858"}
        };
        public static void Add(Phone phone)
        {
            Phones.Add(phone);
        }
        public static void Update(Phone phone)
        {
            var phoneToUpdate = Phones.FirstOrDefault(x=>x.Id == phone.Id);
            if(phoneToUpdate == null)
               throw new Exception("Not Found");

            phoneToUpdate.Brand = phone.Brand;
            phoneToUpdate.Model = phone.Model;
            phoneToUpdate.Number = phone.Number;
            
        }
        public static void Delete(int id)
        {
            var phoneToDelete = Phones.FirstOrDefault(x => x.Id == id);
            if (phoneToDelete == null)
                throw new Exception("Not Found");

            Phones.Remove(phoneToDelete);
        }
        public static Phone Get(int id)
        {
            var phone = Phones.FirstOrDefault(x => x.Id == id);
            if (phone == null)
                throw new Exception("Not Found");
            return phone;
        }
        public static List<Phone> List()
        {
            return Phones;
        }
    }
}
