using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTT.Common
{
    public class Uris
    {
        public readonly static Uri Home = new Uri("../Views/HomeView.xaml", UriKind.Relative);
        public readonly static Uri SetItemStandard = new Uri("../Views/SetItemStandardView.xaml", UriKind.Relative);
        public readonly static Uri SetProjectStandard = new Uri("../Views/SetProjectStandardView.xaml", UriKind.Relative);
        public readonly static Uri ComputeGroupResult = new Uri("../Views/ComputeGroupResultView.xaml", UriKind.Relative);
        public readonly static Uri ComputePersonResult = new Uri("../Views/SetPersonResultView.xaml", UriKind.Relative);
    }
}
