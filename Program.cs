namespace Abstract.Lesson
{
    public abstract class FiguraGeometrica // 1 -  Di essere un contratto!
    {                                     //  2 -  Un Oggetto normale [ memebri, funzioni implementate]
        int _perimetro;
        public abstract int CalcArea();  // Contratto
        public virtual int GetPerimentro() // Servizio in Piu
        {
            System.Console.WriteLine("FiguraGeometrica -  io calcolo il perimetro");

            return 500;
        }
    }
    public interface IGeometrica { } // 1 -  Di essere un contratto!

    public class Rettangolo : FiguraGeometrica
    {
        int _base = 10;
        int _altezza = 40;
        public override int CalcArea()
        {
            System.Console.WriteLine("Area del Rettangolo:  ");
            System.Console.WriteLine((_base * _altezza));

            return _base * _altezza;
        }
        public override int GetPerimentro()
        {
            System.Console.WriteLine("Rettangolo -  io calcolo il perimetro");
            return 10000;
        }
    }
    public class Triangolo : FiguraGeometrica
    {
        int _base = 10;
        int _altezza = 40;
        public override int CalcArea()
        {
            System.Console.WriteLine("Area del Triangolo:  ");
            System.Console.WriteLine((_base * _altezza) / 2);
            return (_base * _altezza) / 2;
        }
    }
}
