﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.OfficeConvert
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class OfficeConvert : Form
  {
    private IContainer components;
    private string[] _officeProPlus;
    private string[] _officeProject;
    private string[] _officeVisio;
    public string Winversionbuild;
    public string Winproductname;
    private string _strProplus;
    private string _strVisiopro;
    private string _strProjectpro;
    private string _strProplus16;
    private string _strVisiopro16;
    private string _strProjectpro16;
    private string _strWord16;
    private string _strExcel16;
    private string _strAccess16;
    private string _strOneNote16;
    private string _strOutlook16;
    private string _strPowerPoint16;
    private string _strPublisher16;
    private bool _officeConvertRunning;

    public OfficeConvert()
    {
      this.Load += new EventHandler(this.OfficeConvert_Load);
      this._officeProPlus = new string[14]
      {
        "Licenses.sl.ISSUANCE.CLIENT_BRIDGE_OFFICE.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT_BRIDGE_TEST.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_STIL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL_OOB.xrm-ms",
        "Licenses.sl.PKEYCONFIG.SIGNED.xrm-ms",
        "LicenseSetData._2B88C4F2_EA8F_43CD_805E_4D41346E18A7.OOB.xrm-ms",
        "LicenseSetData._2B88C4F2_EA8F_43CD_805E_4D41346E18A7.PHN.xrm-ms",
        "LicenseSetData._2B88C4F2_EA8F_43CD_805E_4D41346E18A7.PL.xrm-ms",
        "LicenseSetData._2B88C4F2_EA8F_43CD_805E_4D41346E18A7.PPDLIC.xrm-ms",
        "LicenseSetData._B322DA9C_A2E2_4058_9E4E_F59A6970BD69.OOB.xrm-ms",
        "LicenseSetData._B322DA9C_A2E2_4058_9E4E_F59A6970BD69.PL.xrm-ms",
        "LicenseSetData._B322DA9C_A2E2_4058_9E4E_F59A6970BD69.PPDLIC.xrm-ms"
      };
      this._officeProject = new string[14]
      {
        "Licenses.sl.ISSUANCE.CLIENT_BRIDGE_OFFICE.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT_BRIDGE_TEST.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_STIL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL_OOB.xrm-ms",
        "Licenses.sl.PKEYCONFIG.SIGNED.xrm-ms",
        "LicenseSetData._4A5D124A_E620_44BA_B6FF_658961B33B9A.OOB.xrm-ms",
        "LicenseSetData._4A5D124A_E620_44BA_B6FF_658961B33B9A.PL.xrm-ms",
        "LicenseSetData._4A5D124A_E620_44BA_B6FF_658961B33B9A.PPDLIC.xrm-ms",
        "LicenseSetData._ED34DC89_1C27_4ECD_8B2F_63D0F4CEDC32.OOB.xrm-ms",
        "LicenseSetData._ED34DC89_1C27_4ECD_8B2F_63D0F4CEDC32.PHN.xrm-ms",
        "LicenseSetData._ED34DC89_1C27_4ECD_8B2F_63D0F4CEDC32.PL.xrm-ms",
        "LicenseSetData._ED34DC89_1C27_4ECD_8B2F_63D0F4CEDC32.PPDLIC.xrm-ms"
      };
      this._officeVisio = new string[14]
      {
        "Licenses.sl.ISSUANCE.CLIENT_BRIDGE_OFFICE.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_ROOT_BRIDGE_TEST.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_STIL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL.xrm-ms",
        "Licenses.sl.ISSUANCE.CLIENT_UL_OOB.xrm-ms",
        "Licenses.sl.PKEYCONFIG.SIGNED.xrm-ms",
        "LicenseSetData._3E4294DD_A765_49BC_8DBD_CF8B62A4BD3D.OOB.xrm-ms",
        "LicenseSetData._3E4294DD_A765_49BC_8DBD_CF8B62A4BD3D.PHN.xrm-ms",
        "LicenseSetData._3E4294DD_A765_49BC_8DBD_CF8B62A4BD3D.PL.xrm-ms",
        "LicenseSetData._3E4294DD_A765_49BC_8DBD_CF8B62A4BD3D.PPDLIC.xrm-ms",
        "LicenseSetData._E13AC10E_75D0_4AFF_A0CD_764982CF541C.OOB.xrm-ms",
        "LicenseSetData._E13AC10E_75D0_4AFF_A0CD_764982CF541C.PL.xrm-ms",
        "LicenseSetData._E13AC10E_75D0_4AFF_A0CD_764982CF541C.PPDLIC.xrm-ms"
      };
      this.Winversionbuild = "";
      this.Winproductname = "";
      this._strProplus = "";
      this._strVisiopro = "";
      this._strProjectpro = "";
      this._strProplus16 = "";
      this._strVisiopro16 = "";
      this._strProjectpro16 = "";
      this._strWord16 = "";
      this._strExcel16 = "";
      this._strAccess16 = "";
      this._strOneNote16 = "";
      this._strOutlook16 = "";
      this._strPowerPoint16 = "";
      this._strPublisher16 = "";
      this._officeConvertRunning = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OfficeConvert));
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.Button4 = new Button();
      this.Button5 = new Button();
      this.Button6 = new Button();
      this.Button7 = new Button();
      this.Button8 = new Button();
      this.Button9 = new Button();
      this.Button10 = new Button();
      this.Button11 = new Button();
      this.Button12 = new Button();
      this.Button13 = new Button();
      this.SuspendLayout();
      this.Button1.Location = new Point(29, 28);
      this.Button1.Margin = new Padding(4);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(312, 28);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Button1";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.Location = new Point(29, 62);
      this.Button2.Margin = new Padding(4);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(312, 28);
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Button2";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button3.Location = new Point(29, 96);
      this.Button3.Margin = new Padding(4);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(312, 28);
      this.Button3.TabIndex = 2;
      this.Button3.Text = "Button3";
      this.Button3.UseVisualStyleBackColor = true;
      this.Button4.Location = new Point(29, 130);
      this.Button4.Margin = new Padding(4);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(312, 28);
      this.Button4.TabIndex = 3;
      this.Button4.Text = "Button4";
      this.Button4.UseVisualStyleBackColor = true;
      this.Button5.Location = new Point(29, 164);
      this.Button5.Margin = new Padding(4);
      this.Button5.Name = "Button5";
      this.Button5.Size = new Size(312, 28);
      this.Button5.TabIndex = 4;
      this.Button5.Text = "Button5";
      this.Button5.UseVisualStyleBackColor = true;
      this.Button6.Location = new Point(29, 198);
      this.Button6.Margin = new Padding(4);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(312, 28);
      this.Button6.TabIndex = 5;
      this.Button6.Text = "Button6";
      this.Button6.UseVisualStyleBackColor = true;
      this.Button7.Location = new Point(30, 241);
      this.Button7.Margin = new Padding(4);
      this.Button7.Name = "Button7";
      this.Button7.Size = new Size(312, 28);
      this.Button7.TabIndex = 6;
      this.Button7.Text = "Button7";
      this.Button7.UseVisualStyleBackColor = true;
      this.Button8.Location = new Point(30, 275);
      this.Button8.Margin = new Padding(4);
      this.Button8.Name = "Button8";
      this.Button8.Size = new Size(312, 28);
      this.Button8.TabIndex = 7;
      this.Button8.Text = "Button8";
      this.Button8.UseVisualStyleBackColor = true;
      this.Button9.Location = new Point(30, 309);
      this.Button9.Margin = new Padding(4);
      this.Button9.Name = "Button9";
      this.Button9.Size = new Size(312, 28);
      this.Button9.TabIndex = 8;
      this.Button9.Text = "Button9";
      this.Button9.UseVisualStyleBackColor = true;
      this.Button10.Location = new Point(30, 343);
      this.Button10.Margin = new Padding(4);
      this.Button10.Name = "Button10";
      this.Button10.Size = new Size(312, 28);
      this.Button10.TabIndex = 9;
      this.Button10.Text = "Button10";
      this.Button10.UseVisualStyleBackColor = true;
      this.Button11.Location = new Point(30, 377);
      this.Button11.Margin = new Padding(4);
      this.Button11.Name = "Button11";
      this.Button11.Size = new Size(312, 28);
      this.Button11.TabIndex = 10;
      this.Button11.Text = "Button11";
      this.Button11.UseVisualStyleBackColor = true;
      this.Button12.Location = new Point(30, 411);
      this.Button12.Margin = new Padding(4);
      this.Button12.Name = "Button12";
      this.Button12.Size = new Size(312, 28);
      this.Button12.TabIndex = 11;
      this.Button12.Text = "Button12";
      this.Button12.UseVisualStyleBackColor = true;
      this.Button13.Location = new Point(30, 445);
      this.Button13.Margin = new Padding(4);
      this.Button13.Name = "Button13";
      this.Button13.Size = new Size(312, 28);
      this.Button13.TabIndex = 12;
      this.Button13.Text = "Button13";
      this.Button13.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(372, 501);
      this.Controls.Add((Control) this.Button13);
      this.Controls.Add((Control) this.Button12);
      this.Controls.Add((Control) this.Button11);
      this.Controls.Add((Control) this.Button10);
      this.Controls.Add((Control) this.Button9);
      this.Controls.Add((Control) this.Button8);
      this.Controls.Add((Control) this.Button7);
      this.Controls.Add((Control) this.Button6);
      this.Controls.Add((Control) this.Button5);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.Name = nameof (OfficeConvert);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Office Convert";
      this.ResumeLayout(false);
    }

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

    private void OfficeConvert_Load(object sender, EventArgs e)
    {
      this.Button1.Text = "Office 2013 Pro Plus RETAIL -> VL";
      this.Button2.Text = "Office 2013 Visio Pro RETAIL -> VL";
      this.Button3.Text = "Office 2013 Project Pro RETAIL -> VL";
      this.Button4.Text = "Office 2016 Pro Plus RETAIL -> VL";
      this.Button5.Text = "Office 2016 Visio Pro RETAIL -> VL";
      this.Button6.Text = "Office 2016 Project Pro RETAIL -> VL";
      this.Button7.Text = "Office 2016 Word RETAIL -> VL";
      this.Button8.Text = "Office 2016 Excel RETAIL -> VL";
      this.Button9.Text = "Office 2016 Access RETAIL -> VL";
      this.Button10.Text = "Office 2016 OneNote RETAIL -> VL";
      this.Button11.Text = "Office 2016 Outlook RETAIL -> VL";
      this.Button12.Text = "Office 2016 PowerPoint RETAIL -> VL";
      this.Button13.Text = "Office 2016 Publisher RETAIL -> VL";
      this.Button1.Enabled = false;
      this.Button2.Enabled = false;
      this.Button3.Enabled = false;
      this.Button4.Enabled = false;
      this.Button5.Enabled = false;
      this.Button6.Enabled = false;
      this.Button7.Enabled = false;
      this.Button8.Enabled = false;
      this.Button9.Enabled = false;
      this.Button10.Enabled = false;
      this.Button11.Enabled = false;
      this.Button12.Enabled = false;
      this.Button13.Enabled = false;
      this.CheckOfficeRetail();
    }

    private bool CheckOfficeRetail()
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
        string wmiSpp = this.GetWMI_SPP("Office 15");
