﻿using BorderlessGaming.Logic.Core;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnMakeBorderless = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.processContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAddToFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByTheWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip169CenterTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip169LeftTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip169RightTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip219Title = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBorderlessOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHideProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFavScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedItem = new System.Windows.Forms.Button();
            this.lstFavorites = new System.Windows.Forms.ListBox();
            this.mnuFavoritesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNoSizeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetSetWindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAutomaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdjustWindowBounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelayBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemoveMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMuteInBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRemoveFromFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveFavorite = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.favoritesLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGlobalHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMinimizedToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCloseToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideBalloonTips = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSlowWindowDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripViewFullProcessDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRestoreProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPauseAutomaticProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpenDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripToggleMouseCursorVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripToggleWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFullApplicationRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsageGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegexReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSupportUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rainwayStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestoreWindow = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processContext.SuspendLayout();
            this.mnuFavoritesContext.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeBorderless
            // 
            resources.ApplyResources(this.btnMakeBorderless, "btnMakeBorderless");
            this.btnMakeBorderless.Image = global::BorderlessGaming.Properties.Resources.borderless;
            this.btnMakeBorderless.Name = "btnMakeBorderless";
            this.btnMakeBorderless.UseVisualStyleBackColor = true;
            this.btnMakeBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            this.btnMakeBorderless.MouseHover += new System.EventHandler(this.btnMakeBorderless_MouseHover);
            // 
            // lstProcesses
            // 
            resources.ApplyResources(this.lstProcesses, "lstProcesses");
            this.lstProcesses.ContextMenuStrip = this.processContext;
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Sorted = true;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            // 
            // processContext
            // 
            resources.ApplyResources(this.processContext, "processContext");
            this.processContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAddToFavs,
            this.toolStripMenuItem1,
            this.contextBorderless,
            this.contextBorderlessOn,
            this.toolStripSetWindowTitle,
            this.toolStripMenuItem8,
            this.toolStripHideProcess});
            this.processContext.Name = "processContext";
            this.processContext.Opening += new System.ComponentModel.CancelEventHandler(this.processContext_Opening);
            // 
            // contextAddToFavs
            // 
            resources.ApplyResources(this.contextAddToFavs, "contextAddToFavs");
            this.contextAddToFavs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripByTheWindowTitle,
            this.toolStripByRegex,
            this.toolStripByProcess});
            this.contextAddToFavs.Name = "contextAddToFavs";
            // 
            // toolStripByTheWindowTitle
            // 
            resources.ApplyResources(this.toolStripByTheWindowTitle, "toolStripByTheWindowTitle");
            this.toolStripByTheWindowTitle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip169CenterTitle,
            this.toolStrip169LeftTitle,
            this.toolStrip169RightTitle,
            this.toolStrip219Title});
            this.toolStripByTheWindowTitle.Name = "toolStripByTheWindowTitle";
            // 
            // toolStrip169CenterTitle
            // 
            resources.ApplyResources(this.toolStrip169CenterTitle, "toolStrip169CenterTitle");
            this.toolStrip169CenterTitle.Name = "toolStrip169CenterTitle";
            this.toolStrip169CenterTitle.Click += new System.EventHandler(this.toolStrip169CenterTitle_Click);
            // 
            // toolStrip169LeftTitle
            // 
            resources.ApplyResources(this.toolStrip169LeftTitle, "toolStrip169LeftTitle");
            this.toolStrip169LeftTitle.Name = "toolStrip169LeftTitle";
            this.toolStrip169LeftTitle.Click += new System.EventHandler(this.toolStrip169LeftTitle_Click);
            // 
            // toolStrip169RightTitle
            // 
            resources.ApplyResources(this.toolStrip169RightTitle, "toolStrip169RightTitle");
            this.toolStrip169RightTitle.Name = "toolStrip169RightTitle";
            this.toolStrip169RightTitle.Click += new System.EventHandler(this.toolStrip169RightTitle_Click);
            // 
            // toolStrip219Title
            // 
            resources.ApplyResources(this.toolStrip219Title, "toolStrip219Title");
            this.toolStrip219Title.Name = "toolStrip219Title";
            this.toolStrip219Title.Click += new System.EventHandler(this.toolStrip219Title_Click);
            // 
            // toolStripByRegex
            // 
            resources.ApplyResources(this.toolStripByRegex, "toolStripByRegex");
            this.toolStripByRegex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.toolStripByRegex.Name = "toolStripByRegex";
            // 
            // toolStripMenuItem14
            // 
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStrip169CenterTitle_Click);
            // 
            // toolStripMenuItem15
            // 
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStrip169LeftTitle_Click);
            // 
            // toolStripMenuItem16
            // 
            resources.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStrip169RightTitle_Click);
            // 
            // toolStripMenuItem17
            // 
            resources.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStrip219Title_Click);
            // 
            // toolStripByProcess
            // 
            resources.ApplyResources(this.toolStripByProcess, "toolStripByProcess");
            this.toolStripByProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22});
            this.toolStripByProcess.Name = "toolStripByProcess";
            // 
            // toolStripMenuItem18
            // 
            resources.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStrip169CenterTitle_Click);
            // 
            // toolStripMenuItem20
            // 
            resources.ApplyResources(this.toolStripMenuItem20, "toolStripMenuItem20");
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStrip169LeftTitle_Click);
            // 
            // toolStripMenuItem21
            // 
            resources.ApplyResources(this.toolStripMenuItem21, "toolStripMenuItem21");
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStrip169RightTitle_Click);
            // 
            // toolStripMenuItem22
            // 
            resources.ApplyResources(this.toolStripMenuItem22, "toolStripMenuItem22");
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStrip219Title_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // contextBorderless
            // 
            resources.ApplyResources(this.contextBorderless, "contextBorderless");
            this.contextBorderless.Name = "contextBorderless";
            this.contextBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            // 
            // contextBorderlessOn
            // 
            resources.ApplyResources(this.contextBorderlessOn, "contextBorderlessOn");
            this.contextBorderlessOn.Name = "contextBorderlessOn";
            // 
            // toolStripSetWindowTitle
            // 
            resources.ApplyResources(this.toolStripSetWindowTitle, "toolStripSetWindowTitle");
            this.toolStripSetWindowTitle.Name = "toolStripSetWindowTitle";
            this.toolStripSetWindowTitle.Click += new System.EventHandler(this.setWindowTitleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // toolStripHideProcess
            // 
            resources.ApplyResources(this.toolStripHideProcess, "toolStripHideProcess");
            this.toolStripHideProcess.Name = "toolStripHideProcess";
            this.toolStripHideProcess.Click += new System.EventHandler(this.hideThisProcessToolStripMenuItem_Click);
            // 
            // contextFavScreen
            // 
            resources.ApplyResources(this.contextFavScreen, "contextFavScreen");
            this.contextFavScreen.Name = "contextFavScreen";
            // 
            // addSelectedItem
            // 
            resources.ApplyResources(this.addSelectedItem, "addSelectedItem");
            this.addSelectedItem.Image = global::BorderlessGaming.Properties.Resources.add;
            this.addSelectedItem.Name = "addSelectedItem";
            this.addSelectedItem.UseVisualStyleBackColor = true;
            this.addSelectedItem.Click += new System.EventHandler(this.addSelectedItem_Click);
            this.addSelectedItem.MouseHover += new System.EventHandler(this.addSelectedItem_MouseHover);
            // 
            // lstFavorites
            // 
            resources.ApplyResources(this.lstFavorites, "lstFavorites");
            this.lstFavorites.ContextMenuStrip = this.mnuFavoritesContext;
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Sorted = true;
            this.lstFavorites.SelectedIndexChanged += new System.EventHandler(this.lstFavorites_SelectedIndexChanged);
            // 
            // mnuFavoritesContext
            // 
            resources.ApplyResources(this.mnuFavoritesContext, "mnuFavoritesContext");
            this.mnuFavoritesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFullScreen,
            this.toolStripNoSizeChange,
            this.toolStripSetSetWindowSize,
            this.toolStripMenuItem6,
            this.toolStripAutomaximize,
            this.toolStripAdjustWindowBounds,
            this.toolStripMenuItem4,
            this.toolStripAlwaysOnTop,
            this.toolStripDelayBorderless,
            this.toolStripHideMouseCursor,
            this.toolStripHideWindowsTaskbar,
            this.toolStripRemoveMenus,
            this.toolStripMenuItem9,
            this.contextFavScreen,
            this.toolStripMuteInBackground,
            this.contextRemoveFromFavs});
            this.mnuFavoritesContext.Name = "mnuFavoritesRightClick";
            this.mnuFavoritesContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuFavoritesContext_Opening);
            // 
            // toolStripFullScreen
            // 
            resources.ApplyResources(this.toolStripFullScreen, "toolStripFullScreen");
            this.toolStripFullScreen.CheckOnClick = true;
            this.toolStripFullScreen.Name = "toolStripFullScreen";
            this.toolStripFullScreen.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // toolStripNoSizeChange
            // 
            resources.ApplyResources(this.toolStripNoSizeChange, "toolStripNoSizeChange");
            this.toolStripNoSizeChange.CheckOnClick = true;
            this.toolStripNoSizeChange.Name = "toolStripNoSizeChange";
            this.toolStripNoSizeChange.Click += new System.EventHandler(this.noSizeChangeToolStripMenuItem_Click);
            // 
            // toolStripSetSetWindowSize
            // 
            resources.ApplyResources(this.toolStripSetSetWindowSize, "toolStripSetSetWindowSize");
            this.toolStripSetSetWindowSize.Name = "toolStripSetSetWindowSize";
            this.toolStripSetSetWindowSize.Click += new System.EventHandler(this.setWindowSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // toolStripAutomaximize
            // 
            resources.ApplyResources(this.toolStripAutomaximize, "toolStripAutomaximize");
            this.toolStripAutomaximize.CheckOnClick = true;
            this.toolStripAutomaximize.Name = "toolStripAutomaximize";
            this.toolStripAutomaximize.Click += new System.EventHandler(this.automaximizeToolStripMenuItem_Click);
            // 
            // toolStripAdjustWindowBounds
            // 
            resources.ApplyResources(this.toolStripAdjustWindowBounds, "toolStripAdjustWindowBounds");
            this.toolStripAdjustWindowBounds.Name = "toolStripAdjustWindowBounds";
            this.toolStripAdjustWindowBounds.Click += new System.EventHandler(this.adjustWindowBoundsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // toolStripAlwaysOnTop
            // 
            resources.ApplyResources(this.toolStripAlwaysOnTop, "toolStripAlwaysOnTop");
            this.toolStripAlwaysOnTop.CheckOnClick = true;
            this.toolStripAlwaysOnTop.Name = "toolStripAlwaysOnTop";
            this.toolStripAlwaysOnTop.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // toolStripDelayBorderless
            // 
            resources.ApplyResources(this.toolStripDelayBorderless, "toolStripDelayBorderless");
            this.toolStripDelayBorderless.CheckOnClick = true;
            this.toolStripDelayBorderless.Name = "toolStripDelayBorderless";
            this.toolStripDelayBorderless.Click += new System.EventHandler(this.delayBorderlessToolStripMenuItem_Click);
            // 
            // toolStripHideMouseCursor
            // 
            resources.ApplyResources(this.toolStripHideMouseCursor, "toolStripHideMouseCursor");
            this.toolStripHideMouseCursor.CheckOnClick = true;
            this.toolStripHideMouseCursor.Name = "toolStripHideMouseCursor";
            this.toolStripHideMouseCursor.Click += new System.EventHandler(this.hideMouseCursorToolStripMenuItem_Click);
            // 
            // toolStripHideWindowsTaskbar
            // 
            resources.ApplyResources(this.toolStripHideWindowsTaskbar, "toolStripHideWindowsTaskbar");
            this.toolStripHideWindowsTaskbar.CheckOnClick = true;
            this.toolStripHideWindowsTaskbar.Name = "toolStripHideWindowsTaskbar";
            this.toolStripHideWindowsTaskbar.Click += new System.EventHandler(this.hideWindowsTaskbarToolStripMenuItem_Click);
            // 
            // toolStripRemoveMenus
            // 
            resources.ApplyResources(this.toolStripRemoveMenus, "toolStripRemoveMenus");
            this.toolStripRemoveMenus.CheckOnClick = true;
            this.toolStripRemoveMenus.Name = "toolStripRemoveMenus";
            this.toolStripRemoveMenus.Click += new System.EventHandler(this.removeMenusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            // 
            // toolStripMuteInBackground
            // 
            resources.ApplyResources(this.toolStripMuteInBackground, "toolStripMuteInBackground");
            this.toolStripMuteInBackground.CheckOnClick = true;
            this.toolStripMuteInBackground.Name = "toolStripMuteInBackground";
            this.toolStripMuteInBackground.Click += new System.EventHandler(this.muteInBackgroundToolStripMenuItem_Click);
            // 
            // contextRemoveFromFavs
            // 
            resources.ApplyResources(this.contextRemoveFromFavs, "contextRemoveFromFavs");
            this.contextRemoveFromFavs.Name = "contextRemoveFromFavs";
            this.contextRemoveFromFavs.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            // 
            // btnRemoveFavorite
            // 
            resources.ApplyResources(this.btnRemoveFavorite, "btnRemoveFavorite");
            this.btnRemoveFavorite.Image = global::BorderlessGaming.Properties.Resources.remove;
            this.btnRemoveFavorite.Name = "btnRemoveFavorite";
            this.btnRemoveFavorite.UseVisualStyleBackColor = true;
            this.btnRemoveFavorite.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            this.btnRemoveFavorite.MouseHover += new System.EventHandler(this.btnRemoveFavorite_MouseHover);
            // 
            // processLabel
            // 
            resources.ApplyResources(this.processLabel, "processLabel");
            this.processLabel.Name = "processLabel";
            // 
            // favoritesLabel
            // 
            resources.ApplyResources(this.favoritesLabel, "favoritesLabel");
            this.favoritesLabel.Name = "favoritesLabel";
            // 
            // trayIcon
            // 
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconContextMenu
            // 
            resources.ApplyResources(this.trayIconContextMenu, "trayIconContextMenu");
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem7,
            this.exitToolStripMenuItem});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptions,
            this.toolsToolStripMenuItem,
            this.toolStripInfo,
            this.rainwayStrip});
            this.mnuMain.Name = "mnuMain";
            // 
            // toolStripOptions
            // 
            resources.ApplyResources(this.toolStripOptions, "toolStripOptions");
            this.toolStripOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRunOnStartup,
            this.toolStripLanguages,
            this.toolStripCheckForUpdates,
            this.toolStripMenuItem3,
            this.toolStripGlobalHotkey,
            this.toolStripMouseLock,
            this.toolStripMouseHide,
            this.toolStripMenuItem5,
            this.toolStripMinimizedToTray,
            this.toolStripCloseToTray,
            this.toolStripHideBalloonTips,
            this.toolStripSlowWindowDetection,
            this.toolStripViewFullProcessDetails,
            this.toolStripMenuItem10,
            this.toolStripRestoreProcesses});
            this.toolStripOptions.Name = "toolStripOptions";
            // 
            // toolStripRunOnStartup
            // 
            resources.ApplyResources(this.toolStripRunOnStartup, "toolStripRunOnStartup");
            this.toolStripRunOnStartup.CheckOnClick = true;
            this.toolStripRunOnStartup.Name = "toolStripRunOnStartup";
            this.toolStripRunOnStartup.CheckedChanged += new System.EventHandler(this.toolStripRunOnStartup_CheckChanged);
            // 
            // toolStripLanguages
            // 
            resources.ApplyResources(this.toolStripLanguages, "toolStripLanguages");
            this.toolStripLanguages.Name = "toolStripLanguages";
            // 
            // toolStripCheckForUpdates
            // 
            resources.ApplyResources(this.toolStripCheckForUpdates, "toolStripCheckForUpdates");
            this.toolStripCheckForUpdates.CheckOnClick = true;
            this.toolStripCheckForUpdates.Name = "toolStripCheckForUpdates";
            this.toolStripCheckForUpdates.CheckedChanged += new System.EventHandler(this.toolStripCheckForUpdates_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // toolStripGlobalHotkey
            // 
            resources.ApplyResources(this.toolStripGlobalHotkey, "toolStripGlobalHotkey");
            this.toolStripGlobalHotkey.CheckOnClick = true;
            this.toolStripGlobalHotkey.Name = "toolStripGlobalHotkey";
            this.toolStripGlobalHotkey.CheckedChanged += new System.EventHandler(this.toolStripGlobalHotkey_CheckChanged);
            // 
            // toolStripMouseLock
            // 
            resources.ApplyResources(this.toolStripMouseLock, "toolStripMouseLock");
            this.toolStripMouseLock.CheckOnClick = true;
            this.toolStripMouseLock.Name = "toolStripMouseLock";
            this.toolStripMouseLock.CheckedChanged += new System.EventHandler(this.toolStripMouseLock_CheckChanged);
            // 
            // toolStripMouseHide
            // 
            resources.ApplyResources(this.toolStripMouseHide, "toolStripMouseHide");
            this.toolStripMouseHide.CheckOnClick = true;
            this.toolStripMouseHide.Name = "toolStripMouseHide";
            this.toolStripMouseHide.CheckedChanged += new System.EventHandler(this.useMouseHideHotkeyWinScrollLockToolStripMenuItem_CheckChanged);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // toolStripMinimizedToTray
            // 
            resources.ApplyResources(this.toolStripMinimizedToTray, "toolStripMinimizedToTray");
            this.toolStripMinimizedToTray.CheckOnClick = true;
            this.toolStripMinimizedToTray.Name = "toolStripMinimizedToTray";
            this.toolStripMinimizedToTray.CheckedChanged += new System.EventHandler(this.startMinimizedToTrayToolStripMenuItem_CheckedChanged);
            // 
            // toolStripCloseToTray
            // 
            resources.ApplyResources(this.toolStripCloseToTray, "toolStripCloseToTray");
            this.toolStripCloseToTray.CheckOnClick = true;
            this.toolStripCloseToTray.Name = "toolStripCloseToTray";
            this.toolStripCloseToTray.CheckedChanged += new System.EventHandler(this.closeToTrayToolStripMenuItem_CheckedChanged);
            // 
            // toolStripHideBalloonTips
            // 
            resources.ApplyResources(this.toolStripHideBalloonTips, "toolStripHideBalloonTips");
            this.toolStripHideBalloonTips.CheckOnClick = true;
            this.toolStripHideBalloonTips.Name = "toolStripHideBalloonTips";
            this.toolStripHideBalloonTips.CheckedChanged += new System.EventHandler(this.hideBalloonTipsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSlowWindowDetection
            // 
            resources.ApplyResources(this.toolStripSlowWindowDetection, "toolStripSlowWindowDetection");
            this.toolStripSlowWindowDetection.CheckOnClick = true;
            this.toolStripSlowWindowDetection.Name = "toolStripSlowWindowDetection";
            this.toolStripSlowWindowDetection.Click += new System.EventHandler(this.useSlowerWindowDetectionToolStripMenuItem_Click);
            // 
            // toolStripViewFullProcessDetails
            // 
            resources.ApplyResources(this.toolStripViewFullProcessDetails, "toolStripViewFullProcessDetails");
            this.toolStripViewFullProcessDetails.CheckOnClick = true;
            this.toolStripViewFullProcessDetails.Name = "toolStripViewFullProcessDetails";
            this.toolStripViewFullProcessDetails.CheckedChanged += new System.EventHandler(this.viewFullProcessDetailsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem10
            // 
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            // 
            // toolStripRestoreProcesses
            // 
            resources.ApplyResources(this.toolStripRestoreProcesses, "toolStripRestoreProcesses");
            this.toolStripRestoreProcesses.Name = "toolStripRestoreProcesses";
            this.toolStripRestoreProcesses.Click += new System.EventHandler(this.resetHiddenProcessesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPauseAutomaticProcessing,
            this.toolStripOpenDataFolder,
            this.toolStripMenuItem11,
            this.toolStripToggleMouseCursorVisibility,
            this.toolStripToggleWindowsTaskbar,
            this.toolStripMenuItem12,
            this.toolStripFullApplicationRefresh});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            // 
            // toolStripPauseAutomaticProcessing
            // 
            resources.ApplyResources(this.toolStripPauseAutomaticProcessing, "toolStripPauseAutomaticProcessing");
            this.toolStripPauseAutomaticProcessing.CheckOnClick = true;
            this.toolStripPauseAutomaticProcessing.Name = "toolStripPauseAutomaticProcessing";
            this.toolStripPauseAutomaticProcessing.Click += new System.EventHandler(this.pauseAutomaticProcessingToolStripMenuItem_Click);
            // 
            // toolStripOpenDataFolder
            // 
            resources.ApplyResources(this.toolStripOpenDataFolder, "toolStripOpenDataFolder");
            this.toolStripOpenDataFolder.Name = "toolStripOpenDataFolder";
            this.toolStripOpenDataFolder.Click += new System.EventHandler(this.openDataFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            // 
            // toolStripToggleMouseCursorVisibility
            // 
            resources.ApplyResources(this.toolStripToggleMouseCursorVisibility, "toolStripToggleMouseCursorVisibility");
            this.toolStripToggleMouseCursorVisibility.Name = "toolStripToggleMouseCursorVisibility";
            this.toolStripToggleMouseCursorVisibility.Click += new System.EventHandler(this.toggleMouseCursorVisibilityToolStripMenuItem_Click);
            // 
            // toolStripToggleWindowsTaskbar
            // 
            resources.ApplyResources(this.toolStripToggleWindowsTaskbar, "toolStripToggleWindowsTaskbar");
            this.toolStripToggleWindowsTaskbar.Name = "toolStripToggleWindowsTaskbar";
            this.toolStripToggleWindowsTaskbar.Click += new System.EventHandler(this.toggleWindowsTaskbarVisibilityToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            // 
            // toolStripFullApplicationRefresh
            // 
            resources.ApplyResources(this.toolStripFullApplicationRefresh, "toolStripFullApplicationRefresh");
            this.toolStripFullApplicationRefresh.Name = "toolStripFullApplicationRefresh";
            this.toolStripFullApplicationRefresh.Click += new System.EventHandler(this.fullApplicationRefreshToolStripMenuItem_Click);
            // 
            // toolStripInfo
            // 
            resources.ApplyResources(this.toolStripInfo, "toolStripInfo");
            this.toolStripInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsageGuide,
            this.toolStripRegexReference,
            this.toolStripMenuItem13,
            this.toolStripReportBug,
            this.toolStripSupportUs,
            this.toolStripMenuItem2,
            this.toolStripAbout});
            this.toolStripInfo.Name = "toolStripInfo";
            // 
            // toolStripUsageGuide
            // 
            resources.ApplyResources(this.toolStripUsageGuide, "toolStripUsageGuide");
            this.toolStripUsageGuide.Name = "toolStripUsageGuide";
            this.toolStripUsageGuide.Click += new System.EventHandler(this.usageGuideToolStripMenuItem_Click);
            // 
            // toolStripRegexReference
            // 
            resources.ApplyResources(this.toolStripRegexReference, "toolStripRegexReference");
            this.toolStripRegexReference.Name = "toolStripRegexReference";
            this.toolStripRegexReference.Click += new System.EventHandler(this.toolStripRegexReference_Click);
            // 
            // toolStripMenuItem13
            // 
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            // 
            // toolStripReportBug
            // 
            resources.ApplyResources(this.toolStripReportBug, "toolStripReportBug");
            this.toolStripReportBug.Name = "toolStripReportBug";
            this.toolStripReportBug.Click += new System.EventHandler(this.toolStripReportBug_Click);
            // 
            // toolStripSupportUs
            // 
            resources.ApplyResources(this.toolStripSupportUs, "toolStripSupportUs");
            this.toolStripSupportUs.Name = "toolStripSupportUs";
            this.toolStripSupportUs.Click += new System.EventHandler(this.toolStripSupportUs_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripAbout
            // 
            resources.ApplyResources(this.toolStripAbout, "toolStripAbout");
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // rainwayStrip
            // 
            resources.ApplyResources(this.rainwayStrip, "rainwayStrip");
            this.rainwayStrip.Image = global::BorderlessGaming.Properties.Resources.master_glyph;
            this.rainwayStrip.Name = "rainwayStrip";
            this.rainwayStrip.Click += new System.EventHandler(this.checkOutRainwayToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.favoritesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstProcesses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstFavorites, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.addSelectedItem);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveFavorite);
            this.flowLayoutPanel1.Controls.Add(this.btnMakeBorderless);
            this.flowLayoutPanel1.Controls.Add(this.btnRestoreWindow);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnRestoreWindow
            // 
            resources.ApplyResources(this.btnRestoreWindow, "btnRestoreWindow");
            this.btnRestoreWindow.Image = global::BorderlessGaming.Properties.Resources.bordered;
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            this.btnRestoreWindow.MouseHover += new System.EventHandler(this.btnRestoreWindow_MouseHover);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.processContext.ResumeLayout(false);
            this.mnuFavoritesContext.ResumeLayout(false);
            this.trayIconContextMenu.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBorderless;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button addSelectedItem;
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Button btnRemoveFavorite;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripRunOnStartup;
        private System.Windows.Forms.ToolStripMenuItem toolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem rainwayStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripReportBug;
        private System.Windows.Forms.ToolStripMenuItem toolStripSupportUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegexReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip processContext;
        private System.Windows.Forms.ToolStripMenuItem contextAddToFavs;
        private System.Windows.Forms.ToolStripMenuItem contextBorderless;
        private System.Windows.Forms.ToolStripMenuItem contextBorderlessOn;
        private System.Windows.Forms.ToolStripMenuItem contextFavScreen;
        private System.Windows.Forms.ContextMenuStrip mnuFavoritesContext;
        private System.Windows.Forms.ToolStripMenuItem contextRemoveFromFavs;
        private System.Windows.Forms.ToolStripMenuItem toolStripGlobalHotkey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripByTheWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripByProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripByRegex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdjustWindowBounds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripAutomaximize;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMinimizedToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideBalloonTips;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckForUpdates;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;//this might get replaced if you redo anything in the form designer
        private System.Windows.Forms.ToolStripMenuItem toolStripViewFullProcessDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetSetWindowSize;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveMenus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelayBorderless;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleMouseCursorVisibility;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseHide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripRestoreProcesses;
        private System.Windows.Forms.ToolStripMenuItem toolStripPauseAutomaticProcessing;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripNoSizeChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenDataFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullApplicationRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripSlowWindowDetection;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsageGuide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMuteInBackground;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguages;
        private System.Windows.Forms.ToolStripMenuItem toolStrip169CenterTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStrip169LeftTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStrip169RightTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStrip219Title;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
    }
}