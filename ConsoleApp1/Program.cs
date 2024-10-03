public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

public class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
}
public interface IShapeFactory
{
    IShape CreateCircle();
    IShape CreateSquare();
    IShape CreateTriangle();
}

public class RedFactory : IShapeFactory
{
    public IShape CreateCircle()
    {
        return new RedCircle();
    }

    public IShape CreateSquare()
    {
        return new RedSquare();
    }

    public IShape CreateTriangle()
    {
        return new RedTriangle();
    }
}

public class BlueFactory : IShapeFactory
{
    public IShape CreateCircle()
    {
        return new BlueCircle();
    }

    public IShape CreateSquare()
    {
        return new BlueSquare();
    }

    public IShape CreateTriangle()
    {
        return new BlueTriangle();
    }
}

public class RedCircle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Red Circle");
    }
}

public class BlueCircle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Blue Circle");
    }
}

public class RedSquare : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Red Square");
    }
}

public class BlueSquare : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Blue Square");
    }
}

public class RedTriangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Red Triangle");
    }
}

public class BlueTriangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Blue Triangle");
    }
}
public class ShapeApplication
{
    private IShapeFactory currentFactory;

    public void SetFactory(IShapeFactory factory)
    {
        currentFactory = factory;
        ClearShapes();
    }

    public void DrawShapes()
    {
        if (currentFactory == null) return;

        IShape circle = currentFactory.CreateCircle();
        circle.Draw();

        IShape square = currentFactory.CreateSquare();
        square.Draw();

        IShape triangle = currentFactory.CreateTriangle();
        triangle.Draw();
    }

    private void ClearShapes()
    {
        
       
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ShapeApplication app = new ShapeApplication();

        Console.WriteLine("Select color (1 - Red, 2 - Blue): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            app.SetFactory(new RedFactory());
        }
        else if (choice == 2)
        {
            app.SetFactory(new BlueFactory());
        }

        app.DrawShapes();
    }
}