label_3:
        num3 = 4;
        MyProject.Forms.Form1.SetWMIService();
label_4:
        num3 = 5;
        object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT Name, Description FROM " + wmiSpp + " WHERE PartialProductKey <> null")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_5:
        num3 = 6;
        string str1 = "";
label_6:
        num3 = 7;
        string str2 = "";
label_7:
        num3 = 8;
        IEnumerator enumerator = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_56;
label_9:
        num3 = 9;
        object objectValue2;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue2)))
          goto label_55;
label_10:
        num3 = 10;
        str1 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_11:
        num3 = 11;
        str2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_12:
        num3 = 12;
        if (!(Strings.InStr(Strings.UCase(str1), "OFFICE", CompareMethod.Binary) > 0 & Strings.InStr(Strings.UCase(str1), "OFFICE 15", CompareMethod.Binary) > 0))
          goto label_23;
label_13:
        num3 = 13;
        if (!Strings.UCase(str2).Contains("RETAIL"))
          goto label_23;
label_14:
        num3 = 14;
        if (!Strings.UCase(str1).Contains("PROPLUS"))
          goto label_17;
label_15:
        num3 = 15;
        this.Button1.Enabled = true;
label_16:
        num3 = 16;
        this._strProplus = str1;
label_17:
        num3 = 17;
        if (!Strings.UCase(str1).Contains("VISIOPRO"))
          goto label_20;
