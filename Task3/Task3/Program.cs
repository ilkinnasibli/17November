static int CircleArea (int radius) 
{
    int area;
    area = 3 * radius*radius;
    Console.WriteLine (area);
    return area;

}
CircleArea(5);
static int RectangleArea(int side1, int side2) 
{
    int area;
    area=side1 * side2;
    Console.WriteLine (area);
    return (area);
}
RectangleArea(2, 5);
static double TriangleArea (double radius,double side1,double side2,double side3) 
{
    double area = ((side1 + side2 + side3) / 2) * radius;
    Console.WriteLine (area);
    return (area);
}
TriangleArea(1, 1, 1, 1);
