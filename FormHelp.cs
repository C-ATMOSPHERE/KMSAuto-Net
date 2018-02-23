// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.FormHelp
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class FormHelp : Form
  {
    private IContainer components;

    public FormHelp()
    {
      this.FormClosed += new FormClosedEventHandler(this.FormHelp_FormClosed);
      this.Load += new EventHandler(this.FormHelp_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormHelp));
      this.TextBox1 = new TextBox();
      this.SuspendLayout();
      this.TextBox1.BackColor = SystemColors.Window;
      this.TextBox1.Font = new Font("Courier New", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.TextBox1.ForeColor = SystemColors.WindowText;
      this.TextBox1.Location = new Point(0, -2);
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.ReadOnly = true;
      this.TextBox1.ScrollBars = ScrollBars.Vertical;
      this.TextBox1.Size = new Size(706, 485);
      this.TextBox1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(704, 481);
      this.Controls.Add((Control) this.TextBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (FormHelp);
      this.Text = "ReadMe";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FormHelp_FormClosed(object sender, FormClosedEventArgs e)
    {
    }

    private void FormHelp_Load(object sender, EventArgs e)
    {
      this.TextBox1.Clear();
      if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_ru;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "EN", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_en;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "FR", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_fr;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "ES", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_es;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "CN", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_cn;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "VI", false) == 0)
      {
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_vi;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
      else
      {
        if (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "UA", false) != 0)
          return;
        this.TextBox1.Text = KMSAuto_Net.My.Resources.Resources.readme_ua;
        this.TextBox1.SelectionStart = 0;
        this.TextBox1.SelectionLength = 0;
      }
    }
  }
}
