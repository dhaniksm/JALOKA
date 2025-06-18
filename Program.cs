namespace JALOKA.Views
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new V_TampilanAwal());

        }
    }
}