label_18:
        num3 = 18;
        this.Button2.Enabled = true;
label_19:
        num3 = 19;
        this._strVisiopro = str1;
label_20:
        num3 = 20;
        if (!Strings.UCase(str1).Contains("PROJECTPRO"))
          goto label_23;
label_21:
        num3 = 21;
        this.Button3.Enabled = true;
label_22:
        num3 = 22;
        this._strProjectpro = str1;
label_23:
        num3 = 23;
        if (!(Strings.InStr(Strings.UCase(str1), "OFFICE", CompareMethod.Binary) > 0 & Strings.InStr(Strings.UCase(str1), "OFFICE 16", CompareMethod.Binary) > 0))
          goto label_55;
label_24:
        num3 = 24;
        if (!Strings.UCase(str2).Contains("RETAIL"))
          goto label_55;
label_25:
        num3 = 25;
        if (!Strings.UCase(str1).Contains("PROPLUS"))
          goto label_28;
label_26:
        num3 = 26;
        this.Button4.Enabled = true;
label_27:
        num3 = 27;
        this._strProplus16 = str1;
label_28:
        num3 = 28;
        if (!Strings.UCase(str1).Contains("VISIOPRO"))
          goto label_31;
label_29:
        num3 = 29;
        this.Button5.Enabled = true;
label_30:
        num3 = 30;
        this._strVisiopro16 = str1;
label_31:
        num3 = 31;
        if (!Strings.UCase(str1).Contains("PROJECTPRO"))
          goto label_34;
label_32:
        num3 = 32;
        this.Button6.Enabled = true;
label_33:
        num3 = 33;
        this._strProjectpro16 = str1;
label_34:
        num3 = 34;
        if (!Strings.UCase(str1).Contains("WORD"))
          goto label_37;
label_35:
        num3 = 35;
        this.Button7.Enabled = true;
label_36:
        num3 = 36;
        this._strWord16 = str1;
label_37:
        num3 = 37;
        if (!Strings.UCase(str1).Contains("EXCEL"))
          goto label_40;
label_38:
        num3 = 38;
        this.Button8.Enabled = true;
label_39:
        num3 = 39;
        this._strExcel16 = str1;
label_40:
        num3 = 40;
        if (!Strings.UCase(str1).Contains("ACCESS"))
          goto label_43;
label_41:
        num3 = 41;
        this.Button9.Enabled = true;
label_42:
        num3 = 42;
        this._strAccess16 = str1;
label_43:
        num3 = 43;
        if (!Strings.UCase(str1).Contains("ONENOTE"))
          goto label_46;
label_44:
        num3 = 44;
        this.Button10.Enabled = true;
label_45:
        num3 = 45;
        this._strOneNote16 = str1;
label_46:
        num3 = 46;
        if (!Strings.UCase(str1).Contains("OUTLOOK"))
          goto label_49;
label_47:
        num3 = 47;
        this.Button11.Enabled = true;
label_48:
        num3 = 48;
        this._strOutlook16 = str1;
label_49:
        num3 = 49;
        if (!Strings.UCase(str1).Contains("POWERPOINT"))
          goto label_52;
label_50:
        num3 = 50;
        this.Button12.Enabled = true;
label_51:
        num3 = 51;
        this._strPowerPoint16 = str1;
label_52:
        num3 = 52;
        if (!Strings.UCase(str1).Contains("PUBLISHER"))
          goto label_55;
label_53:
        num3 = 53;
        this.Button13.Enabled = true;
label_54:
        num3 = 54;
        this._strPublisher16 = str1;
label_55:
        num3 = 55;
label_56:
        if (enumerator.MoveNext())
        {
          objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
          goto label_9;
        }
label_57:
        num3 = 56;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
label_59:
        num3 = 57;
        MyProject.Forms.Form1.objWMIService = (object) null;
label_60:
        num3 = 58;
        MyProject.Forms.Form1.objSWbemLocator = (object) null;
label_61:
        num3 = 59;
        MyProject.Forms.Form1.objCtx = (object) null;
        goto label_67;
