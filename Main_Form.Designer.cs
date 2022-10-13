namespace RTWS
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.computer_listbox = new System.Windows.Forms.ListBox();
            this.computer_listbox_remove_selected_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.add_computer_export_powershell_format_button = new System.Windows.Forms.Button();
            this.add_computer_textbox = new System.Windows.Forms.TextBox();
            this.add_computer_button = new System.Windows.Forms.Button();
            this.add_computer_import_from_txt_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.service_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.computer_not_reached_listbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_results_to_txt_button = new System.Windows.Forms.Button();
            this.clear_results_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.service_installed_state_listbox = new System.Windows.Forms.ListBox();
            this.service_not_running_state_listbox = new System.Windows.Forms.ListBox();
            this.service_not_installed_state_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ad_username_textbox = new System.Windows.Forms.TextBox();
            this.ad_query_button = new System.Windows.Forms.Button();
            this.ad_password_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad_dc_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.computer_listbox);
            this.groupBox2.Controls.Add(this.computer_listbox_remove_selected_button);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 379);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computers";
            // 
            // computer_listbox
            // 
            this.computer_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_listbox.FormattingEnabled = true;
            this.computer_listbox.ItemHeight = 17;
            this.computer_listbox.Location = new System.Drawing.Point(6, 19);
            this.computer_listbox.Name = "computer_listbox";
            this.computer_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.computer_listbox.Size = new System.Drawing.Size(286, 310);
            this.computer_listbox.TabIndex = 3;
            // 
            // computer_listbox_remove_selected_button
            // 
            this.computer_listbox_remove_selected_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.computer_listbox_remove_selected_button.Location = new System.Drawing.Point(6, 335);
            this.computer_listbox_remove_selected_button.Name = "computer_listbox_remove_selected_button";
            this.computer_listbox_remove_selected_button.Size = new System.Drawing.Size(286, 29);
            this.computer_listbox_remove_selected_button.TabIndex = 10;
            this.computer_listbox_remove_selected_button.Text = "Remove selected";
            this.computer_listbox_remove_selected_button.UseVisualStyleBackColor = true;
            this.computer_listbox_remove_selected_button.Click += new System.EventHandler(this.computer_listbox_remove_selected_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.add_computer_export_powershell_format_button);
            this.groupBox3.Controls.Add(this.add_computer_textbox);
            this.groupBox3.Controls.Add(this.add_computer_button);
            this.groupBox3.Controls.Add(this.add_computer_import_from_txt_button);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 158);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add computer";
            // 
            // add_computer_export_powershell_format_button
            // 
            this.add_computer_export_powershell_format_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_computer_export_powershell_format_button.Location = new System.Drawing.Point(6, 120);
            this.add_computer_export_powershell_format_button.Name = "add_computer_export_powershell_format_button";
            this.add_computer_export_powershell_format_button.Size = new System.Drawing.Size(286, 29);
            this.add_computer_export_powershell_format_button.TabIndex = 8;
            this.add_computer_export_powershell_format_button.Text = "Export powershell format";
            this.add_computer_export_powershell_format_button.UseVisualStyleBackColor = true;
            this.add_computer_export_powershell_format_button.Click += new System.EventHandler(this.add_computer_export_powershell_format_button_Click);
            // 
            // add_computer_textbox
            // 
            this.add_computer_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_computer_textbox.Location = new System.Drawing.Point(6, 19);
            this.add_computer_textbox.Name = "add_computer_textbox";
            this.add_computer_textbox.Size = new System.Drawing.Size(286, 25);
            this.add_computer_textbox.TabIndex = 4;
            this.add_computer_textbox.Text = "Enter name here";
            this.add_computer_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_computer_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_computer_textbox_MouseClick);
            // 
            // add_computer_button
            // 
            this.add_computer_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_computer_button.Location = new System.Drawing.Point(6, 50);
            this.add_computer_button.Name = "add_computer_button";
            this.add_computer_button.Size = new System.Drawing.Size(286, 29);
            this.add_computer_button.TabIndex = 5;
            this.add_computer_button.Text = "Add computer";
            this.add_computer_button.UseVisualStyleBackColor = true;
            this.add_computer_button.Click += new System.EventHandler(this.add_computer_button_Click);
            // 
            // add_computer_import_from_txt_button
            // 
            this.add_computer_import_from_txt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_computer_import_from_txt_button.Location = new System.Drawing.Point(6, 85);
            this.add_computer_import_from_txt_button.Name = "add_computer_import_from_txt_button";
            this.add_computer_import_from_txt_button.Size = new System.Drawing.Size(286, 29);
            this.add_computer_import_from_txt_button.TabIndex = 7;
            this.add_computer_import_from_txt_button.Text = "Import from TXT";
            this.add_computer_import_from_txt_button.UseVisualStyleBackColor = true;
            this.add_computer_import_from_txt_button.Click += new System.EventHandler(this.add_computer_import_from_txt_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.service_textbox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.computer_not_reached_listbox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.save_results_to_txt_button);
            this.groupBox4.Controls.Add(this.clear_results_button);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.service_installed_state_listbox);
            this.groupBox4.Controls.Add(this.service_not_running_state_listbox);
            this.groupBox4.Controls.Add(this.service_not_installed_state_listbox);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(316, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1022, 662);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result Overview";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Service:";
            // 
            // service_textbox
            // 
            this.service_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.service_textbox.Location = new System.Drawing.Point(66, 628);
            this.service_textbox.Name = "service_textbox";
            this.service_textbox.Size = new System.Drawing.Size(274, 25);
            this.service_textbox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(809, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Computer not available.";
            // 
            // computer_not_reached_listbox
            // 
            this.computer_not_reached_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.computer_not_reached_listbox.FormattingEnabled = true;
            this.computer_not_reached_listbox.HorizontalScrollbar = true;
            this.computer_not_reached_listbox.ItemHeight = 17;
            this.computer_not_reached_listbox.Location = new System.Drawing.Point(765, 37);
            this.computer_not_reached_listbox.Name = "computer_not_reached_listbox";
            this.computer_not_reached_listbox.Size = new System.Drawing.Size(247, 582);
            this.computer_not_reached_listbox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(569, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Service don\'t exists.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Service exists but is not running.";
            // 
            // save_results_to_txt_button
            // 
            this.save_results_to_txt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.save_results_to_txt_button.Location = new System.Drawing.Point(440, 625);
            this.save_results_to_txt_button.Name = "save_results_to_txt_button";
            this.save_results_to_txt_button.Size = new System.Drawing.Size(285, 29);
            this.save_results_to_txt_button.TabIndex = 11;
            this.save_results_to_txt_button.Text = "Export results to TXT";
            this.save_results_to_txt_button.UseVisualStyleBackColor = true;
            this.save_results_to_txt_button.Click += new System.EventHandler(this.save_results_to_txt_button_Click);
            // 
            // clear_results_button
            // 
            this.clear_results_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.clear_results_button.Location = new System.Drawing.Point(731, 625);
            this.clear_results_button.Name = "clear_results_button";
            this.clear_results_button.Size = new System.Drawing.Size(285, 29);
            this.clear_results_button.TabIndex = 22;
            this.clear_results_button.Text = "Clear Results";
            this.clear_results_button.UseVisualStyleBackColor = true;
            this.clear_results_button.Click += new System.EventHandler(this.clear_results_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Service found and running.";
            // 
            // service_installed_state_listbox
            // 
            this.service_installed_state_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.service_installed_state_listbox.FormattingEnabled = true;
            this.service_installed_state_listbox.HorizontalScrollbar = true;
            this.service_installed_state_listbox.ItemHeight = 17;
            this.service_installed_state_listbox.Location = new System.Drawing.Point(6, 36);
            this.service_installed_state_listbox.Name = "service_installed_state_listbox";
            this.service_installed_state_listbox.Size = new System.Drawing.Size(247, 582);
            this.service_installed_state_listbox.TabIndex = 6;
            // 
            // service_not_running_state_listbox
            // 
            this.service_not_running_state_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.service_not_running_state_listbox.FormattingEnabled = true;
            this.service_not_running_state_listbox.HorizontalScrollbar = true;
            this.service_not_running_state_listbox.ItemHeight = 17;
            this.service_not_running_state_listbox.Location = new System.Drawing.Point(259, 36);
            this.service_not_running_state_listbox.Name = "service_not_running_state_listbox";
            this.service_not_running_state_listbox.Size = new System.Drawing.Size(247, 582);
            this.service_not_running_state_listbox.TabIndex = 21;
            // 
            // service_not_installed_state_listbox
            // 
            this.service_not_installed_state_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.service_not_installed_state_listbox.FormattingEnabled = true;
            this.service_not_installed_state_listbox.HorizontalScrollbar = true;
            this.service_not_installed_state_listbox.ItemHeight = 17;
            this.service_not_installed_state_listbox.Location = new System.Drawing.Point(512, 37);
            this.service_not_installed_state_listbox.Name = "service_not_installed_state_listbox";
            this.service_not_installed_state_listbox.Size = new System.Drawing.Size(247, 582);
            this.service_not_installed_state_listbox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ad_username_textbox);
            this.groupBox1.Controls.Add(this.ad_query_button);
            this.groupBox1.Controls.Add(this.ad_password_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ad_dc_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 156);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import computers from active directory";
            // 
            // ad_username_textbox
            // 
            this.ad_username_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ad_username_textbox.Location = new System.Drawing.Point(84, 57);
            this.ad_username_textbox.Name = "ad_username_textbox";
            this.ad_username_textbox.Size = new System.Drawing.Size(208, 25);
            this.ad_username_textbox.TabIndex = 15;
            // 
            // ad_query_button
            // 
            this.ad_query_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ad_query_button.Location = new System.Drawing.Point(6, 119);
            this.ad_query_button.Name = "ad_query_button";
            this.ad_query_button.Size = new System.Drawing.Size(286, 29);
            this.ad_query_button.TabIndex = 12;
            this.ad_query_button.Text = "Query";
            this.ad_query_button.UseVisualStyleBackColor = true;
            this.ad_query_button.Click += new System.EventHandler(this.ad_query_button_Click);
            // 
            // ad_password_textbox
            // 
            this.ad_password_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ad_password_textbox.Location = new System.Drawing.Point(84, 88);
            this.ad_password_textbox.Name = "ad_password_textbox";
            this.ad_password_textbox.Size = new System.Drawing.Size(208, 25);
            this.ad_password_textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Domain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password:";
            // 
            // ad_dc_textbox
            // 
            this.ad_dc_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ad_dc_textbox.Location = new System.Drawing.Point(70, 26);
            this.ad_dc_textbox.Name = "ad_dc_textbox";
            this.ad_dc_textbox.Size = new System.Drawing.Size(222, 25);
            this.ad_dc_textbox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Username:";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.start_button.Location = new System.Drawing.Point(316, 680);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(1022, 29);
            this.start_button.TabIndex = 113;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1153, 712);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 13);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/0x100001/RTWS";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTWS - Remote test windows services";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox add_computer_textbox;
        private System.Windows.Forms.Button add_computer_button;
        private System.Windows.Forms.Button add_computer_import_from_txt_button;
        private System.Windows.Forms.ListBox computer_listbox;
        private System.Windows.Forms.Button computer_listbox_remove_selected_button;
        private System.Windows.Forms.Button add_computer_export_powershell_format_button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox computer_not_reached_listbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox service_installed_state_listbox;
        private System.Windows.Forms.Button save_results_to_txt_button;
        private System.Windows.Forms.ListBox service_not_running_state_listbox;
        private System.Windows.Forms.ListBox service_not_installed_state_listbox;
        private System.Windows.Forms.Button clear_results_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ad_username_textbox;
        private System.Windows.Forms.Button ad_query_button;
        private System.Windows.Forms.TextBox ad_password_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad_dc_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox service_textbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

