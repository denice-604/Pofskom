using Kursach.BL.Controller;
using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace profkom.WEB.Pages
{
    public class ShowMembersModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public List<Member> members;

        public void OnGet()
        {
            members = Session.Members;
        }


        public string DepartmentOnID(int id)
        {
            Organization? department = Session.Organizations.FirstOrDefault(o => o.Id == id);
            if (department == null)
            {
                return "не найдено";
            }

            return department.Name;
        }

        public IActionResult OnPost(string action)
        {


            if (action == "namep")
            {
                members = Session.Members.OrderBy(m => m.FirstName).ToList();
            }
            else if (action == "date")
            {
                members = Session.Members.OrderBy(m => m.Memberships.DateJoin).ToList();
            }
            else if (action == "Name")
            {
                members = Session.Members.Where(m => m.FirstName == Name).ToList();
            }



            if (action == "action")
            {
                // Создание нового пакета Excel
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    // Создание нового листа Excel
                    var worksheet = package.Workbook.Worksheets.Add("Отчет");

                    // Заголовки столбцов
                    worksheet.Cells[1, 1].Value = "Имя";
                    worksheet.Cells[1, 2].Value = "Должность";
                    worksheet.Cells[1, 3].Value = "Цеховая орг.";
                    worksheet.Cells[1, 4].Value = "Дата вступления";
                    members = Session.Members;
                    // Заполнение данных из модели
                    if (members != null)
                    {
                        int row = 2;
                        foreach (var member in members.ToList())
                        {
                            worksheet.Cells[row, 1].Value = $"{member.FirstName} {member.SecondName} {member.ThirdName}";
                            worksheet.Cells[row, 2].Value = member.PostW.Post;
                            worksheet.Cells[row, 3].Value = DepartmentOnID(member.Memberships.OrganizationID);
                            worksheet.Cells[row, 4].Value = member.Memberships.DateJoin.ToShortDateString();
                            row++;
                        }
                    }

                    // Настройка стилей ячеек
                    using (var range = worksheet.Cells[1, 1, 1, 4])
                    {
                        range.Style.Font.Bold = true;
                    }

                    // Автонастройка ширины столбцов
                    worksheet.Cells.AutoFitColumns();

                    // Преобразование пакета Excel в байтовый массив
                    byte[] fileContents = package.GetAsByteArray();

                    string filePath = "D:\\otchet.xlsx";
                    System.IO.File.WriteAllBytes(filePath, fileContents);

                    // Возврат файла Excel в качестве отклика
                    return PhysicalFile(filePath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "otchet.xlsx");
                }



            }

            return Page();
        }
    }
}



    


