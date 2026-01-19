namespace bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diék> list = new List<Diék>();
            var sorok = File.ReadAllLines("bmi.txt", System.Text.Encoding.Latin1).Skip(1);
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
                string[] darabok =  sor.Split(";");
                string nev = darabok[0];
                int eletkor = Convert.ToInt32(darabok[1]);
                int magassag = Convert.ToInt32(darabok[2]);
                int suly = Convert.ToInt32(darabok[3]);
                Diék d = new Diék(nev, eletkor, magassag, suly);
                list.Add(d);
            }
        }
    }
}
