namespace DigitalNotesManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuFileOpen = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            menuFileSave = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            menuFileExit = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuEditCut = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuEditCopy = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            menuEditPaste = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            menuEditFormat = new ToolStripMenuItem();
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            menuView = new ToolStripMenuItem();
            menuViewNotesList = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            menuViewArrange = new ToolStripMenuItem();
            menuViewArrangeCascade = new ToolStripMenuItem();
            menuViewArrangeTile = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuHelpAbout = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            reminderTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit, menuView, menuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(790, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, toolStripMenuItem1, menuFileOpen, toolStripMenuItem7, menuFileSave, toolStripMenuItem6, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            menuFileNew.Image = Properties.Resources._new;
            menuFileNew.Name = "menuFileNew";
            menuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            menuFileNew.Size = new Size(146, 22);
            menuFileNew.Text = "&New";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(143, 6);
            // 
            // menuFileOpen
            // 
            menuFileOpen.Image = Properties.Resources.open;
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuFileOpen.Size = new Size(146, 22);
            menuFileOpen.Text = "&Open";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(143, 6);
            // 
            // menuFileSave
            // 
            menuFileSave.Image = Properties.Resources.save;
            menuFileSave.Name = "menuFileSave";
            menuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            menuFileSave.Size = new Size(146, 22);
            menuFileSave.Text = "&Save";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(143, 6);
            // 
            // menuFileExit
            // 
            menuFileExit.Image = Properties.Resources.out_icon;
            menuFileExit.Name = "menuFileExit";
            menuFileExit.Size = new Size(146, 22);
            menuFileExit.Text = "E&xit";
            menuFileExit.Click += menuFileExit_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuEditCut, toolStripMenuItem2, menuEditCopy, toolStripMenuItem3, menuEditPaste, toolStripMenuItem4, menuEditFormat, addCategoryToolStripMenuItem });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(39, 20);
            menuEdit.Text = "&Edit";
            // 
            // menuEditCut
            // 
            menuEditCut.Image = Properties.Resources.cut;
            menuEditCut.Name = "menuEditCut";
            menuEditCut.ShortcutKeys = Keys.Control | Keys.X;
            menuEditCut.Size = new Size(147, 22);
            menuEditCut.Text = "&Cut";
            menuEditCut.Click += menuEditCut_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(144, 6);
            // 
            // menuEditCopy
            // 
            menuEditCopy.Image = Properties.Resources.copy;
            menuEditCopy.Name = "menuEditCopy";
            menuEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            menuEditCopy.Size = new Size(147, 22);
            menuEditCopy.Text = "&Copy";
            menuEditCopy.Click += menuEditCopy_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(144, 6);
            // 
            // menuEditPaste
            // 
            menuEditPaste.Image = Properties.Resources.paste;
            menuEditPaste.Name = "menuEditPaste";
            menuEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            menuEditPaste.Size = new Size(147, 22);
            menuEditPaste.Text = "&Paste";
            menuEditPaste.Click += menuEditPaste_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(144, 6);
            // 
            // menuEditFormat
            // 
            menuEditFormat.Image = Properties.Resources.font1;
            menuEditFormat.Name = "menuEditFormat";
            menuEditFormat.Size = new Size(147, 22);
            menuEditFormat.Text = "&Format";
            menuEditFormat.Click += menuEditFormat_Click;
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Image = Properties.Resources._new;
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.Size = new Size(147, 22);
            addCategoryToolStripMenuItem.Text = "Add Category";
            addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
            // 
            // menuView
            // 
            menuView.DropDownItems.AddRange(new ToolStripItem[] { menuViewNotesList, toolStripMenuItem5, menuViewArrange });
            menuView.Name = "menuView";
            menuView.Size = new Size(44, 20);
            menuView.Text = "&View";
            // 
            // menuViewNotesList
            // 
            menuViewNotesList.Image = (Image)resources.GetObject("menuViewNotesList.Image");
            menuViewNotesList.Name = "menuViewNotesList";
            menuViewNotesList.Size = new Size(168, 22);
            menuViewNotesList.Text = "&Notes List";
            menuViewNotesList.Click += menuViewNotesList_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(165, 6);
            // 
            // menuViewArrange
            // 
            menuViewArrange.DropDownItems.AddRange(new ToolStripItem[] { menuViewArrangeCascade, menuViewArrangeTile });
            menuViewArrange.Image = Properties.Resources.list21;
            menuViewArrange.Name = "menuViewArrange";
            menuViewArrange.Size = new Size(168, 22);
            menuViewArrange.Text = "Arrange &Windows";
            // 
            // menuViewArrangeCascade
            // 
            menuViewArrangeCascade.Image = Properties.Resources.list1;
            menuViewArrangeCascade.Name = "menuViewArrangeCascade";
            menuViewArrangeCascade.Size = new Size(118, 22);
            menuViewArrangeCascade.Text = "&Cascade";
            menuViewArrangeCascade.Click += menuViewArrangeCascade_Click;
            // 
            // menuViewArrangeTile
            // 
            menuViewArrangeTile.Image = Properties.Resources.list22;
            menuViewArrangeTile.Name = "menuViewArrangeTile";
            menuViewArrangeTile.Size = new Size(118, 22);
            menuViewArrangeTile.Text = "&Tile";
            menuViewArrangeTile.Click += menuViewArrangeTile_Click;
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuHelpAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 20);
            menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            menuHelpAbout.Image = Properties.Resources.about;
            menuHelpAbout.Name = "menuHelpAbout";
            menuHelpAbout.Size = new Size(107, 22);
            menuHelpAbout.Text = "&About";
            menuHelpAbout.Click += menuHelpAbout_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // reminderTimer
            // 
            reminderTimer.Enabled = true;
            reminderTimer.Interval = 10000;
            reminderTimer.Tick += reminderTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(790, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuView;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuFileNew;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem menuEditCut;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuEditCopy;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem menuEditPaste;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem menuEditFormat;
        private ToolStripMenuItem menuViewNotesList;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem menuViewArrange;
        private ToolStripMenuItem menuViewArrangeCascade;
        private ToolStripMenuItem menuViewArrangeTile;
        private ToolStripMenuItem menuHelpAbout;
        private ToolStripMenuItem menuFileSave;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripSeparator toolStripMenuItem7;
        private OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer reminderTimer;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
    }
}
