using System.Diagnostics;

 static void Main(string[] args)
{

    Medicines objmed = new Medicines();
    objmed.Accept();
    objmed.Display();

    Polygone objpoly = new Polygone("");
    objpoly.draw();

    Rectangle objrect = new Rectangle("");
    objrect.draw();

    Circle objcircle = new Circle();
    objcircle.getArea(4);

    Rectangle objrect = new Rectangle("");
    objrect.getArea();

    //e.g. of inedex out of range
    int[] ar = { 1, 2, 3, 4, 5 };

    // causing exception
    for (int i = 0; i <= ar.Length; i++)
        Console.WriteLine(ar[i]);

    Console.WriteLine("Throw Example");
    try
    {
        string empName = null;
        ThrowException(empName);
    }
    catch (ArgumentNullException objnull)
    {
        Console.WriteLine(objnull);
    }
    lambdaprog t = new lambdaprog(delegate (int i) { return i * i; });
    Console.WriteLine(t(2));










}
