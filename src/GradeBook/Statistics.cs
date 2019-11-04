
namespace GradeBook {
    public class Statistics 
    {
        public double Average { get; set; }
        public double High {get; set; }
        public double Low { get; set; }

        public Statistics() {
            
        }

        public Statistics(double average, double high, double low) {
            this.Average = average;
            this.High = high;
            this.Low = low;
        }
    }
}