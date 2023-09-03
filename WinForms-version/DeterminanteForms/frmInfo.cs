using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterminanteForms
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
            LoadVersion();
        }

        public void LoadVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string currentVersion = versionInfo.FileVersion;

            lbVersion.Text = "Version: " + currentVersion;
        }
    }
}
