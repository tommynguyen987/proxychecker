using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace ProxyChecker
{
    public partial class Main : Form
    {
        Thread[] checkerThread;
        int checking;
        int beenChecked;
        private bool isRunning;
        private delegate void filterProxyHandler(int Index, bool Valid);
        private delegate void updateApplicationDel(string Status);

        public Main()
        {
            InitializeComponent();
            startButton.Enabled = stopButton.Enabled = saveButton.Enabled = clearButton.Enabled = clearButton2.Enabled = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var proxyCount = 0;
            var line = 0;
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Filter = "Text Files|*.txt|All Files|*.*";
                if (o.ShowDialog() == DialogResult.OK)
                {
                    var lines = File.ReadAllLines(o.FileName).Distinct().Where(l => l != string.Empty);
                    if (lines.Count() > 1)
                    {
                        proxyCount = lines.Count();
                        foreach (String s in lines)
                        {
                            try
                            {
                                proxyList.Items.Add(s);
                            }
                            catch
                            {
                                line++;
                            }
                            line++;
                            statusBox.Text = "On line: " + line + " out of: " + proxyCount;
                            Application.DoEvents();
                        }
                    }
                    else if (lines.Count() == 1)
                    {
                        proxyCount = File.ReadAllText(o.FileName).Split(',').Length;                       
                        try
                        {
                            var lists = File.ReadAllText(o.FileName).Split(',');
                            for (var i = 0; i < lists.Length; i++)
                            {
                                proxyList.Items.Add(lists[i]);
                                line++;
                            }
                        }
                        catch
                        {
                            line++;
                        }                        
                        statusBox.Text = "On line: " + line + " out of: " + proxyCount;
                        Application.DoEvents();                        
                    }
                    startButton.Enabled = clearButton.Enabled = true;
                    saveButton.Enabled = clearButton2.Enabled = false;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            proxyList.Items.Clear();
            startButton.Enabled = clearButton.Enabled = false;
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            checkedList.Items.Clear();
            saveButton.Enabled = clearButton2.Enabled = false;
            respondingLable.Text = "Responding proxies : 0";
        }

        #region Proxy Checking
        private void startButton_Click(object sender, EventArgs e)
        {
            checkerThread = new Thread[Convert.ToInt32(threadBox.Text)];
            checking = proxyList.Items.Count;
            statusBox.Text = "Starting to filter.";
            isRunning = true;
            beenChecked = 1;
            startButton.Enabled = loadButton.Enabled = clearButton.Enabled = clearButton2.Enabled = false;
            stopButton.Enabled = true;

            for (var i = 0; i <= Convert.ToInt32(threadBox.Text) - 1; i++)
            {
                var input = i;
                checkerThread[i] = new Thread(new ParameterizedThreadStart(checkProxys));
                checkerThread[i].Start(input);
            }
        }

        public void checkProxys(object Index)
        {
            var index = (int)Index;
            while (isRunning)
            {
                if (beenChecked >= checking)
                {
                    isRunning = false;
                    break;
                }
                if (index >= proxyList.Items.Count)
                {
                    checkerThread[index].Abort();
                    break;
                }                    

                var occoultProxy = proxyList.Items[index].ToString();
                object[] validArgs = {index, true};
                object[] invalidArgs = {index, false};
                try
                {
                    var proxy = new WebProxy(occoultProxy.Split(':')[0], Convert.ToInt32(occoultProxy.Split(':')[1]));
                    var web = WebRequest.Create(serverBox.Text.ToString());
                    web.Proxy = proxy;
                    web.Timeout = Convert.ToInt32(timeoutbox.Text);
                    Console.WriteLine(proxy.Address.ToString());
                    Console.WriteLine(web.RequestUri.AbsoluteUri.ToString());
                    web.GetResponse();
                    if (proxyList.InvokeRequired)
                        proxyList.Invoke(new filterProxyHandler(filterProxy), validArgs);
                    else
                        filterProxy(index, true);

                    if (statusBox.InvokeRequired)
                        statusBox.Invoke(new updateApplicationDel(updateApplication), "Processed " + beenChecked + " out of" + checking);
                    else
                        statusBox.Text = "Processed " + beenChecked + " out of" + checking;

                    beenChecked++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (proxyList.InvokeRequired)
                        proxyList.Invoke(new filterProxyHandler(filterProxy), invalidArgs);
                    else
                        filterProxy(index, false);

                    if (statusBox.InvokeRequired)
                       statusBox.Invoke(new updateApplicationDel(updateApplication), "Processed " + beenChecked + " out of" + checking);
                    else
                        statusBox.Text = "Processed " + beenChecked + " out of" + checking;

                    beenChecked++;                    
                }
            }
            checkerThread[1].Abort();
            loadButton.Enabled = true;
            stopButton.Enabled = false;
            saveButton.Enabled = clearButton2.Enabled = checkedList.Items.Count > 0;
        }
        void filterProxy(int index, bool Valid)
        {
            try
            {
                if (Valid) checkedList.Items.Add(proxyList.Items[index]);
                proxyList.Items.RemoveAt(index);
            }
            catch{}
        }   

        #endregion

        private void stopButton_Click(object sender, EventArgs e)
        {
            isRunning = stopButton.Enabled = false;
            loadButton.Enabled = true;

            for (var i = 0; i <= Convert.ToInt32(threadBox.Text) - 1; i++) {
                checkerThread[i].Abort();
            }
        }
        private void updateApplication(string status)
        {
            respondingLable.Text = "Responding proxies : " + checkedList.Items.Count.ToString();
            statusBox.Text = status;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {            
            using (var sF = new SaveFileDialog())
            {
                sF.Filter = "Text Files|*.txt|All Files|*.*";
                if (sF.ShowDialog() == DialogResult.OK)
                {
                    var proxyCount = checkedList.Items.Count;
                    foreach (var s in checkedList.Items)
                    {
                        try
                        {
                            File.WriteAllLines(sF.FileName, checkedList.Items.Cast<string>());
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString()); 
                        }
                    }                    
                }
            }
        }
    }
}
