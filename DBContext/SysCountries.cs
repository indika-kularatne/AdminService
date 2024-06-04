using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysCountries
    {
        public string Countrycode { get; set; }
        public string Countrydesc { get; set; }
        public string Currencycode { get; set; }
        public Guid Countryuuid { get; set; }
    }
}
