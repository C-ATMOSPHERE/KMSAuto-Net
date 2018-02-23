// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.FormKmsHelp
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
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class FormKmsHelp : Form
  {
    private IContainer components;

    public FormKmsHelp()
    {
      this.Load += new EventHandler(this.FormKMSHelp_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormKmsHelp));
      this.TextBox1 = new TextBox();
      this.SuspendLayout();
      this.TextBox1.BackColor = Color.DarkBlue;
      this.TextBox1.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.TextBox1.ForeColor = Color.Yellow;
      this.TextBox1.Location = new Point(-2, -2);
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.ReadOnly = true;
      this.TextBox1.Size = new Size(538, 215);
      this.TextBox1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(531, 211);
      this.Controls.Add((Control) this.TextBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = "FormKMSHelp";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "FormKMSHelp";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FormKMSHelp_Load(object sender, EventArgs e)
    {
      this.Text = "KMSSS.exe ReadME";
      this.TextBox1.Clear();
      FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\readmekms.txt"))
      {
        MyProject.Computer.FileSystem.WriteAllText("readmekms.txt", KMSAuto_Net.My.Resources.Resources.readme_kms, false);
        Application.DoEvents();
      }
      string[] strArray = File.ReadAllLines(MyProject.Forms.Form1.Tempdir + "\\readmekms.txt");
      int num = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num)
      {
        this.TextBox1.AppendText(strArray[index] + "\r\n");
        checked { ++index; }
      }
      MyProject.Forms.Form1.DelFile("readmekms.txt");
    }
  }
}
