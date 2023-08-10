namespace MeasurementsWebAPI.BusinessLogic.CustomAttributes
{
    public class MinValue: Attribute
    {
        public int Min;
        public string? Error;

        public MinValue(int min, string error="Invalid Input!")
        {
            Min = min;
            Error = error;
        }
    }
}
