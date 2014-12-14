using Common.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Common.Lib
{
    public class DataTableToList
    {
        public static List<ItemModels> ToItemList(DataTable dt)
        {
            List<ItemModels> items = new List<ItemModels>();
            foreach (DataRow dr in dt.Rows)
            {
                ItemModels item = new ItemModels()
                {
                    Item_Id = Convert.ToInt64(dr[0]),
                    Item_ProjectID = dr[1].ToString(),
                    Item_ResultMin = dr[2].ToString(),
                    Item_ResultMax = dr[3].ToString(),
                    Item_Score = dr[4].ToString(),
                    Item_Level = dr[5].ToString(),
                    Item_Sex = Convert.ToInt32(dr[6]) == 0 ? "女" : "男"
                };
                items.Add(item);
            }
            return items;
        }

        public static List<ProjectModel> ToProjectList(DataTable dt)
        {
            List<ProjectModel> items = new List<ProjectModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ProjectModel item = new ProjectModel()
                {
                    Id = Convert.ToInt32(dr[0]),
                    Project_Id = Convert.ToInt32(dr[1]),
                    Project_Name = dr[2].ToString(),
                    Project_Expression = dr[3].ToString(),
                    Project_Sex = dr[4].ToString(),
                };
                items.Add(item);
            }
            return items;
        }
    }
}
