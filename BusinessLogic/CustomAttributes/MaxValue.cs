namespace MeasurementsWebAPI.BusinessLogic.CustomAttributes
{
    public class MaxValue: Attribute
    {
        public int Max;
        public string? Error;

        public MaxValue(int max, string error="Invalid Input!")
        {
            Max = max;
            Error = error;
        }
    }
}
