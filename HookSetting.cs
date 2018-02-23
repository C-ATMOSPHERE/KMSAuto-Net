﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.HookSetting
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
  public class HookSetting : Form
  {
    private IContainer components;
    private bool _loadform;

    public HookSetting()
    {
      this.Load += new EventHandler(this.HookSetting_Load);
      this._loadform = true;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HookSetting));
      this.RadioButton1 = new RadioButton();
      this.RadioButton2 = new RadioButton();
      this.SuspendLayout();
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.Location = new Point(26, 24);
      this.RadioButton1.Name = "RadioButton1";
      this.RadioButton1.Size = new Size(90, 17);
      this.RadioButton1.TabIndex = 2;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "RadioButton1";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.Location = new Point(26, 56);
      this.RadioButton2.Name = "RadioButton2";
      this.RadioButton2.Size = new Size(90, 17);
      this.RadioButton2.TabIndex = 3;
      this.RadioButton2.TabStop = true;
      this.RadioButton2.Text = "RadioButton2";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(325, 101);
      this.Controls.Add((Control) this.RadioButton2);
      this.Controls.Add((Control) this.RadioButton1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (HookSetting);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (HookSetting);
      this.ResumeLayout(false);
      this.PerformLayout();
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

    private void HookSetting_Load(object sender, EventArgs e)
    {
      this.Text = Lang.TabPageText2 + " Hook";
      this.RadioButton1.Text = Lang.HookModeTxt2;
      this.RadioButton2.Text = Lang.HookModeTxt;
      if (MyProject.Forms.Form1.HookMode == 0)
        this.RadioButton1.Checked = true;
      else if (MyProject.Forms.Form1.HookMode == 1)
        this.RadioButton2.Checked = true;
      this._loadform = false;
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (this._loadform)
        return;
      if (this.RadioButton1.Checked)
        MyProject.Forms.Form1.HookMode = 0;
      this.Close();
    }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (this._loadform)
        return;
      if (this.RadioButton2.Checked)
        MyProject.Forms.Form1.HookMode = 1;
      this.Close();
    }
  }
}
