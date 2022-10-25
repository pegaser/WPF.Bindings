using System;

namespace HomeworkResolved
{
    public class DistanceConverter
    {
        public string Convert(double amount, DistanceType distancetype)
        {
            if (distancetype == DistanceType.Miles)
                return (amount * 1.6).ToString("0.##") + " km";

            if (distancetype == DistanceType.Kilometres)
                return (amount * 0.6).ToString("0.##") + " m";

            throw new ArgumentOutOfRangeException("distanceType");
        }
    }
}
