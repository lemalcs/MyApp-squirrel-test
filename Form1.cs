using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            Assembly assembly = Assembly.GetExecutingAssembly();

			locationTextBox.Text = assembly.Location;
            versionTextBox.Text = assembly.GetName().Version.ToString(3);

			using (var mgr=new UpdateManager(null))
            {
				txt_RootFolder.Text= mgr.RootAppDirectory;
				check_IsInstalled.Checked = mgr.IsInstalledApp;
				txt_AppName.Text = mgr.ApplicationName;
            }
		}

        private void btn_HiButton_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Hi this is a new version of this application.");
        }
    }
}
