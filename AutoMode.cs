﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.AutoMode
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
  public class AutoMode : Form
  {
    private IContainer components;

    public AutoMode()
    {
      this.Load += new EventHandler(this.AutoMode_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AutoMode));
      this.CheckBox1 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBox5 = new CheckBox();
      this.SuspendLayout();
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(26, 18);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(81, 17);
      this.CheckBox1.TabIndex = 0;
      this.CheckBox1.Text = "CheckBox1";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.CheckBox2.AutoSize = true;
      this.CheckBox2.Location = new Point(26, 104);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new Size(81, 17);
      this.CheckBox2.TabIndex = 1;
      this.CheckBox2.Text = "CheckBox2";
      this.CheckBox2.UseVisualStyleBackColor = true;
      this.CheckBox3.AutoSize = true;
      this.CheckBox3.Location = new Point(26, 81);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new Size(81, 17);
      this.CheckBox3.TabIndex = 2;
      this.CheckBox3.Text = "CheckBox3";
      this.CheckBox3.UseVisualStyleBackColor = true;
      this.CheckBox4.AutoSize = true;
      this.CheckBox4.Location = new Point(26, (int) sbyte.MaxValue);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new Size(81, 17);
      this.CheckBox4.TabIndex = 3;
      this.CheckBox4.Text = "CheckBox4";
      this.CheckBox4.UseVisualStyleBackColor = true;
      this.CheckBox5.AutoSize = true;
      this.CheckBox5.Location = new Point(26, 57);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new Size(81, 17);
      this.CheckBox5.TabIndex = 4;
      this.CheckBox5.Text = "CheckBox5";
      this.CheckBox5.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(325, 157);
      this.Controls.Add((Control) this.CheckBox5);
      this.Controls.Add((Control) this.CheckBox4);
      this.Controls.Add((Control) this.CheckBox3);
      this.Controls.Add((Control) this.CheckBox2);
      this.Controls.Add((Control) this.CheckBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AutoMode);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (AutoMode);
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

    internal virtual CheckBox CheckBox2
    {
      get
      {
        return this._CheckBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
        CheckBox checkBox2_1 = this._CheckBox2;
        if (checkBox2_1 != null)
          checkBox2_1.CheckedChanged -= eventHandler;
        this._CheckBox2 = value;
        CheckBox checkBox2_2 = this._CheckBox2;
        if (checkBox2_2 == null)
          return;
        checkBox2_2.CheckedChanged += eventHandler;
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

    private void AutoMode_Load(object sender, EventArgs e)
    {
      this.Text = Lang.TabPageText2 + " Auto";
      this.CheckBox1.Text = Lang.AutoModeCheckBoxTxt;
      this.CheckBox2.Text = Lang.AutoModeTxtHook;
      this.CheckBox3.Text = Lang.AutoModeTxtWinDivert;
      this.CheckBox4.Text = Lang.AutoModeTxttap;
      this.CheckBox5.Text = Lang.AutoModeTxtLhost;
      this.CheckBox1.Checked = MyProject.Forms.Form1.AutoRes;
      this.CheckEnabledMode();
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (MyProject.Forms.Form1.LoadingProgramm)
        return;
      MyProject.Forms.Form1.AutoRes = this.CheckBox1.Checked;
      this.Close();
    }

    private void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
      this.CheckEnabledMode();
    }

    private void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
      this.CheckEnabledMode();
    }

    private void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
      this.CheckEnabledMode();
    }

    private void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
      this.CheckEnabledMode();
    }

    private void CheckEnabledMode()
    {
      if (!(!this.CheckBox2.Checked & !this.CheckBox3.Checked & !this.CheckBox4.Checked & !this.CheckBox5.Checked))
        return;
      if (this.CheckBox2.Enabled)
        this.CheckBox2.Checked = true;
      this.CheckBox3.Checked = true;
      this.CheckBox4.Checked = true;
      if (MyProject.Forms.Form1.Check_New_Windows_Version_9600())
        this.CheckBox5.Checked = false;
      else
        this.CheckBox5.Checked = true;
    }
  }
}
