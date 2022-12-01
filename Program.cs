using System;

namespace arayuzler_ornek
{ 
    class program
    { 
        static void Main(string[] args)
        { 
            X5 x5 = new X5();
           Console.WriteLine(x5.HangiMarkanınAraci().ToString());
           Console.WriteLine(x5.KacTekerlektenOlusur());
           Console.WriteLine(x5.StandartRengiNE().ToString());

            A8 a8 = new A8();
           Console.WriteLine(a8.HangiMarkanınAraci().ToString());
           Console.WriteLine(a8.KacTekerlektenOlusur());
           Console.WriteLine(a8.StandartRengiNE().ToString());

            E300 e300 = new E300();
           Console.WriteLine(e300.HangiMarkanınAraci().ToString());
           Console.WriteLine(e300.KacTekerlektenOlusur());
           Console.WriteLine(e300.StandartRengiNE().ToString());   
        }
    }
}