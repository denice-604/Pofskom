using Kursach.BL.Model;
using Kursach.BL;
using System;


namespace Profkom.CMD
{
    internal class Program
    {
        static void Main(string[] args)


        {
            DateTime ae = new DateTime(2003, 12, 2);

            Member Maksim = new Member(1, "Maksim", "Lonskii", "Huevii", false, "+375228", true, ae, "zaaz", "faaf", "asd", "asdf", "asfa", "asdasfas", "fffff", "dasdasd", "asdasdasf", "asfasffas", "asfasfasd", null, "asdas", "assss", "aas", "asfas");


            // Создать объект контекста
            MemberContext context = new MemberContext();

            // Вставить данные в таблицу Customers с помощью LINQ
            context.Members.Add(Maksim);

            context.SaveChanges();
        }
    }
}
