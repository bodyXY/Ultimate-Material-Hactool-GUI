using System.Diagnostics;

namespace Ultimate_Material_Hactool_GUI
{
    class Hactoolstarter
    {
        Process Hactool = new Process();

        public Hactoolstarter()
        {
            Hactool.StartInfo.FileName = "hactool.exe";
            Hactool.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        public void RunCommand(string Args)
        {
            Hactool.StartInfo.Arguments = Args;
            Hactool.Start();
            Hactool.WaitForExit();
        }
    }
}