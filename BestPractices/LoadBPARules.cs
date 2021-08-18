System.Net.WebClient w = new System.Net.WebClient(); 

string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
string version = System.Windows.Forms.Application.ProductVersion.Substring(0,1);
string downloadLoc = path+@"\TabularEditor\BPARules.json";
if (version == "3")
{
    downloadLoc = path+@"\TabularEditor3\BPARules.json";
}
string url = "https://github.com/Reinsight-SE/Tabular/raw/main/BestPractices/BPARules.json";
string dlMessage = "Downloaded BPARules.json. Please restart Tabular Editor.";

if (System.IO.File.Exists(downloadLoc))
{
    if (System.Windows.Forms.MessageBox.Show("Would you like to overwrite the existing BPARules.json file?","Overwrite Existing BPA Rules",System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
    {
        w.DownloadFile(url, downloadLoc);
        System.Windows.Forms.MessageBox.Show(dlMessage,"Overwrite Existing BPA Rules",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
    }
    else
    {
        System.Windows.Forms.MessageBox.Show("Did not download BPARules.json.","Overwrite Existing BPA Rules",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
    }
}
else
{
    w.DownloadFile(url, downloadLoc);
    System.Windows.Forms.MessageBox.Show(dlMessage,"Download BPA Rules",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
}