label_63:
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
                goto label_9;
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
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
                goto label_26;
              case 27:
                goto label_27;
              case 28:
                goto label_28;
              case 29:
                goto label_29;
              case 30:
                goto label_30;
              case 31:
                goto label_31;
              case 32:
                goto label_32;
              case 33:
                goto label_33;
              case 34:
                goto label_34;
              case 35:
                goto label_35;
              case 36:
                goto label_36;
              case 37:
                goto label_37;
              case 38:
                goto label_38;
              case 39:
                goto label_39;
              case 40:
                goto label_40;
              case 41:
                goto label_41;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 52:
                goto label_52;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_57;
              case 57:
                goto label_59;
              case 58:
                goto label_60;
              case 59:
                goto label_61;
              case 60:
                goto label_67;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_63;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_67:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return flag;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button1.Text;
      this.Button1.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\proplus.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("proplus.dat", KMSAuto_Net.My.Resources.Resources.proplus, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c proplus.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("proplus.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\proplus");
      string[] officeProPlus = this._officeProPlus;
      int index = 0;
      while (index < officeProPlus.Length)
      {
        this.WmiInstallLic(this._strProplus, File.ReadAllText(officeProPlus[index]));
        checked { ++index; }
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c reg import proplus.reg", AppWinStyle.Hide, true, -1);
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("proplus");
      this.InstallProductGVLK_oneKey(this._strProplus, "YC7DK-G2NP3-2QQC3-J6H88-GVGXT");
      this.WmiUninstallLicense(this._strProplus);
      this.Button1.Text = text;
      this.Button1.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button2.Text;
      this.Button2.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\visio.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("visio.dat", KMSAuto_Net.My.Resources.Resources.visio, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c visio.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("visio.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\visio");
      string[] officeVisio = this._officeVisio;
      int index = 0;
      while (index < officeVisio.Length)
      {
        this.WmiInstallLic(this._strVisiopro, File.ReadAllText(officeVisio[index]));
        checked { ++index; }
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c reg import visio.reg", AppWinStyle.Hide, true, -1);
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("visio");
      this.InstallProductGVLK_oneKey(this._strVisiopro, "C2FG9-N6J68-H8BTJ-BW3QX-RM3B3");
      this.WmiUninstallLicense(this._strVisiopro);
      this.Button2.Text = text;
      this.Button2.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button3.Text;
      this.Button3.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\project.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("project.dat", KMSAuto_Net.My.Resources.Resources.project, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c project.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("project.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\project");
      string[] officeProject = this._officeProject;
      int index = 0;
      while (index < officeProject.Length)
      {
        this.WmiInstallLic(this._strProjectpro, File.ReadAllText(officeProject[index]));
        checked { ++index; }
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c reg import project.reg", AppWinStyle.Hide, true, -1);
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("project");
      this.InstallProductGVLK_oneKey(this._strProjectpro, "FN8TT-7WMH6-2D4X9-M337T-2342K");
      this.WmiUninstallLicense(this._strProjectpro);
      this.Button3.Text = text;
      this.Button3.Enabled = false;
      this._officeConvertRunning = false;
    }

    public string GetWMI_SPP(string ProductName)
    {
      string Left = "";
      string str = "SoftwareLicensingProduct";
      if (ProductName.Contains("Windows"))
        Left = "Windows";
      else if (ProductName.Contains("Office 14"))
        Left = "2010";
      else if (ProductName.Contains("Office 15") | ProductName.Contains("Office 16"))
        Left = "2013";
      if (this.Winversionbuild.Length < 3)
        this.GetWindowsVersion();
      int integer = Conversions.ToInteger(this.Winversionbuild);
      if (integer <= 7601)
      {
        if (Operators.CompareString(Left, "Windows", false) == 0)
          str = "SoftwareLicensingProduct";
        else if (Operators.CompareString(Left, "2013", false) == 0)
          str = "OfficeSoftwareProtectionProduct";
        else if (Operators.CompareString(Left, "2010", false) == 0)
          str = "OfficeSoftwareProtectionProduct";
      }
      else if (integer > 7601)
      {
        if (Operators.CompareString(Left, "Windows", false) == 0)
          str = "SoftwareLicensingProduct";
        else if (Operators.CompareString(Left, "2013", false) == 0)
          str = "SoftwareLicensingProduct";
        else if (Operators.CompareString(Left, "2010", false) == 0)
          str = "OfficeSoftwareProtectionProduct";
      }
      return str;
    }

    public string GetWindowsVersion()
    {
label_0:
      int num1;
      string String1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 1;
label_1:
        int num3 = 2;
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
label_2:
        num3 = 3;
        RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false);
label_3:
        num3 = 4;
        String1 = Conversions.ToString(registryKey2.GetValue("BuildLabEx"));
label_4:
        num3 = 5;
        this.Winproductname = Conversions.ToString(registryKey2.GetValue("ProductName"));
label_5:
        num3 = 6;
        registryKey1.Close();
label_6:
        num3 = 7;
        int num4 = Strings.InStr(String1, ".", CompareMethod.Binary);
label_7:
        num3 = 8;
        if (num4 <= 1)
          goto label_9;
label_8:
        num3 = 9;
        String1 = String1.Remove(checked (num4 - 1));
label_9:
        num3 = 10;
        this.Winversionbuild = String1;
        goto label_15;
label_11:
        num2 = num3;
        switch (num1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
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
                goto label_15;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_11;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_15:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return String1;
    }

    private object WmiInstallLic(string ProductName, string lic)
    {
label_0:
      int num1;
      object obj1;
      int num2;
      try
      {
        int num3 = 1;
        object Instance = (object) new object[0];
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num3 = 3;
        MyProject.Forms.Form1.SetWMIService();
label_3:
        num3 = 4;
        string Left = "SoftwareLicensingProduct";
label_4:
        num3 = 5;
        if (Operators.CompareString(ProductName, "", false) == 0)
          goto label_6;
label_5:
        num3 = 6;
        Left = this.GetWMI_SPP(ProductName);
label_6:
        num3 = 7;
        if (Operators.CompareString(Left, "SoftwareLicensingProduct", false) != 0)
          goto label_23;
label_7:
        num3 = 8;
        string str = "SELECT Version FROM SoftwareLicensingService";
label_8:
        num3 = 9;
        object[] objArray1;
        bool[] flagArray1;
        object obj2 = NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", objArray1 = new object[1]
        {
          (object) str
        }, (string[]) null, (Type[]) null, flagArray1 = new bool[1]
        {
          true
        });
        if (flagArray1[0])
          str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (string));
        object obj3 = RuntimeHelpers.GetObjectValue(obj2);
label_11:
        num3 = 10;
        if (Information.Err().Number == 0)
          goto label_13;
label_12:
        num3 = 11;
        obj1 = (object) Information.Err().Number;
        goto label_45;
label_13:
        num3 = 13;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj3)))
          goto label_15;
label_14:
        num3 = 14;
        obj1 = (object) (int) byte.MaxValue;
        goto label_45;
label_15:
        num3 = 16;
        IEnumerator enumerator1 = ((IEnumerable) obj3).GetEnumerator();
        goto label_19;
label_17:
        num3 = 17;
        if (Information.Err().Number != 0)
          goto label_22;
label_18:
        num3 = 20;
label_19:
        if (enumerator1.MoveNext())
        {
          Instance = RuntimeHelpers.GetObjectValue(enumerator1.Current);
          goto label_17;
        }
label_20:
        num3 = 21;
        if (enumerator1 is IDisposable)
        {
          (enumerator1 as IDisposable).Dispose();
          goto label_31;
        }
        else
          goto label_31;
label_22:
        num3 = 18;
        obj1 = (object) Information.Err().Number;
        goto label_45;
label_23:
        num3 = 23;
        if (Operators.CompareString(Left, "OfficeSoftwareProtectionProduct", false) != 0)
          goto label_45;
label_24:
        num3 = 24;
        IEnumerator enumerator2 = ((IEnumerable) NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "InstancesOf", new object[1]
        {
          (object) "OfficeSoftwareProtectionService"
        }, (string[]) null, (Type[]) null, (bool[]) null)).GetEnumerator();
label_25:
        if (enumerator2.MoveNext())
          Instance = RuntimeHelpers.GetObjectValue(enumerator2.Current);
        else
          goto label_29;
label_27:
        num3 = 25;
        if (Information.Err().Number == 0)
          goto label_29;
label_28:
        num3 = 26;
        obj1 = (object) Information.Err().Number;
        goto label_45;
label_29:
        num3 = 30;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
label_31:
        num3 = 33;
        object[] objArray2;
        bool[] flagArray2;
        NewLateBinding.LateCall(Instance, (Type) null, "InstallLicense", objArray2 = new object[1]
        {
          (object) lic
        }, (string[]) null, (Type[]) null, flagArray2 = new bool[1]
        {
          true
        }, true);
        if (flagArray2[0])
          lic = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (string));
