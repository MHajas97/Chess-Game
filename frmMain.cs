using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SharpChess
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>

	public class frmMain : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		
		const int SQUARE_SIZE = 48;
		const int INTELLEGENCE_HUMAN = 0;


		private System.Drawing.Color BOARD_SQUARE_COLOUR_WHITE = System.Drawing.Color.FromArgb(229,197,105);
		private System.Drawing.Color BOARD_SQUARE_COLOUR_BLACK = System.Drawing.Color.FromArgb(189,117,53);

		Square m_squareFrom = null;
		Moves m_movesPossible = new Moves();
		private System.ComponentModel.IContainer components;
		private Game m_game;
		private System.Windows.Forms.StatusBar sbr;
		PictureBox[,] m_picSquares;
		PictureBox[] m_picWhitesCaptures;
		private System.Windows.Forms.ImageList imgPieces;
		private System.Windows.Forms.MainMenu mnu;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuHelp;
	
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem mnuSep1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuUndoMove;
		private System.Windows.Forms.MenuItem mnuSep2;
		private System.Windows.Forms.ToolBar tbr;
		private System.Windows.Forms.ToolBarButton tbrNew;
		private System.Windows.Forms.ImageList imgToolMenus;
		private System.Windows.Forms.ToolBarButton tbrUndoMove;
		private System.Windows.Forms.ToolBarButton tbrSep2;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Label lblStage;
		private System.Windows.Forms.ListView lvwMoveHistory;
		private System.Windows.Forms.ColumnHeader lvcMoveNo;
		private System.Windows.Forms.ProgressBar pbr;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnlEdging;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ImageList imgTiles;
		private System.Windows.Forms.TreeView tvwMoves;
		private System.Windows.Forms.MenuItem mnuRedoMove;
		private System.Windows.Forms.MenuItem mnuUndoAllMoves;
		private System.Windows.Forms.ToolBarButton tbrRedoMove;
		private System.Windows.Forms.ToolBarButton tbrUndoAllMoves;
		private System.Windows.Forms.ToolBarButton tbrRedoAllMoves;
		private System.Windows.Forms.MenuItem mnuRedoAllMoves;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Label lblBlackClock;
		private System.Windows.Forms.Label lblBlackScore;
		private System.Windows.Forms.Label lblBlackPoints;
		private System.Windows.Forms.Label lblWhiteClock;
		private System.Windows.Forms.Label lblWhiteScore;
		private System.Windows.Forms.Label lblWhitePoints;
		private System.Windows.Forms.Label lblPlayerClocks;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ToolBarButton tbrResumePlay;
		private System.Windows.Forms.ToolBarButton tbrPausePlay;
		private System.Windows.Forms.MenuItem mnuResumePlay;
		private System.Windows.Forms.MenuItem mnuPausePlay;
		private System.Windows.Forms.ColumnHeader lvcTime;
		private System.Windows.Forms.ColumnHeader lvcMove;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		PictureBox[] m_picBlacksCaptures;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sbr = new System.Windows.Forms.StatusBar();
            this.imgPieces = new System.Windows.Forms.ImageList(this.components);
            this.mnu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuSep1 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuResumePlay = new System.Windows.Forms.MenuItem();
            this.mnuPausePlay = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuUndoMove = new System.Windows.Forms.MenuItem();
            this.mnuRedoMove = new System.Windows.Forms.MenuItem();
            this.mnuUndoAllMoves = new System.Windows.Forms.MenuItem();
            this.mnuRedoAllMoves = new System.Windows.Forms.MenuItem();
            this.mnuSep2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.tbr = new System.Windows.Forms.ToolBar();
            this.tbrNew = new System.Windows.Forms.ToolBarButton();
            this.tbrUndoAllMoves = new System.Windows.Forms.ToolBarButton();
            this.tbrUndoMove = new System.Windows.Forms.ToolBarButton();
            this.tbrResumePlay = new System.Windows.Forms.ToolBarButton();
            this.tbrPausePlay = new System.Windows.Forms.ToolBarButton();
            this.tbrRedoMove = new System.Windows.Forms.ToolBarButton();
            this.tbrRedoAllMoves = new System.Windows.Forms.ToolBarButton();
            this.tbrSep2 = new System.Windows.Forms.ToolBarButton();
            this.imgToolMenus = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBlackClock = new System.Windows.Forms.Label();
            this.lblBlackScore = new System.Windows.Forms.Label();
            this.lblBlackPoints = new System.Windows.Forms.Label();
            this.lblWhiteClock = new System.Windows.Forms.Label();
            this.lblWhiteScore = new System.Windows.Forms.Label();
            this.lblWhitePoints = new System.Windows.Forms.Label();
            this.lblPlayerClocks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.lblStage = new System.Windows.Forms.Label();
            this.lvwMoveHistory = new System.Windows.Forms.ListView();
            this.lvcMoveNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlEdging = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgTiles = new System.Windows.Forms.ImageList(this.components);
            this.tvwMoves = new System.Windows.Forms.TreeView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlEdging.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbr
            // 
            this.sbr.Location = new System.Drawing.Point(0, 576);
            this.sbr.Name = "sbr";
            this.sbr.Size = new System.Drawing.Size(892, 19);
            this.sbr.SizingGrip = false;
            this.sbr.TabIndex = 7;
            // 
            // imgPieces
            // 
            this.imgPieces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPieces.ImageStream")));
            this.imgPieces.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPieces.Images.SetKeyName(0, "");
            this.imgPieces.Images.SetKeyName(1, "");
            this.imgPieces.Images.SetKeyName(2, "");
            this.imgPieces.Images.SetKeyName(3, "");
            this.imgPieces.Images.SetKeyName(4, "");
            this.imgPieces.Images.SetKeyName(5, "");
            this.imgPieces.Images.SetKeyName(6, "");
            this.imgPieces.Images.SetKeyName(7, "");
            this.imgPieces.Images.SetKeyName(8, "");
            this.imgPieces.Images.SetKeyName(9, "");
            this.imgPieces.Images.SetKeyName(10, "");
            this.imgPieces.Images.SetKeyName(11, "");
            // 
            // mnu
            // 
            this.mnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.menuItem2,
            this.menuItem1});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNew,
            this.mnuSep1,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.Index = 0;
            this.mnuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Index = 1;
            this.mnuSep1.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 2;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuResumePlay,
            this.mnuPausePlay});
            this.menuItem2.Text = "&Game";
            // 
            // mnuResumePlay
            // 
            this.mnuResumePlay.Index = 0;
            this.mnuResumePlay.Text = "&Resume";
            // 
            // mnuPausePlay
            // 
            this.mnuPausePlay.Enabled = false;
            this.mnuPausePlay.Index = 1;
            this.mnuPausePlay.Text = "&Pause";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuUndoMove,
            this.mnuRedoMove,
            this.mnuUndoAllMoves,
            this.mnuRedoAllMoves,
            this.mnuSep2});
            this.menuItem1.Text = "&Move";
            // 
            // mnuUndoMove
            // 
            this.mnuUndoMove.Index = 0;
            this.mnuUndoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.mnuUndoMove.Text = "&Undo Move";
            this.mnuUndoMove.Click += new System.EventHandler(this.mnuUndoMove_Click);
            // 
            // mnuRedoMove
            // 
            this.mnuRedoMove.Index = 1;
            this.mnuRedoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.mnuRedoMove.Text = "&Redo Move";
            // 
            // mnuUndoAllMoves
            // 
            this.mnuUndoAllMoves.Index = 2;
            this.mnuUndoAllMoves.Text = "U&ndo All Moves";
            // 
            // mnuRedoAllMoves
            // 
            this.mnuRedoAllMoves.Index = 3;
            this.mnuRedoAllMoves.Text = "Re&do All Moves";
            // 
            // mnuSep2
            // 
            this.mnuSep2.Index = 4;
            this.mnuSep2.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "-";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = -1;
            this.mnuHelp.Text = "";
            // 
            // tbr
            // 
            this.tbr.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbr.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbrNew,
            this.tbrUndoAllMoves,
            this.tbrUndoMove,
            this.tbrResumePlay,
            this.tbrPausePlay,
            this.tbrRedoMove,
            this.tbrRedoAllMoves,
            this.tbrSep2});
            this.tbr.DropDownArrows = true;
            this.tbr.ImageList = this.imgToolMenus;
            this.tbr.Location = new System.Drawing.Point(0, 0);
            this.tbr.Name = "tbr";
            this.tbr.ShowToolTips = true;
            this.tbr.Size = new System.Drawing.Size(892, 28);
            this.tbr.TabIndex = 32;
            this.tbr.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbr.Wrappable = false;
            this.tbr.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbr_ButtonClick);
            // 
            // tbrNew
            // 
            this.tbrNew.ImageIndex = 0;
            this.tbrNew.Name = "tbrNew";
            this.tbrNew.Tag = "New";
            this.tbrNew.ToolTipText = "Start a new chess game";
            // 
            // tbrUndoAllMoves
            // 
            this.tbrUndoAllMoves.ImageIndex = 6;
            this.tbrUndoAllMoves.Name = "tbrUndoAllMoves";
            this.tbrUndoAllMoves.Tag = "UndoAllMoves";
            this.tbrUndoAllMoves.ToolTipText = "Undo all moves played so far";
            // 
            // tbrUndoMove
            // 
            this.tbrUndoMove.ImageIndex = 4;
            this.tbrUndoMove.Name = "tbrUndoMove";
            this.tbrUndoMove.Tag = "UndoMove";
            this.tbrUndoMove.ToolTipText = "Undo the last move";
            // 
            // tbrResumePlay
            // 
            this.tbrResumePlay.ImageIndex = 8;
            this.tbrResumePlay.Name = "tbrResumePlay";
            this.tbrResumePlay.Tag = "ResumePlay";
            this.tbrResumePlay.ToolTipText = "Resume play";
            // 
            // tbrPausePlay
            // 
            this.tbrPausePlay.Enabled = false;
            this.tbrPausePlay.ImageIndex = 9;
            this.tbrPausePlay.Name = "tbrPausePlay";
            this.tbrPausePlay.Tag = "PausePlay";
            this.tbrPausePlay.ToolTipText = "Pause play";
            // 
            // tbrRedoMove
            // 
            this.tbrRedoMove.ImageIndex = 5;
            this.tbrRedoMove.Name = "tbrRedoMove";
            this.tbrRedoMove.Tag = "RedoMove";
            this.tbrRedoMove.ToolTipText = "Redo move";
            // 
            // tbrRedoAllMoves
            // 
            this.tbrRedoAllMoves.ImageIndex = 7;
            this.tbrRedoAllMoves.Name = "tbrRedoAllMoves";
            this.tbrRedoAllMoves.Tag = "RedoAllMoves";
            this.tbrRedoAllMoves.ToolTipText = "Redo all moves";
            // 
            // tbrSep2
            // 
            this.tbrSep2.Name = "tbrSep2";
            this.tbrSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // imgToolMenus
            // 
            this.imgToolMenus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolMenus.ImageStream")));
            this.imgToolMenus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgToolMenus.Images.SetKeyName(0, "");
            this.imgToolMenus.Images.SetKeyName(1, "");
            this.imgToolMenus.Images.SetKeyName(2, "");
            this.imgToolMenus.Images.SetKeyName(3, "");
            this.imgToolMenus.Images.SetKeyName(4, "");
            this.imgToolMenus.Images.SetKeyName(5, "");
            this.imgToolMenus.Images.SetKeyName(6, "");
            this.imgToolMenus.Images.SetKeyName(7, "");
            this.imgToolMenus.Images.SetKeyName(8, "");
            this.imgToolMenus.Images.SetKeyName(9, "");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lblBlackClock);
            this.pnlMain.Controls.Add(this.lblBlackScore);
            this.pnlMain.Controls.Add(this.lblBlackPoints);
            this.pnlMain.Controls.Add(this.lblWhiteClock);
            this.pnlMain.Controls.Add(this.lblWhiteScore);
            this.pnlMain.Controls.Add(this.lblWhitePoints);
            this.pnlMain.Controls.Add(this.lblPlayerClocks);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pbr);
            this.pnlMain.Controls.Add(this.lblStage);
            this.pnlMain.Controls.Add(this.lvwMoveHistory);
            this.pnlMain.Controls.Add(this.pnlEdging);
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(892, 892);
            this.pnlMain.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 136;
            this.label5.Text = "Black";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 135;
            this.label3.Text = "White";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackClock
            // 
            this.lblBlackClock.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackClock.CausesValidation = false;
            this.lblBlackClock.Location = new System.Drawing.Point(673, 67);
            this.lblBlackClock.Name = "lblBlackClock";
            this.lblBlackClock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackClock.Size = new System.Drawing.Size(115, 26);
            this.lblBlackClock.TabIndex = 130;
            this.lblBlackClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackScore
            // 
            this.lblBlackScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackScore.CausesValidation = false;
            this.lblBlackScore.Location = new System.Drawing.Point(673, 104);
            this.lblBlackScore.Name = "lblBlackScore";
            this.lblBlackScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackScore.Size = new System.Drawing.Size(115, 26);
            this.lblBlackScore.TabIndex = 127;
            this.lblBlackScore.Text = "0";
            this.lblBlackScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackPoints
            // 
            this.lblBlackPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackPoints.CausesValidation = false;
            this.lblBlackPoints.Location = new System.Drawing.Point(673, 132);
            this.lblBlackPoints.Name = "lblBlackPoints";
            this.lblBlackPoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackPoints.Size = new System.Drawing.Size(115, 27);
            this.lblBlackPoints.TabIndex = 125;
            this.lblBlackPoints.Text = "0";
            this.lblBlackPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteClock
            // 
            this.lblWhiteClock.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhiteClock.CausesValidation = false;
            this.lblWhiteClock.Location = new System.Drawing.Point(548, 67);
            this.lblWhiteClock.Name = "lblWhiteClock";
            this.lblWhiteClock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhiteClock.Size = new System.Drawing.Size(115, 26);
            this.lblWhiteClock.TabIndex = 124;
            this.lblWhiteClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteScore
            // 
            this.lblWhiteScore.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhiteScore.CausesValidation = false;
            this.lblWhiteScore.Location = new System.Drawing.Point(548, 104);
            this.lblWhiteScore.Name = "lblWhiteScore";
            this.lblWhiteScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhiteScore.Size = new System.Drawing.Size(115, 26);
            this.lblWhiteScore.TabIndex = 121;
            this.lblWhiteScore.Text = "0";
            this.lblWhiteScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitePoints
            // 
            this.lblWhitePoints.BackColor = System.Drawing.Color.Transparent;
            this.lblWhitePoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhitePoints.CausesValidation = false;
            this.lblWhitePoints.Location = new System.Drawing.Point(548, 132);
            this.lblWhitePoints.Name = "lblWhitePoints";
            this.lblWhitePoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhitePoints.Size = new System.Drawing.Size(115, 27);
            this.lblWhitePoints.TabIndex = 119;
            this.lblWhitePoints.Text = "0";
            this.lblWhitePoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerClocks
            // 
            this.lblPlayerClocks.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerClocks.Location = new System.Drawing.Point(481, 67);
            this.lblPlayerClocks.Name = "lblPlayerClocks";
            this.lblPlayerClocks.Size = new System.Drawing.Size(57, 28);
            this.lblPlayerClocks.TabIndex = 118;
            this.lblPlayerClocks.Text = "Clock";
            this.lblPlayerClocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(490, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 27);
            this.label4.TabIndex = 115;
            this.label4.Text = "Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(490, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 114;
            this.label1.Text = "Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(464, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 426);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(29, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 9);
            this.panel4.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(29, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 429);
            this.panel2.TabIndex = 56;
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(0, 612);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(883, 26);
            this.pbr.TabIndex = 54;
            // 
            // lblStage
            // 
            this.lblStage.BackColor = System.Drawing.Color.Transparent;
            this.lblStage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStage.CausesValidation = false;
            this.lblStage.Location = new System.Drawing.Point(478, 396);
            this.lblStage.Name = "lblStage";
            this.lblStage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStage.Size = new System.Drawing.Size(374, 26);
            this.lblStage.TabIndex = 50;
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwMoveHistory
            // 
            this.lvwMoveHistory.BackColor = System.Drawing.SystemColors.Control;
            this.lvwMoveHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcMoveNo,
            this.lvcTime,
            this.lvcMove});
            this.lvwMoveHistory.Location = new System.Drawing.Point(479, 162);
            this.lvwMoveHistory.Name = "lvwMoveHistory";
            this.lvwMoveHistory.Size = new System.Drawing.Size(373, 231);
            this.lvwMoveHistory.TabIndex = 39;
            this.lvwMoveHistory.UseCompatibleStateImageBehavior = false;
            this.lvwMoveHistory.View = System.Windows.Forms.View.Details;
            // 
            // lvcMoveNo
            // 
            this.lvcMoveNo.Text = "#";
            this.lvcMoveNo.Width = 19;
            // 
            // lvcTime
            // 
            this.lvcTime.Text = "Time";
            this.lvcTime.Width = 56;
            // 
            // lvcMove
            // 
            this.lvcMove.Text = "Move";
            this.lvcMove.Width = 215;
            // 
            // pnlEdging
            // 
            this.pnlEdging.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEdging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdging.Controls.Add(this.panel1);
            this.pnlEdging.Location = new System.Drawing.Point(34, 15);
            this.pnlEdging.Name = "pnlEdging";
            this.pnlEdging.Size = new System.Drawing.Size(439, 423);
            this.pnlEdging.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 10);
            this.panel1.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 9);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // imgTiles
            // 
            this.imgTiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTiles.ImageStream")));
            this.imgTiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTiles.Images.SetKeyName(0, "");
            this.imgTiles.Images.SetKeyName(1, "");
            // 
            // tvwMoves
            // 
            this.tvwMoves.BackColor = System.Drawing.SystemColors.Control;
            this.tvwMoves.Location = new System.Drawing.Point(893, 9);
            this.tvwMoves.Name = "tvwMoves";
            this.tvwMoves.Size = new System.Drawing.Size(528, 674);
            this.tvwMoves.TabIndex = 63;
            this.tvwMoves.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwMoves_AfterExpand);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(892, 595);
            this.Controls.Add(this.tvwMoves);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.sbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mnu;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpChess";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlEdging.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		Square m_squareLastFrom = null;
		Square m_squareLastTo = null;

		public void MoveConsidered()
		{
			RenderStatus();

			if (m_squareLastFrom != null)
			{
				m_picSquares[m_squareLastFrom.File, m_squareLastFrom.Rank].BackColor = (m_squareLastFrom.Colour==Square.enmColour.White ? BOARD_SQUARE_COLOUR_WHITE : BOARD_SQUARE_COLOUR_BLACK);
				m_picSquares[m_squareLastFrom.File, m_squareLastFrom.Rank].Refresh();
			}
			if (Game.ShowThinking)
			{
				m_squareLastFrom = Game.PlayerToPlay.CurrentMove.From;
				m_picSquares[m_squareLastFrom.File, m_squareLastFrom.Rank].BackColor=System.Drawing.Color.Yellow;
				m_picSquares[m_squareLastFrom.File, m_squareLastFrom.Rank].Refresh();
			}

			if (m_squareLastTo != null)
			{
				m_picSquares[m_squareLastTo.File, m_squareLastTo.Rank].BackColor = (m_squareLastTo.Colour==Square.enmColour.White ? BOARD_SQUARE_COLOUR_WHITE : BOARD_SQUARE_COLOUR_BLACK);
				m_picSquares[m_squareLastTo.File, m_squareLastTo.Rank].Refresh();
			}
			if (Game.ShowThinking)
			{
				m_squareLastTo = Game.PlayerToPlay.CurrentMove.To;
				m_picSquares[m_squareLastTo.File, m_squareLastTo.Rank].BackColor=System.Drawing.Color.Yellow;
				m_picSquares[m_squareLastTo.File, m_squareLastTo.Rank].Refresh();
			}

			SetFormState();

			Application.DoEvents();
		}	

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			m_game = new Game();

			Game.PlayerWhite.MoveConsidered += new delegateGameEvent(MoveConsidered);
			Game.PlayerBlack.MoveConsidered += new delegateGameEvent(MoveConsidered);
			
		

			CreateBoard();
			RenderBoard();
			RenderClocks();
			this.Text = Application.ProductName + " - " + Game.FileName;
			SizeMainForm();

			timer.Start();

			SetFormState();
		}



		private void RenderClocks()
		{
			lblWhiteClock.Text = Game.PlayerWhite.Clock.TimeElapsed.Hours.ToString().PadLeft(2,'0') + ":" + Game.PlayerWhite.Clock.TimeElapsed.Minutes.ToString().PadLeft(2,'0') + ":" + Game.PlayerWhite.Clock.TimeElapsed.Seconds.ToString().PadLeft(2,'0');
			lblBlackClock.Text = Game.PlayerBlack.Clock.TimeElapsed.Hours.ToString().PadLeft(2,'0') + ":" + Game.PlayerBlack.Clock.TimeElapsed.Minutes.ToString().PadLeft(2,'0') + ":" + Game.PlayerBlack.Clock.TimeElapsed.Seconds.ToString().PadLeft(2,'0');
		}

		private void RenderBoard()
		{
			Square square;

			for (int intOrdinal=0; intOrdinal<Board.SQUARE_COUNT; intOrdinal++)
			{
				square = Board.GetSquare(intOrdinal);
				
				if (square!=null)
				{
					if (square.Colour == Square.enmColour.White)
					{
						m_picSquares[square.File, square.Rank].BackColor = BOARD_SQUARE_COLOUR_WHITE;
					}
					else
					{
						m_picSquares[square.File, square.Rank].BackColor = BOARD_SQUARE_COLOUR_BLACK;
					}

					if (square.Piece == null)
					{
						m_picSquares[square.File, square.Rank].Image = null;
					}
					else
					{
						m_picSquares[square.File, square.Rank].Image = GetPieceImage(square.Piece);
					}

					m_picSquares[square.File, square.Rank].BorderStyle = System.Windows.Forms.BorderStyle.None;
				}
			}

			// Render selection highlights
			if (m_squareFrom!=null)
			{
				m_picSquares[m_squareFrom.File, m_squareFrom.Rank].BackColor = Color.Blue;
				foreach (Move move in m_movesPossible)
				{
					m_picSquares[move.To.File, move.To.Rank].BackColor = Color.LightBlue;
				}
			}

			// Render Last Move highlights
			if (Game.MoveHistory.Count>0)
			{
				m_picSquares[Game.MoveHistory.Item(Game.MoveHistory.Count-1).From.File, Game.MoveHistory.Item(Game.MoveHistory.Count-1).From.Rank].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				m_picSquares[Game.MoveHistory.Item(Game.MoveHistory.Count-1).To.File  , Game.MoveHistory.Item(Game.MoveHistory.Count-1).To.Rank  ].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			}

			// Render pieces taken
			for (int intIndex=0; intIndex<15; intIndex++)
			{
				m_picWhitesCaptures[intIndex].Image = null;
				m_picBlacksCaptures[intIndex].Image = null;
			}
			for (int intIndex=0; intIndex<Game.PlayerWhite.CapturedEnemyPieces.Count; intIndex++)
			{
				m_picWhitesCaptures[intIndex].Image = GetPieceImage(Game.PlayerWhite.CapturedEnemyPieces.Item(intIndex));
			}
			for (int intIndex=0; intIndex<Game.PlayerBlack.CapturedEnemyPieces.Count; intIndex++)
			{
				m_picBlacksCaptures[intIndex].Image = GetPieceImage(Game.PlayerBlack.CapturedEnemyPieces.Item(intIndex));
			}

			// Render player status
			if (Game.PlayerToPlay == Game.PlayerWhite)
			{
				lblWhiteScore.BackColor = Game.PlayerWhite.Status==Player.enmStatus.InCheckMate ? Color.Red : (Game.PlayerWhite.IsInCheck ? Color.Orange: Color.FromName(System.Drawing.KnownColor.Control.ToString()) );
				lblBlackScore.BackColor = Color.FromName(System.Drawing.KnownColor.Control.ToString());
				lblWhiteClock.BackColor = Color.LightGray;
				lblBlackClock.BackColor = Color.FromName(System.Drawing.KnownColor.Control.ToString());
			}
			else
			{
				lblWhiteScore.BackColor = Color.FromName(System.Drawing.KnownColor.Control.ToString());
				lblBlackScore.BackColor = Game.PlayerBlack.Status==Player.enmStatus.InCheckMate ? Color.Red : (Game.PlayerBlack.IsInCheck ? Color.Orange : Color.FromName(System.Drawing.KnownColor.Control.ToString()) );
				lblBlackClock.BackColor = Color.LightGray;
				lblWhiteClock.BackColor = Color.FromName(System.Drawing.KnownColor.Control.ToString());
			}
			// Set form state

			lblWhitePoints.Text = Game.PlayerWhite.Points.ToString();
			lblBlackPoints.Text = Game.PlayerBlack.Points.ToString();

			lblWhiteScore.Text = Game.PlayerWhite.Score.ToString();
			lblBlackScore.Text = Game.PlayerBlack.Score.ToString();

			lblStage.Text = Game.Stage.ToString() + " Game - " + Game.PlayerToPlay.Colour.ToString() + " to play";
//			lblStage.Text = "A: " + Board.HashCodeA.ToString() + "     B: " + Board.HashCodeB.ToString();

			// Update move history
			while (lvwMoveHistory.Items.Count < Game.MoveHistory.Count)
			{
				AddMoveToHistory(Game.MoveHistory.Item(lvwMoveHistory.Items.Count));
			}
			while (lvwMoveHistory.Items.Count > Game.MoveHistory.Count)
			{
				RemoveLastHistoryItem();
			}

			SetFormState();

			this.Refresh();
		}

		private Image GetPieceImage(Piece piece)
		{
			return imgPieces.Images[piece.ImageIndex];
		}

		private void RenderStatus()
		{
			Player playerToPlay = Game.PlayerToPlay;

			sbr.Text = (playerToPlay.SearchDepth==0) ? "" : 
				(
					"Ply: " + playerToPlay.SearchDepth.ToString() + "/" + playerToPlay.MaxSearchDepth.ToString() 
					+ ". Move: " + playerToPlay.CurrentMoveNo.ToString() + " / " + playerToPlay.TotalMoves.ToString() 
					+ ". Secs: " + ((int)(playerToPlay.ThinkingTimeRemaining.TotalSeconds)).ToString() + "/" + ((int)playerToPlay.ThinkingTimeAllotted.TotalSeconds).ToString() 
					+ (!Game.ShowThinking ? "" : (". Best: " + ((playerToPlay.BestMove==null) ? "" : playerToPlay.BestMove.Piece.Name.ToString() + " " + playerToPlay.BestMove.From.Name+"-"+playerToPlay.BestMove.To.Name + " " + playerToPlay.BestMove.Description + " Score: " + playerToPlay.BestMove.Score)))
					+ " Positions: " + playerToPlay.PositionsSearched + " MaxQDepth: " + playerToPlay.MaxQuiesDepth
					+ " P:" + HashTable.Probes
					+ " H:" + HashTable.Hits
					+ " W:" + HashTable.Writes 
					+ " C:" + HashTable.Collisions
					+ " O:" + HashTable.Overwrites
				);

			pbr.Maximum = Math.Max(playerToPlay.TotalMoves, playerToPlay.CurrentMoveNo);
			pbr.Value = playerToPlay.CurrentMoveNo;
			sbr.Refresh();
			pbr.Refresh();
		}

		private void SetFormState()
		{
			mnuNew.Enabled = !Game.PlayerToPlay.IsThinking;
			mnuUndoMove.Enabled = (!Game.PlayerToPlay.IsThinking && Game.MoveHistory.Count>0);
			mnuRedoMove.Enabled = (!Game.PlayerToPlay.IsThinking && Game.MoveRedoList.Count>0);
			mnuUndoAllMoves.Enabled = mnuUndoMove.Enabled;
			mnuRedoAllMoves.Enabled = mnuRedoMove.Enabled;
			mnuResumePlay.Enabled = (!Game.PlayerToPlay.IsThinking && !Game.PlayerToPlay.Clock.IsTicking); 
			mnuPausePlay.Enabled = (!Game.PlayerToPlay.IsThinking && Game.PlayerToPlay.Clock.IsTicking);

			tbrNew.Enabled = mnuNew.Enabled;
			tbrUndoMove.Enabled = mnuUndoMove.Enabled;
			tbrRedoMove.Enabled = mnuRedoMove.Enabled;
			tbrUndoAllMoves.Enabled = mnuUndoAllMoves.Enabled;
			tbrRedoAllMoves.Enabled = mnuRedoAllMoves.Enabled;
			tbrResumePlay.Enabled = mnuResumePlay.Enabled;
			tbrPausePlay.Enabled = mnuPausePlay.Enabled;
			
			
		}

		private void CreateBoard()
		{
			PictureBox picSquare;
			Square square;
			Label lblRank;
			Label lblFile;

			for (int intRank=0; intRank<Board.RANK_COUNT; intRank++)
			{
				lblRank = new System.Windows.Forms.Label();
				lblRank.BackColor = System.Drawing.Color.Transparent;
				lblRank.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				lblRank.Name = "lblRank" + intRank.ToString();
				lblRank.Size = new System.Drawing.Size(24, 48);
				lblRank.TabIndex = 12;
				lblRank.Text = Board.GetSquare(0, intRank).RankName;
				lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				lblRank.Left = 0;
				lblRank.Top = (Board.RANK_COUNT-1)*SQUARE_SIZE - intRank*SQUARE_SIZE + 16;
				pnlMain.Controls.Add( lblRank );
			}

			m_picSquares = new PictureBox[Board.FILE_COUNT, Board.RANK_COUNT];

			for (int intFile=0; intFile<Board.FILE_COUNT; intFile++)
			{

				lblFile = new System.Windows.Forms.Label();
				lblFile.BackColor = System.Drawing.Color.Transparent;
				lblFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				lblFile.Name = "lblFile" + intFile.ToString();
				lblFile.Size = new System.Drawing.Size(48, 24);
				lblFile.TabIndex = 12;
				lblFile.Text = Board.GetSquare(intFile, 0).FileName;
				lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				lblFile.Left = intFile*SQUARE_SIZE + 30;
				lblFile.Top = (Board.RANK_COUNT)*SQUARE_SIZE + 24;
				pnlMain.Controls.Add( lblFile );
				
			}

			for (int intOrdinal=0; intOrdinal<Board.SQUARE_COUNT; intOrdinal++)
			{
				square = Board.GetSquare(intOrdinal);

				if (square!=null)
				{
					picSquare = new System.Windows.Forms.PictureBox();

					picSquare.Left = square.File*SQUARE_SIZE + 1;
					picSquare.Top = (Board.RANK_COUNT-1)*SQUARE_SIZE - square.Rank*SQUARE_SIZE + 1;
					if (square.Colour == Square.enmColour.White)
					{
						picSquare.BackColor = BOARD_SQUARE_COLOUR_WHITE;
					}
					else
					{
						picSquare.BackColor = BOARD_SQUARE_COLOUR_BLACK;
					}
					picSquare.Name = "picSquare" + square.File.ToString() + square.Rank.ToString();
					picSquare.Size = new System.Drawing.Size(SQUARE_SIZE, SQUARE_SIZE);
					picSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
					picSquare.TabIndex = 0;
					picSquare.TabStop = false;
					picSquare.Tag = square.Ordinal;
					picSquare.Click += new System.EventHandler(this.picSquare_Click);
					pnlEdging.Controls.Add( picSquare );
					m_picSquares[square.File, square.Rank] = picSquare;
				}
			}

			m_picWhitesCaptures = new PictureBox[15];
			m_picBlacksCaptures = new PictureBox[15];

			for (int intIndex=0; intIndex<15; intIndex++)
			{
				picSquare = new System.Windows.Forms.PictureBox();
				picSquare.Left = intIndex*(SQUARE_SIZE+1)+1;
				picSquare.Top = 432;
				picSquare.BackColor = System.Drawing.SystemColors.ControlDark;
				picSquare.Name = "picSquareWhite" + intIndex.ToString();
				picSquare.Size = new System.Drawing.Size(SQUARE_SIZE, SQUARE_SIZE);
				picSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				picSquare.TabIndex = 0;
				picSquare.TabStop = false;
				picSquare.Tag = intIndex;
				pnlMain.Controls.Add( picSquare );
				m_picWhitesCaptures[intIndex] = picSquare;

				picSquare = new System.Windows.Forms.PictureBox();
				picSquare.Left = intIndex*(SQUARE_SIZE+1)+1;
				picSquare.Top = 432 + SQUARE_SIZE+1;
				picSquare.BackColor = System.Drawing.SystemColors.ControlDark;
				picSquare.Name = "picSquareBlack" + intIndex.ToString();
				picSquare.Size = new System.Drawing.Size(SQUARE_SIZE, SQUARE_SIZE);
				picSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				picSquare.TabIndex = 0;
				picSquare.TabStop = false;
				picSquare.Tag = intIndex;
				pnlMain.Controls.Add( picSquare );
				m_picBlacksCaptures[intIndex] = picSquare;
			}
		}

		private void picSquare_Click(object sender, System.EventArgs e)
		{
			int intOrdinal = Convert.ToInt32( ((PictureBox)sender).Tag );

			if (m_squareFrom==null)
			{
				// No current selection

				Square squareClicked = Board.GetSquare(intOrdinal);

				Piece piece = squareClicked.Piece;
				if (piece!=null && piece.Player.Colour==Game.PlayerToPlay.Colour)
				{
					// Mark possible moves
					m_squareFrom = squareClicked;
					m_movesPossible = new Moves();
					piece.GenerateLegalMoves(m_movesPossible);
				}
				else
				{
					// No piece on square
					m_squareFrom = null;
					m_movesPossible = new Moves();
				}
			}
			else
			{
				Square squareClicked = Board.GetSquare(intOrdinal);

				Piece piece = squareClicked.Piece;
				if (piece==null || piece!=null && piece.Player.Colour!=Game.PlayerToPlay.Colour)
				{
					// Is square one of the possible moves? If it is, then move the piece
					foreach (Move move in m_movesPossible)
					{
						if (move.To == squareClicked)
						{
							m_squareFrom = null;
							m_movesPossible = new Moves();

							MakeAHumanMove(move.Name, move.Piece, move.To);
							break; 
						}
					}
					m_squareFrom = null;
					m_movesPossible = new Moves();
				}
				else if (piece!=null && piece==m_squareFrom.Piece)
				{
					// Same piece clicked again, so unselect
					m_squareFrom = null;
					m_movesPossible = new Moves();
				}
				else if (piece!=null) // Must be own piece
				{
					// Mark possible moves
					m_movesPossible = new Moves();
					m_squareFrom = squareClicked;
					m_squareFrom.Piece.GenerateLegalMoves(m_movesPossible);
				}
				else
				{
					// No piece on square
					m_squareFrom = null;
					m_movesPossible = new Moves();
				}
			}

			RenderBoard();
		}


		private void MakeAHumanMove(Move.enmName MoveName, Piece piece, Square square)
		{
			Game.MakeAMove(MoveName, piece, square);
			RenderBoard();
		}


		private void mnuUndoMove_Click(object sender, System.EventArgs e)
		{
			UndoMove();
		}

		private void AddMoveToHistory(Move move)
		{
			string[] lvi = {	move.MoveNo.ToString(), move.TimeStamp.Hours.ToString().PadLeft(2,'0') + ":" + move.TimeStamp.Minutes.ToString().PadLeft(2,'0') + ":" + move.TimeStamp.Seconds.ToString().PadLeft(2,'0') 
							   , move.Piece.Player.Colour.ToString() + " "
							   + move.Piece.Name.ToString() + " "
							   + move.From.Name 
							   + (move.PieceTaken!=null?"x":"-")
							   + move.To.Name 
							   + move.Description
						   };

			lvwMoveHistory.Items.Add( new ListViewItem( lvi ) );
			switch (move.Piece.Player.Colour)
			{
				case Player.enmColour.White:
					lvwMoveHistory.Items[lvwMoveHistory.Items.Count-1].BackColor = Color.White;
					lvwMoveHistory.Items[lvwMoveHistory.Items.Count-1].ForeColor = Color.Blue;
					break;

				case Player.enmColour.Black:
					lvwMoveHistory.Items[lvwMoveHistory.Items.Count-1].BackColor = Color.White;
					lvwMoveHistory.Items[lvwMoveHistory.Items.Count-1].ForeColor = Color.Black;
					break;
			}
			lvwMoveHistory.Items[lvwMoveHistory.Items.Count-1].EnsureVisible();
		}

		private void RemoveLastHistoryItem()
		{
			lvwMoveHistory.Items.RemoveAt(lvwMoveHistory.Items.Count-1);
			m_squareFrom = null;
			m_movesPossible = new Moves();
		}

		private void RenderMoveAnalysis()
		{
			tvwMoves.Nodes.Clear();
			AddBranch(2, Game.MoveAnalysis, tvwMoves.Nodes);
		}

		private void AddBranch(int intDepth, Moves moves, TreeNodeCollection treeNodes)
		{
			if (intDepth == 0) return;

			TreeNode treeNode;
			if (moves!=null)
			{
				foreach(Move move in moves)
				{
					treeNode = treeNodes.Add( move.DebugText );
					treeNode.Tag = move;
					if (move.Moves!=null && move.Moves.Count>0)
					{
						AddBranch(intDepth-1, move.Moves, treeNode.Nodes);
					}
				}
			}
		}

		private void tvwMoves_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			foreach (TreeNode tn in e.Node.Nodes)
			{
				AddBranch(1, ((Move)tn.Tag).Moves, tn.Nodes);
			}
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void NewGame()
		{
			lvwMoveHistory.Items.Clear();
			Game.New();
			RenderBoard();
			this.Text = Application.ProductName + " - " + Game.FileName;
		}

		private void UndoMove()
		{
			Game.UndoMove();
			RenderBoard();
		}

		private void RedoMove()
		{
			Game.RedoMove();
			RenderBoard();
		}

		private void UndoAllMoves()
		{
			Game.UndoAllMoves();
			RenderBoard();
		}

		private void RedoAllMoves()
		{
			Game.RedoAllMoves();
			RenderBoard();
		}

		private void ResumePlay()
		{
			Game.ResumePlay();
			SetFormState();
		}

		private void PausePlay()
		{
			Game.PausePlay();
			SetFormState();
		}

		

		private void mnuNew_Click(object sender, System.EventArgs e)
		{
			NewGame();
		}




		private void tbr_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(e.Button.Tag.ToString())
			{
				case "New":
					NewGame();
					break; 

				case "UndoMove":
					UndoMove();
					break;

				case "RedoMove":
					RedoMove();
					break;

				case "UndoAllMoves":
					UndoAllMoves();
					break;

				case "RedoAllMoves":
					RedoAllMoves();
					break;

				case "ResumePlay":
					ResumePlay();
					break;

				case "PausePlay":
					PausePlay();
					break;
			}
		}

		private void mnuDisplayMoveAnalysisTree_Click(object sender, System.EventArgs e)
		{
			Game.DisplayMoveAnalysisTree = !Game.DisplayMoveAnalysisTree;
			SizeMainForm();
		}



		private void SizeMainForm()
		{
			this.Width = Game.DisplayMoveAnalysisTree ? 1192: 744;
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			RenderClocks();
		}
	}
}
