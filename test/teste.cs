namespace test
{
    public class teste
    {
        public void Falar(){

        }
        static void Beep(int x, int z)
        {
            Console.Beep(x, z);
        }
        public void PlaySong()
    {
        Beep(1320,500);
        Beep(990,250);
        Beep(1056,250);
        Beep(1188,250);
        Beep(1320,125);
        Beep(1188,125);
        Beep(1056,250);
        Beep(990,250);
        Beep(880,500);
        Beep(880,250);
        Beep(1056,250);
        Beep(1320,500);
        Beep(1188,250);
        Beep(1056,250);
        Beep(990,750);
        Beep(1056,250);
        Beep(1188,500);
        Beep(1320,500);
        Beep(1056,500);
        Beep(880,500);
        Beep(880,500);
        System.Threading.Thread.Sleep(250);
        Beep(1188,500);
        Beep(1408,250);
        Beep(1760,500);
        Beep(1584,250);
        Beep(1408,250);
        Beep(1320,750);
        Beep(1056,250);
        Beep(1320,500);
        Beep(1188,250);
        Beep(1056,250);
        Beep(990,500);
        Beep(990,250);
        Beep(1056,250);
        Beep(1188,500);
        Beep(1320,500);
        Beep(1056,500);
        Beep(880,500);
        Beep(880,500);
        System.Threading.Thread.Sleep(500);
        PlaySong();

    }
    }
}