label_33:
        num3 = 34;
        if (Information.Err().Number == 0)
          goto label_35;
label_34:
        num3 = 35;
        Information.Err().Clear();
label_35:
        num3 = 37;
        obj3 = (object) null;
label_36:
        num3 = 38;
        Instance = (object) null;
label_37:
        num3 = 39;
        MyProject.Forms.Form1.objCtx = (object) null;
label_38:
        num3 = 40;
        obj1 = (object) 0;
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
                goto label_11;
              case 11:
                goto label_12;
              case 12:
              case 15:
              case 19:
              case 27:
              case 32:
              case 41:
                goto label_45;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_17;
              case 18:
                goto label_22;
              case 20:
                goto label_18;
              case 21:
                goto label_20;
              case 22:
              case 31:
              case 33:
                goto label_31;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_27;
              case 26:
                goto label_28;
              case 28:
              case 30:
                goto label_29;
              case 29:
                num3 = 29;
                goto label_25;
              case 34:
                goto label_33;
              case 35:
                goto label_34;
              case 36:
              case 37:
                goto label_35;
              case 38:
                goto label_36;
              case 39:
                goto label_37;
              case 40:
                goto label_38;
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
      return obj1;
    }

    public bool WmiUninstallLicense(string ProductName)
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
        long num4 = (long) MyProject.Forms.Form1.SetWMIService();
label_3:
        num3 = 4;
        string str = "SoftwareLicensingProduct";
label_4:
        num3 = 5;
        if (Strings.InStr(Strings.UCase(ProductName), "OFFICE 14", CompareMethod.Binary) <= 0)
          goto label_6;
label_5:
        num3 = 6;
        object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, Name, ApplicationId, PartialProductKey, Description, LicenseIsAddon FROM " + str + " WHERE ApplicationId = '59a52881-a989-479d-af46-f275c6370663' AND PartialProductKey <> NULL")
        }, (string[]) null, (Type[]) null, (bool[]) null));
        goto label_7;
label_6:
        num3 = 8;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, LicenseStatus FROM " + str + " WHERE ProductKeyID IS NOT NULL")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_7:
        num3 = 9;
        IEnumerator enumerator1 = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_12;
label_9:
        num3 = 10;
        object objectValue2;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue2)))
          goto label_14;
label_10:
        num3 = 12;
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) ProductName, false))
          goto label_13;
label_11:
        num3 = 15;
label_12:
        if (enumerator1.MoveNext())
        {
          objectValue2 = RuntimeHelpers.GetObjectValue(enumerator1.Current);
          goto label_9;
        }
        else
          goto label_14;
label_13:
        num3 = 13;
        NewLateBinding.LateCall(objectValue2, (Type) null, "UninstallProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
label_14:
        num3 = 16;
        if (enumerator1 is IDisposable)
          (enumerator1 as IDisposable).Dispose();
label_16:
        num3 = 17;
        str = "OfficeSoftwareProtectionProduct";
label_17:
        num3 = 18;
        if (Strings.InStr(Strings.UCase(ProductName), "OFFICE 14", CompareMethod.Binary) <= 0)
          goto label_19;
label_18:
        num3 = 19;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, Name, ApplicationId, PartialProductKey, Description, LicenseIsAddon FROM " + str + " WHERE ApplicationId = '59a52881-a989-479d-af46-f275c6370663' AND PartialProductKey <> NULL")
        }, (string[]) null, (Type[]) null, (bool[]) null));
        goto label_20;
label_19:
        num3 = 21;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, LicenseStatus FROM " + str + " WHERE ProductKeyID IS NOT NULL")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_20:
        num3 = 22;
        IEnumerator enumerator2 = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_25;
label_22:
        num3 = 23;
        object objectValue3;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue3)))
          goto label_27;
label_23:
        num3 = 25;
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue3, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) ProductName, false))
          goto label_26;
label_24:
        num3 = 28;
label_25:
        if (enumerator2.MoveNext())
        {
          objectValue3 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
          goto label_22;
        }
        else
          goto label_27;
