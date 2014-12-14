using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Models
{
    public class ProjectModel
    {
        private int _Id;
        public int Id

        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        private int _Project_Id;
        public int Project_Id
        {
            get 
            {
                return _Project_Id;
            }
            set
            {
                _Project_Id = value;
            }
        }

        private string _Project_Expression;
        public string Project_Expression
        {
            get
            {
                return _Project_Expression;
            }
            set
            {
                _Project_Expression = value;
            }
        }

        private string _Project_Name;
        public string Project_Name
        {
            get
            {
                return _Project_Name;
            }
            set
            {
                _Project_Name = value;
            }
        }

        private string _Project_Sex;
        public string Project_Sex
        {
            get
            {
                return _Project_Sex;
            }
            set
            {
                _Project_Sex = value;
            }
        }
    }
}
