using BlueSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobHunter.Models
{
    public class CampaignStats
    {
        public int Total      { get; set; }
        public int Active     { get; set; }
        public int Waiting    { get; set; }
        public int NotStarted { get; set; }
        public int InProgress { get; set; }
        public int Scheduled  { get; set; }
        public int Late       { get; set; }
        public int Completed  { get; set; }
        public int Hold       { get; set; }
        public int Cancelled  { get; set; }

        public CampaignStats(List<Campaign> campaigns)
        {
            List<string> ActiveStatuses     = new List<string> { "prep", "sched", "started", "movedon", "submitted", "waiting" };
            List<string> CancellingStatuses = new List<string> { "nogo", "cancelled", "expired" };
            List<string> WaitingStatuses    = new List<string> { "submitted", "waiting" };
            
            Total      = campaigns.Count();
            Active     = campaigns.Where(c => ActiveStatuses.Contains(c.Status)).Count();
            Waiting    = campaigns.Where(c => WaitingStatuses.Contains(c.Status)).Count();
            NotStarted = campaigns.Where(c => c.Status == "todo").Count();
            InProgress = campaigns.Where(c => ActiveStatuses.Contains(c.Status)).Count();
            Scheduled  = campaigns.Where(c => c.Status == "sched").Count();
            Completed  = campaigns.Where(c => c.Status == "done").Count();
            Hold       = campaigns.Where(c => c.Status == "hold").Count();
            Cancelled  = campaigns.Where(c => CancellingStatuses.Contains(c.Status)).Count();

        }

    }
}
