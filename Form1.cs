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
        String Windows, Win8Ed, Win8p1Ed, Win10Ed, Win11Ed, Edition, key;

        public Form_Activate()
        {
            InitializeComponent();
        }

        private void comboBox_Windows_SelectedIndexChanged(object sender, EventArgs e)
        {
            Windows = comboBox_Windows.Text;

            comboBox_Blank.Visible = false;

            comboBox_8.Visible = false;
            comboBox_8.Enabled = false;

            comboBox_8p1.Visible = false;
            comboBox_8p1.Enabled = false;

            comboBox_10.Visible = false;
            comboBox_10.Enabled = false;

            comboBox_11.Visible = false;
            comboBox_11.Enabled = false;

            if (Windows == "8")
            {
                comboBox_8.Visible = true;
                comboBox_8.Enabled = true;
            }

            if (Windows == "8.1")
            {
                comboBox_8p1.Visible = true;
                comboBox_8p1.Enabled = true;
            }

            if (Windows == "10")
            {
                comboBox_10.Visible = true;
                comboBox_10.Enabled = true;
            }

            if (Windows == "11")
            {
                comboBox_11.Visible = true;
                comboBox_11.Enabled = true;
            }
        }

        private void comboBox_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Win8Ed = comboBox_8.Text;
            Activate();
        }

        private void comboBox_8p1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Win8p1Ed = comboBox_8p1.Text;
            Activate();
        }

        private void comboBox_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Win10Ed = comboBox_10.Text;
            Activate();
        }

        private void comboBox_11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Win11Ed = comboBox_11.Text;
            Activate();
        }

        private new void Activate()
        {
            label_Windows.Visible = false;

            comboBox_8.Visible = false;
            comboBox_8.Enabled = false;

            comboBox_8p1.Visible = false;
            comboBox_8p1.Enabled = false;

            comboBox_10.Visible = false;
            comboBox_10.Enabled = false;

            comboBox_11.Visible = false;
            comboBox_11.Enabled = false;

            comboBox_Windows.Visible = false;
            comboBox_Windows.Enabled = false;

            GenerateKey();
            InstallKey();
            KMS();
            FinalActivate();
        }

        private void InstallKey()
        {
            label_Windows.Text = "Installing Product Key!";
            cmd("/c slmgr /ipk " + key);
        }

        private void KMS()
        {
            label_Windows.Text = "Setting Key Management Service!";
            cmd("/c slmgr /skms kms8.msguides.com");
        }

        private void FinalActivate()
        {
            label_Windows.Text = "Activating Windows " + Windows + " " + Edition + "!";
            cmd("/c slmgr /ato");
            Application.Exit();
        }

        private void GenerateKey()
        {
            label_Windows.Padding = new Padding(0, 0, 0, 0); 
            label_Windows.Dock = DockStyle.Fill;
            label_Windows.Text = "Generating Product Key!";
            label_Windows.Visible = true;

            if (Windows == "8")
            {
                Edition = Win8Ed;
                if (Win8Ed == "Home")
                {
                    key = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
                }
                if (Win8Ed == "Home Single Language")
                {
                    key = "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
                }
                if (Win8Ed == "Professional")
                {
                    key = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                }
                if (Win8Ed == "Professional N")
                {
                    key = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                }
                if (Win8Ed == "Professional WMC")
                {
                    key = "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
                }
                if (Win8Ed == "Enterprice")
                {
                    key = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                }
                if (Win8Ed == "Enterprice N")
                {
                    key = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                }
            }

            if (Windows == "8.1")
            {
                Edition = Win8p1Ed;
                if (Win8p1Ed == "Home")
                {
                    key = "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
                }
                if (Win8p1Ed == "Home N")
                {
                    key = "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
                }
                if (Win8p1Ed == "Home Single Language")
                {
                    key = "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
                }
                if (Win8p1Ed == "Professional")
                {
                    key = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                }
                if (Win8p1Ed == "Professional N")
                {
                    key = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                }
                if (Win8p1Ed == "Professional WMC")
                {
                    key = "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
                }
                if (Win8p1Ed == "Enterprice")
                {
                    key = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                }
                if (Win8p1Ed == "Enterprice N")
                {
                    key = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                }
            }

            if (Windows == "10")
            {
                Edition = Win10Ed;
                if (Win10Ed == "Home")
                {
                    key = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (Win10Ed == "Home N")
                {
                    key = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                }
                if (Win10Ed == "Home Single Language")
                {
                    key = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                }
                if (Win10Ed == "Home Country Specific")
                {
                    key = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                }
                if (Win10Ed == "Professional")
                {
                    key = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (Win10Ed == "Professional N")
                {
                    key = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                }
                if (Win10Ed == "Education")
                {
                    key = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                }
                if (Win10Ed == "Education N")
                {
                    key = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                }
                if (Win10Ed == "Enterprice")
                {
                    key = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
                if (Win10Ed == "Enterprice N")
                {
                    key = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                }
            }

            if (Windows == "11")
            {
                Edition = Win11Ed;
                if (Win11Ed == "Home")
                {
                    key = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (Win11Ed == "Home N")
                {
                    key = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                }
                if (Win11Ed == "Home Single Language")
                {
                    key = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                }
                if (Win11Ed == "Home Country Specific")
                {
                    key = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                }
                if (Win11Ed == "Professional")
                {
                    key = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (Win11Ed == "Professional N")
                {
                    key = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                }
                if (Win11Ed == "Education")
                {
                    key = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                }
                if (Win11Ed == "Education N")
                {
                    key = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                }
                if (Win11Ed == "Enterprice")
                {
                    key = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
                if (Win11Ed == "Enterprice N")
                {
                    key = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                }
            }
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