label_26:
        num3 = 26;
        NewLateBinding.LateCall(objectValue3, (Type) null, "UninstallProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
label_27:
        num3 = 29;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
label_29:
        num3 = 30;
        MyProject.Forms.Form1.objWMIService = (object) null;
label_30:
        num3 = 31;
        MyProject.Forms.Form1.objSWbemLocator = (object) null;
label_31:
        num3 = 32;
        MyProject.Forms.Form1.objCtx = (object) null;
        goto label_37;
label_33:
        num2 = num3;
        switch (num1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
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
              case 9:
                goto label_7;
              case 8:
                goto label_6;
              case 10:
                goto label_9;
              case 11:
              case 14:
              case 16:
                goto label_14;
              case 12:
                goto label_10;
              case 13:
                goto label_13;
              case 15:
                goto label_11;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
                goto label_18;
              case 20:
              case 22:
                goto label_20;
              case 21:
                goto label_19;
              case 23:
                goto label_22;
              case 24:
              case 27:
              case 29:
                goto label_27;
              case 25:
                goto label_23;
              case 26:
                goto label_26;
              case 28:
                goto label_24;
              case 30:
                goto label_29;
              case 31:
                goto label_30;
              case 32:
                goto label_31;
              case 33:
                goto label_37;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_33;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_37:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return flag;
    }

    public bool InstallProductGVLK_oneKey(string ProductName, string key)
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
        string wmiSpp = this.GetWMI_SPP(ProductName);
label_2:
        num3 = 3;
        flag = false;
label_3:
        num3 = 4;
        string str1 = ProductName;
label_4:
        num3 = 5;
        int num4 = 0;
label_5:
        num3 = 6;
        if (!Strings.UCase(ProductName).Contains("OFFICE 15"))
          goto label_10;
label_6:
        num3 = 7;
        num4 = Strings.InStr(str1, "_", CompareMethod.Binary);
label_7:
        num3 = 8;
        if (num4 <= 0)
          goto label_9;
label_8:
        num3 = 9;
        str1 = str1.Remove(checked (num4 - 1));
label_9:
        num3 = 10;
        this.CheckOfficeRetail();
        goto label_15;
label_10:
        num3 = 12;
        if (!Strings.UCase(ProductName).Contains("OFFICE 14"))
          goto label_15;
label_11:
        num3 = 13;
        num4 = Strings.InStr(str1, "-", CompareMethod.Binary);
label_12:
        num3 = 14;
        if (num4 <= 0)
          goto label_14;
label_13:
        num3 = 15;
        str1 = str1.Remove(checked (num4 - 1));
label_14:
        num3 = 16;
        this.CheckOfficeRetail();
label_15:
        num3 = 17;
        if (Strings.InStr(Strings.UCase(str1), "VISIOPRO", CompareMethod.Binary) <= 0)
          goto label_18;
label_16:
        num3 = 18;
        num4 = Strings.InStr(Strings.UCase(str1), "VISIOPRO", CompareMethod.Binary);
label_17:
        num3 = 19;
        str1 = str1.Remove(checked (num4 + 7));
        goto label_45;
label_18:
        num3 = 21;
        if (Strings.InStr(Strings.UCase(str1), "PROPLUS", CompareMethod.Binary) <= 0)
          goto label_21;
label_19:
        num3 = 22;
        num4 = Strings.InStr(Strings.UCase(str1), "PROPLUS", CompareMethod.Binary);
label_20:
        num3 = 23;
        str1 = str1.Remove(checked (num4 + 6));
        goto label_45;
label_21:
        num3 = 25;
        if (Strings.InStr(Strings.UCase(str1), "PROJECTPRO", CompareMethod.Binary) <= 0)
          goto label_24;
label_22:
        num3 = 26;
        num4 = Strings.InStr(Strings.UCase(str1), "PROJECTPRO", CompareMethod.Binary);
label_23:
        num3 = 27;
        str1 = str1.Remove(checked (num4 + 9));
        goto label_45;
label_24:
        num3 = 29;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16WORD", CompareMethod.Binary) <= 0)
          goto label_27;
label_25:
        num3 = 30;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16WORD", CompareMethod.Binary);
label_26:
        num3 = 31;
        str1 = str1.Remove(checked (num4 + 11));
        goto label_45;
label_27:
        num3 = 33;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16EXCEL", CompareMethod.Binary) <= 0)
          goto label_30;
label_28:
        num3 = 34;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16EXCEL", CompareMethod.Binary);
label_29:
        num3 = 35;
        str1 = str1.Remove(checked (num4 + 12));
        goto label_45;
label_30:
        num3 = 37;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16ACCESS", CompareMethod.Binary) <= 0)
          goto label_33;
label_31:
        num3 = 38;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16ACCESS", CompareMethod.Binary);
label_32:
        num3 = 39;
        str1 = str1.Remove(checked (num4 + 13));
        goto label_45;
label_33:
        num3 = 41;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16ONENOTE", CompareMethod.Binary) <= 0)
          goto label_36;
label_34:
        num3 = 42;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16ONENOTE", CompareMethod.Binary);
label_35:
        num3 = 43;
        str1 = str1.Remove(checked (num4 + 14));
        goto label_45;
label_36:
        num3 = 45;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16OUTLOOK", CompareMethod.Binary) <= 0)
          goto label_39;
label_37:
        num3 = 46;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16OUTLOOK", CompareMethod.Binary);
label_38:
        num3 = 47;
        str1 = str1.Remove(checked (num4 + 14));
        goto label_45;
label_39:
        num3 = 49;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16POWERPOINT", CompareMethod.Binary) <= 0)
          goto label_42;
label_40:
        num3 = 50;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16POWERPOINT", CompareMethod.Binary);
label_41:
        num3 = 51;
        str1 = str1.Remove(checked (num4 + 17));
        goto label_45;
label_42:
        num3 = 53;
        if (Strings.InStr(Strings.UCase(str1), "OFFICE16PUBLISHER", CompareMethod.Binary) <= 0)
          goto label_45;
label_43:
        num3 = 54;
        num4 = Strings.InStr(Strings.UCase(str1), "OFFICE16PUBLISHER", CompareMethod.Binary);
label_44:
        num3 = 55;
        str1 = str1.Remove(checked (num4 + 16));
label_45:
        num3 = 56;
        MyProject.Forms.Form1.SetWMIService();
label_46:
        num3 = 57;
        if (Strings.InStr(Strings.UCase(ProductName), "OFFICE 14", CompareMethod.Binary) <= 0)
          goto label_48;
label_47:
        num3 = 58;
        object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, Name, ApplicationId, PartialProductKey, Description, LicenseIsAddon FROM " + wmiSpp)
        }, (string[]) null, (Type[]) null, (bool[]) null));
        goto label_51;
label_48:
        num3 = 60;
        if (Strings.InStr(Strings.UCase(ProductName), "OFFICE 15", CompareMethod.Binary) <= 0)
          goto label_50;
label_49:
        num3 = 61;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, LicenseStatus FROM " + wmiSpp)
        }, (string[]) null, (Type[]) null, (bool[]) null));
        goto label_51;
label_50:
        num3 = 63;
        objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, ApplicationId, PartialProductKey, LicenseIsAddon, Description, Name, LicenseStatus FROM " + wmiSpp)
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_51:
        num3 = 64;
        IEnumerator enumerator = ((IEnumerable) objectValue1).GetEnumerator();
        goto label_61;
label_53:
        num3 = 65;
        object objectValue2;
        string String1 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_54:
        num3 = 66;
        if (Strings.InStr(String1, str1, CompareMethod.Binary) <= 0)
          goto label_60;
label_55:
        num3 = 67;
        Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "ID", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_56:
        num3 = 68;
        string str2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_57:
        num3 = 69;
        if (Strings.InStr(Strings.UCase(str2), "KMSCLIENT", CompareMethod.Binary) <= 0)
          goto label_60;
label_58:
        num3 = 70;
        this.WmiInstallKey(str1, key);
label_59:
        num3 = 71;
        flag = true;
label_60:
        num3 = 72;
label_61:
        if (enumerator.MoveNext())
        {
          objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
          goto label_53;
        }
label_62:
        num3 = 73;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
label_64:
        num3 = 74;
        MyProject.Forms.Form1.objWMIService = (object) null;
label_65:
        num3 = 75;
        MyProject.Forms.Form1.objSWbemLocator = (object) null;
