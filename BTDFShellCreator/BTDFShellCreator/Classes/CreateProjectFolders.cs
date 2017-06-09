using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BTDFShellCreator.Classes
{
    class CreateProjectFolders
    {
        public string CreateSolutionFolder(string strHomeDir, string strAppType, string strCusName, string strAppName)
        {
            string strFileName = "";
            //string strTarget = strHomeDir + @"\" + strAppType + @"\" + strCusName;
            string strTarget = Environment.CurrentDirectory + @"\..\..\..\..\..\" + strHomeDir + @"\" + strCusName;
               
            try
            {
                foreach (var srcPath in Directory.GetFiles(@"..\..\ShellFiles\"))
                {
                    strFileName = srcPath.Substring(srcPath.LastIndexOf(@"\") + 1);
                    strFileName = strFileName.Replace("_AppName", strAppName);
                    strFileName = strFileName.Replace("_AppType", strAppType);
                    strFileName = strFileName.Replace("_CusName", strCusName);
                    strFileName = strFileName.Replace("_sln", "sln");

                    string strReplace = File.ReadAllText(srcPath);
                    strReplace = strReplace.Replace("#AppName", strAppName);
                    strReplace = strReplace.Replace("#AppType", strAppType);
                    strReplace = strReplace.Replace("#CusName", strCusName);
                    strReplace = strReplace.Replace("#GUID1", System.Guid.NewGuid().ToString());
                    strReplace = strReplace.Replace("#GUID2", System.Guid.NewGuid().ToString());

                    File.WriteAllText(strTarget + @"\" + strFileName, strReplace);

                }

                return "Solution File Created.";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        public string CreateFolderShell(string strHomeDir, string strAppType, string strCusName, string strAppName, string strCopyFolder)
        {
            try
            {
                //string strTarget = strHomeDir + @"\" + strAppType + @"\" + strCusName + @"\" + strAppName + "." + strAppType + "." + strCusName + "." + strCopyFolder;

                string strTarget = Environment.CurrentDirectory + @"\..\..\..\..\..\" + strHomeDir + @"\" + strCusName + @"\" + strAppName + "." + strAppType + "." + strCusName + "." + strCopyFolder;
                System.IO.Directory.CreateDirectory(strTarget);

                string strFileName = "";

                
                foreach (var srcPath in Directory.GetFiles(@"..\..\ShellFiles\" + strCopyFolder + @"\"))
                {
                    strFileName = srcPath.Substring(srcPath.LastIndexOf(@"\") + 1);
                    strFileName = strFileName.Replace("_AppName", strAppName);
                    strFileName = strFileName.Replace("_AppType", strAppType);
                    strFileName = strFileName.Replace("_CusName", strCusName);
                    strFileName = strFileName.Replace("xbtdfprojx", "btdfproj");

                    string strReplace = File.ReadAllText(srcPath);
                    strReplace = strReplace.Replace("#AppName", strAppName);
                    strReplace = strReplace.Replace("#AppType", strAppType);
                    strReplace = strReplace.Replace("#CusName", strCusName);
                    strReplace = strReplace.Replace("#GUID1", System.Guid.NewGuid().ToString());
                    strReplace = strReplace.Replace("#GUID2", System.Guid.NewGuid().ToString());

                    if (strFileName == "AssemblyInfo._cs")
                    {
                        strFileName = "AssemblyInfo.cs";
                        System.IO.Directory.CreateDirectory(strTarget + @"\Properties\");
                        File.WriteAllText(strTarget + @"\Properties\" + strFileName, strReplace);
                    }
                    else
                    {
                        File.WriteAllText(strTarget + @"\" + strFileName, strReplace);
                    }
                    
                }

                return strFileName;
            }
           catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}
