using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimIllness
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public string NatureOfIllness { get; set; }
        public string Symptoms { get; set; }
        public DateTime? SymptomsStartedDate { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public string DcotorName { get; set; }
        public string HospitalName { get; set; }
    }
}
