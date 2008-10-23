﻿namespace Waddu.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReloadLocalAddons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWadduAllAddons = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAddon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCheckSingleAddon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWadduSingleAddon = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxThread = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAbortThread = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerEx2 = new Waddu.Controls.SplitContainerEx();
            this.splitContainerEx1 = new Waddu.Controls.SplitContainerEx();
            this.gbAddons = new System.Windows.Forms.GroupBox();
            this.dgvAddons = new System.Windows.Forms.DataGridView();
            this.tsAddon = new System.Windows.Forms.ToolStrip();
            this.tsddFilter = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiFilterInstalled = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterNotInstalled = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterSubAddons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterBlizzard = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddonDetails = new System.Windows.Forms.GroupBox();
            this.txtLocalVersion = new System.Windows.Forms.TextBox();
            this.lblLocalVersion = new System.Windows.Forms.Label();
            this.gbMappings = new System.Windows.Forms.GroupBox();
            this.dgvMappings = new System.Windows.Forms.DataGridView();
            this.gbSubAddons = new System.Windows.Forms.GroupBox();
            this.lbSubAddons = new System.Windows.Forms.ListBox();
            this.linkDownload = new System.Windows.Forms.LinkLabel();
            this.linkInfo = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.splitContainerEx3 = new Waddu.Controls.SplitContainerEx();
            this.dgvThreadActivity = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.dgcTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsLog = new System.Windows.Forms.ToolStrip();
            this.tsddLogLevel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLogDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogError = new System.Windows.Forms.ToolStripMenuItem();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.ctxAddon.SuspendLayout();
            this.ctxLog.SuspendLayout();
            this.ctxThread.SuspendLayout();
            this.splitContainerEx2.Panel1.SuspendLayout();
            this.splitContainerEx2.Panel2.SuspendLayout();
            this.splitContainerEx2.SuspendLayout();
            this.splitContainerEx1.Panel1.SuspendLayout();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            this.gbAddons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddons)).BeginInit();
            this.tsAddon.SuspendLayout();
            this.gbAddonDetails.SuspendLayout();
            this.gbMappings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).BeginInit();
            this.gbSubAddons.SuspendLayout();
            this.splitContainerEx3.Panel1.SuspendLayout();
            this.splitContainerEx3.Panel2.SuspendLayout();
            this.splitContainerEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreadActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.tsLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiAddons});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(116, 22);
            this.tsmiSettings.Text = "&Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(116, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiAddons
            // 
            this.tsmiAddons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReloadLocalAddons,
            this.tsmiCheckForUpdates,
            this.tsmWadduAllAddons});
            this.tsmiAddons.Name = "tsmiAddons";
            this.tsmiAddons.Size = new System.Drawing.Size(60, 20);
            this.tsmiAddons.Text = "&Addons";
            // 
            // tsmiReloadLocalAddons
            // 
            this.tsmiReloadLocalAddons.Name = "tsmiReloadLocalAddons";
            this.tsmiReloadLocalAddons.Size = new System.Drawing.Size(185, 22);
            this.tsmiReloadLocalAddons.Text = "&Reload Local Addons";
            this.tsmiReloadLocalAddons.Click += new System.EventHandler(this.tsmiReloadLocalAddons_Click);
            // 
            // tsmiCheckForUpdates
            // 
            this.tsmiCheckForUpdates.Name = "tsmiCheckForUpdates";
            this.tsmiCheckForUpdates.Size = new System.Drawing.Size(185, 22);
            this.tsmiCheckForUpdates.Text = "&Check for Updates";
            this.tsmiCheckForUpdates.Click += new System.EventHandler(this.tsmiCheckForUpdates_Click);
            // 
            // tsmWadduAllAddons
            // 
            this.tsmWadduAllAddons.Name = "tsmWadduAllAddons";
            this.tsmWadduAllAddons.Size = new System.Drawing.Size(185, 22);
            this.tsmWadduAllAddons.Text = "&Update all Addons";
            this.tsmWadduAllAddons.Click += new System.EventHandler(this.tsmiUpdateAllAddons_Click);
            // 
            // ctxAddon
            // 
            this.ctxAddon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckSingleAddon,
            this.tsmWadduSingleAddon});
            this.ctxAddon.Name = "ctxAddon";
            this.ctxAddon.Size = new System.Drawing.Size(167, 48);
            // 
            // tsmiCheckSingleAddon
            // 
            this.tsmiCheckSingleAddon.Name = "tsmiCheckSingleAddon";
            this.tsmiCheckSingleAddon.Size = new System.Drawing.Size(166, 22);
            this.tsmiCheckSingleAddon.Text = "&Check for Update";
            this.tsmiCheckSingleAddon.Click += new System.EventHandler(this.tsmiCheckSingleAddon_Click);
            // 
            // tsmWadduSingleAddon
            // 
            this.tsmWadduSingleAddon.Name = "tsmWadduSingleAddon";
            this.tsmWadduSingleAddon.Size = new System.Drawing.Size(166, 22);
            this.tsmWadduSingleAddon.Text = "&Update";
            this.tsmWadduSingleAddon.Click += new System.EventHandler(this.tsmiUpdateSingleAddon_Click);
            // 
            // ctxLog
            // 
            this.ctxLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearLog});
            this.ctxLog.Name = "ctxLog";
            this.ctxLog.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(124, 22);
            this.tsmiClearLog.Text = "&Clear Log";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // ctxThread
            // 
            this.ctxThread.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbortThread});
            this.ctxThread.Name = "ctxThread";
            this.ctxThread.Size = new System.Drawing.Size(105, 26);
            // 
            // tsmiAbortThread
            // 
            this.tsmiAbortThread.Name = "tsmiAbortThread";
            this.tsmiAbortThread.Size = new System.Drawing.Size(104, 22);
            this.tsmiAbortThread.Text = "&Abort";
            this.tsmiAbortThread.Click += new System.EventHandler(this.tsmiAbortThread_Click);
            // 
            // splitContainerEx2
            // 
            this.splitContainerEx2.AlternativeCollapseDefault = false;
            this.splitContainerEx2.AlternativeCollapsePanel = Waddu.Controls.SplitContainerEx.Panels.Panel2;
            this.splitContainerEx2.BottomRightLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx2.CenterLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx2.DragLineOffset = 0;
            this.splitContainerEx2.DragLines = Waddu.Controls.SplitContainerEx.LineMode.Normal;
            this.splitContainerEx2.DragLineWidth = 40;
            this.splitContainerEx2.Location = new System.Drawing.Point(0, 24);
            this.splitContainerEx2.Name = "splitContainerEx2";
            this.splitContainerEx2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx2.Panel1
            // 
            this.splitContainerEx2.Panel1.Controls.Add(this.splitContainerEx1);
            this.splitContainerEx2.Panel1MaxSize = 0;
            // 
            // splitContainerEx2.Panel2
            // 
            this.splitContainerEx2.Panel2.Controls.Add(this.splitContainerEx3);
            this.splitContainerEx2.Panel2MaxSize = 0;
            this.splitContainerEx2.Size = new System.Drawing.Size(787, 524);
            this.splitContainerEx2.SplitterDistance = 335;
            this.splitContainerEx2.SplitterWidth = 20;
            this.splitContainerEx2.TabIndex = 13;
            this.splitContainerEx2.TopLeftLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.AlternativeCollapseDefault = false;
            this.splitContainerEx1.AlternativeCollapsePanel = Waddu.Controls.SplitContainerEx.Panels.Panel2;
            this.splitContainerEx1.BottomRightLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx1.CenterLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.DragLineOffset = 0;
            this.splitContainerEx1.DragLines = Waddu.Controls.SplitContainerEx.LineMode.Normal;
            this.splitContainerEx1.DragLineWidth = 40;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.gbAddons);
            this.splitContainerEx1.Panel1MaxSize = 0;
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.gbAddonDetails);
            this.splitContainerEx1.Panel2MaxSize = 0;
            this.splitContainerEx1.Size = new System.Drawing.Size(787, 335);
            this.splitContainerEx1.SplitterDistance = 441;
            this.splitContainerEx1.SplitterWidth = 20;
            this.splitContainerEx1.TabIndex = 0;
            this.splitContainerEx1.TopLeftLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            // 
            // gbAddons
            // 
            this.gbAddons.Controls.Add(this.dgvAddons);
            this.gbAddons.Controls.Add(this.tsAddon);
            this.gbAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddons.Location = new System.Drawing.Point(0, 0);
            this.gbAddons.Name = "gbAddons";
            this.gbAddons.Size = new System.Drawing.Size(441, 335);
            this.gbAddons.TabIndex = 10;
            this.gbAddons.TabStop = false;
            this.gbAddons.Text = "Addons";
            // 
            // dgvAddons
            // 
            this.dgvAddons.AllowUserToAddRows = false;
            this.dgvAddons.AllowUserToDeleteRows = false;
            this.dgvAddons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddons.ContextMenuStrip = this.ctxAddon;
            this.dgvAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddons.Location = new System.Drawing.Point(3, 41);
            this.dgvAddons.Name = "dgvAddons";
            this.dgvAddons.ReadOnly = true;
            this.dgvAddons.RowHeadersVisible = false;
            this.dgvAddons.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddons.Size = new System.Drawing.Size(435, 291);
            this.dgvAddons.TabIndex = 4;
            this.dgvAddons.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddons_CellMouseDown);
            this.dgvAddons.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAddons_CellPainting);
            this.dgvAddons.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvAddons_RowStateChanged);
            // 
            // tsAddon
            // 
            this.tsAddon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAddon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddFilter});
            this.tsAddon.Location = new System.Drawing.Point(3, 16);
            this.tsAddon.Name = "tsAddon";
            this.tsAddon.Size = new System.Drawing.Size(435, 25);
            this.tsAddon.TabIndex = 5;
            this.tsAddon.Text = "toolStrip1";
            // 
            // tsddFilter
            // 
            this.tsddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterInstalled,
            this.tsmiFilterNotInstalled,
            this.tsmiFilterSubAddons,
            this.tsmiFilterBlizzard});
            this.tsddFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsddFilter.Image")));
            this.tsddFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddFilter.Name = "tsddFilter";
            this.tsddFilter.Size = new System.Drawing.Size(46, 22);
            this.tsddFilter.Text = "Filter";
            // 
            // tsmiFilterInstalled
            // 
            this.tsmiFilterInstalled.Checked = true;
            this.tsmiFilterInstalled.CheckOnClick = true;
            this.tsmiFilterInstalled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiFilterInstalled.Name = "tsmiFilterInstalled";
            this.tsmiFilterInstalled.Size = new System.Drawing.Size(141, 22);
            this.tsmiFilterInstalled.Text = "Installed";
            this.tsmiFilterInstalled.CheckedChanged += new System.EventHandler(this.tsmiFilter_CheckedChanged);
            // 
            // tsmiFilterNotInstalled
            // 
            this.tsmiFilterNotInstalled.CheckOnClick = true;
            this.tsmiFilterNotInstalled.Name = "tsmiFilterNotInstalled";
            this.tsmiFilterNotInstalled.Size = new System.Drawing.Size(141, 22);
            this.tsmiFilterNotInstalled.Text = "Not Installed";
            this.tsmiFilterNotInstalled.CheckedChanged += new System.EventHandler(this.tsmiFilter_CheckedChanged);
            // 
            // tsmiFilterSubAddons
            // 
            this.tsmiFilterSubAddons.CheckOnClick = true;
            this.tsmiFilterSubAddons.Name = "tsmiFilterSubAddons";
            this.tsmiFilterSubAddons.Size = new System.Drawing.Size(141, 22);
            this.tsmiFilterSubAddons.Text = "SubAddons";
            this.tsmiFilterSubAddons.CheckedChanged += new System.EventHandler(this.tsmiFilter_CheckedChanged);
            // 
            // tsmiFilterBlizzard
            // 
            this.tsmiFilterBlizzard.CheckOnClick = true;
            this.tsmiFilterBlizzard.Name = "tsmiFilterBlizzard";
            this.tsmiFilterBlizzard.Size = new System.Drawing.Size(141, 22);
            this.tsmiFilterBlizzard.Text = "Blizzard";
            this.tsmiFilterBlizzard.CheckedChanged += new System.EventHandler(this.tsmiFilter_CheckedChanged);
            // 
            // gbAddonDetails
            // 
            this.gbAddonDetails.Controls.Add(this.txtLocalVersion);
            this.gbAddonDetails.Controls.Add(this.lblLocalVersion);
            this.gbAddonDetails.Controls.Add(this.gbMappings);
            this.gbAddonDetails.Controls.Add(this.gbSubAddons);
            this.gbAddonDetails.Controls.Add(this.linkDownload);
            this.gbAddonDetails.Controls.Add(this.linkInfo);
            this.gbAddonDetails.Controls.Add(this.lblName);
            this.gbAddonDetails.Controls.Add(this.txtName);
            this.gbAddonDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddonDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAddonDetails.Name = "gbAddonDetails";
            this.gbAddonDetails.Size = new System.Drawing.Size(326, 335);
            this.gbAddonDetails.TabIndex = 11;
            this.gbAddonDetails.TabStop = false;
            this.gbAddonDetails.Text = "Addon Details";
            // 
            // txtLocalVersion
            // 
            this.txtLocalVersion.Location = new System.Drawing.Point(216, 13);
            this.txtLocalVersion.Name = "txtLocalVersion";
            this.txtLocalVersion.ReadOnly = true;
            this.txtLocalVersion.Size = new System.Drawing.Size(98, 20);
            this.txtLocalVersion.TabIndex = 10;
            // 
            // lblLocalVersion
            // 
            this.lblLocalVersion.AutoSize = true;
            this.lblLocalVersion.Location = new System.Drawing.Point(139, 16);
            this.lblLocalVersion.Name = "lblLocalVersion";
            this.lblLocalVersion.Size = new System.Drawing.Size(71, 13);
            this.lblLocalVersion.TabIndex = 9;
            this.lblLocalVersion.Text = "Local Version";
            // 
            // gbMappings
            // 
            this.gbMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMappings.Controls.Add(this.dgvMappings);
            this.gbMappings.Location = new System.Drawing.Point(6, 57);
            this.gbMappings.Name = "gbMappings";
            this.gbMappings.Size = new System.Drawing.Size(311, 162);
            this.gbMappings.TabIndex = 8;
            this.gbMappings.TabStop = false;
            this.gbMappings.Text = "Mappings";
            // 
            // dgvMappings
            // 
            this.dgvMappings.AllowUserToAddRows = false;
            this.dgvMappings.AllowUserToDeleteRows = false;
            this.dgvMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Site,
            this.Version,
            this.LastUpdated});
            this.dgvMappings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMappings.Location = new System.Drawing.Point(3, 16);
            this.dgvMappings.Name = "dgvMappings";
            this.dgvMappings.ReadOnly = true;
            this.dgvMappings.RowHeadersVisible = false;
            this.dgvMappings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMappings.Size = new System.Drawing.Size(305, 143);
            this.dgvMappings.TabIndex = 6;
            // 
            // gbSubAddons
            // 
            this.gbSubAddons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubAddons.Controls.Add(this.lbSubAddons);
            this.gbSubAddons.Location = new System.Drawing.Point(6, 225);
            this.gbSubAddons.Name = "gbSubAddons";
            this.gbSubAddons.Size = new System.Drawing.Size(314, 104);
            this.gbSubAddons.TabIndex = 7;
            this.gbSubAddons.TabStop = false;
            this.gbSubAddons.Text = "SubAddons";
            // 
            // lbSubAddons
            // 
            this.lbSubAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubAddons.FormattingEnabled = true;
            this.lbSubAddons.IntegralHeight = false;
            this.lbSubAddons.Location = new System.Drawing.Point(3, 16);
            this.lbSubAddons.Name = "lbSubAddons";
            this.lbSubAddons.Size = new System.Drawing.Size(308, 85);
            this.lbSubAddons.TabIndex = 1;
            // 
            // linkDownload
            // 
            this.linkDownload.AutoSize = true;
            this.linkDownload.Location = new System.Drawing.Point(38, 41);
            this.linkDownload.Name = "linkDownload";
            this.linkDownload.Size = new System.Drawing.Size(55, 13);
            this.linkDownload.TabIndex = 5;
            this.linkDownload.TabStop = true;
            this.linkDownload.Text = "Download";
            this.linkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDownload_LinkClicked);
            // 
            // linkInfo
            // 
            this.linkInfo.AutoSize = true;
            this.linkInfo.Location = new System.Drawing.Point(7, 41);
            this.linkInfo.Name = "linkInfo";
            this.linkInfo.Size = new System.Drawing.Size(25, 13);
            this.linkInfo.TabIndex = 4;
            this.linkInfo.TabStop = true;
            this.linkInfo.Text = "Info";
            this.linkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInfo_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 13);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(86, 20);
            this.txtName.TabIndex = 0;
            // 
            // splitContainerEx3
            // 
            this.splitContainerEx3.AlternativeCollapseDefault = false;
            this.splitContainerEx3.AlternativeCollapsePanel = Waddu.Controls.SplitContainerEx.Panels.Panel2;
            this.splitContainerEx3.BottomRightLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx3.CenterLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            this.splitContainerEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx3.DragLineOffset = 0;
            this.splitContainerEx3.DragLines = Waddu.Controls.SplitContainerEx.LineMode.Normal;
            this.splitContainerEx3.DragLineWidth = 40;
            this.splitContainerEx3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx3.Name = "splitContainerEx3";
            // 
            // splitContainerEx3.Panel1
            // 
            this.splitContainerEx3.Panel1.Controls.Add(this.dgvThreadActivity);
            this.splitContainerEx3.Panel1MaxSize = 0;
            // 
            // splitContainerEx3.Panel2
            // 
            this.splitContainerEx3.Panel2.Controls.Add(this.dgvLog);
            this.splitContainerEx3.Panel2.Controls.Add(this.tsLog);
            this.splitContainerEx3.Panel2MaxSize = 0;
            this.splitContainerEx3.Size = new System.Drawing.Size(787, 169);
            this.splitContainerEx3.SplitterDistance = 441;
            this.splitContainerEx3.SplitterWidth = 20;
            this.splitContainerEx3.TabIndex = 0;
            this.splitContainerEx3.TopLeftLine = Waddu.Controls.SplitContainerEx.LineMode.Hidden;
            // 
            // dgvThreadActivity
            // 
            this.dgvThreadActivity.AllowUserToAddRows = false;
            this.dgvThreadActivity.AllowUserToDeleteRows = false;
            this.dgvThreadActivity.AllowUserToResizeRows = false;
            this.dgvThreadActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThreadActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.State,
            this.Info});
            this.dgvThreadActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThreadActivity.Location = new System.Drawing.Point(0, 0);
            this.dgvThreadActivity.MultiSelect = false;
            this.dgvThreadActivity.Name = "dgvThreadActivity";
            this.dgvThreadActivity.ReadOnly = true;
            this.dgvThreadActivity.RowHeadersVisible = false;
            this.dgvThreadActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThreadActivity.Size = new System.Drawing.Size(441, 169);
            this.dgvThreadActivity.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 80;
            // 
            // Info
            // 
            this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 50;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTime,
            this.Type,
            this.dgcMessage});
            this.dgvLog.ContextMenuStrip = this.ctxLog;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 25);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 20;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(326, 144);
            this.dgvLog.TabIndex = 0;
            // 
            // dgcTime
            // 
            this.dgcTime.HeaderText = "Time";
            this.dgcTime.Name = "dgcTime";
            this.dgcTime.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 80;
            // 
            // dgcMessage
            // 
            this.dgcMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcMessage.HeaderText = "Message";
            this.dgcMessage.Name = "dgcMessage";
            this.dgcMessage.ReadOnly = true;
            this.dgcMessage.Width = 75;
            // 
            // tsLog
            // 
            this.tsLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddLogLevel});
            this.tsLog.Location = new System.Drawing.Point(0, 0);
            this.tsLog.Name = "tsLog";
            this.tsLog.Size = new System.Drawing.Size(326, 25);
            this.tsLog.TabIndex = 1;
            this.tsLog.Text = "toolStrip1";
            // 
            // tsddLogLevel
            // 
            this.tsddLogLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddLogLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogDebug,
            this.tsmiLogInformation,
            this.tsmiLogWarning,
            this.tsmiLogError});
            this.tsddLogLevel.Image = ((System.Drawing.Image)(resources.GetObject("tsddLogLevel.Image")));
            this.tsddLogLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddLogLevel.Name = "tsddLogLevel";
            this.tsddLogLevel.Size = new System.Drawing.Size(70, 22);
            this.tsddLogLevel.Text = "Log Level";
            // 
            // tsmiLogDebug
            // 
            this.tsmiLogDebug.CheckOnClick = true;
            this.tsmiLogDebug.Name = "tsmiLogDebug";
            this.tsmiLogDebug.Size = new System.Drawing.Size(137, 22);
            this.tsmiLogDebug.Text = "Debug";
            this.tsmiLogDebug.Click += new System.EventHandler(this.tsmiLogLevelItem_Click);
            // 
            // tsmiLogInformation
            // 
            this.tsmiLogInformation.CheckOnClick = true;
            this.tsmiLogInformation.Name = "tsmiLogInformation";
            this.tsmiLogInformation.Size = new System.Drawing.Size(137, 22);
            this.tsmiLogInformation.Text = "Information";
            this.tsmiLogInformation.Click += new System.EventHandler(this.tsmiLogLevelItem_Click);
            // 
            // tsmiLogWarning
            // 
            this.tsmiLogWarning.CheckOnClick = true;
            this.tsmiLogWarning.Name = "tsmiLogWarning";
            this.tsmiLogWarning.Size = new System.Drawing.Size(137, 22);
            this.tsmiLogWarning.Text = "Warning";
            this.tsmiLogWarning.Click += new System.EventHandler(this.tsmiLogLevelItem_Click);
            // 
            // tsmiLogError
            // 
            this.tsmiLogError.CheckOnClick = true;
            this.tsmiLogError.Name = "tsmiLogError";
            this.tsmiLogError.Size = new System.Drawing.Size(137, 22);
            this.tsmiLogError.Text = "Error";
            this.tsmiLogError.Click += new System.EventHandler(this.tsmiLogLevelItem_Click);
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // LastUpdated
            // 
            this.LastUpdated.HeaderText = "LastUpdated";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.splitContainerEx2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Waddu - WoW Addon Updater";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxAddon.ResumeLayout(false);
            this.ctxLog.ResumeLayout(false);
            this.ctxThread.ResumeLayout(false);
            this.splitContainerEx2.Panel1.ResumeLayout(false);
            this.splitContainerEx2.Panel2.ResumeLayout(false);
            this.splitContainerEx2.ResumeLayout(false);
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            this.splitContainerEx1.ResumeLayout(false);
            this.gbAddons.ResumeLayout(false);
            this.gbAddons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddons)).EndInit();
            this.tsAddon.ResumeLayout(false);
            this.tsAddon.PerformLayout();
            this.gbAddonDetails.ResumeLayout(false);
            this.gbAddonDetails.PerformLayout();
            this.gbMappings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).EndInit();
            this.gbSubAddons.ResumeLayout(false);
            this.splitContainerEx3.Panel1.ResumeLayout(false);
            this.splitContainerEx3.Panel2.ResumeLayout(false);
            this.splitContainerEx3.Panel2.PerformLayout();
            this.splitContainerEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreadActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.tsLog.ResumeLayout(false);
            this.tsLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvAddons;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddons;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem tsmWadduAllAddons;
        private System.Windows.Forms.DataGridView dgvThreadActivity;
        private System.Windows.Forms.ListBox lbSubAddons;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.ContextMenuStrip ctxAddon;
        private System.Windows.Forms.ToolStripMenuItem tsmWadduSingleAddon;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckSingleAddon;
        private System.Windows.Forms.ContextMenuStrip ctxLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.ContextMenuStrip ctxThread;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbortThread;
        private System.Windows.Forms.ToolStrip tsAddon;
        private System.Windows.Forms.ToolStripMenuItem tsmiReloadLocalAddons;
        private System.Windows.Forms.ToolStripDropDownButton tsddFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterNotInstalled;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterInstalled;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterSubAddons;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterBlizzard;
        private System.Windows.Forms.GroupBox gbAddons;
        private System.Windows.Forms.GroupBox gbAddonDetails;
        private Waddu.Controls.SplitContainerEx splitContainerEx2;
        private Waddu.Controls.SplitContainerEx splitContainerEx1;
        private Waddu.Controls.SplitContainerEx splitContainerEx3;
        private System.Windows.Forms.ToolStrip tsLog;
        private System.Windows.Forms.ToolStripDropDownButton tsddLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.LinkLabel linkDownload;
        private System.Windows.Forms.LinkLabel linkInfo;
        private System.Windows.Forms.ToolTip ttMainForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogDebug;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogWarning;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogError;
        private System.Windows.Forms.DataGridView dgvMappings;
        private System.Windows.Forms.GroupBox gbSubAddons;
        private System.Windows.Forms.GroupBox gbMappings;
        private System.Windows.Forms.TextBox txtLocalVersion;
        private System.Windows.Forms.Label lblLocalVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;

    }
}

