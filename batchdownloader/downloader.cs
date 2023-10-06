using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace batchdownloader
{
    public class downloader
    {
        public TextBox update_textbox;
        public Label update_label;
        public ProgressBar update_bar;
        public String song_folder;
        public List<int> set_ids;
        public List<int> already_downloaded;
        public bool started = false;
        public downloader(TextBox update_textbox, Label update_label, ProgressBar update_bar, String song_folder, List<int> set_ids, List<int> already_downloaded) {
            this.update_textbox = update_textbox;
            this.update_label = update_label;
            this.update_bar = update_bar;
            this.song_folder = song_folder;
            this.set_ids = set_ids;
            this.already_downloaded = already_downloaded;
        }

        public void start()
        {
            Thread thread = new Thread(download);
            thread.Start();

            this.started = true;
        }

        private void download()
        {
            int progress = 1;
            update_bar.Invoke((MethodInvoker)delegate
            {
                update_bar.Maximum = set_ids.Count();
                update_bar.Minimum = 0;
            });
            foreach (int mapid in set_ids)
            {
                Thread.Sleep(1000);
                update_bar.Invoke((MethodInvoker)delegate
                {
                    update_bar.Value = progress;
                });
                update_label.Invoke((MethodInvoker)delegate
                {
                    update_label.Text = "Progress: " + progress + "/" + set_ids.Count();
                });
                if (!started)
                {
                    update_textbox.Invoke((MethodInvoker)delegate
                    {
                        update_textbox.Text += "Aborting.\n";
                    });
                    return;
                }
                if (already_downloaded.Contains(mapid))
                {
                    /**
                    update_textbox.Invoke((MethodInvoker)delegate
                    {
                        update_textbox.Text += "Skipping set" + mapid + "\n";
                    });
                    */
                } else
                {
                    if (download_direct(mapid, song_folder) || download_chimu(mapid, song_folder) || download_nerinyan(mapid, song_folder))
                    {
                        
                    } else
                    {
                        update_textbox.Invoke((MethodInvoker)delegate
                        {
                            update_textbox.AppendText("404: " + mapid);
                            update_textbox.AppendText(Environment.NewLine);
                        });
                    }
                }
                progress++;
            }
        }

        private bool download_direct(int set_id,string song_folder)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.osu.direct/d/" + set_id);
                request.UserAgent = "batchdownloader";
                WebResponse response = request.GetResponse();
                string originalFileName = response.Headers["Content-Disposition"].Split("\"")[1];
                Stream streamWithFileBody = response.GetResponseStream();
                using (var fileStream = File.Create(song_folder + "\\" + originalFileName))
                {
                    streamWithFileBody.CopyTo(fileStream);
                    streamWithFileBody.Flush();
                }
                return true;
            } catch
            {
                return false;
            }
        }

        private bool download_chimu(int set_id, string song_folder)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chimu.moe/v1/download/" + set_id);
                request.UserAgent = "batchdownloader";
                WebResponse response = request.GetResponse();

                string originalFileName = HttpUtility.UrlDecode(response.Headers["Content-Disposition"]).Split("=")[1];
                System.Diagnostics.Debug.WriteLine("downloading with chimu");
                System.Diagnostics.Debug.WriteLine(originalFileName);
                Stream streamWithFileBody = response.GetResponseStream();
                using (var fileStream = File.Create(song_folder + "\\" + originalFileName))
                {
                    streamWithFileBody.CopyTo(fileStream);
                    streamWithFileBody.Flush();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool download_nerinyan(int set_id, string song_folder)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.nerinyan.moe/d/" + set_id);
                request.UserAgent = "batchdownloader";
                WebResponse response = request.GetResponse();
                string originalFileName = response.Headers["Content-Disposition"].Split("\"")[1];
                System.Diagnostics.Debug.WriteLine("downloading with nerinyan");
                System.Diagnostics.Debug.WriteLine(originalFileName);
                Stream streamWithFileBody = response.GetResponseStream();
                using (var fileStream = File.Create(song_folder + "\\" + originalFileName))
                {
                    streamWithFileBody.CopyTo(fileStream);
                    streamWithFileBody.Flush();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    public class filereader
    {

        public List<int> beatmapset_ids;
        public filereader(string filename)
        {
            this.beatmapset_ids = new List<int>();
            string[] readText = File.ReadAllLines(filename);
            foreach (string s in readText)
            {
                try
                {
                    this.beatmapset_ids.Add(Int32.Parse(s.Split(",")[0]));
                } catch (FormatException)
                {
                    
                }
            }
        }
    }

    public class songfolderreader
    {

        public List<int> beatmapset_ids;
        public songfolderreader(string folder)
        {
            string[] dirs = Directory.GetDirectories(folder, "*", SearchOption.TopDirectoryOnly);
            string[] files = Directory.GetFiles(folder);
            this.beatmapset_ids = new List<int>();
            foreach (string s in dirs)
            {
                System.Diagnostics.Debug.WriteLine(s);
                try
                {
                    this.beatmapset_ids.Add(Int32.Parse(s.Split("\\").Last().Split(" ")[0]));
                } catch (FormatException) { }
            }
            foreach (string s in files)
            {
                System.Diagnostics.Debug.WriteLine(s);
                try
                {
                    this.beatmapset_ids.Add(Int32.Parse(s.Split("\\").Last().Split(" ")[0]));
                }
                catch (FormatException) { }
            }
        }
    }
}
