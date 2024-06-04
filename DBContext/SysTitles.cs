using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysTitles
    {
        public int Titleorder { get; set; }
        public string Titlename { get; set; }
        public string Titlegender { get; set; }
        public Guid Titleuuid { get; set; }
    }
}
