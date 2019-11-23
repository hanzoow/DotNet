﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP3.Model;
namespace APP3.Service
{
    class LearningHistoryService
    {
        /// <summary>
        /// Lấy danh sách học tập của 1 sinh viên
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<LearningHistory> GetList(string idStudent)
        {
            List<LearningHistory> rs = new List<LearningHistory>();
            for (int i = 1; i <= 12; i++)
            {
                LearningHistory learning = new LearningHistory
                {
                    Id = i.ToString(),
                    FromYear = 2007 + i,
                    ToYear = 2008 + i,
                    IdStudent = idStudent
                };
                if (i <= 5)
                    learning.Address = "Tiểu học Phan Bội Châu";
                else if (i <= 9)
                    learning.Address = "Trung học Phan Đăng Lưu";
                else
                    learning.Address = "Phổ Thông Quốc học";
                rs.Add(learning);
            }
            return rs;
        }
        public static List<LearningHistory> GetList(string path,string idStudent)
        {
            List<LearningHistory> rs = new List<LearningHistory>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var listItem = line.Split(new char[] { '#' });
                    LearningHistory learning = new LearningHistory
                    {
                        Id = listItem[0],
                        FromYear = Int32.Parse(listItem[1]),
                        ToYear = Int32.Parse(listItem[2]),
                        Address = listItem[3],
                        IdStudent = idStudent
                    };
                    rs.Add(learning);

                }
                return rs;
            }

            else
            {
                return null;
            }
        }

        public static List<LearningHistory> GetListFromFile(string path,string idStudent)
        {
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                List<LearningHistory> rs = new List<LearningHistory>();
                foreach(var line in lines)
                {
                    var items = line.Split(new char[] { '#' });
                    LearningHistory history = new LearningHistory
                    {
                        Id = items[0],
                        FromYear = int.Parse(items[1]),
                        ToYear = int.Parse(items[2]),
                        Address = items[3],
                        IdStudent = items[4]
                    };
                    if(history.IdStudent == idStudent)
                    {
                        rs.Add(history);
                    }
                }
                return rs;
            }
            else
            {
                return null;
            }
        }
        
    }
}