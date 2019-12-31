namespace GradeBook
{
    public class Statistics
    {
        public double Average;

        public double LowestGrade;

        public double HighestGrade;

        public Statistics(double average, double lowestGrade, double highestGrade)
        {
            this.Average = average;
            this.LowestGrade = lowestGrade;
            this.HighestGrade = highestGrade;
        }
    }
}