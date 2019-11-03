using System.Diagnostics;

namespace Ultimate_Material_Hactool_GUI
{
    class Hactoolstarter
    {
        // INSTANTIATION OF PROCESSES
        Process Hactool = new Process();
        Process Kill = new Process();

        //METHOD TO RUN HACTOOL PROCESS
        public Hactoolstarter()
        {
            Hactool.StartInfo.FileName = "hactool.exe";
            Hactool.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        //METHOD TO EXECUTE COMMAND FOR HACTOOL
        public void RunCommand(string Args)
        {
            Hactool.StartInfo.Arguments = Args;
            Hactool.StartInfo.CreateNoWindow = true;
            Hactool.StartInfo.UseShellExecute = false;
            Hactool.Start();
        }

        //METHOD TO CANCEL HACTOOL PROCESS
        public void KillProcess()
        {
            foreach (var proc in Process.GetProcessesByName("hactool"))
            {
                proc.Kill();
            }
        }
    }
}