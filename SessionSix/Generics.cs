namespace SessionSix.SessionSix
{
    internal class Generics
    {
    }

    public class Assemblers<Tcover, Tcontent>
    {
        Product<Tcover, Tcontent> _product;
        public Product<Tcover, Tcontent> Assemble(Tcover cover, Tcontent content)
        {
            return new Product<Tcover, Tcontent>(cover, content);
        }
    }

    public class Product<Tcover, Tcontent>
    {
        Tcover _cover;
        Tcontent _content;
        public Product(Tcover cover, Tcontent content)
        {
            _cover = cover;
            _content = content;
        }
    }

    public class PenCover { }
    public class InkTube { }
    public class Bottle { }
    public class Zobo { }

    public class Pen : Product<PenCover, InkTube>
    {
        PenCover _cover;
        InkTube _tube;

        public Pen(PenCover cover, InkTube tube): base(cover, tube)
        {
            _cover = cover;
            _tube = tube;
        }
    }

    public class ZoboDrink : Product<Bottle, Zobo>
    {
        Bottle _bottle;   
        Zobo _zobo;   
        public ZoboDrink(Bottle bottle, Zobo zobo):base(bottle, zobo)
        {
            _bottle = bottle;
            _zobo = zobo;
        }
    }

    public class PlayGroundTwo
    {
        public void Run()
        {
            //Create a cover
            Bottle cover = new();
            //Create a content
            Zobo zobo = new();
            //Pass 'em both to Assembler
            Assemblers<Bottle, Zobo> assembler = new();
            ZoboDrink drink = (ZoboDrink)assembler.Assemble(cover, zobo);

            PenCover penCover = new();
            InkTube InkTube = new();
            Assemblers<PenCover, InkTube> assemblerTwo = new();
            Pen pen = (Pen)assemblerTwo.Assemble(penCover, InkTube);

        }
    }
}
