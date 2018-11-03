using System;

namespace assign_team.BO
{
    public class Project
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimeSpan getProjectDuration()
        {
            return this.EndDate - this.StartDate;
        }
    }
}