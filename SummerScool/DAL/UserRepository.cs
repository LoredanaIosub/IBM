using SummerScool.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SummerScool.DAL
{
    public class UserRepository
    {
        private IQueryable<User> user { get; set; } //proprietate care se vede doar in aceasta clasa pt ca este private

        SummerSchoolDbContext dbContext = new SummerSchoolDbContext();

        public UserRepository()
        {
            //SummerSchoolDbContext dbContext = new SummerSchoolDbContext();

            user = dbContext.Users;
        }

        public bool CheckEmailAndPassword(string email, string password)
        {
            return user.Any(x => x.Email == email && x.Password == password); //x este un operator, metoda Any returneaza un bool
        }

        public User GetUserById(Guid Id)
        {
            return user.FirstOrDefault(item => item.Id == Id);
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return user.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public void AddUser(User user)
        {
            //SummerSchoolDbContext dbContext = new SummerSchoolDbContext(); //cream din nou contextul

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public List<User> RetrieveUsers()
        {
            
            return dbContext.Users.ToList();

        }

        public void DeleteUser(Guid Id)
        {
            User userTobeDelete = GetUserById(Id);

            if (userTobeDelete != null)
            {
                dbContext.Users.Remove(userTobeDelete);
                dbContext.SaveChanges();
            }
        }
        
        public void EditUser(User user)//varianta simpla a celei care urmeaza
        {
            dbContext.Entry(user).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Update(User user)
        {
            User userFromDatabase = GetUserById(user.Id);

            userFromDatabase.FirstName = user.FirstName;
            userFromDatabase.LastName = user.LastName;
            userFromDatabase.Email = user.Email;
            userFromDatabase.UserName = user.UserName;
            userFromDatabase.Addreess = user.Addreess;
            userFromDatabase.BirthDate = user.BirthDate;
            userFromDatabase.Password = user.Password;

            this.dbContext.SaveChanges();
        }

        internal void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}