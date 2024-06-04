using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditGetquote
    {
        public int? Directioncount { get; set; }
        public int? Tripdurationdays { get; set; }
        public string Departureairportcode { get; set; }
        public string Departurecountrycode { get; set; }
        public string Arrivalairportcode { get; set; }
        public string Arrivalcountrycode { get; set; }
        public string Carriercode { get; set; }
        public string Currencycode { get; set; }
        public int? Mindeparturetimeminutes { get; set; }
        public string Agentname { get; set; }
        public DateTime Querydatetime { get; set; }
        public Guid Auditgetquoteuuid { get; set; }
        public Guid? Plancatuuid { get; set; }

        public virtual InsPlansCategories Plancatuu { get; set; }
    }
}
