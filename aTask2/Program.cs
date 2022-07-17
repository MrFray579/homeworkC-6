void Coordinates (double k1, double k2, double b1, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = x * k1 + b1; 
    Console.WriteLine("Coordinates {0}, {1}", x, y);
}

Coordinates(2, 5, 7, 10);
Coordinates(9, 6, 8, 1);
Coordinates(1, 7, 3, 15);