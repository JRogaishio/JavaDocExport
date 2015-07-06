using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace JavaDocExport
{
    public partial class frmMain : Form
    {
        private string importFile = "", exportPath = "";
        private string exportFile;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbo_exportType.SelectedIndex = 0;
        }

        private void btn_importFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                importFile = file.FileName;
                exportFile = file.SafeFileName + "_JavaDocExport.htm";
                lbl_importFile.Text = importFile;
            }
        }

        private void btn_exportDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                exportPath = folder.SelectedPath + "\\";
                lbl_exportDir.Text = exportPath;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (importFile != "" && exportPath != "")
            {
                string newline;
                StreamReader sr = new StreamReader(importFile);
                StreamWriter sw = new StreamWriter(exportPath + exportFile, false);

                try
                {
                    while (!sr.EndOfStream)
                    {
                        newline = sr.ReadLine();

                        //Start the javadoc read if we find a javadoc line
                        if (newline.IndexOf("/**") >= 0)
                        {
                            newline = sr.ReadLine(); //Read the next line in the javadoc

                            int readPos = 0, longDesc = 0;
                            string htmlOutput = "";
                            //While we havent found the terminator
                            while (newline.IndexOf("*/") == -1) {
                            
                                
                                //Make sure the line is in the correct format
                                if(newline.IndexOf("* ") != -1) {
                                    //Grab everything from the * to the right
                                    newline = newline.Substring(newline.IndexOf("* ")+2, newline.Length - newline.IndexOf("* ")-2);
                                    newline = newline.Trim(); // remove whitespace
                                    //MessageBox.Show(newline);

                                    if (readPos == 0 && newline.IndexOf("@") == -1 && newline != "") {
                                        htmlOutput += "<p>" + newline + "</p>";
                                    }
                                    else if (readPos > 0 && newline.IndexOf("@") == -1 && newline != "") {
                                        if (longDesc == 0) {
                                            htmlOutput += "<p>" + newline + "</p>";
                                            longDesc++;
                                        }
                                        else {
                                            //Trim off the double line break of the HTML output since we are still adding to the long description
                                            htmlOutput = htmlOutput.Substring(0, htmlOutput.Length-12) + " " + newline;
                                        }
                                    }
                                    else if (newline.IndexOf("@") != -1 && newline != "") {
                                        htmlOutput += "<div class='api-item-params'>";
                                        string tag = "";
                                        string[] tempData, tempTag;

                                        longDesc = 0; //Reset the long description

                                        newline = trimTabs(newline); //Make sure there is only 1 tab between data
                                        tempData = newline.Split(' ');
                                        tempTag = tempData[0].Split(new string[] {" "}, 2, StringSplitOptions.None); //Split by space only once to separate the parameter from the data

                                        tag = tempData[0];
                                        Debug.WriteLine(tag);
                                        switch (tag.ToUpper())  {
                                            case "@PARAM":
                                                
                                                if (tempData.Length >= 2) {
                                                    string desc = string.Join(" ", tempData.Skip(3));
                                                    htmlOutput += "<strong>Param</strong> " + tempData[2] + " - " + tempData[1] + " : " + desc + "<br />";
                                                }
                                                break;
                                            case "@AUTHOR":
                                                if (tempData.Length >= 1) {
                                                    string desc = string.Join(" ", tempData.Skip(1));
                                                    htmlOutput += "<b>Author</b> " + desc + "<br /><br />";
                                                }
                                                break;
                                            case "@RETURN":
                                                if (tempData.Length >= 1) {
                                                    string desc = string.Join(" ", tempData.Skip(1));
                                                    htmlOutput += "<b>Returns</b> " + desc + "<br /><br />";
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        htmlOutput += "</div>";
                                    } //End @ check
                                }
                                readPos++; //
                                newline = sr.ReadLine();
                            } //End JavaDoc While
                            
                            //We broke out of the loop because we found the terminator, grab the function name
                            newline = sr.ReadLine(); //Read in the function name
                            newline = newline.Replace("{", "");
                            htmlOutput = "<div class='api-item'><h2>" + newline + "</h2>" + htmlOutput + "</div>"; //Prepend the output with the function name

                            //MessageBox.Show("WRITE: \n" + htmlOutput);

                            sw.Write(htmlOutput + "\n\r");
                            readPos = 0;
                            longDesc = 0;
                            htmlOutput = "";
                            
                        } //End JavaDoc opening Check

                    } //End while file read
                    sr.Close();
                    sw.Close();

                    MessageBox.Show("Export Completed!");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Removes all but one tab character
        string trimTabs(string str) {
            StringBuilder ret = new StringBuilder(str); ;
            //C# can index into a string link an array apparently
	        
            for(int i=0; i<str.Length; i++) {
                if(str[i]=='\t') {
                    if(i != str.Length) {
                        if(str[i+1] == '\t') {
                            ret.Remove(i,1); //remove this tab if there is another after it
                        }
                    }
                }

            }


            return ret.ToString();
        }	


    }//End Class
}//End namespace
