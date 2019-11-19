using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_S00180206
{
    
    
    class Activity:IComparable
    {
        public enum ActivityType{ land, water, air};
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public double Cost { get; set; }



        public Activity (string name, string description, DateTime date, double cost, ActivityType activityType)
        {
            Name = name;
            Description = description;
            Date = date;
            Cost = cost;
            ActivityType activityType1 = activityType;

        }
        

        public override string ToString()
        {
            return $"{Name}\t{Description}\t{Date}\t{Cost}\t{"ActivityType"}";
        }

        public int CompareTo(object obj)
        {
            //get a refrence to the next object in the list/array/collection
            Activity objectThatIAmComparingTo = (Activity)obj;//or obj as Activity


            //indicate what field I want ro compare
            int returnValue = this.Date.CompareTo(objectThatIAmComparingTo.Date);

            //return
            return returnValue;
        }

    }
}
