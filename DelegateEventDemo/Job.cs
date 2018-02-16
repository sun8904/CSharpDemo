using System;

namespace DelegateEventDemo
{
    public class Job : EventArgs
    {
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        private WorkType workType;

        public WorkType WorkType
        {
            get { return workType; }
            set { workType = value; }
        }

        public Job(int hours, WorkType workType)
        {
            this.hours = hours;
            this.workType = workType;
        }

        public override string ToString()
        {
            return $"hours:{hours},{workType}";
        }
    }
}