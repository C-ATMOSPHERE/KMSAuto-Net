// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.KmSservice
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;

namespace KMSAuto_Net
{
  [StandardModule]
  internal sealed class KmSservice
  {
    public static bool KmSserviceFlag = false;
    public const string WinPidParam = "-PWin";
    public const string O14PidParam = "-PO14";
    public const string O15PidParam = "-PO15";
    public const string PortParam = "-Port";
    public const string AiParam = "-AI";
    public const string RiParam = "-RI";
    public const string LogParam = "-Log";
    public const string IpParam = "-IP";
    public const string IpFiltrOffParam = "-IPFiltrOFF";
    public const string KillProcessOnPortParam = "KillProcessOnPort";
    public const string HwidParam = "-Hwid";
    private const int ScNotSetError = -2147217376;
    private const int ScNotKmSnameError = -2147217375;
    private const int ScNotRegKeyError = -2147217374;
    private static ServiceController _objKmSservice;
    private const string RegServiceKeyName = "SYSTEM\\CurrentControlSet\\services";
    private const string StartValueName = "ImagePath";

    private static void AddLineToLog(string iLine)
    {
      MyProject.Forms.Form1.MyPrintLine(iLine);
    }

    public static void SetKmsServiceName(string iKms)
    {
      MyProject.Forms.Form1.KmsServerServiceName = iKms;
    }

    public static bool IsKmsServiceExist()
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
        if (Operators.CompareString(MyProject.Forms.Form1.KmsServerServiceName, "", false) != 0)
          goto label_4;
label_3:
        num3 = 4;
        KmSservice.AddLineToLog(Lang.ScNotKmSnameErrText);
label_4:
        num3 = 5;
        if (KmSservice.KmSserviceFlag)
          goto label_6;
label_5:
        num3 = 6;
        KmSservice._objKmSservice = new ServiceController(MyProject.Forms.Form1.KmsServerServiceName);
label_6:
        num3 = 7;
        KmSservice._objKmSservice.Refresh();
label_7:
        num3 = 8;
        if (Information.Err().Number != 0)
          goto label_17;
label_8:
        num3 = 10;
        int status = (int) KmSservice._objKmSservice.Status;
label_9:
        num3 = 11;
        if (Information.Err().Number != 0)
          goto label_17;
label_10:
        num3 = 13;
        KmSservice.KmSserviceFlag = true;
label_11:
        num3 = 14;
        flag = true;
        goto label_17;
label_13:
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
              case 12:
              case 15:
                goto label_17;
              case 10:
                goto label_8;
              case 11:
                goto label_9;
              case 13:
                goto label_10;
              case 14:
                goto label_11;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_13;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_17:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return flag;
    }

    public static void ResetKmsController()
    {
      KmSservice.KmSserviceFlag = false;
      KmSservice._objKmSservice = (ServiceController) null;
    }

