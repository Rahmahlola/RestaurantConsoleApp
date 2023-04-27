using System.Collections.Generic;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Implementations
{
    public class RiderManager : IRiderManager
    {
        public static List<Rider> riderDatabase = new List<Rider>()
        {
            new Rider(1,"Mr Felix","felix34@gmail.com","7654","Rider","0907765432","Rider"),
            new Rider(2,"Mr ola","ola@gmail.com","2453","Rider","0807165432","Rider"),
            new Rider(3,"Mr Lekan","lecan4@gmail.com","1114","Rider","0902003432","Rider"),
            new Rider(4,"Ms chichi","chichi@gmail.com","9999","Rider","0703457289","Rider"),
        };
        public Rider Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Rider Get(int id)
        {
            foreach (var rider in riderDatabase)
            {
                if(rider.Id == id)
                {
                    return rider;
                }
            }
            return null;
        }

        public List<Rider> GetAll()
        {
            return riderDatabase;
        }

        public Rider Login(string email, string pin)
        {
            foreach (var rider in riderDatabase)
            {
                if(rider.Email == email && rider.Pin == pin)
                {
                    return rider;
                }
            }
            return null;
        }

        public Rider Register(string name, string pin, string email, string phoneNumber)
        {
            int id = riderDatabase.Count + 1;
            Rider rider = new Rider(id,name,email,pin,"Rider",phoneNumber,"Rider");
            riderDatabase.Add(rider);
            return rider;
            
        }

        public Rider Update(string name, string pin, string email, string phoneNumber)
        {
            throw new System.NotImplementedException();
        }
        private Rider CheckIfExist(int id)
        {
            foreach (var rider in riderDatabase)
            {
                if(rider.Id == id)
                {
                    return rider;
                }
            }
            return null;
        }
    }
}