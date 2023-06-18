using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LW31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeProcessList();
        }

        private void InitializeProcessList()
        {
            processListView.Items.Clear();
            processListView.Columns.Clear();
            processListView.Columns.Add("Process Name");
            processListView.Columns.Add("ID");
            processListView.Columns[0].Width = 450;
            processListView.Columns[1].Width = -2;
            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                processListView.Items.Add(item);
            }
        }

        private void processStopButton_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                int processId = int.Parse(processListView.SelectedItems[0].SubItems[1].Text);
                Process process = Process.GetProcessById(processId);

                try
                {
                    process.Kill();
                    MessageBox.Show("Process stopped successfully.", "Process Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error stopping process: " + ex.Message, "Process Manager",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshProcessList();
            }
        }

        private void processGetDetailsButton_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                string processName = selectedItem.Text;
                string processId = selectedItem.SubItems[1].Text;
                string processInfo = "Process Name: " + processName + Environment.NewLine + "Process ID: " + processId
                    + Environment.NewLine;
                MessageBox.Show(processInfo, "Process Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void processListRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void processListExportButton_Click(object sender, EventArgs e)
        {
            if (processListView.Items.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.Title = "Export Process List";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            foreach (ListViewItem item in processListView.Items)
                            {
                                writer.WriteLine(item.Text + " (Process ID: " + item.SubItems[1].Text + ")");
                            }
                        }
                        MessageBox.Show("Process list exported successfully.", "Process Manager", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