label_66:
        num3 = 76;
        MyProject.Forms.Form1.objCtx = (object) null;
        goto label_72;
label_68:
        num2 = num3;
        switch (num1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
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
              case 17:
                goto label_15;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 15:
                goto label_13;
              case 16:
                goto label_14;
              case 18:
                goto label_16;
              case 19:
                goto label_17;
              case 20:
              case 24:
              case 28:
              case 32:
              case 36:
              case 40:
              case 44:
              case 48:
              case 52:
              case 56:
                goto label_45;
              case 21:
                goto label_18;
              case 22:
                goto label_19;
              case 23:
                goto label_20;
              case 25:
                goto label_21;
              case 26:
                goto label_22;
              case 27:
                goto label_23;
              case 29:
                goto label_24;
              case 30:
                goto label_25;
              case 31:
                goto label_26;
              case 33:
                goto label_27;
              case 34:
                goto label_28;
              case 35:
                goto label_29;
              case 37:
                goto label_30;
              case 38:
                goto label_31;
              case 39:
                goto label_32;
              case 41:
                goto label_33;
              case 42:
                goto label_34;
              case 43:
                goto label_35;
              case 45:
                goto label_36;
              case 46:
                goto label_37;
              case 47:
                goto label_38;
              case 49:
                goto label_39;
              case 50:
                goto label_40;
              case 51:
                goto label_41;
              case 53:
                goto label_42;
              case 54:
                goto label_43;
              case 55:
                goto label_44;
              case 57:
                goto label_46;
              case 58:
                goto label_47;
              case 59:
              case 62:
              case 64:
                goto label_51;
              case 60:
                goto label_48;
              case 61:
                goto label_49;
              case 63:
                goto label_50;
              case 65:
                goto label_53;
              case 66:
                goto label_54;
              case 67:
                goto label_55;
              case 68:
                goto label_56;
              case 69:
                goto label_57;
              case 70:
                goto label_58;
              case 71:
                goto label_59;
              case 72:
                goto label_60;
              case 73:
                goto label_62;
              case 74:
                goto label_64;
              case 75:
                goto label_65;
              case 76:
                goto label_66;
              case 77:
                goto label_72;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_68;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_72:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return flag;
    }

    private object WmiInstallKey(string ProductName, string key)
    {
label_0:
      int num1;
      object obj1;
      int num2;
      try
      {
        int num3 = 1;
        object Instance = (object) new object[0];
label_1:
        ProjectData.ClearProjectError();
        num1 = 1;
label_2:
        num3 = 3;
        MyProject.Forms.Form1.SetWMIService();
label_3:
        num3 = 4;
        string Left = "SoftwareLicensingProduct";
label_4:
        num3 = 5;
        if (Operators.CompareString(ProductName, "", false) == 0)
          goto label_6;
label_5:
        num3 = 6;
        Left = this.GetWMI_SPP(ProductName);
label_6:
        num3 = 7;
        if (Operators.CompareString(Left, "SoftwareLicensingProduct", false) != 0)
          goto label_22;
label_7:
        num3 = 8;
        string str = "SELECT Version FROM SoftwareLicensingService";
label_8:
        num3 = 9;
        object[] objArray1;
        bool[] flagArray1;
        object obj2 = NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "ExecQuery", objArray1 = new object[1]
        {
          (object) str
        }, (string[]) null, (Type[]) null, flagArray1 = new bool[1]
        {
          true
        });
        if (flagArray1[0])
          str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (string));
        object obj3 = RuntimeHelpers.GetObjectValue(obj2);
label_11:
        num3 = 10;
        if (Information.Err().Number == 0)
          goto label_13;
label_12:
        num3 = 11;
        obj1 = (object) Information.Err().Number;
        goto label_44;
label_13:
        num3 = 13;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(obj3)))
          goto label_44;
label_14:
        num3 = 15;
        IEnumerator enumerator1 = ((IEnumerable) obj3).GetEnumerator();
        goto label_18;
label_16:
        num3 = 16;
        if (Information.Err().Number != 0)
          goto label_21;
label_17:
        num3 = 19;
label_18:
        if (enumerator1.MoveNext())
        {
          Instance = RuntimeHelpers.GetObjectValue(enumerator1.Current);
          goto label_16;
        }
label_19:
        num3 = 20;
        if (enumerator1 is IDisposable)
        {
          (enumerator1 as IDisposable).Dispose();
          goto label_30;
        }
        else
          goto label_30;
label_21:
        num3 = 17;
        obj1 = (object) Information.Err().Number;
        goto label_44;
label_22:
        num3 = 22;
        if (Operators.CompareString(Left, "OfficeSoftwareProtectionProduct", false) != 0)
          goto label_44;
label_23:
        num3 = 23;
        IEnumerator enumerator2 = ((IEnumerable) NewLateBinding.LateGet(MyProject.Forms.Form1.objWMIService, (Type) null, "InstancesOf", new object[1]
        {
          (object) "OfficeSoftwareProtectionService"
        }, (string[]) null, (Type[]) null, (bool[]) null)).GetEnumerator();
label_24:
        if (enumerator2.MoveNext())
          Instance = RuntimeHelpers.GetObjectValue(enumerator2.Current);
        else
          goto label_28;
label_26:
        num3 = 24;
        if (Information.Err().Number == 0)
          goto label_28;
label_27:
        num3 = 25;
        obj1 = (object) Information.Err().Number;
        goto label_44;
label_28:
        num3 = 29;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
label_30:
        num3 = 32;
        object[] objArray2;
        bool[] flagArray2;
        NewLateBinding.LateCall(Instance, (Type) null, "InstallProductKey", objArray2 = new object[1]
        {
          (object) key
        }, (string[]) null, (Type[]) null, flagArray2 = new bool[1]
        {
          true
        }, true);
        if (flagArray2[0])
          key = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (string));
label_32:
        num3 = 33;
        if (Information.Err().Number == 0)
          goto label_34;
label_33:
        num3 = 34;
        Information.Err().Clear();
label_34:
        num3 = 36;
        obj3 = (object) null;
label_35:
        num3 = 37;
        Instance = (object) null;
label_36:
        num3 = 38;
        MyProject.Forms.Form1.objCtx = (object) null;
label_37:
        num3 = 39;
        obj1 = (object) 0;
        goto label_44;
