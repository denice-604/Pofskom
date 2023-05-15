using Kursach.BL.Model;


namespace Kursach.BL.Controller.Add
{
    public class AddUser
    {
        public static bool Add(Users users)
        {
            WorkWithDB.AddUser(ref users);

            Session.Users.Add(users);

            return true;
        }
    }
}
