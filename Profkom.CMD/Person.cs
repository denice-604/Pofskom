using Kursach.BL.Model;
using System.Collections.Generic;
using System;
using System.Net;
using Kursach.BL.Controller;

namespace Profkom.CMD
{
    public class Person
    {
        static public bool AddOrganization()
        {
            Console.WriteLine("Enter organization name: ");
            Organization organization = new Organization
            {
                Name = Console.ReadLine()
            };

            WorkWithDB.AddOrganization(ref organization);
            Session.Organizations.Add(organization);
            return true;
        }

        static public bool AddPostProfk()
        {
            Console.WriteLine("Enter Post name: ");
            OrgPost orgPost = new OrgPost
            {
                Name = Console.ReadLine()
            };

            WorkWithDB.AddOrgPost(ref orgPost);
            Session.Posts.Add(orgPost);
            return true;
        }


        static Addres AddAddres()
        {
            Addres addres = new Addres();

            Console.WriteLine("Enter house number: ");
            addres.NumberHouse = Console.ReadLine();

            Console.WriteLine("Enter street: ");
            addres.Street = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            addres.City = Console.ReadLine();

            Console.WriteLine("Etner Region: ");
            addres.Region = Console.ReadLine();

            Console.WriteLine("Enter country: ");
            addres.Country = Console.ReadLine();

            Console.WriteLine("Enter apartment number: ");
            addres.ApartmentNumber = Console.ReadLine();

            Console.WriteLine("Enter postcode: ");
            addres.Postcode = Console.ReadLine();

            return addres;
        }

        static WorkPost AddWpost()
        {
            WorkPost workPost = new WorkPost();
            Console.WriteLine("Enter department: ");
            workPost.Department = Console.ReadLine();

            Console.WriteLine("Enter post: ");
            workPost.Post = Console.ReadLine();

            return workPost;

        }

        static Education AddEducation()
        {
            Education education = new Education();
            Console.WriteLine("Enter educational institution: ");
            education.EducationalInstitution = Console.ReadLine();

            Console.WriteLine("Enter speciality: ");
            education.Speciality = Console.ReadLine();

            Console.WriteLine("Enter end date: ");
            education.EndDate = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter degree");
            education.Degree = Console.ReadLine();

            return education;
        }

        static PersonalFile AddPersonalFile()
        {
            PersonalFile personalFile = new PersonalFile
            {
                NumberPersonalFile = Console.ReadLine()
            };

            return personalFile;
        }

        static Parent AddParent()
        {
            Parent parent = new Parent();

            Console.Write("Enter first name: ");
            parent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter second name: ");
            parent.SecondName = Console.ReadLine();

            Console.WriteLine("Enter third name: ");
            parent.ThirdName = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            parent.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter job title: ");
            parent.JobTitle = Console.ReadLine();
           

            return parent;
        }

        static Children AddChildren()
        {
            Children children = new Children();

            Console.WriteLine("Enter first name: ");
            children.FirstName = Console.ReadLine();

            Console.WriteLine("Enter second name: ");
            children.SecondName = Console.ReadLine();

            Console.WriteLine("Enter therd name: ");
            children.ThirdName = Console.ReadLine();

            Console.WriteLine("Enter birth date: dd/mm/eeee: ");
            children.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone number: ");
            children.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter note: ");
            children.Note = Console.ReadLine();

            return children;
        }

        static Membership AddMembership()
        {
            Membership membership = new Membership();

            Console.WriteLine("Enter date join dd.mm.eeee : ");
            membership.DateJoin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter last payment date: ");
            membership.LastPayment = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Choose organization: ");
            foreach (Organization organization in Session.Organizations)
            {
                Console.WriteLine($"No: {organization.Id}; Name: {organization.Name};");
            }
            Console.WriteLine("Choose No: ");

            int a = int.Parse(Console.ReadLine());

            foreach (Organization organization in Session.Organizations)
            {
                if (organization.Id == a)
                {
                    membership.OrganizationID = organization.Id;
                    break;
                }
            }

            Console.WriteLine("Choose Post: ");
            foreach (OrgPost orgPost in Session.Posts)
            {
                Console.WriteLine($"No: {orgPost.Id}; Name: {orgPost.Name};");
            }
            Console.WriteLine("Choose No: ");

            a = int.Parse(Console.ReadLine());

            foreach (OrgPost orgPost in Session.Posts)
            {
                if (orgPost.Id == a)
                {
                    membership.PostOrgID = orgPost.Id;
                    break;  
                }
            }

            return membership;
        }

        public static bool AddPerson()
        {
            Member member = new Member();

            Console.WriteLine("Enter first name: ");
            member.FirstName = Console.ReadLine();

            Console.WriteLine("Enter second name: ");
            member.SecondName = Console.ReadLine();

            Console.WriteLine("Enter therd name: ");
            member.ThirdName = Console.ReadLine();

            Console.WriteLine("Enter gender: 0/1; 1=M, 0=F");
            if (int.Parse(Console.ReadLine()) == 1)
                member.Gender = true;
            else
                member.Gender = false;

            Console.WriteLine("Enter phone number: ");
            member.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter merital status: 1/0; 1-have wife");
            if (int.Parse(Console.ReadLine()) == 1)
                member.MaritalStatus = true;
            else
                member.MaritalStatus = false;

            Console.WriteLine("Enter birth date dd.mm.eeee: ");
            member.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter registration: ");
            member.DocumetAddress = AddAddres();

            Console.WriteLine("Enter location: ");
            //member.FactAddress = AddAddres();
            member.FactAddress = member.DocumetAddress;

            Console.WriteLine("Enter work post info:");
            member.PostW = AddWpost();

            // TODO: сделать выгрузку фото и конвертирование в массив битов.

            Console.WriteLine("Enter inf about education: ");
            member.Educations = AddEducation();

            Console.WriteLine("Enter email: ");
            member.Email = Console.ReadLine();

            Console.WriteLine("Enter personal file info: ");
            member.PersonalFiles = AddPersonalFile();

            Console.WriteLine("Enter citizenship: ");
            member.Citizenship = Console.ReadLine();
            string ans;
            Console.WriteLine("Add inf about dad? Y/N: ");
            if ( (ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                member.Father = AddParent();
                member.Father.Gender = true;
            }

            Console.WriteLine("Add inf about mom? Y/N: ");
            if ((ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                member.Mother = AddParent();
                member.Mother.Gender = false;
            }

            Console.WriteLine("Add children? Y/N");
            while ((ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                member.Childrens.Add(AddChildren());
                Console.WriteLine("Add children? Y/N");
            }

            Console.WriteLine("Add inf ab memships: ");
            member.Memberships = AddMembership();

            WorkWithDB.AddMember(ref member);

            return true;
        }
    }
}
