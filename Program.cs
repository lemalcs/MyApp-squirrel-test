using System;
using Squirrel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static /*async Task*/void Main()
        {

            try
            {
                //GitHubUpdate();
                //AmazonS3Update();
                StaticGithubUpdate();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        static async void LocalUpdate()
        {
            using (var mgr = new UpdateManager("D:\\SourceRepo\\MyApp-squirrel-test\\Releases"))
            {
                await mgr.UpdateApp();
            }
        }

        static void GitHubUpdate()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/lemalcs/MyApp-squirrel-test"))
            {
                mgr.Result.UpdateApp().Wait();
            }
        }

        static async void AmazonS3Update()
        {
            using (var mgr = new UpdateManager("https://khernetreleases.s3.amazonaws.com"))
            {
                await mgr.UpdateApp();
            }
        }

        static async void StaticGithubUpdate()
        {
            using (var mgr = new UpdateManager("https://github.com/lemalcs/MyApp-squirrel-test/releases/latest/download"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}
