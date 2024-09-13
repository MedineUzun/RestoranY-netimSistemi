namespace YazLab1_3
{
    internal static class Program
    {
        private static object LockObject = new object();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Masa masa = new Masa(6);
            masa.MasaOlustur();
            Garson garson = new Garson(3);
            garson.GarsonOlustur();

            Form1 form1 = new Form1();

            Application.Run(form1);


        }



    }
}