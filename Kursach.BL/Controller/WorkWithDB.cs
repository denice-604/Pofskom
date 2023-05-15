using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace Kursach.BL.Controller
{
    /// <summary>
    /// Класс для работы с ms сервером.
    /// </summary>
    public class WorkWithDB
    {

        /// <summary>
        /// строка подключения к бд.
        /// </summary>
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Profkom;Trusted_Connection=True;";

        /// <summary>
        /// Создание базы данных с таблицами.
        /// </summary>
        /// <returns></returns>
        private static void CreateDB()
        {
            string connectionString2 = "Server=(localdb)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string createNewDBCommand = "CREATE DATABASE Profkom";
            string useDB = "use Profkom";
            string createTableCommand = "create table Users(\r\nLogin NVarChar(255) primary key,\r\nPassword NVarChar(255),\r\nEmail NVarChar(255),\r\nAccess int,\r\nDepartment NVarChar(255),\r\nPost NVarChar(255),\r\nName NVarChar(255)\r\n)\r\n\r\n\r\ninsert Users(Login, Password, Email, Access, Department, Post, Name)\r\nvalues ('Admin','020604','den.hodkov@gmail.com',0, 'Университет', 'Председатель', 'Денис')\r\n create table Members(\r\nMembersID bigint primary key identity(1,1),\r\nFirstName NVarChar(20),\r\nSecondName NVarChar(20),\r\nTherdName NVarChar(20),\r\nPhoneNumber NVarChar(20),\r\nMerital bit,\r\nBirthDate date,\r\nMail NVarChar(30),\r\nGender char,\r\nCitizenship NVarChar(40),\r\nPhoto  VARBINARY(MAX),\r\n)\r\n\r\ncreate table Father (\r\nFatherID bigint primary key identity(1,1),\r\nFirstName NVarChar(20),\r\nSecondName NVarChar(20),\r\nTherdName NVarChar(20),\r\nPhoneNumber NVarChar(20),\r\nJobTitle NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Mother (\r\nMotherID bigint primary key identity(1,1),\r\nFirstName NVarChar(20),\r\nSecondName NVarChar(20),\r\nTherdName NVarChar(20),\r\nPhoneNumber NVarChar(20),\r\nJobTitle NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Children (\r\nChildID bigint primary key identity(1,1),\r\nFirstName NVarChar(20),\r\nSecondName NVarChar(20),\r\nTherdName NVarChar(20),\r\nPhoneNumber NVarChar(20),\r\nMemberID bigint not null,\r\nBirthDate date,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\n\r\ncreate table PersonalFile (\r\nFileID bigint primary key identity(1,1),\r\nPersonalFileNumber NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Registration (\r\nRegID bigint primary key identity(1,1),\r\nCountry NVarChar(20),\r\nRegion NVarChar(20),\r\nCity NVarChar(20),\r\nStreet NVarChar(20),\r\nHouse NVarChar(20),\r\nApartmentNumber NVarChar(20),\r\nPostcode NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Location (\r\nLocID bigint primary key identity(1,1),\r\nCountry NVarChar(20),\r\nRegion NVarChar(20),\r\nCity NVarChar(20),\r\nStreet NVarChar(20),\r\nHouse NVarChar(20),\r\nApartmentNumber NVarChar(20),\r\nPostcode NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\n\r\ncreate table Post (\r\nPostID bigint primary key identity(1,1),\r\nDepartmentName NVarChar(40),\r\nPost NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Education (\r\nEducID bigint primary key identity(1,1),\r\nEducationalInstitution NVarChar(30),\r\nSpeciality NVarChar(30),\r\nEndDate date,\r\nDegree NVarChar(20),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID)\r\n)\r\n\r\ncreate table Departments (\r\nDepID int primary key identity(1,1),\r\nName NVarChar(20)\r\n)\r\n\r\ncreate table ProfkPost (\r\nPostID int primary key identity(1,1),\r\nName NVarChar(20))\r\n\r\ncreate table Memberships (\r\nMembershipsID bigint primary key identity(1,1),\r\nEntryDate date default getdate(),\r\nDepID int,\r\nPostID int,\r\nDueDate date default getdate(),\r\nMemberID bigint not null,\r\nFOREIGN KEY (MemberID) REFERENCES Members(MembersID),\r\nFOREIGN KEY (DepID) REFERENCES Departments(DepID),\r\nFOREIGN KEY (PostID) REFERENCES ProfkPost(PostID)\r\n)\r\n\r\ncreate table Deserts (\r\nDesID bigint primary key identity(1,1),\r\nTypeDes NVarChar(30),\r\nGetsDate date,\r\nNote NVarChar(40),\r\nMembershipsID bigint not null,\r\nFOREIGN KEY (MembershipsID) REFERENCES Memberships(MembershipsID),\r\n)\r\n\r\ncreate table Penalty (\r\nPenaltyID bigint primary key identity(1,1),\r\nTypeDes NVarChar(30),\r\nGetsDate date,\r\nNote NVarChar(40),\r\nMembershipsID bigint not null,\r\nFOREIGN KEY (MembershipsID) REFERENCES Memberships(MembershipsID),\r\n)";
            SqlCommand command = new SqlCommand(createNewDBCommand, connection);
            command.ExecuteNonQuery();
            command = new SqlCommand(useDB, connection);
            command.ExecuteNonQuery();
            command = new SqlCommand(createTableCommand, connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// проверка существования нужной дб.
        /// </summary>
        /// <returns>Если она существует вернёт true, если она не существует вернёт false.</returns>
        public static bool CheckDB()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Если соединение установлено успешно, то база данных существует
                    return true;
                }
                catch (SqlException)
                {
                    // Если возникла ошибка, значит база данных не существует
                    CreateDB();
                    return false;
                }
            }
        }

  

        public static List<Member> GetFromDBMembers(ref List<Member> members)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Command = "select\r\n    m.MembersID,\r\n    m.FirstName,\r\n    m.SecondName,\r\n    m.TherdName,\r\n    m.PhoneNumber,\r\n    m.Merital,\r\n    m.BirthDate,\r\n    m.Mail,\r\n    m.Gender,\r\n    m.Citizenship,\r\n    m.Photo,\r\n    mom.FirstName as momName,\r\n    mom.SecondName as mom2Name,\r\n    mom.TherdName as mom3Name,\r\n    mom.PhoneNumber as momNumber,\r\n    mom.JobTitle as momJob,\r\n    dad.FirstName as dadName,\r\n    dad.SecondName as dad2Name,\r\n    dad.TherdName as dad3Name,\r\n    dad.PhoneNumber as dadPhone,\r\n    dad.JobTitle as dadJob,\r\n    pf.PersonalFileNumber as FileNumber,\r\n    Post.DepartmentName as DepWork,\r\n    Post.Post as PostWork,\r\n    loc.Country as locCountry,\r\n    loc.Region as locRegion,\r\n    loc.City as locCity,\r\n    loc.Street as locStreet,\r\n    loc.House as locHouse,\r\n    loc.ApartmentNumber as locApNum,\r\n    loc.Postcode as locPostCode,\r\n    reg.Country as regCountry,\r\n    reg.Region as regRegion,\r\n    reg.City as regCity,\r\n    reg.Street as regStreet,\r\n    reg.House as regHouse,\r\n    reg.ApartmentNumber as regApNum,\r\n    reg.Postcode as regPostCode,\r\n    edu.EducationalInstitution as Zavedenie,\r\n    edu.Speciality as spec,\r\n    edu.EndDate as endDateEd,\r\n    edu.Degree as degree,\r\n    memsh.MembershipsID as memshID,\r\n    memsh.EntryDate as etnry,\r\n    memsh.DepID as depID,\r\n    memsh.PostID as postID,\r\n    memsh.DueDate as dueDate\r\nfrom\r\n    Members as m\r\n    left join Location as loc on loc.MemberID = m.MembersID\r\n    left join Registration as reg on reg.MemberID = m.MembersID\r\n    left join Education as edu on edu.MemberID = m.MembersID\r\n    left join Mother as mom on mom.MemberID = m.MembersID\r\n    left join post on post.MemberID = m.MembersID\r\n    left join Father as dad on dad.MemberID = m.MembersID\r\n    left join PersonalFile as pf on pf.MemberID = m.MembersID\r\n    left join Memberships as memsh on memsh.MemberID = m.MembersID";
            using (SqlCommand command = new SqlCommand(Command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Member> membe = new List<Member>();
                    while (reader.Read())
                    {

                        Member mem = new Member();
                        mem.Id = Convert.ToInt32(reader["MembersID"]);
                        mem.FirstName = (string)reader["FirstName"];
                        mem.SecondName = (string)reader["SecondName"];
                        mem.ThirdName = (string)reader["TherdName"];
                        mem.PhoneNumber = (string)reader["PhoneNumber"];
                        //MaritalStatus = bool.Parse((string)reader["Merital"]),
                        mem.BirthDate = (DateTime)reader["BirthDate"];
                        mem.Email = (string)reader["Mail"];
                        //Gender = bool.Parse((string)reader["Gender"]),
                        mem.Citizenship = (string)reader["Citizenship"];
                        mem.Photo = reader["Photo"] != DBNull.Value ? (byte[])reader["Photo"] : null;
                        mem.MaritalStatus = reader["Merital"] != DBNull.Value && Convert.ToBoolean(reader["Merital"]);
                        if (reader["Gender"] != DBNull.Value)
                        {
                            if ((string)reader["Gender"] == "1")
                                mem.Gender = true;
                            else
                                mem.Gender = false;
                        }

                        if (reader["momName"] != DBNull.Value)
                        {
                            mem.Mother.FirstName = (string)reader["momName"];
                            mem.Mother.SecondName = (string)reader["mom2Name"];
                            mem.Mother.ThirdName = (string)reader["mom3Name"];
                            mem.Mother.PhoneNumber = (string)reader["momNumber"];
                            mem.Mother.JobTitle = (string)reader["momJob"];
                        }

                        if (reader["dadName"] != DBNull.Value)
                        {
                            mem.Father.FirstName = (string)reader["dadName"];
                            mem.Father.SecondName = (string)reader["dad2Name"];
                            mem.Father.ThirdName = (string)reader["dad3Name"];
                            mem.Father.PhoneNumber = (string)reader["dadPhone"];
                            mem.Father.JobTitle = (string)reader["dadJob"];
                        }
                        mem.PersonalFiles.NumberPersonalFile = (string)reader["FileNumber"];
                        mem.PostW.Post = (string)reader["PostWork"];
                        mem.PostW.Department = (string)reader["DepWork"];
                        mem.FactAddress.Country = (string)reader["locCountry"];
                        mem.FactAddress.Region = (string)reader["locRegion"];
                        mem.FactAddress.City = (string)reader["locCity"];
                        mem.FactAddress.Street = (string)reader["locStreet"];
                        mem.FactAddress.NumberHouse = (string)reader["locHouse"];
                        mem.FactAddress.ApartmentNumber = (string)reader["locApNum"];
                        mem.FactAddress.Postcode = (string)reader["locPostCode"];
                        mem.DocumetAddress.Country = (string)reader["regCountry"];
                        mem.DocumetAddress.Region = (string)reader["regRegion"];
                        mem.DocumetAddress.City = (string)reader["regCity"];
                        mem.DocumetAddress.Street = (string)reader["regStreet"];
                        mem.DocumetAddress.NumberHouse = (string)reader["regHouse"];
                        mem.DocumetAddress.ApartmentNumber = (string)reader["regApNum"];
                        mem.DocumetAddress.Postcode = (string)reader["regPostCode"];
                        mem.Educations.EducationalInstitution = (string)reader["Zavedenie"];
                        mem.Educations.Speciality = (string)reader["spec"];
                        var year = (DateTime)reader["endDateEd"];
                        mem.Educations.EndDate = (int)year.Year;
                        mem.Educations.Degree = (string)reader["degree"];
                        mem.Memberships.Id = Convert.ToInt32(reader["memshID"]);
                        mem.Memberships.DateJoin = (DateTime)reader["etnry"];
                        mem.Memberships.OrganizationID = (int)reader["depID"];
                        mem.Memberships.PostOrgID = (int)reader["postID"];
                        mem.Memberships.LastPayment = (DateTime)reader["dueDate"];

                        membe.Add(mem);

                    }
                        reader.Close();

                    foreach (var mem in membe)
                    {

                        SqlCommand command2 = new SqlCommand("select \r\n\tFirstName,\r\n\tSecondName,\r\n\tTherdName,\r\n\tPhoneNumber,\r\n\tBirthDate\r\nfrom Children\r\nwhere MemberID = @memID", connection);
                        command2.Parameters.Add("@memID", System.Data.SqlDbType.Int).Value = mem.Id;
                        using (SqlDataReader reader2 = command2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                Children children = new Children
                                {
                                    FirstName = (string)reader["FirstName"],
                                    SecondName = (string)reader["SecondName"],
                                    ThirdName = (string)reader["TherdName"],
                                    PhoneNumber = (string)reader["PhoneNumber"],
                                    BirthDate = (DateTime)reader["BirthDate"]
                                };
                                mem.Childrens.Add(children);
                            }

                            reader2.Close();
                        }
                    }
                    foreach (var mem in membe)
                    {
                        SqlCommand command2 = new SqlCommand("select\r\n\tTypeDes,\r\n\tGetsDate,\r\n\tNote\r\nfrom Deserts\r\nwhere MembershipsID = @memshID", connection);
                        command2.Parameters.Add("@memshID", System.Data.SqlDbType.Int).Value = mem.Memberships.Id;
                        using (SqlDataReader reader2 = command2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                Deserts des = new Deserts
                                {
                                    DesertTypes = (string)reader2["TypeDes"],
                                    Date = (DateTime)reader2["GetsDate"],
                                    Note = (string)reader2["Note"]
                                };
                                mem.Memberships.Deserts.Add(des);
                            }

                            reader2.Close();
                        }
                    }

                    foreach (var mem in membe)
                    {
                        SqlCommand command2 = new SqlCommand("select\r\n\tTypeDes,\r\n\tGetsDate,\r\n\tNote\r\nfrom Penalty\r\nwhere MembershipsID = @memshID", connection);
                        command2.Parameters.Add("@memshID", System.Data.SqlDbType.Int).Value = mem.Memberships.Id;
                        using (SqlDataReader reader2 = command2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                Penalty pen = new Penalty
                                {
                                    DesertTypes = (string)reader2["TypeDes"],
                                    Date = (DateTime)reader2["GetsDate"],
                                    Note = (string)reader2["Note"]
                                };
                                mem.Memberships.Penaltys.Add(pen);
                            }

                            reader2.Close();
                        }
                        members.Add(mem);
                    }
                }
                connection.Close();
            }
            return members;
        }

        public static bool AddMember
            (
            ref Member member
            )
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {


                    SqlCommand command = new SqlCommand("insert into Members (\r\nFirstName,\r\nSecondName,\r\nTherdName,\r\nPhoneNumber,\r\nMerital,\r\nBirthDate,\r\nMail,\r\nGender,\r\nCitizenship)\r\nVALUES (\r\n@1name,\r\n@2name,\r\n@3name,\r\n@phNumber,\r\n@Merital,\r\n@BirthDate,\r\n@Mail,\r\n@Gender,\r\n@Citizenship);\r\nselect SCOPE_IDENTITY();", connection, transaction);
                    command.Parameters.AddWithValue("@1name", member.FirstName);
                    command.Parameters.AddWithValue("@2name", member.SecondName);
                    command.Parameters.AddWithValue("@3name", member.ThirdName);
                    command.Parameters.AddWithValue("@phNumber", member.PhoneNumber);
                    command.Parameters.AddWithValue("@Merital", member.MaritalStatus);
                    command.Parameters.AddWithValue("@BirthDate", member.BirthDate);
                    command.Parameters.AddWithValue("@Mail", member.Email);
                    command.Parameters.AddWithValue("@Gender", member.Gender);
                    command.Parameters.AddWithValue("@Citizenship", member.Citizenship);
                    //command.Parameters.AddWithValue("@Photo", member.Photo);
                    int membersId = Convert.ToInt32(command.ExecuteScalar());

                    if (member.Father != null)
                    {
                        command = new SqlCommand("insert into Father (\r\nFirstName,\r\nSecondName,\r\nTherdName,\r\nPhoneNumber,\r\nJobTitle,\r\nMemberID)\r\nVALUES (\r\n@1name,\r\n@2name,\r\n@3name,\r\n@phNumber,\r\n@JobTitle,\r\n@memID)", connection, transaction);
                        command.Parameters.AddWithValue("@1name", member.Father.FirstName);
                        command.Parameters.AddWithValue("@2name", member.Father.SecondName);
                        command.Parameters.AddWithValue("@3name", member.Father.ThirdName);
                        command.Parameters.AddWithValue("@JobTitle", member.Father.JobTitle);
                        command.Parameters.AddWithValue("@phNumber", member.Father.PhoneNumber);
                        command.Parameters.AddWithValue("@memID", membersId);
                        command.ExecuteNonQuery();
                    }

                    if (member.Mother != null)
                    {
                        command = new SqlCommand("insert into Mother (\r\nFirstName,\r\nSecondName,\r\nTherdName,\r\nPhoneNumber,\r\nJobTitle,\r\nMemberID)\r\nVALUES (\r\n@1name,\r\n@2name,\r\n@3name,\r\n@phNumber,\r\n@JobTitle,\r\n@memID)", connection, transaction);
                        command.Parameters.AddWithValue("@1name", member.Mother.FirstName);
                        command.Parameters.AddWithValue("@2name", member.Mother.SecondName);
                        command.Parameters.AddWithValue("@3name", member.Mother.ThirdName);
                        command.Parameters.AddWithValue("@JobTitle", member.Mother.JobTitle);
                        command.Parameters.AddWithValue("@phNumber", member.Mother.PhoneNumber);
                        command.Parameters.AddWithValue("@memID", membersId);
                        command.ExecuteNonQuery();
                    }

                    command = new SqlCommand("insert into PersonalFile (PersonalFileNumber,MemberID)\r\nvalues (\r\n@pesNum,\r\n@memID)", connection, transaction);
                    command.Parameters.AddWithValue("@pesNum", member.PersonalFiles.NumberPersonalFile);
                    command.Parameters.AddWithValue("@memID", membersId);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("insert into Post (DepartmentName,post,MemberID)\r\nvalues (\r\n@depName,\r\n@Post,\r\n@memID)", connection, transaction);
                    command.Parameters.AddWithValue("@depName", member.PostW.Department);
                    command.Parameters.AddWithValue("@Post", member.PostW.Post);
                    command.Parameters.AddWithValue("@memID", membersId);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("insert into Location (\r\nCountry,\r\nRegion,\r\nCity,\r\nStreet,\r\nHouse,\r\nApartmentNumber,\r\nPostcode,\r\nMemberID)\r\nvalues  (\r\n@Country,\r\n@Region,\r\n@City,\r\n@Street,\r\n@House,\r\n@ApartmentNumber,\r\n@Postcode,\r\n@MemberID)", connection, transaction);
                    command.Parameters.AddWithValue("@Country", member.FactAddress.Country);
                    command.Parameters.AddWithValue("@Region", member.FactAddress.Region);
                    command.Parameters.AddWithValue("@City", member.FactAddress.City);
                    command.Parameters.AddWithValue("@Street", member.FactAddress.Street);
                    command.Parameters.AddWithValue("@House", member.FactAddress.NumberHouse);
                    command.Parameters.AddWithValue("@ApartmentNumber", member.FactAddress.ApartmentNumber);
                    command.Parameters.AddWithValue("@Postcode", member.FactAddress.Postcode);
                    command.Parameters.AddWithValue("@MemberID", membersId);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("insert into Registration (\r\nCountry,\r\nRegion,\r\nCity,\r\nStreet,\r\nHouse,\r\nApartmentNumber,\r\nPostcode,\r\nMemberID)\r\nvalues  (\r\n@Country,\r\n@Region,\r\n@City,\r\n@Street,\r\n@House,\r\n@ApartmentNumber,\r\n@Postcode,\r\n@MemberID)", connection, transaction);
                    command.Parameters.AddWithValue("@Country", member.DocumetAddress.Country);
                    command.Parameters.AddWithValue("@Region", member.DocumetAddress.Region);
                    command.Parameters.AddWithValue("@City", member.DocumetAddress.City);
                    command.Parameters.AddWithValue("@Street", member.DocumetAddress.Street);
                    command.Parameters.AddWithValue("@House", member.DocumetAddress.NumberHouse);
                    command.Parameters.AddWithValue("@ApartmentNumber", member.DocumetAddress.ApartmentNumber);
                    command.Parameters.AddWithValue("@Postcode", member.DocumetAddress.Postcode);
                    command.Parameters.AddWithValue("@MemberID", membersId);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("insert into Education (\r\nEducationalInstitution,\r\nSpeciality,\r\nEndDate,\r\nDegree,\r\nMemberID)\r\nvalues (\r\n@EducationalInstitution,\r\n@Speciality,\r\n@EndDate,\r\n@Degree,\r\n@MemberID\r\n)", connection, transaction);
                    command.Parameters.AddWithValue("@EducationalInstitution", member.Educations.EducationalInstitution);
                    command.Parameters.AddWithValue("@Speciality", member.Educations.Speciality);
                    command.Parameters.AddWithValue("@EndDate", DateTime.ParseExact(member.Educations.EndDate.ToString(),"yyyy",null));
                    command.Parameters.AddWithValue("@Degree", member.Educations.Degree);
                    command.Parameters.AddWithValue("@MemberID", membersId);
                    command.ExecuteNonQuery();

                    if (member.Childrens != null)
                    {
                        foreach (var child in member.Childrens)
                        {
                            command = new SqlCommand("insert into Children (\r\nFirstName,\r\nSecondName,\r\nTherdName,\r\nPhoneNumber,\r\nMemberID,\r\nBirthDate)\r\nvalues (\r\n@FirstName,\r\n@SecondName,\r\n@TherdName,\r\n@PhoneNumber,\r\n@MemberID,\r\n@BirthDate)", connection, transaction);
                            command.Parameters.AddWithValue("@FirstName", child.FirstName);
                            command.Parameters.AddWithValue("@SecondName", child.SecondName);
                            command.Parameters.AddWithValue("@TherdName", child.ThirdName);
                            command.Parameters.AddWithValue("@PhoneNumber", child.PhoneNumber);
                            command.Parameters.AddWithValue("@BirthDate", child.BirthDate);
                            command.Parameters.AddWithValue("@MemberID", membersId);
                            command.ExecuteNonQuery();
                        }
                    }

                    command = new SqlCommand("insert into Memberships (\r\nEntryDate,\r\nDepID,\r\nPostID,\r\nDueDate,\r\nMemberID)\r\nvalues (\r\n@EntryDate,\r\n@DepID,\r\n@PostID,\r\n@DueDate,\r\n@MemberID)\r\nselect SCOPE_IDENTITY();", connection, transaction);
                    command.Parameters.AddWithValue("@EntryDate", member.Memberships.DateJoin);
                    command.Parameters.AddWithValue("@DepID", member.Memberships.OrganizationID);
                    command.Parameters.AddWithValue("@PostID", member.Memberships.PostOrgID);
                    command.Parameters.AddWithValue("@DueDate", member.Memberships.LastPayment);
                    command.Parameters.AddWithValue("@MemberID", membersId);
                    int membershipId = Convert.ToInt32(command.ExecuteScalar());
                    member.Memberships.Id = membershipId;

                    transaction.Commit();

                    return true;
 
                }


            }
        }

        public static void AddOrganization(ref Organization organization)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert into Departments (Name)\r\nvalues (@name)\r\nselect SCOPE_IDENTITY();", connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = organization.Name;
                organization.Id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close(); 
            }
        }

        public static void AddOrgPost(ref OrgPost orgPost)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert into ProfkPost (Name)\r\nvalues (@name)\r\nselect SCOPE_IDENTITY();", connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = orgPost.Name;
                orgPost.Id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }
        }

        public static bool GetFromDBPostProfk(ref List<OrgPost> orgPosts)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Command = "select Name, PostID from ProfkPost;";
            using (SqlCommand command = new SqlCommand(Command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrgPost post = new OrgPost()
                        {
                            Name = (string)reader["Name"],
                            Id = (int)reader["PostID"]
                        };

                        orgPosts.Add(post);
                    }
                    reader.Close();
                }
                connection.Close();
            }

            return true;
        }

        

        public static bool GetFromDBOrganization(ref List<Organization> organizations)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Command = "Select Name, DepID from Departments;";
            using (SqlCommand command = new SqlCommand(Command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Organization org = new Organization
                        {
                            Name = (string)reader["Name"],
                            Id = (int)reader["DepID"]
                        };

                        organizations.Add(org);
                    }
                    reader.Close();
                }
                connection.Close();
            }

            return true;
        }

        public static void AddUser(ref Users user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert Users(Login, Password, Email, Access, Department, Post, Name)\r\nvalues (@login, @password, @email, @access, @dep, @post, @name)", connection);
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = user.Login;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;
                command.Parameters.Add("@access", SqlDbType.Int).Value = user.Access;
                command.Parameters.Add("@dep", SqlDbType.NVarChar).Value = user.Department;
                command.Parameters.Add("@post", SqlDbType.NVarChar).Value = user.Post;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = user.Name;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static bool GetUsersFromDB(ref List<Users> users)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Command = "select * from Users;";
            using (SqlCommand command = new SqlCommand(Command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Users user = new Users
                        {
                            Login = (string)reader["Login"],
                            Password = (string)reader["Password"],
                            Email = (string)reader["Email"],
                            Access = (int)reader["Access"],
                            Name = (string)reader["Name"],
                            Post = (string)reader["Post"],
                            Department = (string)reader["Department"]
                        };

                        users.Add(user);
                    }
                    reader.Close();
                }
                connection.Close();
            }

            return true;
        }

    }

}



