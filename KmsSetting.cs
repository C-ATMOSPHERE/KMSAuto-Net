﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.KmsSetting
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
  public class KmsSetting : Form
  {
    private IContainer components;

    public KmsSetting()
    {
      this.Load += new EventHandler(this.KMSSetting_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KmsSetting));
      this.CheckBox1 = new CheckBox();
      this.SuspendLayout();
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(26, 22);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(81, 17);
      this.CheckBox1.TabIndex = 0;
      this.CheckBox1.Text = "CheckBox1";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(325, 98);
      this.Controls.Add((Control) this.CheckBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "KMSSetting";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "KMSSetting";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

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

    private void KMSSetting_Load(object sender, EventArgs e)
    {
      this.Text = Lang.TabPageText2 + " KMS-Service";
      this.CheckBox1.Text = Lang.SetKmsProgramDataTxt;
      if (MyProject.Forms.Form1.SetKmsProgramData)
        this.CheckBox1.Checked = true;
      else
        this.CheckBox1.Checked = false;
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (MyProject.Forms.Form1.LoadingProgramm)
        return;
      this.CheckBox1.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.Form1.KmsFlag, "KMS", false) == 0 | MyProject.Forms.Form1.Scheduler)
      {
        int num = (int) MessageBox.Show(Lang.WarningPathCh, Lang.Caption2);
        if (MyProject.Forms.Form1.SetKmsProgramData)
        {
          MyProject.Forms.Form1.LoadingProgramm = true;
          this.CheckBox1.Checked = true;
          MyProject.Forms.Form1.LoadingProgramm = false;
        }
        else
        {
          MyProject.Forms.Form1.LoadingProgramm = true;
          this.CheckBox1.Checked = false;
          MyProject.Forms.Form1.LoadingProgramm = false;
        }
        this.CheckBox1.Enabled = true;
      }
      else
      {
        if (MyProject.Forms.Form1.ModeTap)
          MyProject.Forms.Form1.UnInstallTap();
        if (this.CheckBox1.Checked)
        {
          MyProject.Forms.Form1.SetKmsProgramData = true;
          MyProject.Forms.Form1.DelDir(Application.StartupPath + "\\bin");
        }
        else
          MyProject.Forms.Form1.SetKmsProgramData = false;
        MyProject.Forms.Form1.RB1AUTO.Checked = true;
        this.CheckBox1.Enabled = true;
        this.Close();
      }
    }
  }
}