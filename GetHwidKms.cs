// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.GetHwidKms
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class GetHwidKms : Form
  {
    private IContainer components;
    public string Tempdir;
    public string SysPath;
    private string _systemroot;
    private string _product;
    private string _protocol;
    private string _memo;
    private string _memoprot;

    public GetHwidKms()
    {
      this.FormClosed += new FormClosedEventHandler(this.GetHwidKMS_FormClosed);
      this.Load += new EventHandler(this.GetHwidKMS_Load);
      this.Tempdir = Interaction.Environ("TEMP");
      this.SysPath = "";
      this._systemroot = Interaction.Environ("SYSTEMROOT");
      this._product = "/A=3c40b358-5948-45af-923b-53d21fcc7e79";
      this._protocol = "/6";
      this._memo = "";
      this._memoprot = "";
      this.InitializeComponent();
    }

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GetHwidKms));
      this.TextBoxIP = new TextBox();
      this.Label1 = new Label();
      this.TextBoxePID = new TextBox();
      this.Label2 = new Label();
      this.Button1 = new Button();
      this.TextBoxPort = new TextBox();
      this.Label3 = new Label();
      this.TextBoxHwid = new TextBox();
      this.Label4 = new Label();
      this.CheckBox1 = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.RadioButton3 = new RadioButton();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.GroupBox2 = new GroupBox();
      this.RadioButton6 = new RadioButton();
      this.RadioButton5 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.TextBoxIP.Location = new Point(48, 18);
      this.TextBoxIP.Name = "TextBoxIP";
      this.TextBoxIP.Size = new Size(172, 20);
      this.TextBoxIP.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(26, 21);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(20, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "IP:";
      this.TextBoxePID.Location = new Point(48, 50);
      this.TextBoxePID.Name = "TextBoxePID";
      this.TextBoxePID.Size = new Size(277, 20);
      this.TextBoxePID.TabIndex = 2;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(13, 53);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(34, 13);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "ePID:";
      this.Button1.Location = new Point(48, 120);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(128, 23);
      this.Button1.TabIndex = 4;
      this.Button1.Text = "Start";
      this.Button1.UseVisualStyleBackColor = true;
      this.TextBoxPort.Location = new Point(261, 18);
      this.TextBoxPort.Name = "TextBoxPort";
      this.TextBoxPort.Size = new Size(63, 20);
      this.TextBoxPort.TabIndex = 5;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(227, 22);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(29, 13);
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Port:";
      this.TextBoxHwid.Location = new Point(48, 83);
      this.TextBoxHwid.Name = "TextBoxHwid";
      this.TextBoxHwid.Size = new Size(128, 20);
      this.TextBoxHwid.TabIndex = 7;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(13, 86);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(34, 13);
      this.Label4.TabIndex = 8;
      this.Label4.Text = "Hwid:";
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(220, 124);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(81, 17);
      this.CheckBox1.TabIndex = 9;
      this.CheckBox1.Text = "CheckBox1";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.RadioButton3);
      this.GroupBox1.Controls.Add((Control) this.RadioButton2);
      this.GroupBox1.Controls.Add((Control) this.RadioButton1);
      this.GroupBox1.Location = new Point(16, 159);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(140, 100);
      this.GroupBox1.TabIndex = 31;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "GroupBox1";
      this.RadioButton3.AutoSize = true;
      this.RadioButton3.Location = new Point(6, 66);
      this.RadioButton3.Name = "RadioButton3";
      this.RadioButton3.Size = new Size(90, 17);
      this.RadioButton3.TabIndex = 2;
      this.RadioButton3.TabStop = true;
      this.RadioButton3.Text = "RadioButton3";
      this.RadioButton3.UseVisualStyleBackColor = true;
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.Location = new Point(6, 43);
      this.RadioButton2.Name = "RadioButton2";
      this.RadioButton2.Size = new Size(90, 17);
      this.RadioButton2.TabIndex = 1;
      this.RadioButton2.TabStop = true;
      this.RadioButton2.Text = "RadioButton2";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.Location = new Point(7, 20);
      this.RadioButton1.Name = "RadioButton1";
      this.RadioButton1.Size = new Size(90, 17);
      this.RadioButton1.TabIndex = 0;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "RadioButton1";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.RadioButton6);
      this.GroupBox2.Controls.Add((Control) this.RadioButton5);
      this.GroupBox2.Controls.Add((Control) this.RadioButton4);
      this.GroupBox2.Location = new Point(213, 159);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(140, 100);
      this.GroupBox2.TabIndex = 32;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "GroupBox2";
      this.RadioButton6.AutoSize = true;
      this.RadioButton6.Location = new Point(7, 66);
      this.RadioButton6.Name = "RadioButton6";
      this.RadioButton6.Size = new Size(90, 17);
      this.RadioButton6.TabIndex = 2;
      this.RadioButton6.TabStop = true;
      this.RadioButton6.Text = "RadioButton6";
      this.RadioButton6.UseVisualStyleBackColor = true;
      this.RadioButton5.AutoSize = true;
      this.RadioButton5.Location = new Point(7, 43);
      this.RadioButton5.Name = "RadioButton5";
      this.RadioButton5.Size = new Size(90, 17);
      this.RadioButton5.TabIndex = 1;
      this.RadioButton5.TabStop = true;
      this.RadioButton5.Text = "RadioButton5";
      this.RadioButton5.UseVisualStyleBackColor = true;
      this.RadioButton4.AutoSize = true;
      this.RadioButton4.Location = new Point(7, 20);
      this.RadioButton4.Name = "RadioButton4";
      this.RadioButton4.Size = new Size(90, 17);
      this.RadioButton4.TabIndex = 0;
      this.RadioButton4.TabStop = true;
      this.RadioButton4.Text = "RadioButton4";
      this.RadioButton4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(370, 287);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.TextBoxHwid);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.TextBoxPort);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.TextBoxePID);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TextBoxIP);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = "GetHwidKMS";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "KMS-Service Info";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox TextBoxIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxePID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBoxPort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxHwid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton3
    {
      get
      {
        return this._RadioButton3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton3_CheckedChanged);
        RadioButton radioButton3_1 = this._RadioButton3;
        if (radioButton3_1 != null)
          radioButton3_1.CheckedChanged -= eventHandler;
        this._RadioButton3 = value;
        RadioButton radioButton3_2 = this._RadioButton3;
        if (radioButton3_2 == null)
          return;
        radioButton3_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton2
    {
      get
      {
        return this._RadioButton2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton2_CheckedChanged);
        RadioButton radioButton2_1 = this._RadioButton2;
        if (radioButton2_1 != null)
          radioButton2_1.CheckedChanged -= eventHandler;
        this._RadioButton2 = value;
        RadioButton radioButton2_2 = this._RadioButton2;
        if (radioButton2_2 == null)
          return;
        radioButton2_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton1
    {
      get
      {
        return this._RadioButton1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
        RadioButton radioButton1_1 = this._RadioButton1;
        if (radioButton1_1 != null)
          radioButton1_1.CheckedChanged -= eventHandler;
        this._RadioButton1 = value;
        RadioButton radioButton1_2 = this._RadioButton1;
        if (radioButton1_2 == null)
          return;
        radioButton1_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton6
    {
      get
      {
        return this._RadioButton6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton6_CheckedChanged);
        RadioButton radioButton6_1 = this._RadioButton6;
        if (radioButton6_1 != null)
          radioButton6_1.CheckedChanged -= eventHandler;
        this._RadioButton6 = value;
        RadioButton radioButton6_2 = this._RadioButton6;
        if (radioButton6_2 == null)
          return;
        radioButton6_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton5
    {
      get
      {
        return this._RadioButton5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton5_CheckedChanged);
        RadioButton radioButton5_1 = this._RadioButton5;
        if (radioButton5_1 != null)
          radioButton5_1.CheckedChanged -= eventHandler;
        this._RadioButton5 = value;
        RadioButton radioButton5_2 = this._RadioButton5;
        if (radioButton5_2 == null)
          return;
        radioButton5_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton4
    {
      get
      {
        return this._RadioButton4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton4_CheckedChanged);
        RadioButton radioButton4_1 = this._RadioButton4;
        if (radioButton4_1 != null)
          radioButton4_1.CheckedChanged -= eventHandler;
        this._RadioButton4 = value;
        RadioButton radioButton4_2 = this._RadioButton4;
        if (radioButton4_2 == null)
          return;
        radioButton4_2.CheckedChanged += eventHandler;
      }
    }

    private void GetHwidKMS_FormClosed(object sender, FormClosedEventArgs e)
    {
      FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir(MyProject.Forms.Form1.Tempdir + "\\kmsclient");
    }

    private void GetHwidKMS_Load(object sender, EventArgs e)
    {
      this.Button1.Text = Lang.ButtonText31;
      this.TextBoxIP.Text = "127.0.0.2";
      this.TextBoxePID.Text = "";
      this.TextBoxHwid.Text = "";
      this.TextBoxPort.Text = "1688";
      this.CheckBox1.Text = Lang.ButtonText26;
      this.RadioButton1.Text = "Windows";
      this.RadioButton2.Text = "Office 2010";
      this.RadioButton3.Text = "Office 2013";
      this.RadioButton4.Text = "V4 protocol";
      this.RadioButton5.Text = "V5 protocol";
      this.RadioButton6.Text = "V6 protocol";
      this.GroupBox1.Text = Lang.ProductTxt;
      this.GroupBox2.Text = Lang.ProtocolTxt;
      this.RadioButton1.Checked = true;
      this.RadioButton6.Checked = true;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      string text = this.Button1.Text;
      this.Button1.Text = Lang.ButtonRuns;
      this.Button1.Enabled = false;
      this.TextBoxePID.Text = "";
      this.TextBoxHwid.Text = "";
      this.TextBoxePID.Refresh();
      this.TextBoxHwid.Refresh();
      if (Operators.CompareString(this.TextBoxIP.Text, "", false) == 0)
        return;
      this.TextBoxIP.Focus();
      FileSystem.ChDir(this.Tempdir);
      if (!(File.Exists(this.Tempdir + "\\kmsclient\\KMSClient.exe") & File.Exists(this.Tempdir + "\\kmsclient\\HGM-KMS.dll")))
      {
        while (!File.Exists(this.Tempdir + "\\kmsclient.dat"))
        {
          MyProject.Computer.FileSystem.WriteAllBytes("kmsclient.dat", KMSAuto_Net.My.Resources.Resources.kmsclient, false);
          Application.DoEvents();
        }
        Interaction.Shell(this.SysPath + "cmd.exe /c kmsclient.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
        MyProject.Forms.Form1.DelFile("kmsclient.dat");
      }
      FileSystem.ChDir(this.Tempdir + "\\kmsclient");
      Interaction.Shell(this.SysPath + "cmd.exe /c KMSClient.exe " + Strings.Trim(this.TextBoxPort.Text) + " " + Strings.Trim(this.TextBoxIP.Text) + " " + this._product + " " + this._protocol + " > output.txt", AppWinStyle.Hide, true, -1);
      string String1 = MyProject.Computer.FileSystem.ReadAllText("output.txt", Encoding.Default);
      int num1 = Strings.InStr(1, String1, "(Hardware Id)", CompareMethod.Binary);
      if (num1 > 0)
      {
        string str1 = String1.Remove(0, checked (num1 + 14));
        int num2 = Strings.InStr(1, str1, " ", CompareMethod.Binary);
        string pid = Strings.Mid(str1, 1, checked (num2 - 1));
        if (Operators.ConditionalCompareObjectEqual(this.CheckPidFormat(pid), (object) 0, false))
          this.TextBoxePID.Text = pid;
        string str2 = str1.Remove(0, checked (num2 + 1));
        int num3 = Strings.InStr(1, str2, ")", CompareMethod.Binary);
        string str3 = Strings.Mid(str2, 1, checked (num3 - 1));
        if (new Regex("^[0-9a-fA-F]{16}$").IsMatch(str3))
        {
          string str4 = "";
          int Start = 15;
          int num4 = 0;
          do
          {
            str4 += Strings.Mid(str3, Start, 2);
            checked { Start -= 2; }
            checked { ++num4; }
          }
          while (num4 <= 7);
          this.TextBoxHwid.Text = str4;
        }
      }
      else
      {
        int num2 = Strings.InStr(1, String1, "KMS Server PID", CompareMethod.Binary);
        if (num2 > 0)
        {
          string str = String1.Remove(0, checked (num2 + 15));
          int num3 = Strings.InStr(1, str, "\r\n", CompareMethod.Binary);
          if (num3 > 0)
          {
            string pid = Strings.Mid(str, 1, checked (num3 - 1));
            if (Operators.ConditionalCompareObjectEqual(this.CheckPidFormat(pid), (object) 0, false))
              this.TextBoxePID.Text = pid;
          }
        }
      }
      if (this.CheckBox1.Checked)
      {
        string str = "IP: " + this.TextBoxIP.Text + " Port: " + this.TextBoxPort.Text + " Product: " + this._memo + " Protocol: " + this._memoprot + "\r\n" + "ePID: " + this.TextBoxePID.Text + " Hwid: " + this.TextBoxHwid.Text + "\r\n\r\n";
        StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\KMSServers.txt", true, Encoding.GetEncoding("utf-8"));
        streamWriter.Write(str);
        streamWriter.Close();
      }
      this.TextBoxIP.Focus();
      this.Button1.Enabled = true;
      this.Button1.Text = text;
      this.Button1.Refresh();
    }

    private object CheckPidFormat(string pid)
    {
      return new Regex("^[0-9]{5}-[0-9]{5}-[0-9]{3}-[0-9]{6}-[0-9]{2,3}-[0-9]{3,5}-[0-9]{4}.[0-9]{4}-[0-9]{7}$").IsMatch(Strings.UCase(Strings.Trim(pid))) ? (object) 0 : (object) (int) byte.MaxValue;
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton1.Checked)
        return;
      this._product = "/A=55c92734-d682-4d71-983e-d6ec3f16059f";
      this._memo = "Windows";
    }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton2.Checked)
        return;
      this._product = "/A=59a52881-a989-479d-af46-f275c6370663";
      this._memo = "Office 2010";
    }

    private void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton3.Checked)
        return;
      this._product = "/A=0ff1ce15-a989-479d-af46-f275c6370663";
      this._memo = "Office 2013";
    }

    private void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton4.Checked)
        return;
      this._protocol = "/4";
      this._memoprot = "V4";
    }

    private void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton5.Checked)
        return;
      this._protocol = "/5";
      this._memoprot = "V5";
    }

    private void RadioButton6_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioButton6.Checked)
        return;
      this._protocol = "/6";
      this._memoprot = "V6";
    }
  }
}
