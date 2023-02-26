namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            baraban bar = new baraban(10);
            gitara git = new gitara(7);
            truba trub = new truba(11);

            music_instrum[] instr = { bar, git, trub };
            for (int i = 0; i < instr.Length; i++)
            {
                instr[i].play();

            }
        }
    }

    public interface music_instrum
    {
        void play(){}
    }

    public class baraban : music_instrum
    {
        public int razm;
        public baraban(int razmer)
        {
            razm = razmer;
        }
        public void play()
        {
            Console.WriteLine("Играет Барабан размером " + razm + " дюймов");
        }
    }

    public class gitara : music_instrum
    {
        public int strun;
        public gitara(int str)
        {
            strun = str;
        }
        public void play()
        {
            Console.WriteLine("Играет Гитара с "+strun + " струнами ");
        }
    }
   
    public class truba : music_instrum
    {
        public float diam;
        public truba(float diametr)
        {
            diam = diametr;
        }
        public void play()
        {
            Console.WriteLine("Играет Труба диаметром " + diam + " милиметров");
        }
    }
}