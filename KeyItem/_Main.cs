using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace KeyItem
{
    public partial class _Main : Form
    {
        public _Main()
        {
            InitializeComponent();
        }
        #region Device
      
        private void GetItemCodes()
        {


            //web http://keyword.gg.in.th/
            //ตั้งค่าให้google ซ่อนไว้จะได้ไม่รกจอ
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("headless");
            var hidese = EdgeDriverService.CreateDefaultService();
            hidese.HideCommandPromptWindow = true;
            EdgeDriver driver = new EdgeDriver(hidese, options);

            //



            try
            {
                rtb_01.Clear();
                rtb_01.AppendText("กำลังเริ่มรอสักครู่"+ Environment.NewLine);
                rtb_01.ScrollToCaret();
               
                driver.Navigate().GoToUrl("http://keyword.gg.in.th/");
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} โหลดข้อมูลหน้าเว็ป " + Environment.NewLine);
                rtb_01.ScrollToCaret();

                IWebElement OpenCode = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[12]/div[1]/div[3]/a"));
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} กำลังโหลดไอเทมโค๊ดรายวัน " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                OpenCode.Click();


                //กลับไปหน้าเดิมเพื่อเปิดโค๊ด
                driver.Navigate().GoToUrl("http://keyword.gg.in.th/");
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} โหลดหน้าคีย์ไอเทม " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                //ก๊อปปี้โค๊ด
                IWebElement Codekeyday = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[12]/div[1]/div[3]/div[1]"));
                string keyday = Codekeyday.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์รายวัน {Codekeyday.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_keyDay.Text = keyday;

                IWebElement Key0 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[11]/div[1]/div[3]/div[1]"));
                string key_0 = Key0.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 0 นาที {Key0.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_0.Text = key_0;

                IWebElement Key60 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[10]/div[1]/div[3]/div[1]"));
                string key_60 = Key60.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 60 นาที {Key60.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_60.Text = key_60;

                IWebElement key120 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[9]/div[1]/div[3]/div[1]"));
                string key_120 = key120.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 120 นาที {key120.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_120.Text = key_120;

                IWebElement key180 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[8]/div[1]/div[3]/div[1]"));
                string key_180 = key180.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 180 นาที {key180.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_180.Text = key_180;

                IWebElement key240 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[7]/div[1]/div[3]/div[1]"));
                string key_240 = key240.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 240 นาที {key240.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_240.Text = key_240;

                IWebElement key300 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[6]/div[1]/div[3]/div[1]"));
                string key_300 = key300.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 300 นาที {key300.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_300.Text = key_300;

                IWebElement key360 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[5]/div[1]/div[3]/div[1]"));
                string key_360 = key360.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 360 นาที {key360.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_360.Text = key_360;

                IWebElement key420 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[4]/div[1]/div[3]/div[1]"));
                string key_420 = key420.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 420 นาที {key420.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_420.Text = key_420;

                IWebElement key480 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[3]/div[1]/div[3]/div[1]"));
                string key_480 = key480.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 480 นาที {key480.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_480.Text = key_480;

                IWebElement key540 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[2]/div[1]/div[3]/div[1]"));
                string key_540 = key540.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 540 นาที {key540.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_540.Text = key_540;

                IWebElement key600 = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div[1]/div[1]/div[3]/div[1]"));
                string key_600 = key600.Text;
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} คีย์ 600 นาที {key600.Text} " + Environment.NewLine);
                rtb_01.ScrollToCaret();
                txt_600.Text = key_600;
            }
            catch (NoAlertPresentException)
            {

            }
            catch (Exception)
            {
                //MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} เกิดข้อผิดพลาด ไม่สามารถเข้าถึงข้อมูลได้ " + Environment.NewLine);
                rtb_01.ScrollToCaret();
            }
            finally
            {
                try
                {
                    // ตรวจสอบว่ามี Alert หรือไม่
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    //alert.Accept();
                    //MessageBox.Show("มีข้อความแจ้งเตือน: " + alertText, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} ข้อผิดพลาด {alertText} " + Environment.NewLine);
                    rtb_01.ScrollToCaret();

                }
                catch (NoAlertPresentException)
                {
                    // หากไม่มี Alert ให้ทำการข้ามส่วนนี้ไป

                }
                finally
                {

                    driver.Quit();
                    DateTime currentTime = DateTime.Now;
                    DayOfWeek currentDay = currentTime.DayOfWeek;
                    txt_time.Text = currentTime.ToString("yyy-MM-dd");
                    rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} เสร็จสิ้น " + Environment.NewLine);
                    rtb_01.ScrollToCaret();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }

        }
        public void Loads()
        {
            //โหลดคีย์เวิดที่เคยบันทึกไว้
 
        
            txt_time.Text = KeyItem.Properties.Settings.Default.Time;
            txt_keyDay.Text = KeyItem.Properties.Settings.Default.keyDay;
            txt_0.Text = KeyItem.Properties.Settings.Default.k_0;
            txt_60.Text = KeyItem.Properties.Settings.Default.K_60;
            txt_120.Text = KeyItem.Properties.Settings.Default.K_120;
            txt_180.Text = KeyItem.Properties.Settings.Default.K_180;
            txt_240.Text = KeyItem.Properties.Settings.Default.K_240;
            txt_300.Text = KeyItem.Properties.Settings.Default.K_300;
            txt_360.Text = KeyItem.Properties.Settings.Default.K_360;
            txt_420.Text = KeyItem.Properties.Settings.Default.K_420;
            txt_480.Text = KeyItem.Properties.Settings.Default.K_480;
            txt_540.Text = KeyItem.Properties.Settings.Default.K_540;
            txt_600.Text = KeyItem.Properties.Settings.Default.K_600;
            


        }
        public void SaveSettings()
        {

            //เซฟคีย์เวิร์ดที่ ดึงมาจากหน้าเว็ป

            //itemCode.Properties.Settings.Default.Username01 = txt_Username.Text;
            //itemCode.Properties.Settings.Default.Password01 = txt_Password.Text;


            //
            
            KeyItem.Properties.Settings.Default.Time = txt_time.Text;
            KeyItem.Properties.Settings.Default.keyDay = txt_keyDay.Text;
            KeyItem.Properties.Settings.Default.k_0 = txt_0.Text;
            KeyItem.Properties.Settings.Default.K_60 = txt_60.Text;
            KeyItem.Properties.Settings.Default.K_120 = txt_120.Text;
            KeyItem.Properties.Settings.Default.K_180 = txt_180.Text;
            KeyItem.Properties.Settings.Default.K_240 = txt_240.Text;
            KeyItem.Properties.Settings.Default.K_300 = txt_300.Text;
            KeyItem.Properties.Settings.Default.K_360 = txt_360.Text;
            KeyItem.Properties.Settings.Default.K_420 = txt_420.Text;
            KeyItem.Properties.Settings.Default.K_480 = txt_480.Text;
            KeyItem.Properties.Settings.Default.K_540 = txt_540.Text;
            KeyItem.Properties.Settings.Default.K_600 = txt_600.Text;
            KeyItem.Properties.Settings.Default.Save();

        }
        #endregion
        private void _Main_Load(object sender, EventArgs e)
        {
           
            Loads();

        }

        private void _Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            
        }

        private void หนาEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome", "http://member.sf.in.th/EventCenter/");
        }

        private void aAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(
               $"Day = {txt_time.Text}\n\n" +
               $"Key = {txt_keyDay.Text}\n " +
               $"0   = {txt_0.Text}\n" +
               $"60  = {txt_60.Text}\n" +
               $"120 = {txt_120.Text}\n" +
               $"180 = {txt_180.Text}\n" +
               $"240 = {txt_240.Text}\n" +
               $"300 = {txt_300.Text}\n" +
               $"360 = {txt_360.Text}\n" +
               $"420 = {txt_420.Text}\n" +
               $"480 = {txt_480.Text}\n" +
               $"540 = {txt_540.Text}\n" +
               $"600 = {txt_600.Text}\n"
               );
        }

        private void bw_01_DoWork(object sender, DoWorkEventArgs e)
        {
           
            string task = (string)e.Argument;
            switch (task)
            {
                case "GetItemcode":
                    GetItemCodes();
                    break;  
                default:
                    throw new ArgumentException("Invalid task");
            }
        }

        private void ดงไอเทมโคดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!bw_01.IsBusy)
            {
                bw_01.RunWorkerAsync("GetItemcode");
            }
            else
            {
                logmessge("กำลังดำเนินการอยู่รอสักครู่");
            }
        }
        private void logmessge(string message)
        {
            rtb_01.AppendText($"{DateTime.Now.ToString("hh:mm:ss")} {message}");
            rtb_01.ScrollToCaret();
           
        }
        private void bw_01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("ดึงคีย์รายวันเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "https://auth.gg.in.th/authenticate_v3/Auth_Full/Login.aspx?appid=1&scope=&state=1&sourceid=1&redirecturi=https://sf.gg.in.th/newauthen/landingplatform.aspx&fblogin=true");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome", "https://www.facebook.com/PLAMSsE/");
        }
    }
}
