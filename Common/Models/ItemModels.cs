using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Models
{
    public class ItemModels
    {
        private long _Item_Id;
        public long Item_Id
        {
            get
            {
                return _Item_Id;
            }
            set
            {
                if (value != _Item_Id)
                {
                    _Item_Id = value;
                }
            }
        }

        private string _Item_ProjectID;
        public string Item_ProjectID 
        {
            get
            {
                return _Item_ProjectID;
            }
            set
            {
                if (value != _Item_ProjectID)
                {
                    _Item_ProjectID = value;
                }
            }
        }

        private string _Item_ResultMin;
        public string Item_ResultMin 
        {
            get 
            {
                return _Item_ResultMin;
            }
            set
            {
                if (value != _Item_ResultMin)
                {
                    _Item_ResultMin = value;
                }
            }
        }

        private string _Item_ResultMax;
        public string Item_ResultMax
        {
            get
            {
                return _Item_ResultMax;
            }
            set
            {
                if (value != _Item_ResultMax)
                {
                    _Item_ResultMax = value;
                }
            }
        }

        private string _Item_Score;
        public string Item_Score 
        {
            get
            {
                return _Item_Score;
            }
            set
            {
                if (value != _Item_Score)
                {
                    _Item_Score = value;
                }
            }
        }

        private string _Item_Level;
        public string Item_Level
        {
            get
            {
                return _Item_Level;
            }
            set
            {
                if (value != _Item_Level)
                {
                    _Item_Level = value;
                }
            }
        }

        private string _Item_Sex;
        public string Item_Sex
        {
            get
            {
                return _Item_Sex;
            }
            set
            {
                if (value != _Item_Sex)
                {
                    _Item_Sex = value;
                }
            }
        }
    }
}
