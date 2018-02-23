// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.EnterGvlk
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class EnterGvlk : Form
  {
    private IContainer components;

    public EnterGvlk()
    {
      this.Load += new EventHandler(this.EnterGVLK_Load);
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
      this.components = (IContainer) new Container();
      this.CancelBtn = new Button();
      this.EnteredGVLK = new TextBox();
      this.ProductInfo = new GroupBox();
      this.ContinueBtn = new Button();
      this.PictureBox1 = new PictureBox();
      this.PartialKey = new Label();
      this.ProductDescriptionData = new Label();
      this.ProductNameData = new Label();
      this.WarningLbl = new Label();
      this.lblPartialKey = new Label();
      this.lblProductDescription = new Label();
      this.lblProductName = new Label();
      this.InfoTip = new ToolTip(this.components);
      this.ProductInfo.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.CancelBtn.Location = new Point(309, 132);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new Size(83, 23);
      this.CancelBtn.TabIndex = 3;
      this.CancelBtn.UseVisualStyleBackColor = true;
      this.EnteredGVLK.Location = new Point(12, 134);
      this.EnteredGVLK.Name = "EnteredGVLK";
      this.EnteredGVLK.Size = new Size(210, 20);
      this.EnteredGVLK.TabIndex = 2;
      this.ProductInfo.BackColor = Color.Transparent;
      this.ProductInfo.Controls.Add((Control) this.ContinueBtn);
      this.ProductInfo.Controls.Add((Control) this.PictureBox1);
      this.ProductInfo.Controls.Add((Control) this.CancelBtn);
      this.ProductInfo.Controls.Add((Control) this.EnteredGVLK);
      this.ProductInfo.Controls.Add((Control) this.PartialKey);
      this.ProductInfo.Controls.Add((Control) this.ProductDescriptionData);
      this.ProductInfo.Controls.Add((Control) this.ProductNameData);
      this.ProductInfo.Controls.Add((Control) this.WarningLbl);
      this.ProductInfo.Controls.Add((Control) this.lblPartialKey);
      this.ProductInfo.Controls.Add((Control) this.lblProductDescription);
      this.ProductInfo.Controls.Add((Control) this.lblProductName);
      this.ProductInfo.Location = new Point(12, 7);
      this.ProductInfo.Name = "ProductInfo";
      this.ProductInfo.Size = new Size(404, 161);
      this.ProductInfo.TabIndex = 1;
      this.ProductInfo.TabStop = false;
      this.ContinueBtn.Location = new Point(309, 103);
      this.ContinueBtn.Name = "ContinueBtn";
      this.ContinueBtn.Size = new Size(83, 23);
      this.ContinueBtn.TabIndex = 6;
      this.ContinueBtn.Text = "Button1";
      this.ContinueBtn.UseVisualStyleBackColor = true;
      this.PictureBox1.BackgroundImage = (Image) KMSAuto_Net.My.Resources.Resources.key48;
      this.PictureBox1.BackgroundImageLayout = ImageLayout.Center;
      this.PictureBox1.Location = new Point(250, 103);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(53, 52);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox1.TabIndex = 5;
      this.PictureBox1.TabStop = false;
      this.PartialKey.BorderStyle = BorderStyle.Fixed3D;
      this.PartialKey.Location = new Point(83, 71);
      this.PartialKey.Name = "PartialKey";
      this.PartialKey.Size = new Size(51, 15);
      this.PartialKey.TabIndex = 0;
      this.ProductDescriptionData.BorderStyle = BorderStyle.Fixed3D;
      this.ProductDescriptionData.Location = new Point(83, 47);
      this.ProductDescriptionData.Name = "ProductDescriptionData";
      this.ProductDescriptionData.Size = new Size(315, 15);
      this.ProductDescriptionData.TabIndex = 1;
      this.ProductNameData.BorderStyle = BorderStyle.Fixed3D;
      this.ProductNameData.Location = new Point(83, 23);
      this.ProductNameData.Name = "ProductNameData";
      this.ProductNameData.Size = new Size(315, 15);
      this.ProductNameData.TabIndex = 2;
      this.WarningLbl.Location = new Point(9, 104);
      this.WarningLbl.Name = "WarningLbl";
      this.WarningLbl.Size = new Size(232, 28);
      this.WarningLbl.TabIndex = 0;
      this.lblPartialKey.Location = new Point(9, 63);
      this.lblPartialKey.Name = "lblPartialKey";
      this.lblPartialKey.Size = new Size(68, 33);
      this.lblPartialKey.TabIndex = 3;
      this.lblProductDescription.BackColor = SystemColors.Control;
      this.lblProductDescription.Location = new Point(9, 48);
      this.lblProductDescription.Name = "lblProductDescription";
      this.lblProductDescription.Size = new Size(68, 15);
      this.lblProductDescription.TabIndex = 4;
      this.lblProductName.Location = new Point(9, 24);
      this.lblProductName.Name = "lblProductName";
      this.lblProductName.Size = new Size(68, 15);
      this.lblProductName.TabIndex = 5;
      this.InfoTip.AutoPopDelay = 6000;
      this.InfoTip.InitialDelay = 400;
      this.InfoTip.ReshowDelay = 200;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(429, 184);
      this.Controls.Add((Control) this.ProductInfo);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EnterGVLK";
      this.Text = "EnterGVLK";
      this.ProductInfo.ResumeLayout(false);
      this.ProductInfo.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual Button CancelBtn
    {
      get
      {
        return this._CancelBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CancelBtn_Click_1);
        Button cancelBtn1 = this._CancelBtn;
        if (cancelBtn1 != null)
          cancelBtn1.Click -= eventHandler;
        this._CancelBtn = value;
        Button cancelBtn2 = this._CancelBtn;
        if (cancelBtn2 == null)
          return;
        cancelBtn2.Click += eventHandler;
      }
    }

    internal virtual TextBox EnteredGVLK { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox ProductInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblPartialKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblProductDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblProductName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label WarningLbl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label PartialKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label ProductDescriptionData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label ProductNameData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual ToolTip InfoTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ContinueBtn
    {
      get
      {
        return this._ContinueBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ContinueBtn_Click_1);
        Button continueBtn1 = this._ContinueBtn;
        if (continueBtn1 != null)
          continueBtn1.Click -= eventHandler;
        this._ContinueBtn = value;
        Button continueBtn2 = this._ContinueBtn;
        if (continueBtn2 == null)
          return;
        continueBtn2.Click += eventHandler;
      }
    }

    private void EnterGVLK_Load(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Default;
      this.InfoTip.ToolTipTitle = Lang.InfoTipTitle;
      this.InfoTip.SetToolTip((Control) this.ProductInfo, Lang.ProductInfoTip);
      this.lblProductName.Text = Lang.LblProductNameText;
      this.lblProductDescription.Text = Lang.LblProductDescriptionText;
      this.lblPartialKey.Text = Lang.LblPartialKeyText;
      this.ContinueBtn.Text = Lang.ContinueBtnText;
      this.InfoTip.SetToolTip((Control) this.ContinueBtn, Lang.ContinueBtnTip);
      this.CancelBtn.Text = Lang.CancelBtnText;
      this.InfoTip.SetToolTip((Control) this.CancelBtn, Lang.CancelBtnTip);
      this.InfoTip.SetToolTip((Control) this.EnteredGVLK, Lang.EnteredGvlkTip);
    }

    private void CancelBtn_Click_1(object sender, EventArgs e)
    {
      this.EnteredGVLK.Text = "";
      this.Close();
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void ContinueBtn_Click_1(object sender, EventArgs e)
    {
      string str = Strings.UCase(Strings.Trim(this.EnteredGVLK.Text));
      if (Operators.CompareString(str, "", false) == 0)
      {
        this.EnteredGVLK.Text = "";
        this.Close();
      }
      else if (!new Regex("^[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}-[0-9A-Z]{5}$").IsMatch(str))
      {
        int num = (int) Interaction.MsgBox((object) "Entered key has invalid format", MsgBoxStyle.Exclamation, (object) "Key checking");
      }
      else
      {
        this.EnteredGVLK.Text = str;
        this.Close();
      }
    }
  }
}
