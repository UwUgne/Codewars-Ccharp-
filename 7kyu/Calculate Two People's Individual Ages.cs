/*Create a function that takes in the sum and age difference of two people, calculates their individual ages, and returns a pair of values (oldest age first) if those exist or null/None if:

sum < 0
difference < 0
Either of the calculated ages come out to be negative */

public class Kata
{
    public static double[] GetAges(double sum, double difference)
    {
        if (sum < 0 || difference < 0 || difference > sum)
        { return null; }

        else
        {
            double a = (sum + difference) / 2;
            double b = a - difference;

            return new double[] { a, b };
        }

    }
}