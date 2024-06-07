namespace Lesson1.Services;

public class RectangleServiceImplcs : RectangleService
{
    private CalculateService calculateService;
    public RectangleServiceImplcs(CalculateService _calculateService)
    {
        calculateService = _calculateService;
    }

    public double Area(double x, double y)
    {
        return calculateService.Mul(x, y);
    }

    public double Perimter(double x, double y)
    {
        return calculateService.Mul(calculateService.Add(x, y), 2);
    }
}
