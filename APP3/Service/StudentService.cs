using APP3.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3.Service
{
    class StudentService
    {
        /// <summary>
        /// Lấy thông tin sinh viên dựa vào mã sinh viên truyền vào
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Thông tin của sinh viên có mã sinh viên truyền vào,
        /// Nếu sinh viên không tồn tại thì trả về NULL</returns>
        public static Student GetStudent(string idStudent)
        {
            var Student = new Student
            {
                Id = idStudent,
                FirstName = "Vũ",
                LastName = "Nguyễn",
                DateOfBirth = new DateTime(2002, 02, 20),
                Gender = GENDER.Male,
                PlaceOfBirth = "Phú Hải",

            };
            return Student;
        }
        /// <summary>
        /// Lấy thông tin sinh viên thông qua file dữ liệu studen.husc
        /// </summary>
        /// <param name="pathData">Đường dẫn của file student.husc</param>
        /// <param name="idStudent">Mã sinh viên cần lấy</param>
        /// <returns>Đối tượng sinh viên có mã tương ứng</returns>
        public static Student GetStudent(string pathData,string idStudent)
        {
            if (File.Exists(pathData))
            {
                var lines = File.ReadAllLines(pathData);
                foreach (var line in lines)
                {
                    //Cấu trúc: MSC#HO#TEN#NGAYSINH#GIOITINH#NOISINH
                    var listItem = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        Id = listItem[0],
                        LastName = listItem[1],
                        FirstName = listItem[2],
                        DateOfBirth = DateTime.ParseExact(listItem[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Gender = listItem[4] == "Female" ? GENDER.Female : (listItem[4] == "Male" ? GENDER.Male : GENDER.Female),
                        PlaceOfBirth = listItem[5]
                    };
                    
                    if (student.Id == idStudent)
                    {
                        return student;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
