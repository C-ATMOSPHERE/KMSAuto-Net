﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.Form1
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    private readonly string[] _systemFileCheck;
    public string[] TaskList;
    private readonly string[] _kmsAutoFileList;
    private readonly string[,] string_0;
    private readonly string[,] _productList8ForChengeOs;
    private readonly string[,] _productListWindowsOffice;
    private readonly string[,] _productListNewOsInstallGvlkKey;
    public bool BackGroundRun;
    public bool LoadingError;
    private const int wbemImpersonationLevelImpersonate = 3;
    private const int wbemAuthenticationLevelPktPrivacy = 6;
    private const int WmiaProductProcessError = -2147217392;
    public object objCtx;
    public object objSWbemLocator;
    public object objWMIService;
    public string TargetLang;
    private int _positionLeft;
    private int _positionTop;
    private int _positionLeftTmp;
    private int _positionTopTmp;
    private bool _meMovePosition;
    public string Tempdir;
    public string Windir;
    private readonly string _systemroot;
    public string Username;
    public string Computername;
    private readonly string _systemdrive;
    private string _programdata;
    private string _programdataKmsauto;
    private readonly string _userprofile;
    private readonly string _localappdata;
    private string _host;
    private string _winPid;
    private string _off2013Pid;
    private string _off2010Pid;
    private string _hwid;
    private string _port;
    private string _sai;
    private string _sri;
    public string SysPath;
    private string _sysPath2;
    private string _officePath;
    private string _textBuffer;
    public string KmsFlag;
    private string _args;
    private bool _argsFlag;
    public bool Scheduler;
    private readonly string _razdelitel;
    private readonly string _razdelitel2;
    private bool _saveToFileLog;
    private bool _addFunctions;
    private bool _noLogo;
    private bool _professional;
    private bool _logFile;
    private bool _logFileIp;
    private int _index1;
    private int _index2;
    private int _index3;
    private int _index4;
    private int _index5;
    private int _index6;
    private int _index7;
    private bool _cmDlineExist;
    private KmSservice.KmssStartKeys _currentParameters;
    private string[] _windowsBackupKey;
    private string[] _officeBackupKey;
    private string[] _windowsBackupKey2;
    private string[] _officeBackupKey2;
    public string ProductNameWin;
    public bool OwnKeyInstallNoDialog;
    public bool OwnKeyInstallNoDialogMyKey;
    public bool OwnKeyInstallYesDialog;
    public string OwnKeyInstallYesDialogProductName;
    public string OwnKeyInstallNoDialogKey;
    public int OwnKeyInstallKey;
    private bool _schtasksWinStatus;
    private bool _schtasksOffStatus;
    private bool _actSuccessfullFlag;
    public string KmsServerServiceName;
    private string[] _keyString;
    private string _editionId;
    private bool _sounds;
    private bool _cdDvdRom;
    public int ActivateError;
    private bool _myPrintLineNoPrint;
    private bool _delKmsServer;
    private int _codepage;
    private readonly string _myKey;
    private string _winVersion;
    private string _userFolderToSave;
    private readonly FolderBrowserDialog _openfolder;
    private byte[] _hexBufData;
    private bool _saveOffice2013Act;
    public string MyOfficeKey;
    public bool LoadingProgramm;
    private string _kmsServicePathExe;
    private string _kmsServicePathLog;
    private bool _showDialogReinstallKms;
    public bool ModeTap;
    private bool _modeWd;
    private bool _modeAuto;
    private bool _modeAutoNo;
    private bool _modeHook;
    private string _autoModeHost;
    private readonly string _autoHostText;
    private readonly string _autoModeHostLh;
    private readonly string _autoModeHostWd;
    private readonly string _autoModeHostTap;
    private readonly string _autoModeHostHook;
    private bool _disableActivateSystemButton;
    public string Errorcodetxt;
    private int _type;
    private int _countActivations;
    private bool _winDivertRun;
    public bool WinDivertRemoveHard;
    private bool _requestWinKey;
    private bool _requestOffKey;
    public bool AutoRes;
    private bool _firstActivation;
    public bool NoAutoNoKms;
    public string TapType;
    public string ApplicationStartupPathForDos;
    public string ApplicationStartupPathForPlan;
    public string PathKmsService;
    public bool SetKmsProgramData;
    public string[] AutoModeList;
    public bool SaveInIinfolder;
    public int HookMode;
    private bool _showReadmeView;
    private bool _positionLeftTopStartProg;
    private bool _btnVideo;
    public string WinVersion7601;
    private bool _instKey;
    private bool _installOwnKeyFlag;
    private bool _windows10;
    private bool _msActBackUpFlag;
    private bool _officeInstalled;
    private string _actSuccessfull;
    private readonly string _version;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.Button41 = new Button();
      this.PictureBox2 = new PictureBox();
      this.GroupBox9 = new GroupBox();
      this.Label15 = new Label();
      this.Label6 = new Label();
      this.LinkLabel3 = new LinkLabel();
      this.Button35 = new Button();
      this.Button32 = new Button();
      this.Button26 = new Button();
      this.Button5 = new Button();
      this.Label14 = new Label();
      this.GroupBox2 = new GroupBox();
      this.Button34 = new Button();
      this.Button3 = new Button();
      this.Button4 = new Button();
      this.TextBox1 = new TextBox();
      this.TabPage5 = new TabPage();
      this.GroupBox17 = new GroupBox();
      this.ComboBoxLangs = new ComboBox();
      this.ChkBoxReset = new CheckBox();
      this.Label17 = new Label();
      this.RB5Hook = new RadioButton();
      this.RB4NOAuto = new RadioButton();
      this.RB2WD = new RadioButton();
      this.RB1AUTO = new RadioButton();
      this.CheckBoxIP = new CheckBox();
      this.RB3TAP = new RadioButton();
      this.Button33 = new Button();
      this.Button31 = new Button();
      this.GroupBox10 = new GroupBox();
      this.LinkLabel8 = new LinkLabel();
      this.ComboBox7 = new ComboBox();
      this.Button30 = new Button();
      this.Button29 = new Button();
      this.GroupBox8 = new GroupBox();
      this.Label9 = new Label();
      this.Button28 = new Button();
      this.CheckBoxLog = new CheckBox();
      this.Button27 = new Button();
      this.GroupBox1 = new GroupBox();
      this.LinkLabel7 = new LinkLabel();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.GroupBox3 = new GroupBox();
      this.Button7 = new Button();
      this.Button6 = new Button();
      this.LinkLabel2 = new LinkLabel();
      this.LinkLabel4 = new LinkLabel();
      this.LinkLabel6 = new LinkLabel();
      this.LinkLabel5 = new LinkLabel();
      this.LinkLabel9 = new LinkLabel();
      this.PictureBox3 = new PictureBox();
      this.TabPage2 = new TabPage();
      this.GroupBox16 = new GroupBox();
      this.TextBoxFakeIP = new TextBox();
      this.CheckBoxFakeIP = new CheckBox();
      this.CheckBoxInstKey = new CheckBox();
      this.CheckBox5 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBoxAnalizer = new CheckBox();
      this.CBox7IniFile = new CheckBox();
      this.CheckBox1 = new CheckBox();
      this.PictureBox4 = new PictureBox();
      this.GroupBox11 = new GroupBox();
      this.Button10 = new Button();
      this.ComboBox8 = new ComboBox();
      this.Button8 = new Button();
      this.GroupBox7 = new GroupBox();
      this.ButtonHwMn = new Button();
      this.ButtonHwPl = new Button();
      this.LabelHwid = new Label();
      this.ComboBoxHwid = new ComboBox();
      this.PictureBox9 = new PictureBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBoxKP = new CheckBox();
      this.LabelRITime = new Label();
      this.LabelAITime = new Label();
      this.Label16 = new Label();
      this.Label10 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.NumericUpDown3 = new NumericUpDown();
      this.NumericUpDown2 = new NumericUpDown();
      this.NumericUpDown1 = new NumericUpDown();
      this.ComboBox3 = new ComboBox();
      this.Button16 = new Button();
      this.Button25 = new Button();
      this.Button24 = new Button();
      this.Button17 = new Button();
      this.ComboBox6 = new ComboBox();
      this.Button12 = new Button();
      this.ComboBox1 = new ComboBox();
      this.Button15 = new Button();
      this.ComboBox2 = new ComboBox();
      this.Button13 = new Button();
      this.Button14 = new Button();
      this.TabPage3 = new TabPage();
      this.GroupBox19 = new GroupBox();
      this.ButtonOfficeScript = new Button();
      this.Button37 = new Button();
      this.PictureBox5 = new PictureBox();
      this.Button11 = new Button();
      this.GroupBox12 = new GroupBox();
      this.Button9 = new Button();
      this.Button22 = new Button();
      this.GroupBox6 = new GroupBox();
      this.TextBox2 = new TextBox();
      this.Button21 = new Button();
      this.Button20 = new Button();
      this.GroupBox4 = new GroupBox();
      this.Button19 = new Button();
      this.Button18 = new Button();
      this.TabPage6 = new TabPage();
      this.GroupBox14 = new GroupBox();
      this.ButtonHideUpdates = new Button();
      this.GroupBox20 = new GroupBox();
      this.Button38 = new Button();
      this.GroupBox18 = new GroupBox();
      this.Button36 = new Button();
      this.Button23 = new Button();
      this.GroupBox15 = new GroupBox();
      this.PictureBox8 = new PictureBox();
      this.Button48 = new Button();
      this.TextBox3 = new TextBox();
      this.ComboBox10 = new ComboBox();
      this.GroupBox13 = new GroupBox();
      this.ButtonValidator = new Button();
      this.Button47 = new Button();
      this.Button46 = new Button();
      this.Button43 = new Button();
      this.Button42 = new Button();
      this.GroupBox5 = new GroupBox();
      this.CheckBox6 = new CheckBox();
      this.Label12 = new Label();
      this.ComboBox9 = new ComboBox();
      this.Button40 = new Button();
      this.TabPage4 = new TabPage();
      this.ButtonVideoSearch = new Button();
      this.ButtonVideo = new Button();
      this.Label13 = new Label();
      this.Button39 = new Button();
      this.LinkLabel1 = new LinkLabel();
      this.Label11 = new Label();
      this.Label8 = new Label();
      this.Label7 = new Label();
      this.ButtonHelp = new Button();
      this.PictureBox6 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.PictureBox7 = new PictureBox();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      this.GroupBox9.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.TabPage5.SuspendLayout();
      this.GroupBox17.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      this.TabPage2.SuspendLayout();
      this.GroupBox16.SuspendLayout();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.GroupBox11.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      ((ISupportInitialize) this.PictureBox9).BeginInit();
      this.NumericUpDown3.BeginInit();
      this.NumericUpDown2.BeginInit();
      this.NumericUpDown1.BeginInit();
      this.TabPage3.SuspendLayout();
      this.GroupBox19.SuspendLayout();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      this.GroupBox12.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.TabPage6.SuspendLayout();
      this.GroupBox14.SuspendLayout();
      this.GroupBox20.SuspendLayout();
      this.GroupBox18.SuspendLayout();
      this.GroupBox15.SuspendLayout();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      this.GroupBox13.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.TabPage4.SuspendLayout();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      this.SuspendLayout();
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage5);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      this.TabControl1.Controls.Add((Control) this.TabPage6);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.TabControl1.Location = new Point(-5, -2);
      this.TabControl1.Margin = new Padding(4);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(567, 631);
      this.TabControl1.SizeMode = TabSizeMode.FillToRight;
      this.TabControl1.TabIndex = 3;
      this.TabPage1.BackgroundImageLayout = ImageLayout.None;
      this.TabPage1.Controls.Add((Control) this.Button41);
      this.TabPage1.Controls.Add((Control) this.PictureBox2);
      this.TabPage1.Controls.Add((Control) this.GroupBox9);
      this.TabPage1.Controls.Add((Control) this.GroupBox2);
      this.TabPage1.Controls.Add((Control) this.TextBox1);
      this.TabPage1.Location = new Point(4, 26);
      this.TabPage1.Margin = new Padding(4);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(4);
      this.TabPage1.Size = new Size(559, 601);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.UseVisualStyleBackColor = true;
      this.Button41.BackgroundImage = (Image) componentResourceManager.GetObject("Button41.BackgroundImage");
      this.Button41.BackgroundImageLayout = ImageLayout.Center;
      this.Button41.Location = new Point(527, 304);
      this.Button41.Margin = new Padding(4);
      this.Button41.Name = "Button41";
      this.Button41.Size = new Size(21, 20);
      this.Button41.TabIndex = 11;
      this.Button41.UseVisualStyleBackColor = true;
      this.PictureBox2.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox2.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox2.Location = new Point(5, 0);
      this.PictureBox2.Margin = new Padding(4);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(111, 82);
      this.PictureBox2.TabIndex = 10;
      this.PictureBox2.TabStop = false;
      this.GroupBox9.Controls.Add((Control) this.Label15);
      this.GroupBox9.Controls.Add((Control) this.Label6);
      this.GroupBox9.Controls.Add((Control) this.LinkLabel3);
      this.GroupBox9.Controls.Add((Control) this.Button35);
      this.GroupBox9.Controls.Add((Control) this.Button32);
      this.GroupBox9.Controls.Add((Control) this.Button26);
      this.GroupBox9.Controls.Add((Control) this.Button5);
      this.GroupBox9.Controls.Add((Control) this.Label14);
      this.GroupBox9.Location = new Point(133, 138);
      this.GroupBox9.Margin = new Padding(4);
      this.GroupBox9.Name = "GroupBox9";
      this.GroupBox9.Padding = new Padding(4);
      this.GroupBox9.Size = new Size(287, 178);
      this.GroupBox9.TabIndex = 9;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "GroupBox9";
      this.Label15.AutoSize = true;
      this.Label15.ForeColor = SystemColors.ControlText;
      this.Label15.Location = new Point(103, 156);
      this.Label15.Margin = new Padding(4, 0, 4, 0);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(59, 17);
      this.Label15.TabIndex = 11;
      this.Label15.Text = "Label15";
      this.Label6.AutoSize = true;
      this.Label6.ForeColor = System.Drawing.Color.Red;
      this.Label6.Location = new Point(5, 134);
      this.Label6.Margin = new Padding(4, 0, 4, 0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(88, 17);
      this.Label6.TabIndex = 0;
      this.Label6.Text = "                    ";
      this.LinkLabel3.AutoSize = true;
      this.LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
      this.LinkLabel3.Location = new Point(67, 111);
      this.LinkLabel3.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel3.Name = "LinkLabel3";
      this.LinkLabel3.Size = new Size(136, 17);
      this.LinkLabel3.TabIndex = 32;
      this.LinkLabel3.TabStop = true;
      this.LinkLabel3.Text = "Пройти Валидацию";
      this.LinkLabel3.TextAlign = ContentAlignment.MiddleCenter;
      this.Button35.BackgroundImageLayout = ImageLayout.None;
      this.Button35.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Button35.ForeColor = SystemColors.ControlText;
      this.Button35.Location = new Point(34, 23);
      this.Button35.Margin = new Padding(4);
      this.Button35.Name = "Button35";
      this.Button35.Size = new Size(216, 78);
      this.Button35.TabIndex = 12;
      this.Button35.Text = "Button35";
      this.Button35.UseVisualStyleBackColor = true;
      this.Button32.Location = new Point(149, 23);
      this.Button32.Margin = new Padding(4);
      this.Button32.Name = "Button32";
      this.Button32.Size = new Size(113, 32);
      this.Button32.TabIndex = 10;
      this.Button32.Text = "Button32";
      this.Button32.UseVisualStyleBackColor = true;
      this.Button26.Location = new Point(23, 69);
      this.Button26.Margin = new Padding(4);
      this.Button26.Name = "Button26";
      this.Button26.Size = new Size(240, 32);
      this.Button26.TabIndex = 7;
      this.Button26.Text = "Button26";
      this.Button26.UseVisualStyleBackColor = true;
      this.Button5.Location = new Point(23, 23);
      this.Button5.Margin = new Padding(4);
      this.Button5.Name = "Button5";
      this.Button5.Size = new Size(113, 32);
      this.Button5.TabIndex = 6;
      this.Button5.Text = "Button5";
      this.Button5.UseVisualStyleBackColor = true;
      this.Label14.AutoSize = true;
      this.Label14.Location = new Point(96, 134);
      this.Label14.Margin = new Padding(4, 0, 4, 0);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(59, 17);
      this.Label14.TabIndex = 33;
      this.Label14.Text = "Label14";
      this.Label14.TextAlign = ContentAlignment.MiddleCenter;
      this.GroupBox2.Controls.Add((Control) this.Button34);
      this.GroupBox2.Controls.Add((Control) this.Button3);
      this.GroupBox2.Controls.Add((Control) this.Button4);
      this.GroupBox2.Location = new Point(133, 15);
      this.GroupBox2.Margin = new Padding(4);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Padding = new Padding(4);
      this.GroupBox2.Size = new Size(287, 117);
      this.GroupBox2.TabIndex = 7;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "GroupBox2";
      this.Button34.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Button34.ForeColor = SystemColors.ControlText;
      this.Button34.Location = new Point(34, 22);
      this.Button34.Margin = new Padding(4);
      this.Button34.Name = "Button34";
      this.Button34.Size = new Size(216, 78);
      this.Button34.TabIndex = 11;
      this.Button34.Text = "Button34";
      this.Button34.UseVisualStyleBackColor = true;
      this.Button3.Location = new Point(23, 23);
      this.Button3.Margin = new Padding(4);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(240, 32);
      this.Button3.TabIndex = 3;
      this.Button3.Text = "Button3";
      this.Button3.UseVisualStyleBackColor = true;
      this.Button4.Location = new Point(23, 68);
      this.Button4.Margin = new Padding(4);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(240, 32);
      this.Button4.TabIndex = 5;
      this.Button4.Text = "Button4";
      this.Button4.UseVisualStyleBackColor = true;
      this.TextBox1.AllowDrop = true;
      this.TextBox1.BackColor = System.Drawing.Color.MidnightBlue;
      this.TextBox1.Cursor = Cursors.IBeam;
      this.TextBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.TextBox1.ForeColor = System.Drawing.Color.Yellow;
      this.TextBox1.Location = new Point(0, 329);
      this.TextBox1.Margin = new Padding(4);
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.ReadOnly = true;
      this.TextBox1.ScrollBars = ScrollBars.Both;
      this.TextBox1.Size = new Size(549, 264);
      this.TextBox1.TabIndex = 4;
      this.TextBox1.WordWrap = false;
      this.TabPage5.BackgroundImageLayout = ImageLayout.None;
      this.TabPage5.Controls.Add((Control) this.GroupBox17);
      this.TabPage5.Controls.Add((Control) this.Label17);
      this.TabPage5.Controls.Add((Control) this.RB5Hook);
      this.TabPage5.Controls.Add((Control) this.RB4NOAuto);
      this.TabPage5.Controls.Add((Control) this.RB2WD);
      this.TabPage5.Controls.Add((Control) this.RB1AUTO);
      this.TabPage5.Controls.Add((Control) this.CheckBoxIP);
      this.TabPage5.Controls.Add((Control) this.RB3TAP);
      this.TabPage5.Controls.Add((Control) this.Button33);
      this.TabPage5.Controls.Add((Control) this.Button31);
      this.TabPage5.Controls.Add((Control) this.GroupBox10);
      this.TabPage5.Controls.Add((Control) this.GroupBox8);
      this.TabPage5.Controls.Add((Control) this.Button28);
      this.TabPage5.Controls.Add((Control) this.CheckBoxLog);
      this.TabPage5.Controls.Add((Control) this.Button27);
      this.TabPage5.Controls.Add((Control) this.GroupBox1);
      this.TabPage5.Controls.Add((Control) this.GroupBox3);
      this.TabPage5.Controls.Add((Control) this.LinkLabel2);
      this.TabPage5.Controls.Add((Control) this.LinkLabel4);
      this.TabPage5.Controls.Add((Control) this.LinkLabel6);
      this.TabPage5.Controls.Add((Control) this.LinkLabel5);
      this.TabPage5.Controls.Add((Control) this.LinkLabel9);
      this.TabPage5.Controls.Add((Control) this.PictureBox3);
      this.TabPage5.Location = new Point(4, 26);
      this.TabPage5.Margin = new Padding(4);
      this.TabPage5.Name = "TabPage5";
      this.TabPage5.Size = new Size(559, 601);
      this.TabPage5.TabIndex = 4;
      this.TabPage5.UseVisualStyleBackColor = true;
      this.GroupBox17.Controls.Add((Control) this.ComboBoxLangs);
      this.GroupBox17.Controls.Add((Control) this.ChkBoxReset);
      this.GroupBox17.Location = new Point(133, 478);
      this.GroupBox17.Margin = new Padding(4);
      this.GroupBox17.Name = "GroupBox17";
      this.GroupBox17.Padding = new Padding(4);
      this.GroupBox17.Size = new Size(287, 100);
      this.GroupBox17.TabIndex = 48;
      this.GroupBox17.TabStop = false;
      this.GroupBox17.Text = "GroupBox17";
      this.ComboBoxLangs.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBoxLangs.FormattingEnabled = true;
      this.ComboBoxLangs.Items.AddRange(new object[4]
      {
        (object) "EN",
        (object) "RU",
        (object) "ES",
        (object) "VI"
      });
      this.ComboBoxLangs.Location = new Point(13, 59);
      this.ComboBoxLangs.Margin = new Padding(4);
      this.ComboBoxLangs.Name = "ComboBoxLangs";
      this.ComboBoxLangs.Size = new Size(263, 25);
      this.ComboBoxLangs.TabIndex = 1;
      this.ChkBoxReset.AutoSize = true;
      this.ChkBoxReset.Location = new Point(13, 18);
      this.ChkBoxReset.Margin = new Padding(4);
      this.ChkBoxReset.Name = "ChkBoxReset";
      this.ChkBoxReset.Size = new Size(114, 21);
      this.ChkBoxReset.TabIndex = 0;
      this.ChkBoxReset.Text = "ChkBoxReset";
      this.ChkBoxReset.UseVisualStyleBackColor = true;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label17.ForeColor = System.Drawing.Color.Red;
      this.Label17.Location = new Point(124, 132);
      this.Label17.Margin = new Padding(4, 0, 4, 0);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(82, 25);
      this.Label17.TabIndex = 39;
      this.Label17.Text = "Label17";
      this.RB5Hook.AutoSize = true;
      this.RB5Hook.Location = new Point(207, 166);
      this.RB5Hook.Margin = new Padding(4);
      this.RB5Hook.Name = "RB5Hook";
      this.RB5Hook.Size = new Size(17, 16);
      this.RB5Hook.TabIndex = 46;
      this.RB5Hook.TabStop = true;
      this.RB5Hook.UseVisualStyleBackColor = true;
      this.RB4NOAuto.AutoSize = true;
      this.RB4NOAuto.Location = new Point(267, 166);
      this.RB4NOAuto.Margin = new Padding(4);
      this.RB4NOAuto.Name = "RB4NOAuto";
      this.RB4NOAuto.Size = new Size(17, 16);
      this.RB4NOAuto.TabIndex = 40;
      this.RB4NOAuto.TabStop = true;
      this.RB4NOAuto.UseVisualStyleBackColor = true;
      this.RB2WD.AutoSize = true;
      this.RB2WD.Location = new Point(147, 166);
      this.RB2WD.Margin = new Padding(4);
      this.RB2WD.Name = "RB2WD";
      this.RB2WD.Size = new Size(17, 16);
      this.RB2WD.TabIndex = 34;
      this.RB2WD.TabStop = true;
      this.RB2WD.UseVisualStyleBackColor = true;
      this.RB1AUTO.AutoSize = true;
      this.RB1AUTO.Location = new Point(327, 166);
      this.RB1AUTO.Margin = new Padding(4);
      this.RB1AUTO.Name = "RB1AUTO";
      this.RB1AUTO.Size = new Size(17, 16);
      this.RB1AUTO.TabIndex = 33;
      this.RB1AUTO.TabStop = true;
      this.RB1AUTO.UseVisualStyleBackColor = true;
      this.CheckBoxIP.AutoSize = true;
      this.CheckBoxIP.Location = new Point(436, 156);
      this.CheckBoxIP.Margin = new Padding(4);
      this.CheckBoxIP.Name = "CheckBoxIP";
      this.CheckBoxIP.Size = new Size(104, 21);
      this.CheckBoxIP.TabIndex = 32;
      this.CheckBoxIP.Text = "CheckBoxIP";
      this.CheckBoxIP.UseVisualStyleBackColor = true;
      this.RB3TAP.AutoSize = true;
      this.RB3TAP.Location = new Point(387, 166);
      this.RB3TAP.Margin = new Padding(4);
      this.RB3TAP.Name = "RB3TAP";
      this.RB3TAP.Size = new Size(17, 16);
      this.RB3TAP.TabIndex = 35;
      this.RB3TAP.TabStop = true;
      this.RB3TAP.UseVisualStyleBackColor = true;
      this.Button33.Location = new Point(436, 193);
      this.Button33.Margin = new Padding(4);
      this.Button33.Name = "Button33";
      this.Button33.Size = new Size(100, 28);
      this.Button33.TabIndex = 29;
      this.Button33.Text = "Button33";
      this.Button33.UseVisualStyleBackColor = true;
      this.Button31.Location = new Point(436, 250);
      this.Button31.Margin = new Padding(4);
      this.Button31.Name = "Button31";
      this.Button31.Size = new Size(100, 28);
      this.Button31.TabIndex = 28;
      this.Button31.Text = "Button31";
      this.Button31.UseVisualStyleBackColor = true;
      this.GroupBox10.Controls.Add((Control) this.LinkLabel8);
      this.GroupBox10.Controls.Add((Control) this.ComboBox7);
      this.GroupBox10.Controls.Add((Control) this.Button30);
      this.GroupBox10.Controls.Add((Control) this.Button29);
      this.GroupBox10.Location = new Point(133, 225);
      this.GroupBox10.Margin = new Padding(4);
      this.GroupBox10.Name = "GroupBox10";
      this.GroupBox10.Padding = new Padding(4);
      this.GroupBox10.Size = new Size(287, 137);
      this.GroupBox10.TabIndex = 27;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "GroupBox10";
      this.LinkLabel8.AutoSize = true;
      this.LinkLabel8.Location = new Point(8, -1);
      this.LinkLabel8.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel8.Name = "LinkLabel8";
      this.LinkLabel8.Size = new Size(77, 17);
      this.LinkLabel8.TabIndex = 3;
      this.LinkLabel8.TabStop = true;
      this.LinkLabel8.Text = "LinkLabel8";
      this.ComboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox7.FormattingEnabled = true;
      this.ComboBox7.Location = new Point(9, 96);
      this.ComboBox7.Margin = new Padding(4);
      this.ComboBox7.Name = "ComboBox7";
      this.ComboBox7.Size = new Size(268, 25);
      this.ComboBox7.TabIndex = 2;
      this.Button30.Location = new Point(9, 60);
      this.Button30.Margin = new Padding(4);
      this.Button30.Name = "Button30";
      this.Button30.Size = new Size(269, 28);
      this.Button30.TabIndex = 1;
      this.Button30.Text = "Button30";
      this.Button30.UseVisualStyleBackColor = true;
      this.Button29.Location = new Point(8, 23);
      this.Button29.Margin = new Padding(4);
      this.Button29.Name = "Button29";
      this.Button29.Size = new Size(269, 28);
      this.Button29.TabIndex = 0;
      this.Button29.Text = "Button29";
      this.Button29.UseVisualStyleBackColor = true;
      this.GroupBox8.Controls.Add((Control) this.Label9);
      this.GroupBox8.Location = new Point(133, 188);
      this.GroupBox8.Margin = new Padding(4);
      this.GroupBox8.Name = "GroupBox8";
      this.GroupBox8.Padding = new Padding(4);
      this.GroupBox8.Size = new Size(287, 31);
      this.GroupBox8.TabIndex = 26;
      this.GroupBox8.TabStop = false;
      this.Label9.AutoSize = true;
      this.Label9.ForeColor = System.Drawing.Color.Red;
      this.Label9.Location = new Point(8, 11);
      this.Label9.Margin = new Padding(4, 0, 4, 0);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(8, 17);
      this.Label9.TabIndex = 0;
      this.Label9.Text = "\r\n";
      this.Button28.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Button28.Location = new Point(436, 76);
      this.Button28.Margin = new Padding(4);
      this.Button28.Name = "Button28";
      this.Button28.Size = new Size(100, 28);
      this.Button28.TabIndex = 25;
      this.Button28.Text = "Button28";
      this.Button28.UseVisualStyleBackColor = true;
      this.CheckBoxLog.AutoSize = true;
      this.CheckBoxLog.Location = new Point(436, 118);
      this.CheckBoxLog.Margin = new Padding(4);
      this.CheckBoxLog.Name = "CheckBoxLog";
      this.CheckBoxLog.Size = new Size(116, 21);
      this.CheckBoxLog.TabIndex = 24;
      this.CheckBoxLog.Text = "CheckBoxLog";
      this.CheckBoxLog.UseVisualStyleBackColor = true;
      this.Button27.Location = new Point(436, 41);
      this.Button27.Margin = new Padding(4);
      this.Button27.Name = "Button27";
      this.Button27.Size = new Size(100, 28);
      this.Button27.TabIndex = 23;
      this.Button27.Text = "Button27";
      this.Button27.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.LinkLabel7);
      this.GroupBox1.Controls.Add((Control) this.Button1);
      this.GroupBox1.Controls.Add((Control) this.Button2);
      this.GroupBox1.Location = new Point(133, 18);
      this.GroupBox1.Margin = new Padding(4);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Padding = new Padding(4);
      this.GroupBox1.Size = new Size(287, 106);
      this.GroupBox1.TabIndex = 18;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "GroupBox1";
      this.LinkLabel7.AutoSize = true;
      this.LinkLabel7.Location = new Point(8, -1);
      this.LinkLabel7.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel7.Name = "LinkLabel7";
      this.LinkLabel7.Size = new Size(77, 17);
      this.LinkLabel7.TabIndex = 2;
      this.LinkLabel7.TabStop = true;
      this.LinkLabel7.Text = "LinkLabel7";
      this.Button1.Location = new Point(8, 22);
      this.Button1.Margin = new Padding(4);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(269, 28);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Button1";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.Location = new Point(8, 58);
      this.Button2.Margin = new Padding(4);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(269, 28);
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Button2";
      this.Button2.UseVisualStyleBackColor = true;
      this.GroupBox3.Controls.Add((Control) this.Button7);
      this.GroupBox3.Controls.Add((Control) this.Button6);
      this.GroupBox3.Location = new Point(133, 367);
      this.GroupBox3.Margin = new Padding(4);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Padding = new Padding(4);
      this.GroupBox3.Size = new Size(287, 106);
      this.GroupBox3.TabIndex = 1;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "GroupBox3";
      this.Button7.Location = new Point(8, 60);
      this.Button7.Margin = new Padding(4);
      this.Button7.Name = "Button7";
      this.Button7.Size = new Size(269, 28);
      this.Button7.TabIndex = 1;
      this.Button7.Text = "Button7";
      this.Button7.UseVisualStyleBackColor = true;
      this.Button6.Location = new Point(8, 25);
      this.Button6.Margin = new Padding(4);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(269, 28);
      this.Button6.TabIndex = 0;
      this.Button6.Text = "Button6";
      this.Button6.UseVisualStyleBackColor = true;
      this.LinkLabel2.AutoSize = true;
      this.LinkLabel2.Location = new Point(120, 135);
      this.LinkLabel2.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel2.Name = "LinkLabel2";
      this.LinkLabel2.Size = new Size(69, 17);
      this.LinkLabel2.TabIndex = 42;
      this.LinkLabel2.TabStop = true;
      this.LinkLabel2.Text = "WinDivert";
      this.LinkLabel4.AutoSize = true;
      this.LinkLabel4.LinkColor = System.Drawing.Color.Red;
      this.LinkLabel4.Location = new Point(249, 135);
      this.LinkLabel4.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel4.Name = "LinkLabel4";
      this.LinkLabel4.Size = new Size(55, 17);
      this.LinkLabel4.TabIndex = 43;
      this.LinkLabel4.TabStop = true;
      this.LinkLabel4.Text = "NoAuto";
      this.LinkLabel6.AutoSize = true;
      this.LinkLabel6.Location = new Point(376, 135);
      this.LinkLabel6.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel6.Name = "LinkLabel6";
      this.LinkLabel6.Size = new Size(35, 17);
      this.LinkLabel6.TabIndex = 45;
      this.LinkLabel6.TabStop = true;
      this.LinkLabel6.Text = "TAP";
      this.LinkLabel5.AutoSize = true;
      this.LinkLabel5.LinkColor = System.Drawing.Color.Green;
      this.LinkLabel5.Location = new Point(316, 135);
      this.LinkLabel5.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel5.Name = "LinkLabel5";
      this.LinkLabel5.Size = new Size(37, 17);
      this.LinkLabel5.TabIndex = 44;
      this.LinkLabel5.TabStop = true;
      this.LinkLabel5.Text = "Auto";
      this.LinkLabel9.AutoSize = true;
      this.LinkLabel9.Location = new Point(195, 135);
      this.LinkLabel9.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel9.Name = "LinkLabel9";
      this.LinkLabel9.Size = new Size(41, 17);
      this.LinkLabel9.TabIndex = 47;
      this.LinkLabel9.TabStop = true;
      this.LinkLabel9.Text = "Hook";
      this.PictureBox3.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox3.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox3.Location = new Point(5, 0);
      this.PictureBox3.Margin = new Padding(4);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(111, 82);
      this.PictureBox3.TabIndex = 30;
      this.PictureBox3.TabStop = false;
      this.TabPage2.BackgroundImageLayout = ImageLayout.None;
      this.TabPage2.Controls.Add((Control) this.GroupBox16);
      this.TabPage2.Controls.Add((Control) this.PictureBox4);
      this.TabPage2.Controls.Add((Control) this.GroupBox11);
      this.TabPage2.Controls.Add((Control) this.GroupBox7);
      this.TabPage2.Location = new Point(4, 26);
      this.TabPage2.Margin = new Padding(4);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(4);
      this.TabPage2.Size = new Size(559, 601);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.UseVisualStyleBackColor = true;
      this.GroupBox16.Controls.Add((Control) this.TextBoxFakeIP);
      this.GroupBox16.Controls.Add((Control) this.CheckBoxFakeIP);
      this.GroupBox16.Controls.Add((Control) this.CheckBoxInstKey);
      this.GroupBox16.Controls.Add((Control) this.CheckBox5);
      this.GroupBox16.Controls.Add((Control) this.CheckBox3);
      this.GroupBox16.Controls.Add((Control) this.CheckBoxAnalizer);
      this.GroupBox16.Controls.Add((Control) this.CBox7IniFile);
      this.GroupBox16.Controls.Add((Control) this.CheckBox1);
      this.GroupBox16.Location = new Point(16, 90);
      this.GroupBox16.Margin = new Padding(4);
      this.GroupBox16.Name = "GroupBox16";
      this.GroupBox16.Padding = new Padding(4);
      this.GroupBox16.Size = new Size(520, 177);
      this.GroupBox16.TabIndex = 22;
      this.GroupBox16.TabStop = false;
      this.GroupBox16.Text = "GroupBox16";
      this.TextBoxFakeIP.Location = new Point(381, 122);
      this.TextBoxFakeIP.Margin = new Padding(4);
      this.TextBoxFakeIP.Name = "TextBoxFakeIP";
      this.TextBoxFakeIP.Size = new Size(129, 23);
      this.TextBoxFakeIP.TabIndex = 31;
      this.TextBoxFakeIP.TextAlign = HorizontalAlignment.Center;
      this.CheckBoxFakeIP.AutoSize = true;
      this.CheckBoxFakeIP.Location = new Point(16, 122);
      this.CheckBoxFakeIP.Margin = new Padding(4);
      this.CheckBoxFakeIP.Name = "CheckBoxFakeIP";
      this.CheckBoxFakeIP.Size = new Size(135, 21);
      this.CheckBoxFakeIP.TabIndex = 30;
      this.CheckBoxFakeIP.Text = "CheckBoxFakeIP";
      this.CheckBoxFakeIP.UseVisualStyleBackColor = true;
      this.CheckBoxInstKey.AutoSize = true;
      this.CheckBoxInstKey.Location = new Point(16, 73);
      this.CheckBoxInstKey.Margin = new Padding(4);
      this.CheckBoxInstKey.Name = "CheckBoxInstKey";
      this.CheckBoxInstKey.Size = new Size(138, 21);
      this.CheckBoxInstKey.TabIndex = 29;
      this.CheckBoxInstKey.Text = "CheckBoxInstKey";
      this.CheckBoxInstKey.UseVisualStyleBackColor = true;
      this.CheckBox5.AutoSize = true;
      this.CheckBox5.Location = new Point(393, 22);
      this.CheckBox5.Margin = new Padding(4);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new Size(100, 21);
      this.CheckBox5.TabIndex = 28;
      this.CheckBox5.Text = "CheckBox5";
      this.CheckBox5.UseVisualStyleBackColor = true;
      this.CheckBox3.AutoSize = true;
      this.CheckBox3.Location = new Point(229, 22);
      this.CheckBox3.Margin = new Padding(4);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new Size(58, 21);
      this.CheckBox3.TabIndex = 27;
      this.CheckBox3.Text = "Intro";
      this.CheckBox3.UseVisualStyleBackColor = true;
      this.CheckBoxAnalizer.AutoSize = true;
      this.CheckBoxAnalizer.Location = new Point(16, 97);
      this.CheckBoxAnalizer.Margin = new Padding(4);
      this.CheckBoxAnalizer.Name = "CheckBoxAnalizer";
      this.CheckBoxAnalizer.Size = new Size(143, 21);
      this.CheckBoxAnalizer.TabIndex = 26;
      this.CheckBoxAnalizer.Text = "CheckBoxAnalizer";
      this.CheckBoxAnalizer.UseVisualStyleBackColor = true;
      this.CBox7IniFile.AutoSize = true;
      this.CBox7IniFile.Location = new Point(16, 48);
      this.CBox7IniFile.Margin = new Padding(4);
      this.CBox7IniFile.Name = "CBox7IniFile";
      this.CBox7IniFile.Size = new Size(106, 21);
      this.CBox7IniFile.TabIndex = 25;
      this.CBox7IniFile.Text = "CBox7IniFile";
      this.CBox7IniFile.UseVisualStyleBackColor = true;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(16, 23);
      this.CheckBox1.Margin = new Padding(4);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(18, 17);
      this.CheckBox1.TabIndex = 17;
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.PictureBox4.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox4.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox4.Location = new Point(5, 0);
      this.PictureBox4.Margin = new Padding(4);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(111, 82);
      this.PictureBox4.TabIndex = 21;
      this.PictureBox4.TabStop = false;
      this.GroupBox11.Controls.Add((Control) this.Button10);
      this.GroupBox11.Controls.Add((Control) this.ComboBox8);
      this.GroupBox11.Controls.Add((Control) this.Button8);
      this.GroupBox11.Location = new Point(152, 20);
      this.GroupBox11.Margin = new Padding(4);
      this.GroupBox11.Name = "GroupBox11";
      this.GroupBox11.Padding = new Padding(4);
      this.GroupBox11.Size = new Size(344, 58);
      this.GroupBox11.TabIndex = 20;
      this.GroupBox11.TabStop = false;
      this.GroupBox11.Text = "GroupBox11";
      this.Button10.Location = new Point(163, 19);
      this.Button10.Margin = new Padding(4);
      this.Button10.Name = "Button10";
      this.Button10.Size = new Size(158, 28);
      this.Button10.TabIndex = 21;
      this.Button10.Text = "Button10";
      this.Button10.UseVisualStyleBackColor = true;
      this.ComboBox8.FormattingEnabled = true;
      this.ComboBox8.Items.AddRange(new object[3]
      {
        (object) "Windows",
        (object) "Office 2010",
        (object) "Office 2013/16"
      });
      this.ComboBox8.Location = new Point(24, 20);
      this.ComboBox8.Margin = new Padding(4);
      this.ComboBox8.Name = "ComboBox8";
      this.ComboBox8.Size = new Size(131, 25);
      this.ComboBox8.TabIndex = 20;
      this.ComboBox8.Text = "Windows";
      this.Button8.Location = new Point(24, 18);
      this.Button8.Margin = new Padding(4);
      this.Button8.Name = "Button8";
      this.Button8.Size = new Size(297, 28);
      this.Button8.TabIndex = 19;
      this.Button8.Text = "Button8";
      this.Button8.UseVisualStyleBackColor = true;
      this.GroupBox7.Controls.Add((Control) this.ButtonHwMn);
      this.GroupBox7.Controls.Add((Control) this.ButtonHwPl);
      this.GroupBox7.Controls.Add((Control) this.LabelHwid);
      this.GroupBox7.Controls.Add((Control) this.ComboBoxHwid);
      this.GroupBox7.Controls.Add((Control) this.PictureBox9);
      this.GroupBox7.Controls.Add((Control) this.CheckBox4);
      this.GroupBox7.Controls.Add((Control) this.CheckBoxKP);
      this.GroupBox7.Controls.Add((Control) this.LabelRITime);
      this.GroupBox7.Controls.Add((Control) this.LabelAITime);
      this.GroupBox7.Controls.Add((Control) this.Label16);
      this.GroupBox7.Controls.Add((Control) this.Label10);
      this.GroupBox7.Controls.Add((Control) this.Label5);
      this.GroupBox7.Controls.Add((Control) this.Label4);
      this.GroupBox7.Controls.Add((Control) this.Label3);
      this.GroupBox7.Controls.Add((Control) this.Label2);
      this.GroupBox7.Controls.Add((Control) this.Label1);
      this.GroupBox7.Controls.Add((Control) this.NumericUpDown3);
      this.GroupBox7.Controls.Add((Control) this.NumericUpDown2);
      this.GroupBox7.Controls.Add((Control) this.NumericUpDown1);
      this.GroupBox7.Controls.Add((Control) this.ComboBox3);
      this.GroupBox7.Controls.Add((Control) this.Button16);
      this.GroupBox7.Controls.Add((Control) this.Button25);
      this.GroupBox7.Controls.Add((Control) this.Button24);
      this.GroupBox7.Controls.Add((Control) this.Button17);
      this.GroupBox7.Controls.Add((Control) this.ComboBox6);
      this.GroupBox7.Controls.Add((Control) this.Button12);
      this.GroupBox7.Controls.Add((Control) this.ComboBox1);
      this.GroupBox7.Controls.Add((Control) this.Button15);
      this.GroupBox7.Controls.Add((Control) this.ComboBox2);
      this.GroupBox7.Controls.Add((Control) this.Button13);
      this.GroupBox7.Controls.Add((Control) this.Button14);
      this.GroupBox7.Location = new Point(16, 274);
      this.GroupBox7.Margin = new Padding(4);
      this.GroupBox7.Name = "GroupBox7";
      this.GroupBox7.Padding = new Padding(4);
      this.GroupBox7.Size = new Size(520, 302);
      this.GroupBox7.TabIndex = 18;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "GroupBox7";
      this.ButtonHwMn.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Clear10;
      this.ButtonHwMn.BackgroundImageLayout = ImageLayout.Stretch;
      this.ButtonHwMn.Location = new Point(484, 159);
      this.ButtonHwMn.Margin = new Padding(4);
      this.ButtonHwMn.Name = "ButtonHwMn";
      this.ButtonHwMn.Size = new Size(28, 26);
      this.ButtonHwMn.TabIndex = 45;
      this.ButtonHwMn.UseVisualStyleBackColor = true;
      this.ButtonHwPl.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Save12;
      this.ButtonHwPl.BackgroundImageLayout = ImageLayout.Stretch;
      this.ButtonHwPl.Location = new Point(455, 159);
      this.ButtonHwPl.Margin = new Padding(4);
      this.ButtonHwPl.Name = "ButtonHwPl";
      this.ButtonHwPl.Size = new Size(28, 26);
      this.ButtonHwPl.TabIndex = 44;
      this.ButtonHwPl.UseVisualStyleBackColor = true;
      this.LabelHwid.AutoSize = true;
      this.LabelHwid.Location = new Point(8, 164);
      this.LabelHwid.Margin = new Padding(4, 0, 4, 0);
      this.LabelHwid.Name = "LabelHwid";
      this.LabelHwid.Size = new Size(47, 17);
      this.LabelHwid.TabIndex = 43;
      this.LabelHwid.Text = "-Hwid:";
      this.ComboBoxHwid.FormattingEnabled = true;
      this.ComboBoxHwid.Location = new Point(267, 159);
      this.ComboBoxHwid.Margin = new Padding(4);
      this.ComboBoxHwid.Name = "ComboBoxHwid";
      this.ComboBoxHwid.Size = new Size(181, 25);
      this.ComboBoxHwid.TabIndex = 42;
      this.PictureBox9.BackgroundImage = (Image) componentResourceManager.GetObject("PictureBox9.BackgroundImage");
      this.PictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
      this.PictureBox9.Location = new Point(155, 22);
      this.PictureBox9.Margin = new Padding(4);
      this.PictureBox9.Name = "PictureBox9";
      this.PictureBox9.Size = new Size(27, 25);
      this.PictureBox9.TabIndex = 41;
      this.PictureBox9.TabStop = false;
      this.CheckBox4.AutoSize = true;
      this.CheckBox4.Location = new Point(229, 267);
      this.CheckBox4.Margin = new Padding(4);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new Size(100, 21);
      this.CheckBox4.TabIndex = 40;
      this.CheckBox4.Text = "CheckBox4";
      this.CheckBox4.UseVisualStyleBackColor = true;
      this.CheckBoxKP.AutoSize = true;
      this.CheckBoxKP.Location = new Point(16, 267);
      this.CheckBoxKP.Margin = new Padding(4);
      this.CheckBoxKP.Name = "CheckBoxKP";
      this.CheckBoxKP.Size = new Size(149, 21);
      this.CheckBoxKP.TabIndex = 38;
      this.CheckBoxKP.Text = "-KillProcessOnPort";
      this.CheckBoxKP.UseVisualStyleBackColor = true;
      this.LabelRITime.AutoSize = true;
      this.LabelRITime.Location = new Point(155, 233);
      this.LabelRITime.Margin = new Padding(4, 0, 4, 0);
      this.LabelRITime.Name = "LabelRITime";
      this.LabelRITime.Size = new Size(87, 17);
      this.LabelRITime.TabIndex = 37;
      this.LabelRITime.Text = "LabelRITime";
      this.LabelAITime.AutoSize = true;
      this.LabelAITime.Location = new Point(155, 199);
      this.LabelAITime.Margin = new Padding(4, 0, 4, 0);
      this.LabelAITime.Name = "LabelAITime";
      this.LabelAITime.Size = new Size(86, 17);
      this.LabelAITime.TabIndex = 36;
      this.LabelAITime.Text = "LabelAITime";
      this.Label16.AutoSize = true;
      this.Label16.Location = new Point(223, 26);
      this.Label16.Margin = new Padding(4, 0, 4, 0);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(41, 17);
      this.Label16.TabIndex = 35;
      this.Label16.Text = "Host:";
      this.Label10.AutoSize = true;
      this.Label10.Location = new Point(8, 233);
      this.Label10.Margin = new Padding(4, 0, 4, 0);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(30, 17);
      this.Label10.TabIndex = 34;
      this.Label10.Text = "-RI:";
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(8, 199);
      this.Label5.Margin = new Padding(4, 0, 4, 0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(29, 17);
      this.Label5.TabIndex = 33;
      this.Label5.Text = "-AI:";
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(8, 129);
      this.Label4.Margin = new Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(53, 17);
      this.Label4.TabIndex = 32;
      this.Label4.Text = "-PO15:";
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(8, 95);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(53, 17);
      this.Label3.TabIndex = 31;
      this.Label3.Text = "-PO14:";
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(8, 60);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(50, 17);
      this.Label2.TabIndex = 30;
      this.Label2.Text = "-PWin:";
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(8, 26);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(43, 17);
      this.Label1.TabIndex = 29;
      this.Label1.Text = "-Port:";
      this.NumericUpDown3.Location = new Point(63, 228);
      this.NumericUpDown3.Margin = new Padding(4);
      this.NumericUpDown3.Maximum = new Decimal(new int[4]
      {
        43200,
        0,
        0,
        0
      });
      this.NumericUpDown3.Minimum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.NumericUpDown3.Name = "NumericUpDown3";
      this.NumericUpDown3.Size = new Size(80, 23);
      this.NumericUpDown3.TabIndex = 28;
      this.NumericUpDown3.Value = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.NumericUpDown2.Location = new Point(63, 194);
      this.NumericUpDown2.Margin = new Padding(4);
      this.NumericUpDown2.Maximum = new Decimal(new int[4]
      {
        43200,
        0,
        0,
        0
      });
      this.NumericUpDown2.Minimum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.NumericUpDown2.Name = "NumericUpDown2";
      this.NumericUpDown2.Size = new Size(80, 23);
      this.NumericUpDown2.TabIndex = 27;
      this.NumericUpDown2.Value = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.NumericUpDown1.Location = new Point(63, 22);
      this.NumericUpDown1.Margin = new Padding(4);
      this.NumericUpDown1.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.NumericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.NumericUpDown1.Name = "NumericUpDown1";
      this.NumericUpDown1.Size = new Size(80, 23);
      this.NumericUpDown1.TabIndex = 26;
      this.NumericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.ComboBox3.FormattingEnabled = true;
      this.ComboBox3.Location = new Point(267, 21);
      this.ComboBox3.Margin = new Padding(4);
      this.ComboBox3.Name = "ComboBox3";
      this.ComboBox3.Size = new Size(183, 25);
      this.ComboBox3.TabIndex = 4;
      this.Button16.BackgroundImage = (Image) componentResourceManager.GetObject("Button16.BackgroundImage");
      this.Button16.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button16.Location = new Point(455, 21);
      this.Button16.Margin = new Padding(4);
      this.Button16.Name = "Button16";
      this.Button16.Size = new Size(28, 26);
      this.Button16.TabIndex = 12;
      this.Button16.UseVisualStyleBackColor = true;
      this.Button25.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Clear10;
      this.Button25.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button25.Location = new Point(484, 90);
      this.Button25.Margin = new Padding(4);
      this.Button25.Name = "Button25";
      this.Button25.Size = new Size(28, 26);
      this.Button25.TabIndex = 15;
      this.Button25.UseVisualStyleBackColor = true;
      this.Button24.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Save12;
      this.Button24.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button24.Location = new Point(455, 90);
      this.Button24.Margin = new Padding(4);
      this.Button24.Name = "Button24";
      this.Button24.Size = new Size(28, 26);
      this.Button24.TabIndex = 14;
      this.Button24.UseVisualStyleBackColor = true;
      this.Button17.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Clear10;
      this.Button17.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button17.Location = new Point(484, 21);
      this.Button17.Margin = new Padding(4);
      this.Button17.Name = "Button17";
      this.Button17.Size = new Size(28, 26);
      this.Button17.TabIndex = 13;
      this.Button17.UseVisualStyleBackColor = true;
      this.ComboBox6.FormattingEnabled = true;
      this.ComboBox6.Location = new Point(63, 90);
      this.ComboBox6.Margin = new Padding(4);
      this.ComboBox6.Name = "ComboBox6";
      this.ComboBox6.Size = new Size(385, 25);
      this.ComboBox6.TabIndex = 12;
      this.Button12.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Save12;
      this.Button12.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button12.Location = new Point(455, 55);
      this.Button12.Margin = new Padding(4);
      this.Button12.Name = "Button12";
      this.Button12.Size = new Size(28, 26);
      this.Button12.TabIndex = 8;
      this.Button12.UseVisualStyleBackColor = true;
      this.ComboBox1.FormattingEnabled = true;
      this.ComboBox1.Location = new Point(63, 55);
      this.ComboBox1.Margin = new Padding(4);
      this.ComboBox1.Name = "ComboBox1";
      this.ComboBox1.Size = new Size(385, 25);
      this.ComboBox1.TabIndex = 0;
      this.Button15.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Clear10;
      this.Button15.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button15.Location = new Point(484, 55);
      this.Button15.Margin = new Padding(4);
      this.Button15.Name = "Button15";
      this.Button15.Size = new Size(28, 26);
      this.Button15.TabIndex = 11;
      this.Button15.UseVisualStyleBackColor = true;
      this.ComboBox2.FormattingEnabled = true;
      this.ComboBox2.Location = new Point(63, 124);
      this.ComboBox2.Margin = new Padding(4);
      this.ComboBox2.Name = "ComboBox2";
      this.ComboBox2.Size = new Size(385, 25);
      this.ComboBox2.TabIndex = 1;
      this.Button13.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Save12;
      this.Button13.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button13.Location = new Point(455, 124);
      this.Button13.Margin = new Padding(4);
      this.Button13.Name = "Button13";
      this.Button13.Size = new Size(28, 26);
      this.Button13.TabIndex = 9;
      this.Button13.UseVisualStyleBackColor = true;
      this.Button14.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Clear10;
      this.Button14.BackgroundImageLayout = ImageLayout.Stretch;
      this.Button14.Location = new Point(484, 124);
      this.Button14.Margin = new Padding(4);
      this.Button14.Name = "Button14";
      this.Button14.Size = new Size(28, 26);
      this.Button14.TabIndex = 10;
      this.Button14.UseVisualStyleBackColor = true;
      this.TabPage3.BackgroundImageLayout = ImageLayout.None;
      this.TabPage3.Controls.Add((Control) this.GroupBox19);
      this.TabPage3.Controls.Add((Control) this.PictureBox5);
      this.TabPage3.Controls.Add((Control) this.Button11);
      this.TabPage3.Controls.Add((Control) this.GroupBox12);
      this.TabPage3.Controls.Add((Control) this.Button22);
      this.TabPage3.Controls.Add((Control) this.GroupBox6);
      this.TabPage3.Controls.Add((Control) this.GroupBox4);
      this.TabPage3.Location = new Point(4, 26);
      this.TabPage3.Margin = new Padding(4);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Size = new Size(559, 601);
      this.TabPage3.TabIndex = 2;
      this.TabPage3.UseVisualStyleBackColor = true;
      this.GroupBox19.Controls.Add((Control) this.ButtonOfficeScript);
      this.GroupBox19.Controls.Add((Control) this.Button37);
      this.GroupBox19.Location = new Point((int) sbyte.MaxValue, 274);
      this.GroupBox19.Margin = new Padding(4);
      this.GroupBox19.Name = "GroupBox19";
      this.GroupBox19.Padding = new Padding(4);
      this.GroupBox19.Size = new Size(300, 112);
      this.GroupBox19.TabIndex = 12;
      this.GroupBox19.TabStop = false;
      this.GroupBox19.Text = "GroupBox19";
      this.ButtonOfficeScript.Location = new Point(8, 60);
      this.ButtonOfficeScript.Margin = new Padding(4);
      this.ButtonOfficeScript.Name = "ButtonOfficeScript";
      this.ButtonOfficeScript.Size = new Size(283, 28);
      this.ButtonOfficeScript.TabIndex = 1;
      this.ButtonOfficeScript.Text = "ButtonOfficeScript";
      this.ButtonOfficeScript.UseVisualStyleBackColor = true;
      this.Button37.Location = new Point(8, 23);
      this.Button37.Margin = new Padding(4);
      this.Button37.Name = "Button37";
      this.Button37.Size = new Size(283, 28);
      this.Button37.TabIndex = 0;
      this.Button37.Text = "Button37";
      this.Button37.UseVisualStyleBackColor = true;
      this.PictureBox5.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox5.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox5.Location = new Point(5, 0);
      this.PictureBox5.Margin = new Padding(4);
      this.PictureBox5.Name = "PictureBox5";
      this.PictureBox5.Size = new Size(111, 82);
      this.PictureBox5.TabIndex = 11;
      this.PictureBox5.TabStop = false;
      this.Button11.Location = new Point(435, 523);
      this.Button11.Margin = new Padding(4);
      this.Button11.Name = "Button11";
      this.Button11.Size = new Size(100, 28);
      this.Button11.TabIndex = 5;
      this.Button11.Text = "Button11";
      this.Button11.UseVisualStyleBackColor = true;
      this.GroupBox12.Controls.Add((Control) this.Button9);
      this.GroupBox12.Location = new Point((int) sbyte.MaxValue, 409);
      this.GroupBox12.Margin = new Padding(4);
      this.GroupBox12.Name = "GroupBox12";
      this.GroupBox12.Padding = new Padding(4);
      this.GroupBox12.Size = new Size(300, 79);
      this.GroupBox12.TabIndex = 4;
      this.GroupBox12.TabStop = false;
      this.GroupBox12.Text = "GroupBox12";
      this.Button9.Location = new Point(8, 23);
      this.Button9.Margin = new Padding(4);
      this.Button9.Name = "Button9";
      this.Button9.Size = new Size(283, 28);
      this.Button9.TabIndex = 0;
      this.Button9.Text = "Button9";
      this.Button9.UseVisualStyleBackColor = true;
      this.Button22.Location = new Point(435, 224);
      this.Button22.Margin = new Padding(4);
      this.Button22.Name = "Button22";
      this.Button22.Size = new Size(100, 28);
      this.Button22.TabIndex = 3;
      this.Button22.Text = "Button22";
      this.Button22.UseVisualStyleBackColor = true;
      this.GroupBox6.Controls.Add((Control) this.TextBox2);
      this.GroupBox6.Controls.Add((Control) this.Button21);
      this.GroupBox6.Controls.Add((Control) this.Button20);
      this.GroupBox6.Location = new Point((int) sbyte.MaxValue, 129);
      this.GroupBox6.Margin = new Padding(4);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Padding = new Padding(4);
      this.GroupBox6.Size = new Size(300, 138);
      this.GroupBox6.TabIndex = 2;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "GroupBox6";
      this.TextBox2.Location = new Point(8, 97);
      this.TextBox2.Margin = new Padding(4);
      this.TextBox2.Name = "TextBox2";
      this.TextBox2.Size = new Size(281, 23);
      this.TextBox2.TabIndex = 2;
      this.Button21.Location = new Point(8, 60);
      this.Button21.Margin = new Padding(4);
      this.Button21.Name = "Button21";
      this.Button21.Size = new Size(283, 28);
      this.Button21.TabIndex = 1;
      this.Button21.Text = "Button21";
      this.Button21.UseVisualStyleBackColor = true;
      this.Button20.Location = new Point(8, 23);
      this.Button20.Margin = new Padding(4);
      this.Button20.Name = "Button20";
      this.Button20.Size = new Size(283, 28);
      this.Button20.TabIndex = 0;
      this.Button20.Text = "Button20";
      this.Button20.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.Button19);
      this.GroupBox4.Controls.Add((Control) this.Button18);
      this.GroupBox4.Location = new Point((int) sbyte.MaxValue, 11);
      this.GroupBox4.Margin = new Padding(4);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Padding = new Padding(4);
      this.GroupBox4.Size = new Size(300, 111);
      this.GroupBox4.TabIndex = 1;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "GroupBox4";
      this.Button19.Location = new Point(8, 60);
      this.Button19.Margin = new Padding(4);
      this.Button19.Name = "Button19";
      this.Button19.Size = new Size(283, 28);
      this.Button19.TabIndex = 1;
      this.Button19.Text = "Button19";
      this.Button19.UseVisualStyleBackColor = true;
      this.Button18.Location = new Point(8, 23);
      this.Button18.Margin = new Padding(4);
      this.Button18.Name = "Button18";
      this.Button18.Size = new Size(283, 28);
      this.Button18.TabIndex = 0;
      this.Button18.Text = "Button18";
      this.Button18.UseVisualStyleBackColor = true;
      this.TabPage6.Controls.Add((Control) this.PictureBox7);
      this.TabPage6.Controls.Add((Control) this.GroupBox14);
      this.TabPage6.Controls.Add((Control) this.GroupBox20);
      this.TabPage6.Controls.Add((Control) this.GroupBox18);
      this.TabPage6.Controls.Add((Control) this.GroupBox15);
      this.TabPage6.Controls.Add((Control) this.GroupBox13);
      this.TabPage6.Controls.Add((Control) this.GroupBox5);
      this.TabPage6.Location = new Point(4, 26);
      this.TabPage6.Margin = new Padding(4);
      this.TabPage6.Name = "TabPage6";
      this.TabPage6.Size = new Size(559, 601);
      this.TabPage6.TabIndex = 5;
      this.TabPage6.UseVisualStyleBackColor = true;
      this.GroupBox14.Controls.Add((Control) this.ButtonHideUpdates);
      this.GroupBox14.Location = new Point(57, 430);
      this.GroupBox14.Margin = new Padding(4);
      this.GroupBox14.Name = "GroupBox14";
      this.GroupBox14.Padding = new Padding(4);
      this.GroupBox14.Size = new Size(440, 62);
      this.GroupBox14.TabIndex = 7;
      this.GroupBox14.TabStop = false;
      this.GroupBox14.Text = "GroupBox14";
      this.ButtonHideUpdates.Location = new Point(20, 20);
      this.ButtonHideUpdates.Margin = new Padding(4);
      this.ButtonHideUpdates.Name = "ButtonHideUpdates";
      this.ButtonHideUpdates.Size = new Size(400, 28);
      this.ButtonHideUpdates.TabIndex = 5;
      this.ButtonHideUpdates.Text = "ButtonHideUpdates";
      this.ButtonHideUpdates.UseVisualStyleBackColor = true;
      this.GroupBox20.Controls.Add((Control) this.Button38);
      this.GroupBox20.Location = new Point(57, 494);
      this.GroupBox20.Margin = new Padding(4);
      this.GroupBox20.Name = "GroupBox20";
      this.GroupBox20.Padding = new Padding(4);
      this.GroupBox20.Size = new Size(440, 81);
      this.GroupBox20.TabIndex = 6;
      this.GroupBox20.TabStop = false;
      this.GroupBox20.Text = "GroupBox20";
      this.Button38.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Button38.ForeColor = System.Drawing.Color.Blue;
      this.Button38.Location = new Point(20, 23);
      this.Button38.Margin = new Padding(4);
      this.Button38.Name = "Button38";
      this.Button38.Size = new Size(400, 43);
      this.Button38.TabIndex = 0;
      this.Button38.Text = "Button38";
      this.Button38.UseVisualStyleBackColor = true;
      this.GroupBox18.Controls.Add((Control) this.Button36);
      this.GroupBox18.Controls.Add((Control) this.Button23);
      this.GroupBox18.Location = new Point(57, 374);
      this.GroupBox18.Margin = new Padding(4);
      this.GroupBox18.Name = "GroupBox18";
      this.GroupBox18.Padding = new Padding(4);
      this.GroupBox18.Size = new Size(440, 54);
      this.GroupBox18.TabIndex = 5;
      this.GroupBox18.TabStop = false;
      this.GroupBox18.Text = "GroupBox18";
      this.Button36.Location = new Point(232, 17);
      this.Button36.Margin = new Padding(4);
      this.Button36.Name = "Button36";
      this.Button36.Size = new Size(188, 28);
      this.Button36.TabIndex = 6;
      this.Button36.Text = "Button36";
      this.Button36.UseVisualStyleBackColor = true;
      this.Button23.Location = new Point(19, 17);
      this.Button23.Margin = new Padding(4);
      this.Button23.Name = "Button23";
      this.Button23.Size = new Size(187, 28);
      this.Button23.TabIndex = 5;
      this.Button23.Text = "Button23";
      this.Button23.UseVisualStyleBackColor = true;
      this.GroupBox15.Controls.Add((Control) this.PictureBox8);
      this.GroupBox15.Controls.Add((Control) this.Button48);
      this.GroupBox15.Controls.Add((Control) this.TextBox3);
      this.GroupBox15.Controls.Add((Control) this.ComboBox10);
      this.GroupBox15.Location = new Point(141, 4);
      this.GroupBox15.Margin = new Padding(4);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Padding = new Padding(4);
      this.GroupBox15.Size = new Size(356, 126);
      this.GroupBox15.TabIndex = 4;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "GroupBox15";
      this.PictureBox8.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Key24;
      this.PictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
      this.PictureBox8.InitialImage = (Image) null;
      this.PictureBox8.Location = new Point(112, 86);
      this.PictureBox8.Margin = new Padding(4);
      this.PictureBox8.Name = "PictureBox8";
      this.PictureBox8.Size = new Size(27, 25);
      this.PictureBox8.TabIndex = 3;
      this.PictureBox8.TabStop = false;
      this.Button48.Location = new Point(149, 85);
      this.Button48.Margin = new Padding(4);
      this.Button48.Name = "Button48";
      this.Button48.Size = new Size(185, 28);
      this.Button48.TabIndex = 2;
      this.Button48.Text = "Button48";
      this.Button48.UseVisualStyleBackColor = true;
      this.TextBox3.Location = new Point(21, 53);
      this.TextBox3.Margin = new Padding(4);
      this.TextBox3.Name = "TextBox3";
      this.TextBox3.Size = new Size(312, 23);
      this.TextBox3.TabIndex = 1;
      this.ComboBox10.Cursor = Cursors.Default;
      this.ComboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox10.DropDownWidth = (int) byte.MaxValue;
      this.ComboBox10.FormattingEnabled = true;
      this.ComboBox10.Location = new Point(21, 21);
      this.ComboBox10.Margin = new Padding(4);
      this.ComboBox10.Name = "ComboBox10";
      this.ComboBox10.Size = new Size(312, 25);
      this.ComboBox10.TabIndex = 0;
      this.GroupBox13.Controls.Add((Control) this.ButtonValidator);
      this.GroupBox13.Controls.Add((Control) this.Button47);
      this.GroupBox13.Controls.Add((Control) this.Button46);
      this.GroupBox13.Controls.Add((Control) this.Button43);
      this.GroupBox13.Controls.Add((Control) this.Button42);
      this.GroupBox13.Location = new Point(57, 132);
      this.GroupBox13.Margin = new Padding(4);
      this.GroupBox13.Name = "GroupBox13";
      this.GroupBox13.Padding = new Padding(4);
      this.GroupBox13.Size = new Size(440, 128);
      this.GroupBox13.TabIndex = 2;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "GroupBox13";
      this.ButtonValidator.Location = new Point(19, 87);
      this.ButtonValidator.Margin = new Padding(4);
      this.ButtonValidator.Name = "ButtonValidator";
      this.ButtonValidator.Size = new Size(401, 28);
      this.ButtonValidator.TabIndex = 4;
      this.ButtonValidator.Text = "ButtonValidator";
      this.ButtonValidator.UseVisualStyleBackColor = true;
      this.Button47.Location = new Point(232, 53);
      this.Button47.Margin = new Padding(4);
      this.Button47.Name = "Button47";
      this.Button47.Size = new Size(188, 28);
      this.Button47.TabIndex = 3;
      this.Button47.Text = "Button47";
      this.Button47.UseVisualStyleBackColor = true;
      this.Button46.Location = new Point(19, 53);
      this.Button46.Margin = new Padding(4);
      this.Button46.Name = "Button46";
      this.Button46.Size = new Size(187, 28);
      this.Button46.TabIndex = 2;
      this.Button46.Text = "Button46";
      this.Button46.UseVisualStyleBackColor = true;
      this.Button43.Location = new Point(19, 18);
      this.Button43.Margin = new Padding(4);
      this.Button43.Name = "Button43";
      this.Button43.Size = new Size(187, 28);
      this.Button43.TabIndex = 1;
      this.Button43.Text = "Button43";
      this.Button43.UseVisualStyleBackColor = true;
      this.Button42.Location = new Point(232, 18);
      this.Button42.Margin = new Padding(4);
      this.Button42.Name = "Button42";
      this.Button42.Size = new Size(188, 28);
      this.Button42.TabIndex = 0;
      this.Button42.Text = "Button42";
      this.Button42.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.CheckBox6);
      this.GroupBox5.Controls.Add((Control) this.Label12);
      this.GroupBox5.Controls.Add((Control) this.ComboBox9);
      this.GroupBox5.Controls.Add((Control) this.Button40);
      this.GroupBox5.Location = new Point(57, 262);
      this.GroupBox5.Margin = new Padding(4);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Padding = new Padding(4);
      this.GroupBox5.Size = new Size(440, 110);
      this.GroupBox5.TabIndex = 0;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "GroupBox5";
      this.CheckBox6.AutoSize = true;
      this.CheckBox6.Location = new Point(19, 67);
      this.CheckBox6.Margin = new Padding(4);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new Size(100, 21);
      this.CheckBox6.TabIndex = 3;
      this.CheckBox6.Text = "CheckBox6";
      this.CheckBox6.UseVisualStyleBackColor = true;
      this.Label12.Location = new Point(8, 16);
      this.Label12.Margin = new Padding(4, 0, 4, 0);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(215, 47);
      this.Label12.TabIndex = 2;
      this.Label12.Text = "Label12";
      this.ComboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox9.DropDownWidth = 240;
      this.ComboBox9.FormattingEnabled = true;
      this.ComboBox9.Location = new Point(232, 18);
      this.ComboBox9.Margin = new Padding(4);
      this.ComboBox9.Name = "ComboBox9";
      this.ComboBox9.Size = new Size(186, 25);
      this.ComboBox9.TabIndex = 1;
      this.Button40.Location = new Point(232, 51);
      this.Button40.Margin = new Padding(4);
      this.Button40.Name = "Button40";
      this.Button40.Size = new Size(188, 49);
      this.Button40.TabIndex = 0;
      this.Button40.Text = "Button40";
      this.Button40.UseVisualStyleBackColor = true;
      this.TabPage4.BackgroundImageLayout = ImageLayout.Center;
      this.TabPage4.Controls.Add((Control) this.ButtonVideoSearch);
      this.TabPage4.Controls.Add((Control) this.ButtonVideo);
      this.TabPage4.Controls.Add((Control) this.Label13);
      this.TabPage4.Controls.Add((Control) this.Button39);
      this.TabPage4.Controls.Add((Control) this.LinkLabel1);
      this.TabPage4.Controls.Add((Control) this.Label11);
      this.TabPage4.Controls.Add((Control) this.Label8);
      this.TabPage4.Controls.Add((Control) this.Label7);
      this.TabPage4.Controls.Add((Control) this.ButtonHelp);
      this.TabPage4.Controls.Add((Control) this.PictureBox6);
      this.TabPage4.Controls.Add((Control) this.PictureBox1);
      this.TabPage4.Location = new Point(4, 26);
      this.TabPage4.Margin = new Padding(4);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Size = new Size(559, 601);
      this.TabPage4.TabIndex = 3;
      this.TabPage4.UseVisualStyleBackColor = true;
      this.ButtonVideoSearch.BackgroundImage = (Image) componentResourceManager.GetObject("ButtonVideoSearch.BackgroundImage");
      this.ButtonVideoSearch.BackgroundImageLayout = ImageLayout.Center;
      this.ButtonVideoSearch.Location = new Point(71, 414);
      this.ButtonVideoSearch.Margin = new Padding(4);
      this.ButtonVideoSearch.Name = "ButtonVideoSearch";
      this.ButtonVideoSearch.Size = new Size(39, 46);
      this.ButtonVideoSearch.TabIndex = 17;
      this.ButtonVideoSearch.UseVisualStyleBackColor = true;
      this.ButtonVideo.BackgroundImage = (Image) componentResourceManager.GetObject("ButtonVideo.BackgroundImage");
      this.ButtonVideo.BackgroundImageLayout = ImageLayout.Center;
      this.ButtonVideo.Location = new Point(52, 463);
      this.ButtonVideo.Margin = new Padding(4);
      this.ButtonVideo.Name = "ButtonVideo";
      this.ButtonVideo.Size = new Size(71, 46);
      this.ButtonVideo.TabIndex = 16;
      this.ButtonVideo.UseVisualStyleBackColor = true;
      this.Label13.AutoSize = true;
      this.Label13.ForeColor = System.Drawing.Color.Green;
      this.Label13.Location = new Point(185, 66);
      this.Label13.Margin = new Padding(4, 0, 4, 0);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(59, 17);
      this.Label13.TabIndex = 15;
      this.Label13.Text = "Label13";
      this.Button39.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Button39.Location = new Point(396, 513);
      this.Button39.Margin = new Padding(4);
      this.Button39.Name = "Button39";
      this.Button39.Size = new Size(135, 46);
      this.Button39.TabIndex = 13;
      this.Button39.Text = "Профессиональный Режим";
      this.Button39.UseVisualStyleBackColor = true;
      this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
      this.LinkLabel1.Location = new Point(187, 539);
      this.LinkLabel1.Margin = new Padding(4, 0, 4, 0);
      this.LinkLabel1.Name = "LinkLabel1";
      this.LinkLabel1.Size = new Size(172, 16);
      this.LinkLabel1.TabIndex = 3;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel1.Text = "http://forum.ru-board.com";
      this.LinkLabel1.TextAlign = ContentAlignment.MiddleCenter;
      this.Label11.AutoSize = true;
      this.Label11.BackColor = System.Drawing.Color.Transparent;
      this.Label11.ForeColor = System.Drawing.Color.Blue;
      this.Label11.Location = new Point(199, 46);
      this.Label11.Margin = new Padding(4, 0, 4, 0);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(59, 17);
      this.Label11.TabIndex = 2;
      this.Label11.Text = "Label11";
      this.Label8.AutoSize = true;
      this.Label8.BackColor = System.Drawing.Color.Transparent;
      this.Label8.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
      this.Label8.Location = new Point(131, 27);
      this.Label8.Margin = new Padding(4, 0, 4, 0);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(51, 17);
      this.Label8.TabIndex = 1;
      this.Label8.Text = "Label8";
      this.Label7.AutoSize = true;
      this.Label7.BackColor = System.Drawing.Color.Transparent;
      this.Label7.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
      this.Label7.Location = new Point(161, 7);
      this.Label7.Margin = new Padding(4, 0, 4, 0);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(51, 17);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Label7";
      this.ButtonHelp.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Info24;
      this.ButtonHelp.BackgroundImageLayout = ImageLayout.Center;
      this.ButtonHelp.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.ButtonHelp.Location = new Point(19, 513);
      this.ButtonHelp.Margin = new Padding(4);
      this.ButtonHelp.Name = "ButtonHelp";
      this.ButtonHelp.Size = new Size(135, 46);
      this.ButtonHelp.TabIndex = 14;
      this.ButtonHelp.UseVisualStyleBackColor = true;
      this.PictureBox6.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox6.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox6.Location = new Point(5, 0);
      this.PictureBox6.Margin = new Padding(4);
      this.PictureBox6.Name = "PictureBox6";
      this.PictureBox6.Size = new Size(111, 82);
      this.PictureBox6.TabIndex = 11;
      this.PictureBox6.TabStop = false;
      this.PictureBox1.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.Comodo2;
      this.PictureBox1.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox1.Location = new Point(0, -10);
      this.PictureBox1.Margin = new Padding(4);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(564, 604);
      this.PictureBox1.TabIndex = 5;
      this.PictureBox1.TabStop = false;
      this.PictureBox7.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.logo_kmsAutoNettransparent1;
      this.PictureBox7.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox7.Location = new Point(5, 0);
      this.PictureBox7.Margin = new Padding(4);
      this.PictureBox7.Name = "PictureBox7";
      this.PictureBox7.Size = new Size(111, 82);
      this.PictureBox7.TabIndex = 12;
      this.PictureBox7.TabStop = false;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(549, 607);
      this.Controls.Add((Control) this.TabControl1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(567, 654);
      this.MinimumSize = new Size(567, 654);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      this.GroupBox9.ResumeLayout(false);
      this.GroupBox9.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.TabPage5.ResumeLayout(false);
      this.TabPage5.PerformLayout();
      this.GroupBox17.ResumeLayout(false);
      this.GroupBox17.PerformLayout();
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox3).EndInit();
      this.TabPage2.ResumeLayout(false);
      this.GroupBox16.ResumeLayout(false);
      this.GroupBox16.PerformLayout();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.GroupBox11.ResumeLayout(false);
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      ((ISupportInitialize) this.PictureBox9).EndInit();
      this.NumericUpDown3.EndInit();
      this.NumericUpDown2.EndInit();
      this.NumericUpDown1.EndInit();
      this.TabPage3.ResumeLayout(false);
      this.GroupBox19.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox5).EndInit();
      this.GroupBox12.ResumeLayout(false);
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.TabPage6.ResumeLayout(false);
      this.GroupBox14.ResumeLayout(false);
      this.GroupBox20.ResumeLayout(false);
      this.GroupBox18.ResumeLayout(false);
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      this.GroupBox13.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.TabPage4.ResumeLayout(false);
      this.TabPage4.PerformLayout();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage1
    {
      get
      {
        return this._TabPage1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TabPage1_Click);
        TabPage tabPage1_1 = this._TabPage1;
        if (tabPage1_1 != null)
          tabPage1_1.Click -= eventHandler;
        this._TabPage1 = value;
        TabPage tabPage1_2 = this._TabPage1;
        if (tabPage1_2 == null)
          return;
        tabPage1_2.Click += eventHandler;
      }
    }

    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button3
    {
      get
      {
        return this._Button3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button4
    {
      get
      {
        return this._Button4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button5
    {
      get
      {
        return this._Button5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        Button button5_1 = this._Button5;
        if (button5_1 != null)
          button5_1.Click -= eventHandler;
        this._Button5 = value;
        Button button5_2 = this._Button5;
        if (button5_2 == null)
          return;
        button5_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox1
    {
      get
      {
        return this._ComboBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
        ComboBox comboBox1_1 = this._ComboBox1;
        if (comboBox1_1 != null)
          comboBox1_1.SelectedIndexChanged -= eventHandler;
        this._ComboBox1 = value;
        ComboBox comboBox1_2 = this._ComboBox1;
        if (comboBox1_2 == null)
          return;
        comboBox1_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox2
    {
      get
      {
        return this._ComboBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox2_SelectedIndexChanged);
        ComboBox comboBox2_1 = this._ComboBox2;
        if (comboBox2_1 != null)
          comboBox2_1.SelectedIndexChanged -= eventHandler;
        this._ComboBox2 = value;
        ComboBox comboBox2_2 = this._ComboBox2;
        if (comboBox2_2 == null)
          return;
        comboBox2_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox3
    {
      get
      {
        return this._ComboBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.ComboBox3_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.ComboBox3_TextChench);
        ComboBox comboBox3_1 = this._ComboBox3;
        if (comboBox3_1 != null)
        {
          comboBox3_1.SelectedIndexChanged -= eventHandler1;
          comboBox3_1.TextChanged -= eventHandler2;
        }
        this._ComboBox3 = value;
        ComboBox comboBox3_2 = this._ComboBox3;
        if (comboBox3_2 == null)
          return;
        comboBox3_2.SelectedIndexChanged += eventHandler1;
        comboBox3_2.TextChanged += eventHandler2;
      }
    }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button13
    {
      get
      {
        return this._Button13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button13_Click);
        Button button13_1 = this._Button13;
        if (button13_1 != null)
          button13_1.Click -= eventHandler;
        this._Button13 = value;
        Button button13_2 = this._Button13;
        if (button13_2 == null)
          return;
        button13_2.Click += eventHandler;
      }
    }

    internal virtual Button Button12
    {
      get
      {
        return this._Button12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button12_Click);
        Button button12_1 = this._Button12;
        if (button12_1 != null)
          button12_1.Click -= eventHandler;
        this._Button12 = value;
        Button button12_2 = this._Button12;
        if (button12_2 == null)
          return;
        button12_2.Click += eventHandler;
      }
    }

    internal virtual Button Button15
    {
      get
      {
        return this._Button15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button15_Click);
        Button button15_1 = this._Button15;
        if (button15_1 != null)
          button15_1.Click -= eventHandler;
        this._Button15 = value;
        Button button15_2 = this._Button15;
        if (button15_2 == null)
          return;
        button15_2.Click += eventHandler;
      }
    }

    internal virtual Button Button14
    {
      get
      {
        return this._Button14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button14_Click);
        Button button14_1 = this._Button14;
        if (button14_1 != null)
          button14_1.Click -= eventHandler;
        this._Button14 = value;
        Button button14_2 = this._Button14;
        if (button14_2 == null)
          return;
        button14_2.Click += eventHandler;
      }
    }

    internal virtual Button Button17
    {
      get
      {
        return this._Button17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button17_Click);
        Button button17_1 = this._Button17;
        if (button17_1 != null)
          button17_1.Click -= eventHandler;
        this._Button17 = value;
        Button button17_2 = this._Button17;
        if (button17_2 == null)
          return;
        button17_2.Click += eventHandler;
      }
    }

    internal virtual Button Button16
    {
      get
      {
        return this._Button16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button16_Click);
        Button button16_1 = this._Button16;
        if (button16_1 != null)
          button16_1.Click -= eventHandler;
        this._Button16 = value;
        Button button16_2 = this._Button16;
        if (button16_2 == null)
          return;
        button16_2.Click += eventHandler;
      }
    }

    internal virtual TabPage TabPage4
    {
      get
      {
        return this._TabPage4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TabPage4_Click);
        TabPage tabPage4_1 = this._TabPage4;
        if (tabPage4_1 != null)
          tabPage4_1.Leave -= eventHandler;
        this._TabPage4 = value;
        TabPage tabPage4_2 = this._TabPage4;
        if (tabPage4_2 == null)
          return;
        tabPage4_2.Leave += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button18
    {
      get
      {
        return this._Button18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button18_Click);
        Button button18_1 = this._Button18;
        if (button18_1 != null)
          button18_1.Click -= eventHandler;
        this._Button18 = value;
        Button button18_2 = this._Button18;
        if (button18_2 == null)
          return;
        button18_2.Click += eventHandler;
      }
    }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button19
    {
      get
      {
        return this._Button19;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button19_Click);
        Button button19_1 = this._Button19;
        if (button19_1 != null)
          button19_1.Click -= eventHandler;
        this._Button19 = value;
        Button button19_2 = this._Button19;
        if (button19_2 == null)
          return;
        button19_2.Click += eventHandler;
      }
    }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button21
    {
      get
      {
        return this._Button21;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button21_Click);
        Button button21_1 = this._Button21;
        if (button21_1 != null)
          button21_1.Click -= eventHandler;
        this._Button21 = value;
        Button button21_2 = this._Button21;
        if (button21_2 == null)
          return;
        button21_2.Click += eventHandler;
      }
    }

    internal virtual Button Button20
    {
      get
      {
        return this._Button20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button20_Click);
        Button button20_1 = this._Button20;
        if (button20_1 != null)
          button20_1.Click -= eventHandler;
        this._Button20 = value;
        Button button20_2 = this._Button20;
        if (button20_2 == null)
          return;
        button20_2.Click += eventHandler;
      }
    }

    internal virtual Button Button22
    {
      get
      {
        return this._Button22;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button22_Click);
        Button button22_1 = this._Button22;
        if (button22_1 != null)
          button22_1.Click -= eventHandler;
        this._Button22 = value;
        Button button22_2 = this._Button22;
        if (button22_2 == null)
          return;
        button22_2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button7
    {
      get
      {
        return this._Button7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        Button button7_1 = this._Button7;
        if (button7_1 != null)
          button7_1.Click -= eventHandler;
        this._Button7 = value;
        Button button7_2 = this._Button7;
        if (button7_2 == null)
          return;
        button7_2.Click += eventHandler;
      }
    }

    internal virtual Button Button6
    {
      get
      {
        return this._Button6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        Button button6_1 = this._Button6;
        if (button6_1 != null)
          button6_1.Click -= eventHandler;
        this._Button6 = value;
        Button button6_2 = this._Button6;
        if (button6_2 == null)
          return;
        button6_2.Click += eventHandler;
      }
    }

    internal virtual Button Button25
    {
      get
      {
        return this._Button25;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button25_Click);
        Button button25_1 = this._Button25;
        if (button25_1 != null)
          button25_1.Click -= eventHandler;
        this._Button25 = value;
        Button button25_2 = this._Button25;
        if (button25_2 == null)
          return;
        button25_2.Click += eventHandler;
      }
    }

    internal virtual Button Button24
    {
      get
      {
        return this._Button24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button24_Click);
        Button button24_1 = this._Button24;
        if (button24_1 != null)
          button24_1.Click -= eventHandler;
        this._Button24 = value;
        Button button24_2 = this._Button24;
        if (button24_2 == null)
          return;
        button24_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox6
    {
      get
      {
        return this._ComboBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox6_SelectedIndexChanged);
        ComboBox comboBox6_1 = this._ComboBox6;
        if (comboBox6_1 != null)
          comboBox6_1.SelectedIndexChanged -= eventHandler;
        this._ComboBox6 = value;
        ComboBox comboBox6_2 = this._ComboBox6;
        if (comboBox6_2 == null)
          return;
        comboBox6_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button26
    {
      get
      {
        return this._Button26;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button26_Click);
        Button button26_1 = this._Button26;
        if (button26_1 != null)
          button26_1.Click -= eventHandler;
        this._Button26 = value;
        Button button26_2 = this._Button26;
        if (button26_2 == null)
          return;
        button26_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button28
    {
      get
      {
        return this._Button28;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button28_Click);
        Button button28_1 = this._Button28;
        if (button28_1 != null)
          button28_1.Click -= eventHandler;
        this._Button28 = value;
        Button button28_2 = this._Button28;
        if (button28_2 == null)
          return;
        button28_2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxLog
    {
      get
      {
        return this._CheckBoxLog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxLog_CheckedChanged);
        CheckBox checkBoxLog1 = this._CheckBoxLog;
        if (checkBoxLog1 != null)
          checkBoxLog1.CheckedChanged -= eventHandler;
        this._CheckBoxLog = value;
        CheckBox checkBoxLog2 = this._CheckBoxLog;
        if (checkBoxLog2 == null)
          return;
        checkBoxLog2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button Button27
    {
      get
      {
        return this._Button27;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button27_Click);
        Button button27_1 = this._Button27;
        if (button27_1 != null)
          button27_1.Click -= eventHandler;
        this._Button27 = value;
        Button button27_2 = this._Button27;
        if (button27_2 == null)
          return;
        button27_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button30
    {
      get
      {
        return this._Button30;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button30_Click);
        Button button30_1 = this._Button30;
        if (button30_1 != null)
          button30_1.Click -= eventHandler;
        this._Button30 = value;
        Button button30_2 = this._Button30;
        if (button30_2 == null)
          return;
        button30_2.Click += eventHandler;
      }
    }

    internal virtual Button Button29
    {
      get
      {
        return this._Button29;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button29_Click);
        Button button29_1 = this._Button29;
        if (button29_1 != null)
          button29_1.Click -= eventHandler;
        this._Button29 = value;
        Button button29_2 = this._Button29;
        if (button29_2 == null)
          return;
        button29_2.Click += eventHandler;
      }
    }

    internal virtual Button Button31
    {
      get
      {
        return this._Button31;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button31_Click);
        Button button31_1 = this._Button31;
        if (button31_1 != null)
          button31_1.Click -= eventHandler;
        this._Button31 = value;
        Button button31_2 = this._Button31;
        if (button31_2 == null)
          return;
        button31_2.Click += eventHandler;
      }
    }

    internal virtual Button Button32
    {
      get
      {
        return this._Button32;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button32_Click);
        Button button32_1 = this._Button32;
        if (button32_1 != null)
          button32_1.Click -= eventHandler;
        this._Button32 = value;
        Button button32_2 = this._Button32;
        if (button32_2 == null)
          return;
        button32_2.Click += eventHandler;
      }
    }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button8
    {
      get
      {
        return this._Button8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        Button button8_1 = this._Button8;
        if (button8_1 != null)
          button8_1.Click -= eventHandler;
        this._Button8 = value;
        Button button8_2 = this._Button8;
        if (button8_2 == null)
          return;
        button8_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button9
    {
      get
      {
        return this._Button9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button9_Click);
        Button button9_1 = this._Button9;
        if (button9_1 != null)
          button9_1.Click -= eventHandler;
        this._Button9 = value;
        Button button9_2 = this._Button9;
        if (button9_2 == null)
          return;
        button9_2.Click += eventHandler;
      }
    }

    internal virtual Button Button11
    {
      get
      {
        return this._Button11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button11_Click);
        Button button11_1 = this._Button11;
        if (button11_1 != null)
          button11_1.Click -= eventHandler;
        this._Button11 = value;
        Button button11_2 = this._Button11;
        if (button11_2 == null)
          return;
        button11_2.Click += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel1
    {
      get
      {
        return this._LinkLabel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        LinkLabel linkLabel1_1 = this._LinkLabel1;
        if (linkLabel1_1 != null)
          linkLabel1_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel1 = value;
        LinkLabel linkLabel1_2 = this._LinkLabel1;
        if (linkLabel1_2 == null)
          return;
        linkLabel1_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Button Button33
    {
      get
      {
        return this._Button33;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button33_Click);
        Button button33_1 = this._Button33;
        if (button33_1 != null)
          button33_1.Click -= eventHandler;
        this._Button33 = value;
        Button button33_2 = this._Button33;
        if (button33_2 == null)
          return;
        button33_2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
        PictureBox pictureBox1_1 = this._PictureBox1;
        if (pictureBox1_1 != null)
          pictureBox1_1.Click -= eventHandler;
        this._PictureBox1 = value;
        PictureBox pictureBox1_2 = this._PictureBox1;
        if (pictureBox1_2 == null)
          return;
        pictureBox1_2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get
      {
        return this._PictureBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox2_Click);
        PictureBox pictureBox2_1 = this._PictureBox2;
        if (pictureBox2_1 != null)
          pictureBox2_1.Click -= eventHandler;
        this._PictureBox2 = value;
        PictureBox pictureBox2_2 = this._PictureBox2;
        if (pictureBox2_2 == null)
          return;
        pictureBox2_2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button35
    {
      get
      {
        return this._Button35;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button35_Click);
        Button button35_1 = this._Button35;
        if (button35_1 != null)
          button35_1.Click -= eventHandler;
        this._Button35 = value;
        Button button35_2 = this._Button35;
        if (button35_2 == null)
          return;
        button35_2.Click += eventHandler;
      }
    }

    internal virtual Button Button34
    {
      get
      {
        return this._Button34;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button34_Click);
        Button button34_1 = this._Button34;
        if (button34_1 != null)
          button34_1.Click -= eventHandler;
        this._Button34 = value;
        Button button34_2 = this._Button34;
        if (button34_2 == null)
          return;
        button34_2.Click += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel3
    {
      get
      {
        return this._LinkLabel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
        LinkLabel linkLabel3_1 = this._LinkLabel3;
        if (linkLabel3_1 != null)
          linkLabel3_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel3 = value;
        LinkLabel linkLabel3_2 = this._LinkLabel3;
        if (linkLabel3_2 == null)
          return;
        linkLabel3_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Button Button39
    {
      get
      {
        return this._Button39;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button39_Click);
        Button button39_1 = this._Button39;
        if (button39_1 != null)
          button39_1.Click -= eventHandler;
        this._Button39 = value;
        Button button39_2 = this._Button39;
        if (button39_2 == null)
          return;
        button39_2.Click += eventHandler;
      }
    }

    internal virtual TabPage TabPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button40
    {
      get
      {
        return this._Button40;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button40_Click);
        Button button40_1 = this._Button40;
        if (button40_1 != null)
          button40_1.Click -= eventHandler;
        this._Button40 = value;
        Button button40_2 = this._Button40;
        if (button40_2 == null)
          return;
        button40_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonHelp
    {
      get
      {
        return this._ButtonHelp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button41_Click);
        Button buttonHelp1 = this._ButtonHelp;
        if (buttonHelp1 != null)
          buttonHelp1.Click -= eventHandler;
        this._ButtonHelp = value;
        Button buttonHelp2 = this._ButtonHelp;
        if (buttonHelp2 == null)
          return;
        buttonHelp2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button43
    {
      get
      {
        return this._Button43;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button43_Click);
        Button button43_1 = this._Button43;
        if (button43_1 != null)
          button43_1.Click -= eventHandler;
        this._Button43 = value;
        Button button43_2 = this._Button43;
        if (button43_2 == null)
          return;
        button43_2.Click += eventHandler;
      }
    }

    internal virtual Button Button42
    {
      get
      {
        return this._Button42;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button42_Click);
        Button button42_1 = this._Button42;
        if (button42_1 != null)
          button42_1.Click -= eventHandler;
        this._Button42 = value;
        Button button42_2 = this._Button42;
        if (button42_2 == null)
          return;
        button42_2.Click += eventHandler;
      }
    }

    internal virtual Button Button46
    {
      get
      {
        return this._Button46;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button46_Click);
        Button button46_1 = this._Button46;
        if (button46_1 != null)
          button46_1.Click -= eventHandler;
        this._Button46 = value;
        Button button46_2 = this._Button46;
        if (button46_2 == null)
          return;
        button46_2.Click += eventHandler;
      }
    }

    internal virtual Button Button47
    {
      get
      {
        return this._Button47;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button47_Click);
        Button button47_1 = this._Button47;
        if (button47_1 != null)
          button47_1.Click -= eventHandler;
        this._Button47 = value;
        Button button47_2 = this._Button47;
        if (button47_2 == null)
          return;
        button47_2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox6
    {
      get
      {
        return this._CheckBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox6_CheckedChanged);
        CheckBox checkBox6_1 = this._CheckBox6;
        if (checkBox6_1 != null)
          checkBox6_1.CheckedChanged -= eventHandler;
        this._CheckBox6 = value;
        CheckBox checkBox6_2 = this._CheckBox6;
        if (checkBox6_2 == null)
          return;
        checkBox6_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox10
    {
      get
      {
        return this._ComboBox10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox10_SelectedIndexChanged);
        ComboBox comboBox10_1 = this._ComboBox10;
        if (comboBox10_1 != null)
          comboBox10_1.SelectedIndexChanged -= eventHandler;
        this._ComboBox10 = value;
        ComboBox comboBox10_2 = this._ComboBox10;
        if (comboBox10_2 == null)
          return;
        comboBox10_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button Button48
    {
      get
      {
        return this._Button48;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button48_Click);
        Button button48_1 = this._Button48;
        if (button48_1 != null)
          button48_1.Click -= eventHandler;
        this._Button48 = value;
        Button button48_2 = this._Button48;
        if (button48_2 == null)
          return;
        button48_2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxIP
    {
      get
      {
        return this._CheckBoxIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxShowIP_CheckedChanged);
        CheckBox checkBoxIp1 = this._CheckBoxIP;
        if (checkBoxIp1 != null)
          checkBoxIp1.CheckedChanged -= eventHandler;
        this._CheckBoxIP = value;
        CheckBox checkBoxIp2 = this._CheckBoxIP;
        if (checkBoxIp2 == null)
          return;
        checkBoxIp2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RB3TAP
    {
      get
      {
        return this._RB3TAP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RB3TAP_CheckedChanged);
        RadioButton rb3Tap1 = this._RB3TAP;
        if (rb3Tap1 != null)
          rb3Tap1.CheckedChanged -= eventHandler;
        this._RB3TAP = value;
        RadioButton rb3Tap2 = this._RB3TAP;
        if (rb3Tap2 == null)
          return;
        rb3Tap2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RB2WD
    {
      get
      {
        return this._RB2WD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RB2WDV_CheckedChanged);
        RadioButton rb2Wd1 = this._RB2WD;
        if (rb2Wd1 != null)
          rb2Wd1.CheckedChanged -= eventHandler;
        this._RB2WD = value;
        RadioButton rb2Wd2 = this._RB2WD;
        if (rb2Wd2 == null)
          return;
        rb2Wd2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RB1AUTO
    {
      get
      {
        return this._RB1AUTO;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RB1AUTO_CheckedChanged);
        RadioButton rb1Auto1 = this._RB1AUTO;
        if (rb1Auto1 != null)
          rb1Auto1.CheckedChanged -= eventHandler;
        this._RB1AUTO = value;
        RadioButton rb1Auto2 = this._RB1AUTO;
        if (rb1Auto2 == null)
          return;
        rb1Auto2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RB4NOAuto
    {
      get
      {
        return this._RB4NOAuto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RB4NOAuto_CheckedChanged);
        RadioButton rb4NoAuto1 = this._RB4NOAuto;
        if (rb4NoAuto1 != null)
          rb4NoAuto1.CheckedChanged -= eventHandler;
        this._RB4NOAuto = value;
        RadioButton rb4NoAuto2 = this._RB4NOAuto;
        if (rb4NoAuto2 == null)
          return;
        rb4NoAuto2.CheckedChanged += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel2
    {
      get
      {
        return this._LinkLabel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
        LinkLabel linkLabel2_1 = this._LinkLabel2;
        if (linkLabel2_1 != null)
          linkLabel2_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel2 = value;
        LinkLabel linkLabel2_2 = this._LinkLabel2;
        if (linkLabel2_2 == null)
          return;
        linkLabel2_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel6
    {
      get
      {
        return this._LinkLabel6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel6_LinkClicked);
        LinkLabel linkLabel6_1 = this._LinkLabel6;
        if (linkLabel6_1 != null)
          linkLabel6_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel6 = value;
        LinkLabel linkLabel6_2 = this._LinkLabel6;
        if (linkLabel6_2 == null)
          return;
        linkLabel6_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel5
    {
      get
      {
        return this._LinkLabel5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel5_LinkClicked);
        LinkLabel linkLabel5_1 = this._LinkLabel5;
        if (linkLabel5_1 != null)
          linkLabel5_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel5 = value;
        LinkLabel linkLabel5_2 = this._LinkLabel5;
        if (linkLabel5_2 == null)
          return;
        linkLabel5_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel4
    {
      get
      {
        return this._LinkLabel4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
        LinkLabel linkLabel4_1 = this._LinkLabel4;
        if (linkLabel4_1 != null)
          linkLabel4_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel4 = value;
        LinkLabel linkLabel4_2 = this._LinkLabel4;
        if (linkLabel4_2 == null)
          return;
        linkLabel4_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual LinkLabel LinkLabel7
    {
      get
      {
        return this._LinkLabel7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel7_LinkClicked);
        LinkLabel linkLabel7_1 = this._LinkLabel7;
        if (linkLabel7_1 != null)
          linkLabel7_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel7 = value;
        LinkLabel linkLabel7_2 = this._LinkLabel7;
        if (linkLabel7_2 == null)
          return;
        linkLabel7_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel8
    {
      get
      {
        return this._LinkLabel8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel8_LinkClicked);
        LinkLabel linkLabel8_1 = this._LinkLabel8;
        if (linkLabel8_1 != null)
          linkLabel8_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel8 = value;
        LinkLabel linkLabel8_2 = this._LinkLabel8;
        if (linkLabel8_2 == null)
          return;
        linkLabel8_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual RadioButton RB5Hook
    {
      get
      {
        return this._RB5Hook;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RB5Hook_CheckedChanged);
        RadioButton rb5Hook1 = this._RB5Hook;
        if (rb5Hook1 != null)
          rb5Hook1.CheckedChanged -= eventHandler;
        this._RB5Hook = value;
        RadioButton rb5Hook2 = this._RB5Hook;
        if (rb5Hook2 == null)
          return;
        rb5Hook2.CheckedChanged += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel9
    {
      get
      {
        return this._LinkLabel9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel9_LinkClicked);
        LinkLabel linkLabel9_1 = this._LinkLabel9;
        if (linkLabel9_1 != null)
          linkLabel9_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel9 = value;
        LinkLabel linkLabel9_2 = this._LinkLabel9;
        if (linkLabel9_2 == null)
          return;
        linkLabel9_2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual GroupBox GroupBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkBoxReset
    {
      get
      {
        return this._ChkBoxReset;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkBoxReset_CheckedChanged_1);
        CheckBox chkBoxReset1 = this._ChkBoxReset;
        if (chkBoxReset1 != null)
          chkBoxReset1.CheckedChanged -= eventHandler;
        this._ChkBoxReset = value;
        CheckBox chkBoxReset2 = this._ChkBoxReset;
        if (chkBoxReset2 == null)
          return;
        chkBoxReset2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonVideo
    {
      get
      {
        return this._ButtonVideo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonVideo_Click);
        Button buttonVideo1 = this._ButtonVideo;
        if (buttonVideo1 != null)
          buttonVideo1.Click -= eventHandler;
        this._ButtonVideo = value;
        Button buttonVideo2 = this._ButtonVideo;
        if (buttonVideo2 == null)
          return;
        buttonVideo2.Click += eventHandler;
      }
    }

    internal virtual Button ButtonValidator
    {
      get
      {
        return this._ButtonValidator;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonValidator_Click);
        Button buttonValidator1 = this._ButtonValidator;
        if (buttonValidator1 != null)
          buttonValidator1.Click -= eventHandler;
        this._ButtonValidator = value;
        Button buttonValidator2 = this._ButtonValidator;
        if (buttonValidator2 == null)
          return;
        buttonValidator2.Click += eventHandler;
      }
    }

    internal virtual Button ButtonVideoSearch
    {
      get
      {
        return this._ButtonVideoSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonVideoSearch_Click);
        Button buttonVideoSearch1 = this._ButtonVideoSearch;
        if (buttonVideoSearch1 != null)
          buttonVideoSearch1.Click -= eventHandler;
        this._ButtonVideoSearch = value;
        Button buttonVideoSearch2 = this._ButtonVideoSearch;
        if (buttonVideoSearch2 == null)
          return;
        buttonVideoSearch2.Click += eventHandler;
      }
    }

    internal virtual NumericUpDown NumericUpDown3
    {
      get
      {
        return this._NumericUpDown3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown3_ValueChanged);
        NumericUpDown numericUpDown3_1 = this._NumericUpDown3;
        if (numericUpDown3_1 != null)
          numericUpDown3_1.ValueChanged -= eventHandler;
        this._NumericUpDown3 = value;
        NumericUpDown numericUpDown3_2 = this._NumericUpDown3;
        if (numericUpDown3_2 == null)
          return;
        numericUpDown3_2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown NumericUpDown2
    {
      get
      {
        return this._NumericUpDown2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown2_ValueChanged);
        NumericUpDown numericUpDown2_1 = this._NumericUpDown2;
        if (numericUpDown2_1 != null)
          numericUpDown2_1.ValueChanged -= eventHandler;
        this._NumericUpDown2 = value;
        NumericUpDown numericUpDown2_2 = this._NumericUpDown2;
        if (numericUpDown2_2 == null)
          return;
        numericUpDown2_2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown NumericUpDown1
    {
      get
      {
        return this._NumericUpDown1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown1_ValueChanged);
        NumericUpDown numericUpDown1_1 = this._NumericUpDown1;
        if (numericUpDown1_1 != null)
          numericUpDown1_1.ValueChanged -= eventHandler;
        this._NumericUpDown1 = value;
        NumericUpDown numericUpDown1_2 = this._NumericUpDown1;
        if (numericUpDown1_2 == null)
          return;
        numericUpDown1_2.ValueChanged += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label LabelAITime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label LabelRITime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxKP
    {
      get
      {
        return this._CheckBoxKP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxKP_CheckedChanged);
        CheckBox checkBoxKp1 = this._CheckBoxKP;
        if (checkBoxKp1 != null)
          checkBoxKp1.CheckedChanged -= eventHandler;
        this._CheckBoxKP = value;
        CheckBox checkBoxKp2 = this._CheckBoxKP;
        if (checkBoxKp2 == null)
          return;
        checkBoxKp2.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox1
    {
      get
      {
        return this._CheckBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
        CheckBox checkBox1_1 = this._CheckBox1;
        if (checkBox1_1 != null)
          checkBox1_1.CheckedChanged -= eventHandler;
        this._CheckBox1 = value;
        CheckBox checkBox1_2 = this._CheckBox1;
        if (checkBox1_2 == null)
          return;
        checkBox1_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CBox7IniFile
    {
      get
      {
        return this._CBox7IniFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CBox7IniFile_CheckedChanged);
        CheckBox cbox7IniFile1 = this._CBox7IniFile;
        if (cbox7IniFile1 != null)
          cbox7IniFile1.CheckedChanged -= eventHandler;
        this._CBox7IniFile = value;
        CheckBox cbox7IniFile2 = this._CBox7IniFile;
        if (cbox7IniFile2 == null)
          return;
        cbox7IniFile2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxAnalizer
    {
      get
      {
        return this._CheckBoxAnalizer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxAnalizer_CheckedChanged);
        CheckBox checkBoxAnalizer1 = this._CheckBoxAnalizer;
        if (checkBoxAnalizer1 != null)
          checkBoxAnalizer1.CheckedChanged -= eventHandler;
        this._CheckBoxAnalizer = value;
        CheckBox checkBoxAnalizer2 = this._CheckBoxAnalizer;
        if (checkBoxAnalizer2 == null)
          return;
        checkBoxAnalizer2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox3
    {
      get
      {
        return this._CheckBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox3_CheckedChanged);
        CheckBox checkBox3_1 = this._CheckBox3;
        if (checkBox3_1 != null)
          checkBox3_1.CheckedChanged -= eventHandler;
        this._CheckBox3 = value;
        CheckBox checkBox3_2 = this._CheckBox3;
        if (checkBox3_2 == null)
          return;
        checkBox3_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox5
    {
      get
      {
        return this._CheckBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox5_CheckedChanged);
        CheckBox checkBox5_1 = this._CheckBox5;
        if (checkBox5_1 != null)
          checkBox5_1.CheckedChanged -= eventHandler;
        this._CheckBox5 = value;
        CheckBox checkBox5_2 = this._CheckBox5;
        if (checkBox5_2 == null)
          return;
        checkBox5_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox4
    {
      get
      {
        return this._CheckBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox4_CheckedChanged);
        CheckBox checkBox4_1 = this._CheckBox4;
        if (checkBox4_1 != null)
          checkBox4_1.CheckedChanged -= eventHandler;
        this._CheckBox4 = value;
        CheckBox checkBox4_2 = this._CheckBox4;
        if (checkBox4_2 == null)
          return;
        checkBox4_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox9
    {
      get
      {
        return this._PictureBox9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox9_Click);
        PictureBox pictureBox9_1 = this._PictureBox9;
        if (pictureBox9_1 != null)
          pictureBox9_1.Click -= eventHandler;
        this._PictureBox9 = value;
        PictureBox pictureBox9_2 = this._PictureBox9;
        if (pictureBox9_2 == null)
          return;
        pictureBox9_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button23
    {
      get
      {
        return this._Button23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button23_Click);
        Button button23_1 = this._Button23;
        if (button23_1 != null)
          button23_1.Click -= eventHandler;
        this._Button23 = value;
        Button button23_2 = this._Button23;
        if (button23_2 == null)
          return;
        button23_2.Click += eventHandler;
      }
    }

    internal virtual Button Button36
    {
      get
      {
        return this._Button36;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button36_Click);
        Button button36_1 = this._Button36;
        if (button36_1 != null)
          button36_1.Click -= eventHandler;
        this._Button36 = value;
        Button button36_2 = this._Button36;
        if (button36_2 == null)
          return;
        button36_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button37
    {
      get
      {
        return this._Button37;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button37_Click);
        Button button37_1 = this._Button37;
        if (button37_1 != null)
          button37_1.Click -= eventHandler;
        this._Button37 = value;
        Button button37_2 = this._Button37;
        if (button37_2 == null)
          return;
        button37_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBoxHwid
    {
      get
      {
        return this._ComboBoxHwid;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBoxHwid_SelectedIndexChanged);
        ComboBox comboBoxHwid1 = this._ComboBoxHwid;
        if (comboBoxHwid1 != null)
          comboBoxHwid1.SelectedIndexChanged -= eventHandler;
        this._ComboBoxHwid = value;
        ComboBox comboBoxHwid2 = this._ComboBoxHwid;
        if (comboBoxHwid2 == null)
          return;
        comboBoxHwid2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button ButtonHwMn
    {
      get
      {
        return this._ButtonHwMn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonHwMn_Click);
        Button buttonHwMn1 = this._ButtonHwMn;
        if (buttonHwMn1 != null)
          buttonHwMn1.Click -= eventHandler;
        this._ButtonHwMn = value;
        Button buttonHwMn2 = this._ButtonHwMn;
        if (buttonHwMn2 == null)
          return;
        buttonHwMn2.Click += eventHandler;
      }
    }

    internal virtual Button ButtonHwPl
    {
      get
      {
        return this._ButtonHwPl;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonHwPl_Click);
        Button buttonHwPl1 = this._ButtonHwPl;
        if (buttonHwPl1 != null)
          buttonHwPl1.Click -= eventHandler;
        this._ButtonHwPl = value;
        Button buttonHwPl2 = this._ButtonHwPl;
        if (buttonHwPl2 == null)
          return;
        buttonHwPl2.Click += eventHandler;
      }
    }

    internal virtual Label LabelHwid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button38
    {
      get
      {
        return this._Button38;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button38_Click);
        Button button38_1 = this._Button38;
        if (button38_1 != null)
          button38_1.Click -= eventHandler;
        this._Button38 = value;
        Button button38_2 = this._Button38;
        if (button38_2 == null)
          return;
        button38_2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxInstKey
    {
      get
      {
        return this._CheckBoxInstKey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxInstKey_CheckedChanged);
        CheckBox checkBoxInstKey1 = this._CheckBoxInstKey;
        if (checkBoxInstKey1 != null)
          checkBoxInstKey1.CheckedChanged -= eventHandler;
        this._CheckBoxInstKey = value;
        CheckBox checkBoxInstKey2 = this._CheckBoxInstKey;
        if (checkBoxInstKey2 == null)
          return;
        checkBoxInstKey2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button Button41
    {
      get
      {
        return this._Button41;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button41_Click_1);
        Button button41_1 = this._Button41;
        if (button41_1 != null)
          button41_1.Click -= eventHandler;
        this._Button41 = value;
        Button button41_2 = this._Button41;
        if (button41_2 == null)
          return;
        button41_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBoxLangs
    {
      get
      {
        return this._ComboBoxLangs;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox4_SelectedIndexChanged);
        ComboBox comboBoxLangs1 = this._ComboBoxLangs;
        if (comboBoxLangs1 != null)
          comboBoxLangs1.SelectedIndexChanged -= eventHandler;
        this._ComboBoxLangs = value;
        ComboBox comboBoxLangs2 = this._ComboBoxLangs;
        if (comboBoxLangs2 == null)
          return;
        comboBoxLangs2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button ButtonOfficeScript
    {
      get
      {
        return this._ButtonOfficeScript;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonOfficeScript_Click);
        Button buttonOfficeScript1 = this._ButtonOfficeScript;
        if (buttonOfficeScript1 != null)
          buttonOfficeScript1.Click -= eventHandler;
        this._ButtonOfficeScript = value;
        Button buttonOfficeScript2 = this._ButtonOfficeScript;
        if (buttonOfficeScript2 == null)
          return;
        buttonOfficeScript2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxFakeIP
    {
      get
      {
        return this._CheckBoxFakeIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxFakeIP_CheckedChanged);
        CheckBox checkBoxFakeIp1 = this._CheckBoxFakeIP;
        if (checkBoxFakeIp1 != null)
          checkBoxFakeIp1.CheckedChanged -= eventHandler;
        this._CheckBoxFakeIP = value;
        CheckBox checkBoxFakeIp2 = this._CheckBoxFakeIP;
        if (checkBoxFakeIp2 == null)
          return;
        checkBoxFakeIp2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBoxFakeIP
    {
      get
      {
        return this._TextBoxFakeIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxFakeIP_TextChanged);
        TextBox textBoxFakeIp1 = this._TextBoxFakeIP;
        if (textBoxFakeIp1 != null)
          textBoxFakeIp1.LostFocus -= eventHandler;
        this._TextBoxFakeIP = value;
        TextBox textBoxFakeIp2 = this._TextBoxFakeIP;
        if (textBoxFakeIp2 == null)
          return;
        textBoxFakeIp2.LostFocus += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonHideUpdates
    {
      get
      {
        return this._ButtonHideUpdates;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonHideUpdates_Click);
        Button buttonHideUpdates1 = this._ButtonHideUpdates;
        if (buttonHideUpdates1 != null)
          buttonHideUpdates1.Click -= eventHandler;
        this._ButtonHideUpdates = value;
        Button buttonHideUpdates2 = this._ButtonHideUpdates;
        if (buttonHideUpdates2 == null)
          return;
        buttonHideUpdates2.Click += eventHandler;
      }
    }

    internal virtual Button Button10
    {
      get
      {
        return this._Button10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button10_Click);
        Button button10_1 = this._Button10;
        if (button10_1 != null)
          button10_1.Click -= eventHandler;
        this._Button10 = value;
        Button button10_2 = this._Button10;
        if (button10_2 == null)
          return;
        button10_2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DllImport("slwga.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern uint SLIsGenuineLocal(ref Guid slid, ref int genuineState, int uIopts);

    private void Form1_Load(object sender, EventArgs e)
    {
      Application.EnableVisualStyles();
      this.LoadingProgramm = true;
      this.TargetLang = "";
      this.LoadProgramSetting();
      if (Operators.CompareString(this.TargetLang, "RU", false) == 0 | Operators.CompareString(this.TargetLang, "EN", false) == 0 | Operators.CompareString(this.TargetLang, "FR", false) == 0 | Operators.CompareString(this.TargetLang, "ES", false) == 0 | Operators.CompareString(this.TargetLang, "VI", false) == 0 | Operators.CompareString(this.TargetLang, "UA", false) == 0)
        Lang.LanguageSet(this.TargetLang);
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("EN"))
      {
        Lang.LanguageSet("EN");
        this.TargetLang = "EN";
      }
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("FR"))
      {
        Lang.LanguageSet("FR");
        this.TargetLang = "FR";
      }
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("RU"))
      {
        Lang.LanguageSet("RU");
        this.TargetLang = "RU";
      }
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("ES"))
      {
        Lang.LanguageSet("ES");
        this.TargetLang = "ES";
      }
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("VI"))
      {
        Lang.LanguageSet("VI");
        this.TargetLang = "VI";
      }
      else if (Strings.UCase(CultureInfo.CurrentCulture.Name).Contains("UA"))
      {
        Lang.LanguageSet("UA");
        this.TargetLang = "UA";
      }
      else
      {
        Lang.LanguageSet("EN");
        this.TargetLang = "EN";
      }
      if (this.LoadingError)
      {
        this.Close();
      }
      else
      {
        this.Hide();
        this.Visible = false;
        this.MaximizeBox = false;
        this._actSuccessfull = "                            ===== " + Lang.WmiaApActSuccessful + " =====";
        this._productListWindowsOffice[0, 0] = "=== Windows, " + Lang.Yourkey + " ===";
        this._productListWindowsOffice[1, 0] = "=== Office, " + Lang.Yourkey + " ===";
        this.Text = this._version;
        this.GroupBox11.Text = "";
        this.ComboBox8.Hide();
        this.GroupBox7.Hide();
        this.Label7.Text = Lang.LabelText7;
        this.Label8.Text = "Coded by: Ratiborus, co-developer Evgeny972";
        this.LinkLabel3.Text = Lang.Validation;
        this.Button1.Text = Lang.ButtonText1;
        this.Button2.Text = Lang.ButtonText2;
        this.Button3.Text = Lang.ButtonText3;
        this.Button4.Text = Lang.ButtonText4;
        this.Button5.Text = Lang.ButtonText5;
        this.Button18.Text = Lang.ButtonText18;
        this.Button19.Text = Lang.ButtonText19;
        this.Button20.Text = Lang.ButtonText20;
        this.Button21.Text = Lang.ButtonText21;
        this.Button22.Text = Lang.ButtonText22;
        this.Button6.Text = Lang.ButtonText6;
        this.Button7.Text = Lang.ButtonText7;
        this.Button8.Text = Lang.ButtonText8;
        this.Button9.Text = Lang.ActivationBackupButtonWin;
        this.Button11.Text = "Rearm";
        this.Button23.Text = "ShowHideControls";
        this.Button26.Text = Lang.ButtonText26;
        this.Button27.Text = Lang.ButtonText27;
        this.Button28.Text = Lang.ButtonText28;
        this.Button29.Text = Lang.ButtonText29;
        this.Button30.Text = Lang.ButtonText30;
        this.Button31.Text = Lang.ButtonText31;
        this.Button32.Text = Lang.ButtonText32;
        this.Button33.Text = Lang.ButtonText23;
        this.Button34.Text = Lang.GroupBoxText2;
        this.Button35.Text = Lang.GroupBoxText9;
        this.Button36.Text = Lang.ShowHideControllTxt;
        this.Button37.Text = Lang.OffConvertTxt;
        this.Button38.Text = Lang.UtilitiesTxt;
        this.Button40.Text = Lang.Button40Text;
        this.Button43.Text = Lang.Services;
        this.ButtonOfficeScript.Text = Lang.DelOfficeUpdatesTxt;
        this.Button42.Text = Lang.SchedulerText;
        this.Button46.Text = Lang.ButtonText46;
        this.Button47.Text = Lang.ButtonText47;
        this.Button48.Text = Lang.KeyInstall;
        this.ButtonValidator.Text = Lang.ValidatorBtntxt;
        this.ButtonHideUpdates.Text = "Show or hide updates";
        this.Label11.Text = Lang.LabelText11;
        this.Label13.Text = Lang.ProgInterfaceTxt;
        this.Label14.Text = "";
        this.Label15.Text = "";
        this.TabPage1.Text = Lang.TabPageText1;
        this.TabPage2.Text = Lang.TabPageText2;
        this.TabPage3.Text = Lang.TabPageText3;
        this.TabPage4.Text = Lang.TabPageText4;
        this.TabPage5.Text = Lang.TabPageText5;
        this.TabPage6.Text = Lang.TabPageText6;
        this.GroupBox1.Text = "                    ";
        this.LinkLabel7.Text = Lang.GroupBoxText1;
        this.GroupBox10.Text = "                       ";
        this.LinkLabel8.Text = Lang.GroupBoxText10;
        this.GroupBox2.Text = "";
        this.GroupBox3.Text = Lang.GroupBoxText3;
        this.GroupBox4.Text = Lang.GroupBoxText4;
        this.GroupBox5.Text = Lang.GroupBoxText5 + " №1";
        this.GroupBox6.Text = Lang.GroupBoxText6;
        this.GroupBox7.Text = Lang.GroupBoxText7 + " KMS-Service";
        this.GroupBox9.Text = "";
        this.GroupBox12.Text = Lang.ActivationBackup;
        this.GroupBox13.Text = Lang.Admin;
        this.GroupBox14.Text = "Microsoft Windows 10";
        this.GroupBox15.Text = Lang.KeysWinOffice;
        this.GroupBox16.Text = Lang.GroupBoxText7;
        this.GroupBox18.Text = Lang.GroupBoxText5 + " №2";
        this.GroupBox19.Text = "Microsoft Office 2010/2013/2016";
        this.GroupBox20.Text = "";
        this.CheckBox1.Text = Lang.CheckBoxText1;
        this.CheckBoxLog.Text = Lang.CheckBoxText2;
        this.CheckBox3.Text = Lang.CheckBoxText3;
        this.CheckBox4.Text = Lang.CheckBoxText4;
        this.CheckBox5.Text = Lang.CheckBoxText5;
        this.CheckBox6.Text = Lang.CrazymodeText;
        this.CBox7IniFile.Text = Lang.Cb7Txt;
        this.CheckBoxAnalizer.Text = Lang.KmsAnalizerTxt;
        this.CheckBoxIP.Text = Lang.LogModeIptxt;
        this.ChkBoxReset.Text = Lang.ResetTxt;
        this.CheckBoxInstKey.Text = Lang.InstallKeyTxt;
        this.CheckBoxFakeIP.Text = Lang.FakeIptxt;
        this.LinkLabel2.Text = "WinDivert";
        this.LinkLabel4.Text = "Auto";
        this.LinkLabel6.Text = "TAP";
        this.Label17.Text = "";
        this.LinkLabel4.Text = "NoAuto";
        this.GroupBox17.Text = Lang.Gb16Txt;
        if (Operators.CompareString(this.TargetLang, "CN", false) == 0)
        {
          this.Label13.Location = new Point(100, 54);
          this.Button39.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
        }
        if (Operators.CompareString(this.TargetLang, "VI", false) == 0)
        {
          this.Label13.Location = new Point(120, 54);
          this.Button39.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
          this.Button39.Location = new Point(297, 412);
          this.Button39.Size = new Size(101, 57);
          this._actSuccessfull = "                       ===== " + Lang.WmiaApActSuccessful + " =====";
        }
        this.ToolTip1.SetToolTip((Control) this.Button1, Lang.ToolTipButton1);
        this.ToolTip1.SetToolTip((Control) this.Button2, Lang.ToolTipButton2);
        this.ToolTip1.SetToolTip((Control) this.Button3, Lang.ToolTipButton3);
        this.ToolTip1.SetToolTip((Control) this.Button4, Lang.ToolTipButton4);
        this.ToolTip1.SetToolTip((Control) this.Button5, Lang.ToolTipButton5);
        this.ToolTip1.SetToolTip((Control) this.Button6, Lang.ToolTipButton6);
        this.ToolTip1.SetToolTip((Control) this.Button7, Lang.ToolTipButton7);
        this.ToolTip1.SetToolTip((Control) this.Button8, Lang.ToolTipButton8);
        this.ToolTip1.SetToolTip((Control) this.Button12, Lang.ToolTipButton12);
        this.ToolTip1.SetToolTip((Control) this.Button13, Lang.ToolTipButton13);
        this.ToolTip1.SetToolTip((Control) this.Button14, Lang.ToolTipButton14);
        this.ToolTip1.SetToolTip((Control) this.Button15, Lang.ToolTipButton15);
        this.ToolTip1.SetToolTip((Control) this.Button16, Lang.ToolTipButton16);
        this.ToolTip1.SetToolTip((Control) this.Button17, Lang.ToolTipButton17);
        this.ToolTip1.SetToolTip((Control) this.Button18, Lang.ToolTipButton18);
        this.ToolTip1.SetToolTip((Control) this.Button19, Lang.ToolTipButton19);
        this.ToolTip1.SetToolTip((Control) this.Button20, Lang.ToolTipButton20);
        this.ToolTip1.SetToolTip((Control) this.Button21, Lang.ToolTipButton21);
        this.ToolTip1.SetToolTip((Control) this.Button22, Lang.ToolTipButton22);
        this.ToolTip1.SetToolTip((Control) this.Button24, Lang.ToolTipButton13);
        this.ToolTip1.SetToolTip((Control) this.Button25, Lang.ToolTipButton14);
        this.ToolTip1.SetToolTip((Control) this.Button26, Lang.ToolTipButton26);
        this.ToolTip1.SetToolTip((Control) this.Button27, Lang.ToolTipButton27);
        this.ToolTip1.SetToolTip((Control) this.Button28, Lang.ToolTipButton28);
        this.ToolTip1.SetToolTip((Control) this.Button29, Lang.ToolTipButton29);
        this.ToolTip1.SetToolTip((Control) this.Button30, Lang.ToolTipButton30);
        this.ToolTip1.SetToolTip((Control) this.Button31, Lang.ToolTipButton31);
        this.ToolTip1.SetToolTip((Control) this.Button32, Lang.ToolTipButton32);
        this.ToolTip1.SetToolTip((Control) this.ButtonOfficeScript, Lang.ToolTipButtonOfficeScript);
        this.ToolTip1.SetToolTip((Control) this.ComboBox1, Lang.ToolTipComboBox1);
        this.ToolTip1.SetToolTip((Control) this.ComboBox2, Lang.ToolTipComboBox2);
        this.ToolTip1.SetToolTip((Control) this.ComboBox3, Lang.ToolTipComboBox3);
        this.ToolTip1.SetToolTip((Control) this.NumericUpDown2, Lang.ToolTipComboBox4);
        this.ToolTip1.SetToolTip((Control) this.NumericUpDown3, Lang.ToolTipComboBox4);
        this.ToolTip1.SetToolTip((Control) this.NumericUpDown1, Lang.ToolTipComboBox5);
        this.ToolTip1.SetToolTip((Control) this.ComboBox6, Lang.ToolTipComboBox6);
        this.ToolTip1.SetToolTip((Control) this.TextBox1, Lang.ToolTipTextBox1);
        this.ToolTip1.SetToolTip((Control) this.TextBox2, Lang.ToolTipTextBox2);
        this.ToolTip1.SetToolTip((Control) this.CheckBox1, Lang.ToolTipCheckBox1);
        this.ToolTip1.SetToolTip((Control) this.ButtonValidator, Lang.ValidatorMessage);
        this.Initialization();
        this.CheckCmdline();
        this.InitializationEnd();
        this.Change_Windows_Version_Init();
      }
    }

    private void Initialization()
    {
      if (this._positionLeftTopStartProg)
      {
        this.Left = this._positionLeft;
        this.Top = this._positionTop;
        this._positionLeftTopStartProg = false;
      }
      this._meMovePosition = true;
      this.Show_HideProfessionalVersionInit();
      this.SysPathSet();
      Interaction.Shell("cmd /c echo test>>\"" + this.ApplicationStartupPathForDos + "\\test.test\"", AppWinStyle.Hide, true, -1);
      if (File.Exists(Application.StartupPath + "\\test.test"))
      {
        this._cdDvdRom = false;
        this.DelFile(this.ApplicationStartupPathForDos + "\\test.test");
      }
      else
        this._cdDvdRom = true;
      this.FileSetAttrib();
      this.ComboBox7.Items.Clear();
      this.ComboBox7.Items.AddRange(new object[3]
      {
        (object) Lang.ComboBox7Cols1,
        (object) Lang.ComboBox7Cols2,
        (object) Lang.ComboBox7Cols3
      });
      this.ComboBox7.Text = Lang.ComboBox7Cols1;
      this.ComboBoxLangs.Items.Clear();
      this.ComboBoxLangs.Items.AddRange(new object[6]
      {
        (object) Lang.TargetLangRu,
        (object) Lang.TargetLangEn,
        (object) Lang.TargetLangFr,
        (object) Lang.TargetLangEs,
        (object) Lang.TargetLangVi,
        (object) Lang.TargetLangUa
      });
      if (Operators.CompareString(this.TargetLang, "RU", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangRu;
      else if (Operators.CompareString(this.TargetLang, "EN", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangEn;
      else if (Operators.CompareString(this.TargetLang, "FR", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangFr;
      else if (Operators.CompareString(this.TargetLang, "ES", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangEs;
      else if (Operators.CompareString(this.TargetLang, "VI", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangVi;
      else if (Operators.CompareString(this.TargetLang, "UA", false) == 0)
        this.ComboBoxLangs.Text = Lang.TargetLangUa;
      this.InitCombo();
      this.Button28.Enabled = false;
      this.CheckBox1.Checked = this._delKmsServer;
      if (!this.Check_New_Windows_Version_9600())
      {
        this._modeHook = false;
      }
      else
      {
        MyProject.Forms.AutoMode.CheckBox5.Checked = false;
        MyProject.Forms.AutoMode.CheckBox5.Enabled = false;
      }
      if (this.SetKmsProgramData)
      {
        this.PathKmsService = this._systemdrive + "\\ProgramData\\KMSAuto";
      }
      else
      {
        this.PathKmsService = Application.StartupPath;
        this.DelDir(this._systemdrive + "\\ProgramData\\KMSAuto");
      }
      if (File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm"))
      {
        this.Button28.Enabled = true;
        this.CheckBoxAnalizer.Checked = true;
      }
      else
      {
        this.Button28.Enabled = false;
        this.CheckBoxAnalizer.Checked = false;
      }
      this.CheckBoxInstKey.Checked = this._instKey;
      this.EnableRadioButton();
      this.AutoModeListSet();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.SaveProgramSetting();
      if (File.Exists(Application.StartupPath + "\\KMS Log File.log"))
        this.DelFile(Application.StartupPath + "\\KMS Log File.log");
      if (!this.BackGroundRun && File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        this.DelFile(this.Tempdir + "\\MS_Office_updates_del.cmd");
      if (this._msActBackUpFlag)
        return;
      if (File.Exists(this.Tempdir + "\\MSActBackup.exe"))
        this.DelFile(this.Tempdir + "\\MSActBackup.exe");
      if (File.Exists(this.Tempdir + "\\MSActBackup.ini"))
        this.DelFile(this.Tempdir + "\\MSActBackup.ini");
      if (!File.Exists(this.Tempdir + "\\MSActBackUpPath.ini"))
        return;
      this.DelFile(this.Tempdir + "\\MSActBackUpPath.ini");
    }

    private void InitializationEnd()
    {
      if (!this._cmDlineExist)
      {
        this.Refresh();
        if (this._noLogo)
        {
          this.CheckBox3.Checked = false;
        }
        else
        {
          this.CheckBox3.Checked = true;
          this.Intro();
        }
        this.MyPrintLine("===== " + Lang.LabelHost + this._host + " " + Lang.LabelText5 + this._port + " =====");
        this.MyPrintLine(Lang.Hello + this.Username + ". " + Lang.InfoProg1);
        this.MyPrintLine(this._razdelitel);
        this.CheckKmsService();
        if (File.Exists(this._kmsServicePathLog))
        {
          this.Button27.Enabled = true;
          this.Button33.Enabled = true;
          this._logFile = true;
        }
        else
        {
          this.Button27.Enabled = false;
          this.Button33.Enabled = false;
          this.Button28.Enabled = false;
        }
        this.CheckBox5.Checked = this._sounds;
        if (this._addFunctions)
        {
          this.EnableAddSettings();
          this.CheckBox4.Checked = true;
        }
        else
          this.CheckBox4.Checked = false;
        if (this._currentParameters.LogMode)
        {
          this.CheckBoxLog.Checked = true;
          this._logFile = true;
        }
        else
          this.CheckBoxLog.Checked = false;
        if (this._currentParameters.LogModeIp)
        {
          this.CheckBoxIP.Checked = true;
          this._logFile = true;
        }
        if (File.Exists(Application.StartupPath + "\\" + Lang.LogFileLog))
          File.Delete(Application.StartupPath + "\\" + Lang.LogFileLog);
        if (this._professional)
          this.Button39.Text = Lang.NormalMode;
        else
          this.Button39.Text = Lang.ProfMode;
        this.ListKey();
        this.ShowTextBoxandButtonStatusBackupSystem();
        if (this._modeAuto)
        {
          this.ComboBox3.Text = this._autoHostText;
          this.ComboBox3.Enabled = false;
        }
        this.CheckWindowsVersion();
        switch (this.GenuineStateCheck())
        {
          case 0:
            this.MyPrintLine(Lang.SystemActivateNoProblemTxt);
            goto case 222;
          case 222:
            if (Operators.ConditionalCompareObjectEqual(this.CheckTask(), (object) 0, false))
            {
              if (File.Exists(this.SysPath + "\\Tasks\\KMSAutoNet"))
              {
                this.DelFile(this.Tempdir + "\\KMSAutoNet.tmp");
                Interaction.Shell(this.SysPath + "cmd.exe /c copy " + this.Windir + "\\system32\\Tasks\\KMSAutoNet \"" + this.Tempdir + "\\KMSAutoNet.tmp\" /Y", AppWinStyle.Hide, true, -1);
                string str = File.ReadAllText(this.Tempdir + "\\KMSAutoNet.tmp");
                this.DelFile(this.Tempdir + "\\KMSAutoNet.tmp");
                if (Strings.LCase(str).Contains("/win=act") & Strings.LCase(str).Contains("/off=act"))
                  this.ComboBox7.Text = Lang.ComboBox7Cols1;
                else if (Strings.LCase(str).Contains("/win=act"))
                  this.ComboBox7.Text = Lang.ComboBox7Cols2;
                else if (Strings.LCase(str).Contains("/off=act"))
                  this.ComboBox7.Text = Lang.ComboBox7Cols3;
              }
              this.Button29.Enabled = false;
              this.Button30.Enabled = true;
              this.Button31.Enabled = true;
              this.Scheduler = true;
              this.KMS_SchedulerFlagShow();
            }
            else
            {
              this.Button29.Enabled = true;
              this.Button30.Enabled = false;
              this.Button31.Enabled = false;
              this.Scheduler = false;
              this.KMS_SchedulerFlagShow();
              this.DelDir(this._systemdrive + "\\ProgramData\\KMSAutoS");
            }
            if (!this._modeAuto & !this._modeAutoNo & !this._modeHook & !this.ModeTap & !this._modeWd)
            {
              this._modeAuto = true;
              this.RB1AUTO.Checked = true;
            }
            if (this.SetKmsProgramData)
              this.DelDir(Application.StartupPath + "\\bin");
            if (this._showReadmeView)
            {
              this.ShowReadme();
              this._showReadmeView = false;
            }
            this.ButtonVideo.Hide();
            this.ButtonVideoSearch.Hide();
            break;
          default:
            this.MyPrintLine(Lang.SystemActivateProblemTxt);
            goto case 222;
        }
      }
      if (Operators.CompareString(this._winVersion, "Windows 7 Ultimate", false) == 0)
      {
        this._disableActivateSystemButton = true;
        this.Button3.Enabled = false;
      }
      this.AIUpDown();
      this.RIUpDown();
      if (this._addFunctions)
      {
        this.Button8.Hide();
        this.Button10.Show();
      }
      else
      {
        this.Button8.Show();
        this.Button10.Hide();
      }
      this.LoadingProgramm = false;
    }

    private void AutoModeListSet()
    {
      string[] strArray = new string[1];
      this.AutoModeList = new string[0];
      if (MyProject.Forms.AutoMode.CheckBox5.Checked)
      {
        strArray[0] = "localhost";
        this.AutoModeList = ((IEnumerable<string>) this.AutoModeList).Concat<string>((IEnumerable<string>) strArray).ToArray<string>();
      }
      if (MyProject.Forms.AutoMode.CheckBox3.Checked)
      {
        strArray[0] = "windivert";
        this.AutoModeList = ((IEnumerable<string>) this.AutoModeList).Concat<string>((IEnumerable<string>) strArray).ToArray<string>();
      }
      if (MyProject.Forms.AutoMode.CheckBox2.Checked & this.RB5Hook.Enabled)
      {
        strArray[0] = "hook";
        this.AutoModeList = ((IEnumerable<string>) this.AutoModeList).Concat<string>((IEnumerable<string>) strArray).ToArray<string>();
      }
      if (!MyProject.Forms.AutoMode.CheckBox4.Checked)
        return;
      strArray[0] = "tap";
      this.AutoModeList = ((IEnumerable<string>) this.AutoModeList).Concat<string>((IEnumerable<string>) strArray).ToArray<string>();
    }

    private bool CheckAmpersand()
    {
      bool flag = false;
      if (Application.ExecutablePath.Contains("&"))
      {
        int num = (int) MessageBox.Show(Lang.AmpersandTxt, Lang.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = true;
      }
      return flag;
    }

    private void SysPathSet()
    {
      string Left = "";
      if (File.Exists(this._systemroot + "\\Sysnative\\cmd.exe"))
      {
        string[] systemFileCheck = this._systemFileCheck;
        int index = 0;
        while (index < systemFileCheck.Length)
        {
          string str = systemFileCheck[index];
          if (!File.Exists(this._systemroot + "\\Sysnative\\" + str))
            Left = Left + "\r\n" + str;
          checked { ++index; }
        }
        if (Operators.CompareString(Left, "", false) == 0)
        {
          this.SysPath = this._systemroot + "\\Sysnative\\";
          this._sysPath2 = this._systemroot + "\\Sysnative";
        }
        else
        {
          this.SysPath = this._systemroot + "\\System32\\";
          this._sysPath2 = this._systemroot + "\\System32";
          int num = (int) MessageBox.Show(Lang.NoValidSystemTxt + Left + ". \r\n" + Lang.NoValidSystemTxt2, Lang.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else if (File.Exists(this._systemroot + "\\System32\\cmd.exe"))
      {
        string[] systemFileCheck = this._systemFileCheck;
        int index = 0;
        while (index < systemFileCheck.Length)
        {
          string str = systemFileCheck[index];
          if (!File.Exists(this._systemroot + "\\System32\\" + str))
            Left = Left + "\r\n" + str;
          checked { ++index; }
        }
        if (Operators.CompareString(Left, "", false) == 0)
        {
          this.SysPath = this._systemroot + "\\System32\\";
          this._sysPath2 = this._systemroot + "\\System32";
        }
        else
        {
          this.SysPath = this._systemroot + "\\System32\\";
          this._sysPath2 = this._systemroot + "\\System32";
          int num = (int) MessageBox.Show(Lang.NoValidSystemTxt + Left + ". \r\n" + Lang.NoValidSystemTxt2, Lang.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      int Start = 1;
      while (true)
      {
        int startIndex = Strings.InStr(Start, this.ApplicationStartupPathForPlan, "&", CompareMethod.Binary);
        if (startIndex != 0)
        {
          this.ApplicationStartupPathForPlan = this.ApplicationStartupPathForPlan.Insert(startIndex, "amp;");
          Start = checked (startIndex + 5);
        }
        else
          break;
      }
      this.ApplicationStartupPathForDos = Application.StartupPath;
    }

    public void MyPrintLine(string a)
    {
      if (this._myPrintLineNoPrint)
        return;
      if (Operators.CompareString(a, Lang.WmiaApActSuccessful, false) == 0)
      {
        this.ActSuccessful();
      }
      else
      {
        if (this._saveToFileLog)
        {
          StreamWriter streamWriter = new StreamWriter(!this._cdDvdRom ? Application.StartupPath + "\\ActStatus.log" : this._userprofile + "\\Desktop\\ActStatus.log", true, Encoding.GetEncoding("utf-16"));
          streamWriter.Write(a + "\r\n");
          streamWriter.Close();
        }
        if (Operators.CompareString(a, "clear", false) == 0)
        {
          this._textBuffer = "";
          a = "";
          this.TextBox1.Text = this._textBuffer;
          this.TextBox1.Refresh();
        }
        else
        {
          this.TextBox1.AppendText(a + "\r\n");
          this.TextBox1.Refresh();
        }
      }
    }

    private void CmdWinActivate()
    {
      while (true)
      {
        do
        {
          if (this._modeAuto)
            this._ModeAutoSetupSettings(true);
          if (this.ModeTap)
          {
            if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsSetAndExtractFolder();
            this.InstallTap();
            Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
          }
          else if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsSetAndExtractFolder();
          if (this._modeWd)
            this.InstallDivert();
          if (this._modeHook)
            this.InstallHook();
          int num;
          int successful;
          if (this._delKmsServer)
          {
            WmIfunctions.ClearProductKmsParameters((byte) 1);
            WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
            num = WmIfunctions.ActivateProduct((byte) 1);
            successful = WmIfunctions.WindowsOperationCounters.Successful;
            WmIfunctions.ClearGlobalKmsParameters();
          }
          else
          {
            WmIfunctions.ClearProductKmsParameters((byte) 1);
            WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
            num = WmIfunctions.ActivateProduct((byte) 1);
            successful = WmIfunctions.WindowsOperationCounters.Successful;
          }
          if (this._modeWd)
            this.UninstallDivert();
          if (this._modeHook)
            this.UnInstallHook();
          if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsDelAndDelFolder();
          if (this._modeAuto)
            this.UnInstallTap();
          if (successful < 1 | (uint) num > 0U)
          {
            if (this._modeWd)
              this.UninstallDivert();
            if (!this._ModeAutoSetupSettings(false))
              goto label_29;
          }
          else
            goto label_29;
        }
        while (Operators.CompareString(this.KmsFlag, "KMS", false) == 0);
        this.KmsDelAndDelFolder();
      }
label_29:
      this._countActivations = 0;
    }

    private void CmdOffActivate()
    {
      while (true)
      {
        do
        {
          if (this._modeAuto)
            this._ModeAutoSetupSettings(true);
          if (this.ModeTap)
          {
            if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsSetAndExtractFolder();
            this.InstallTap();
            Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
          }
          else if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsSetAndExtractFolder();
          if (this._modeWd)
            this.InstallDivert();
          if (this._modeHook)
            this.InstallHook();
          int num;
          int successful;
          if (this._delKmsServer)
          {
            WmIfunctions.ClearProductKmsParameters((byte) 6);
            WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
            num = WmIfunctions.ActivateProduct((byte) 6);
            successful = WmIfunctions.OfficeOperationCounters.Successful;
            WmIfunctions.ClearGlobalKmsParameters();
          }
          else
          {
            WmIfunctions.ClearProductKmsParameters((byte) 6);
            WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
            num = WmIfunctions.ActivateProduct((byte) 6);
            successful = WmIfunctions.OfficeOperationCounters.Successful;
          }
          if (this._modeWd)
            this.UninstallDivert();
          if (this._modeHook)
            this.UnInstallHook();
          if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsDelAndDelFolder();
          if (this._modeAuto)
            this.UnInstallTap();
          if (!(successful < 1 | (uint) num > 0U) || !this._ModeAutoSetupSettings(false))
            goto label_26;
        }
        while (Operators.CompareString(this.KmsFlag, "KMS", false) == 0);
        this.KmsDelAndDelFolder();
      }
label_26:
      this._countActivations = 0;
    }

    private object CheckTask()
    {
      object obj = (object) 0;
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\TaskCache\\Tree\\KMSAutoNet", false);
      try
      {
        Conversions.ToString(registryKey2.GetValue("Id"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) (int) byte.MaxValue;
        ProjectData.ClearProjectError();
      }
      registryKey1.Close();
      return obj;
    }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
      this.Move += new EventHandler(this.Me_Move);
      this._systemFileCheck = new string[12]
      {
        "cmd.exe",
        "reg.exe",
        "cscript.exe",
        "mode.com",
        "schtasks.exe",
        "timeout.exe",
        "control.exe",
        "net.exe",
        "sc.exe",
        "notepad.exe",
        "xcopy.exe",
        "slwga.dll"
      };
      this.TaskList = new string[22]
      {
        "Microsoft\\Windows\\Application Experience\\AitAgent",
        "Microsoft\\Windows\\Application Experience\\ProgramDataUpdater",
        "Microsoft\\Windows\\Application Experience\\StartupAppTask",
        "Microsoft\\Windows\\Application Experience\\Microsoft Compatibility Appraiser",
        "Microsoft\\Windows\\Autochk\\Proxy",
        "Microsoft\\Windows\\Customer Experience Improvement Program\\KernelCeipTask",
        "Microsoft\\Windows\\Customer Experience Improvement Program\\UsbCeip",
        "Microsoft\\Windows\\Customer Experience Improvement Program\\BthSQM",
        "Microsoft\\Windows\\Customer Experience Improvement Program\\Consolidator",
        "Microsoft\\Windows\\Customer Experience Improvement Program\\HypervisorFlightingTask",
        "Microsoft\\Windows\\DiskDiagnostic\\Microsoft-Windows-DiskDiagnosticDataCollector",
        "Microsoft\\Windows\\NetTrace\\GatherNetworkInfo",
        "Microsoft\\Windows\\Power Efficiency Diagnostics\\AnalyzeSystem",
        "Microsoft\\Windows\\Shell\\FamilySafetyMonitor",
        "Microsoft\\Windows\\Shell\\FamilySafetyRefresh",
        "Microsoft Office 15 Sync Maintenance for %COMPUTERNAME%-%USERNAME% %COMPUTERNAME%",
        "Microsoft\\Office\\Office 15 Subscription Heartbeat",
        "Microsoft\\Office\\OfficeTelemetryAgentFallBack",
        "Microsoft\\Office\\OfficeTelemetryAgentLogOn",
        "\\Microsoft\\Office\\Office ClickToRun Service Monitor",
        "\\Microsoft\\Office\\OfficeTelemetryAgentFallBack2016",
        "\\Microsoft\\Office\\OfficeTelemetryAgentLogOn2016"
      };
      this._kmsAutoFileList = new string[7]
      {
        "\\kmsauto.ini",
        "xmlfile.xml",
        "\\bin\\KMSSS.exe",
        "\\pdk.dll",
        "TunMirror.exe",
        "\\bin\\KMSSS.log",
        "TunMirror2.exe"
      };
      this.string_0 = new string[5, 2]
      {
        {
          "Windows 7 Home Basic",
          "HomeBasic"
        },
        {
          "Windows 7 Home Premium",
          "HomePremium"
        },
        {
          "Windows 7 Enterprise",
          "Enterprise"
        },
        {
          "Windows 7 Professional",
          "Professional"
        },
        {
          "Windows 7 Ultimate",
          "Ultimate"
        }
      };
      this._productList8ForChengeOs = new string[20, 2]
      {
        {
          "Windows 8",
          "Core"
        },
        {
          "Windows 8 Pro",
          "Professional"
        },
        {
          "Windows 8 Enterprise",
          "Enterprise"
        },
        {
          "Windows 8.1 Single Language",
          "CoreSingleLanguage"
        },
        {
          "Windows 8.1",
          "Core"
        },
        {
          "Windows 8.1 N",
          "CoreN"
        },
        {
          "Windows 8.1 Pro",
          "Professional"
        },
        {
          "Windows 8.1 Pro N",
          "ProfessionalN"
        },
        {
          "Windows 8.1 Pro with Media Center",
          "ProfessionalWMC"
        },
        {
          "Windows 8.1 Enterprise",
          "Enterprise"
        },
        {
          "Windows 8.1 Enterprise N",
          "EnterpriseN"
        },
        {
          "Windows 10 Home Single Language",
          "CoreSingleLanguage"
        },
        {
          "Windows 10 Home",
          "Core"
        },
        {
          "Windows 10 Pro",
          "Professional"
        },
        {
          "Windows 10 Pro N",
          "ProfessionalN"
        },
        {
          "Windows 10 Enterprise N",
          "EnterpriseN"
        },
        {
          "Windows 10 Enterprise",
          "Enterprise"
        },
        {
          "Windows 10 Education",
          "Education"
        },
        {
          "Windows 10 Education N",
          "EducationN"
        },
        {
          "Windows 10 Enterprise 2015 LTSB",
          "EnterpriseS"
        }
      };
      this._productListWindowsOffice = new string[137, 2]
      {
        {
          "=== Windows, " + Lang.Yourkey + " ===",
          ""
        },
        {
          "=== Office, " + Lang.Yourkey + " ===",
          ""
        },
        {
          "=========== Windows Vista ===========",
          ""
        },
        {
          "Windows Vista Business",
          "YFKBB-PQJJV-G996G-VWGXY-2V3X8"
        },
        {
          "Windows Vista Business N",
          "HMBQG-8H2RH-C77VX-27R82-VMQBT"
        },
        {
          "Windows Vista Enterprise",
          "VKK3X-68KWM-X2YGT-QR4M6-4BWMV"
        },
        {
          "Windows Vista Enterprise N",
          "VTC42-BM838-43QHV-84HX6-XJXKV"
        },
        {
          "============ Windows 7 ============",
          ""
        },
        {
          "Windows Embedded POSREady 7",
          "YBYF6-BHCR3-JPKRB-CDW7B-F9BK4"
        },
        {
          "Windows Embedded Standard 7",
          "XGY72-BRBBT-FF8MH-2GG8H-W7KCW"
        },
        {
          "Windows Thin PC Embedded 7",
          "73KQT-CD9G6-K7TQG-66MRP-CQ22C"
        },
        {
          "Windows 7 Professional",
          "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4"
        },
        {
          "Windows 7 Professional N",
          "MRPKT-YTG23-K7D7T-X2JMM-QY7MG"
        },
        {
          "Windows 7 Professional E",
          "W82YF-2Q76Y-63HXB-FGJG9-GF7QX"
        },
        {
          "Windows 7 Enterprise",
          "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH"
        },
        {
          "Windows 7 Enterprise N",
          "YDRBP-3D83W-TY26F-D46B2-XCKRJ"
        },
        {
          "Windows 7 Enterprise E",
          "C29WB-22CC8-VJ326-GHFJW-H9DH4"
        },
        {
          "============ Windows 8 ============",
          ""
        },
        {
          "Windows Embedded Industry 8 Professional",
          "RYXVT-BNQG7-VD29F-DBMRY-HT73M"
        },
        {
          "Windows Embedded Industry 8 Enterprise",
          "NKB3R-R2F8T-3XCDP-7Q2KW-XWYQ2"
        },
        {
          "Windows 8 Core",
          "BN3D2-R7TKB-3YPBD-8DRP2-27GG4"
        },
        {
          "Windows 8 Core Single Language",
          "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ"
        },
        {
          "Windows 8 Professional",
          "NG4HW-VH26C-733KW-K6F98-J8CK4"
        },
        {
          "Windows 8 Professional N",
          "XCVCF-2NXM9-723PB-MHCB7-2RYQQ"
        },
        {
          "Windows 8 Professional WMC",
          "GNBB8-YVD74-QJHX6-27H4K-8QHDG"
        },
        {
          "Windows 8 Enterprise",
          "32JNW-9KQ84-P47T8-D8GGY-CWCK7"
        },
        {
          "Windows 8 Enterprise N",
          "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT"
        },
        {
          "=========== Windows 8.1 ===========",
          ""
        },
        {
          "Windows 8.1 Embedded Industry Pro",
          "NMMPB-38DD4-R2823-62W8D-VXKJB"
        },
        {
          "Windows 8.1 EmbeddedIndustryA",
          "VHXM3-NR6FT-RY6RT-CK882-KW2CJ"
        },
        {
          "Windows 8.1 Embedded Industry Enterprise",
          "FNFKF-PWTVT-9RC8H-32HB2-JB34X"
        },
        {
          "Windows 8.1 Core",
          "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        },
        {
          "Windows 8.1 CoreN",
          "7B9N3-D94CG-YTVHR-QBPX3-RJP64"
        },
        {
          "Windows 8.1 CoreSingleLanguage",
          "BB6NG-PQ82V-VRDPW-8XVD2-V8P66"
        },
        {
          "Windows 8.1 Pro",
          "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        },
        {
          "Windows 8.1 Enterprise",
          "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        },
        {
          "Windows 8.1 ProfessionalN",
          "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY"
        },
        {
          "Windows 8.1 EnterpriseN",
          "TT4HM-HN7YT-62K67-RGRQJ-JFFXW"
        },
        {
          "Windows 8.1 Pro with Media Center",
          "789NJ-TQK6T-6XTH8-J39CJ-J8D3P"
        },
        {
          "Windows 8.1 Core Preview",
          "MPWP3-DXNP9-BRD79-W8WFP-3YFJ6"
        },
        {
          "Windows 8.1 Pro Preview",
          "MTWNQ-CKDHJ-3HXW9-Q2PFX-WB2HQ"
        },
        {
          "Windows 8.1 Pro Preview with Media Center",
          "MY4N9-TGH34-4X4VY-8FG2T-RRDPV"
        },
        {
          "Windows 8.1 Enterprise Preview",
          "2MP7K-98NK8-WPVF3-Q2WDG-VMD98"
        },
        {
          "Windows 8.1 Core Connected",
          "3PY8R-QHNP9-W7XQD-G6DPH-3J2C9"
        },
        {
          "Windows 8.1 Connected Single Language",
          "9NYGF-X9VP2-Q7MYB-QH9MB-TXWQY"
        },
        {
          "Windows 8.1 Connected for Education",
          "MX3RK-9HNGX-K3QKC-6PJ3F-W8D7B"
        },
        {
          "============ Windows 10 ============",
          ""
        },
        {
          "Windows 10 Technical Preview for Consumer",
          "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        },
        {
          "Windows 10 Pro Technical Preview",
          "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        },
        {
          "Windows 10 Enterprise Technical Preview",
          "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        },
        {
          "Windows 10 Home",
          "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"
        },
        {
          "Windows 10 Home N",
          "3KHY7-WNT83-DGQKR-F7HPR-844BM"
        },
        {
          "Windows 10 Home Single Language",
          "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"
        },
        {
          "Windows 10 Home Country Specific",
          "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR"
        },
        {
          "Windows 10 Pro",
          "W269N-WFGWX-YVC9B-4J6C9-T83GX"
        },
        {
          "Windows 10 Pro N",
          "MH37W-N47XK-V7XM9-C7227-GCQG9"
        },
        {
          "Windows 10 Education",
          "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
        },
        {
          "Windows 10 Education N",
          "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
        },
        {
          "Windows 10 Enterprise",
          "NPPR9-FWDCX-D2C8J-H872K-2YT43"
        },
        {
          "Windows 10 Enterprise N",
          "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
        },
        {
          "Windows 10 Enterprise 2015 LTSB",
          "WNMTR-4C88C-JK8YV-HQ7T2-76DF9"
        },
        {
          "Windows 10 Enterprise 2015 LTSB N",
          "2F77B-TNFGY-69QQF-B8YKP-D69TJ"
        },
        {
          "========== Windows Server ==========",
          ""
        },
        {
          "Server 2008 Web",
          "WYR28-R7TFJ-3X2YQ-YCY4H-M249D"
        },
        {
          "Server 2008 Standard",
          "TM24T-X9RMF-VWXK6-X8JC9-BFGM2"
        },
        {
          "Server 2008 Enterprise",
          "YQGMW-MPWTJ-34KDK-48M3W-X4Q6V"
        },
        {
          "Server 2008 HPC",
          "RCTX3-KWVHP-BR6TB-RB6DM-6X7HP"
        },
        {
          "Server 2008 Datacenter",
          "7M67G-PC374-GR742-YH8V4-TCBY3"
        },
        {
          "Server 2008 R2 Web",
          "6TPJF-RBVHG-WBW2R-86QPH-6RTM4"
        },
        {
          "Server 2008 R2 HPC Edition",
          "TT8MH-CG224-D3D7Q-498W2-9QCTX"
        },
        {
          "Server 2008 R2 Standard",
          "YC6KT-GKW9T-YTKYR-T4X34-R7VHC"
        },
        {
          "Server 2008 R2 Enterprise",
          "489J6-VHDMP-X63PK-3K798-CPX3Y"
        },
        {
          "Server 2008 R2 Datacenter",
          "74YFP-3QFB3-KQT8W-PMXWJ-7M648"
        },
        {
          "Server 2012 Core",
          "BN3D2-R7TKB-3YPBD-8DRP2-27GG4"
        },
        {
          "Server 2012 Core N",
          "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY"
        },
        {
          "Server 2012 Core Single Language",
          "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ"
        },
        {
          "Server 2012 Core Country Specific",
          "4K36P-JN4VD-GDC6V-KDT89-DYFKP"
        },
        {
          "Server 2012 Standard",
          "XC9B7-NBPP2-83J2H-RHMBY-92BT4"
        },
        {
          "Server 2012 Standard Core",
          "XC9B7-NBPP2-83J2H-RHMBY-92BT4"
        },
        {
          "Server 2012 Datacenter",
          "48HP8-DN98B-MYWDG-T2DCC-8W83P"
        },
        {
          "Server 2012 Datacenter Core",
          "48HP8-DN98B-MYWDG-T2DCC-8W83P"
        },
        {
          "Server 2012 Datacenter Evaluation",
          "48HP8-DN98B-MYWDG-T2DCC-8W83P"
        },
        {
          "Server 2012 MultiPoint Standard",
          "HM7DN-YVMH3-46JC3-XYTG7-CYQJJ"
        },
        {
          "Server 2012 MultiPoint Premium",
          "XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G"
        },
        {
          "Server 2012 R2 Standard Preview",
          "YNBF9-GPVTG-FFHQC-MJR4B-B4CQX"
        },
        {
          "Server 2012 R2 Datacenter Preview",
          "VRDD2-NVGDP-K7QG8-69BR4-TVFHB"
        },
        {
          "Server 2012 R2 Standard",
          "D2N9P-3P6X9-2R39C-7RTCD-MDVJX"
        },
        {
          "Server 2012 R2 Datacenter",
          "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9"
        },
        {
          "Server 2012 R2 Essentials",
          "KNC87-3J2TX-XB4WP-VCPJV-M4FWM"
        },
        {
          "============ Office 2010 ============",
          ""
        },
        {
          "Office 2010 Standard",
          "V7QKV-4XVVR-XYV4D-F7DFM-8R6BM"
        },
        {
          "Office 2010 Professional Plus",
          "VYBBJ-TRJPB-QFQRF-QFT4D-H3GVB"
        },
        {
          "Office 2010 Small Business Basics",
          "D6QFG-VBYP2-XQHM7-J97RH-VVRCK"
        },
        {
          "Access 2010",
          "V7Y44-9T38C-R2VJK-666HK-T7DDX"
        },
        {
          "InfoPath 2010",
          "K96W8-67RPQ-62T9Y-J8FQJ-BT37T"
        },
        {
          "OneNote 2010",
          "Q4Y4M-RHWJM-PY37F-MTKWH-D3XHX"
        },
        {
          "Outlook 2010",
          "7YDC2-CWM8M-RRTJC-8MDVC-X3DWQ"
        },
        {
          "PowerPoint 2010",
          "RC8FX-88JRY-3PF7C-X8P67-P4VTT"
        },
        {
          "Project 2010 Standard",
          "4HP3K-88W3F-W2K3D-6677X-F9PGB"
        },
        {
          "Project 2010 Professional",
          "YGX6F-PGV49-PGW3J-9BTGG-VHKC6"
        },
        {
          "Publisher 2010",
          "BFK7F-9MYHM-V68C7-DRQ66-83YTP"
        },
        {
          "SharePoint Workspace (Groove) 2010",
          "QYYW6-QP4CB-MBV6G-HYMCJ-4T3J4"
        },
        {
          "Visio 2010 Standard",
          "767HD-QGMWX-8QTDB-9G3R2-KHFGJ"
        },
        {
          "Visio 2010 Professional",
          "7MCW8-VRQVK-G677T-PDJCM-Q8TCP"
        },
        {
          "Visio 2010 Premium",
          "D9DWC-HPYVV-JGF4P-BTWQB-WX8BJ"
        },
        {
          "Word 2010",
          "HVHB3-C6FV7-KQX9W-YQG79-CRY7T"
        },
        {
          "Excel 2010",
          "H62QG-HXVKF-PP4HP-66KMR-CW9BM"
        },
        {
          "============ Office 2013 ============",
          ""
        },
        {
          "Office 2013 Standard",
          "KBKQT-2NMXY-JJWGP-M62JB-92CD4"
        },
        {
          "Office 2013 Professional Plus",
          "YC7DK-G2NP3-2QQC3-J6H88-GVGXT"
        },
        {
          "Access 2013",
          "NG2JY-H4JBT-HQXYP-78QH9-4JM2D"
        },
        {
          "Excel 2013",
          "VGPNG-Y7HQW-9RHP7-TKPV3-BG7GB"
        },
        {
          "InfoPath 2013",
          "DKT8B-N7VXH-D963P-Q4PHY-F8894"
        },
        {
          "Lync 2013",
          "2MG3G-3BNTT-3MFW9-KDQW3-TCK7R"
        },
        {
          "OneNote 2013",
          "TGN6P-8MMBC-37P2F-XHXXK-P34VW"
        },
        {
          "Outlook 2013",
          "QPN8Q-BJBTJ-334K3-93TGY-2PMBT"
        },
        {
          "PowerPoint 2013",
          "4NT99-8RJFH-Q2VDH-KYG2C-4RD4F"
        },
        {
          "Project 2013 Standard",
          "6NTH3-CW976-3G3Y2-JK3TX-8QHTT"
        },
        {
          "Project 2013 Professional",
          "FN8TT-7WMH6-2D4X9-M337T-2342K"
        },
        {
          "Publisher 2013",
          "PN2WF-29XG2-T9HJ7-JQPJR-FCXK4"
        },
        {
          "Visio 2013 Standard",
          "J484Y-4NKBF-W2HMG-DBMJC-PGWR7"
        },
        {
          "Visio 2013 Professional",
          "C2FG9-N6J68-H8BTJ-BW3QX-RM3B3"
        },
        {
          "Word 2013",
          "6Q7VD-NX8JD-WJ2VH-88V73-4GBJ7"
        },
        {
          "============ Office 2016 ============",
          ""
        },
        {
          "Office 2016 Standard",
          "JNRGM-WHDWX-FJJG3-K47QV-DRTFM"
        },
        {
          "Office 2016 Project Standard",
          "GNFHQ-F6YQM-KQDGJ-327XX-KQBVC"
        },
        {
          "Office 2016 Visio Standard",
          "7WHWN-4T7MP-G96JF-G33KR-W8GF4"
        },
        {
          "Office 2016 Professional Plus",
          "XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99"
        },
        {
          "Office 2016 Project Professional",
          "YG9NW-3K39V-2T3HJ-93F3Q-G83KT"
        },
        {
          "Office 2016 Visio Professional",
          "PD3PC-RHNGV-FXJ29-8JK7D-RJRJK"
        },
        {
          "Office 2016 Word",
          "WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6"
        },
        {
          "Office 2016 Excel",
          "9C2PK-NWTVB-JMPW8-BFT28-7FTBF"
        },
        {
          "Office 2016 Access",
          "GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW"
        },
        {
          "Office 2016 OneNote",
          "DR92N-9HTF2-97XKM-XW2WJ-XW3J6"
        },
        {
          "Office 2016 Outlook",
          "R69KK-NTPKF-7M3Q4-QYBHW-6MT9B"
        },
        {
          "Office 2016 PowerPoint",
          "J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6"
        },_productListNewOsInstallGvlkKey
        {
          "Office 2016 Publisher",
          "F47MM-N3XJP-TQXJ9-BP99D-8K837"
        }
      };
      this._productListNewOsInstallGvlkKey = new string[46, 2]
      {
        {
          "Windows 8 Single Language",
          "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ"
        },
        {
          "Windows 8.1",
          "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        },
        {
          "Windows 8.1 Pro Preview",
          "MTWNQ-CKDHJ-3HXW9-Q2PFX-WB2HQ"
        },
        {
          "Windows 8.1 Connected",
          "3PY8R-QHNP9-W7XQD-G6DPH-3J2C9"
        },
        {
          "Windows 8.1 Connected Single Language",
          "9NYGF-X9VP2-Q7MYB-QH9MB-TXWQY"
        },
        {
          "Windows 8.1 Connected for Education",
          "MX3RK-9HNGX-K3QKC-6PJ3F-W8D7B"
        },
        {
          "Windows 8.1 Enterprise Preview",
          "2MP7K-98NK8-WPVF3-Q2WDG-VMD98"
        },
        {
          "Windows 8.1 Pro Preview with Media Center",
          "MY4N9-TGH34-4X4VY-8FG2T-RRDPV"
        },
        {
          "Windows 8.1 Pro with Media Center",
          "789NJ-TQK6T-6XTH8-J39CJ-J8D3P"
        },
        {
          "Windows 8.1 N",
          "7B9N3-D94CG-YTVHR-QBPX3-RJP64"
        },
        {
          "Windows 8.1 CoreN",
          "7B9N3-D94CG-YTVHR-QBPX3-RJP64"
        },
        {
          "Windows 8.1 Core N",
          "7B9N3-D94CG-YTVHR-QBPX3-RJP64"
        },
        {
          "Windows 8.1 Single Language",
          "BB6NG-PQ82V-VRDPW-8XVD2-V8P66"
        },
        {
          "Windows 8.1 Pro N",
          "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY"
        },
        {
          "Windows 8.1 EnterpriseN",
          "TT4HM-HN7YT-62K67-RGRQJ-JFFXW"
        },
        {
          "Windows 8.1 Enterprise N",
          "TT4HM-HN7YT-62K67-RGRQJ-JFFXW"
        },
        {
          "Windows 8.1 EmbeddedIndustry",
          "NMMPB-38DD4-R2823-62W8D-VXKJB"
        },
        {
          "Windows Embedded 8.1 Industry Pro",
          "NMMPB-38DD4-R2823-62W8D-VXKJB"
        },
        {
          "Windows Embedded 8.1 Industry Enterprise",
          "FNFKF-PWTVT-9RC8H-32HB2-JB34X"
        },
        {
          "Windows Embedded 8.1 Industry A",
          "VHXM3-NR6FT-RY6RT-CK882-KW2CJ"
        },
        {
          "Windows 8.1 EmbeddedIndustryE",
          "FNFKF-PWTVT-9RC8H-32HB2-JB34X"
        },
        {
          "Windows 8.1 Pro",
          "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        },
        {
          "Windows 8.1 Enterprise",
          "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        },
        {
          "Windows Server 2012 R2 Standard Preview",
          "YNBF9-GPVTG-FFHQC-MJR4B-B4CQX"
        },
        {
          "Windows Server 2012 R2 Datacenter Preview",
          "VRDD2-NVGDP-K7QG8-69BR4-TVFHB"
        },
        {
          "Windows Server 2012 R2 Standard",
          "D2N9P-3P6X9-2R39C-7RTCD-MDVJX"
        },
        {
          "Windows Server 2012 R2 Datacenter",
          "W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9"
        },
        {
          "Windows Server 2012 R2 Essentials",
          "KNC87-3J2TX-XB4WP-VCPJV-M4FWM"
        },
        {
          "Windows Technical Preview",
          "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        },
        {
          "Windows Technical Preview for Consumer",
          "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        },
        {
          "Windows Technical Preview for Enterprise",
          "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        },
        {
          "Windows 10 Pro Technical Preview",
          "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        },
        {
          "Windows 10 Technical Preview",
          "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        },
        {
          "Windows 10 Enterprise Technical Preview",
          "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        },
        {
          "Windows 10 Home",
          "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"
        },
        {
          "Windows 10 Pro",
          "W269N-WFGWX-YVC9B-4J6C9-T83GX"
        },
        {
          "Windows 10 Home Single Language",
          "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"
        },
        {
          "Windows 10 Enterprise",
          "NPPR9-FWDCX-D2C8J-H872K-2YT43"
        },
        {
          "Windows 10 Home Country Specific",
          "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR"
        },
        {
          "Windows 10 Pro N",
          "MH37W-N47XK-V7XM9-C7227-GCQG9"
        },
        {
          "Windows 10 Education",
          "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
        },
        {
          "Windows 10 Education N",
          "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
        },
        {
          "Windows 10 Enterprise N",
          "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
        },
        {
          "Windows 10 Enterprise 2015 LTSB",
          "WNMTR-4C88C-JK8YV-HQ7T2-76DF9"
        },
        {
          "Windows 10 Enterprise 2015 LTSB N",
          "2F77B-TNFGY-69QQF-B8YKP-D69TJ"
        },
        {
          "Windows 10 Pro Insider Preview",
          "W269N-WFGWX-YVC9B-4J6C9-T83GX"
        }
      };
      this.BackGroundRun = false;
      this.LoadingError = true;
      this.TargetLang = "";
      this._positionLeft = 200;
      this._positionTop = 200;
      this._positionLeftTmp = 200;
      this._positionTopTmp = 200;
      this._meMovePosition = false;
      this.Tempdir = Interaction.Environ("TEMP");
      this.Windir = Interaction.Environ("WINDIR");
      this._systemroot = Interaction.Environ("SYSTEMROOT");
      this.Username = Interaction.Environ("USERNAME");
      this.Computername = Interaction.Environ("COMPUTERNAME");
      this._systemdrive = Interaction.Environ("SYSTEMDRIVE");
      this._programdata = Interaction.Environ("PROGRAMDATA");
      this._programdataKmsauto = Interaction.Environ("PROGRAMDATA") + "\\KMSAuto";
      this._userprofile = Interaction.Environ("USERPROFILE");
      this._localappdata = Interaction.Environ("LOCALAPPDATA") + "\\MSfree Inc";
      this._host = "10.3.0.222";
      this._winPid = "";
      this._off2013Pid = "";
      this._off2010Pid = "";
      this._hwid = "";
      this._port = "1688";
      this._sai = "";
      this._sri = "";
      this.SysPath = "";
      this._sysPath2 = "";
      this._officePath = "";
      this._textBuffer = "";
      this.KmsFlag = "";
      this._args = "";
      this._argsFlag = false;
      this.Scheduler = false;
      this._razdelitel = "                                       ==========================";
      this._razdelitel2 = "      ===========================";
      this._saveToFileLog = false;
      this._addFunctions = false;
      this._noLogo = false;
      this._professional = false;
      this._logFile = false;
      this._logFileIp = false;
      this._index1 = 0;
      this._index2 = 0;
      this._index3 = 0;
      this._index4 = 0;
      this._index5 = 0;
      this._index6 = 0;
      this._index7 = 0;
      this._cmDlineExist = false;
      this._windowsBackupKey = new string[5]
      {
        "",
        "",
        "",
        "",
        ""
      };
      this._officeBackupKey = new string[5]
      {
        "",
        "",
        "",
        "",
        ""
      };
      this._windowsBackupKey2 = new string[5]
      {
        "",
        "",
        "",
        "",
        ""
      };
      this._officeBackupKey2 = new string[5]
      {
        "",
        "",
        "",
        "",
        ""
      };
      this.ProductNameWin = "";
      this.OwnKeyInstallNoDialog = false;
      this.OwnKeyInstallNoDialogMyKey = false;
      this.OwnKeyInstallYesDialog = false;
      this.OwnKeyInstallYesDialogProductName = "";
      this.OwnKeyInstallNoDialogKey = "";
      this.OwnKeyInstallKey = 0;
      this._schtasksWinStatus = false;
      this._schtasksOffStatus = false;
      this._actSuccessfullFlag = false;
      this.KmsServerServiceName = "KMSEmulator";
      this._sounds = true;
      this._cdDvdRom = true;
      this.ActivateError = 0;
      this._myPrintLineNoPrint = false;
      this._delKmsServer = false;
      this._codepage = 866;
      this._myKey = "";
      this._userFolderToSave = "";
      this._openfolder = new FolderBrowserDialog();
      this._saveOffice2013Act = false;
      this.MyOfficeKey = "";
      this.LoadingProgramm = true;
      this._kmsServicePathExe = Application.StartupPath + this._kmsAutoFileList[2];
      this._kmsServicePathLog = Application.StartupPath + this._kmsAutoFileList[5];
      this._showDialogReinstallKms = true;
      this.ModeTap = false;
      this._modeWd = false;
      this._modeAuto = false;
      this._modeAutoNo = false;
      this._modeHook = false;
      this._autoModeHost = "127.0.0.2";
      this._autoHostText = "   == Auto Host ==";
      this._autoModeHostLh = "127.0.0.2";
      this._autoModeHostWd = "100.100.0.10";
      this._autoModeHostTap = "10.3.0.20";
      this._autoModeHostHook = "1.2.3.4";
      this._disableActivateSystemButton = false;
      this.Errorcodetxt = "";
      this._type = 0;
      this._countActivations = 0;
      this._winDivertRun = false;
      this.WinDivertRemoveHard = false;
      this._requestWinKey = false;
      this._requestOffKey = false;
      this.AutoRes = false;
      this._firstActivation = true;
      this.NoAutoNoKms = true;
      this.TapType = "";
      this.ApplicationStartupPathForDos = Application.StartupPath;
      this.ApplicationStartupPathForPlan = Application.StartupPath;
      this.PathKmsService = Application.StartupPath;
      this.SetKmsProgramData = true;
      this.AutoModeList = new string[0];
      this.SaveInIinfolder = false;
      this.HookMode = 0;
      this._showReadmeView = false;
      this._positionLeftTopStartProg = true;
      this._btnVideo = false;
      this.WinVersion7601 = "";
      this._instKey = true;
      this._installOwnKeyFlag = false;
      this._windows10 = false;
      this._msActBackUpFlag = false;
      this._officeInstalled = false;
      this._actSuccessfull = "                            ===== " + Lang.WmiaApActSuccessful + " =====";
      this._version = Application.ProductName + " 2015 v" + Application.ProductVersion + " by Ratiborus";
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.Manual;
    }

    private void KMS_SchedulerFlagShow()
    {
      if (this.Scheduler)
      {
        this.Label6.Text = Lang.Warning4;
        this.Label6.Refresh();
      }
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
      {
        this.Label6.Text = Lang.Warning2;
        this.Label6.Refresh();
        this.Label9.Text = Lang.Warning2;
        this.Label9.Refresh();
      }
      else
      {
        this.Label9.Text = "";
        this.Label9.Refresh();
      }
      if (Operators.CompareString(this.KmsFlag, "", false) == 0 & !this.Scheduler)
      {
        this.Label6.Text = "";
        this.Label6.Refresh();
        this.Label9.Text = "";
        this.Label9.Refresh();
      }
      if (File.Exists(this._kmsServicePathLog))
      {
        this.Button27.Enabled = true;
        this.Button33.Enabled = true;
      }
      else
      {
        this.Button27.Enabled = false;
        this.Button33.Enabled = false;
      }
      if (File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm"))
      {
        bool loadingProgramm = this.LoadingProgramm;
        this.LoadingProgramm = true;
        this.CheckBoxAnalizer.Checked = true;
        this.LoadingProgramm = loadingProgramm;
        this.Button28.Enabled = true;
      }
      else
      {
        bool loadingProgramm = this.LoadingProgramm;
        this.LoadingProgramm = true;
        this.CheckBoxAnalizer.Checked = false;
        this.LoadingProgramm = loadingProgramm;
        this.Button28.Enabled = false;
      }
    }

    private void CheckCmdline()
    {
      if (this.IsServiceExist(this.KmsServerServiceName))
        this.KmsFlag = "KMS";
      this.ParseCommandLineArgs("/sound=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this._sounds = true;
        this.SaveProgramSetting();
      }
      else if (Operators.CompareString(this._args, "no", false) == 0)
      {
        this._argsFlag = true;
        this._sounds = false;
        this.SaveProgramSetting();
      }
      this.ParseCommandLineArgs("/kmsset=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this.KmsFlag = "KMS";
        this.KmsSetAndExtractFolder();
      }
      this.ParseCommandLineArgs("/kmsdel=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this.KmsFlag = "";
        this.KmsDelAndDelFolder();
      }
      this.ParseCommandLineArgs("/convert=");
      if (Operators.CompareString(this._args, "win8", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win8pro", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8 Pro";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win8ent", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8 Enterprise";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81pro", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Pro";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81ent", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Enterprise";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81sl", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Single Language";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81wmc", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Pro with Media Center";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81n", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 N";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81entn", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Enterprise N";
        this.Change_Windows_Version();
      }
      if (Operators.CompareString(this._args, "win81pron", false) == 0)
      {
        this._argsFlag = true;
        this.ComboBox9.Text = "Windows 8.1 Pro N";
        this.Change_Windows_Version();
      }
      this.ParseCommandLineArgs("/key=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this.OwnKeyInstallNoDialog = true;
        this.Install_OwnKey_Old_and_New_Windows_Version();
        this.OwnKeyInstallNoDialog = true;
        this.OwnKeyInstallNoDialogMyKey = false;
        WmIfunctions.InstallGvlk((byte) 1, byte.MaxValue);
        this.OwnKeyInstallNoDialog = false;
      }
      this.ParseCommandLineArgs("/win=");
      if (Operators.CompareString(this._args, "act", false) == 0)
      {
        this._argsFlag = true;
        this.CmdWinActivate();
      }
      this.ParseCommandLineArgs("/off=");
      if (Operators.CompareString(this._args, "act", false) == 0)
      {
        this._argsFlag = true;
        this.CmdOffActivate();
      }
      this.ParseCommandLineArgs("/log=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this.Change_Windows_Version_Init();
        this.WriteLoGfile();
      }
      this.ParseCommandLineArgs("/task=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        this.ParseCommandLineArgs("/win=");
        string args1 = this._args;
        this.ParseCommandLineArgs("/off=");
        string args2 = this._args;
        if (Operators.CompareString(args1, "act", false) == 0 & Operators.CompareString(args2, "act", false) == 0)
          this.CheckTaskParamAndSetShedule("all");
        else if (Operators.CompareString(args1, "act", false) == 0 & (uint) Operators.CompareString(args2, "act", false) > 0U)
          this.CheckTaskParamAndSetShedule("win");
        else if ((uint) Operators.CompareString(args1, "act", false) > 0U & Operators.CompareString(args2, "act", false) == 0)
          this.CheckTaskParamAndSetShedule("off");
      }
      this.ParseCommandLineArgs("/taskrun=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /run /TN KMSAutoNet", AppWinStyle.Hide, false, -1);
      }
      this.ParseCommandLineArgs("/test=");
      if (Operators.CompareString(this._args, "yes", false) == 0)
      {
        this._argsFlag = true;
        Thread.Sleep(1000);
      }
      if (this._argsFlag)
      {
        this.Hide();
        this.Visible = false;
        this.Close();
        this._cmDlineExist = true;
      }
      else
      {
        this.Show();
        this.Visible = true;
        this._cmDlineExist = false;
      }
    }

    private void ParseCommandLineArgs(string a)
    {
      this._args = "";
      string str = a;
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Application.CommandLineArgs.GetEnumerator();
        while (enumerator.MoveNext())
        {
          string current = enumerator.Current;
          if (current.ToLower().StartsWith(str))
            this._args = current.Remove(0, str.Length);
        }
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
    }

    private void MessageReinstallKms()
    {
      if (!this._showDialogReinstallKms || Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      if (MessageBox.Show(Lang.Message, Lang.Caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        this._showDialogReinstallKms = false;
        this.TabControl1.SelectedTab = this.TabPage1;
        this.Refresh();
        this.KmsSetAndExtractFolder();
        this.CheckKmsService();
        this._showDialogReinstallKms = true;
      }
      else
        this._showDialogReinstallKms = false;
    }

    private void WriteLoGfile()
    {
      this._saveToFileLog = true;
      this.MyPrintLine(this._razdelitel2);
      WmIfunctions.GetProductStatus((byte) 1);
      this.MyPrintLine(this._razdelitel2);
      WmIfunctions.GetProductStatus((byte) 6);
      this.MyPrintLine(this._razdelitel2);
      this.ProduKeyInfo();
      this.MyPrintLine("      === " + Conversions.ToString(DateAndTime.Now) + " ===");
      this.MyPrintLine("");
      this._saveToFileLog = false;
    }

    private bool IsServiceExist(string NAME)
    {
      bool flag = false;
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey registryKey2 = registryKey1.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + NAME, false);
      string Left;
      try
      {
        Left = Conversions.ToString(registryKey2.GetValue("ImagePath"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Left = "";
        ProjectData.ClearProjectError();
      }
      registryKey1.Close();
      if (Operators.CompareString(Left, "", false) != 0)
        flag = true;
      return flag;
    }

    private object ExtractKmsService(string PathKMSService)
    {
      if (!Directory.Exists(PathKMSService))
        Interaction.Shell(this.SysPath + "cmd.exe /c md \"" + PathKMSService + "\"", AppWinStyle.Hide, true, -1);
      FileSystem.ChDir(PathKMSService);
      if (!(File.Exists(PathKMSService + "\\bin\\KMSSS.exe") & File.Exists(PathKMSService + "\\bin\\TunMirror.exe") & File.Exists(PathKMSService + "\\bin\\TunMirror2.exe")))
      {
        while (!File.Exists(PathKMSService + "\\bin.dat"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("bin.dat", KMSAuto_Net.My.Resources.Resources.bin, false);
          Application.DoEvents();
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c bin.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
        this.DelFile("bin.dat");
      }
      if (Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0)
      {
        if (!(File.Exists(PathKMSService + "\\bin\\driver\\oas_sert.cer") & File.Exists(PathKMSService + "\\bin\\driver\\tap0901.cer") & File.Exists(PathKMSService + "\\bin\\driver\\x64WDV\\FakeClient.exe")))
        {
          while (!File.Exists(PathKMSService + "\\bin_x64.dat"))
          {
            MyProject.Computer.FileSystem.WriteAllBytes("bin_x64.dat", KMSAuto_Net.My.Resources.Resources.bin_x64, false);
            Application.DoEvents();
          }
          Interaction.Shell(this.SysPath + "cmd.exe /c bin_x64.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
          this.DelFile("bin_x64.dat");
        }
      }
      else if (!(File.Exists(PathKMSService + "\\bin\\driver\\oas_sert.cer") & File.Exists(PathKMSService + "\\bin\\driver\\tap0901.cer") & File.Exists(PathKMSService + "\\bin\\driver\\x86WDV\\FakeClient.exe")))
      {
        while (!File.Exists(PathKMSService + "\\bin_x86.dat"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("bin_x86.dat", KMSAuto_Net.My.Resources.Resources.bin_x86, false);
          Application.DoEvents();
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c bin_x86.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
        this.DelFile("bin_x86.dat");
      }
      if (!File.Exists(PathKMSService + "\\KMSAuto Net.exe"))
        File.Copy(Application.StartupPath + "\\KMSAuto Net.exe", PathKMSService + "\\KMSAuto Net.exe", true);
      FileSystem.ChDir(Application.StartupPath);
      int num;
      return (object) num;
    }

    private object KmsSetAndExtractFolder()
    {
      this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAuto";
      Conversions.ToInteger(this.ExtractKmsService(this.PathKmsService));
      object obj = (object) 0;
      this.MyPrintLine(Lang.KmsSetText1);
      if (this.IsServiceExist(this.KmsServerServiceName))
      {
        int num1 = this.StopKmsServer();
        if (!(num1 == 0 | num1 == 1056))
        {
          this.MyPrintLine("KMSSet, KMS-Service Stop error!!!");
          obj = (object) (int) byte.MaxValue;
          goto label_12;
        }
        else
        {
          int num2 = this.DeleteKmsServer();
          if (!(num2 == 0 | num2 == 1056))
          {
            this.MyPrintLine("KMS-Service Delete error!!!");
            obj = (object) (int) byte.MaxValue;
            goto label_12;
          }
        }
      }
      this.MyPrintLine(Lang.KmsSetText4);
      Interaction.Shell(this.SysPath + "cmd.exe /c for /f \"tokens=5 delims=, \" %i in ('netstat -ano ^| find \":" + this._port + " \"') do taskkill /pid %i /f", AppWinStyle.Hide, true, -1);
      Interaction.Shell(this.SysPath + "Netsh Advfirewall Firewall delete rule name=\"0pen Port KMS\" protocol=TCP", AppWinStyle.Hide, true, -1);
      Interaction.Shell(this.SysPath + "Netsh Advfirewall Firewall add rule name=\"0pen Port KMS\" dir=in action=allow protocol=TCP localport=" + this._port ?? "", AppWinStyle.Hide, true, -1);
      int num3 = this.InstallKmsService(this.PathKmsService + this._kmsAutoFileList[2]);
      if (num3 == 0 | num3 == 1056)
      {
        this._kmsServicePathExe = this.PathKmsService + this._kmsAutoFileList[2];
        this._kmsServicePathLog = this.PathKmsService + this._kmsAutoFileList[5];
        int num1 = this.StartKmsServer();
        if (num1 == 0 | num1 == 1056)
        {
          this.MyPrintLine(Lang.KmsServiceStartSusces);
          this.MyPrintLine(this._razdelitel);
          if (File.Exists(this.PathKmsService + this._kmsAutoFileList[5]))
          {
            this.Button27.Enabled = true;
            this.Button33.Enabled = true;
          }
          else
          {
            this.Button27.Enabled = false;
            this.Button33.Enabled = false;
            this.Button28.Enabled = false;
          }
        }
        else
        {
          this.MyPrintLine("KMSSet, KMS-Service Start error!!!");
          this.KmsDelAndDelFolder();
          obj = (object) (int) byte.MaxValue;
        }
      }
      else
      {
        this.MyPrintLine("KMS-Service install error!!!");
        obj = (object) (int) byte.MaxValue;
      }
label_12:
      return obj;
    }

    private object KmsDelAndDelFolder()
    {
      object obj = (object) 0;
      if (this.SetKmsProgramData)
      {
        string str = this._systemdrive + "\\ProgramData\\KMSAuto";
      }
      else
      {
        string startupPath = Application.StartupPath;
      }
      if (this.IsServiceExist(this.KmsServerServiceName))
      {
        int num1 = this.StopKmsServer();
        if (!(num1 == 0 | num1 == 1060))
        {
          this.MyPrintLine("KMSDel, KMS-Service Stop error!!!");
          obj = (object) (int) byte.MaxValue;
          this.DeleteKmsServer();
          goto label_17;
        }
        else
        {
          int num2 = this.DeleteKmsServer();
          if (!(num2 == 0 | num2 == 1060))
          {
            this.MyPrintLine("KMS-Service Delete error!!!");
            obj = (object) (int) byte.MaxValue;
            goto label_17;
          }
          else if (File.Exists(this.SysPath + "reg.exe"))
            Interaction.Shell(this.SysPath + "cmd.exe /c reg.exe DELETE HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + this.KmsServerServiceName + " /f", AppWinStyle.Hide, true, -1);
          else
            Interaction.Shell(this._systemroot + "\\System32\\cmd.exe /c reg.exe DELETE HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + this.KmsServerServiceName + " /f", AppWinStyle.Hide, true, -1);
        }
      }
      if (File.Exists(this.SysPath + "Netsh.exe"))
        Interaction.Shell(this.SysPath + "Netsh Advfirewall Firewall delete rule name=\"0pen Port KMS\" protocol=TCP", AppWinStyle.Hide, true, -1);
      else
        Interaction.Shell(this._systemroot + "\\System32\\Netsh.exe Advfirewall Firewall delete rule name=\"0pen Port KMS\" protocol=TCP", AppWinStyle.Hide, true, -1);
      if (this.SetKmsProgramData)
        this.DelDir(this._systemdrive + "\\ProgramData\\KMSAuto");
      this.MyPrintLine(Lang.KmsDelText8);
label_17:
      return obj;
    }

    private object InstallHook()
    {
      object obj;
      if (this.HookMode == 1)
      {
        this.InstallHook2();
        obj = (object) 0;
      }
      else
      {
        obj = (object) 0;
        Interaction.Shell("net stop sppsvc /y", AppWinStyle.Hide, true, -1);
        Process[] processesByName = Process.GetProcessesByName("sppsvc");
        int index = 0;
        while (index < processesByName.Length)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        this.MyPrintLine(Lang.InstallHookTxt + ", SppPatcher ...");
        FileSystem.ChDir(this._systemroot + "\\System32");
        Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
        if (Directory.Exists(this.Tempdir + "\\KMSAuto"))
        {
          FileSystem.ChDir(this._systemroot + "\\System32");
          Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
          this.DelDir(this.Tempdir + "\\KMSAuto");
        }
        FileSystem.ChDir(this.Tempdir);
        if (Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0)
        {
          while (!File.Exists(this.Tempdir + "\\SppPatcher_x64.dat"))
          {
            MyProject.Computer.FileSystem.WriteAllBytes("SppPatcher_x64.dat", KMSAuto_Net.My.Resources.Resources.SppP_x64, false);
            Application.DoEvents();
          }
          Interaction.Shell(this.SysPath + "cmd.exe /c SppPatcher_x64.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
          this.DelFile("SppPatcher_x64.dat");
        }
        else
        {
          while (!File.Exists(this.Tempdir + "\\SppPatcher_x86.dat"))
          {
            MyProject.Computer.FileSystem.WriteAllBytes("SppPatcher_x86.dat", KMSAuto_Net.My.Resources.Resources.SppP_x86, false);
            Application.DoEvents();
          }
          Interaction.Shell(this.SysPath + "cmd.exe /c SppPatcher_x86.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
          this.DelFile("SppPatcher_x86.dat");
        }
        FileSystem.ChDir(this.Tempdir + "\\KMSAuto");
        Interaction.Shell(this.SysPath + "cmd.exe /c copy SppExtComObjPatcher.exe " + this.Windir + "\\system32\\SppExtComObjPatcher.exe /Y", AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd.exe /c copy SppExtComObjHook.dll " + this.Windir + "\\system32\\SppExtComObjHook.dll /Y", AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SppExtComObj.Exe\" /f /v \"Debugger\" /t REG_SZ /d \"SppExtComObjPatcher.exe\"", AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SppExtComObj.Exe\" /f /v \"KMS_Emulation\" /t REG_DWORD /d 0", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(Application.StartupPath);
      }
      return obj;
    }

    private object UnInstallHook()
    {
      object obj;
      if (this.HookMode == 1)
      {
        this.UnInstallHook2();
        obj = (object) 0;
      }
      else
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
        this.DelDir(this.Tempdir + "\\KMSAuto");
        this.DelFile(this.Windir + "\\system32\\SppExtComObjPatcher.exe");
        this.DelFile(this.Windir + "\\system32\\SppExtComObjHook.dll");
        try
        {
          RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
          registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true).DeleteSubKeyTree("SppExtComObj.Exe");
          registryKey.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.MyPrintLine("Error delete registry key !");
          ProjectData.ClearProjectError();
        }
        FileSystem.ChDir(Application.StartupPath);
        obj = (object) 0;
      }
      return obj;
    }

    private object InstallHook2()
    {
      object obj = (object) 0;
      Interaction.Shell("net stop sppsvc /y", AppWinStyle.Hide, true, -1);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      this.MyPrintLine(Lang.InstallHookTxt + ", Injector by deagles ...");
      FileSystem.ChDir(this._systemroot + "\\System32");
      Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
      if (Directory.Exists(this.Tempdir + "\\KMSAuto"))
        this.UnInstallHook2();
      FileSystem.ChDir(this.Tempdir);
      if (Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\Inject_dx64.dat"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("Inject_dx64.dat", KMSAuto_Net.My.Resources.Resources.Inj_dx64, false);
          Application.DoEvents();
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c Inject_dx64.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
        this.DelFile("Inject_dx64.dat");
      }
      else
      {
        while (!File.Exists(this.Tempdir + "\\Inject_dx86.dat"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("Inject_dx86.dat", KMSAuto_Net.My.Resources.Resources.Inj_dx86, false);
          Application.DoEvents();
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c Inject_dx86.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
        this.DelFile("Inject_dx86.dat");
      }
      FileSystem.ChDir(this.Tempdir + "\\KMSAuto");
      Interaction.Shell(this.SysPath + "cmd.exe /c Injector.exe", AppWinStyle.Hide, true, -1);
      FileSystem.ChDir(Application.StartupPath);
      return obj;
    }

    private object UnInstallHook2()
    {
      object obj = (object) 0;
      FileSystem.ChDir(this._systemroot + "\\System32");
      Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
      FileSystem.ChDir(this.Tempdir + "\\KMSAuto");
      Interaction.Shell(this.SysPath + "cmd.exe /c Injector.exe", AppWinStyle.Hide, true, -1);
      FileSystem.ChDir(this.Tempdir);
      this.DelDir(this.Tempdir + "\\KMSAuto");
      while (Directory.Exists(this.Tempdir + "\\KMSAuto"))
      {
        FileSystem.ChDir(this._systemroot + "\\System32");
        Interaction.Shell(this.SysPath + "cmd.exe /c taskkill /t /f /IM SppExtComObj.Exe", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(this.Tempdir);
        if (Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0)
        {
          while (!File.Exists(this.Tempdir + "\\Inject_dx64.dat"))
          {
            MyProject.Computer.FileSystem.WriteAllBytes("Inject_dx64.dat", KMSAuto_Net.My.Resources.Resources.Inj_dx64, false);
            Application.DoEvents();
          }
          Interaction.Shell(this.SysPath + "cmd.exe /c Inject_dx64.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
          this.DelFile("Inject_dx64.dat");
        }
        else
        {
          while (!File.Exists(this.Tempdir + "\\Inject_dx86.dat"))
          {
            MyProject.Computer.FileSystem.WriteAllBytes("Inject_dx86.dat", KMSAuto_Net.My.Resources.Resources.Inj_dx86, false);
            Application.DoEvents();
          }
          Interaction.Shell(this.SysPath + "cmd.exe /c Inject_dx86.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
          this.DelFile("Inject_dx86.dat");
        }
        FileSystem.ChDir(this.Tempdir + "\\KMSAuto");
        Interaction.Shell(this.SysPath + "cmd.exe /c Injector.exe", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(this.Tempdir);
        this.DelDir(this.Tempdir + "\\KMSAuto");
      }
      FileSystem.ChDir(Application.StartupPath);
      return obj;
    }

    private void DisableRadioButton()
    {
      this.LinkLabel2.Hide();
      this.LinkLabel4.Hide();
      this.LinkLabel6.Hide();
      this.LinkLabel4.Hide();
      this.LinkLabel9.Hide();
      this.Label17.Text = Lang.PleaseWait;
      this.Label17.Refresh();
      this.RB1AUTO.Enabled = false;
      this.RB2WD.Enabled = false;
      this.RB3TAP.Enabled = false;
      this.RB4NOAuto.Enabled = false;
      this.RB5Hook.Enabled = false;
      this.PrintMode();
    }

    private void EnableRadioButton()
    {
      this.Label17.Text = "";
      this.Label17.Refresh();
      this.LinkLabel2.Show();
      this.LinkLabel4.Show();
      this.LinkLabel6.Show();
      this.LinkLabel4.Show();
      this.LinkLabel9.Show();
      this.LinkLabel9.Refresh();
      this.LinkLabel2.Refresh();
      this.LinkLabel4.Refresh();
      this.LinkLabel6.Refresh();
      this.LinkLabel4.Refresh();
      this.RB1AUTO.Enabled = true;
      this.RB2WD.Enabled = true;
      this.RB3TAP.Enabled = true;
      this.RB4NOAuto.Enabled = true;
      if (this.Check_New_Windows_Version_9600())
      {
        this.RB5Hook.Enabled = true;
        this.LinkLabel9.Enabled = true;
      }
      else
      {
        this.RB5Hook.Enabled = false;
        this.LinkLabel9.Enabled = false;
        if (this._modeHook)
        {
          this._modeHook = false;
          this._modeAuto = true;
        }
        MyProject.Forms.AutoMode.CheckBox2.Checked = false;
        MyProject.Forms.AutoMode.CheckBox2.Enabled = false;
      }
      this.PrintMode();
    }

    private void PrintMode()
    {
      if (this._modeAuto)
      {
        this.Label14.ForeColor = System.Drawing.Color.Green;
        this.Label14.Text = "    = Auto =";
      }
      else if (this._modeWd)
      {
        this.Label14.ForeColor = System.Drawing.Color.Blue;
        this.Label14.Text = "= WinDivert =";
      }
      else if (this.ModeTap)
      {
        this.Label14.ForeColor = System.Drawing.Color.Blue;
        this.Label14.Text = "    = TAP =";
      }
      else if (this._modeAutoNo)
      {
        this.Label14.ForeColor = System.Drawing.Color.Red;
        this.Label14.Text = " = NoAuto =";
      }
      else if (this._modeHook)
      {
        this.Label14.ForeColor = System.Drawing.Color.Blue;
        this.Label14.Text = "  = Hook =";
      }
      this.Label14.Refresh();
    }

    private void InstallTap()
    {
      string tempfile = "\\KMSSettmp" + Conversions.ToString(this.GenerateRnd(0, (int) byte.MaxValue)) + ".tmp";
      bool flagTap1 = false;
      bool flagTap2 = false;
      if (this.IsServiceExist("TunMirror"))
        return;
      this.MyPrintLine(Lang.InstallTapAdapter);
      this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAuto";
      this.ExtractKmsService(this.PathKmsService);
      this.DisableRadioButton();
      Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"ptun0901\" get Manufacturer  >\"" + this.Tempdir + tempfile ?? "", AppWinStyle.Hide, true, -1);
      string[] saveParamProg;
      if (File.Exists(this.Tempdir + tempfile))
        saveParamProg = File.ReadAllLines(this.Tempdir + tempfile);
      Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"tapoas\" get Manufacturer  >\"" + this.Tempdir + tempfile ?? "", AppWinStyle.Hide, true, -1);
      string[] saveParamProg2;
      if (File.Exists(this.Tempdir + tempfile))
        saveParamProg2 = File.ReadAllLines(this.Tempdir + tempfile);
      string[] strArray1 = saveParamProg;
      int index1 = 0;
      while (index1 < strArray1.Length)
      {
        if (strArray1[index1].Contains("TAP Provider V9"))
          flagTap1 = true;
        checked { ++index1; }
      }
      string[] strArray2 = saveParamProg2;
      int index2 = 0;
      while (index2 < strArray2.Length)
      {
        if (strArray2[index2].Contains("TAP-Win32 Provider OAS"))
          flagTap2 = true;
        checked { ++index2; }
      }
      if (Operators.CompareString(this.TapType, "", false) == 0)
      {
        if (!flagTap1)
          this._InstallTAP1(this.PathKmsService, tempfile, saveParamProg, flagTap1);
        else
          this._InstallTAP2(this.PathKmsService, tempfile, saveParamProg2, flagTap2);
      }
      else if (Operators.CompareString(this.TapType, "TAP1", false) == 0)
        this._InstallTAP1(this.PathKmsService, tempfile, saveParamProg, flagTap1);
      else if (Operators.CompareString(this.TapType, "TAP2", false) == 0)
        this._InstallTAP2(this.PathKmsService, tempfile, saveParamProg2, flagTap2);
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror.InstallState"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror.InstallState");
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror2.InstallState"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror2.InstallState");
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror2.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror2.InstallLog");
      if (File.Exists(this.PathKmsService + "\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\InstallUtil.InstallLog");
      if (File.Exists(this.Tempdir + tempfile))
        File.Delete(this.Tempdir + tempfile);
      if (File.Exists(this.PathKmsService + "\\bin\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\InstallUtil.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\driver\\x64\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\driver\\x64\\InstallUtil.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\driver\\x86\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\driver\\x86\\InstallUtil.InstallLog");
      this.EnableRadioButton();
    }

    private object _InstallTAP1(string PathKMSService, string tempfile, string[] saveParamProg, bool flagTap1)
    {
      string str = !(Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0) ? "x86TAP1" : "x64TAP1";
      if (!flagTap1)
      {
        FileSystem.ChDir(PathKMSService + "\\bin\\driver");
        Interaction.Shell(this.SysPath + "cmd.exe /c certutil -addstore \"TrustedPublisher\" tap0901.cer", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService + "\\bin\\driver\\" + str);
        Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe install OemVista.inf ptun0901", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService);
      }
      Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"ptun0901\" get InterfaceIndex  >\"" + this.Tempdir + tempfile ?? "", AppWinStyle.Hide, true, -1);
      if (File.Exists(this.Tempdir + tempfile))
        saveParamProg = File.ReadAllLines(this.Tempdir + tempfile);
      if (saveParamProg.Length > 1)
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c netsh interface ip set address " + saveParamProg[1] + " static 10.3.0.1 255.255.255.0", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService + "\\bin");
        if (this.IsServiceExist("TunMirror"))
        {
          Interaction.Shell("net stop TunMirror", AppWinStyle.Hide, true, -1);
          Interaction.Shell(this.SysPath + "cmd.exe /c Tunmirror.exe /u", AppWinStyle.Hide, true, -1);
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c Tunmirror.exe /i", AppWinStyle.Hide, true, -1);
        Interaction.Shell("net start TunMirror", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService);
        if (!File.Exists(PathKMSService + "\\bin\\TunMirror.InstallState"))
          Thread.Sleep(2000);
        Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
      }
      this.TapType = "TAP1";
      return (object) 0;
    }

    private object _InstallTAP2(string PathKMSService, string tempfile, string[] saveParamProg2, bool flagTap2)
    {
      string str = !(Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0) ? "x86TAP2" : "x64TAP2";
      Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"tapoas\" get Manufacturer  >\"" + this.Tempdir + tempfile ?? "", AppWinStyle.Hide, true, -1);
      if (!flagTap2)
      {
        FileSystem.ChDir(PathKMSService + "\\bin\\driver");
        Interaction.Shell(this.SysPath + "cmd.exe /c certutil -addstore \"TrustedPublisher\" oas_sert.cer", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService + "\\bin\\driver\\" + str);
        Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe install tapoas.inf tapoas", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService);
      }
      Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"tapoas\" get InterfaceIndex  >\"" + this.Tempdir + tempfile ?? "", AppWinStyle.Hide, true, -1);
      if (File.Exists(this.Tempdir + tempfile))
        saveParamProg2 = File.ReadAllLines(this.Tempdir + tempfile);
      if (saveParamProg2.Length > 1)
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c netsh interface ip set address " + saveParamProg2[1] + " static 10.3.0.1 255.255.255.0", AppWinStyle.Hide, true, -1);
        int num = this.IsServiceExist("TunMirror") ? 1 : 0;
        FileSystem.ChDir(PathKMSService + "\\bin");
        if (num != 0)
        {
          Interaction.Shell("net stop TunMirror", AppWinStyle.Hide, true, -1);
          Interaction.Shell("cmd.exe /c Tunmirror2.exe /u", AppWinStyle.Hide, true, -1);
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c Tunmirror2.exe /i", AppWinStyle.Hide, true, -1);
        Interaction.Shell("net start TunMirror", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(PathKMSService);
        if (!File.Exists(PathKMSService + "\\bin\\TunMirror.InstallState"))
          Thread.Sleep(2000);
        Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
      }
      this.TapType = "TAP2";
      return (object) 0;
    }

    public void UnInstallTap()
    {
      if (Operators.CompareString(this.TapType, "", false) == 0)
        return;
      string str1 = "\\KMSDeltmp" + Conversions.ToString(this.GenerateRnd(0, (int) byte.MaxValue)) + ".tmp";
      this.DisableRadioButton();
      this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAuto";
      this.ExtractKmsService(this.PathKmsService);
      if (this.IsServiceExist("TunMirror"))
      {
        Interaction.Shell("net stop TunMirror", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(this.PathKmsService + "\\bin");
        Interaction.Shell("cmd.exe /c TunMirror /u", AppWinStyle.Hide, true, -1);
        FileSystem.ChDir(this.PathKmsService);
      }
      if (Operators.CompareString(this.TapType, "TAP1", false) == 0)
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"ptun0901\" get Manufacturer  >\"" + this.Tempdir + str1 ?? "", AppWinStyle.Hide, true, -1);
        if (File.Exists(this.Tempdir + str1))
        {
          string[] strArray = File.ReadAllLines(this.Tempdir + str1);
          int index = 0;
          while (index < strArray.Length)
          {
            if (!strArray[index].Contains("TAP Provider V9"))
            {
              checked { ++index; }
            }
            else
            {
              string str2 = !(Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0) ? "x86TAP1" : "x64TAP1";
              if (File.Exists(this.PathKmsService + "\\bin\\driver\\" + str2 + "\\devcon.exe"))
              {
                FileSystem.ChDir(this.PathKmsService + "\\bin\\driver\\" + str2);
                Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe remove ptun0901", AppWinStyle.Hide, true, -1);
                FileSystem.ChDir(this.PathKmsService);
                break;
              }
              this.ExtractKmsService(this.PathKmsService);
              FileSystem.ChDir(this.PathKmsService + "\\bin\\driver\\" + str2);
              Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe remove ptun0901", AppWinStyle.Hide, true, -1);
              FileSystem.ChDir(this.PathKmsService);
              this.DelDir(this._systemdrive + "\\ProgramData\\KMSAuto");
              break;
            }
          }
          this.TapType = "";
        }
      }
      if (Operators.CompareString(this.TapType, "TAP2", false) == 0)
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c WMIC Path Win32_NetworkAdapter WHERE ServiceName=\"tapoas\" get Manufacturer  >\"" + this.Tempdir + str1 ?? "", AppWinStyle.Hide, true, -1);
        if (File.Exists(this.Tempdir + str1))
        {
          string[] strArray = File.ReadAllLines(this.Tempdir + str1);
          int index = 0;
          while (index < strArray.Length)
          {
            if (!strArray[index].Contains("TAP-Win32 Provider OAS"))
            {
              checked { ++index; }
            }
            else
            {
              string str2 = !(Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0) ? "x86TAP2" : "x64TAP2";
              if (File.Exists(this.PathKmsService + "\\bin\\driver\\" + str2 + "\\devcon.exe"))
              {
                FileSystem.ChDir(this.PathKmsService + "\\bin\\driver\\" + str2);
                Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe remove tapoas", AppWinStyle.Hide, true, -1);
                FileSystem.ChDir(this.PathKmsService);
                break;
              }
              this.ExtractKmsService(this.PathKmsService);
              FileSystem.ChDir(this.PathKmsService + "\\bin\\driver\\" + str2);
              Interaction.Shell(this.SysPath + "cmd.exe /c devcon.exe remove tapoas", AppWinStyle.Hide, true, -1);
              FileSystem.ChDir(this.PathKmsService);
              this.DelDir(this._systemdrive + "\\ProgramData\\KMSAuto");
              break;
            }
          }
          this.TapType = "";
        }
      }
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\TunMirror2.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\TunMirror2.InstallLog");
      if (File.Exists(this.PathKmsService + "\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\InstallUtil.InstallLog");
      if (File.Exists(this.Tempdir + str1))
        File.Delete(this.Tempdir + str1);
      if (File.Exists(this.PathKmsService + "\\bin\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\InstallUtil.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\driver\\x64\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\driver\\x64\\InstallUtil.InstallLog");
      if (File.Exists(this.PathKmsService + "\\bin\\driver\\x86\\InstallUtil.InstallLog"))
        File.Delete(this.PathKmsService + "\\bin\\driver\\x86\\InstallUtil.InstallLog");
      if (this.SetKmsProgramData && Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        this.DelDir(this._systemdrive + "\\ProgramData\\KMSAuto");
      this.EnableRadioButton();
    }

    private object InstallDivert()
    {
      object obj;
      if (this._winDivertRun)
      {
        obj = (object) (int) byte.MaxValue;
      }
      else
      {
        int num1 = 0;
        this.MyPrintLine(Lang.InstallWinDivertDriver);
        while (true)
        {
          this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAuto";
          Conversions.ToInteger(this.ExtractKmsService(this.PathKmsService));
          if (!File.Exists(this.PathKmsService + "\\KMSAuto Net.exe"))
            this.ExtractKmsService(this.PathKmsService);
          Interaction.Shell(this.SysPath + "cmd.exe /c route -p add " + this._host + " 0.0.0.0 IF 1", AppWinStyle.Hide, true, -1);
          FileSystem.ChDir(this.PathKmsService + "\\bin\\driver\\" + (!(Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITECTURE"), "AMD64", false) == 0 | Operators.CompareString(Interaction.Environ("PROCESSOR_ARCHITEW6432"), "AMD64", false) == 0) ? "x86WDV" : "x64WDV"));
          Interaction.Shell(this.SysPath + "cmd.exe /c FakeClient.exe " + this._host, AppWinStyle.Hide, false, -1);
          FileSystem.ChDir(Application.StartupPath);
          int num2 = 0;
          while (num2 < 100)
          {
            this.Focus();
            Application.DoEvents();
            checked { ++num2; }
            Thread.Sleep(50);
          }
          bool flag = false;
          Process[] processesByName = Process.GetProcessesByName("FakeClient");
          int num3 = 0;
          while (num3 < processesByName.Length)
          {
            flag = true;
            checked { ++num3; }
          }
          if (!flag)
          {
            checked { ++num1; }
            if (num1 < 10)
            {
              this._winDivertRun = true;
              this.UninstallDivert();
              this._winDivertRun = false;
            }
            else
              break;
          }
          else
            goto label_15;
        }
        this._winDivertRun = true;
        this.UninstallDivert();
        this._winDivertRun = false;
        this.MyPrintLine("=== WinDivert ERROR!!! ===");
label_15:
        obj = (object) 0;
        this._winDivertRun = true;
      }
      return obj;
    }

    private object UninstallDivert()
    {
      object obj;
      if (!this._winDivertRun)
      {
        obj = (object) (int) byte.MaxValue;
      }
      else
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c route delete " + this._host + " 0.0.0.0", AppWinStyle.Hide, true, -1);
        if (this.WinDivertRemoveHard)
        {
          this.StartProcessHide("cmd.exe", "/c taskkill /t /f /IM FakeClient.exe", true);
          this.StopService((object) "WinDivert1.1");
          this.DeleteService((object) "WinDivert1.1");
        }
        else
        {
          this.StartProcessHide("cmd.exe", "/c taskkill /t /f /IM FakeClient.exe", true);
          this.StartProcessHide("cmd.exe", "/c sc.exe delete WinDivert1.1", true);
        }
        obj = (object) 0;
        this._winDivertRun = false;
      }
      return obj;
    }

    public int InstallKmsService(string serviceExe)
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = "create " + this.KmsServerServiceName + " binpath= temp.exe  type= own start= auto";
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_11;
label_9:
        num4 = 10;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_10:
        num4 = 11;
        num2 = Information.Err().Number;
        goto label_89;
label_11:
        num4 = 13;
        process.WaitForExit();
label_12:
        num4 = 14;
        if (Information.Err().Number == 0)
          goto label_15;
label_13:
        num4 = 15;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_14:
        num4 = 16;
        num2 = Information.Err().Number;
        goto label_89;
label_15:
        num4 = 18;
        int exitCode = process.ExitCode;
label_16:
        num4 = 19;
        process.Close();
label_17:
        num4 = 20;
        if (Information.Err().Number == 0)
          goto label_20;
label_18:
        num4 = 21;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_19:
        num4 = 22;
        num2 = Information.Err().Number;
        goto label_89;
label_20:
        num4 = 24;
        if (exitCode == 0)
          goto label_23;
label_21:
        num4 = 25;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_22:
        num4 = 26;
        num2 = (int) byte.MaxValue;
        goto label_89;
label_23:
        num4 = 28;
        string str = "\"" + serviceExe + "\"";
label_24:
        num4 = 29;
        if (Operators.CompareString(this._port, "", false) != 0)
          goto label_26;
label_25:
        num4 = 30;
        this._port = "1688";
label_26:
        num4 = 31;
        str = str + " -Port " + Strings.Trim(this._port);
label_27:
        num4 = 32;
        if (Operators.CompareString(this._winPid, "", false) != 0)
          goto label_29;
label_28:
        num4 = 33;
        this._winPid = "RandomKMSPID";
label_29:
        num4 = 34;
        str = str + " -PWin " + Strings.Trim(this._winPid);
label_30:
        num4 = 35;
        if (Operators.CompareString(this._off2010Pid, "", false) != 0)
          goto label_32;
label_31:
        num4 = 36;
        this._off2010Pid = "RandomKMSPID";
label_32:
        num4 = 37;
        str = str + " -PO14 " + Strings.Trim(this._off2010Pid);
label_33:
        num4 = 38;
        if (Operators.CompareString(this._off2013Pid, "", false) != 0)
          goto label_35;
label_34:
        num4 = 39;
        this._off2013Pid = "RandomKMSPID";
label_35:
        num4 = 40;
        str = str + " -PO15 " + Strings.Trim(this._off2013Pid);
label_36:
        num4 = 41;
        if (Operators.CompareString(this._sai, "", false) != 0)
          goto label_38;
label_37:
        num4 = 42;
        this._sai = "43200";
label_38:
        num4 = 43;
        str = str + " -AI " + Strings.Trim(this._sai);
label_39:
        num4 = 44;
        if (Operators.CompareString(this._sri, "", false) != 0)
          goto label_41;
label_40:
        num4 = 45;
        this._sri = "43200";
label_41:
        num4 = 46;
        str = str + " -RI " + Strings.Trim(this._sri);
label_42:
        num4 = 47;
        if (!this.CheckBoxKP.Checked)
          goto label_44;
label_43:
        num4 = 48;
        str += " KillProcessOnPort";
label_44:
        num4 = 49;
        if (!this.CheckBoxLog.Checked)
          goto label_46;
label_45:
        num4 = 50;
        str += " -Log";
label_46:
        num4 = 51;
        if (!(this.CheckBoxIP.Checked & this.CheckBoxLog.Checked))
          goto label_48;
label_47:
        num4 = 52;
        str += " -IP";
label_48:
        num4 = 53;
        if (!Operators.ConditionalCompareObjectEqual(this.CheckHwidFormat(this._hwid, false), (object) 0, false))
          goto label_50;
label_49:
        num4 = 54;
        str = str + " -Hwid " + this._hwid;
label_50:
        num4 = 55;
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
label_51:
        num4 = 56;
        if (Information.Err().Number == 0)
          goto label_54;
label_52:
        num4 = 57;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_53:
        num4 = 58;
        num2 = Information.Err().Number;
        goto label_89;
label_54:
        num4 = 60;
        RegistryKey registryKey2 = registryKey1.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + this.KmsServerServiceName, true);
label_55:
        num4 = 61;
        if (Information.Err().Number == 0)
          goto label_59;
label_56:
        num4 = 62;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_57:
        num4 = 63;
        num2 = Information.Err().Number;
label_58:
        num4 = 64;
        registryKey1.Close();
        goto label_89;
label_59:
        num4 = 66;
        if (registryKey2 != null)
          goto label_63;
label_60:
        num4 = 67;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_61:
        num4 = 68;
        num2 = (int) byte.MaxValue;
label_62:
        num4 = 69;
        registryKey1.Close();
        goto label_89;
label_63:
        num4 = 71;
        registryKey2.SetValue("ImagePath", (object) str, RegistryValueKind.String);
label_64:
        num4 = 72;
        if (Information.Err().Number == 0)
          goto label_69;
label_65:
        num4 = 73;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_66:
        num4 = 74;
        num2 = Information.Err().Number;
label_67:
        num4 = 75;
        registryKey2.Close();
label_68:
        num4 = 76;
        registryKey1.Close();
        goto label_89;
label_69:
        num4 = 78;
        registryKey2.SetValue("Description", (object) "KMS-host for all Microsoft VL Products", RegistryValueKind.String);
label_70:
        num4 = 79;
        if (Information.Err().Number == 0)
          goto label_75;
label_71:
        num4 = 80;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_72:
        num4 = 81;
        num2 = Information.Err().Number;
label_73:
        num4 = 82;
        registryKey2.Close();
label_74:
        num4 = 83;
        registryKey1.Close();
        goto label_89;
label_75:
        num4 = 85;
        registryKey2.SetValue("DisplayName", (object) "KMS-host Service", RegistryValueKind.String);
label_76:
        num4 = 86;
        if (Information.Err().Number == 0)
          goto label_81;
label_77:
        num4 = 87;
        this.MyPrintLine(Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_78:
        num4 = 88;
        num2 = Information.Err().Number;
label_79:
        num4 = 89;
        registryKey2.Close();
label_80:
        num4 = 90;
        registryKey1.Close();
        goto label_89;
label_81:
        num4 = 92;
        registryKey2.Close();
label_82:
        num4 = 93;
        registryKey1.Close();
label_83:
        num4 = 94;
        num2 = 0;
        goto label_89;
label_85:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
              case 17:
              case 23:
              case 27:
              case 59:
              case 65:
              case 70:
              case 77:
              case 84:
              case 91:
              case 95:
                goto label_89;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 15:
                goto label_13;
              case 16:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 20:
                goto label_17;
              case 21:
                goto label_18;
              case 22:
                goto label_19;
              case 24:
                goto label_20;
              case 25:
                goto label_21;
              case 26:
                goto label_22;
              case 28:
                goto label_23;
              case 29:
                goto label_24;
              case 30:
                goto label_25;
              case 31:
                goto label_26;
              case 32:
                goto label_27;
              case 33:
                goto label_28;
              case 34:
                goto label_29;
              case 35:
                goto label_30;
              case 36:
                goto label_31;
              case 37:
                goto label_32;
              case 38:
                goto label_33;
              case 39:
                goto label_34;
              case 40:
                goto label_35;
              case 41:
                goto label_36;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
                goto label_39;
              case 45:
                goto label_40;
              case 46:
                goto label_41;
              case 47:
                goto label_42;
              case 48:
                goto label_43;
              case 49:
                goto label_44;
              case 50:
                goto label_45;
              case 51:
                goto label_46;
              case 52:
                goto label_47;
              case 53:
                goto label_48;
              case 54:
                goto label_49;
              case 55:
                goto label_50;
              case 56:
                goto label_51;
              case 57:
                goto label_52;
              case 58:
                goto label_53;
              case 60:
                goto label_54;
              case 61:
                goto label_55;
              case 62:
                goto label_56;
              case 63:
                goto label_57;
              case 64:
                goto label_58;
              case 66:
                goto label_59;
              case 67:
                goto label_60;
              case 68:
                goto label_61;
              case 69:
                goto label_62;
              case 71:
                goto label_63;
              case 72:
                goto label_64;
              case 73:
                goto label_65;
              case 74:
                goto label_66;
              case 75:
                goto label_67;
              case 76:
                goto label_68;
              case 78:
                goto label_69;
              case 79:
                goto label_70;
              case 80:
                goto label_71;
              case 81:
                goto label_72;
              case 82:
                goto label_73;
              case 83:
                goto label_74;
              case 85:
                goto label_75;
              case 86:
                goto label_76;
              case 87:
                goto label_77;
              case 88:
                goto label_78;
              case 89:
                goto label_79;
              case 90:
                goto label_80;
              case 92:
                goto label_81;
              case 93:
                goto label_82;
              case 94:
                goto label_83;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_85;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_89:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private void FileSetAttrib()
    {
      if (this._cdDvdRom)
        return;
      int num = checked (this._kmsAutoFileList.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (File.Exists(Application.StartupPath + this._kmsAutoFileList[index]))
          File.SetAttributes(Application.StartupPath + this._kmsAutoFileList[index], FileAttributes.Normal);
        checked { ++index; }
      }
      if (!File.Exists(Application.ExecutablePath))
        return;
      File.SetAttributes(Application.ExecutablePath, FileAttributes.Normal);
    }

    private void InitCombo()
    {
      if (this._index1 >= this.ComboBox1.Items.Count)
        this._index1 = 0;
      if (this._index2 >= this.ComboBox2.Items.Count)
        this._index2 = 0;
      if (this._index3 >= this.ComboBox3.Items.Count)
        this._index3 = 0;
      if (this._index6 >= this.ComboBox6.Items.Count)
        this._index6 = 0;
      if (this._index7 >= this.ComboBoxHwid.Items.Count)
        this._index7 = 0;
      this.ComboBox1.SelectedIndex = this._index1;
      this.ComboBox2.SelectedIndex = this._index2;
      this.ComboBox3.SelectedIndex = this._index3;
      this.ComboBox6.SelectedIndex = this._index6;
      this.ComboBoxHwid.SelectedIndex = this._index7;
    }

    private void SchtasksSet()
    {
      string text = this.Button2.Text;
      this.Button2.Text = Lang.ButtonRuns;
      this.Button2.Refresh();
      this.KmsFlag = "";
      this.KmsDelAndDelFolder();
      this.Button2.Text = text;
      this.Button2.Refresh();
      this.Button29.Enabled = false;
      this.Button30.Enabled = false;
      this.Button31.Enabled = false;
      if (this._modeWd)
        this._host = this._autoModeHostWd;
      else if (this.ModeTap)
        this._host = this._autoModeHostTap;
      if (this._modeAutoNo)
        this._host = this._autoModeHostLh;
      if (this._modeHook)
        this._host = this._autoModeHostHook;
      Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /end /TN KMSAutoNet", AppWinStyle.Hide, true, -1);
      Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /delete /TN KMSAutoNet /F", AppWinStyle.Hide, true, -1);
      this.SaveProgramSetting();
      this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAutoS";
      Conversions.ToInteger(this.ExtractKmsService(this.PathKmsService));
      if (this.PathKmsService.Contains("KMSAutoS"))
      {
        this.SetKmsProgramData = false;
        this.SaveProgramSetting();
      }
      this.DelFile(this.PathKmsService + "\\kmsauto.ini");
      if (File.Exists(Application.StartupPath + "\\kmsauto.ini") && !File.Exists(this.PathKmsService + "\\kmsauto.ini"))
        File.Copy(Application.StartupPath + "\\kmsauto.ini", this.PathKmsService + "\\kmsauto.ini", true);
      if (!File.Exists(this.PathKmsService + "\\kmsauto.ini") && File.Exists(this._localappdata + "\\kmsauto.ini"))
        File.Copy(this._localappdata + "\\kmsauto.ini", this.PathKmsService + "\\kmsauto.ini", true);
      if (this.PathKmsService.Contains("KMSAutoS"))
      {
        this.SetKmsProgramData = true;
        this.SaveProgramSetting();
      }
      FileSystem.ChDir(this.Tempdir);
      if (File.Exists(this._kmsAutoFileList[1]))
        this.DelFile(this.Tempdir + "\\" + this._kmsAutoFileList[1]);
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols1, false))
      {
        this.GetScheduler_Files("all");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 14400", AppWinStyle.Hide, true, -1);
        this._schtasksWinStatus = true;
        this._schtasksOffStatus = true;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols2, false))
      {
        this.GetScheduler_Files("win");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 14400", AppWinStyle.Hide, true, -1);
        this._schtasksWinStatus = true;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols3, false))
      {
        this.GetScheduler_Files("off");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 14400", AppWinStyle.Hide, true, -1);
        this._schtasksOffStatus = true;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols4, false))
      {
        this.GetScheduler_Files("all");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 1440", AppWinStyle.Hide, true, -1);
        this._schtasksWinStatus = true;
        this._schtasksOffStatus = true;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols5, false))
      {
        this.GetScheduler_Files("win");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 1440", AppWinStyle.Hide, true, -1);
        this._schtasksWinStatus = true;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox7.SelectedItem, (object) Lang.ComboBox7Cols6, false))
      {
        this.GetScheduler_Files("off");
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /create /TN KMSAutoNet /XML " + this._kmsAutoFileList[1], AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /change /TN KMSAutoNet /RI 1440", AppWinStyle.Hide, true, -1);
        this._schtasksOffStatus = true;
      }
      if (File.Exists(this._kmsAutoFileList[1]))
        this.DelFile(this.Tempdir + "\\" + this._kmsAutoFileList[1]);
      FileSystem.ChDir(this.PathKmsService);
      if (Conversions.ToInteger(this.CheckTask()) != 0)
      {
        this.Scheduler = false;
      }
      else
      {
        this.Scheduler = true;
        this.MyPrintLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Lang.SchtasksSetText3 + "\r\n"), this.ComboBox7.SelectedItem), (object) ".")));
      }
      if (Operators.CompareString(this.PathKmsService, Application.StartupPath, false) == 0)
        this.LoadProgramSetting();
      this.PathKmsService = !this.SetKmsProgramData ? Application.StartupPath : this._systemdrive + "\\ProgramData\\KMSAuto";
      this.Button29.Enabled = false;
      this.Button30.Enabled = true;
      this.Button31.Enabled = true;
    }

    private void SchtasksDel()
    {
      this.Button29.Enabled = false;
      this.Button30.Enabled = false;
      this.Button31.Enabled = false;
      this.StartProcessHide(this.SysPath + "cmd.exe", "/c schtasks.exe /end /TN KMSAutoNet", true);
      this.StartProcessHide(this.SysPath + "cmd.exe", "/c schtasks.exe /delete /TN KMSAutoNet /F", true);
      if (this.SetKmsProgramData && Operators.CompareString(this._systemdrive + "\\ProgramData\\KMSAutoS", Application.StartupPath, false) != 0)
        this.DelDir(this._systemdrive + "\\ProgramData\\KMSAutoS");
      this.MyPrintLine(Lang.SchtasksDelText2);
      this._schtasksWinStatus = false;
      this._schtasksOffStatus = false;
      this.Scheduler = false;
      this.Button29.Enabled = true;
      this.Button30.Enabled = false;
      this.Button31.Enabled = false;
    }

    private int GenerateRnd(int min, int max)
    {
      VBMath.Randomize();
      return checked ((int) Math.Round(Math.Floor(unchecked ((double) checked (max - min + 1) * (double) VBMath.Rnd()))) + min);
    }

    private string GeneratePid()
    {
      string str1 = "";
      string str2 = "";
      bool flag = false;
      string str3;
      string str4;
      if (this.GenerateRnd(0, 1) == 1)
      {
        str3 = "55041-";
        str4 = "7601.0000-";
      }
      else
      {
        str3 = "05426-";
        str1 = "00206-";
        str2 = "152-";
        str4 = "9200.0000-";
        flag = true;
      }
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Windows", false), (object) !flag)))
      {
        str1 = new string[3]{ "00206-", "00168-", "00172-" }[this.GenerateRnd(0, 2)];
        str2 = Conversions.ToString(this.GenerateRnd(199, 201)) + "-";
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Office 2010", false))
      {
        str1 = "00096-";
        str2 = Conversions.ToString(this.GenerateRnd(152, 201)) + "-";
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Office 2013/16", false))
      {
        str1 = "00206-";
        str2 = "234-";
      }
      string str5 = (Conversions.ToString(this.GenerateRnd(100, 999999)) + "-").PadLeft(7, '0');
      string str6 = "03-";
      string str7 = new string[4]
      {
        "1033-",
        "1049-",
        "1274-",
        "1031-"
      }[this.GenerateRnd(0, 3)];
      int rnd = this.GenerateRnd(2012, 2015);
      string str8 = (Conversions.ToString(rnd != 2015 ? this.GenerateRnd(285, 365) : this.GenerateRnd(1, 250)) + Conversions.ToString(rnd)).PadLeft(7, '0');
      return str3 + str1 + str2 + str5 + str6 + str7 + str4 + str8;
    }

    private void EnableAddSettings()
    {
      this.GroupBox11.Text = Lang.GroupBoxText11;
      this.ComboBox8.Show();
      this.Button8.Hide();
      this.Button10.Show();
      this.Button10.Text = Lang.ButtonText82;
      this.ToolTip1.SetToolTip((Control) this.Button8, Lang.ToolTipButton82);
      this.GroupBox7.Show();
    }

    private void CheckKmsService()
    {
      KmSservice.SetKmsServiceName(this.KmsServerServiceName);
      int num = this.IsServiceExist(this.KmsServerServiceName) ? 1 : 0;
      this._kmsServicePathExe = Application.StartupPath + this._kmsAutoFileList[2];
      this._kmsServicePathLog = Strings.Replace(this._kmsServicePathExe, this._kmsAutoFileList[2], this._kmsAutoFileList[5], 1, -1, CompareMethod.Binary);
      if (num == 0)
        return;
      Interaction.Shell(this.SysPath + "sc start " + this.KmsServerServiceName, AppWinStyle.Hide, true, -1);
      this.KmsFlag = "KMS";
      this.MyPrintLine(Lang.KmsExist);
      KmSservice.GetCurrentKmsParameters(ref this._currentParameters);
      if (Operators.CompareString(this._currentParameters.Port, "", false) == 0)
        this._currentParameters.Port = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.WinPid, "", false) == 0)
        this._currentParameters.WinPid = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.O14Pid, "", false) == 0)
        this._currentParameters.O14Pid = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.O15Pid, "", false) == 0)
        this._currentParameters.O15Pid = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.Ai, "", false) == 0)
        this._currentParameters.Ai = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.Ri, "", false) == 0)
        this._currentParameters.Ri = Lang.DefaultTxt;
      if (Operators.CompareString(this._currentParameters.Hwid, "", false) == 0)
        this._currentParameters.Hwid = Lang.HwidDefaulttTxt;
      this._kmsServicePathExe = this._currentParameters.ServiceExe;
      this._kmsServicePathLog = Strings.Replace(this._kmsServicePathExe, this._kmsAutoFileList[2], this._kmsAutoFileList[5], 1, -1, CompareMethod.Binary);
      if (this._cmDlineExist)
        return;
      if (this._professional)
      {
        this.MyPrintLine(Lang.Executable + this._currentParameters.ServiceExe);
        this.MyPrintLine("Port                       : " + this._currentParameters.Port);
        this.MyPrintLine("Windows PID        : " + this._currentParameters.WinPid);
        this.MyPrintLine("Office 2010 PID    : " + this._currentParameters.O14Pid);
        this.MyPrintLine("Office 2013 PID    : " + this._currentParameters.O15Pid);
        this.MyPrintLine("Activation Interval : " + this._currentParameters.Ai);
        this.MyPrintLine("Renewal Interval   : " + this._currentParameters.Ri);
        if (this._currentParameters.KillProcessOnPort)
          this.MyPrintLine("Kill Process on port: Enabled");
        else
          this.MyPrintLine("Kill Process on port: Disabled");
        if (this._currentParameters.LogMode)
          this.MyPrintLine("Log File                 : Enabled");
        else
          this.MyPrintLine("Log File                 : Disabled");
        if (Operators.CompareString(this._currentParameters.Hwid, "", false) != 0)
          this.MyPrintLine("Hwid                      : " + this._currentParameters.Hwid);
        else
          this.MyPrintLine("Hwid                      : Default");
      }
      this._winPid = Strings.Trim(this.ComboBox1.Text);
      this._off2010Pid = Strings.Trim(this.ComboBox6.Text);
      this._off2013Pid = Strings.Trim(this.ComboBox2.Text);
      this.MyPrintLine(this._razdelitel);
      bool flag = false;
      if (Operators.CompareString(this._currentParameters.Hwid, Lang.DefaultTxt, false) == 0 & Operators.CompareString(this._hwid, Lang.HwidDefaulttTxt, false) == 0)
        flag = false;
      else if (Operators.CompareString(this._currentParameters.Hwid, this._hwid, false) != 0)
      {
        flag = true;
        this.MessageReinstallKms();
      }
      if (!(((uint) Operators.CompareString(this._currentParameters.Port, this._port, false) > 0U | (uint) Operators.CompareString(this._currentParameters.WinPid, this._winPid, false) > 0U | (uint) Operators.CompareString(this._currentParameters.O14Pid, this._off2010Pid, false) > 0U | (uint) Operators.CompareString(this._currentParameters.O15Pid, this._off2013Pid, false) > 0U | (uint) Operators.CompareString(this._currentParameters.Ai, this._sai, false) > 0U | (uint) Operators.CompareString(this._currentParameters.Ri, this._sri, false) > 0U | this._currentParameters.LogMode != this.CheckBoxLog.Checked | this._currentParameters.KillProcessOnPort != this.CheckBoxKP.Checked | this._currentParameters.LogModeIp != this.CheckBoxIP.Checked) & !flag))
        return;
      this.MessageReinstallKms();
    }

    private void Intro()
    {
      int num1 = 0;
      do
      {
        this.MyPrintLine("");
        Thread.Sleep(20);
        checked { ++num1; }
      }
      while (num1 <= 8);
      Thread.Sleep(500);
      this.MyPrintLine("                                      " + Lang.LabelText7);
      this.MyPrintLine(Lang.Presents);
      this.MyPrintLine("");
      this.MyPrintLine("                                              http://forum.ru-board.com");
      int num2 = 0;
      do
      {
        this.MyPrintLine("");
        Thread.Sleep(100);
        checked { ++num2; }
      }
      while (num2 <= 3);
      Thread.Sleep(3000);
      this.MyPrintLine("clear");
    }

    private int StartKmsServer()
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = "start " + this.KmsServerServiceName;
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_10;
label_9:
        num4 = 10;
        num2 = Information.Err().Number;
        goto label_25;
label_10:
        num4 = 12;
        process.WaitForExit();
label_11:
        num4 = 13;
        if (Information.Err().Number == 0)
          goto label_13;
label_12:
        num4 = 14;
        num2 = Information.Err().Number;
        goto label_25;
label_13:
        num4 = 16;
        int exitCode = process.ExitCode;
label_14:
        num4 = 17;
        process.Close();
label_15:
        num4 = 18;
        if (Information.Err().Number == 0)
          goto label_17;
label_16:
        num4 = 19;
        num2 = Information.Err().Number;
        goto label_25;
label_17:
        num4 = 21;
        if (exitCode == 0)
          goto label_19;
label_18:
        num2 = exitCode;
        goto label_25;
label_19:
        num4 = 24;
        num2 = 0;
        goto label_25;
label_21:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
              case 15:
              case 20:
              case 23:
              case 25:
                goto label_25;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 16:
                goto label_13;
              case 17:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 21:
                goto label_17;
              case 22:
                goto label_18;
              case 24:
                goto label_19;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_21;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_25:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private int StopKmsServer()
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = "stop " + this.KmsServerServiceName;
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_10;
label_9:
        num4 = 10;
        num2 = Information.Err().Number;
        goto label_25;
label_10:
        num4 = 12;
        process.WaitForExit();
label_11:
        num4 = 13;
        if (Information.Err().Number == 0)
          goto label_13;
label_12:
        num4 = 14;
        num2 = Information.Err().Number;
        goto label_25;
label_13:
        num4 = 16;
        int exitCode = process.ExitCode;
label_14:
        num4 = 17;
        process.Close();
label_15:
        num4 = 18;
        if (Information.Err().Number == 0)
          goto label_17;
label_16:
        num4 = 19;
        num2 = Information.Err().Number;
        goto label_25;
label_17:
        num4 = 21;
        if (exitCode == 0)
          goto label_19;
label_18:
        num2 = exitCode;
        goto label_25;
label_19:
        num4 = 24;
        num2 = 0;
        goto label_25;
label_21:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
              case 15:
              case 20:
              case 23:
              case 25:
                goto label_25;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 16:
                goto label_13;
              case 17:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 21:
                goto label_17;
              case 22:
                goto label_18;
              case 24:
                goto label_19;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_21;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_25:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private int DeleteKmsServer()
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = "delete " + this.KmsServerServiceName;
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_10;
label_9:
        num4 = 10;
        num2 = Information.Err().Number;
        goto label_25;
label_10:
        num4 = 12;
        process.WaitForExit();
label_11:
        num4 = 13;
        if (Information.Err().Number == 0)
          goto label_13;
label_12:
        num4 = 14;
        num2 = Information.Err().Number;
        goto label_25;
label_13:
        num4 = 16;
        int exitCode = process.ExitCode;
label_14:
        num4 = 17;
        process.Close();
label_15:
        num4 = 18;
        if (Information.Err().Number == 0)
          goto label_17;
label_16:
        num4 = 19;
        num2 = Information.Err().Number;
        goto label_25;
label_17:
        num4 = 21;
        if (exitCode == 0)
          goto label_19;
label_18:
        num2 = exitCode;
        goto label_25;
label_19:
        num4 = 24;
        num2 = 0;
        goto label_25;
label_21:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
              case 15:
              case 20:
              case 23:
              case 25:
                goto label_25;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 16:
                goto label_13;
              case 17:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 21:
                goto label_17;
              case 22:
                goto label_18;
              case 24:
                goto label_19;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_21;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_25:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public int StartProcessHide(string exeName, string exeArgument, bool wait)
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = exeName;
label_3:
        num4 = 4;
        process.StartInfo.Arguments = exeArgument;
label_4:
        num4 = 5;
        process.StartInfo.CreateNoWindow = true;
label_5:
        num4 = 6;
        process.StartInfo.UseShellExecute = false;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_11;
label_9:
        num4 = 10;
        this.MyPrintLine(exeName + " " + Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_10:
        num4 = 11;
        num2 = Information.Err().Number;
        goto label_26;
label_11:
        num4 = 13;
        if (!wait)
          goto label_26;
label_12:
        num4 = 14;
        int num5 = 0;
        goto label_17;
label_13:
        num4 = 16;
        checked { ++num5; }
label_14:
        num4 = 17;
        if (num5 <= 1000)
          goto label_17;
label_15:
        num4 = 18;
        Application.DoEvents();
label_16:
        num4 = 19;
        num5 = 0;
label_17:
        num4 = 15;
        if (!process.HasExited)
          goto label_13;
label_18:
        num4 = 21;
        num2 = process.ExitCode;
label_19:
        num4 = 22;
        process.Close();
label_20:
        num4 = 23;
        process.Dispose();
        goto label_26;
label_22:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num6 = num3 + 1;
            num3 = 0;
            switch (num6)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
              case 24:
                goto label_26;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 15:
              case 20:
                goto label_17;
              case 16:
                goto label_13;
              case 17:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 21:
                goto label_18;
              case 22:
                goto label_19;
              case 23:
                goto label_20;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_22;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_26:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private int GenuineStateCheck()
    {
      int genuineState = 200;
      try
      {
        Guid slid = new Guid("55c92734-d682-4d71-983e-d6ec3f16059f");
        int num = (int) Form1.SLIsGenuineLocal(ref slid, ref genuineState, 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
      return genuineState;
    }

    private object CheckWindowsVersion()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      this._winVersion = Conversions.ToString(registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false).GetValue("ProductName"));
      registryKey.Close();
      return (object) true;
    }

    private string OpenFolderDialog(string type)
    {
      string str = "";
      if (Operators.CompareString(type, "save", false) == 0)
      {
        this._openfolder.Description = Lang.FolderforSaveTxt;
        this._openfolder.ShowNewFolderButton = true;
      }
      if (Operators.CompareString(type, "restore", false) == 0)
      {
        this._openfolder.Description = Lang.FolderforRestoreTxt;
        this._openfolder.ShowNewFolderButton = false;
      }
      if (this._openfolder.ShowDialog() == DialogResult.OK)
        str = this._openfolder.SelectedPath;
      return str;
    }

    private int ActivationBackupWin81(string folderToSave)
    {
      Interaction.Shell("net stop sppsvc /y", AppWinStyle.Hide, true, -1);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      this.DelDir(folderToSave);
      Interaction.Shell("cmd /c md \"" + folderToSave + "\"", AppWinStyle.Hide, true, -1);
      Interaction.Shell("cmd /c md \"" + folderToSave + "\\store\\2.0\"", AppWinStyle.Hide, true, -1);
      File.Copy(this.SysPath + "spp\\store\\2.0\\tokens.dat", folderToSave + "\\store\\2.0\\tokens.dat");
      File.Copy(this.SysPath + "spp\\store\\2.0\\data.dat", folderToSave + "\\store\\2.0\\data.dat");
      File.SetAttributes(folderToSave + "\\store\\2.0\\tokens.dat", FileAttributes.Normal);
      File.SetAttributes(folderToSave + "\\store\\2.0\\data.dat", FileAttributes.Normal);
      StreamWriter streamWriter = new StreamWriter(folderToSave + "\\sn_win81.ini", true, Encoding.GetEncoding("utf-8"));
      streamWriter.Write(Strings.Trim(this._myKey) + "\r\n");
      streamWriter.Close();
      if (this._saveOffice2013Act)
        this._SaveOfficeKey(folderToSave);
      Interaction.Shell("sc.exe start sppsvc", AppWinStyle.Hide, true, -1);
      int num;
      return num;
    }

    private object _SaveOfficeKey(string folderToSave)
    {
      object maxValue = (object) (int) byte.MaxValue;
      object obj;
      if (Operators.CompareString(this.MyOfficeKey, "", false) != 0 && Conversions.ToInteger(this.CheckKeyFormat(this.MyOfficeKey, false)) == 0)
      {
        string str = Interaction.InputBox(Lang.YourOfficeKeySaveTxt + "\r\n" + Lang.YourOfficeKeySaveBackupTxt + "\r\n" + this.MyOfficeKey, Lang.MessageOfficeKeySaveBackupTxt, "", -1, -1);
        if (Operators.CompareString(str, "", false) != 0 && Conversions.ToInteger(this.CheckKeyFormat(str, true)) == 0)
          this.MyOfficeKey = str;
      }
      else
      {
        string str;
        do
        {
          str = Interaction.InputBox(Lang.YourOfficeKeySaveTxt + "\r\n" + Lang.YourOfficeKeySaveBackupTxt + "\r\n" + this.MyOfficeKey, Lang.MessageOfficeKeySaveBackupTxt, "", -1, -1);
          if (Operators.CompareString(str, "", false) == 0)
            goto label_11;
        }
        while (Conversions.ToInteger(this.CheckKeyFormat(str, true)) != 0);
        this.MyOfficeKey = str;
        goto label_6;
label_11:
        this.MyPrintLine(Lang.MessageNoOfficeKeyTxt);
        obj = (object) (int) byte.MaxValue;
        goto label_12;
      }
label_6:
      StreamWriter streamWriter1 = new StreamWriter(folderToSave + "\\sn_office.ini", true, Encoding.GetEncoding("utf-8"));
      streamWriter1.Write(Strings.Trim(this.MyOfficeKey) + "\r\n");
      streamWriter1.Close();
      while (true)
      {
        string str;
        do
        {
          str = Interaction.InputBox(Lang.YourOfficeVisioKeySaveTxt, Lang.MessageOfficeKeySaveBackupTxt, "", -1, -1);
          if (Operators.CompareString(str, "", false) == 0)
            goto label_10;
        }
        while (Conversions.ToInteger(this.CheckKeyFormat(str, true)) != 0);
        StreamWriter streamWriter2 = new StreamWriter(folderToSave + "\\sn_office.ini", true, Encoding.GetEncoding("utf-8"));
        streamWriter2.Write(Strings.Trim(str) + "\r\n");
        streamWriter2.Close();
        this.MyPrintLine(Lang.MessageOfficeKeyTxt + str);
      }
label_10:
      this.MyPrintLine(Lang.MessageOfficeKeyTxt + this.MyOfficeKey);
      obj = (object) 0;
label_12:
      return obj;
    }

    private int ActivationRestoreAll()
    {
      string Left1 = "";
      int num;
      if (MessageBox.Show(Lang.QuestionActivationRestoreTxt, Lang.QuestionActivationRestoreTitleTxt, MessageBoxButtons.YesNo) == DialogResult.No)
      {
        num = (int) byte.MaxValue;
      }
      else
      {
        this.TabControl1.SelectedTab = this.TabPage1;
        this.Refresh();
        string Left2 = this.OpenFolderDialog("restore");
        if (Operators.CompareString(Left2, "", false) != 0)
          this._userFolderToSave = Left2;
        if (File.Exists(this._userFolderToSave + "\\store\\data.dat") & File.Exists(this._userFolderToSave + "\\sn_win8.ini"))
          Left1 = "Win8";
        if (File.Exists(this._userFolderToSave + "\\store\\2.0\\data.dat") & File.Exists(this._userFolderToSave + "\\sn_win81.ini"))
          Left1 = "Win81";
        if (!File.Exists(this._userFolderToSave + "\\store\\data.dat") & File.Exists(this._userFolderToSave + "\\sn_win7.ini"))
          Left1 = "Win7";
        if (Operators.CompareString(Left1, "", false) != 0)
          this.MyPrintLine("- " + Lang.QuestionActivationRestoreTitleTxt + " ...");
        else
          this.MyPrintLine(Lang.ActivationRestoreFailedTxt);
        if (Operators.CompareString(Left1, "Win7", false) == 0)
          this.ActivationRestoreWin7(this._userFolderToSave);
        if (Operators.CompareString(Left1, "Win8", false) == 0)
          this.ActivationRestoreWin8(this._userFolderToSave);
        if (Operators.CompareString(Left1, "Win81", false) == 0)
          this.ActivationRestoreWin81(this._userFolderToSave);
        switch (this.GenuineStateCheck())
        {
          case 0:
            this.MyPrintLine(Lang.SystemActivateNoProblemTxt);
            goto case 222;
          case 222:
            num = 0;
            break;
          default:
            this.MyPrintLine(Lang.SystemActivateProblemTxt);
            goto case 222;
        }
      }
      return num;
    }

    private int ActivationRestoreWin8(string UserFolderToSave)
    {
      string[] strArray = new string[0];
      int num1;
      if (!File.Exists(this.SysPath + "spp\\store\\tokens.dat"))
      {
        num1 = (int) byte.MaxValue;
        int num2 = (int) MessageBox.Show(Lang.BackupWrongTxt, Lang.ErrortRestoreTxt);
        if (File.Exists(this.SysPath + "spp\\store\\2.0\\tokens.dat") && MessageBox.Show(Lang.RestoreWin8ToWin81Txt, Lang.QuestionActivationRestoreTitleTxt, MessageBoxButtons.YesNo) == DialogResult.Yes)
          this.ActivationRestoreWin8_81(UserFolderToSave);
        else
          this.MyPrintLine(Lang.ErrortRestore2Txt);
      }
      else
      {
        if (File.Exists(UserFolderToSave + "\\sn_win8.ini"))
        {
          strArray = File.ReadAllLines(UserFolderToSave + "\\sn_win8.ini");
          this.MyPrintLine(Lang.BackupKeyTxt + strArray[0]);
        }
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.StartProcessHide("net", "stop sppsvc /y", true);
        Process[] processesByName = Process.GetProcessesByName("sppsvc");
        int index = 0;
        while (index < processesByName.Length)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        if (File.Exists(this.SysPath + "spp\\store\\data.dat"))
        {
          File.SetAttributes(this.SysPath + "spp\\store\\data.dat", FileAttributes.Normal);
          Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\data.dat\"", AppWinStyle.Hide, true, -1);
        }
        if (File.Exists(this.SysPath + "spp\\store\\tokens.dat"))
        {
          File.SetAttributes(this.SysPath + "spp\\store\\tokens.dat", FileAttributes.Normal);
          Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\tokens.dat\"", AppWinStyle.Hide, true, -1);
        }
        File.Copy(UserFolderToSave + "\\store\\tokens.dat", this.SysPath + "spp\\store\\tokens.dat");
        File.Copy(UserFolderToSave + "\\store\\data.dat", this.SysPath + "spp\\store\\data.dat");
        File.SetAttributes(this.SysPath + "spp\\store\\data.dat", FileAttributes.Hidden);
        this.StartProcessHide("sc.exe", "start sppsvc", true);
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.ActivationRestoreOffice(UserFolderToSave);
        this.MyPrintLine(Lang.RestoreCompleteTxt);
        int num2;
        num1 = num2;
      }
      return num1;
    }

    private object InstallAnyWindowsKey(string backUpKey)
    {
      int num;
      if (Operators.CompareString(backUpKey, "", false) != 0)
      {
        this.OwnKeyInstallNoDialog = true;
        this.OwnKeyInstallNoDialogMyKey = true;
        this.OwnKeyInstallNoDialogKey = Strings.Trim(backUpKey);
        num = WmIfunctions.InstallGvlk((byte) 1, (byte) 7);
        this.OwnKeyInstallNoDialog = false;
        this.OwnKeyInstallNoDialogMyKey = false;
        this.OwnKeyInstallNoDialogKey = "";
        if (num == 0)
          this.MyPrintLine(this._razdelitel);
      }
      return (object) num;
    }

    private void ShowTextBoxandButtonStatusBackupSystem()
    {
      int num1 = File.Exists(Application.StartupPath + "\\Backup\\Windows\\sn_win8.ini") | File.Exists(Application.StartupPath + "\\Backup\\Windows\\sn_win81.ini") | File.Exists(Application.StartupPath + "\\Backup\\Windows\\sn_win7.ini") ? 1 : 0;
      File.Exists(Application.StartupPath + "\\Backup\\Office\\sn_office.ini");
      int num2 = File.Exists(Application.StartupPath + "\\Backup\\Windows\\store\\tokens.dat") | File.Exists(Application.StartupPath + "\\Backup\\Windows\\store\\2.0\\tokens.dat") | File.Exists(Application.StartupPath + "\\Backup\\Windows\\tokens.dat") ? 1 : 0;
      int num3 = File.Exists(Application.StartupPath + "\\Backup\\Office\\store\\tokens.dat") | File.Exists(Application.StartupPath + "\\Backup\\Office\\store\\2.0\\tokens.dat") | File.Exists(Application.StartupPath + "\\Backup\\Office\\tokens.dat") ? 1 : 0;
    }

    private int ActivationBackupWin7(string folderToSave)
    {
      Interaction.Shell("net stop sppsvc /y", AppWinStyle.Hide, true, -1);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      this.DelDir(folderToSave);
      Interaction.Shell("cmd /c md \"" + folderToSave + "\"", AppWinStyle.Hide, true, -1);
      File.Copy(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat", folderToSave + "\\tokens.dat");
      File.SetAttributes(folderToSave + "\\tokens.dat", FileAttributes.Normal);
      StreamWriter streamWriter = new StreamWriter(folderToSave + "\\sn_win7.ini", true, Encoding.GetEncoding("utf-8"));
      streamWriter.Write(Strings.Trim(this._myKey) + "\r\n");
      streamWriter.Close();
      Interaction.Shell("sc.exe start sppsvc", AppWinStyle.Hide, true, -1);
      int num;
      return num;
    }

    private int ActivationBackupWin8(string folderToSave)
    {
      Interaction.Shell("net stop sppsvc /y", AppWinStyle.Hide, true, -1);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      this.DelDir(folderToSave);
      Interaction.Shell("cmd /c md \"" + folderToSave + "\"", AppWinStyle.Hide, true, -1);
      Interaction.Shell("cmd /c md \"" + folderToSave + "\\store\"", AppWinStyle.Hide, true, -1);
      File.Copy(this.SysPath + "spp\\store\\tokens.dat", folderToSave + "\\store\\tokens.dat");
      File.Copy(this.SysPath + "spp\\store\\data.dat", folderToSave + "\\store\\data.dat");
      File.SetAttributes(folderToSave + "\\store\\tokens.dat", FileAttributes.Normal);
      File.SetAttributes(folderToSave + "\\store\\data.dat", FileAttributes.Normal);
      StreamWriter streamWriter = new StreamWriter(folderToSave + "\\sn_win8.ini", true, Encoding.GetEncoding("utf-8"));
      streamWriter.Write(Strings.Trim(this._myKey) + "\r\n");
      streamWriter.Close();
      if (this._saveOffice2013Act)
        this._SaveOfficeKey(folderToSave);
      Interaction.Shell("sc.exe start sppsvc", AppWinStyle.Hide, true, -1);
      int num;
      return num;
    }

    private int ActivationRestoreWin81(string UserFolderToSave)
    {
      string[] strArray = new string[0];
      int num1;
      if (!File.Exists(this.SysPath + "spp\\store\\2.0\\tokens.dat"))
      {
        num1 = (int) byte.MaxValue;
        int num2 = (int) MessageBox.Show(Lang.BackupWrongTxt, Lang.ErrortRestoreTxt);
        this.MyPrintLine(Lang.ErrortRestore2Txt);
      }
      else
      {
        if (File.Exists(UserFolderToSave + "\\sn_win81.ini"))
        {
          strArray = File.ReadAllLines(UserFolderToSave + "\\sn_win81.ini");
          this.MyPrintLine(Lang.BackupKeyTxt + strArray[0]);
        }
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.StartProcessHide("net", "stop sppsvc /y", true);
        Process[] processesByName = Process.GetProcessesByName("sppsvc");
        int index = 0;
        while (index < processesByName.Length)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        if (File.Exists(this.SysPath + "spp\\store\\2.0\\data.dat"))
          File.SetAttributes(this.SysPath + "spp\\store\\2.0\\data.dat", FileAttributes.Normal);
        if (File.Exists(this.SysPath + "spp\\store\\2.0\\tokens.dat"))
          File.SetAttributes(this.SysPath + "spp\\store\\2.0\\tokens.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\tokens.dat\"", AppWinStyle.Hide, true, -1);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\data.dat\"", AppWinStyle.Hide, true, -1);
        File.Copy(UserFolderToSave + "\\store\\2.0\\tokens.dat", this.SysPath + "spp\\store\\2.0\\tokens.dat");
        File.Copy(UserFolderToSave + "\\store\\2.0\\data.dat", this.SysPath + "spp\\store\\2.0\\data.dat");
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\data.dat", FileAttributes.Hidden);
        this.StartProcessHide("sc.exe", "start sppsvc", true);
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.ActivationRestoreOffice(UserFolderToSave);
        this.MyPrintLine(Lang.RestoreCompleteTxt);
        int num2;
        num1 = num2;
      }
      return num1;
    }

    private int ActivationRestoreWin8_81(string UserFolderToSave)
    {
      string[] strArray = new string[0];
      if (File.Exists(UserFolderToSave + "\\sn_win8.ini"))
      {
        strArray = File.ReadAllLines(UserFolderToSave + "\\sn_win8.ini");
        this.MyPrintLine(Lang.BackupKeyTxt + strArray[0]);
      }
      if (Operators.CompareString(strArray[0], "", false) != 0)
        this.InstallAnyWindowsKey(strArray[0]);
      this.StartProcessHide("net", "stop sppsvc /y", true);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      if (File.Exists(this.SysPath + "spp\\store\\2.0\\data.dat"))
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\data.dat", FileAttributes.Normal);
      if (File.Exists(this.SysPath + "spp\\store\\2.0\\tokens.dat"))
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\tokens.dat", FileAttributes.Normal);
      Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\tokens.dat\"", AppWinStyle.Hide, true, -1);
      Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\data.dat\"", AppWinStyle.Hide, true, -1);
      File.Copy(UserFolderToSave + "\\store\\tokens.dat", this.SysPath + "spp\\store\\2.0\\tokens.dat");
      File.Copy(UserFolderToSave + "\\store\\data.dat", this.SysPath + "spp\\store\\2.0\\data.dat");
      File.SetAttributes(this.SysPath + "spp\\store\\2.0\\data.dat", FileAttributes.Hidden);
      this.StartProcessHide("sc.exe", "start sppsvc", true);
      if (Operators.CompareString(strArray[0], "", false) != 0)
        this.InstallAnyWindowsKey(strArray[0]);
      this.ActivationRestoreOffice(UserFolderToSave);
      this.MyPrintLine(Lang.RestoreCompleteTxt);
      int num;
      return num;
    }

    private int ActivationRestoreWin7(string UserFolderToSave)
    {
      string[] strArray = new string[0];
      int num1;
      if (!File.Exists(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat"))
      {
        num1 = (int) byte.MaxValue;
        int num2 = (int) MessageBox.Show(Lang.BackupWrongTxt, Lang.ErrortRestoreTxt);
        this.MyPrintLine(Lang.ErrortRestore2Txt);
      }
      else
      {
        if (File.Exists(UserFolderToSave + "\\sn_win7.ini"))
        {
          strArray = File.ReadAllLines(UserFolderToSave + "\\sn_win7.ini");
          this.MyPrintLine(Lang.BackupKeyTxt + strArray[0]);
        }
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.StartProcessHide("net", "stop sppsvc /y", true);
        Process[] processesByName = Process.GetProcessesByName("sppsvc");
        int index = 0;
        while (index < processesByName.Length)
        {
          processesByName[index].Kill();
          checked { ++index; }
        }
        if (File.Exists(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat"))
          File.SetAttributes(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat\"", AppWinStyle.Hide, true, -1);
        File.Copy(UserFolderToSave + "\\tokens.dat", this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat");
        this.StartProcessHide("sc.exe", "start sppsvc", true);
        if (Operators.CompareString(strArray[0], "", false) != 0)
          this.InstallAnyWindowsKey(strArray[0]);
        this.MyPrintLine(Lang.RestoreCompleteTxt);
        int num2;
        num1 = num2;
      }
      return num1;
    }

    private object ActivationRestoreOffice(string UserFolderToSave)
    {
      if (File.Exists(UserFolderToSave + "\\sn_office.ini"))
      {
        string[] strArray = File.ReadAllLines(UserFolderToSave + "\\sn_office.ini");
        int num = checked (strArray.Length - 1);
        int index = 0;
        while (index <= num)
        {
          this.MyPrintLine(Lang.BackupOfficeKeyTxt + Conversions.ToString(checked (index + 1)) + ": " + strArray[index]);
          this.InstallAnyWindowsKey(strArray[index]);
          checked { ++index; }
        }
      }
      return (object) 0;
    }

    public string GetProductKey(string keyPath, string valueName)
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      if (Information.Err().Number != 0)
      {
        this.MyPrintLine("Error " + Strings.LCase(Conversion.Hex(Information.Err().Number)));
        string str = "ERROR " + Conversions.ToString(Information.Err().Number);
      }
      object objectValue = RuntimeHelpers.GetObjectValue(registryKey.OpenSubKey(keyPath, true).GetValue(valueName));
      registryKey.Close();
      this._hexBufData = new byte[0];
      this._hexBufData = ((IEnumerable<byte>) this._hexBufData).Concat<byte>((IEnumerable<byte>) objectValue).ToArray<byte>();
      return Conversions.ToString(this.ConvertToKey(RuntimeHelpers.GetObjectValue(objectValue)));
    }

    private object ConvertToKey(object regKey)
    {
      string str1 = "";
      string str2 = Conversions.ToString(Operators.AndObject(Operators.IntDivideObject(NewLateBinding.LateIndexGet(regKey, new object[1]
      {
        (object) 66
      }, (string[]) null), (object) 6), (object) 1));
      NewLateBinding.LateIndexSet(regKey, new object[2]
      {
        (object) 66,
        Operators.OrObject(Operators.AndObject(NewLateBinding.LateIndexGet(regKey, new object[1]
        {
          (object) 66
        }, (string[]) null), (object) 247), (object) checked (Conversions.ToLong(str2) & 2L * 4L))
      }, (string[]) null);
      int num1 = 24;
      string str3 = "BCDFGHJKMPQRTVWXY2346789";
      int Length;
      do
      {
        int num2 = 0;
        int num3 = 14;
        do
        {
          int num4 = checked (num2 * 256);
          int integer = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateIndexGet(regKey, new object[1]
          {
            (object) checked (num3 + 52)
          }, (string[]) null), (object) num4));
          NewLateBinding.LateIndexSet(regKey, new object[2]
          {
            (object) checked (num3 + 52),
            (object) (integer / 24)
          }, (string[]) null);
          num2 = integer % 24;
          checked { --num3; }
        }
        while (num3 >= 0);
        checked { --num1; }
        str1 = Strings.Mid(str3, checked (num2 + 1), 1) + str1;
        Length = num2;
      }
      while (num1 >= 0);
      if (Conversions.ToDouble(str2) == 1.0)
      {
        string Find = Strings.Mid(str1, 2, Length);
        string str4 = "N";
        str1 = Strings.Replace(str1, Find, Find + str4, 2, 1, CompareMethod.Binary);
        if (Length == 0)
          str1 = str4 + str1;
      }
      return (object) (Strings.Mid(str1, 1, 5) + "-" + Strings.Mid(str1, 6, 5) + "-" + Strings.Mid(str1, 11, 5) + "-" + Strings.Mid(str1, 16, 5) + "-" + Strings.Mid(str1, 21, 5));
    }

    private object Show_HideProfessionalVersion()
    {
      if (this._professional)
      {
        this.TabPage4.Parent = (Control) null;
        this.TabPage6.Parent = (Control) null;
        this.TabControl1.Controls.Add((Control) this.TabPage2);
        this.TabControl1.Controls.Add((Control) this.TabPage3);
        this.TabControl1.Controls.Add((Control) this.TabPage6);
        this.TabControl1.Controls.Add((Control) this.TabPage4);
        this.Refresh();
        this.ShowActivationMenu();
        this.ShowInformationMenu();
        this.MyPrintLine(Lang.AdvancedMode);
        this.MyPrintLine(this._razdelitel);
        this.Button39.Text = Lang.NormalMode;
      }
      else
      {
        this.TabPage2.Parent = (Control) null;
        this.TabPage3.Parent = (Control) null;
        this.TabPage6.Parent = (Control) null;
        this.Refresh();
        this.HideActivationMenu();
        this.HideInformationMenu();
        this.MyPrintLine(Lang.AdvancedModeDisable);
        this.MyPrintLine(this._razdelitel);
        this.Button39.Text = Lang.ProfMode;
      }
      this.TabControl1.SelectedTab = this.TabPage1;
      this.Refresh();
      return (object) 0;
    }

    private object Show_HideProfessionalVersionInit()
    {
      if (this._professional)
      {
        this.ShowActivationMenu();
        this.ShowInformationMenu();
      }
      else
      {
        this.TabPage2.Parent = (Control) null;
        this.TabPage3.Parent = (Control) null;
        this.TabPage6.Parent = (Control) null;
        this.HideActivationMenu();
        this.HideInformationMenu();
      }
      return (object) 0;
    }

    private void Enable_Disable_Professional_mode()
    {
      if (!this._professional)
      {
        if (MessageBox.Show(Lang.Message4, Lang.Caption2, MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this._professional = true;
        this.Show_HideProfessionalVersion();
      }
      else
      {
        this._professional = false;
        this._schtasksWinStatus = false;
        this._schtasksOffStatus = false;
        this.Show_HideProfessionalVersion();
      }
    }

    private string FindKeyWin_Office(string[] KeyString, string product)
    {
      int num1 = checked (KeyString.Length - 1);
      int index = 0;
      string str1;
      while (index <= num1)
      {
        if (!KeyString[index].StartsWith(product))
        {
          checked { ++index; }
        }
        else
        {
          string str2 = KeyString[index];
          int num2 = str2.IndexOf(",");
          string str3 = str2.Remove(0, checked (num2 + 1));
          int num3 = str3.IndexOf(",");
          string str4 = str3.Remove(0, checked (num3 + 1));
          if (str4.IndexOf(",") != 29)
          {
            str1 = "";
            goto label_8;
          }
          else
          {
            string str5 = str4.Remove(29);
            str1 = Operators.CompareString(Strings.Mid(str5, 1, 7), "Product", false) != 0 ? str5 : "";
            goto label_8;
          }
        }
      }
      str1 = "";
label_8:
      return str1;
    }

    private void Label6_Click(object sender, EventArgs e)
    {
      if (!this._professional)
        return;
      this.CheckKmsService();
    }

    private object ProduKeyInfo()
    {
      FileSystem.ChDir(this.Tempdir);
      while (!File.Exists(this.Tempdir + "\\pdk.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("pdk.dat", KMSAuto_Net.My.Resources.Resources.pdkutils, false);
        Application.DoEvents();
      }
      Interaction.Shell(this.SysPath + "cmd.exe /c pdk.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      this.DelFile("pdk.dat");
      FileSystem.ChDir(this.Tempdir + "\\PDK");
      object obj;
      if (File.Exists(this.Tempdir + "\\PDK" + this._kmsAutoFileList[3]))
      {
        this.StartProcessHide(this.Tempdir + "\\PDK" + this._kmsAutoFileList[3], "/nosavereg /IEKeys 0 /WindowsKeys 1  /OfficeKeys 1 /sort 3 /ExtractEdition 1 /stext \"" + this.Tempdir + "\\$.tmp\"", true);
        if (File.Exists(this.Tempdir + "\\$.tmp"))
        {
          this._keyString = File.ReadAllLines(this.Tempdir + "\\$.tmp");
          this.DelFile(this.Tempdir + "\\$.tmp");
        }
        if (Operators.CompareString(this._keyString[0], "", false) != 0)
        {
          this.MyPrintLine("====== ProduKey v1.80,  Copyright (c)  2005 - 2014 Nir Sofer ======");
          this.MyPrintLine("Product: " + this.ProductNameWin + ", EditionID: " + this._editionId);
          int num = checked (this._keyString.Length - 1);
          int index = 0;
          while (index <= num)
          {
            this.MyPrintLine(this._keyString[index]);
            checked { ++index; }
          }
        }
        FileSystem.ChDir(this.Tempdir);
        this.DelDir(this.Tempdir + "\\PDK");
        FileSystem.ChDir(Application.StartupPath);
        obj = (object) 0;
      }
      else
      {
        this.MyPrintLine("Error! The file pdk.dll is missing. ");
        obj = (object) (int) byte.MaxValue;
      }
      return obj;
    }

    private object ParseSettingProgSub(string[] saveParamProg, string inputArgument)
    {
      string[] strArray = saveParamProg;
      int index = 0;
      object obj;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        if (!str.ToLower().StartsWith(inputArgument))
        {
          checked { ++index; }
        }
        else
        {
          obj = (object) str.Remove(0, inputArgument.Length);
          goto label_6;
        }
      }
      obj = (object) "";
label_6:
      return obj;
    }

    private object ParseSettingProgCombo(string[] saveParamProg, string inputArgument)
    {
      int num = 0;
      string[] strArray = saveParamProg;
      int index = 0;
      object obj;
      while (index < strArray.Length)
      {
        if (!strArray[index].StartsWith(inputArgument))
        {
          checked { ++num; }
          checked { ++index; }
        }
        else
        {
          obj = (object) num;
          goto label_6;
        }
      }
      obj = (object) 0;
label_6:
      return obj;
    }

    private void LoadProgramSetting()
    {
      string[] saveParamProg;
      bool flag;
      if (File.Exists(Application.StartupPath + this._kmsAutoFileList[0]))
      {
        saveParamProg = File.ReadAllLines(Application.StartupPath + this._kmsAutoFileList[0]);
        flag = true;
      }
      else
      {
        if (File.Exists(this._localappdata + this._kmsAutoFileList[0]))
        {
          saveParamProg = File.ReadAllLines(this._localappdata + this._kmsAutoFileList[0]);
        }
        else
        {
          this.Create_INI_File();
          saveParamProg = File.ReadAllLines(this._localappdata + this._kmsAutoFileList[0]);
          this._showReadmeView = true;
        }
        this.DelFile(Application.StartupPath + this._kmsAutoFileList[0]);
        flag = false;
      }
      this.ChkBoxReset.Enabled = true;
      this.ChkBoxReset.Checked = false;
      this.TargetLang = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "language="));
      this._port = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "port="));
      if (Operators.CompareString(this._port, "", false) == 0)
        this._port = "1688";
      if (Conversions.ToInteger(this._port) < 1)
        this._port = "1688";
      this.NumericUpDown1.Value = new Decimal(Conversions.ToInteger(this._port));
      this._sai = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "ai="));
      if (Operators.CompareString(this._sai, "", false) == 0)
        this._sai = "43200";
      if (Conversions.ToInteger(this._sai) < 15)
        this._sai = "43200";
      this.NumericUpDown2.Value = new Decimal(Conversions.ToInteger(this._sai));
      this._sri = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "ri="));
      if (Operators.CompareString(this._sri, "", false) == 0)
        this._sri = "43200";
      if (Conversions.ToInteger(this._sri) < 15)
        this._sri = "43200";
      this.NumericUpDown3.Value = new Decimal(Conversions.ToInteger(this._sri));
      int integer1 = Conversions.ToInteger(this.ParseSettingProgCombo(saveParamProg, "[ComboBoxHost]"));
      this.ComboBox3.Items.Clear();
      this.ComboBox3.Items.Add((object) this._autoHostText);
      int num1 = checked (integer1 + 1);
      int num2 = checked (saveParamProg.Length - 1);
      int index1 = num1;
      while (index1 <= num2 && !(integer1 == 0 | Operators.CompareString(saveParamProg[index1], "", false) == 0 | saveParamProg[index1].Contains("[")))
      {
        this.ComboBox3.Items.Add((object) Strings.Trim(saveParamProg[index1]));
        checked { ++index1; }
      }
      int integer2 = Conversions.ToInteger(this.ParseSettingProgCombo(saveParamProg, "[ComboBoxWinePID]"));
      this.ComboBox1.Items.Clear();
      int num3 = checked (integer2 + 1);
      int num4 = checked (saveParamProg.Length - 1);
      int index2 = num3;
      while (index2 <= num4 && !(integer2 == 0 | Operators.CompareString(saveParamProg[index2], "", false) == 0 | saveParamProg[index2].Contains("[")))
      {
        this.ComboBox1.Items.Add((object) Strings.Trim(saveParamProg[index2]));
        checked { ++index2; }
      }
      int integer3 = Conversions.ToInteger(this.ParseSettingProgCombo(saveParamProg, "[ComboBoxOff10ePID]"));
      this.ComboBox6.Items.Clear();
      int num5 = checked (integer3 + 1);
      int num6 = checked (saveParamProg.Length - 1);
      int index3 = num5;
      while (index3 <= num6 && !(integer3 == 0 | Operators.CompareString(saveParamProg[index3], "", false) == 0 | saveParamProg[index3].Contains("[")))
      {
        this.ComboBox6.Items.Add((object) Strings.Trim(saveParamProg[index3]));
        checked { ++index3; }
      }
      int integer4 = Conversions.ToInteger(this.ParseSettingProgCombo(saveParamProg, "[ComboBoxOff13ePID]"));
      this.ComboBox2.Items.Clear();
      int num7 = checked (integer4 + 1);
      int num8 = checked (saveParamProg.Length - 1);
      int index4 = num7;
      while (index4 <= num8 && !(integer4 == 0 | Operators.CompareString(saveParamProg[index4], "", false) == 0 | saveParamProg[index4].Contains("[")))
      {
        this.ComboBox2.Items.Add((object) Strings.Trim(saveParamProg[index4]));
        checked { ++index4; }
      }
      int integer5 = Conversions.ToInteger(this.ParseSettingProgCombo(saveParamProg, "[ComboBoxHwid]"));
      this.ComboBoxHwid.Items.Clear();
      this.ComboBoxHwid.Items.Add((object) Lang.HwidDefaulttTxt);
      int num9 = checked (integer5 + 1);
      int num10 = checked (saveParamProg.Length - 1);
      int index5 = num9;
      while (index5 <= num10 && !(integer5 == 0 | Operators.CompareString(saveParamProg[index5], "", false) == 0 | saveParamProg[index5].Contains("[")))
      {
        this.ComboBoxHwid.Items.Add((object) Strings.Trim(saveParamProg[index5]));
        checked { ++index5; }
      }
      this._professional = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "professional=")), "yes", false) == 0;
      this._addFunctions = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "addfunctions=")), "yes", false) == 0;
      this._noLogo = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "nologo=")), "yes", false) == 0;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "logfile=")), "yes", false) == 0)
      {
        this._currentParameters.LogMode = true;
        this._logFile = true;
        this.CheckBoxLog.Checked = true;
      }
      else
      {
        this._currentParameters.LogMode = false;
        this._logFile = false;
        this.CheckBoxLog.Checked = false;
      }
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "logfileip=")), "yes", false) == 0)
      {
        this._currentParameters.LogModeIp = true;
        this._logFileIp = true;
        this.CheckBoxIP.Checked = true;
      }
      else
      {
        this._currentParameters.LogModeIp = false;
        this._logFileIp = false;
        this.CheckBoxIP.Checked = false;
      }
      this.CheckBoxKP.Checked = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "killprocessonport=")), "yes", false) == 0;
      this._schtasksWinStatus = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "taskwinstatus=")), "yes", false) == 0;
      this._schtasksOffStatus = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "taskoffstatus=")), "yes", false) == 0;
      string Left1 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "positionleft="));
      if (Operators.CompareString(Left1, "", false) != 0)
        this._positionLeft = Conversions.ToInteger(Left1);
      string Left2 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "positiontop="));
      if (Operators.CompareString(Left2, "", false) != 0)
        this._positionTop = Conversions.ToInteger(Left2);
      this._sounds = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "sounds=")), "yes", false) == 0;
      this._delKmsServer = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "delkmsserver=")), "yes", false) == 0;
      this._saveOffice2013Act = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "officeactivation=")), "yes", false) == 0;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "modetap=")), "yes", false) == 0)
      {
        this.RB3TAP.Checked = true;
        this.ModeTap = true;
        this._modeWd = false;
        this._modeAuto = false;
      }
      else
        this.RB3TAP.Checked = false;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "modewd=")), "yes", false) == 0)
      {
        this.RB2WD.Checked = true;
        this._modeWd = true;
        this.ModeTap = false;
        this._modeAuto = false;
      }
      else
        this.RB2WD.Checked = false;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "modehook=")), "yes", false) == 0)
      {
        this.RB5Hook.Checked = true;
        this._modeHook = true;
        this._modeWd = false;
        this.ModeTap = false;
        this._modeAuto = false;
        this._modeAutoNo = false;
        this.ComboBox3.Enabled = false;
      }
      else
      {
        this.RB5Hook.Checked = false;
        this._modeHook = false;
      }
      string Left3 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "hookmode="));
      if (Operators.CompareString(Left3, "0", false) == 0)
      {
        this.HookMode = 0;
        MyProject.Forms.HookSetting.RadioButton1.Enabled = true;
      }
      else if (Operators.CompareString(Left3, "1", false) == 0)
      {
        this.HookMode = 1;
        MyProject.Forms.HookSetting.RadioButton2.Enabled = true;
      }
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "modeauto=")), "yes", false) == 0)
      {
        this.RB1AUTO.Checked = true;
        this._modeAuto = true;
        this._modeAutoNo = false;
        this._modeWd = false;
        this.ModeTap = false;
        this._modeHook = false;
        this.ComboBox3.Enabled = false;
        string Left4 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "type="));
        this._type = Operators.CompareString(Left4, "", false) == 0 ? 0 : Conversions.ToInteger(Left4);
        string Left5 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "host="));
        if (Operators.CompareString(Left5, "", false) != 0)
        {
          this._autoModeHost = Left5;
          this._host = Left5;
        }
      }
      else
      {
        string Left4 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "host="));
        if (Operators.CompareString(Left4, "", false) != 0)
          this._host = Left4;
        this.RB1AUTO.Checked = false;
      }
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "noautomode=")), "yes", false) == 0)
      {
        this.RB4NOAuto.Checked = true;
        this._modeWd = false;
        this.ModeTap = false;
        this._modeAuto = false;
        this._modeAutoNo = true;
      }
      else
        this.RB4NOAuto.Checked = false;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "divertdel=")), "hard", false) == 0)
      {
        MyProject.Forms.WinDivertSettings.CheckBox1.Checked = true;
        this.WinDivertRemoveHard = true;
      }
      else
      {
        MyProject.Forms.WinDivertSettings.CheckBox1.Checked = false;
        this.WinDivertRemoveHard = false;
      }
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "autores=")), "yes", false) == 0)
      {
        MyProject.Forms.AutoMode.CheckBox1.Checked = true;
        this.AutoRes = true;
      }
      else
      {
        MyProject.Forms.AutoMode.CheckBox1.Checked = false;
        this.AutoRes = false;
      }
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "noautonokms=")), "yes", false) == 0)
      {
        MyProject.Forms.NoAutoSettings.CheckBox1.Checked = true;
        this.NoAutoNoKms = true;
      }
      else
      {
        MyProject.Forms.NoAutoSettings.CheckBox1.Checked = false;
        this.NoAutoNoKms = false;
      }
      this.TapType = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "taptype="));
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "usepgd=")), "yes", false) == 0)
      {
        MyProject.Forms.KmsSetting.CheckBox1.Checked = true;
        this.SetKmsProgramData = true;
      }
      else
      {
        MyProject.Forms.KmsSetting.CheckBox1.Checked = false;
        this.SetKmsProgramData = false;
      }
      MyProject.Forms.AutoMode.CheckBox5.Checked = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "lhost=")), "true", false) == 0;
      MyProject.Forms.AutoMode.CheckBox2.Checked = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "hook=")), "true", false) == 0;
      MyProject.Forms.AutoMode.CheckBox3.Checked = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "wdivert=")), "true", false) == 0;
      MyProject.Forms.AutoMode.CheckBox4.Checked = Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "tap=")), "true", false) == 0;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "saveiniinfolder=")), "yes", false) == 0)
      {
        this.CBox7IniFile.Checked = true;
        this.SaveInIinfolder = true;
      }
      else
      {
        this.CBox7IniFile.Checked = false;
        this.SaveInIinfolder = false;
        if (flag)
        {
          this.CBox7IniFile.Checked = true;
          this.SaveInIinfolder = true;
        }
      }
      string Left6 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "installkey="));
      if (Operators.CompareString(Left6, "true", false) == 0)
        this._instKey = true;
      else if (Operators.CompareString(Left6, "false", false) == 0)
        this._instKey = false;
      if (Operators.CompareString(Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "fakeip=")), "true", false) == 0)
      {
        this.CheckBoxFakeIP.Checked = true;
        this.TextBoxFakeIP.Enabled = true;
      }
      else
      {
        this.CheckBoxFakeIP.Checked = false;
        this.TextBoxFakeIP.Enabled = false;
      }
      string Left7 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "fakeipadress="));
      this.TextBoxFakeIP.Text = Operators.CompareString(Left7, "", false) == 0 ? "random" : Left7;
      string Left8 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index1="));
      if (Operators.CompareString(Left8, "", false) != 0)
        this._index1 = Conversions.ToInteger(Left8);
      string Left9 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index2="));
      if (Operators.CompareString(Left9, "", false) != 0)
        this._index2 = Conversions.ToInteger(Left9);
      string Left10 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index3="));
      if (Operators.CompareString(Left10, "", false) != 0)
        this._index3 = Conversions.ToInteger(Left10);
      string Left11 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index4="));
      if (Operators.CompareString(Left11, "", false) != 0)
        this._index4 = Conversions.ToInteger(Left11);
      string Left12 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index5="));
      if (Operators.CompareString(Left12, "", false) != 0)
        this._index5 = Conversions.ToInteger(Left12);
      string Left13 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index6="));
      if (Operators.CompareString(Left13, "", false) != 0)
        this._index6 = Conversions.ToInteger(Left13);
      string Left14 = Conversions.ToString(this.ParseSettingProgSub(saveParamProg, "index7="));
      if (Operators.CompareString(Left14, "", false) == 0)
        return;
      this._index7 = Conversions.ToInteger(Left14);
    }

    private object Create_INI_File()
    {
      string[] strArray1 = new string[63]
      {
        "[Configuration]",
        "Professional=no",
        "AddFunctions=no",
        "NoLogo=no",
        "LogFile=yes",
        "LogFileIP=yes",
        "KillProcessOnPort=yes",
        "PositionLeft=76",
        "PositionTop=49",
        "TaskWinStatus=no",
        "TaskOffStatus=no",
        "Sounds=yes",
        "DelKMSServer=yes",
        "OfficeActivation=no",
        "Port=1688",
        "AI=43200",
        "RI=43200",
        "ModeAuto=yes",
        "Host=127.0.0.2",
        "Type=0",
        "NoAutoMode=no",
        "ModeHook=no",
        "ModeWD=no",
        "ModeTAP=no",
        "DivertDel=hard",
        "LHost=true",
        "Hook=true",
        "WDivert=true",
        "TAP=true",
        "AutoRes=no",
        "NoAutoNoKMS=no",
        "TAPType=",
        "UsePgD=yes",
        "HookMode=0",
        "InstallKey=true",
        "fakeip=false",
        "Index1=0",
        "Index2=0",
        "Index3=0",
        "Index4=7",
        "Index5=0",
        "Index6=0",
        "Index7=0",
        "\r\n",
        "[ComboBoxHost]",
        "127.0.0.2",
        "10.3.0.222",
        "127.0.0.3",
        "\r\n",
        "[ComboBoxWinePID]",
        "RandomKMSPID",
        "05426-00206-152-074136-03-1049-9200.0000-0132014",
        "\r\n",
        "[ComboBoxOff10ePID]",
        "RandomKMSPID",
        "05426-00096-200-349822-03-1049-9200.0000-3202013",
        "\r\n",
        "[ComboBoxOff13ePID]",
        "RandomKMSPID",
        "05426-00206-234-321799-03-1049-9200.0000-3202013",
        "\r\n",
        "[ComboBoxHwid]",
        "\r\n"
      };
      Interaction.Shell("cmd /c md \"" + this._localappdata + "\"", AppWinStyle.Hide, true, -1);
      StreamWriter streamWriter = new StreamWriter(this._localappdata + this._kmsAutoFileList[0], true, Encoding.GetEncoding("utf-8"));
      string[] strArray2 = strArray1;
      int index = 0;
      while (index < strArray2.Length)
      {
        string str = strArray2[index];
        streamWriter.Write(str + "\r\n");
        checked { ++index; }
      }
      streamWriter.Close();
      return (object) 0;
    }

    private void SaveProgramSetting()
    {
      if (this._cdDvdRom)
        return;
      string str1 = "[Configuration]\r\n" + "Language=" + this.TargetLang + "\r\n";
      string str2 = !this._professional ? str1 + "Professional=no\r\n" : str1 + "Professional=yes\r\n";
      string str3 = !this._addFunctions ? str2 + "AddFunctions=no\r\n" : str2 + "AddFunctions=yes\r\n";
      string str4 = !this._noLogo ? str3 + "NoLogo=no\r\n" : str3 + "NoLogo=yes\r\n";
      string str5 = !this._logFile ? str4 + "LogFile=no\r\n" : str4 + "LogFile=yes\r\n";
      string str6 = !this._logFileIp ? str5 + "LogFileIP=no\r\n" : str5 + "LogFileIP=yes\r\n";
      string str7 = !this.CheckBoxKP.Checked ? str6 + "KillProcessOnPort=no\r\n" : str6 + "KillProcessOnPort=yes\r\n";
      if (this._positionLeft < -200)
        this._positionLeft = 200;
      if (this._positionTop < -200)
        this._positionTop = 200;
      string str8 = str7 + "PositionLeft=" + Conversions.ToString(this._positionLeft) + "\r\n" + "PositionTop=" + Conversions.ToString(this._positionTop) + "\r\n";
      string str9 = !this._schtasksWinStatus ? str8 + "TaskWinStatus=no\r\n" : str8 + "TaskWinStatus=yes\r\n";
      string str10 = !this._schtasksOffStatus ? str9 + "TaskOffStatus=no\r\n" : str9 + "TaskOffStatus=yes\r\n";
      string str11 = !this._sounds ? str10 + "Sounds=no\r\n" : str10 + "Sounds=yes\r\n";
      string str12 = !this._delKmsServer ? str11 + "DelKMSServer=no\r\n" : str11 + "DelKMSServer=yes\r\n";
      string str13 = (!this._saveOffice2013Act ? str12 + "OfficeActivation=no\r\n" : str12 + "OfficeActivation=yes\r\n") + "Port=" + Conversions.ToString(this.NumericUpDown1.Value) + "\r\n" + "AI=" + Conversions.ToString(this.NumericUpDown2.Value) + "\r\n" + "RI=" + Conversions.ToString(this.NumericUpDown3.Value) + "\r\n";
      string str14 = !this._modeAuto ? str13 + "Host=" + this._host + "\r\n" + "ModeAuto=no\r\n" : str13 + "ModeAuto=yes\r\n" + "Host=" + this._autoModeHost + "\r\n" + "Type=" + Conversions.ToString(this._type) + "\r\n";
      string str15 = !this._modeAutoNo ? str14 + "NoAutoMode=no\r\n" : str14 + "NoAutoMode=yes\r\n";
      string str16 = !this._modeHook ? str15 + "ModeHook=no\r\n" : str15 + "ModeHook=yes\r\n";
      string str17 = !this._modeWd ? str16 + "ModeWD=no\r\n" : str16 + "ModeWD=yes\r\n";
      string str18 = !this.ModeTap ? str17 + "ModeTAP=no\r\n" : str17 + "ModeTAP=yes\r\n";
      string str19 = !this.WinDivertRemoveHard ? str18 + "DivertDel=soft\r\n" : str18 + "DivertDel=hard\r\n";
      string str20 = !MyProject.Forms.AutoMode.CheckBox5.Checked ? str19 + "LHost=false\r\n" : str19 + "LHost=true\r\n";
      string str21 = !MyProject.Forms.AutoMode.CheckBox2.Checked ? str20 + "Hook=false\r\n" : str20 + "Hook=true\r\n";
      string str22 = !MyProject.Forms.AutoMode.CheckBox3.Checked ? str21 + "WDivert=false\r\n" : str21 + "WDivert=true\r\n";
      string str23 = !MyProject.Forms.AutoMode.CheckBox4.Checked ? str22 + "TAP=false\r\n" : str22 + "TAP=true\r\n";
      string str24 = !this.AutoRes ? str23 + "AutoRES=no\r\n" : str23 + "AutoRES=yes\r\n";
      string str25 = (!this.NoAutoNoKms ? str24 + "NoAutoNoKMS=no\r\n" : str24 + "NoAutoNoKMS=yes\r\n") + "TAPType=" + this.TapType + "\r\n";
      if (this.HookMode == 0)
        str25 += "HookMode=0\r\n";
      else if (this.HookMode == 1)
        str25 += "HookMode=1\r\n";
      string str26 = !this.SetKmsProgramData ? str25 + "UsePgD=no\r\n" : str25 + "UsePgD=yes\r\n";
      string str27 = !this.SaveInIinfolder ? str26 + "SaveINIinFolder=no\r\n" : str26 + "SaveINIinFolder=yes\r\n";
      string str28 = !this._instKey ? str27 + "InstallKey=false\r\n" : str27 + "InstallKey=true\r\n";
      string str29 = (!this.CheckBoxFakeIP.Checked ? str28 + "FAKEIP=false\r\n" : str28 + "FAKEIP=true\r\n") + "FAKEIPADRESS=" + this.TextBoxFakeIP.Text + "\r\n" + "Index1=" + Conversions.ToString(this._index1) + "\r\n" + "Index2=" + Conversions.ToString(this._index2) + "\r\n" + "Index3=" + Conversions.ToString(this._index3) + "\r\n" + "Index4=" + Conversions.ToString(this._index4) + "\r\n" + "Index5=" + Conversions.ToString(this._index5) + "\r\n" + "Index6=" + Conversions.ToString(this._index6) + "\r\n" + "Index7=" + Conversions.ToString(this._index7) + "\r\n" + "\r\n" + "\r\n" + "[ComboBoxHost]\r\n";
      try
      {
        foreach (object obj in this.ComboBox3.Items)
        {
          string Left = Conversions.ToString(obj);
          if (Operators.CompareString(Left, this._autoHostText, false) != 0)
            str29 = str29 + Left + "\r\n";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string str30 = str29 + "\r\n" + "[ComboBoxWinePID]\r\n";
      try
      {
        foreach (object obj in this.ComboBox1.Items)
        {
          string str31 = Conversions.ToString(obj);
          str30 = str30 + str31 + "\r\n";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string str32 = str30 + "\r\n" + "[ComboBoxOff10ePID]\r\n";
      try
      {
        foreach (object obj in this.ComboBox6.Items)
        {
          string str31 = Conversions.ToString(obj);
          str32 = str32 + str31 + "\r\n";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string str33 = str32 + "\r\n" + "[ComboBoxOff13ePID]\r\n";
      try
      {
        foreach (object obj in this.ComboBox2.Items)
        {
          string str31 = Conversions.ToString(obj);
          str33 = str33 + str31 + "\r\n";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string str34 = str33 + "\r\n" + "[ComboBoxHwid]\r\n";
      try
      {
        foreach (object obj in this.ComboBoxHwid.Items)
        {
          string Left = Conversions.ToString(obj);
          if (Operators.CompareString(Left, Lang.HwidDefaulttTxt, false) != 0)
            str34 = str34 + Left + "\r\n";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string str35 = str34 + "\r\n";
      string str36;
      if (this.SaveInIinfolder)
      {
        str36 = Application.StartupPath;
      }
      else
      {
        str36 = this._localappdata;
        if (!Directory.Exists(this._localappdata))
          Interaction.Shell("cmd /c md \"" + this._localappdata + "\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(str36 + this._kmsAutoFileList[0]))
        this.DelFile(str36 + this._kmsAutoFileList[0]);
      if (File.Exists(str36 + this._kmsAutoFileList[0]))
        this.DelFile(str36 + this._kmsAutoFileList[0]);
      StreamWriter streamWriter = new StreamWriter(str36 + this._kmsAutoFileList[0], true, Encoding.GetEncoding("utf-8"));
      streamWriter.Write(str35);
      streamWriter.Close();
    }

    private void HideActivationMenu()
    {
      this.Button3.Enabled = false;
      this.Button4.Enabled = false;
      this.GroupBox2.Refresh();
      this.Button3.Hide();
      this.Button4.Hide();
      this.Button34.Show();
      this.GroupBox2.Refresh();
      this.Button34.Enabled = true;
      this.GroupBox2.Text = "";
      this.GroupBox2.Refresh();
    }

    private void ShowActivationMenu()
    {
      this.GroupBox2.Text = Lang.GroupBoxText2;
      this.Button34.Enabled = false;
      this.GroupBox2.Refresh();
      this.Button34.Hide();
      this.Button3.Show();
      this.Button4.Show();
      this.GroupBox2.Refresh();
      if (!this._disableActivateSystemButton)
        this.Button3.Enabled = true;
      this.Button4.Enabled = true;
    }

    private void HideInformationMenu()
    {
      this.Button5.Enabled = false;
      this.Button32.Enabled = false;
      this.Button26.Enabled = false;
      this.GroupBox9.Refresh();
      this.Button5.Hide();
      this.Button32.Hide();
      this.Button26.Hide();
      this.Button35.Show();
      this.GroupBox9.Refresh();
      this.Button35.Enabled = true;
      this.GroupBox9.Text = "";
      this.GroupBox9.Refresh();
    }

    private void ShowInformationMenu()
    {
      this.GroupBox9.Text = Lang.GroupBoxText9;
      this.Button35.Enabled = false;
      this.GroupBox9.Refresh();
      this.Button35.Hide();
      this.Button5.Show();
      this.Button32.Show();
      this.Button26.Show();
      this.GroupBox9.Refresh();
      this.Button5.Enabled = true;
      this.Button32.Enabled = true;
      this.Button26.Enabled = true;
    }

    private object GetScheduler_Files(string xmlFile)
    {
      string str1 = "<Arguments>/win=act</Arguments>";
      string str2 = "<Arguments>/off=act</Arguments>";
      string str3 = "      <DaysInterval>10</DaysInterval>";
      string str4 = "      <Interval>P10D</Interval>";
      string[] strArray1 = new string[53]
      {
        "<?xml version=\"1.0\" encoding=\"UTF-16\"?>",
        "<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">",
        "<RegistrationInfo>",
        "  <Date>2014-04-11T05:43:14</Date>",
        "  <Author>RATIBORUS</Author>",
        "</RegistrationInfo>",
        "<Triggers>",
        "  <CalendarTrigger>",
        "    <Repetition>",
        "      <Interval>P10D</Interval>",
        "      <StopAtDurationEnd>false</StopAtDurationEnd>",
        "    </Repetition>",
        "    <StartBoundary>2014-05-28T10:00:00</StartBoundary>",
        "    <Enabled>true</Enabled>",
        "    <RandomDelay>PT3M</RandomDelay>",
        "    <ScheduleByDay>",
        "      <DaysInterval>10</DaysInterval>",
        "    </ScheduleByDay>",
        "  </CalendarTrigger>",
        "</Triggers>",
        "<Principals>",
        "<Principal id=\"Author\">",
        "<GroupId>S-1-5-32-544</GroupId>",
        "<RunLevel>HighestAvailable</RunLevel>",
        "</Principal>",
        "</Principals>",
        "<Settings>",
        "<MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>",
        "<DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>",
        "<StopIfGoingOnBatteries>false</StopIfGoingOnBatteries>",
        "<AllowHardTerminate>false</AllowHardTerminate>",
        "<StartWhenAvailable>true</StartWhenAvailable>",
        "<RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>",
        "<IdleSettings>",
        "<StopOnIdleEnd>true</StopOnIdleEnd>",
        "<RestartOnIdle>false</RestartOnIdle>",
        "</IdleSettings>",
        "<AllowStartOnDemand>true</AllowStartOnDemand>",
        "<Enabled>true</Enabled>",
        "<Hidden>true</Hidden>",
        "<RunOnlyIfIdle>false</RunOnlyIfIdle>",
        "<WakeToRun>false</WakeToRun>",
        "<ExecutionTimeLimit>PT0S</ExecutionTimeLimit>",
        "<Priority>7</Priority>",
        "</Settings>",
        "<Actions Context=\"Author\">",
        "<Exec>",
        "<Command>KMSAutoNet.exe</Command>",
        "<Arguments>/win=act /off=act</Arguments>",
        "<WorkingDirectory>%ProgramData%\\KMSAutoS</WorkingDirectory>",
        "</Exec>",
        "</Actions>",
        "</Task>"
      };
      if (this.SetKmsProgramData)
      {
        string str5 = this._systemdrive + "\\ProgramData\\KMSAutoS\\KMSAuto Net.exe";
        strArray1[47] = "<Command>\"" + str5 + "\"</Command>";
        strArray1[49] = "<WorkingDirectory>" + this._systemdrive + "\\ProgramData\\KMSAutoS\\</WorkingDirectory>";
      }
      else
      {
        string str5 = this.ApplicationStartupPathForPlan + "\\KMSAuto Net.exe";
        strArray1[47] = "<Command>\"" + str5 + "\"</Command>";
        strArray1[49] = "<WorkingDirectory>" + this.ApplicationStartupPathForPlan + "\\</WorkingDirectory>";
      }
      this.Check_New_Windows_Version_Lite();
      if (Operators.CompareString(this._winVersion, "Windows 8.1", false) == 0)
      {
        strArray1[16] = str3;
        strArray1[9] = str4;
      }
      if (Operators.CompareString(xmlFile, "win", false) == 0)
        strArray1[48] = str1;
      if (Operators.CompareString(xmlFile, "off", false) == 0)
        strArray1[48] = str2;
      StreamWriter streamWriter = new StreamWriter(this.Tempdir + "\\" + this._kmsAutoFileList[1], true, Encoding.GetEncoding("utf-16"));
      string[] strArray2 = strArray1;
      int index = 0;
      while (index < strArray2.Length)
      {
        string str5 = strArray2[index];
        streamWriter.Write(str5 + "\r\n");
        checked { ++index; }
      }
      streamWriter.Close();
      return (object) 0;
    }

    private void Install_Reinstall_Task(string product)
    {
      if (this._schtasksWinStatus & this._schtasksOffStatus & this.Scheduler || Operators.CompareString(this.KmsFlag, "KMS", false) == 0 || (Operators.CompareString(product, "Windows", false) == 0 & this._schtasksWinStatus || Operators.CompareString(product, "Office", false) == 0 & this._schtasksOffStatus))
        return;
      if (!this._professional)
      {
        int num = (int) MessageBox.Show(Lang.SchedulerWarnText + "\r\n\r\n" + Lang.CancelWarnText, Lang.SchedulerWarn, MessageBoxButtons.YesNoCancel);
        if (num == 6)
        {
          if (Operators.CompareString(product, "Windows", false) == 0)
            this.CheckTaskParamAndSetShedule("win");
          else if (Operators.CompareString(product, "Office", false) == 0)
            this.CheckTaskParamAndSetShedule("off");
        }
        if (num == 2)
        {
          if (Operators.CompareString(product, "Windows", false) == 0)
            this._schtasksWinStatus = true;
          if (Operators.CompareString(product, "Office", false) == 0)
            this._schtasksOffStatus = true;
        }
      }
      this.KMS_SchedulerFlagShow();
    }

    private void Me_Move(object sender, EventArgs e)
    {
      if (!this._meMovePosition)
        return;
      this._positionLeftTmp = this.Left;
      this._positionTopTmp = this.Top;
      if (!(this._positionLeft != this._positionLeftTmp | this._positionTop != this._positionTopTmp))
        return;
      this._positionLeft = this._positionLeftTmp;
      this._positionTop = this._positionTopTmp;
    }

    private object CheckKeyFormat(string key, bool flag)
    {
      object obj;
      if (!new Regex("^[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}$").IsMatch(Strings.UCase(Strings.Trim(key))))
      {
        if (flag)
        {
          int num = (int) Interaction.MsgBox((object) Lang.KeyFormatTxt, MsgBoxStyle.Exclamation, (object) Lang.KeyFormatCheckTxt);
        }
        obj = (object) (int) byte.MaxValue;
      }
      else
        obj = (object) 0;
      return obj;
    }

    private bool Check_New_Windows_Version()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      string str = Conversions.ToString(registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false).GetValue("ProductName"));
      registryKey.Close();
      bool flag = false;
      int num1 = checked (unchecked (this._productListNewOsInstallGvlkKey.Length / 2) - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Operators.CompareString(Strings.Trim(str), Strings.Trim(this._productListNewOsInstallGvlkKey[index, 0]), false) != 0)
        {
          checked { ++index; }
        }
        else
        {
          this.OwnKeyInstallNoDialogKey = this._productListNewOsInstallGvlkKey[index, 1];
          this.OwnKeyInstallYesDialog = true;
          this.OwnKeyInstallYesDialogProductName = this._productListNewOsInstallGvlkKey[index, 0];
          this.MyPrintLine(this._razdelitel);
          int num2 = WmIfunctions.InstallGvlk((byte) 1, (byte) 7);
          this.OwnKeyInstallYesDialog = false;
          this.OwnKeyInstallYesDialogProductName = "";
          this.OwnKeyInstallNoDialogKey = "";
          int num3 = 0;
          this.OwnKeyInstallKey = !(num2 == num3 & WmIfunctions.WindowsOperationCounters.Successful >= 1) ? (int) byte.MaxValue : 0;
          flag = true;
          break;
        }
      }
      return flag;
    }

    public bool Check_New_Windows_Version_9600()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      string String1 = Conversions.ToString(registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false).GetValue("BuildLabEx"));
      registryKey.Close();
      bool flag = false;
      int num = Strings.InStr(String1, ".", CompareMethod.Binary);
      if (num > 1)
        String1 = String1.Remove(checked (num - 1));
      int integer = Conversions.ToInteger(String1);
      if (integer >= 9600)
      {
        flag = true;
        this._windows10 = integer > 9840;
      }
      if (integer == 7601)
        this.WinVersion7601 = "7601";
      return flag;
    }

    private bool Check_New_Windows_Version_Lite()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      this._winVersion = Conversions.ToString(registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false).GetValue("ProductName"));
      registryKey.Close();
      bool flag = false;
      if (this._winVersion.Contains("Windows 10"))
        this._winVersion = "Windows 8.1";
      if (this._winVersion.Contains("8.1"))
        flag = true;
      return flag;
    }

    private bool Change_Windows_Version_Init()
    {
      this.CheckBox6.Checked = false;
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      this.ProductNameWin = Conversions.ToString(registryKey2.GetValue("ProductName"));
      this._editionId = Conversions.ToString(registryKey2.GetValue("EditionID"));
      registryKey1.Close();
      if (Operators.CompareString(Strings.Mid(this.ProductNameWin, 1, 9), "Windows 7", false) == 0)
      {
        int num = checked (unchecked (this.string_0.Length / 2) - 1);
        int index = 0;
        while (index <= num)
        {
          this.ComboBox9.Items.Insert(index, (object) this.string_0[index, 0]);
          checked { ++index; }
        }
        this.ComboBox9.Text = this.string_0[0, 0];
      }
      else
      {
        this.CheckBox6.Enabled = false;
        int num = checked (unchecked (this._productList8ForChengeOs.Length / 2) - 1);
        int index = 0;
        while (index <= num)
        {
          this.ComboBox9.Items.Insert(index, (object) this._productList8ForChengeOs[index, 0]);
          checked { ++index; }
        }
        this.ComboBox9.Text = this._productList8ForChengeOs[0, 0];
      }
      this.Label12.Text = Lang.Label12Text + "\r\n" + this.ProductNameWin + " :";
      return true;
    }

    private bool Change_Windows_Version()
    {
      string str = "";
      int num1 = checked (unchecked (this.string_0.Length / 2) - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Operators.CompareString(this.ComboBox9.Text, this.string_0[index1, 0], false) == 0)
        {
          str = this.string_0[index1, 0];
          this._editionId = this.string_0[index1, 1];
        }
        checked { ++index1; }
      }
      int num2 = checked (unchecked (this._productList8ForChengeOs.Length / 2) - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Operators.CompareString(this.ComboBox9.Text, this._productList8ForChengeOs[index2, 0], false) == 0)
        {
          str = this._productList8ForChengeOs[index2, 0];
          this._editionId = this._productList8ForChengeOs[index2, 1];
        }
        checked { ++index2; }
      }
      bool flag;
      if (this._argsFlag & (uint) Operators.CompareString(str, "", false) > 0U)
      {
        this._Change_Windows_Version(str);
        flag = true;
      }
      else
      {
        if (Operators.CompareString(str, this.ProductNameWin, false) != 0)
        {
          MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
          if ((this._cmDlineExist ? DialogResult.OK : MessageBox.Show(Lang.ConvertTxt + "\r\n" + str + Lang.ConvertTxt2, Lang.CaptionConvert, buttons)) == DialogResult.OK)
          {
            this._Change_Windows_Version(str);
            this.Label12.Text = Lang.Label12Text + "\r\n" + this.ProductNameWin + " :";
          }
        }
        flag = true;
      }
      return flag;
    }

    private bool _Change_Windows_Version(string productNameTemp)
    {
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey2.SetValue("ProductName", (object) productNameTemp);
      registryKey2.SetValue("EditionID", (object) this._editionId);
      this.ProductNameWin = Conversions.ToString(registryKey2.GetValue("ProductName"));
      this._editionId = Conversions.ToString(registryKey2.GetValue("EditionID"));
      registryKey1.Close();
      return true;
    }

    public void MyAudioClick()
    {
      if (!this._sounds)
        return;
      try
      {
        if (!File.Exists(this.Windir + "\\media\\Windows Menu Command.wav"))
          return;
        MyProject.Computer.Audio.Play(this.Windir + "\\media\\Windows Menu Command.wav", AudioPlayMode.Background);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MyAudioClickNotify()
    {
      if (!this._sounds)
        return;
      try
      {
        if (File.Exists(this.Windir + "\\media\\Windows Notify System Generic.wav"))
        {
          MyProject.Computer.Audio.Play(this.Windir + "\\media\\Windows Notify System Generic.wav", AudioPlayMode.WaitToComplete);
        }
        else
        {
          if (!File.Exists(this.Windir + "\\media\\tada.wav"))
            return;
          MyProject.Computer.Audio.Play(this.Windir + "\\media\\tada.wav", AudioPlayMode.WaitToComplete);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MyAudioClickUnlock()
    {
      if (!this._sounds)
        return;
      try
      {
        if (File.Exists(this.Windir + "\\media\\Windows Unlock.wav"))
        {
          MyProject.Computer.Audio.Play(this.Windir + "\\media\\Windows Unlock.wav", AudioPlayMode.Background);
        }
        else
        {
          if (!File.Exists(this.Windir + "\\media\\Windows Shutdown.wav"))
            return;
          MyProject.Computer.Audio.Play(this.Windir + "\\media\\Windows Shutdown.wav", AudioPlayMode.Background);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MyAudioClickManualActivationError()
    {
      if (!this._sounds)
        return;
      try
      {
        if (!File.Exists(this.Windir + "\\media\\Windows Critical Stop.wav"))
          return;
        MyProject.Computer.Audio.Play(this.Windir + "\\media\\Windows Critical Stop.wav", AudioPlayMode.Background);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ActSuccessful()
    {
      this.MyAudioClickNotify();
      this._actSuccessfullFlag = true;
    }

    private void ListKey()
    {
      this.ComboBox10.Items.Clear();
      int num = checked (unchecked (this._productListWindowsOffice.Length / 2) - 1);
      int index = 0;
      while (index <= num)
      {
        this.ComboBox10.Items.Add((object) this._productListWindowsOffice[index, 0]);
        checked { ++index; }
      }
      this.ComboBox10.SelectedIndex = 0;
    }

    private object InstallGVLK_from_DataBaseKeys()
    {
      object obj = (object) (int) byte.MaxValue;
      string text = this.ComboBox10.Text;
      if (!(text.StartsWith("======") | Operators.CompareString(this.TextBox3.Text, "", false) == 0))
      {
        if (text.Contains("Windows") | text.Contains("Server"))
        {
          this.OwnKeyInstallNoDialogKey = Strings.Trim(this.TextBox3.Text);
          int num1 = this.StartProcessHide("cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /ipk " + this.OwnKeyInstallNoDialogKey ?? "", true);
          this.OwnKeyInstallNoDialogKey = "";
          if (num1 == 0)
          {
            int num2 = (int) MessageBox.Show(Lang.MessageInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            obj = (object) 0;
          }
          else
          {
            int num3 = (int) MessageBox.Show(Lang.MessageNoInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          this.OwnKeyInstallNoDialog = true;
          this.OwnKeyInstallNoDialogMyKey = true;
          this.OwnKeyInstallNoDialogKey = Strings.Trim(this.TextBox3.Text);
          int num1 = WmIfunctions.InstallGvlk((byte) 6, (byte) 7);
          this.OwnKeyInstallNoDialog = false;
          this.OwnKeyInstallNoDialogMyKey = false;
          this.OwnKeyInstallNoDialogKey = "";
          int num2 = 0;
          if (num1 == num2 & WmIfunctions.OfficeOperationCounters.Successful >= 1)
          {
            int num3 = (int) MessageBox.Show(Lang.MessageInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            obj = (object) 0;
          }
          else
          {
            int num4 = (int) MessageBox.Show(Lang.MessageNoInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
      return obj;
    }

    private void Button34_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.ShowActivationMenu();
      this.HideInformationMenu();
      Thread.Sleep(500);
    }

    private void Button35_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.ShowInformationMenu();
      this.HideActivationMenu();
      Thread.Sleep(500);
    }

    private void PrintMode(bool mode)
    {
      if (mode)
      {
        if (Operators.CompareString(this.AutoModeList[this._type], "localhost", false) == 0)
        {
          this.Label15.Text = "";
          this.GroupBox9.Refresh();
          this.Label15.Refresh();
          this.Label15.Text = "(LocalHost)";
          this.Label15.Refresh();
        }
        else if (Operators.CompareString(this.AutoModeList[this._type], "hook", false) == 0)
        {
          this.Label15.Text = "";
          this.GroupBox9.Refresh();
          this.Label15.Refresh();
          this.Label15.Text = "    (Hook)";
          this.Label15.Refresh();
        }
        else if (Operators.CompareString(this.AutoModeList[this._type], "windivert", false) == 0)
        {
          this.Label15.Text = "";
          this.GroupBox9.Refresh();
          this.Label15.Refresh();
          this.Label15.Text = " (WinDivert)";
          this.Label15.Refresh();
        }
        else if (Operators.CompareString(this.AutoModeList[this._type], "tap", false) == 0)
        {
          this.Label15.Text = "";
          this.GroupBox9.Refresh();
          this.Label15.Refresh();
          this.Label15.Text = "     (TAP)    ";
          this.Label15.Refresh();
        }
      }
      else
        this.Label15.Text = "";
      this.Label15.Refresh();
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string text = this.Button3.Text;
      this.Button3.Text = Lang.ButtonRuns;
      this.Button3.Enabled = false;
      this.Button4.Enabled = false;
      this.Button3.Refresh();
      if (this._instKey)
        this.Install_OwnKey_Old_and_New_Windows_Version();
      while (true)
      {
        do
        {
          if (!this.CheckBoxFakeIP.Checked)
          {
            if (this._modeAuto)
            {
              this._ModeAutoSetupSettings(true);
              this.PrintMode(true);
            }
            if (this.ModeTap)
            {
              if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                this.KmsSetAndExtractFolder();
              this.InstallTap();
              Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
            }
            else if (!this._modeAutoNo)
            {
              if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                this.KmsSetAndExtractFolder();
            }
            else if (!this.NoAutoNoKms && Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsSetAndExtractFolder();
            if (this._modeWd)
              this.InstallDivert();
            if (this._modeHook)
              this.InstallHook();
          }
          else
            goto label_41;
label_23:
          int num;
          int successful;
          while (true)
          {
            this.MyPrintLine(Lang.ButtonActivate + this._host + ":" + this._port + " ...");
            if (!this._delKmsServer)
            {
              WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
              num = WmIfunctions.ActivateProduct((byte) 1);
              successful = WmIfunctions.WindowsOperationCounters.Successful;
            }
            else
              goto label_22;
label_18:
            if ((successful < 1 | (uint) num > 0U) & !this._requestWinKey)
            {
              WmIfunctions.ClearProductKmsParameters((byte) 1);
              if (this.Check_New_Windows_Version())
              {
                this._requestWinKey = true;
                this.MyPrintLine(this._razdelitel);
                continue;
              }
              this.MyPrintLine(this._razdelitel);
              WmIfunctions.InstallGvlk((byte) 1, byte.MaxValue);
              this.MyPrintLine(this._razdelitel);
              this._requestWinKey = true;
              this.MyPrintLine(this._razdelitel);
              continue;
            }
            break;
label_22:
            this.MyPrintLine(Lang.Warning3);
            WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
            num = WmIfunctions.ActivateProduct((byte) 1);
            successful = WmIfunctions.WindowsOperationCounters.Successful;
            WmIfunctions.ClearGlobalKmsParameters();
            goto label_18;
          }
          if (this._modeHook)
            this.UnInstallHook();
          if (this._modeWd)
            this.UninstallDivert();
          if (this.CheckBoxFakeIP.Checked)
            this.UninstallDivert();
          if (this._modeAuto)
            this.UnInstallTap();
          if (!this._modeAutoNo)
          {
            if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsDelAndDelFolder();
          }
          else if (!this.NoAutoNoKms && Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsDelAndDelFolder();
          if ((successful < 1 | (uint) num > 0U) & this._modeAuto)
          {
            if (this._ModeAutoSetupSettings(false))
              continue;
            goto label_46;
          }
          else
            goto label_48;
label_41:
          this.UninstallDivert();
          this._host = this.GenerateIp();
          if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
            this.KmsSetAndExtractFolder();
          this.InstallDivert();
          goto label_23;
        }
        while (!this.CheckBoxFakeIP.Checked);
        this.UninstallDivert();
        this.CheckBoxFakeIP.Checked = false;
      }
label_46:
      if (Interaction.MsgBox((object) Lang.ActFailTxt, MsgBoxStyle.OkCancel, (object) null) == MsgBoxResult.Ok && !this.Install_OwnKey_Old_and_New_Windows_Version())
      {
        this.OwnKeyInstallNoDialog = true;
        this.OwnKeyInstallNoDialogMyKey = false;
        WmIfunctions.InstallGvlk((byte) 1, byte.MaxValue);
        this.OwnKeyInstallNoDialog = false;
      }
label_48:
      this.Button3.Text = text;
      if (!this._disableActivateSystemButton)
        this.Button3.Enabled = true;
      this.Button4.Enabled = true;
      this.Button3.Refresh();
      if (!this._professional)
      {
        this.HideInformationMenu();
        this.HideActivationMenu();
      }
      this.MyPrintLine(this._razdelitel);
      if (this._actSuccessfullFlag)
      {
        this._actSuccessfullFlag = false;
        this.MyAudioClickUnlock();
        this.MyPrintLine(this._actSuccessfull);
        this.MyPrintLine(this._razdelitel);
        this.Install_Reinstall_Task("Windows");
      }
      else
      {
        this.MyAudioClickManualActivationError();
        this.PrintErrorCode();
      }
      this.PrintMode(false);
      this._countActivations = 0;
      if (!File.Exists(Application.StartupPath + "\\KMS Log File.log"))
        return;
      this.LogAnalyzerLogCopy();
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string text = this.Button4.Text;
      this.Button4.Text = Lang.ButtonRuns;
      this.Button4.Enabled = false;
      this.Button3.Enabled = false;
      this.Button4.Refresh();
      if (this.CheckOfficeRetailForm1() && Interaction.MsgBox((object) Lang.Office2013RetailTxt, MsgBoxStyle.Exclamation | MsgBoxStyle.OkCancel, (object) null) == MsgBoxResult.Ok)
      {
        MyProject.Forms.OfficeConvert.Top = checked (this.Top + 70);
        MyProject.Forms.OfficeConvert.Left = checked (this.Left + 70);
        int num = (int) MyProject.Forms.OfficeConvert.ShowDialog();
      }
      if (!this._officeInstalled)
      {
        this.Button4.Text = text;
        this.Button4.Enabled = true;
        if (this._disableActivateSystemButton)
          return;
        this.Button3.Enabled = true;
      }
      else
      {
        while (true)
        {
          do
          {
            if (!this.CheckBoxFakeIP.Checked)
            {
              if (this._modeAuto)
              {
                this._ModeAutoSetupSettings(true);
                this.PrintMode(true);
              }
              if (this.ModeTap)
              {
                if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                  this.KmsSetAndExtractFolder();
                this.InstallTap();
                Interaction.Shell("net start dot3svc", AppWinStyle.Hide, true, -1);
              }
              else if (!this._modeAutoNo)
              {
                if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                  this.KmsSetAndExtractFolder();
              }
              else if (!this.NoAutoNoKms && Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                this.KmsSetAndExtractFolder();
              if (this._modeWd)
                this.InstallDivert();
              if (this._modeHook)
                this.InstallHook();
            }
            else
              goto label_42;
label_24:
            int num;
            int successful;
            while (true)
            {
              this.MyPrintLine(Lang.ButtonActivateOff1 + this._host + ":" + this._port + " ...");
              if (!this._delKmsServer)
              {
                WmIfunctions.ClearProductKmsParameters((byte) 6);
                WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
                num = WmIfunctions.ActivateProduct((byte) 6);
                successful = WmIfunctions.OfficeOperationCounters.Successful;
              }
              else
                goto label_23;
label_21:
              if ((successful < 1 | (uint) num > 0U) & !this._requestOffKey)
              {
                this.MyPrintLine(this._razdelitel);
                WmIfunctions.ClearProductKmsParameters((byte) 6);
                this._requestOffKey = true;
                WmIfunctions.InstallGvlk((byte) 6, byte.MaxValue);
                this.MyPrintLine(this._razdelitel);
                this.MyPrintLine(this._razdelitel);
                continue;
              }
              break;
label_23:
              this.MyPrintLine(Lang.Warning3);
              WmIfunctions.ClearProductKmsParameters((byte) 6);
              WmIfunctions.SetGlobalKmsParameters(this._host, this._port);
              num = WmIfunctions.ActivateProduct((byte) 6);
              successful = WmIfunctions.OfficeOperationCounters.Successful;
              WmIfunctions.ClearGlobalKmsParameters();
              goto label_21;
            }
            if (this._modeWd)
              this.UninstallDivert();
            if (this._modeHook)
              this.UnInstallHook();
            if (this.CheckBoxFakeIP.Checked)
              this.UninstallDivert();
            if (this._modeAuto)
              this.UnInstallTap();
            if (!this._modeAutoNo)
            {
              if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
                this.KmsDelAndDelFolder();
            }
            else if (!this.NoAutoNoKms && Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsDelAndDelFolder();
            if ((successful < 1 | (uint) num > 0U) & this._modeAuto && this._ModeAutoSetupSettings(false))
              continue;
            goto label_47;
label_42:
            this.UninstallDivert();
            this._host = this.GenerateIp();
            if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
              this.KmsSetAndExtractFolder();
            this.InstallDivert();
            goto label_24;
          }
          while (!this.CheckBoxFakeIP.Checked);
          this.UninstallDivert();
          this.CheckBoxFakeIP.Checked = false;
        }
label_47:
        this.Button4.Text = text;
        if (!this._disableActivateSystemButton)
          this.Button3.Enabled = true;
        this.Button4.Enabled = true;
        if (!this._professional)
        {
          this.HideInformationMenu();
          this.HideActivationMenu();
        }
        this.Button4.Refresh();
        this.MyPrintLine(this._razdelitel);
        if (this._actSuccessfullFlag)
        {
          this._actSuccessfullFlag = false;
          this.MyAudioClickUnlock();
          this.MyPrintLine(this._actSuccessfull);
          this.MyPrintLine(this._razdelitel);
          this.Install_Reinstall_Task("Office");
        }
        else
        {
          this.MyAudioClickManualActivationError();
          this.PrintErrorCode();
        }
        this.PrintMode(false);
        this._countActivations = 0;
        if (!File.Exists(Application.StartupPath + "\\KMS Log File.log"))
          return;
        this.LogAnalyzerLogCopy();
      }
    }

    private bool Install_OwnKey_Old_and_New_Windows_Version()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      string str = Conversions.ToString(registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false).GetValue("ProductName"));
      registryKey.Close();
      bool flag = false;
      this._installOwnKeyFlag = false;
      int num1 = checked (unchecked (this._productListNewOsInstallGvlkKey.Length / 2) - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Operators.CompareString(Strings.Trim(str), Strings.Trim(this._productListNewOsInstallGvlkKey[index1, 0]), false) != 0)
        {
          checked { ++index1; }
        }
        else
        {
          this._installOwnKeyFlag = true;
          this.OwnKeyInstallNoDialogKey = this._productListNewOsInstallGvlkKey[index1, 1];
          this.MyPrintLine(this._razdelitel);
          if (this.StartProcessHide("cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /ipk " + this.OwnKeyInstallNoDialogKey ?? "", true) == 0)
          {
            this.MyPrintLine(Lang.MessageInstall);
            flag = true;
            goto label_14;
          }
          else
          {
            this.MyPrintLine(Lang.MessageNoInstall);
            flag = false;
            goto label_14;
          }
        }
      }
      int num2 = checked (unchecked (this._productListWindowsOffice.Length / 2) - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Operators.CompareString(Strings.Trim(str), Strings.Trim(this._productListWindowsOffice[index2, 0]), false) != 0)
        {
          checked { ++index2; }
        }
        else
        {
          this._installOwnKeyFlag = true;
          this.OwnKeyInstallNoDialogKey = this._productListWindowsOffice[index2, 1];
          this.MyPrintLine(this._razdelitel);
          if (this.StartProcessHide("cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /ipk " + this.OwnKeyInstallNoDialogKey ?? "", true) == 0)
          {
            this.MyPrintLine(Lang.MessageInstall);
            flag = true;
            break;
          }
          this.MyPrintLine(Lang.MessageNoInstall);
          flag = false;
          break;
        }
      }
label_14:
      return flag;
    }

    private bool _ModeAutoSetupSettings(bool flag)
    {
      if (this.AutoRes & this._firstActivation)
      {
        this._type = 0;
        this._autoModeHost = this._autoModeHostLh;
        this._firstActivation = false;
      }
      if (this._type > checked (this.AutoModeList.Length - 1))
        this._type = 0;
      bool flag1;
      if (flag)
      {
        this._ModeSetAutoSetupSettings(this.AutoModeList[this._type]);
        flag1 = true;
      }
      else
      {
        if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
          this.StartKmsServer();
        while (this._countActivations < this.AutoModeList.Length)
        {
          if (Operators.CompareString(this.AutoModeList[this._type], "localhost", false) == 0)
          {
            if (Operators.CompareString(this._autoModeHost, this._autoModeHostLh, false) == 0)
            {
              this.INC_Type();
              checked { ++this._countActivations; }
            }
            else
            {
              this._autoModeHost = this._autoModeHostLh;
              this._ModeSetAutoSetupSettings("localhost");
              flag1 = true;
              goto label_26;
            }
          }
          if (Operators.CompareString(this.AutoModeList[this._type], "windivert", false) == 0)
          {
            if (Operators.CompareString(this._autoModeHost, this._autoModeHostWd, false) == 0)
            {
              this.INC_Type();
              checked { ++this._countActivations; }
            }
            else
            {
              this._autoModeHost = this._autoModeHostWd;
              this._ModeSetAutoSetupSettings("windivert");
              flag1 = true;
              goto label_26;
            }
          }
          if (Operators.CompareString(this.AutoModeList[this._type], "tap", false) == 0)
          {
            if (Operators.CompareString(this._autoModeHost, this._autoModeHostTap, false) == 0)
            {
              this.INC_Type();
              checked { ++this._countActivations; }
            }
            else
            {
              this._autoModeHost = this._autoModeHostTap;
              this._ModeSetAutoSetupSettings("tap");
              flag1 = true;
              goto label_26;
            }
          }
          if (Operators.CompareString(this.AutoModeList[this._type], "hook", false) == 0)
          {
            if (Operators.CompareString(this._autoModeHost, this._autoModeHostHook, false) == 0)
            {
              this.INC_Type();
              checked { ++this._countActivations; }
            }
            else
            {
              this._autoModeHost = this._autoModeHostHook;
              this._ModeSetAutoSetupSettings("hook");
              flag1 = true;
              goto label_26;
            }
          }
        }
        this._countActivations = 0;
        flag1 = false;
        goto label_27;
      }
label_26:
      this._host = this._autoModeHost;
label_27:
      return flag1;
    }

    private void INC_Type()
    {
      checked { ++this._type; }
      if (this._type <= checked (this.AutoModeList.Length - 1))
        return;
      this._type = 0;
    }

    private void _ModeSetAutoSetupSettings(string value)
    {
      if (Operators.CompareString(value, "localhost", false) == 0)
      {
        this._autoModeHost = this._autoModeHostLh;
        this.ModeTap = false;
        this.UnInstallTap();
        this._modeWd = false;
        this._modeHook = false;
      }
      else if (Operators.CompareString(value, "windivert", false) == 0)
      {
        this._autoModeHost = this._autoModeHostWd;
        this.ModeTap = false;
        this.UnInstallTap();
        this._modeWd = true;
        this._modeHook = false;
      }
      else if (Operators.CompareString(value, "tap", false) == 0)
      {
        this._autoModeHost = this._autoModeHostTap;
        this.ModeTap = true;
        this.InstallTap();
        this._modeWd = false;
        this._modeHook = false;
      }
      else if (Operators.CompareString(value, "hook", false) == 0)
      {
        this._autoModeHost = this._autoModeHostHook;
        this.ModeTap = false;
        this.UnInstallTap();
        this._modeWd = false;
        this._modeHook = true;
      }
      this._host = this._autoModeHost;
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Button5.Enabled = false;
      WmIfunctions.GetProductStatus((byte) 1);
      this.MyPrintLine(this._razdelitel);
      this.Button5.Enabled = true;
      if (this._professional)
        return;
      this.HideInformationMenu();
      this.HideActivationMenu();
    }

    private void Button32_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Button32.Enabled = false;
      WmIfunctions.GetProductStatus((byte) 6);
      this.MyPrintLine(this._razdelitel);
      this.Button32.Enabled = true;
      if (this._professional)
        return;
      this.HideInformationMenu();
      this.HideActivationMenu();
    }

    private void Button26_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string text = this.Button26.Text;
      this.Button26.Text = Lang.ButtonRuns;
      this.Button26.Refresh();
      this.MyPrintLine(Lang.PrintFileL);
      this.WriteLoGfile();
      this.MyPrintLine(Lang.PrintFileLok);
      this.MyPrintLine(this._razdelitel);
      this.Button26.Text = text;
      this.Button26.Refresh();
      if (this._professional)
        return;
      this.HideInformationMenu();
      this.HideActivationMenu();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (this.Scheduler && MessageBox.Show(Lang.Message2, Lang.Caption2, MessageBoxButtons.YesNo) == DialogResult.No)
      {
        this.KMS_SchedulerFlagShow();
      }
      else
      {
        string text = this.Button1.Text;
        this.Button1.Text = Lang.ButtonRuns;
        this.Button1.Refresh();
        if (Conversions.ToInteger(this.KmsSetAndExtractFolder()) == 0)
          this.KmsFlag = "KMS";
        this.CheckKmsService();
        this.KMS_SchedulerFlagShow();
        this.Button1.Text = text;
        this.Button1.Refresh();
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.DelKMSServer_Button();
    }

    private void DelKMSServer_Button()
    {
      string text = this.Button2.Text;
      this.Button2.Text = Lang.ButtonRuns;
      this.Button2.Refresh();
      if (Conversions.ToInteger(this.KmsDelAndDelFolder()) == 0)
        this.KmsFlag = "";
      this.CheckKmsService();
      this.KMS_SchedulerFlagShow();
      this.Button2.Text = text;
      this.Button2.Refresh();
    }

    private void Button29_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
      {
        int num = (int) MessageBox.Show(Lang.Warning2, Lang.Caption2);
      }
      else
      {
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        if (this.SetKmsProgramData)
        {
          this.PathKmsService = this._systemdrive + "\\ProgramData\\KMSAutoS";
          if (MessageBox.Show(Lang.TaskCreateTxt + "\r\n" + this.PathKmsService, Lang.TaskCreate, buttons) != DialogResult.OK)
            return;
          this.Button29.Enabled = false;
          this.SchtasksSet();
          this.MyPrintLine(this._razdelitel);
          this.KMS_SchedulerFlagShow();
        }
        else
        {
          this.PathKmsService = Application.StartupPath;
          if (MessageBox.Show(Lang.TaskCreateTxt + "\r\n" + Application.StartupPath + "\r\n" + Lang.TaskCreateTxt2, Lang.TaskCreate, buttons) != DialogResult.OK)
            return;
          this.Button29.Enabled = false;
          this.SchtasksSet();
          this.MyPrintLine(this._razdelitel);
          this.KMS_SchedulerFlagShow();
        }
      }
    }

    private void Button30_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.SchtasksDel();
      this.ComboBox7.Text = Lang.ComboBox7Cols1;
      this.MyPrintLine(this._razdelitel);
      this.KMS_SchedulerFlagShow();
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.MyPrintLine(Lang.InstallKeys);
      string text = this.Button6.Text;
      this.Button6.Text = Lang.ButtonRuns;
      this.Button6.Refresh();
      bool flag = this.Install_OwnKey_Old_and_New_Windows_Version();
      if (this._installOwnKeyFlag)
      {
        if (flag)
        {
          int num1 = (int) MessageBox.Show(Lang.MessageInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show(Lang.MessageNoInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        this.Button6.Text = text;
        this.Button6.Refresh();
        this.MyPrintLine(this._razdelitel);
      }
      else
      {
        if (WmIfunctions.InstallGvlk((byte) 1, (byte) 7) == 0 & WmIfunctions.WindowsOperationCounters.Successful >= 1)
        {
          int num1 = (int) MessageBox.Show(Lang.MessageInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show(Lang.MessageNoInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        this.Button6.Text = text;
        this.Button6.Refresh();
        this.MyPrintLine(this._razdelitel);
      }
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.MyPrintLine(Lang.InstallOfficeKey);
      string text = this.Button7.Text;
      this.Button7.Text = Lang.ButtonRuns;
      this.Button7.Refresh();
      if (WmIfunctions.InstallGvlk((byte) 6, (byte) 7) == 0 & WmIfunctions.OfficeOperationCounters.Successful > 0)
      {
        int num1 = (int) MessageBox.Show(Lang.MessageInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num2 = (int) MessageBox.Show(Lang.MessageNoInstall, Lang.CaptionInstallKey, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.Button7.Text = text;
      this.Button7.Refresh();
      this.MyPrintLine(this._razdelitel);
    }

    private void Button27_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (!File.Exists(this._kmsServicePathLog))
        return;
      Interaction.Shell(this.SysPath + "notepad.exe " + this._kmsServicePathLog, AppWinStyle.NormalFocus, false, -1);
      this.MyPrintLine(Lang.ShowLogFile);
      this.MyPrintLine(this._razdelitel);
    }

    private void Button28_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.LogAnalyzerProcess();
    }

    private void LogAnalyzerLogCopy()
    {
      if (!(File.Exists(this._kmsServicePathLog) & File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm")))
        return;
      if (File.Exists(Application.StartupPath + "\\KMS Log File.log"))
        File.SetAttributes(Application.StartupPath + "\\KMS Log File.log", FileAttributes.Normal);
      File.Copy(this._kmsServicePathLog, Application.StartupPath + "\\KMS Log File.log", true);
    }

    private void LogAnalyzerProcess()
    {
      this.LogAnalyzerLogCopy();
      if (!File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm"))
        return;
      Process.Start(Application.StartupPath + "\\KMS Log Analyzer.xlsm");
    }

    private void Button33_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (!File.Exists(this._kmsServicePathLog) || MessageBox.Show(Lang.Areyousure, Lang.Caption2, MessageBoxButtons.YesNo) == DialogResult.No)
        return;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
      {
        while (true)
        {
          int num = this.StopKmsServer();
          if (!(num == 0 | num == 1062))
          {
            this.MyPrintLine(Lang.RunTimeErr);
            Thread.Sleep(1000);
          }
          else
            break;
        }
        this.MyPrintLine(Lang.KmsServiceStopSusces);
      }
      File.SetAttributes(this._kmsServicePathLog, FileAttributes.Normal);
      this.DelFile(this._kmsServicePathLog);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
      {
        while (true)
        {
          int num = this.StartKmsServer();
          if (!(num == 0 | num == 1056))
          {
            this.MyPrintLine(Lang.RunTimeErr);
            Thread.Sleep(1000);
          }
          else
            break;
        }
        this.MyPrintLine(Lang.KmsServiceStartSusces);
      }
      int num1 = (int) MessageBox.Show(Lang.ClearLogSuccessfully, Lang.MessageOk);
      this.MyPrintLine(Lang.ClearLogSuccessfully);
      this.MyPrintLine(this._razdelitel);
    }

    private void Button31_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Button31.Enabled = false;
      this.Button31.Refresh();
      Interaction.Shell(this.SysPath + "cmd /c schtasks.exe /run /TN KMSAutoNet", AppWinStyle.Hide, false, -1);
      Thread.Sleep(3000);
      this.Button31.Enabled = true;
      this.Button31.Refresh();
      this.MyPrintLine(Lang.SchtaskWork);
      this.MyPrintLine(this._razdelitel);
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      if (!(!this._addFunctions & !this.GroupBox7.Visible) || MessageBox.Show(Lang.Message4, Lang.Caption2, MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.EnableAddSettings();
    }

    private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      this._host = Conversions.ToString(this.ComboBox3.SelectedItem);
      if (Operators.CompareString(this._host, this._autoHostText, false) == 0)
      {
        if (this._modeWd)
          this._host = this._autoModeHostWd;
        else if (this.ModeTap)
          this._host = this._autoModeHostTap;
        if (this._modeAutoNo)
          this._host = this._autoModeHostLh;
        if (this._modeHook)
          this._host = this._autoModeHostHook;
      }
      this._index3 = this.ComboBox3.SelectedIndex;
    }

    private void ComboBox3_TextChench(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) == 0)
        return;
      this._host = this.ComboBox3.Text;
    }

    private void Button16_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) == 0)
        return;
      bool flag = false;
      try
      {
        foreach (object obj in this.ComboBox3.Items)
        {
          if (Operators.CompareString(Conversions.ToString(obj), this.ComboBox3.Text, false) == 0)
            flag = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
        return;
      this.ComboBox3.Items.Add((object) this.ComboBox3.Text);
      this._host = this.ComboBox3.Text;
      this.ComboBox3.SelectedIndex = checked (this.ComboBox3.Items.Count - 1);
      this._index3 = this.ComboBox3.SelectedIndex;
    }

    private void Button17_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) == 0 || this.ComboBox3.Items.Count == 1)
        return;
      this.ComboBox3.Items.Remove((object) this.ComboBox3.Text);
      this.ComboBox3.SelectedIndex = this._index3 <= checked (this.ComboBox3.Items.Count - 1) ? this._index3 : checked (this._index3 - 1);
      this._host = this.ComboBox3.Text;
      this._index3 = this.ComboBox3.SelectedIndex;
      this.SaveProgramSetting();
    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this._winPid = Conversions.ToString(this.ComboBox1.SelectedItem);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this._index1 = this.ComboBox1.SelectedIndex;
    }

    private void Button12_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBox1.Text, "RandomKMSPID", false) == 0)
        return;
      bool flag = false;
      try
      {
        foreach (object obj in this.ComboBox1.Items)
        {
          if (Operators.CompareString(Conversions.ToString(obj), this.ComboBox1.Text, false) == 0)
            flag = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
        return;
      this.ComboBox1.Items.Add((object) this.ComboBox1.Text);
      this._winPid = this.ComboBox1.Text;
      this.ComboBox1.SelectedIndex = checked (this.ComboBox1.Items.Count - 1);
      this._index1 = this.ComboBox1.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void Button15_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (this.ComboBox1.Items.Count == 1 || Operators.CompareString(this.ComboBox1.Text, "RandomKMSPID", false) == 0)
        return;
      this.ComboBox1.Items.Remove((object) this.ComboBox1.Text);
      this.ComboBox1.SelectedIndex = this._index1 <= checked (this.ComboBox1.Items.Count - 1) ? this._index1 : checked (this._index1 - 1);
      this._winPid = this.ComboBox1.Text;
      this._index1 = this.ComboBox1.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this.SaveProgramSetting();
    }

    private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
      this._off2010Pid = Conversions.ToString(this.ComboBox6.SelectedItem);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this._index6 = this.ComboBox6.SelectedIndex;
    }

    private void Button24_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBox6.Text, "RandomKMSPID", false) == 0)
        return;
      bool flag = false;
      try
      {
        foreach (object obj in this.ComboBox6.Items)
        {
          if (Operators.CompareString(Conversions.ToString(obj), this.ComboBox6.Text, false) == 0)
            flag = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
        return;
      this.ComboBox6.Items.Add((object) this.ComboBox6.Text);
      this._off2010Pid = this.ComboBox6.Text;
      this.ComboBox6.SelectedIndex = checked (this.ComboBox6.Items.Count - 1);
      this._index6 = this.ComboBox6.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void Button25_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (this.ComboBox6.Items.Count == 1 || Operators.CompareString(this.ComboBox6.Text, "RandomKMSPID", false) == 0)
        return;
      this.ComboBox6.Items.Remove((object) this.ComboBox6.Text);
      this.ComboBox6.SelectedIndex = this._index6 <= checked (this.ComboBox6.Items.Count - 1) ? this._index6 : checked (this._index6 - 1);
      this._off2010Pid = this.ComboBox6.Text;
      this._index6 = this.ComboBox6.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this.SaveProgramSetting();
    }

    private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      this._off2013Pid = Conversions.ToString(this.ComboBox2.SelectedItem);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this._index2 = this.ComboBox2.SelectedIndex;
    }

    private void Button13_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBox2.Text, "RandomKMSPID", false) == 0)
        return;
      bool flag = false;
      try
      {
        foreach (object obj in this.ComboBox2.Items)
        {
          if (Operators.CompareString(Conversions.ToString(obj), this.ComboBox2.Text, false) == 0)
            flag = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
        return;
      this.ComboBox2.Items.Add((object) this.ComboBox2.Text);
      this._off2013Pid = this.ComboBox2.Text;
      this.ComboBox2.SelectedIndex = checked (this.ComboBox2.Items.Count - 1);
      this._index2 = this.ComboBox2.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void Button14_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (this.ComboBox2.Items.Count == 1 || Operators.CompareString(this.ComboBox2.Text, "RandomKMSPID", false) == 0)
        return;
      this.ComboBox2.Items.Remove((object) this.ComboBox2.Text);
      this.ComboBox2.SelectedIndex = this._index2 <= checked (this.ComboBox2.Items.Count - 1) ? this._index2 : checked (this._index2 - 1);
      this._off2013Pid = this.ComboBox2.Text;
      this._index2 = this.ComboBox2.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void Button18_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string text = this.Button18.Text;
      this.Button18.Text = Lang.ButtonRuns;
      this.Button18.Refresh();
      if (Operators.CompareString(this._host, this._autoHostText, false) == 0)
        this._host = this._autoModeHost;
      this.StartProcessHide(this.SysPath + "cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /skms " + this._host + ":" + this._port ?? "", true);
      if (this.StartProcessHide(this.SysPath + "cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /ato", true) == 0)
        this.MyPrintLine("Windows, " + Lang.ActivationSusces);
      this.Button18.Text = text;
      this.Button18.Refresh();
      this.MyPrintLine(this._razdelitel);
    }

    private void Button19_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && mode con cols=90 lines=30 && cscript.exe /nologo " + this.Windir + "\\system32\\slmgr.vbs /dlv", AppWinStyle.NormalFocus, false, -1);
    }

    private void Button20_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string text = this.Button20.Text;
      this.Button20.Text = Lang.ButtonRuns;
      this.Button20.Refresh();
      if (Operators.CompareString(this._host, this._autoHostText, false) == 0)
        this._host = this._autoModeHost;
      if (File.Exists(this._officePath + "\\ospp.vbs"))
      {
        Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"" + this._officePath + "\"\\ospp.vbs /sethst:" + this._host, AppWinStyle.Hide, true, -1);
        Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"" + this._officePath + "\"\\ospp.vbs /setprt:" + this._port, AppWinStyle.Hide, true, -1);
        if (this.StartProcessHide("cscript.exe", "/nologo \"" + this._officePath + "\"\\ospp.vbs /act", true) == 0)
          this.MyPrintLine("Office, " + Lang.ActivationSusces);
      }
      else
      {
        if (File.Exists("c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs"))
        {
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs\" /sethst:" + this._host, AppWinStyle.Hide, true, -1);
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs\" /setprt:" + this._port, AppWinStyle.Hide, true, -1);
          if (this.StartProcessHide(this.SysPath + "cscript.exe", "/nologo \"c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs\" /act", true) == 0)
            this.MyPrintLine("Office, " + Lang.ActivationSusces);
        }
        if (File.Exists("c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs"))
        {
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs\" /sethst:" + this._host, AppWinStyle.Hide, true, -1);
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs\" /setprt:" + this._port, AppWinStyle.Hide, true, -1);
          if (this.StartProcessHide("cscript.exe", "/nologo \"c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs\" /act", true) == 0)
            this.MyPrintLine("Office, " + Lang.ActivationSusces);
        }
        if (File.Exists("c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs"))
        {
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs\" /sethst:" + this._host, AppWinStyle.Hide, true, -1);
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs\" /setprt:" + this._port, AppWinStyle.Hide, true, -1);
          if (this.StartProcessHide(this.SysPath + "cscript.exe", "/nologo \"c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs\" /act", true) == 0)
            this.MyPrintLine("Office, " + Lang.ActivationSusces);
        }
        if (File.Exists("c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs"))
        {
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs\" /sethst:" + this._host, AppWinStyle.Hide, true, -1);
          Interaction.Shell(this.SysPath + "cmd.exe /c cscript.exe \"c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs\" /setprt:" + this._port, AppWinStyle.Hide, true, -1);
          if (this.StartProcessHide(this.SysPath + "cscript.exe", "/nologo \"c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs\" /act", true) == 0)
            this.MyPrintLine("Office, " + Lang.ActivationSusces);
        }
      }
      this.Button20.Text = text;
      this.Button20.Refresh();
    }

    private void Button21_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (File.Exists(this._officePath + "\\ospp.vbs"))
      {
        Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && cscript.exe /nologo \"" + this._officePath + "\"\\ospp.vbs /dstatus", AppWinStyle.NormalFocus, false, -1);
      }
      else
      {
        if (File.Exists("c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs"))
          Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && cscript.exe /nologo \"c:\\Program Files (x86)\\Microsoft Office\\Office15\\ospp.vbs\" /dstatus", AppWinStyle.NormalFocus, false, -1);
        if (File.Exists("c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs"))
          Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && cscript.exe /nologo \"c:\\Program Files\\Microsoft Office\\Office15\\ospp.vbs\" /dstatus", AppWinStyle.NormalFocus, false, -1);
        if (File.Exists("c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs"))
          Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && cscript.exe /nologo \"c:\\Program Files (x86)\\Microsoft Office\\Office14\\ospp.vbs\" /dstatus", AppWinStyle.NormalFocus, false, -1);
        if (!File.Exists("c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs"))
          return;
        Interaction.Shell(this.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && cscript.exe /nologo \"c:\\Program Files\\Microsoft Office\\Office14\\ospp.vbs\" /dstatus", AppWinStyle.NormalFocus, false, -1);
      }
    }

    private void Button22_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this._officePath = this.TextBox2.Text;
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (0 < Process.GetProcessesByName("MSActBackup").Length)
        return;
      string text = this.Button9.Text;
      this.Button9.Text = Lang.ButtonRuns;
      this.Button9.Refresh();
      FileSystem.ChDir(this.Tempdir);
      while (!File.Exists(this.Tempdir + "\\MSActBackup.exe"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("MSActBackup.exe", KMSAuto_Net.My.Resources.Resources.MSActBackup, false);
        Application.DoEvents();
      }
      string str = "[Configurations]\r\n" + "Lang = " + this.TargetLang + "\r\n";
      if (File.Exists(this.Tempdir + "\\MSActBackup.ini"))
        this.DelFile(this.Tempdir + "\\MSActBackup.ini");
      if (File.Exists(this.Tempdir + "\\MSActBackUpPath.ini"))
        this.DelFile(this.Tempdir + "\\MSActBackUpPath.ini");
      StreamWriter streamWriter1 = new StreamWriter(this.Tempdir + "\\MSActBackup.ini", true, Encoding.GetEncoding("utf-8"));
      streamWriter1.Write(str);
      streamWriter1.Close();
      StreamWriter streamWriter2 = new StreamWriter(this.Tempdir + "\\MSActBackUpPath.ini", true, Encoding.GetEncoding("Ascii"));
      streamWriter2.Write(Application.StartupPath + "\\");
      streamWriter2.Close();
      Interaction.Shell(this.Tempdir + "\\MSActBackup.exe", AppWinStyle.NormalFocus, false, -1);
      this._msActBackUpFlag = true;
      this.Button9.Text = text;
      this.Button9.Refresh();
    }

    private void Button11_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Button11.Enabled = false;
      if (this.StartProcessHide("cscript.exe", "/nologo " + this.Windir + "\\system32\\slmgr.vbs /rearm", true) == 0)
        this.MyPrintLine("Rearm Ok!");
      int num = (int) MessageBox.Show(Lang.NeedRestart, Lang.Caption2);
      this.Button11.Enabled = true;
    }

    private void ComboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.TextBox3.Text = this._productListWindowsOffice[this.ComboBox10.SelectedIndex, 1];
    }

    private void Button48_Click(object sender, EventArgs e)
    {
      this.Button48.Enabled = false;
      this.Button48.Refresh();
      this._myPrintLineNoPrint = true;
      this.InstallGVLK_from_DataBaseKeys();
      this._myPrintLineNoPrint = false;
      this.Button48.Enabled = true;
      this.Button48.Refresh();
    }

    private void Button43_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Process.Start(this.Windir + "\\system32\\services.msc");
    }

    private void Button42_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Process.Start(this.Windir + "\\system32\\taskschd.msc");
    }

    private void Button46_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Interaction.Shell(this.Windir + "\\system32\\control.exe userpasswords2", AppWinStyle.NormalFocus, false, -1);
    }

    private void Button47_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Process.Start(this.Windir + "\\system32\\eventvwr.msc");
    }

    private void Button40_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Change_Windows_Version();
    }

    private void CheckBox6_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox6.Checked & Operators.CompareString(Strings.Mid(this.ProductNameWin, 1, 9), "Windows 7", false) == 0)
      {
        this.ComboBox9.Items.Clear();
        int num1 = checked (unchecked (this._productList8ForChengeOs.Length / 2) - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          this.ComboBox9.Items.Insert(index1, (object) this._productList8ForChengeOs[index1, 0]);
          checked { ++index1; }
        }
        int num2 = checked (unchecked (this.string_0.Length / 2) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          this.ComboBox9.Items.Insert(index2, (object) this.string_0[index2, 0]);
          checked { ++index2; }
        }
        this.ComboBox9.Text = this.string_0[0, 0];
      }
      else
      {
        this.ComboBox9.Items.Clear();
        int num = checked (unchecked (this.string_0.Length / 2) - 1);
        int index = 0;
        while (index <= num)
        {
          this.ComboBox9.Items.Insert(index, (object) this.string_0[index, 0]);
          checked { ++index; }
        }
        this.ComboBox9.Text = this.string_0[0, 0];
      }
    }

    private void ShowReadme()
    {
      this.MyAudioClick();
      MyProject.Forms.FormHelp.Show();
    }

    private void Button39_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      this.Enable_Disable_Professional_mode();
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.MyAudioClick();
      string fileName = "http://goo.gl/eD7s9X";
      if (File.Exists(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe"))
        Interaction.Shell(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
      else if (File.Exists(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe"))
        Interaction.Shell(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
      else
        Process.Start(fileName);
    }

    private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.MyAudioClick();
      if (File.Exists(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe"))
        Interaction.Shell(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe http://www.microsoft.com/genuine/validate/", AppWinStyle.NormalFocus, false, -1);
      else if (File.Exists(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe"))
        Interaction.Shell(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe http://www.microsoft.com/genuine/validate/", AppWinStyle.NormalFocus, false, -1);
      else
        Process.Start("http://www.microsoft.com/genuine/validate/");
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (!this._professional)
        return;
      this.ProduKeyInfo();
      this.MyPrintLine(this._razdelitel);
    }

    private void TabPage1_Click(object sender, EventArgs e)
    {
      if (this._professional)
        return;
      this.HideActivationMenu();
      this.HideInformationMenu();
    }

    private void RB3TAP_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm || !this.RB3TAP.Checked)
        return;
      this.DisableRadioButton();
      this.ModeTap = true;
      this._modeWd = false;
      this._modeAuto = false;
      this._modeAutoNo = false;
      this._modeHook = false;
      this.ComboBox3.Enabled = true;
      this.UninstallDivert();
      this.InstallTap();
      this._host = Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) != 0 ? this.ComboBox3.Text : this._autoModeHostTap;
      this.EnableRadioButton();
    }

    private void RB1AUTO_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm || !this.RB1AUTO.Checked)
        return;
      MyProject.Forms.AutoMode.Top = checked (this.Top + 20);
      MyProject.Forms.AutoMode.Left = checked (this.Left + 70);
      int num = (int) MyProject.Forms.AutoMode.ShowDialog();
      this.AutoModeListSet();
      this.DisableRadioButton();
      this.ModeTap = false;
      this.UnInstallTap();
      this._modeWd = false;
      this._modeAutoNo = false;
      this._modeAuto = true;
      this._modeHook = false;
      this.ComboBox3.Enabled = false;
      this.ComboBox3.Text = this._autoHostText;
      this.UnInstallTap();
      this.UninstallDivert();
      this._type = 0;
      this._autoModeHost = this._autoModeHostLh;
      this._host = this._autoModeHostLh;
      this._countActivations = 0;
      this._firstActivation = true;
      this.EnableRadioButton();
    }

    private void RB4NOAuto_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm || !this.RB4NOAuto.Checked)
        return;
      this.DisableRadioButton();
      this.ModeTap = false;
      this._modeWd = false;
      this._modeAuto = false;
      this._modeAutoNo = true;
      this._modeHook = false;
      this.ComboBox3.Enabled = true;
      this.UnInstallTap();
      this.UninstallDivert();
      this._type = -1;
      if (Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) == 0)
      {
        this._autoModeHost = this._autoModeHostLh;
        this._host = this._autoModeHostLh;
      }
      else
        this._host = this.ComboBox3.Text;
      this._countActivations = 0;
      this.EnableRadioButton();
    }

    private void RB2WDV_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm || !this.RB2WD.Checked)
        return;
      this.DisableRadioButton();
      this.ModeTap = false;
      this._modeWd = true;
      this._modeAuto = false;
      this._modeAutoNo = false;
      this._modeHook = false;
      this.ComboBox3.Enabled = true;
      this.UnInstallTap();
      this._host = Operators.CompareString(this.ComboBox3.Text, this._autoHostText, false) != 0 ? this.ComboBox3.Text : this._autoModeHostWd;
      this.EnableRadioButton();
    }

    private void RB5Hook_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm || !this.RB5Hook.Checked)
        return;
      this.DisableRadioButton();
      this.ModeTap = false;
      this._modeWd = false;
      this._modeAutoNo = false;
      this._modeAuto = false;
      this._modeHook = true;
      this.ComboBox3.Text = this._autoHostText;
      this.UnInstallTap();
      this.UninstallDivert();
      this._type = 3;
      this._countActivations = 0;
      this.EnableRadioButton();
      this._autoModeHost = this._autoModeHostHook;
      this._host = this._autoModeHostHook;
    }

    private int StopService(object name)
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = Conversions.ToString(Operators.ConcatenateObject((object) "stop ", name));
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_11;
label_9:
        num4 = 10;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_10:
        num4 = 11;
        num2 = Information.Err().Number;
        goto label_28;
label_11:
        num4 = 13;
        process.WaitForExit();
label_12:
        num4 = 14;
        if (Information.Err().Number == 0)
          goto label_15;
label_13:
        num4 = 15;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_14:
        num4 = 16;
        num2 = Information.Err().Number;
        goto label_28;
label_15:
        num4 = 18;
        int exitCode = process.ExitCode;
label_16:
        num4 = 19;
        process.Close();
label_17:
        num4 = 20;
        if (Information.Err().Number == 0)
          goto label_20;
label_18:
        num4 = 21;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_19:
        num4 = 22;
        num2 = Information.Err().Number;
        goto label_28;
label_20:
        num4 = 24;
        if (exitCode == 0)
          goto label_22;
label_21:
        num2 = exitCode;
        goto label_28;
label_22:
        num4 = 27;
        num2 = 0;
        goto label_28;
label_24:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
              case 17:
              case 23:
              case 26:
              case 28:
                goto label_28;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 15:
                goto label_13;
              case 16:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 20:
                goto label_17;
              case 21:
                goto label_18;
              case 22:
                goto label_19;
              case 24:
                goto label_20;
              case 25:
                goto label_21;
              case 27:
                goto label_22;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_24;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_28:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private int DeleteService(object name)
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        int num4 = 1;
        Process process = new Process();
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num4 = 3;
        process.StartInfo.FileName = "sc.exe";
label_3:
        num4 = 4;
        process.StartInfo.Arguments = Conversions.ToString(Operators.ConcatenateObject((object) "delete ", name));
label_4:
        num4 = 5;
        process.StartInfo.UseShellExecute = false;
label_5:
        num4 = 6;
        process.StartInfo.CreateNoWindow = true;
label_6:
        num4 = 7;
        process.StartInfo.RedirectStandardOutput = true;
label_7:
        num4 = 8;
        process.Start();
label_8:
        num4 = 9;
        if (Information.Err().Number == 0)
          goto label_11;
label_9:
        num4 = 10;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_10:
        num4 = 11;
        num2 = Information.Err().Number;
        goto label_28;
label_11:
        num4 = 13;
        process.WaitForExit();
label_12:
        num4 = 14;
        if (Information.Err().Number == 0)
          goto label_15;
label_13:
        num4 = 15;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_14:
        num4 = 16;
        num2 = Information.Err().Number;
        goto label_28;
label_15:
        num4 = 18;
        int exitCode = process.ExitCode;
label_16:
        num4 = 19;
        process.Close();
label_17:
        num4 = 20;
        if (Information.Err().Number == 0)
          goto label_20;
label_18:
        num4 = 21;
        this.MyPrintLine(Lang.RunTimeErr + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_19:
        num4 = 22;
        num2 = Information.Err().Number;
        goto label_28;
label_20:
        num4 = 24;
        if (exitCode == 0)
          goto label_22;
label_21:
        num2 = exitCode;
        goto label_28;
label_22:
        num4 = 27;
        num2 = 0;
        goto label_28;
label_24:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
              case 17:
              case 23:
              case 26:
              case 28:
                goto label_28;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 15:
                goto label_13;
              case 16:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 20:
                goto label_17;
              case 21:
                goto label_18;
              case 22:
                goto label_19;
              case 24:
                goto label_20;
              case 25:
                goto label_21;
              case 27:
                goto label_22;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_24;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_28:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.WinDivertSettings.Top = checked (this.Top + 20);
      MyProject.Forms.WinDivertSettings.Left = checked (this.Left + 20);
      int num = (int) MyProject.Forms.WinDivertSettings.ShowDialog();
    }

    private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.AutoMode.Top = checked (this.Top + 20);
      MyProject.Forms.AutoMode.Left = checked (this.Left + 70);
      int num = (int) MyProject.Forms.AutoMode.ShowDialog();
      this.AutoModeListSet();
    }

    private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.NoAutoSettings.Top = checked (this.Top + 20);
      MyProject.Forms.NoAutoSettings.Left = checked (this.Left + 70);
      int num = (int) MyProject.Forms.NoAutoSettings.ShowDialog();
    }

    private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.TapSettings.Top = checked (this.Top + 20);
      MyProject.Forms.TapSettings.Left = checked (this.Left + 70);
      int num = (int) MyProject.Forms.TapSettings.ShowDialog();
    }

    private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.KmsSetting.Top = checked (this.Top + 20);
      MyProject.Forms.KmsSetting.Left = checked (this.Left + 50);
      int num = (int) MyProject.Forms.KmsSetting.ShowDialog();
    }

    private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.KmsSetting.Top = checked (this.Top + 150);
      MyProject.Forms.KmsSetting.Left = checked (this.Left + 50);
      int num = (int) MyProject.Forms.KmsSetting.ShowDialog();
    }

    public object DelFile(string filepath)
    {
      object maxValue = (object) (int) byte.MaxValue;
      string Path = FileSystem.CurDir();
      int num = Strings.InStrRev(filepath, "\\", -1, CompareMethod.Binary);
      if (File.Exists(filepath))
      {
        File.SetAttributes(filepath, FileAttributes.Normal);
        if (num == 0)
        {
          Interaction.Shell(this.SysPath + "cmd.exe /c del /F /Q \"" + filepath + "\"", AppWinStyle.Hide, true, -1);
        }
        else
        {
          FileSystem.ChDir(Strings.Mid(filepath, 1, checked (num - 1)));
          Interaction.Shell(this.SysPath + "cmd.exe /c del /F /Q \"" + Strings.Mid(filepath, checked (num + 1)) + "\"", AppWinStyle.Hide, true, -1);
        }
      }
      FileSystem.ChDir(Path);
      return maxValue;
    }

    public object DelDir(string dirpath)
    {
      object maxValue = (object) (int) byte.MaxValue;
      int num = 0;
      FileSystem.CurDir();
      if (Directory.Exists(dirpath))
      {
        while (Directory.Exists(dirpath))
        {
          this.StartProcessHide(this.SysPath + "cmd.exe", "/c rd \"" + dirpath + "\" /S /Q", true);
          Application.DoEvents();
          checked { ++num; }
          if (num > 5)
            break;
        }
      }
      return maxValue;
    }

    private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MyProject.Forms.HookSetting.Top = checked (this.Top + 20);
      MyProject.Forms.HookSetting.Left = checked (this.Left + 20);
      int num = (int) MyProject.Forms.HookSetting.ShowDialog();
    }

    private void ChkBoxReset_CheckedChanged_1(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      this.LoadingProgramm = true;
      if (!this.ChkBoxReset.Checked)
        return;
      this.ChkBoxReset.Enabled = false;
      this.ChkBoxReset.Refresh();
      Thread.Sleep(600);
      this.DelDir(this._localappdata);
      this.DelFile(Application.StartupPath + this._kmsAutoFileList[0]);
      int positionLeft = this._positionLeft;
      int positionTop = this._positionTop;
      if (this.ModeTap)
        this.UnInstallTap();
      this.DelKMSServer_Button();
      this.SchtasksDel();
      this.KMS_SchedulerFlagShow();
      this.MyPrintLine("clear");
      this.TabControl1.SelectedTab = this.TabPage1;
      this.Create_INI_File();
      this.LoadProgramSetting();
      this._positionLeft = positionLeft;
      this._positionTop = positionTop;
      this.LoadingProgramm = false;
      Application.Restart();
    }

    private void Button41_Click(object sender, EventArgs e)
    {
      if (!this._btnVideo)
      {
        this.ButtonVideo.Show();
        this.ButtonVideo.Refresh();
        this.ButtonVideoSearch.Show();
        this.ButtonVideoSearch.Refresh();
        this._btnVideo = true;
        Thread.Sleep(300);
      }
      else
      {
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this.ShowReadme();
        Thread.Sleep(300);
        this._btnVideo = false;
      }
    }

    private void ButtonValidator_Click(object sender, EventArgs e)
    {
      MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
      if ((this._cmDlineExist ? DialogResult.OK : MessageBox.Show(Lang.ValidatorMessage, Lang.Caption2, buttons)) != DialogResult.OK)
        return;
      this.StartProcessHide("net", "stop sppsvc /y", true);
      Process[] processesByName = Process.GetProcessesByName("sppsvc");
      int index = 0;
      while (index < processesByName.Length)
      {
        processesByName[index].Kill();
        checked { ++index; }
      }
      this.TabControl1.SelectedTab = this.TabPage1;
      this.Refresh();
      this.MyPrintLine(Lang.ButtonRuns);
      if (File.Exists(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat"))
      {
        File.SetAttributes(this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.Windir + "\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\SoftwareProtectionPlatform\\tokens.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\cache\\cache.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\cache\\cache.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\cache\\cache.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\data.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\data.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\data.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\tokens.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\tokens.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\tokens.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\2.0\\cache\\cache.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\cache\\cache.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\cache\\cache.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\2.0\\data.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\data.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\data.dat\"", AppWinStyle.Hide, true, -1);
      }
      if (File.Exists(this.SysPath + "spp\\store\\2.0\\tokens.dat"))
      {
        File.SetAttributes(this.SysPath + "spp\\store\\2.0\\tokens.dat", FileAttributes.Normal);
        Interaction.Shell("cmd.exe /c del /F /Q \"" + this.SysPath + "spp\\store\\2.0\\tokens.dat\"", AppWinStyle.Hide, true, -1);
      }
      this.MyPrintLine(Lang.DelSysFilesCompleteTxt);
    }

    private void ButtonVideo_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string fileName = "http://www.youtube.com/watch?v=niXf0ov0S8I";
      if (File.Exists(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe"))
      {
        Interaction.Shell(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
      else if (File.Exists(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe"))
      {
        Interaction.Shell(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
      else
      {
        Process.Start(fileName);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      this.ButtonVideo.Hide();
      this.ButtonVideoSearch.Hide();
      this._btnVideo = false;
    }

    private void TabPage4_Click(object sender, EventArgs e)
    {
      this.ButtonVideo.Hide();
      this.ButtonVideoSearch.Hide();
      this._btnVideo = false;
    }

    private void ButtonVideoSearch_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      string fileName = "http://www.youtube.com/results?search_query=%22KMSAuto%20Net%202015%22";
      if (File.Exists(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe"))
      {
        Interaction.Shell(this._systemdrive + "\\Program Files (x86)\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
      else if (File.Exists(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe"))
      {
        Interaction.Shell(this._systemdrive + "\\Program Files\\Internet Explorer\\iexplore.exe " + fileName, AppWinStyle.NormalFocus, false, -1);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
      else
      {
        Process.Start(fileName);
        this.ButtonVideo.Hide();
        this.ButtonVideoSearch.Hide();
        this._btnVideo = false;
      }
    }

    private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      this._port = Conversions.ToString(this.NumericUpDown1.Value);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void AIUpDown()
    {
      int num1 = 0;
      int num2 = 0;
      this._sai = Conversions.ToString(this.NumericUpDown2.Value);
      int int32 = Convert.ToInt32(this.NumericUpDown2.Value);
      if (int32 >= 60)
      {
        num2 = int32 / 60;
        checked { int32 -= num2 * 60; }
      }
      if (num2 >= 24)
      {
        num1 = num2 / 24;
        checked { num2 -= num1 * 24; }
      }
      string str1 = Conversions.ToString(int32);
      string str2 = Conversions.ToString(num2);
      string str3 = Conversions.ToString(num1);
      if (str1.Length < 2)
        str1 = "0" + str1;
      if (str2.Length < 2)
        str2 = "0" + str2;
      if (str3.Length < 2)
        str3 = "0" + str3;
      this.LabelAITime.Text = str3 + Lang.ComboBox4Cols8 + str2 + Lang.ComboBox4Cols2 + str1 + Lang.ComboBox4Cols1;
      this.NumericUpDown2.Refresh();
    }

    private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      this.AIUpDown();
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void RIUpDown()
    {
      int num1 = 0;
      int num2 = 0;
      this._sri = Conversions.ToString(this.NumericUpDown3.Value);
      int int32 = Convert.ToInt32(this.NumericUpDown3.Value);
      if (int32 >= 60)
      {
        num2 = int32 / 60;
        checked { int32 -= num2 * 60; }
      }
      if (num2 >= 24)
      {
        num1 = num2 / 24;
        checked { num2 -= num1 * 24; }
      }
      string str1 = Conversions.ToString(int32);
      string str2 = Conversions.ToString(num2);
      string str3 = Conversions.ToString(num1);
      if (str1.Length < 2)
        str1 = "0" + str1;
      if (str2.Length < 2)
        str2 = "0" + str2;
      if (str3.Length < 2)
        str3 = "0" + str3;
      this.LabelRITime.Text = str3 + Lang.ComboBox4Cols8 + str2 + Lang.ComboBox4Cols2 + str1 + Lang.ComboBox4Cols1;
      this.NumericUpDown3.Refresh();
    }

    private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
    {
      this.RIUpDown();
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void CheckBoxKP_CheckedChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox1.Checked)
        this._delKmsServer = true;
      else
        this._delKmsServer = false;
    }

    private void CBox7IniFile_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      this.CBox7IniFile.Enabled = false;
      this.CBox7IniFile.Refresh();
      if (this.CBox7IniFile.Checked)
      {
        this.SaveInIinfolder = true;
        this.DelDir(this._localappdata);
      }
      else
      {
        this.SaveInIinfolder = false;
        this.DelFile(Application.StartupPath + this._kmsAutoFileList[0]);
      }
      this.SaveProgramSetting();
      this.CBox7IniFile.Enabled = true;
    }

    private void CheckBoxAnalizer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      if (this.CheckBoxAnalizer.Checked)
      {
        FileSystem.ChDir(Application.StartupPath);
        while (!File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("KMS Log Analyzer.xlsm", KMSAuto_Net.My.Resources.Resources.KMS_Log_Analyzer, false);
          Application.DoEvents();
        }
      }
      else if (File.Exists(Application.StartupPath + "\\KMS Log Analyzer.xlsm") && MessageBox.Show(Lang.KmsAnalizerDelTxt, Lang.Caption2, MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        this.DelFile(Application.StartupPath + "\\KMS Log Analyzer.xlsm");
        if (File.Exists(Application.StartupPath + "\\KMS Log File.log"))
          this.DelFile(Application.StartupPath + "\\KMS Log File.log");
      }
      this.KMS_SchedulerFlagShow();
    }

    private void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox3.Checked)
        this._noLogo = false;
      else
        this._noLogo = true;
    }

    private void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox5.Checked)
        this._sounds = true;
      else
        this._sounds = false;
    }

    private void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox4.Checked)
        this._addFunctions = true;
      else
        this._addFunctions = false;
    }

    private void PictureBox9_Click(object sender, EventArgs e)
    {
      MyProject.Forms.FormKmsHelp.Top = checked (this.Top + 10);
      MyProject.Forms.FormKmsHelp.Left = checked (this.Left - 60);
      int num = (int) MyProject.Forms.FormKmsHelp.ShowDialog();
      MyProject.Forms.FormKmsHelp.Refresh();
    }

    private void Button23_Click(object sender, EventArgs e)
    {
      FileSystem.ChDir(this.Tempdir);
      while (!File.Exists(this.Tempdir + "\\hidecontrol.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("hidecontrol.dat", KMSAuto_Net.My.Resources.Resources.hidecontrol, false);
        Application.DoEvents();
      }
      Interaction.Shell(this.SysPath + "cmd.exe /c hidecontrol.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      this.DelFile("hidecontrol.dat");
      Interaction.Shell(this.Tempdir + "\\ShowHideControls.exe", AppWinStyle.NormalFocus, true, -1);
      this.DelFile(this.Tempdir + "\\ShowHideControls.exe");
    }

    private void Button36_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      Process.Start("http://habrahabr.ru/post/192986/");
    }

    private void Button37_Click(object sender, EventArgs e)
    {
      this.Button37.Enabled = false;
      MyProject.Forms.OfficeConvert.Top = checked (this.Top + 70);
      MyProject.Forms.OfficeConvert.Left = checked (this.Left + 70);
      int num = (int) MyProject.Forms.OfficeConvert.ShowDialog();
      this.Button37.Enabled = true;
    }

    private void ComboBoxHwid_SelectedIndexChanged(object sender, EventArgs e)
    {
      this._hwid = Conversions.ToString(this.ComboBoxHwid.SelectedItem);
      if (Operators.CompareString(this.KmsFlag, "KMS", false) == 0)
        this.CheckKmsService();
      this._index7 = this.ComboBoxHwid.SelectedIndex;
    }

    private void ButtonHwPl_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (Operators.CompareString(this.ComboBoxHwid.Text, Lang.HwidDefaulttTxt, false) == 0 || Operators.ConditionalCompareObjectGreater(this.CheckHwidFormat(this.ComboBoxHwid.Text, true), (object) 0, false))
        return;
      this.ComboBoxHwid.Text = Strings.UCase(this.ComboBoxHwid.Text);
      bool flag = false;
      try
      {
        foreach (object obj in this.ComboBoxHwid.Items)
        {
          if (Operators.CompareString(Conversions.ToString(obj), this.ComboBoxHwid.Text, false) == 0)
            flag = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
        return;
      this.ComboBoxHwid.Items.Add((object) this.ComboBoxHwid.Text);
      this._hwid = this.ComboBoxHwid.Text;
      this.ComboBoxHwid.SelectedIndex = checked (this.ComboBoxHwid.Items.Count - 1);
      this._index7 = this.ComboBoxHwid.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void ButtonHwMn_Click(object sender, EventArgs e)
    {
      this.MyAudioClick();
      if (this.ComboBoxHwid.Items.Count == 1 || Operators.CompareString(this.ComboBoxHwid.Text, Lang.HwidDefaulttTxt, false) == 0)
        return;
      this.ComboBoxHwid.Items.Remove((object) this.ComboBoxHwid.Text);
      this.ComboBoxHwid.SelectedIndex = this._index7 <= checked (this.ComboBoxHwid.Items.Count - 1) ? this._index7 : checked (this._index7 - 1);
      this._hwid = this.ComboBoxHwid.Text;
      this._index7 = this.ComboBoxHwid.SelectedIndex;
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    public object CheckHwidFormat(string Hwid, bool viewMessage)
    {
      object obj;
      if (!new Regex("^[0-9a-fA-F]{16}$").IsMatch(Strings.UCase(Strings.Trim(Hwid))))
      {
        if (viewMessage)
        {
          int num = (int) Interaction.MsgBox((object) Lang.HwidFormatTxt, MsgBoxStyle.Exclamation, (object) Lang.HwidFormatCheckTxt);
        }
        obj = (object) (int) byte.MaxValue;
      }
      else
        obj = (object) 0;
      return obj;
    }

    private void Button38_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Utilities.Top = checked (this.Top + 10);
      MyProject.Forms.Utilities.Left = checked (this.Left + 10);
      int num = (int) MyProject.Forms.Utilities.ShowDialog();
      MyProject.Forms.Utilities.Refresh();
    }

    private void CheckBoxInstKey_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      if (this.CheckBoxInstKey.Checked)
        this._instKey = true;
      else
        this._instKey = false;
    }

    private void CheckBoxLog_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      this.MyAudioClick();
      if (this.CheckBoxLog.Checked)
      {
        this._logFile = true;
      }
      else
      {
        this._logFile = false;
        this.CheckBoxIP.Checked = false;
      }
      this.CheckBoxIP.Refresh();
      this.CheckBoxLog.Refresh();
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void CheckBoxShowIP_CheckedChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      this.MyAudioClick();
      if (this.CheckBoxIP.Checked)
      {
        this.CheckBoxLog.Checked = true;
        this._logFileIp = true;
      }
      else
        this._logFileIp = false;
      this.CheckBoxIP.Refresh();
      this.CheckBoxLog.Refresh();
      if (Operators.CompareString(this.KmsFlag, "KMS", false) != 0)
        return;
      this.CheckKmsService();
    }

    private void CheckTaskParamAndSetShedule(string prodact)
    {
      string Left = "";
      if (File.Exists(this.SysPath + "\\Tasks\\KMSAutoNet"))
      {
        this.DelFile(this.Tempdir + "\\KMSAutoNet.tmp");
        Interaction.Shell(this.SysPath + "cmd.exe /c copy " + this.Windir + "\\system32\\Tasks\\KMSAutoNet \"" + this.Tempdir + "\\KMSAutoNet.tmp\" /Y", AppWinStyle.Hide, true, -1);
        Left = File.ReadAllText(this.Tempdir + "\\KMSAutoNet.tmp");
        this.DelFile(this.Tempdir + "\\KMSAutoNet.tmp");
      }
      if (Strings.LCase(Left).Contains("/win=act") & Strings.LCase(Left).Contains("/off=act") | Operators.CompareString(prodact, "all", false) == 0)
      {
        this.ComboBox7.Text = Lang.ComboBox7Cols1;
        this.SchtasksSet();
      }
      else
      {
        if (Strings.LCase(Left).Contains("/win=act"))
          Left = "win";
        else if (Strings.LCase(Left).Contains("/off=act"))
          Left = "off";
        if (Operators.CompareString(prodact, "win", false) == 0)
        {
          if (Operators.CompareString(Left, "off", false) == 0)
          {
            this.ComboBox7.Text = Lang.ComboBox7Cols1;
            this.SchtasksSet();
          }
          else
          {
            this.ComboBox7.Text = Lang.ComboBox7Cols2;
            this.SchtasksSet();
          }
        }
        else
        {
          if (Operators.CompareString(prodact, "off", false) != 0)
            return;
          if (Operators.CompareString(Left, "win", false) == 0)
          {
            this.ComboBox7.Text = Lang.ComboBox7Cols1;
            this.SchtasksSet();
          }
          else
          {
            this.ComboBox7.Text = Lang.ComboBox7Cols3;
            this.SchtasksSet();
          }
        }
      }
    }

    private void Button41_Click_1(object sender, EventArgs e)
    {
      this.MyPrintLine("clear");
      this.Intro();
      this.MyPrintLine("clear");
      this.MyPrintLine("           -----=====     " + this._version + "     =====-----");
    }

    private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.LoadingProgramm)
        return;
      if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangRu, false) == 0)
        this.TargetLang = "RU";
      else if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangEn, false) == 0)
        this.TargetLang = "EN";
      else if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangFr, false) == 0)
        this.TargetLang = "FR";
      else if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangEs, false) == 0)
        this.TargetLang = "ES";
      else if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangVi, false) == 0)
      {
        this.TargetLang = "VI";
      }
      else
      {
        if (Operators.CompareString(this.ComboBoxLangs.Text, Lang.TargetLangUa, false) != 0)
          return;
        this.TargetLang = "UA";
      }
      this.SaveProgramSetting();
      Application.Restart();
    }

    private void ButtonOfficeScript_Click(object sender, EventArgs e)
    {
      FileSystem.ChDir(this.Tempdir);
      if (Operators.CompareString(this.TargetLang, "RU", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_RU, false);
          Application.DoEvents();
        }
      }
      else if (Operators.CompareString(this.TargetLang, "EN", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_EN, false);
          Application.DoEvents();
        }
      }
      else if (Operators.CompareString(this.TargetLang, "FR", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_FR, false);
          Application.DoEvents();
        }
      }
      else if (Operators.CompareString(this.TargetLang, "ES", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_ES, false);
          Application.DoEvents();
        }
      }
      else if (Operators.CompareString(this.TargetLang, "UA", false) == 0)
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_UA, false);
          Application.DoEvents();
        }
      }
      else
      {
        while (!File.Exists(this.Tempdir + "\\MS_Office_updates_del.cmd"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("MS_Office_updates_del.cmd", KMSAuto_Net.My.Resources.Resources.MS_Office_updates_del_EN, false);
          Application.DoEvents();
        }
      }
      this.BackGroundRun = true;
      Interaction.Shell(this.SysPath + "cmd.exe /c MS_Office_updates_del.cmd", AppWinStyle.NormalFocus, false, -1);
    }

    private bool CheckOfficeRetailForm1()
    {
label_0:
      int num1;
      bool flag;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 1;
label_1:
        int num3 = 2;
        flag = false;
label_2:
        num3 = 3;
        this._officeInstalled = false;
label_3:
        num3 = 4;
        string wmiSpp = MyProject.Forms.OfficeConvert.GetWMI_SPP("Office 15");
label_4:
        num3 = 5;
        this.SetWMIService();
label_5:
        num3 = 6;
        object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT Name, Description, LicenseStatus FROM " + wmiSpp + " WHERE PartialProductKey <> null")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_6:
        num3 = 7;
        string str1 = "";
label_7:
        num3 = 8;
        string str2 = "";
label_8:
        num3 = 9;
        IEnumerator enumerator1 = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_21;
label_10:
        num3 = 10;
        object objectValue2;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue2)))
          goto label_20;
label_11:
        num3 = 11;
        str1 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_12:
        num3 = 12;
        str2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_13:
        num3 = 13;
        if (!(Strings.InStr(Strings.UCase(str1), "OFFICE", CompareMethod.Binary) > 0 & (Strings.InStr(Strings.UCase(str1), "OFFICE 15", CompareMethod.Binary) > 0 | Strings.InStr(Strings.UCase(str1), "OFFICE 16", CompareMethod.Binary) > 0)))
          goto label_20;
label_14:
        num3 = 14;
        this._officeInstalled = true;
label_15:
        num3 = 15;
        if (!Strings.UCase(str2).Contains("RETAIL"))
          goto label_20;
label_16:
        num3 = 16;
        if (!(Strings.UCase(str1).Contains("PROPLUS") | Strings.UCase(str1).Contains("VISIOPRO") | Strings.UCase(str1).Contains("PROJECTPRO") | Strings.UCase(str1).Contains("WORD") | Strings.UCase(str1).Contains("EXCEL") | Strings.UCase(str1).Contains("ACCESS") | Strings.UCase(str1).Contains("ONENOTE") | Strings.UCase(str1).Contains("OUTLOOK") | Strings.UCase(str1).Contains("POWERPOINT") | Strings.UCase(str1).Contains("PUBLISHER")))
          goto label_20;
label_17:
        num3 = 17;
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, (Type) null, "LicenseStatus", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_18:
        num3 = 18;
        if (integer == 1)
          goto label_20;
label_19:
        num3 = 19;
        flag = true;
label_20:
        num3 = 20;
label_21:
        if (enumerator1.MoveNext())
        {
          objectValue2 = RuntimeHelpers.GetObjectValue(enumerator1.Current);
          goto label_10;
        }
label_22:
        num3 = 21;
        if (enumerator1 is IDisposable)
          (enumerator1 as IDisposable).Dispose();
label_24:
        num3 = 22;
        wmiSpp = MyProject.Forms.OfficeConvert.GetWMI_SPP("Office 14");
label_25:
        num3 = 23;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT Name, Description, LicenseStatus FROM " + wmiSpp + " WHERE PartialProductKey <> null")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_26:
        num3 = 24;
        IEnumerator enumerator2 = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_34;
label_28:
        num3 = 25;
        object objectValue3;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue3)))
          goto label_33;
label_29:
        num3 = 26;
        str1 = Conversions.ToString(NewLateBinding.LateGet(objectValue3, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_30:
        num3 = 27;
        str2 = Conversions.ToString(NewLateBinding.LateGet(objectValue3, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_31:
        num3 = 28;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE", CompareMethod.Binary) <= 0)
          goto label_33;
label_32:
        num3 = 29;
        this._officeInstalled = true;
label_33:
        num3 = 30;
label_34:
        if (enumerator2.MoveNext())
        {
          objectValue3 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
          goto label_28;
        }
label_35:
        num3 = 31;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
label_37:
        num3 = 32;
        this.objWMIService = (object) null;
label_38:
        num3 = 33;
        this.objSWbemLocator = (object) null;
label_39:
        num3 = 34;
        this.objCtx = (object) null;
        goto label_45;
label_41:
        num2 = num3;
        switch (num1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 8:
                goto label_7;
              case 9:
                goto label_8;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_22;
              case 22:
                goto label_24;
              case 23:
                goto label_25;
              case 24:
                goto label_26;
              case 25:
                goto label_28;
              case 26:
                goto label_29;
              case 27:
                goto label_30;
              case 28:
                goto label_31;
              case 29:
                goto label_32;
              case 30:
                goto label_33;
              case 31:
                goto label_35;
              case 32:
                goto label_37;
              case 33:
                goto label_38;
              case 34:
                goto label_39;
              case 35:
                goto label_45;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_41;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_45:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return flag;
    }

    public int SetWMIService()
    {
label_0:
      int num1;
      int num2;
      int num3;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 1;
label_1:
        int num4 = 2;
        if (!Environment.Is64BitOperatingSystem)
          goto label_17;
label_2:
        num4 = 3;
        this.objCtx = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WbemScripting.SWbemNamedValueSet", ""));
label_3:
        num4 = 4;
        if (Information.Err().Number == 0)
          goto label_6;
label_4:
        num4 = 5;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_5:
        num4 = 6;
        num2 = Information.Err().Number;
        goto label_57;
label_6:
        num4 = 8;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.objCtx)))
          goto label_9;
label_7:
        num4 = 9;
        this.MyPrintLine(Lang.WmiaErrobjCtx);
label_8:
        num4 = 10;
        num2 = -2147217392;
        goto label_57;
label_9:
        num4 = 12;
        NewLateBinding.LateCall(this.objCtx, (Type) null, "Add", new object[2]
        {
          (object) "__ProviderArchitecture",
          (object) 64
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
label_10:
        num4 = 13;
        if (Information.Err().Number == 0)
          goto label_13;
label_11:
        num4 = 14;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_12:
        num4 = 15;
        num2 = Information.Err().Number;
        goto label_57;
label_13:
        num4 = 17;
        NewLateBinding.LateCall(this.objCtx, (Type) null, "Add", new object[2]
        {
          (object) "__RequiredArchitecture",
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
label_14:
        num4 = 18;
        if (Information.Err().Number == 0)
          goto label_17;
label_15:
        num4 = 19;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_16:
        num4 = 20;
        num2 = Information.Err().Number;
        goto label_57;
label_17:
        num4 = 22;
        this.objSWbemLocator = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WbemScripting.SWbemLocator", ""));
label_18:
        num4 = 23;
        if (Information.Err().Number == 0)
          goto label_21;
label_19:
        num4 = 24;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_20:
        num4 = 25;
        num2 = Information.Err().Number;
        goto label_57;
label_21:
        num4 = 27;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.objSWbemLocator)))
          goto label_24;
label_22:
        num4 = 28;
        this.MyPrintLine(Lang.WmiaErrobjSWbemLocator);
label_23:
        num4 = 29;
        num2 = -2147217392;
        goto label_57;
label_24:
        num4 = 31;
        if (!Environment.Is64BitOperatingSystem)
          goto label_28;
label_25:
        num4 = 32;
        object objSwbemLocator = this.objSWbemLocator;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "ConnectServer";
        // ISSUE: variable of a reference type
        object& local2;
        object[] Arguments;
        // ISSUE: explicit reference operation
        // ISSUE: explicit reference operation
        object[] objArray = Arguments = new object[8]
        {
          (object) ".",
          (object) "root\\cimv2",
          (object) "",
          (object) "",
          (object) Missing.Value,
          (object) Missing.Value,
          (object) Missing.Value,
          ^(local2 = @this.objCtx)
        };
        // ISSUE: variable of the null type
        __Null local3 = null;
        // ISSUE: variable of the null type
        __Null local4 = null;
        bool[] CopyBack = new bool[8];
        CopyBack[7] = true;
        bool[] flagArray = CopyBack;
        object obj = NewLateBinding.LateGet(objSwbemLocator, (Type) local1, MemberName, Arguments, (string[]) local3, (Type[]) local4, CopyBack);
        if (flagArray[7])
        {
          // ISSUE: explicit reference operation
          ^local2 = RuntimeHelpers.GetObjectValue(objArray[7]);
        }
        this.objWMIService = RuntimeHelpers.GetObjectValue(obj);
        goto label_29;
label_28:
        num4 = 34;
        this.objWMIService = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.objSWbemLocator, (Type) null, "ConnectServer", new object[2]
        {
          (object) ".",
          (object) "root\\cimv2"
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_29:
        num4 = 35;
        if (Information.Err().Number == 0)
          goto label_34;
label_30:
        num4 = 36;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_31:
        num4 = 37;
        this.objSWbemLocator = (object) null;
label_32:
        num4 = 38;
        this.objCtx = (object) null;
label_33:
        num4 = 39;
        num2 = Information.Err().Number;
        goto label_57;
label_34:
        num4 = 41;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.objWMIService)))
          goto label_37;
label_35:
        num4 = 42;
        this.MyPrintLine(Lang.WmiaErrobjWmiService);
label_36:
        num4 = 43;
        num2 = -2147217392;
        goto label_57;
label_37:
        num4 = 45;
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.objWMIService, (Type) null, "Security_", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "ImpersonationLevel", new object[1]
        {
          (object) 3
        }, (string[]) null, (Type[]) null, false, true);
label_38:
        num4 = 46;
        if (Information.Err().Number == 0)
          goto label_44;
label_39:
        num4 = 47;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_40:
        num4 = 48;
        this.objWMIService = (object) null;
label_41:
        num4 = 49;
        this.objSWbemLocator = (object) null;
label_42:
        num4 = 50;
        this.objCtx = (object) null;
label_43:
        num4 = 51;
        num2 = Information.Err().Number;
        goto label_57;
label_44:
        num4 = 53;
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.objWMIService, (Type) null, "Security_", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AuthenticationLevel", new object[1]
        {
          (object) 6
        }, (string[]) null, (Type[]) null, false, true);
label_45:
        num4 = 54;
        if (Information.Err().Number == 0)
          goto label_51;
label_46:
        num4 = 55;
        this.MyPrintLine(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_47:
        num4 = 56;
        this.objWMIService = (object) null;
label_48:
        num4 = 57;
        this.objSWbemLocator = (object) null;
label_49:
        num4 = 58;
        this.objCtx = (object) null;
label_50:
        num4 = 59;
        num2 = Information.Err().Number;
        goto label_57;
label_51:
        num4 = 61;
        num2 = 0;
        goto label_57;
label_53:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num5 = num3 + 1;
            num3 = 0;
            switch (num5)
            {
              case 1:
                goto label_0;
              case 2:
                goto label_1;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
              case 11:
              case 16:
              case 21:
              case 26:
              case 30:
              case 40:
              case 44:
              case 52:
              case 60:
              case 62:
                goto label_57;
              case 8:
                goto label_6;
              case 9:
                goto label_7;
              case 10:
                goto label_8;
              case 12:
                goto label_9;
              case 13:
                goto label_10;
              case 14:
                goto label_11;
              case 15:
                goto label_12;
              case 17:
                goto label_13;
              case 18:
                goto label_14;
              case 19:
                goto label_15;
              case 20:
                goto label_16;
              case 22:
                goto label_17;
              case 23:
                goto label_18;
              case 24:
                goto label_19;
              case 25:
                goto label_20;
              case 27:
                goto label_21;
              case 28:
                goto label_22;
              case 29:
                goto label_23;
              case 31:
                goto label_24;
              case 32:
                goto label_25;
              case 33:
              case 35:
                goto label_29;
              case 34:
                goto label_28;
              case 36:
                goto label_30;
              case 37:
                goto label_31;
              case 38:
                goto label_32;
              case 39:
                goto label_33;
              case 41:
                goto label_34;
              case 42:
                goto label_35;
              case 43:
                goto label_36;
              case 45:
                goto label_37;
              case 46:
                goto label_38;
              case 47:
                goto label_39;
              case 48:
                goto label_40;
              case 49:
                goto label_41;
              case 50:
                goto label_42;
              case 51:
                goto label_43;
              case 53:
                goto label_44;
              case 54:
                goto label_45;
              case 55:
                goto label_46;
              case 56:
                goto label_47;
              case 57:
                goto label_48;
              case 58:
                goto label_49;
              case 59:
                goto label_50;
              case 61:
                goto label_51;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_53;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_57:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private void PrintErrorCode()
    {
      if (Strings.UCase(this.Errorcodetxt).Contains("C004F035"))
      {
        this.MyPrintLine(Lang.WmiaApActFailed + "c004F035");
        this.MyPrintLine(Lang.LMsgErrorC004F035);
      }
      else if (Strings.UCase(this.Errorcodetxt).Contains("C004F074"))
      {
        this.MyPrintLine(Lang.WmiaApActFailed + "c004F074");
        this.MyPrintLine(Lang.LMsgErrorC004F074);
      }
      this.Errorcodetxt = "";
    }

    private void CheckBoxFakeIP_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBoxFakeIP.Checked)
      {
        this.TextBoxFakeIP.Enabled = true;
      }
      else
      {
        this.TextBoxFakeIP.Enabled = false;
        this._host = this._autoModeHostWd;
      }
    }

    private string GenerateIp()
    {
      string str1;
      if (this.CheckIPformat(this.TextBoxFakeIP.Text))
      {
        str1 = this.TextBoxFakeIP.Text;
      }
      else
      {
        this.TextBoxFakeIP.Text = "random";
        VBMath.Randomize();
        string Left = Conversions.ToString(checked ((int) Math.Round(Math.Floor(unchecked (186.0 * (double) VBMath.Rnd()))) + 15));
        if (Operators.CompareString(Left, "192", false) == 0 | Operators.CompareString(Left, "127", false) == 0)
          Left = "100";
        VBMath.Randomize();
        string str2 = Conversions.ToString(checked ((int) Math.Round(Math.Floor(unchecked (251.0 * (double) VBMath.Rnd()))) + 0));
        VBMath.Randomize();
        string str3 = Conversions.ToString(checked ((int) Math.Round(Math.Floor(unchecked (251.0 * (double) VBMath.Rnd()))) + 0));
        VBMath.Randomize();
        string str4 = Conversions.ToString(checked ((int) Math.Round(Math.Floor(unchecked (239.0 * (double) VBMath.Rnd()))) + 12));
        str1 = Left + "." + str2 + "." + str3 + "." + str4;
      }
      return str1;
    }

    private bool CheckIPformat(string ip)
    {
      bool flag;
      if (new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$").IsMatch(ip))
      {
        flag = true;
        while (ip.Length > 0)
        {
          int num = Strings.InStr(ip, ".", CompareMethod.Binary);
          if (num > 0)
          {
            if (Conversions.ToInteger(Strings.LSet(ip, checked (num - 1))) > (int) byte.MaxValue)
              flag = false;
            ip = Strings.Mid(ip, checked (num + 1));
          }
          else
          {
            if (Conversions.ToInteger(ip) > (int) byte.MaxValue)
              flag = false;
            ip = "";
          }
        }
      }
      else
        flag = false;
      return flag;
    }

    private void TextBoxFakeIP_TextChanged(object sender, EventArgs e)
    {
      this.TextBoxFakeIP.Text = Strings.Trim(this.TextBoxFakeIP.Text);
      if (this.CheckIPformat(this.TextBoxFakeIP.Text))
        return;
      this.TextBoxFakeIP.Text = "random";
    }

    private void ButtonHideUpdates_Click(object sender, EventArgs e)
    {
      FileSystem.ChDir(this.Tempdir);
      while (!File.Exists(this.Tempdir + "\\wushowhide.diagcab"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("wushowhide.diagcab", KMSAuto_Net.My.Resources.Resources.wushowhide, false);
        Application.DoEvents();
      }
      Process.Start(this.Tempdir + "\\wushowhide.diagcab");
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      string pid = this.GeneratePid();
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Windows", false))
      {
        this.ComboBox1.Items.Add((object) pid);
        this.SaveProgramSetting();
        this.ComboBox1.SelectedIndex = checked (this.ComboBox1.Items.Count - 1);
        this._index1 = this.ComboBox1.SelectedIndex;
      }
      if (Operators.ConditionalCompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Office 2010", false))
      {
        this.ComboBox6.Items.Add((object) pid);
        this.SaveProgramSetting();
        this.ComboBox6.SelectedIndex = checked (this.ComboBox6.Items.Count - 1);
        this._index6 = this.ComboBox6.SelectedIndex;
      }
      if (!Operators.ConditionalCompareObjectEqual(this.ComboBox8.SelectedItem, (object) "Office 2013/16", false))
        return;
      this.ComboBox2.Items.Add((object) pid);
      this.SaveProgramSetting();
      this.ComboBox2.SelectedIndex = checked (this.ComboBox2.Items.Count - 1);
      this._index2 = this.ComboBox2.SelectedIndex;
    }
  }
}
