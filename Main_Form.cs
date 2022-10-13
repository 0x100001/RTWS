using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.DirectoryServices;
using System.ServiceProcess;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace RTWS
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void add_computer_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_computer_textbox.Text == "Enter name here")
                add_computer_textbox.Clear();
        }

        private void add_computer_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(add_computer_textbox.Text) == false && computer_listbox.Items.Contains(add_computer_textbox.Text))
                computer_listbox.Items.Add(add_computer_textbox.Text);
        }

        private void computer_listbox_remove_selected_button_Click(object sender, EventArgs e)
        {
            List<string> computer_list = new List<string> { };

            foreach (string computer in computer_listbox.SelectedItems)
                computer_list.Add(computer);

            foreach (string computer in computer_list)
                computer_listbox.Items.Remove(computer);
        }

        private void add_computer_import_from_txt_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open Text File";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var line in File.ReadLines(openFileDialog.FileName))
                    {
                        if (computer_listbox.Items.Contains(line) == false)
                            computer_listbox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_computer_export_powershell_format_button_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + @"\computer_ps_export.txt";

                if (File.Exists(path))
                    File.Delete(path);

                using (FileStream S = File.Open(Application.StartupPath + @"\computer_ps_export.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in computer_listbox.Items)
                            st.Write("'" + aa.ToString() + "',");
                    }
                }

                MessageBox.Show("Exported to: " + path, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_results_button_Click(object sender, EventArgs e)
        {
            service_installed_state_listbox.Items.Clear();
            service_not_running_state_listbox.Items.Clear();
            service_not_installed_state_listbox.Items.Clear();
            computer_not_reached_listbox.Items.Clear();
        }

        private void save_results_to_txt_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\service_installed_results.txt"))
                    File.Delete(Application.StartupPath + @"\service_installed_results.txt");

                if (File.Exists(Application.StartupPath + @"\service_installed_not_running_results.txt"))
                    File.Delete(Application.StartupPath + @"\service_installed_not_running_results.txt");

                if (File.Exists(Application.StartupPath + @"\service_not_found_results.txt"))
                    File.Delete(Application.StartupPath + @"\service_not_found_results.txt");

                if (File.Exists(Application.StartupPath + @"\computer_not_available.txt"))
                    File.Delete(Application.StartupPath + @"\computer_not_available.txt");

                using (FileStream S = File.Open(Application.StartupPath + @"\service_installed_results.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in service_installed_state_listbox.Items)
                            st.WriteLine(aa.ToString());
                    }
                }

                using (FileStream S = File.Open(Application.StartupPath + @"\service_installed_not_running_results.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in service_not_running_state_listbox.Items)
                            st.WriteLine(aa.ToString());
                    }
                }

                using (FileStream S = File.Open(Application.StartupPath + @"\service_not_found_results.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in service_not_installed_state_listbox.Items)
                            st.WriteLine(aa.ToString());
                    }
                }

                using (FileStream S = File.Open(Application.StartupPath + @"\computer_not_available.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in computer_not_reached_listbox.Items)
                            st.WriteLine(aa.ToString());
                    }
                }

                MessageBox.Show("Exported to: " + Environment.NewLine + 
                    Application.StartupPath + ":" + Environment.NewLine + Environment.NewLine + 
                    Application.StartupPath + @"\service_installed_results.txt" + Environment.NewLine + Environment.NewLine +
                    Application.StartupPath + @"\service_installed_not_running_results.txt" + Environment.NewLine + Environment.NewLine +
                    Application.StartupPath + @"\service_not_found_results.txt" + Environment.NewLine + Environment.NewLine +
                    Application.StartupPath + @"\computer_not_available.txt"                    
                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ad_query_button_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryEntry startingPoint = new DirectoryEntry("LDAP://" + ad_dc_textbox.Text, ad_username_textbox.Text, ad_password_textbox.Text);
                DirectorySearcher searcher = new DirectorySearcher(startingPoint);
                searcher.Filter = "(objectCategory=computer)";

                foreach (SearchResult res in searcher.FindAll())
                {
                    string item = res.Properties["name"][0].ToString();

                    if (computer_listbox.Items.Contains(item) == false)
                        computer_listbox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            ad_dc_textbox.Text = Environment.UserDomainName;
            ad_username_textbox.Text = Environment.UserName;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            service_installed_state_listbox.Items.Clear();

            foreach (var listBoxItem in computer_listbox.Items)
            {
                try
                {
                    Ping ping = new Ping();
                    if (ping.Send(listBoxItem.ToString(), 500).Status == IPStatus.Success)
                    {
                        try
                        {
                            ServiceController sc = new ServiceController(service_textbox.Text, listBoxItem.ToString());
                            if (sc.Status.Equals(ServiceControllerStatus.Running))
                                service_installed_state_listbox.Items.Add(listBoxItem);

                            if (sc.Status.Equals(ServiceControllerStatus.Stopped) || sc.Status.Equals(ServiceControllerStatus.StopPending))
                                service_not_running_state_listbox.Items.Add(listBoxItem);
                        }
                        catch
                        {
                            service_not_installed_state_listbox.Items.Add(listBoxItem);
                        }
                    }
                    else
                        computer_not_reached_listbox.Items.Add(listBoxItem);
                }
                catch
                {
                    computer_not_reached_listbox.Items.Add(listBoxItem);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/0x100001/RTWS");
        }
    }
}
