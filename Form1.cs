using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deleteAllFile
{
    public partial class Form1 : Form
    {
        FileSystemWatcher w = new FileSystemWatcher();
        FileSystemWatcher wchk = new FileSystemWatcher();
        int i = 1;
        string allNotify = "";
        public Form1()
        {
            InitializeComponent();
            txtPath.Text = File.ReadAllText("Common/SourcePath.ini");
            MonitorFile(txtPath.Text);
            timer1.Interval = Int32.Parse(txtAutoEnter.Text);
            timer1.Start();
        }

        private void MonitorFile(string path)
        {
            //.dat
            w.Path = path;
            w.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security;
            w.Filter = "*.dat";
            w.IncludeSubdirectories = true;
            w.Changed += new FileSystemEventHandler(W_Changed);
            w.Created += new FileSystemEventHandler(W_Created);
            w.Deleted += new FileSystemEventHandler(W_Deleted);;
            w.Error += W_Error;
            w.EnableRaisingEvents = true;

            //.chk
            wchk.Path = path;
            wchk.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security;
            wchk.Filter = "*.chk";
            wchk.IncludeSubdirectories = true;
            wchk.Changed += new FileSystemEventHandler(W_Changed);
            wchk.Created += new FileSystemEventHandler(W_Created);
            wchk.Deleted += new FileSystemEventHandler(W_Deleted); ;
            wchk.Error += W_Error;
            wchk.EnableRaisingEvents = true;
        }

        private void W_Error(object sender, ErrorEventArgs e)
        {
            PrintException(e.GetException());
        }

        private static void PrintException(Exception ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }

        private void W_Deleted(object sender, FileSystemEventArgs e)
        {
            string name = e.Name;
            Invoke(new MethodInvoker(() => {
                if (name != "Pos\\FromPos.dat")
                {
                    txtNotify.AppendText("Delete  " + name + Environment.NewLine);
                    allNotify=txtNotify.Text;
                    timer1.Stop();
                    timer1.Start();
                }
                else
                    txtFromPos.AppendText("Delete  " + name + Environment.NewLine);
            }));
        }

        private void W_Created(object sender, FileSystemEventArgs e)
        {
            string name = e.Name;
            Invoke(new MethodInvoker(() => {
                if (name != "Pos\\FromPos.dat")
                {
                    txtNotify.AppendText("Create  " + name + Environment.NewLine);
                    allNotify = txtNotify.Text;
                    timer1.Stop();
                    timer1.Start();
                }
                else
                    txtFromPos.AppendText("Create  " + name + Environment.NewLine);
            }));
        }

        private void W_Changed(object sender, FileSystemEventArgs e)
        {
            string name = e.Name;
            Invoke(new MethodInvoker(() => {
                if (name != "Pos\\FromPos.dat")
                {
                    txtNotify.AppendText("Change  " + name + Environment.NewLine);
                    allNotify = txtNotify.Text;
                    timer1.Stop();
                    timer1.Start();
                }
                else
                    txtFromPos.AppendText("Change  " + name + Environment.NewLine);
            }));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDelete.Text = "";
            txtNotFound.Text = "";

            List<string> listDelete = new List<string>();

            string folderPath = txtPath.Text;
            if (ckbCancelMode.Checked) listDelete.Add(@"CreditNFC\CancelMode.chk");
            if (ckbLastOutputId.Checked) listDelete.Add(@"CreditNFC\LastOutputId.dat");
            if (ckbLastSettlementBrandCode.Checked) listDelete.Add(@"CreditNFC\LastSettlementBrandCode.dat");
            if (ckbLastSettlementSeqNo.Checked) listDelete.Add(@"CreditNFC\LastSettlementSeqNo.dat");
            if (ckbLastTransactionInquiry.Checked) listDelete.Add(@"CreditNFC\LastTransactionInquiry.dat");
            if (ckbJournal.Checked) listDelete.Add(@"CreditNFC\transaction_data\Journal.dat");
            if (ckbtoPos.Checked) listDelete.Add(@"Pos\toPos.dat");

            //Add UnionPay
            if (ckbCancelMode.Checked) listDelete.Add(@"UnionPay\CancelMode.chk");
            if (ckbLastOutputId.Checked) listDelete.Add(@"UnionPay\LastOutputId.dat");
            if (ckbLastSettlementBrandCode.Checked) listDelete.Add(@"UnionPay\LastSettlementBrandCode.dat");
            if (ckbLastSettlementSeqNo.Checked) listDelete.Add(@"UnionPay\LastSettlementSeqNo.dat");
            if (ckbLastTransactionInquiry.Checked) listDelete.Add(@"UnionPay\LastTransactionInquiry.dat");
            if (ckbJournal.Checked) listDelete.Add(@"UnionPay\transaction_data\Journal.dat");


            //Add QR Code
            if (ckbCancelMode.Checked) listDelete.Add(@"QRPayment\CancelMode.chk");
            if (ckbLastOutputId.Checked) listDelete.Add(@"QRPayment\LastOutputId.dat");
            if (ckbLastSettlementBrandCode.Checked) listDelete.Add(@"QRPayment\LastSettlementBrandCode.dat");
            if (ckbLastSettlementSeqNo.Checked) listDelete.Add(@"QRPayment\LastSettlementSeqNo.dat");
            if (ckbLastTransactionInquiry.Checked) listDelete.Add(@"QRPayment\LastTransactionInquiry.dat");
            if (ckbJournal.Checked) listDelete.Add(@"QRPayment\transaction_data\Journal.dat");

            if (ckbLastPosTranNum.Checked) listDelete.Add(@"QRPayment\LastPosTranNum.dat");
            if (ckbLastSettlementServiceCode.Checked) listDelete.Add(@"QRPayment\LastSettlementServiceCode.dat");
            if (ckbLastTransactionSummaryId.Checked) listDelete.Add(@"QRPayment\LastTransactionSummaryId.dat");
            if (ckbPTR.Checked) listDelete.AddRange(Directory.GetFiles("C:\\WEBPOS\\WPSaturnCredit\\Pos\\", "*.dat", SearchOption.AllDirectories));

            Console.WriteLine("Files to delete: " + string.Join(", ", listDelete));
            foreach (string file in listDelete)
            {
                Console.WriteLine(file);
            }


            foreach (string file in listDelete)
            {
                string filePath = folderPath + "\\\\" + file;
                Console.WriteLine("Deleting file: " + filePath);
                if (deleteFile(filePath))
                {
                    txtDelete.AppendText(file + Environment.NewLine);
                }
                else
                {
                    deleteFile(file);
                    txtNotFound.AppendText(file + Environment.NewLine);
                }
            }


            if (ckbLog.Checked)
            {
                string Log = folderPath + @"\Log";
                string[] logFiles = Directory.GetFiles(Log);
                if (logFiles.Length != 0)
                    foreach (string file in logFiles)
                    {
                        if (deleteFile(file)) txtDelete.AppendText(file + Environment.NewLine);
                    }
                else
                    txtNotFound.AppendText("Log file" + Environment.NewLine);
            }

            if (ckbWPSaturnEMoney.Checked)
                KillProcess("WPSaturnEMoney");

            if (ckbWPSaturnCredit.Checked)
                KillProcess("WPSaturnCredit");

            txtNotify.Text = "";
            txtFromPos.Text = "";
            i = 1;
        }

        private bool deleteFile(string path)
        {
            if (Exists(path))
            {
                File.Delete(path);
                return true;
            }
            return false;
        }

        private bool Exists(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }

        public void KillProcess(string name)
        {
            Process[] Emoney =  Process.GetProcessesByName(name);
            if (Emoney.Length != 0)
                foreach (Process proc in Emoney)
                {
                    txtDelete.AppendText(Environment.NewLine + "process " + proc.ProcessName + Environment.NewLine);
                    proc.Kill();
                }
            else
            {
                txtNotFound.AppendText("No process " + name + Environment.NewLine);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string[] lines = txtNotify.Lines;
                var list = lines.Where(x => x.ToLower().Contains(txtSearch.Text.ToLower()));
                txtNotify.Lines = list.ToArray();
            }
            else
            {
                txtNotify.Text = allNotify;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNotify.AppendText(i++.ToString() + ".---------------------------------------------------------"+ Environment.NewLine );
            timer1.Interval = Int32.Parse(txtAutoEnter.Text);
            timer1.Stop();
        }


    }
}
