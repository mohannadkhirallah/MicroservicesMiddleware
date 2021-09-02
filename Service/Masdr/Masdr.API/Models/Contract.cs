using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masdr.API.Models
{
    public class Contract
    {
        public int ID { get; set; }
        public int RegistrationNumber { get; set; }
        public int WorkType { get; set; }
        public int ContractType { get; set; }
        public string EndDate { get; set; }
        public string StartDate { get; set; }
        public int Religion { get; set; }
        public string RepresentedByArb { get; set; }
        public string RepresentedByEng { get; set; }
        public string RepresentedByAsArb { get; set; }
        public string RepresentedByAsEng { get; set; }
        public string JobTitleArb { get; set; }
        public string JobTitleEng { get; set; }
        public int AbroadInd { get; set; }
        public int Country { get; set; }
        public int City { get; set; }
        public string AccountIBAN { get; set; }
        public string AccountBankNameArb { get; set; }
        public string accountBankNameEng { get; set; }
        public int WorkingHoursStandard { get; set; }
        public int WorkingHours { get; set; }
        public int WorkingDays { get; set; }
        public int RestingDays { get; set; }
        public int AnnualLeaveDays { get; set; }
        public int ProbationPeriodDays { get; set; }
        public int TransportationAllowence { get; set; }
        public IEnumerable<AdditionalClause> AdditionalClause { get; set; }
        public IEnumerable<int> OptionalClause { get; set; }
        public int ContributorLanguage { get; set; }
        public int NoticePeriod { get; set; }


    }
    public class AdditionalClause
    {
        public string Arabic { get; set; }
        public string English { get; set; }
    }
}

