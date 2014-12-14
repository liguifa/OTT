using Common.Lib;
using Common.Models;
using DAL.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ProjectOperation : Project
    {
        public List<ProjectModel> GetProject()
        {
            DataTable dt = base.Select();
            return DataTableToList.ToProjectList(dt);
        }
    }
}
