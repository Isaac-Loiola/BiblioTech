using BiblioTechClass;

namespace BiblioTechDesk
{
    internal static class Program
    {
        public static Usuario UsuarioLogado { get; set; }
        public static Endereco EnderecoUsuario { get; set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()

        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmAcesso());
        }
    }
}