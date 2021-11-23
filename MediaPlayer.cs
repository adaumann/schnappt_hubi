using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hubi
{
    public class MediaPlayer
    {
        public List<string> queue;

        public MediaPlayer()
        {
            queue = new List<string>();
        }

        public void AddSound(string sound)
        {
            queue.Add(sound);
        }


        public void Play(int sleepTime=0)
        {
            string queueStr="";
            if (queue.Any())
            {
                foreach (var q in queue)
                {
                    queueStr += $"sound\\{q}.m4a ";
                }
            }
            else
                return;

            using (var process = new Process())
            {
                process.StartInfo.FileName = @"C:\Program Files\VideoLAN\VLC\vlc.exe"; // relative path. absolute path works too.
                process.StartInfo.Arguments = $"--qt-start-minimized --play-and-exit --qt-notification=0 --no-loop {queueStr}";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = false;
                process.StartInfo.RedirectStandardError = false;

                process.Start();
            }
            Thread.Sleep(sleepTime * 1000);

        }

        public void Clear()
        {
            queue.Clear();
        }

        public void Stop()
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = @"taskkill.exe"; // relative path. absolute path works too.
                process.StartInfo.Arguments = $"/IM vlc.exe /F";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = false;
                process.StartInfo.RedirectStandardError = false;

                process.Start();
            }
        }
    }
}
