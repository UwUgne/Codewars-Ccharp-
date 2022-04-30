//8kyu 

using System;

public class Kata
{
    public static int Mango(int quantity, int price)
    {
        int free = quantity / 3;

        int total = (quantity * price) - (free * price);

        return total;
    }
}
