using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimDueAccident
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public string AccidentPlace { get; set; }
        public string AccidentType { get; set; }
        public string InjuryType { get; set; }
        public string EmployerName { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerContactNo { get; set; }
        public DateTime? LastWorkDate { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public bool? IsWorkingNow { get; set; }
        public string OccupationBefore { get; set; }
        public string NatureOfWork { get; set; }
        public string OccupationAfterDisability { get; set; }
    }
}