label_40:
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
                goto label_11;
              case 11:
                goto label_12;
              case 12:
              case 14:
              case 18:
              case 26:
              case 31:
              case 40:
                goto label_44;
              case 13:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_16;
              case 17:
                goto label_21;
              case 19:
                goto label_17;
              case 20:
                goto label_19;
              case 21:
              case 30:
              case 32:
                goto label_30;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_26;
              case 25:
                goto label_27;
              case 27:
              case 29:
                goto label_28;
              case 28:
                num3 = 28;
                goto label_24;
              case 33:
                goto label_32;
              case 34:
                goto label_33;
              case 35:
              case 36:
                goto label_34;
              case 37:
                goto label_35;
              case 38:
                goto label_36;
              case 39:
                goto label_37;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_40;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_44:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return obj1;
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button5.Text;
      this.Button5.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\visio16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("visio16.dat", KMSAuto_Net.My.Resources.Resources.visio16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c visio16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("visio16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\visio16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\visio16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strVisiopro16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("visio16");
      this.InstallProductGVLK_oneKey(this._strVisiopro16, "PD3PC-RHNGV-FXJ29-8JK7D-RJRJK");
      this.WmiUninstallLicense(this._strVisiopro16);
      this.Button5.Text = text;
      this.Button5.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button4.Text;
      this.Button4.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\proplus16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("proplus16.dat", KMSAuto_Net.My.Resources.Resources.proplus16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c proplus16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("proplus16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\proplus16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\proplus16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strProplus16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("proplus16");
      this.InstallProductGVLK_oneKey(this._strProplus16, "XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99");
      this.WmiUninstallLicense(this._strProplus16);
      this.Button4.Text = text;
      this.Button4.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button6.Text;
      this.Button6.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\project16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("project16.dat", KMSAuto_Net.My.Resources.Resources.project16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c project16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("project16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\project16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\project16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strProjectpro16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("project16");
      this.InstallProductGVLK_oneKey(this._strProjectpro16, "YG9NW-3K39V-2T3HJ-93F3Q-G83KT");
      this.WmiUninstallLicense(this._strProjectpro16);
      this.Button6.Text = text;
      this.Button6.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button7.Text;
      this.Button7.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\word16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("word16.dat", KMSAuto_Net.My.Resources.Resources.word16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c word16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("word16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\word16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\word16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strWord16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("word16");
      this.InstallProductGVLK_oneKey(this._strWord16, "WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6");
      this.WmiUninstallLicense(this._strWord16);
      this.Button7.Text = text;
      this.Button7.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button8.Text;
      this.Button8.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\excel16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("excel16.dat", KMSAuto_Net.My.Resources.Resources.excel16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c excel16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("excel16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\excel16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\excel16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strExcel16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("excel16");
      this.InstallProductGVLK_oneKey(this._strExcel16, "9C2PK-NWTVB-JMPW8-BFT28-7FTBF");
      this.WmiUninstallLicense(this._strExcel16);
      this.Button8.Text = text;
      this.Button8.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button9.Text;
      this.Button9.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\access16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("access16.dat", KMSAuto_Net.My.Resources.Resources.access16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c access16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("access16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\access16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\access16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strAccess16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("access16");
      this.InstallProductGVLK_oneKey(this._strAccess16, "GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW");
      this.WmiUninstallLicense(this._strAccess16);
      this.Button9.Text = text;
      this.Button9.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button10.Text;
      this.Button10.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\onenote16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("onenote16.dat", KMSAuto_Net.My.Resources.Resources.onenote16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c onenote16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("onenote16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\onenote16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\onenote16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strOneNote16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("onenote16");
      this.InstallProductGVLK_oneKey(this._strOneNote16, "DR92N-9HTF2-97XKM-XW2WJ-XW3J6");
      this.WmiUninstallLicense(this._strOneNote16);
      this.Button10.Text = text;
      this.Button10.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button11_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button11.Text;
      this.Button11.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\outlook16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("outlook16.dat", KMSAuto_Net.My.Resources.Resources.outlook16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c outlook16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("outlook16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\outlook16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\outlook16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strOutlook16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("outlook16");
      this.InstallProductGVLK_oneKey(this._strOutlook16, "R69KK-NTPKF-7M3Q4-QYBHW-6MT9B");
      this.WmiUninstallLicense(this._strOutlook16);
      this.Button11.Text = text;
      this.Button11.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button12_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button12.Text;
      this.Button12.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\powerpoint16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("powerpoint16.dat", KMSAuto_Net.My.Resources.Resources.powerpoint16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c powerpoint16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("powerpoint16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\powerpoint16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\powerpoint16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strPowerPoint16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("powerpoint16");
      this.InstallProductGVLK_oneKey(this._strPowerPoint16, "J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6");
      this.WmiUninstallLicense(this._strPowerPoint16);
      this.Button12.Text = text;
      this.Button12.Enabled = false;
      this._officeConvertRunning = false;
    }

    private void Button13_Click(object sender, EventArgs e)
    {
      if (this._officeConvertRunning)
        return;
      this._officeConvertRunning = true;
      string text = this.Button13.Text;
      this.Button13.Text = Lang.ButtonRuns;
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      while (!File.Exists(MyProject.Forms.Form1.Tempdir + "\\publisher16.dat"))
      {
        MyProject.Computer.FileSystem.WriteAllBytes("publisher16.dat", KMSAuto_Net.My.Resources.Resources.publisher16, false);
        Application.DoEvents();
      }
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c publisher16.dat -y -pkmsauto", AppWinStyle.Hide, true, -1);
      MyProject.Forms.Form1.DelFile("publisher16.dat");
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir + "\\publisher16");
      IEnumerator<string> enumerator;
      try
      {
        enumerator = MyProject.Computer.FileSystem.GetFiles(MyProject.Forms.Form1.Tempdir + "\\publisher16", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.xrm-ms").GetEnumerator();
        while (enumerator.MoveNext())
          this.WmiInstallLic(this._strPublisher16, File.ReadAllText(enumerator.Current));
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Forms.Form1.Tempdir);
      MyProject.Forms.Form1.DelDir("publisher16");
      this.InstallProductGVLK_oneKey(this._strPublisher16, "F47MM-N3XJP-TQXJ9-BP99D-8K837");
      this.WmiUninstallLicense(this._strPublisher16);
      this.Button13.Text = text;
      this.Button13.Enabled = false;
      this._officeConvertRunning = false;
    }
  }
}
