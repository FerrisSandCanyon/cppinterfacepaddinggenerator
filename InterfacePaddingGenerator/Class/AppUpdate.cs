using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPG.Class
{
    public class AppUpdate
    {
        public int    vMajor      = 0,
                      vMinor      = 0,
                      vPatch      = 0;
                                  
        public string dlLink      = null,
                      description = null;

        public bool Get()
        {
            try
            {
                using (WebClient _wc = new WebClient())
                {
                    AppUpdate au = JsonConvert.DeserializeObject<Class.AppUpdate>(_wc.DownloadString("https://raw.githubusercontent.com/FerrisSandCanyon/cppinterfacepaddinggenerator/master/updates.json"));
                    this.vMajor = au.vMajor;
                    this.vMinor = au.vMinor;
                    this.vPatch = au.vPatch;
                    this.dlLink = au.dlLink;
                    this.description = au.description;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to check for update!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool IsNewer()
        {
            if (this.vMajor > Program.Version[0] || this.vMinor > Program.Version[1] || this.vPatch > Program.Version[2])
                return true;

            return false;
        }

    }
}