    public static int GetKmsStatus(ref int iStatus)
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
        if (KmSservice.KmSserviceFlag)
          goto label_4;
label_2:
        num4 = 3;
        KmSservice.AddLineToLog(Lang.ScNotSetErrText);
label_3:
        num4 = 4;
        num2 = -2147217376;
label_4:
        num4 = 5;
        KmSservice._objKmSservice.Refresh();
label_5:
        num4 = 6;
        if (Information.Err().Number == 0)
          goto label_8;
label_6:
        num4 = 7;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_7:
        num4 = 8;
        num2 = Information.Err().Number;
        goto label_18;
label_8:
        num4 = 10;
        iStatus = (int) KmSservice._objKmSservice.Status;
label_9:
        num4 = 11;
        if (Information.Err().Number == 0)
          goto label_12;
label_10:
        num4 = 12;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_11:
        num4 = 13;
        num2 = Information.Err().Number;
        goto label_18;
label_12:
        num4 = 15;
        num2 = 0;
        goto label_18;
label_14:
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
              case 14:
              case 16:
                goto label_18;
              case 10:
                goto label_8;
              case 11:
                goto label_9;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 15:
                goto label_12;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_14;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_18:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int StartKmSservice()
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
        if (KmSservice.KmSserviceFlag)
          goto label_4;
label_2:
        num4 = 3;
        KmSservice.AddLineToLog(Lang.ScNotSetErrText);
label_3:
        num4 = 4;
        num2 = -2147217376;
label_4:
        num4 = 5;
        KmSservice._objKmSservice.Start();
label_5:
        num4 = 6;
        if (Information.Err().Number == 0)
          goto label_8;
label_6:
        num4 = 7;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_7:
        num4 = 8;
        num2 = Information.Err().Number;
        goto label_24;
label_8:
        num4 = 10;
        KmSservice._objKmSservice.Refresh();
label_9:
        num4 = 11;
        if (Information.Err().Number == 0)
          goto label_15;
label_10:
        num4 = 12;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_11:
        num4 = 13;
        num2 = Information.Err().Number;
        goto label_24;
label_12:
        num4 = 17;
        Thread.Sleep(100);
label_13:
        num4 = 18;
        KmSservice._objKmSservice.Refresh();
label_14:
        num4 = 19;
        if (Information.Err().Number != 0)
          goto label_17;
label_15:
        num4 = 16;
        if (KmSservice._objKmSservice.Status != ServiceControllerStatus.Running)
          goto label_12;
label_16:
        num4 = 24;
        num2 = 0;
        goto label_24;
label_17:
        num4 = 20;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_18:
        num4 = 21;
        num2 = Information.Err().Number;
        goto label_24;
label_20:
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
              case 14:
              case 22:
              case 25:
                goto label_24;
              case 10:
                goto label_8;
              case 11:
                goto label_9;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 15:
              case 16:
              case 23:
                goto label_15;
              case 17:
                goto label_12;
              case 18:
                goto label_13;
              case 19:
                goto label_14;
              case 20:
                goto label_17;
              case 21:
                goto label_18;
              case 24:
                goto label_16;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_20;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_24:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int StopKmSservice()
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
        if (KmSservice.KmSserviceFlag)
          goto label_4;
label_2:
        num4 = 3;
        KmSservice.AddLineToLog(Lang.ScNotSetErrText);
label_3:
        num4 = 4;
        num2 = -2147217376;
label_4:
        num4 = 5;
        KmSservice._objKmSservice.Stop();
label_5:
        num4 = 6;
        if (Information.Err().Number == 0)
          goto label_8;
label_6:
        num4 = 7;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_7:
        num4 = 8;
        num2 = Information.Err().Number;
        goto label_24;
label_8:
        num4 = 10;
        KmSservice._objKmSservice.Refresh();
label_9:
        num4 = 11;
        if (Information.Err().Number == 0)
          goto label_15;
label_10:
        num4 = 12;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_11:
        num4 = 13;
        num2 = Information.Err().Number;
        goto label_24;
label_12:
        num4 = 17;
        Thread.Sleep(100);
label_13:
        num4 = 18;
        KmSservice._objKmSservice.Refresh();
label_14:
        num4 = 19;
        if (Information.Err().Number != 0)
          goto label_17;
label_15:
        num4 = 16;
        if (KmSservice._objKmSservice.Status != ServiceControllerStatus.Stopped)
          goto label_12;
label_16:
        num4 = 24;
        num2 = 0;
        goto label_24;
label_17:
        num4 = 20;
        KmSservice.AddLineToLog(Lang.RunTimeError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_18:
        num4 = 21;
        num2 = Information.Err().Number;
        goto label_24;
label_20:
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
              case 14:
              case 22:
              case 25:
                goto label_24;
              case 10:
                goto label_8;
              case 11:
                goto label_9;
              case 12:
                goto label_10;
              case 13:
                goto label_11;
              case 15:
              case 16:
              case 23:
                goto label_15;
              case 17:
                goto label_12;
              case 18:
                goto label_13;
              case 19:
                goto label_14;
              case 20:
                goto label_17;
              case 21:
                goto label_18;
              case 24:
                goto label_16;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_20;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_24:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int GetCurrentKmsParameters(ref KmSservice.KmssStartKeys parameters)
    {
      parameters.ServiceExe = "";
      parameters.WinPid = "";
      parameters.O14Pid = "";
      parameters.O15Pid = "";
      parameters.Port = "";
      parameters.Ai = "";
      parameters.Ri = "";
      parameters.LogMode = false;
      parameters.LogModeIp = false;
      parameters.KillProcessOnPort = false;
      parameters.Hwid = "";
      if (Operators.CompareString(MyProject.Forms.Form1.KmsServerServiceName, "", false) == 0)
        KmSservice.AddLineToLog(Lang.ScNotKmSnameErrText);
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      int num1;
      if (Information.Err().Number != 0)
      {
        KmSservice.AddLineToLog(Lang.RegOperationError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
        num1 = Information.Err().Number;
      }
      else
      {
        RegistryKey registryKey2 = registryKey1.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + MyProject.Forms.Form1.KmsServerServiceName, true);
        if (Information.Err().Number != 0)
        {
          KmSservice.AddLineToLog(Lang.RegOperationError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
          num1 = Information.Err().Number;
          registryKey1.Close();
        }
        else if (registryKey2 == null)
        {
          KmSservice.AddLineToLog(Lang.ScNotRegKeyErrText);
          num1 = -2147217374;
          registryKey1.Close();
        }
        else
        {
          object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("ImagePath"));
          if (Information.Err().Number != 0)
          {
            KmSservice.AddLineToLog(Lang.RegOperationError + Strings.LCase(Conversion.Hex(Information.Err().Number)));
            num1 = Information.Err().Number;
            registryKey2.Close();
            registryKey1.Close();
          }
          else
          {
            registryKey2.Close();
            registryKey1.Close();
            if (objectValue == null)
            {
              KmSservice.AddLineToLog(Lang.ScNotRegKeyErrText);
              num1 = -2147217374;
              registryKey2.Close();
              registryKey1.Close();
            }
            else
            {
              registryKey2.Close();
              registryKey1.Close();
              string str1 = Conversions.ToString(objectValue);
              int num2 = Strings.Len(str1);
              string str2;
              if (Operators.CompareString(Strings.Left(str1, 1), "\"", false) == 0)
              {
                int Length = Strings.InStr(2, str1, "\"", CompareMethod.Binary);
                if (Length == 0)
                {
                  parameters.ServiceExe = str1;
                  str2 = "";
                }
                else
                {
                  parameters.ServiceExe = Strings.Trim(Strings.Left(str1, Length));
                  str2 = Strings.Trim(Strings.Right(str1, checked (num2 - Length)));
                }
                parameters.ServiceExe = Strings.Mid(parameters.ServiceExe, 2, checked (Strings.Len(parameters.ServiceExe) - 2));
              }
              else
              {
                int Length = Strings.InStr(1, str1, " ", CompareMethod.Binary);
                if (Length == 0)
                {
                  parameters.ServiceExe = str1;
                  str2 = "";
                }
                else
                {
                  while (true)
                  {
                    parameters.ServiceExe = Strings.Trim(Strings.Left(str1, Length));
                    if (!File.Exists(parameters.ServiceExe))
                      checked { ++Length; }
                    else
                      break;
                  }
                  str2 = Strings.Trim(Strings.Right(str1, checked (num2 - Length)));
                }
              }
              int num3 = Strings.Len(str2);
              while (num3 > 0)
              {
                int Length1 = Strings.InStr(1, str2, " ", CompareMethod.Binary);
                string str3;
                if (Length1 == 0)
                {
                  str3 = str2;
                  str2 = "";
                }
                else
                {
                  str3 = Strings.Trim(Strings.Left(str2, Length1));
                  str2 = Strings.Trim(Strings.Right(str2, checked (num3 - Length1)));
                }
                num3 = Strings.Len(str2);
                if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-Log"), false) == 0)
                  parameters.LogMode = true;
                else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-IP"), false) == 0)
                  parameters.LogModeIp = true;
                else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("KillProcessOnPort"), false) == 0)
                  parameters.KillProcessOnPort = true;
                else if (num3 > 0)
                {
                  int Length2 = Strings.InStr(1, str2, " ", CompareMethod.Binary);
                  string str4;
                  if (Length2 == 0)
                  {
                    str4 = str2;
                    str2 = "";
                  }
                  else
                  {
                    str4 = Strings.Trim(Strings.Left(str2, Length2));
                    str2 = Strings.Trim(Strings.Right(str2, checked (num3 - Length2)));
                  }
                  num3 = Strings.Len(str2);
                  if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-PWin"), false) == 0)
                    parameters.WinPid = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-PO14"), false) == 0)
                    parameters.O14Pid = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-PO15"), false) == 0)
                    parameters.O15Pid = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-Port"), false) == 0)
                    parameters.Port = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-AI"), false) == 0)
                    parameters.Ai = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-RI"), false) == 0)
                    parameters.Ri = str4;
                  else if (Operators.CompareString(Strings.UCase(str3), Strings.UCase("-Hwid"), false) == 0)
                    parameters.Hwid = str4;
                }
              }
              num1 = 0;
            }
          }
        }
      }
      return num1;
    }

    public struct KmssStartKeys
    {
      public string ServiceExe;
      public string WinPid;
      public string O14Pid;
      public string O15Pid;
      public string Port;
      public string Ai;
      public string Ri;
      public bool LogMode;
      public bool LogModeIp;
      public bool KillProcessOnPort;
      public string Hwid;
    }
  }
}
