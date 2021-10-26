using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Activator
{
    public partial class Form_Activate : Form
    {

        public Form_Activate()
        {
            InitializeComponent();
        }

        private void comboBox_Windows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Windows.Text == "8")
            {
                comboBox_Edition.Items.Clear();
                comboBox_Edition.Items.Add("Home");
                comboBox_Edition.Items.Add("Home Single Language");
                comboBox_Edition.Items.Add("Professional");
                comboBox_Edition.Items.Add("Professional N");
                comboBox_Edition.Items.Add("Professional WMC");
                comboBox_Edition.Items.Add("Enterprice");
                comboBox_Edition.Items.Add("Enterprice N");
            }

            if (comboBox_Windows.Text == "8.1")
            {
                comboBox_Edition.Items.Clear();
                comboBox_Edition.Items.Add("Home");
                comboBox_Edition.Items.Add("Home N");
                comboBox_Edition.Items.Add("Home Single Language");
                comboBox_Edition.Items.Add("Professional");
                comboBox_Edition.Items.Add("Professional N");
                comboBox_Edition.Items.Add("Professional WMC");
                comboBox_Edition.Items.Add("Enterprice");
                comboBox_Edition.Items.Add("Enterprice N");
            }

            if (comboBox_Windows.Text == "10")
            {
                comboBox_Edition.Items.Clear();
                comboBox_Edition.Items.Add("Home");
                comboBox_Edition.Items.Add("Home N");
                comboBox_Edition.Items.Add("Home Single Language");
                comboBox_Edition.Items.Add("Home Country Specific");
                comboBox_Edition.Items.Add("Professional");
                comboBox_Edition.Items.Add("Professional N");
                comboBox_Edition.Items.Add("Education");
                comboBox_Edition.Items.Add("Education N");
                comboBox_Edition.Items.Add("Enterprice");
                comboBox_Edition.Items.Add("Enterprice N");
            }

            if (comboBox_Windows.Text == "11")
            {
                comboBox_Edition.Items.Clear();
                comboBox_Edition.Items.Add("Home");
                comboBox_Edition.Items.Add("Home N");
                comboBox_Edition.Items.Add("Home Single Language");
                comboBox_Edition.Items.Add("Home Country Specific");
                comboBox_Edition.Items.Add("Professional");
                comboBox_Edition.Items.Add("Professional N");
                comboBox_Edition.Items.Add("Education");
                comboBox_Edition.Items.Add("Education N");
                comboBox_Edition.Items.Add("Enterprice");
                comboBox_Edition.Items.Add("Enterprice N");
            }

            comboBox_Edition.Enabled = true;
        }

        private void comboBox_Edition_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Windows.Visible = false;
            comboBox_Edition.Visible = false;
            comboBox_Windows.Visible = false;
            Activate(comboBox_Windows.Text, comboBox_Edition.Text);
        }

        private void Activate(String Windows, String Edition)
        {
            InstallKey(GenerateKey(Windows, Edition));
            KMS();
            FinalActivate(Windows, Edition);
        }

        private void InstallKey(String key)
        {
            label_Windows.Text = "Installing Product Key!";
            cmd("/c slmgr /ipk " + key);
        }

        private void KMS()
        {
            label_Windows.Text = "Setting Key Management Service!";
            cmd("/c slmgr /skms kms8.msguides.com");
        }

        private void FinalActivate(String Windows, String Edition)
        {
            label_Windows.Text = "Activating Windows " + Windows + " " + Edition + "!";
            cmd("/c slmgr /ato");
            Application.Exit();
        }

        private String GenerateKey(String Windows, String Edition)
        {
            label_Windows.Padding = new Padding(0, 0, 0, 0); 
            label_Windows.Dock = DockStyle.Fill;
            label_Windows.Text = "Generating Product Key!";
            label_Windows.Visible = true;

            if (Windows == "8")
            {
                if (Edition == "Home")
                {
                    return "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
                }
                if (Edition == "Home Single Language")
                {
                    return "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
                }
                if (Edition == "Professional")
                {
                    return "NG4HW-VH26C-733KW-K6F98-J8CK4";
                }
                if (Edition == "Professional N")
                {
                    return "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                }
                if (Edition == "Professional WMC")
                {
                    return "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
                }
                if (Edition == "Enterprice")
                {
                    return "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                }
                if (Edition == "Enterprice N")
                {
                    return "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                }
            }

            if (Windows == "8.1")
            {
                if (Edition == "Home")
                {
                    return "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
                }
                if (Edition == "Home N")
                {
                    return "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
                }
                if (Edition == "Home Single Language")
                {
                    return "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
                }
                if (Edition == "Professional")
                {
                    return "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                }
                if (Edition == "Professional N")
                {
                    return "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                }
                if (Edition == "Professional WMC")
                {
                    return "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
                }
                if (Edition == "Enterprice")
                {
                    return "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                }
                if (Edition == "Enterprice N")
                {
                    return "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                }
            }

            if (Windows == "10")
            {
                if (Edition == "Home")
                {
                    return "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (Edition == "Home N")
                {
                    return "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                }
                if (Edition == "Home Single Language")
                {
                    return "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                }
                if (Edition == "Home Country Specific")
                {
                    return "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                }
                if (Edition == "Professional")
                {
                    return "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (Edition == "Professional N")
                {
                    return "MH37W-N47XK-V7XM9-C7227-GCQG9";
                }
                if (Edition == "Education")
                {
                    return "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                }
                if (Edition == "Education N")
                {
                    return "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                }
                if (Edition == "Enterprice")
                {
                    return "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
                if (Edition == "Enterprice N")
                {
                    return "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                }
            }

            if (Windows == "11")
            {
                if (Edition == "Home")
                {
                    return "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (Edition == "Home N")
                {
                    return "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                }
                if (Edition == "Home Single Language")
                {
                    return "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                }
                if (Edition == "Home Country Specific")
                {
                    return "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                }
                if (Edition == "Professional")
                {
                    return "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (Edition == "Professional N")
                {
                    return "MH37W-N47XK-V7XM9-C7227-GCQG9";
                }
                if (Edition == "Education")
                {
                    return "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                }
                if (Edition == "Education N")
                {
                    return "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                }
                if (Edition == "Enterprice")
                {
                    return "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
                if (Edition == "Enterprice N")
                {
                    return "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                }
            }
            return "";
        }

        private void cmd(String Command)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = Command;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();
        }
    }
}
