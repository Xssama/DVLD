using DVLD_BUSINESS;
using DVLD_DataAccess;
using System.Data;
public static class Program
{
    static void TestAddNewUser()
    {
        clsUser user = new clsUser();
        user.UserName = "Xussama";
        user.Password = "Xussama1234";
        user.PersonID = 1036;
        user.isActive = true;

        if (user.Save())
        {
            Console.WriteLine("the User is added successfully with id =>" + user.UserID.ToString());
        }

        user.Password = "Xussama123456";
        if (user.Save())
        {
            Console.WriteLine("the User with id => " + user.PersonID.ToString() + " is Updated successfully ");

        }
        
    }

    static void isExist()
    {
        if (clsUser.IsExist(1))
        {
            Console.WriteLine("The person with id 1025 is Found");
        }
    }

    static void TEstFindUser()
    {
        clsUser user = clsUser.Find(1);
        Console.WriteLine(user.UserID);
        Console.WriteLine(user.UserName);
        Console.WriteLine(user.Password);
        Console.WriteLine(user.PersonID);
        Console.WriteLine(user.isActive);
        



    }

    static void PrintUsers()
    {
        DataTable dt = clsUser.GetList();
        foreach(DataRow row in dt.Rows)
        {
            Console.WriteLine($"userID => {row["UserID"]}");
            Console.WriteLine($"Username => {row["UserName"]}");
            Console.WriteLine($"password => {row["Password"]}");
            Console.WriteLine($"PersonID => {row["PersonID"]}");
            Console.WriteLine($"IS Active => {row["IsActive"]}");
            Console.WriteLine();
        }
    }
    static void Main()
    {
        if (clsUser.DeleteUser(17))
        {
            Console.WriteLine("The User is Deleted Successfully from the data base");
        }
        //PrintUsers();
        //TestAddNewUser();
        //isExist();
        //TEstFindUser();
        //isExist();
        //TEstFindPerson();
        //TestAddNewPerson();
        //Application.Run(new Form1());
    }
}
