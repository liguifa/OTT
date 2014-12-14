using Common.Lib;
using DAL.lib;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class SetItemStandardOperation : Item
    {
        private static List<string> cols=new List<string>()
                {
                    "Item_ProjectID",
                    "Item_ResultMin",
                    "Item_ResultMax",
                    "Item_Score",
                    "Item_Level",
                    "Item_Sex"
                };
        public List<ItemModels> GetItemList()
        {
            DataTable dt = base.Select("Items", "ID>0");
            return DataTableToList.ToItemList(dt);
        }

        public void AddItem(ItemModels item)
        {
            List<string> datas=new List<string>()
            {
                item.Item_ProjectID,
                item.Item_ResultMin,
                item.Item_ResultMax,
                item.Item_Score,
                item.Item_Level,
                item.Item_Sex
            };
            base.Add(cols, datas);
        }
    }
}
