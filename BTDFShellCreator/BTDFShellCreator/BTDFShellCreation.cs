using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTDFShellCreator
{
    public partial class BTDFShellCreation : Form
    {
        Classes.CreateProjectFolders createFolders = new Classes.CreateProjectFolders();


        public BTDFShellCreation()
        {
            InitializeComponent();
        }

        private void BTDFShellCreation_Load(object sender, EventArgs e)
        {
        }

        private void cmdCreateApp_Click(object sender, EventArgs e)
        {
           
            int counter = 0;
            string line;

            string strHomeDir = txtHomeDir.Text;
            string strAppName = txtAppName.Text;
            string strAppType = txtAppType.Text;
            string strCusName = txtCusname.Text;
            string strCopyFolder, retVal;

            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\ControlFile\Control.txt");
            while((line = file.ReadLine()) != null)
            {
                strCopyFolder = line;  
                retVal = createFolders.CreateFolderShell(strHomeDir, strAppType, strCusName, strAppName, strCopyFolder);
                txtDisplay.Text = txtDisplay.Text + retVal + System.Environment.NewLine;


               counter++;
            }

            file.Close();

            retVal = createFolders.CreateSolutionFolder(strHomeDir, strAppType, strCusName, strAppName);
            txtDisplay.Text = txtDisplay.Text + retVal + System.Environment.NewLine;
        }

       

    }
}
