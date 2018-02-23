﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.WmIfunctions
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [StandardModule]
  internal sealed class WmIfunctions
  {
    private static bool _cumulativeCounter = false;
    private static string _spp = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform";
    private static string _sppusers = "HKEY_USERS\\S-1-5-20\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform";
    private static string _ospp = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform";
    public static string[] WmiaProtocol;
    public static int WmiaProtocolLineCount;
    public static WmIfunctions.Counters WindowsOperationCounters;
    public static WmIfunctions.Counters OfficeOperationCounters;
    public const byte WmiaWindowsProduct = 1;
    public const byte WmiaOffice2010Product = 2;
    public const byte WmiaOffice2013Product = 4;
    public const byte WmiaOfficeProduct = 6;
    public const byte WmiaAllProduct = 7;
    public const byte GvlkForceChange = 1;
    public const byte GvlkOwnForSupported = 2;
    public const byte GvlkOwnForUnsupported = 4;
    private const uint WmiLsUnlicensedCode = 0;
    private const string WmiLsUnlicensedDesc = "Unlicensed";
    private const uint WmiLsLicensedCode = 1;
    private const string WmiLsLicensedDesc = "Licensed";
    private const uint WmiLsOobGraceCode = 2;
    private const string WmiLsOobGraceDesc = "Out-of-Box (OOB) Grace";
    private const uint WmiLsOotGraceCode = 3;
    private const string WmiLsOotGraceDesc = "Out-of-Tolerance (OOT) Grace";
    private const uint WmiLsNonGenuineGraceCode = 4;
    private const string WmiLsNonGenuineGraceDesc = "Non Genuine Grace";
    private const uint WmiLsNotificationCode = 5;
    private const string WmiLsNotificationDesc = "Notification";
    private const uint WmiLsExtendedGraceCode = 6;
    private const string WmiLsExtendedGraceDesc = "Extended Grace";
    private const string WmiLsUndefinedDesc = "Undefined";
    private const int WmiaParameterValueError = -2147217407;
    private const int WmiaParameterRangeError = -2147217406;
    private const int WmiaSppRegKeyError = -2147217405;
    private const int WmiaProductProcessError = -2147217392;
    private const string WmiaSppRegKey = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform";
    private const string WmiaOsppRegKey = "SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform";
    private const string WmiaKmsNameValue = "KeyManagementServiceName";
    private const string WmiaKmsPortValue = "KeyManagementServicePort";
    private const string WmiQProductData = "ID, ApplicationId, Name, Description, PartialProductKey, LicenseIsAddon, KeyManagementServiceMachine, KeyManagementServicePort, KeyManagementServiceProductKeyID, LicenseStatus, LicenseStatusReason, GracePeriodRemaining, VLActivationInterval, VLRenewalInterval";
    public const string WmiQSpp = "SoftwareLicensingProduct";
    public const string WmiQSppServiceClass = "SoftwareLicensingService";
    public const string WmiQOspp = "OfficeSoftwareProtectionProduct";
    public const string WmiQOsppServiceClass = "OfficeSoftwareProtectionService";
    private const int WbemImpersonationLevelImpersonate = 3;
    private const int WbemAuthenticationLevelPktPrivacy = 6;
    private static object _objCtx;
    private static object _objSWbemLocator;
    private static object _objWmiService;
    private static byte _ppProductFlags;
    private static byte _ppProcessMode;
    private const byte PpProcessModeStatus = 0;
    private const byte PpProcessModeSet = 1;
    private const byte PpProcessModeActivate = 2;
    private const byte PpProcessModeClear = 3;
    private const byte PpProcessModeGvlk = 4;
    private static string _ppKmsName;
    private static uint _ppKmsPort;
    private static long _ppOperationStatus;
    private static byte _ppChangeMode;
    private static Point _enterGvlkPosition;
    private const int EnterGvlkYOffset = 40;
    private static string _targetName;
    private static string _targetGvlk;

    public static int SetGlobalKmsParameters(string kmSaddress, string kmSport)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_3:
        num4 = 4;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSppOperation);
label_4:
        num4 = 5;
        if (Operators.CompareString(kmSaddress, "", false) != 0)
          goto label_7;
label_5:
        num4 = 6;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsAddress);
label_6:
        num4 = 7;
        num2 = -2147217407;
        goto label_137;
label_7:
        num4 = 9;
        if (Operators.CompareString(kmSport, "", false) != 0)
          goto label_10;
label_8:
        num4 = 10;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortEmpty);
label_9:
        num4 = 11;
        num2 = -2147217407;
        goto label_137;
label_10:
        num4 = 13;
        if (Versioned.IsNumeric((object) kmSport))
          goto label_13;
label_11:
        num4 = 14;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortValue);
label_12:
        num4 = 15;
        num2 = -2147217407;
        goto label_137;
label_13:
        num4 = 17;
        if ((double) Conversions.ToLong(kmSport) == Conversions.ToDouble(kmSport))
          goto label_16;
label_14:
        num4 = 18;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortValue);
label_15:
        num4 = 19;
        num2 = -2147217407;
        goto label_137;
label_16:
        num4 = 21;
        if (!(Conversions.ToLong(kmSport) < 1L | Conversions.ToLong(kmSport) > (long) ushort.MaxValue))
          goto label_19;
label_17:
        num4 = 22;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortRange);
label_18:
        num4 = 23;
        num2 = -2147217406;
        goto label_137;
label_19:
        num4 = 25;
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
label_20:
        num4 = 26;
        if (Information.Err().Number == 0)
          goto label_23;
label_21:
        num4 = 27;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_22:
        num4 = 28;
        num2 = Information.Err().Number;
        goto label_137;
label_23:
        num4 = 30;
        RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform", true);
label_24:
        num4 = 31;
        if (Information.Err().Number == 0)
          goto label_28;
label_25:
        num4 = 32;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_26:
        num4 = 33;
        num2 = Information.Err().Number;
label_27:
        num4 = 34;
        registryKey1.Close();
        goto label_137;
label_28:
        num4 = 36;
        if (registryKey2 != null)
          goto label_32;
label_29:
        num4 = 37;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrSppKey);
label_30:
        num4 = 38;
        num2 = -2147217405;
label_31:
        num4 = 39;
        registryKey1.Close();
        goto label_137;
label_32:
        num4 = 41;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspKmSaddress + kmSaddress + " ...");
label_33:
        num4 = 42;
        object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("KeyManagementServiceName"));
label_34:
        num4 = 43;
        if (Information.Err().Number == 0)
          goto label_39;
label_35:
        num4 = 44;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_36:
        num4 = 45;
        num2 = Information.Err().Number;
label_37:
        num4 = 46;
        registryKey2.Close();
label_38:
        num4 = 47;
        registryKey1.Close();
        goto label_137;
label_39:
        num4 = 49;
        if (objectValue != null)
          goto label_41;
label_40:
        num4 = 50;
        string Left = "";
        goto label_42;
label_41:
        num4 = 52;
        Left = Conversions.ToString(objectValue);
label_42:
        num4 = 53;
        if (Operators.CompareString(Strings.UCase(Left), Strings.UCase(kmSaddress), false) != 0)
          goto label_45;
label_43:
        num4 = 54;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
label_44:
        num4 = 55;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_54;
label_45:
        num4 = 57;
        registryKey2.SetValue("KeyManagementServiceName", (object) kmSaddress, RegistryValueKind.String);
label_46:
        num4 = 58;
        if (Information.Err().Number == 0)
          goto label_52;
label_47:
        num4 = 59;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_48:
        num4 = 60;
        num2 = Information.Err().Number;
label_49:
        num4 = 61;
        registryKey2.Close();
label_50:
        num4 = 62;
        registryKey1.Close();
label_51:
        num4 = 63;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_137;
label_52:
        num4 = 65;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_53:
        num4 = 66;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
label_54:
        num4 = 67;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspKmSport + kmSport + " ...");
label_55:
        num4 = 68;
        objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("KeyManagementServicePort"));
label_56:
        num4 = 69;
        if (Information.Err().Number == 0)
          goto label_61;
label_57:
        num4 = 70;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_58:
        num4 = 71;
        num2 = Information.Err().Number;
label_59:
        num4 = 72;
        registryKey2.Close();
label_60:
        num4 = 73;
        registryKey1.Close();
        goto label_137;
label_61:
        num4 = 75;
        if (objectValue != null)
          goto label_63;
label_62:
        num4 = 76;
        Left = "";
        goto label_64;
label_63:
        num4 = 78;
        Left = Conversions.ToString(objectValue);
label_64:
        num4 = 79;
        if (Operators.CompareString(Left, kmSport, false) != 0)
          goto label_67;
label_65:
        num4 = 80;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
label_66:
        num4 = 81;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_76;
label_67:
        num4 = 83;
        registryKey2.SetValue("KeyManagementServicePort", (object) kmSport, RegistryValueKind.String);
label_68:
        num4 = 84;
        if (Information.Err().Number == 0)
          goto label_74;
label_69:
        num4 = 85;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_70:
        num4 = 86;
        num2 = Information.Err().Number;
label_71:
        num4 = 87;
        registryKey2.Close();
label_72:
        num4 = 88;
        registryKey1.Close();
label_73:
        num4 = 89;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_137;
label_74:
        num4 = 91;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_75:
        num4 = 92;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
label_76:
        num4 = 93;
        registryKey2.Close();
label_77:
        num4 = 94;
        registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform", true);
label_78:
        num4 = 95;
        if (Information.Err().Number == 0)
          goto label_82;
label_79:
        num4 = 96;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_80:
        num4 = 97;
        num2 = Information.Err().Number;
label_81:
        num4 = 98;
        registryKey1.Close();
        goto label_137;
label_82:
        num4 = 100;
        if (registryKey2 != null)
          goto label_85;
label_83:
        num4 = 101;
        num2 = 0;
label_84:
        num4 = 102;
        registryKey1.Close();
        goto label_137;
label_85:
        num4 = 104;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmsopKmSaddress + kmSaddress + " ...");
label_86:
        num4 = 105;
        objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("KeyManagementServiceName"));
label_87:
        num4 = 106;
        if (Information.Err().Number == 0)
          goto label_92;
label_88:
        num4 = 107;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_89:
        num4 = 108;
        num2 = Information.Err().Number;
label_90:
        num4 = 109;
        registryKey2.Close();
label_91:
        num4 = 110;
        registryKey1.Close();
        goto label_137;
label_92:
        num4 = 112;
        if (objectValue != null)
          goto label_94;
label_93:
        num4 = 113;
        Left = "";
        goto label_95;
label_94:
        num4 = 115;
        Left = Conversions.ToString(objectValue);
label_95:
        num4 = 116;
        if (Operators.CompareString(Strings.UCase(Left), Strings.UCase(kmSaddress), false) != 0)
          goto label_98;
label_96:
        num4 = 117;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_97:
        num4 = 118;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
        goto label_107;
label_98:
        num4 = 120;
        registryKey2.SetValue("KeyManagementServiceName", (object) kmSaddress, RegistryValueKind.String);
label_99:
        num4 = 121;
        if (Information.Err().Number == 0)
          goto label_105;
label_100:
        num4 = 122;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_101:
        num4 = 123;
        num2 = Information.Err().Number;
label_102:
        num4 = 124;
        registryKey2.Close();
label_103:
        num4 = 125;
        registryKey1.Close();
label_104:
        num4 = 126;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
        goto label_137;
label_105:
        num4 = 128;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_106:
        num4 = 129;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_107:
        num4 = 130;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmsopKmSport + kmSport + " ...");
label_108:
        num4 = 131;
        objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("KeyManagementServicePort"));
label_109:
        num4 = 132;
        if (Information.Err().Number == 0)
          goto label_114;
label_110:
        num4 = 133;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_111:
        num4 = 134;
        num2 = Information.Err().Number;
label_112:
        num4 = 135;
        registryKey2.Close();
label_113:
        num4 = 136;
        registryKey1.Close();
        goto label_137;
label_114:
        num4 = 138;
        if (objectValue != null)
          goto label_116;
label_115:
        num4 = 139;
        Left = "";
        goto label_117;
label_116:
        num4 = 141;
        Left = Conversions.ToString(objectValue);
label_117:
        num4 = 142;
        if (Operators.CompareString(Left, kmSport, false) != 0)
          goto label_120;
label_118:
        num4 = 143;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
label_119:
        num4 = 144;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
        goto label_129;
label_120:
        num4 = 146;
        registryKey2.SetValue("KeyManagementServicePort", (object) kmSport, RegistryValueKind.String);
label_121:
        num4 = 147;
        if (Information.Err().Number == 0)
          goto label_127;
label_122:
        num4 = 148;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_123:
        num4 = 149;
        num2 = Information.Err().Number;
label_124:
        num4 = 150;
        registryKey2.Close();
label_125:
        num4 = 151;
        registryKey1.Close();
label_126:
        num4 = 152;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
        goto label_137;
label_127:
        num4 = 154;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_128:
        num4 = 155;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_129:
        num4 = 156;
        registryKey2.Close();
label_130:
        num4 = 157;
        registryKey1.Close();
label_131:
        num4 = 158;
        num2 = 0;
        goto label_137;
label_133:
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
              case 12:
              case 16:
              case 20:
              case 24:
              case 29:
              case 35:
              case 40:
              case 48:
              case 64:
              case 74:
              case 90:
              case 99:
              case 103:
              case 111:
              case (int) sbyte.MaxValue:
              case 137:
              case 153:
              case 159:
                goto label_137;
              case 9:
                goto label_7;
              case 10:
                goto label_8;
              case 11:
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
              case 21:
                goto label_16;
              case 22:
                goto label_17;
              case 23:
                goto label_18;
              case 25:
                goto label_19;
              case 26:
                goto label_20;
              case 27:
                goto label_21;
              case 28:
                goto label_22;
              case 30:
                goto label_23;
              case 31:
                goto label_24;
              case 32:
                goto label_25;
              case 33:
                goto label_26;
              case 34:
                goto label_27;
              case 36:
                goto label_28;
              case 37:
                goto label_29;
              case 38:
                goto label_30;
              case 39:
                goto label_31;
              case 41:
                goto label_32;
              case 42:
                goto label_33;
              case 43:
                goto label_34;
              case 44:
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
              case 53:
                goto label_42;
              case 52:
                goto label_41;
              case 54:
                goto label_43;
              case 55:
                goto label_44;
              case 56:
              case 67:
                goto label_54;
              case 57:
                goto label_45;
              case 58:
                goto label_46;
              case 59:
                goto label_47;
              case 60:
                goto label_48;
              case 61:
                goto label_49;
              case 62:
                goto label_50;
              case 63:
                goto label_51;
              case 65:
                goto label_52;
              case 66:
                goto label_53;
              case 68:
                goto label_55;
              case 69:
                goto label_56;
              case 70:
                goto label_57;
              case 71:
                goto label_58;
              case 72:
                goto label_59;
              case 73:
                goto label_60;
              case 75:
                goto label_61;
              case 76:
                goto label_62;
              case 77:
              case 79:
                goto label_64;
              case 78:
                goto label_63;
              case 80:
                goto label_65;
              case 81:
                goto label_66;
              case 82:
              case 93:
                goto label_76;
              case 83:
                goto label_67;
              case 84:
                goto label_68;
              case 85:
                goto label_69;
              case 86:
                goto label_70;
              case 87:
                goto label_71;
              case 88:
                goto label_72;
              case 89:
                goto label_73;
              case 91:
                goto label_74;
              case 92:
                goto label_75;
              case 94:
                goto label_77;
              case 95:
                goto label_78;
              case 96:
                goto label_79;
              case 97:
                goto label_80;
              case 98:
                goto label_81;
              case 100:
                goto label_82;
              case 101:
                goto label_83;
              case 102:
                goto label_84;
              case 104:
                goto label_85;
              case 105:
                goto label_86;
              case 106:
                goto label_87;
              case 107:
                goto label_88;
              case 108:
                goto label_89;
              case 109:
                goto label_90;
              case 110:
                goto label_91;
              case 112:
                goto label_92;
              case 113:
                goto label_93;
              case 114:
              case 116:
                goto label_95;
              case 115:
                goto label_94;
              case 117:
                goto label_96;
              case 118:
                goto label_97;
              case 119:
              case 130:
                goto label_107;
              case 120:
                goto label_98;
              case 121:
                goto label_99;
              case 122:
                goto label_100;
              case 123:
                goto label_101;
              case 124:
                goto label_102;
              case 125:
                goto label_103;
              case 126:
                goto label_104;
              case 128:
                goto label_105;
              case 129:
                goto label_106;
              case 131:
                goto label_108;
              case 132:
                goto label_109;
              case 133:
                goto label_110;
              case 134:
                goto label_111;
              case 135:
                goto label_112;
              case 136:
                goto label_113;
              case 138:
                goto label_114;
              case 139:
                goto label_115;
              case 140:
              case 142:
                goto label_117;
              case 141:
                goto label_116;
              case 143:
                goto label_118;
              case 144:
                goto label_119;
              case 145:
              case 156:
                goto label_129;
              case 146:
                goto label_120;
              case 147:
                goto label_121;
              case 148:
                goto label_122;
              case 149:
                goto label_123;
              case 150:
                goto label_124;
              case 151:
                goto label_125;
              case 152:
                goto label_126;
              case 154:
                goto label_127;
              case 155:
                goto label_128;
              case 157:
                goto label_130;
              case 158:
                goto label_131;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_133;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_137:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int ClearGlobalKmsParameters()
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
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._spp + "\\55C92734-D682-4D71-983E-D6EC3F16059F\" /f", AppWinStyle.Hide, true, -1);
label_2:
        num4 = 3;
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._spp + "\\0FF1CE15-A989-479D-AF46-F275C6370663\" /f", AppWinStyle.Hide, true, -1);
label_3:
        num4 = 4;
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._ospp + "\\59A52881-A989-479D-AF46-F275C6370663\" /f", AppWinStyle.Hide, true, -1);
label_4:
        num4 = 5;
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._ospp + "\\0FF1CE15-A989-479D-AF46-F275C6370663\" /f", AppWinStyle.Hide, true, -1);
label_5:
        num4 = 6;
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._sppusers + "\\55c92734-d682-4d71-983e-d6ec3f16059f\" /f", AppWinStyle.Hide, true, -1);
label_6:
        num4 = 7;
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "reg delete \"" + WmIfunctions._sppusers + "\\0ff1ce15-a989-479d-af46-f275c6370663\" /f", AppWinStyle.Hide, true, -1);
label_7:
        num4 = 8;
        WmIfunctions.ClearCounters();
label_8:
        num4 = 9;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_9:
        num4 = 10;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCgkmspCppOperation);
label_10:
        num4 = 11;
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
label_11:
        num4 = 12;
        if (Information.Err().Number == 0)
          goto label_14;
label_12:
        num4 = 13;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_13:
        num4 = 14;
        num2 = Information.Err().Number;
        goto label_80;
label_14:
        num4 = 16;
        RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform", true);
label_15:
        num4 = 17;
        if (Information.Err().Number == 0)
          goto label_19;
label_16:
        num4 = 18;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_17:
        num4 = 19;
        num2 = Information.Err().Number;
label_18:
        num4 = 20;
        registryKey1.Close();
        goto label_80;
label_19:
        num4 = 22;
        if (registryKey2 != null)
          goto label_23;
label_20:
        num4 = 23;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrSppKey);
label_21:
        num4 = 24;
        num2 = -2147217405;
label_22:
        num4 = 25;
        registryKey1.Close();
        goto label_80;
label_23:
        num4 = 27;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCgkmspKmSname);
label_24:
        num4 = 28;
        registryKey2.DeleteValue("KeyManagementServiceName", false);
label_25:
        num4 = 29;
        if (Information.Err().Number == 0)
          goto label_31;
label_26:
        num4 = 30;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_27:
        num4 = 31;
        num2 = Information.Err().Number;
label_28:
        num4 = 32;
        registryKey2.Close();
label_29:
        num4 = 33;
        registryKey1.Close();
label_30:
        num4 = 34;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_80;
label_31:
        num4 = 36;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
label_32:
        num4 = 37;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_33:
        num4 = 38;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCgkmspKmSport);
label_34:
        num4 = 39;
        registryKey2.DeleteValue("KeyManagementServicePort", false);
label_35:
        num4 = 40;
        if (Information.Err().Number == 0)
          goto label_41;
label_36:
        num4 = 41;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_37:
        num4 = 42;
        num2 = Information.Err().Number;
label_38:
        num4 = 43;
        registryKey2.Close();
label_39:
        num4 = 44;
        registryKey1.Close();
label_40:
        num4 = 45;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_80;
label_41:
        num4 = 47;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
label_42:
        num4 = 48;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_43:
        num4 = 49;
        registryKey2.Close();
label_44:
        num4 = 50;
        registryKey2 = registryKey1.OpenSubKey("SOFTWARE\\Microsoft\\OfficeSoftwareProtectionPlatform", true);
label_45:
        num4 = 51;
        if (Information.Err().Number == 0)
          goto label_49;
label_46:
        num4 = 52;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_47:
        num4 = 53;
        num2 = Information.Err().Number;
label_48:
        num4 = 54;
        registryKey1.Close();
        goto label_80;
label_49:
        num4 = 56;
        if (registryKey2 != null)
          goto label_52;
label_50:
        num4 = 57;
        num2 = 0;
label_51:
        num4 = 58;
        registryKey1.Close();
        goto label_80;
label_52:
        num4 = 60;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCgkmsopKmSname);
label_53:
        num4 = 61;
        registryKey2.DeleteValue("KeyManagementServiceName", false);
label_54:
        num4 = 62;
        if (Information.Err().Number == 0)
          goto label_60;
label_55:
        num4 = 63;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_56:
        num4 = 64;
        num2 = Information.Err().Number;
label_57:
        num4 = 65;
        registryKey2.Close();
label_58:
        num4 = 66;
        registryKey1.Close();
label_59:
        num4 = 67;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
        goto label_80;
label_60:
        num4 = 69;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_61:
        num4 = 70;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_62:
        num4 = 71;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCgkmsopKmSport);
label_63:
        num4 = 72;
        registryKey2.DeleteValue("KeyManagementServicePort", false);
label_64:
        num4 = 73;
        if (Information.Err().Number == 0)
          goto label_70;
label_65:
        num4 = 74;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrRegOperation + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_66:
        num4 = 75;
        num2 = Information.Err().Number;
label_67:
        num4 = 76;
        registryKey2.Close();
label_68:
        num4 = 77;
        registryKey1.Close();
label_69:
        num4 = 78;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
        goto label_80;
label_70:
        num4 = 80;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_71:
        num4 = 81;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_72:
        num4 = 82;
        registryKey2.Close();
label_73:
        num4 = 83;
        registryKey1.Close();
label_74:
        num4 = 84;
        num2 = 0;
        goto label_80;
label_76:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
              case 21:
              case 26:
              case 35:
              case 46:
              case 55:
              case 59:
              case 68:
              case 79:
              case 85:
                goto label_80;
              case 16:
                goto label_14;
              case 17:
                goto label_15;
              case 18:
                goto label_16;
              case 19:
                goto label_17;
              case 20:
                goto label_18;
              case 22:
                goto label_19;
              case 23:
                goto label_20;
              case 24:
                goto label_21;
              case 25:
                goto label_22;
              case 27:
                goto label_23;
              case 28:
                goto label_24;
              case 29:
                goto label_25;
              case 30:
                goto label_26;
              case 31:
                goto label_27;
              case 32:
                goto label_28;
              case 33:
                goto label_29;
              case 34:
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
              case 47:
                goto label_41;
              case 48:
                goto label_42;
              case 49:
                goto label_43;
              case 50:
                goto label_44;
              case 51:
                goto label_45;
              case 52:
                goto label_46;
              case 53:
                goto label_47;
              case 54:
                goto label_48;
              case 56:
                goto label_49;
              case 57:
                goto label_50;
              case 58:
                goto label_51;
              case 60:
                goto label_52;
              case 61:
                goto label_53;
              case 62:
                goto label_54;
              case 63:
                goto label_55;
              case 64:
                goto label_56;
              case 65:
                goto label_57;
              case 66:
                goto label_58;
              case 67:
                goto label_59;
              case 69:
                goto label_60;
              case 70:
                goto label_61;
              case 71:
                goto label_62;
              case 72:
                goto label_63;
              case 73:
                goto label_64;
              case 74:
                goto label_65;
              case 75:
                goto label_66;
              case 76:
                goto label_67;
              case 77:
                goto label_68;
              case 78:
                goto label_69;
              case 80:
                goto label_70;
              case 81:
                goto label_71;
              case 82:
                goto label_72;
              case 83:
                goto label_73;
              case 84:
                goto label_74;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_76;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_80:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int GetProductStatus(byte productGroup)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        string Left = "";
label_3:
        num4 = 4;
        if (((int) productGroup & 1) == 0)
          goto label_5;
label_4:
        num4 = 5;
        Left = "Windows";
label_5:
        num4 = 6;
        if (((int) productGroup & 2) == 0)
          goto label_9;
label_6:
        num4 = 7;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_8;
label_7:
        num4 = 8;
        Left += ", ";
label_8:
        num4 = 9;
        Left += "Office 2010";
label_9:
        num4 = 10;
        if (((int) productGroup & 4) == 0)
          goto label_13;
label_10:
        num4 = 11;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_12;
label_11:
        num4 = 12;
        Left += ", ";
label_12:
        num4 = 13;
        Left += "Office 2013/2016";
label_13:
        num4 = 14;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_14:
        num4 = 15;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGpsHeader + Left);
label_15:
        num4 = 16;
        if (((int) productGroup & 7) != 0)
          goto label_18;
label_16:
        num4 = 17;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrProductGroup);
label_17:
        num4 = 18;
        num2 = -2147217407;
        goto label_45;
label_18:
        num4 = 20;
        WmIfunctions._ppOperationStatus = 0L;
label_19:
        num4 = 21;
        WmIfunctions._ppProductFlags = productGroup;
label_20:
        num4 = 22;
        WmIfunctions._ppProcessMode = (byte) 0;
label_21:
        num4 = 23;
        long num5 = (long) WmIfunctions.SetWmiService();
label_22:
        num4 = 24;
        if (num5 == 0L)
          goto label_24;
label_23:
        num4 = 25;
        num2 = checked ((int) num5);
        goto label_45;
label_24:
        num4 = 27;
        num5 = (long) WmIfunctions.ProductProcess("SoftwareLicensingProduct");
label_25:
        num4 = 28;
        if (num5 == 0L)
          goto label_30;
label_26:
        num4 = 29;
        WmIfunctions._objWmiService = (object) null;
label_27:
        num4 = 30;
        WmIfunctions._objSWbemLocator = (object) null;
label_28:
        num4 = 31;
        WmIfunctions._objCtx = (object) null;
label_29:
        num4 = 32;
        num2 = checked ((int) num5);
        goto label_45;
label_30:
        num4 = 34;
        num5 = (long) WmIfunctions.ProductProcess("OfficeSoftwareProtectionProduct");
label_31:
        num4 = 35;
        if (num5 == 0L)
          goto label_36;
label_32:
        num4 = 36;
        WmIfunctions._objWmiService = (object) null;
label_33:
        num4 = 37;
        WmIfunctions._objSWbemLocator = (object) null;
label_34:
        num4 = 38;
        WmIfunctions._objCtx = (object) null;
label_35:
        num4 = 39;
        num2 = checked ((int) num5);
        goto label_45;
label_36:
        num4 = 41;
        WmIfunctions._objWmiService = (object) null;
label_37:
        num4 = 42;
        WmIfunctions._objSWbemLocator = (object) null;
label_38:
        num4 = 43;
        WmIfunctions._objCtx = (object) null;
label_39:
        num4 = 44;
        num2 = checked ((int) WmIfunctions._ppOperationStatus);
        goto label_45;
label_41:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
              case 26:
              case 33:
              case 40:
              case 45:
                goto label_45;
              case 20:
                goto label_18;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 27:
                goto label_24;
              case 28:
                goto label_25;
              case 29:
                goto label_26;
              case 30:
                goto label_27;
              case 31:
                goto label_28;
              case 32:
                goto label_29;
              case 34:
                goto label_30;
              case 35:
                goto label_31;
              case 36:
                goto label_32;
              case 37:
                goto label_33;
              case 38:
                goto label_34;
              case 39:
                goto label_35;
              case 41:
                goto label_36;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
                goto label_39;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_41;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_45:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int ActivateProduct(byte productGroup)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        string Left = "";
label_3:
        num4 = 4;
        if (((int) productGroup & 1) == 0)
          goto label_5;
label_4:
        num4 = 5;
        Left = "Windows";
label_5:
        num4 = 6;
        if (((int) productGroup & 2) == 0)
          goto label_9;
label_6:
        num4 = 7;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_8;
label_7:
        num4 = 8;
        Left += ", ";
label_8:
        num4 = 9;
        Left += "Office 2010";
label_9:
        num4 = 10;
        if (((int) productGroup & 4) == 0)
          goto label_13;
label_10:
        num4 = 11;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_12;
label_11:
        num4 = 12;
        Left += ", ";
label_12:
        num4 = 13;
        Left += "Office 2013/2016";
label_13:
        num4 = 14;
        if (Operators.CompareString(Left, "", false) != 0)
          goto label_15;
label_14:
        num4 = 15;
        Left = "Undefined";
label_15:
        num4 = 16;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_16:
        num4 = 17;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApHeader + Left);
label_17:
        num4 = 18;
        if (((int) productGroup & 7) != 0)
          goto label_20;
label_18:
        num4 = 19;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrProductGroup);
label_19:
        num4 = 20;
        num2 = -2147217407;
        goto label_47;
label_20:
        num4 = 22;
        WmIfunctions._ppOperationStatus = 0L;
label_21:
        num4 = 23;
        WmIfunctions._ppProductFlags = productGroup;
label_22:
        num4 = 24;
        WmIfunctions._ppProcessMode = (byte) 2;
label_23:
        num4 = 25;
        long num5 = (long) WmIfunctions.SetWmiService();
label_24:
        num4 = 26;
        if (num5 == 0L)
          goto label_26;
label_25:
        num4 = 27;
        num2 = checked ((int) num5);
        goto label_47;
label_26:
        num4 = 29;
        num5 = (long) WmIfunctions.ProductProcess("SoftwareLicensingProduct");
label_27:
        num4 = 30;
        if (num5 == 0L)
          goto label_32;
label_28:
        num4 = 31;
        WmIfunctions._objWmiService = (object) null;
label_29:
        num4 = 32;
        WmIfunctions._objSWbemLocator = (object) null;
label_30:
        num4 = 33;
        WmIfunctions._objCtx = (object) null;
label_31:
        num4 = 34;
        num2 = checked ((int) num5);
        goto label_47;
label_32:
        num4 = 36;
        num5 = (long) WmIfunctions.ProductProcess("OfficeSoftwareProtectionProduct");
label_33:
        num4 = 37;
        if (num5 == 0L)
          goto label_38;
label_34:
        num4 = 38;
        WmIfunctions._objWmiService = (object) null;
label_35:
        num4 = 39;
        WmIfunctions._objSWbemLocator = (object) null;
label_36:
        num4 = 40;
        WmIfunctions._objCtx = (object) null;
label_37:
        num4 = 41;
        num2 = checked ((int) num5);
        goto label_47;
label_38:
        num4 = 43;
        WmIfunctions._objWmiService = (object) null;
label_39:
        num4 = 44;
        WmIfunctions._objSWbemLocator = (object) null;
label_40:
        num4 = 45;
        WmIfunctions._objCtx = (object) null;
label_41:
        num4 = 46;
        num2 = checked ((int) WmIfunctions._ppOperationStatus);
        goto label_47;
label_43:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
                goto label_18;
              case 20:
                goto label_19;
              case 21:
              case 28:
              case 35:
              case 42:
              case 47:
                goto label_47;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
                goto label_24;
              case 27:
                goto label_25;
              case 29:
                goto label_26;
              case 30:
                goto label_27;
              case 31:
                goto label_28;
              case 32:
                goto label_29;
              case 33:
                goto label_30;
              case 34:
                goto label_31;
              case 36:
                goto label_32;
              case 37:
                goto label_33;
              case 38:
                goto label_34;
              case 39:
                goto label_35;
              case 40:
                goto label_36;
              case 41:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
                goto label_39;
              case 45:
                goto label_40;
              case 46:
                goto label_41;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_43;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_47:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int SetProductKmsParameters(string kmSaddress, string kmSport, byte productGroup)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        string Left = "";
label_3:
        num4 = 4;
        if (((int) productGroup & 1) == 0)
          goto label_5;
label_4:
        num4 = 5;
        Left = "Windows";
label_5:
        num4 = 6;
        if (((int) productGroup & 2) == 0)
          goto label_9;
label_6:
        num4 = 7;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_8;
label_7:
        num4 = 8;
        Left += ", ";
label_8:
        num4 = 9;
        Left += "Office 2010";
label_9:
        num4 = 10;
        if (((int) productGroup & 4) == 0)
          goto label_13;
label_10:
        num4 = 11;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_12;
label_11:
        num4 = 12;
        Left += ", ";
label_12:
        num4 = 13;
        Left += "Office 2013/2016";
label_13:
        num4 = 14;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_14:
        num4 = 15;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpHeader + Left);
label_15:
        num4 = 16;
        if (((int) productGroup & 7) != 0)
          goto label_18;
label_16:
        num4 = 17;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrProductGroup);
label_17:
        num4 = 18;
        num2 = -2147217407;
        goto label_62;
label_18:
        num4 = 20;
        if (Operators.CompareString(kmSaddress, "", false) != 0)
          goto label_21;
label_19:
        num4 = 21;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsAddress);
label_20:
        num4 = 22;
        num2 = -2147217407;
        goto label_62;
label_21:
        num4 = 24;
        if (Operators.CompareString(kmSport, "", false) != 0)
          goto label_24;
label_22:
        num4 = 25;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortEmpty);
label_23:
        num4 = 26;
        num2 = -2147217407;
        goto label_62;
label_24:
        num4 = 28;
        if (Versioned.IsNumeric((object) kmSport))
          goto label_27;
label_25:
        num4 = 29;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortValue);
label_26:
        num4 = 30;
        num2 = -2147217407;
        goto label_62;
label_27:
        num4 = 32;
        if ((double) Conversions.ToLong(kmSport) == Conversions.ToDouble(kmSport))
          goto label_30;
label_28:
        num4 = 33;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortValue);
label_29:
        num4 = 34;
        num2 = -2147217407;
        goto label_62;
label_30:
        num4 = 36;
        if (!(Conversions.ToLong(kmSport) < 1L | Conversions.ToLong(kmSport) > (long) ushort.MaxValue))
          goto label_33;
label_31:
        num4 = 37;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrKmsPortRange);
label_32:
        num4 = 38;
        num2 = -2147217406;
        goto label_62;
label_33:
        num4 = 40;
        WmIfunctions._ppOperationStatus = 0L;
label_34:
        num4 = 41;
        WmIfunctions._ppProductFlags = productGroup;
label_35:
        num4 = 42;
        WmIfunctions._ppProcessMode = (byte) 1;
label_36:
        num4 = 43;
        WmIfunctions._ppKmsName = kmSaddress;
label_37:
        num4 = 44;
        WmIfunctions._ppKmsPort = Conversions.ToUInteger(kmSport);
label_38:
        num4 = 45;
        long num5 = (long) WmIfunctions.SetWmiService();
label_39:
        num4 = 46;
        if (num5 == 0L)
          goto label_41;
label_40:
        num4 = 47;
        num2 = checked ((int) num5);
        goto label_62;
label_41:
        num4 = 49;
        num5 = (long) WmIfunctions.ProductProcess("SoftwareLicensingProduct");
label_42:
        num4 = 50;
        if (num5 == 0L)
          goto label_47;
label_43:
        num4 = 51;
        WmIfunctions._objWmiService = (object) null;
label_44:
        num4 = 52;
        WmIfunctions._objSWbemLocator = (object) null;
label_45:
        num4 = 53;
        WmIfunctions._objCtx = (object) null;
label_46:
        num4 = 54;
        num2 = checked ((int) num5);
        goto label_62;
label_47:
        num4 = 56;
        num5 = (long) WmIfunctions.ProductProcess("OfficeSoftwareProtectionProduct");
label_48:
        num4 = 57;
        if (num5 == 0L)
          goto label_53;
label_49:
        num4 = 58;
        WmIfunctions._objWmiService = (object) null;
label_50:
        num4 = 59;
        WmIfunctions._objSWbemLocator = (object) null;
label_51:
        num4 = 60;
        WmIfunctions._objCtx = (object) null;
label_52:
        num4 = 61;
        num2 = checked ((int) num5);
        goto label_62;
label_53:
        num4 = 63;
        WmIfunctions._objWmiService = (object) null;
label_54:
        num4 = 64;
        WmIfunctions._objSWbemLocator = (object) null;
label_55:
        num4 = 65;
        WmIfunctions._objCtx = (object) null;
label_56:
        num4 = 66;
        num2 = checked ((int) WmIfunctions._ppOperationStatus);
        goto label_62;
label_58:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
              case 23:
              case 27:
              case 31:
              case 35:
              case 39:
              case 48:
              case 55:
              case 62:
              case 67:
                goto label_62;
              case 20:
                goto label_18;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 24:
                goto label_21;
              case 25:
                goto label_22;
              case 26:
                goto label_23;
              case 28:
                goto label_24;
              case 29:
                goto label_25;
              case 30:
                goto label_26;
              case 32:
                goto label_27;
              case 33:
                goto label_28;
              case 34:
                goto label_29;
              case 36:
                goto label_30;
              case 37:
                goto label_31;
              case 38:
                goto label_32;
              case 40:
                goto label_33;
              case 41:
                goto label_34;
              case 42:
                goto label_35;
              case 43:
                goto label_36;
              case 44:
                goto label_37;
              case 45:
                goto label_38;
              case 46:
                goto label_39;
              case 47:
                goto label_40;
              case 49:
                goto label_41;
              case 50:
                goto label_42;
              case 51:
                goto label_43;
              case 52:
                goto label_44;
              case 53:
                goto label_45;
              case 54:
                goto label_46;
              case 56:
                goto label_47;
              case 57:
                goto label_48;
              case 58:
                goto label_49;
              case 59:
                goto label_50;
              case 60:
                goto label_51;
              case 61:
                goto label_52;
              case 63:
                goto label_53;
              case 64:
                goto label_54;
              case 65:
                goto label_55;
              case 66:
                goto label_56;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_58;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_62:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int ClearProductKmsParameters(byte productGroup)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        string Left = "";
label_3:
        num4 = 4;
        if (((int) productGroup & 1) == 0)
          goto label_5;
label_4:
        num4 = 5;
        Left = "Windows";
label_5:
        num4 = 6;
        if (((int) productGroup & 2) == 0)
          goto label_9;
label_6:
        num4 = 7;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_8;
label_7:
        num4 = 8;
        Left += ", ";
label_8:
        num4 = 9;
        Left += "Office 2010";
label_9:
        num4 = 10;
        if (((int) productGroup & 4) == 0)
          goto label_13;
label_10:
        num4 = 11;
        if (Operators.CompareString(Left, "", false) == 0)
          goto label_12;
label_11:
        num4 = 12;
        Left += ", ";
label_12:
        num4 = 13;
        Left += "Office 2013/2016";
label_13:
        num4 = 14;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_14:
        num4 = 15;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCpkpHeader + Left);
label_15:
        num4 = 16;
        if (((int) productGroup & 7) != 0)
          goto label_18;
label_16:
        num4 = 17;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrProductGroup);
label_17:
        num4 = 18;
        num2 = -2147217407;
        goto label_45;
label_18:
        num4 = 20;
        WmIfunctions._ppOperationStatus = 0L;
label_19:
        num4 = 21;
        WmIfunctions._ppProductFlags = productGroup;
label_20:
        num4 = 22;
        WmIfunctions._ppProcessMode = (byte) 3;
label_21:
        num4 = 23;
        long num5 = (long) WmIfunctions.SetWmiService();
label_22:
        num4 = 24;
        if (num5 == 0L)
          goto label_24;
label_23:
        num4 = 25;
        num2 = checked ((int) num5);
        goto label_45;
label_24:
        num4 = 27;
        num5 = (long) WmIfunctions.ProductProcess("SoftwareLicensingProduct");
label_25:
        num4 = 28;
        if (num5 == 0L)
          goto label_30;
label_26:
        num4 = 29;
        WmIfunctions._objWmiService = (object) null;
label_27:
        num4 = 30;
        WmIfunctions._objSWbemLocator = (object) null;
label_28:
        num4 = 31;
        WmIfunctions._objCtx = (object) null;
label_29:
        num4 = 32;
        num2 = checked ((int) num5);
        goto label_45;
label_30:
        num4 = 34;
        num5 = (long) WmIfunctions.ProductProcess("OfficeSoftwareProtectionProduct");
label_31:
        num4 = 35;
        if (num5 == 0L)
          goto label_36;
label_32:
        num4 = 36;
        WmIfunctions._objWmiService = (object) null;
label_33:
        num4 = 37;
        WmIfunctions._objSWbemLocator = (object) null;
label_34:
        num4 = 38;
        WmIfunctions._objCtx = (object) null;
label_35:
        num4 = 39;
        num2 = checked ((int) num5);
        goto label_45;
label_36:
        num4 = 41;
        WmIfunctions._objWmiService = (object) null;
label_37:
        num4 = 42;
        WmIfunctions._objSWbemLocator = (object) null;
label_38:
        num4 = 43;
        WmIfunctions._objCtx = (object) null;
label_39:
        num4 = 44;
        num2 = checked ((int) WmIfunctions._ppOperationStatus);
        goto label_45;
label_41:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
              case 26:
              case 33:
              case 40:
              case 45:
                goto label_45;
              case 20:
                goto label_18;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 27:
                goto label_24;
              case 28:
                goto label_25;
              case 29:
                goto label_26;
              case 30:
                goto label_27;
              case 31:
                goto label_28;
              case 32:
                goto label_29;
              case 34:
                goto label_30;
              case 35:
                goto label_31;
              case 36:
                goto label_32;
              case 37:
                goto label_33;
              case 38:
                goto label_34;
              case 39:
                goto label_35;
              case 41:
                goto label_36;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
                goto label_39;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_41;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_45:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    public static int InstallGvlk(byte productGroup, byte changeMode)
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
        WmIfunctions.ClearCounters();
label_2:
        num4 = 3;
        string str = "";
label_3:
        num4 = 4;
        if (((int) productGroup & 1) == 0)
          goto label_5;
label_4:
        num4 = 5;
        str = "Windows";
label_5:
        num4 = 6;
        if (((int) productGroup & 2) == 0)
          goto label_9;
label_6:
        num4 = 7;
        if (Operators.CompareString(str, "", false) == 0)
          goto label_8;
label_7:
        num4 = 8;
        str += ", ";
label_8:
        num4 = 9;
        str += "Office 2010";
label_9:
        num4 = 10;
        if (((int) productGroup & 4) == 0)
          goto label_13;
label_10:
        num4 = 11;
        if (Operators.CompareString(str, "", false) == 0)
          goto label_12;
label_11:
        num4 = 12;
        str += ", ";
label_12:
        num4 = 13;
        str += "Office 2013/2016";
label_13:
        num4 = 14;
        if (Operators.CompareString(str, "", false) != 0)
          goto label_15;
label_14:
        num4 = 15;
        str = "Undefined";
label_15:
        num4 = 16;
        str = Lang.WmiaGvlkHeaderCommon + str;
label_16:
        num4 = 17;
        WmIfunctions.WmiaProtocolLineCount = 0;
label_17:
        num4 = 18;
        if (((int) changeMode & 1) == 0)
          goto label_19;
label_18:
        num4 = 19;
        str = Lang.WmiaGvlkHeaderForce + str;
        goto label_20;
label_19:
        num4 = 21;
        str = Lang.WmiaGvlkHeaderStandard + str;
label_20:
        num4 = 22;
        WmIfunctions.AddLineToProtocol(str);
label_21:
        num4 = 23;
        if (((int) productGroup & 7) != 0)
          goto label_24;
label_22:
        num4 = 24;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrStrProductGroup);
label_23:
        num4 = 25;
        num2 = -2147217407;
        goto label_52;
label_24:
        num4 = 27;
        WmIfunctions._ppOperationStatus = 0L;
label_25:
        num4 = 28;
        WmIfunctions._ppProductFlags = productGroup;
label_26:
        num4 = 29;
        WmIfunctions._ppProcessMode = (byte) 4;
label_27:
        num4 = 30;
        WmIfunctions._ppChangeMode = changeMode;
label_28:
        num4 = 31;
        long num5 = (long) WmIfunctions.SetWmiService();
label_29:
        num4 = 32;
        if (num5 == 0L)
          goto label_31;
label_30:
        num4 = 33;
        num2 = checked ((int) num5);
        goto label_52;
label_31:
        num4 = 35;
        num5 = (long) WmIfunctions.ProductProcess("SoftwareLicensingProduct");
label_32:
        num4 = 36;
        if (num5 == 0L)
          goto label_37;
label_33:
        num4 = 37;
        WmIfunctions._objWmiService = (object) null;
label_34:
        num4 = 38;
        WmIfunctions._objSWbemLocator = (object) null;
label_35:
        num4 = 39;
        WmIfunctions._objCtx = (object) null;
label_36:
        num4 = 40;
        num2 = checked ((int) num5);
        goto label_52;
label_37:
        num4 = 42;
        num5 = (long) WmIfunctions.ProductProcess("OfficeSoftwareProtectionProduct");
label_38:
        num4 = 43;
        if (num5 == 0L)
          goto label_43;
label_39:
        num4 = 44;
        WmIfunctions._objWmiService = (object) null;
label_40:
        num4 = 45;
        WmIfunctions._objSWbemLocator = (object) null;
label_41:
        num4 = 46;
        WmIfunctions._objCtx = (object) null;
label_42:
        num4 = 47;
        num2 = checked ((int) num5);
        goto label_52;
label_43:
        num4 = 49;
        WmIfunctions._objWmiService = (object) null;
label_44:
        num4 = 50;
        WmIfunctions._objSWbemLocator = (object) null;
label_45:
        num4 = 51;
        WmIfunctions._objCtx = (object) null;
label_46:
        num4 = 52;
        num2 = checked ((int) WmIfunctions._ppOperationStatus);
        goto label_52;
label_48:
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
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
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
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
              case 34:
              case 41:
              case 48:
              case 53:
                goto label_52;
              case 27:
                goto label_24;
              case 28:
                goto label_25;
              case 29:
                goto label_26;
              case 30:
                goto label_27;
              case 31:
                goto label_28;
              case 32:
                goto label_29;
              case 33:
                goto label_30;
              case 35:
                goto label_31;
              case 36:
                goto label_32;
              case 37:
                goto label_33;
              case 38:
                goto label_34;
              case 39:
                goto label_35;
              case 40:
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
              case 49:
                goto label_43;
              case 50:
                goto label_44;
              case 51:
                goto label_45;
              case 52:
                goto label_46;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_48;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_52:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private static int SetWmiService()
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
        WmIfunctions._objCtx = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WbemScripting.SWbemNamedValueSet", ""));
label_3:
        num4 = 4;
        if (Information.Err().Number == 0)
          goto label_6;
label_4:
        num4 = 5;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_5:
        num4 = 6;
        num2 = Information.Err().Number;
        goto label_57;
label_6:
        num4 = 8;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(WmIfunctions._objCtx)))
          goto label_9;
label_7:
        num4 = 9;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrobjCtx);
label_8:
        num4 = 10;
        num2 = -2147217392;
        goto label_57;
label_9:
        num4 = 12;
        NewLateBinding.LateCall(WmIfunctions._objCtx, (Type) null, "Add", new object[2]
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
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_12:
        num4 = 15;
        num2 = Information.Err().Number;
        goto label_57;
label_13:
        num4 = 17;
        NewLateBinding.LateCall(WmIfunctions._objCtx, (Type) null, "Add", new object[2]
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
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_16:
        num4 = 20;
        num2 = Information.Err().Number;
        goto label_57;
label_17:
        num4 = 22;
        WmIfunctions._objSWbemLocator = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WbemScripting.SWbemLocator", ""));
label_18:
        num4 = 23;
        if (Information.Err().Number == 0)
          goto label_21;
label_19:
        num4 = 24;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_20:
        num4 = 25;
        num2 = Information.Err().Number;
        goto label_57;
label_21:
        num4 = 27;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(WmIfunctions._objSWbemLocator)))
          goto label_24;
label_22:
        num4 = 28;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrobjSWbemLocator);
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
        object objSwbemLocator = WmIfunctions._objSWbemLocator;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "ConnectServer";
        object[] Arguments;
        object[] objArray = Arguments = new object[8]
        {
          (object) ".",
          (object) "root\\cimv2",
          (object) "",
          (object) "",
          (object) Missing.Value,
          (object) Missing.Value,
          (object) Missing.Value,
          WmIfunctions._objCtx
        };
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] CopyBack = new bool[8];
        CopyBack[7] = true;
        bool[] flagArray = CopyBack;
        object obj = NewLateBinding.LateGet(objSwbemLocator, (Type) local1, MemberName, Arguments, (string[]) local2, (Type[]) local3, CopyBack);
        if (flagArray[7])
          WmIfunctions._objCtx = RuntimeHelpers.GetObjectValue(objArray[7]);
        WmIfunctions._objWmiService = RuntimeHelpers.GetObjectValue(obj);
        goto label_29;
label_28:
        num4 = 34;
        WmIfunctions._objWmiService = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(WmIfunctions._objSWbemLocator, (Type) null, "ConnectServer", new object[2]
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
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_31:
        num4 = 37;
        WmIfunctions._objSWbemLocator = (object) null;
label_32:
        num4 = 38;
        WmIfunctions._objCtx = (object) null;
label_33:
        num4 = 39;
        num2 = Information.Err().Number;
        goto label_57;
label_34:
        num4 = 41;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(WmIfunctions._objWmiService)))
          goto label_37;
label_35:
        num4 = 42;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrobjWmiService);
label_36:
        num4 = 43;
        num2 = -2147217392;
        goto label_57;
label_37:
        num4 = 45;
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(WmIfunctions._objWmiService, (Type) null, "Security_", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "ImpersonationLevel", new object[1]
        {
          (object) 3
        }, (string[]) null, (Type[]) null, false, true);
label_38:
        num4 = 46;
        if (Information.Err().Number == 0)
          goto label_44;
label_39:
        num4 = 47;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_40:
        num4 = 48;
        WmIfunctions._objWmiService = (object) null;
label_41:
        num4 = 49;
        WmIfunctions._objSWbemLocator = (object) null;
label_42:
        num4 = 50;
        WmIfunctions._objCtx = (object) null;
label_43:
        num4 = 51;
        num2 = Information.Err().Number;
        goto label_57;
label_44:
        num4 = 53;
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(WmIfunctions._objWmiService, (Type) null, "Security_", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AuthenticationLevel", new object[1]
        {
          (object) 6
        }, (string[]) null, (Type[]) null, false, true);
label_45:
        num4 = 54;
        if (Information.Err().Number == 0)
          goto label_51;
label_46:
        num4 = 55;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_47:
        num4 = 56;
        WmIfunctions._objWmiService = (object) null;
label_48:
        num4 = 57;
        WmIfunctions._objSWbemLocator = (object) null;
label_49:
        num4 = 58;
        WmIfunctions._objCtx = (object) null;
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

    private static int ProductProcess(string usedService)
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
        object obj1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(WmIfunctions._objWmiService, (Type) null, "ExecQuery", new object[1]
        {
          (object) ("SELECT ID, ApplicationId, Name, Description, PartialProductKey, LicenseIsAddon, KeyManagementServiceMachine, KeyManagementServicePort, KeyManagementServiceProductKeyID, LicenseStatus, LicenseStatusReason, GracePeriodRemaining, VLActivationInterval, VLRenewalInterval FROM " + usedService + " WHERE ProductKeyID IS NOT NULL")
        }, (string[]) null, (Type[]) null, (bool[]) null));
label_2:
        num4 = 3;
        if (Information.Err().Number == 0)
          goto label_5;
label_3:
        num4 = 4;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_4:
        num4 = 5;
        num2 = Information.Err().Number;
        goto label_262;
label_5:
        num4 = 7;
        IEnumerator enumerator = ((IEnumerable) obj1).GetEnumerator();
label_6:
        object objectValue;
        if (enumerator.MoveNext())
          objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
        else
          goto label_253;
label_8:
        num4 = 8;
        if (Information.Err().Number != 0)
          goto label_251;
label_9:
        num4 = 12;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & (int) WmIfunctions._ppProductFlags) == 0)
          goto label_242;
label_10:
        num4 = 13;
        bool flag = WmIfunctions.IsKmsChannel(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_11:
        num4 = 14;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject(Lang.WmiaPpProductName, NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_12:
        num4 = 15;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject((object) Lang.WmiaPpProductDescription, NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_13:
        num4 = 16;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject((object) Lang.WmiaPpPartialProductKey, NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_14:
        num4 = 17;
        switch (WmIfunctions._ppProcessMode)
        {
          case 1:
            goto label_33;
          case 2:
            goto label_77;
          case 3:
            goto label_102;
          case 4:
            goto label_133;
        }
label_15:
        num4 = 298;
        WmIfunctions.AddLineToProtocol(Lang.WmiaPpLicenseStatus + WmIfunctions.GetLicenseStatusDescription(Conversions.ToUInteger(NewLateBinding.LateGet(objectValue, (Type) null, "LicenseStatus", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_16:
        num4 = 299;
        if (!Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(objectValue, (Type) null, "LicenseStatus", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 1U, false))
          goto label_18;
label_17:
        num4 = 300;
        WmIfunctions.AddLineToProtocol(WmIfunctions.GetLicenseReason(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type) null, "LicenseStatusReason", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_18:
        num4 = 301;
        if (!flag)
          goto label_30;
label_19:
        num4 = 302;
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "", false))
          goto label_21;
label_20:
        num4 = 303;
        string addedLine = Lang.WmiaPpKmsHostDefault;
        goto label_22;
label_21:
        num4 = 305;
        addedLine = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_22:
        num4 = 306;
        addedLine = addedLine + ":" + Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServicePort", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_23:
        num4 = 307;
        WmIfunctions.AddLineToProtocol(Lang.WmiaPpKmsHostMachine + addedLine);
label_24:
        num4 = 308;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject((object) Lang.WmiaPpKmShostPid, NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServiceProductKeyID", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_25:
        num4 = 309;
        if (!Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(objectValue, (Type) null, "GracePeriodRemaining", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false))
          goto label_27;
label_26:
        num4 = 310;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Lang.WmiaPpExpirationDateTime + Strings.Format((object) DateAndTime.DateAdd(DateInterval.Minute, Conversions.ToDouble(NewLateBinding.LateGet(objectValue, (Type) null, "GracePeriodRemaining", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), DateAndTime.Now), "dd-MMM-yyyy HH:mm") + "  ( "), WmIfunctions.FormatIntervalDays(Conversions.ToUInteger(NewLateBinding.LateGet(objectValue, (Type) null, "GracePeriodRemaining", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))), (object) " )")));
        goto label_28;
label_27:
        num4 = 312;
        WmIfunctions.AddLineToProtocol(Lang.WmiaPpExpirationDateTime + Lang.WmiaPpExpirationDateTimeExpired);
label_28:
        num4 = 313;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject((object) Lang.WmiaPpActivationInterval, WmIfunctions.FormatInterval(Conversions.ToUInteger(NewLateBinding.LateGet(objectValue, (Type) null, "VLActivationInterval", new object[0], (string[]) null, (Type[]) null, (bool[]) null))))));
label_29:
        num4 = 314;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject((object) Lang.WmiaPpRenewalInterval, WmIfunctions.FormatInterval(Conversions.ToUInteger(NewLateBinding.LateGet(objectValue, (Type) null, "VLRenewalInterval", new object[0], (string[]) null, (Type[]) null, (bool[]) null))))));
label_30:
        num4 = 315;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_32;
label_31:
        num4 = 316;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_242;
label_32:
        num4 = 318;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
        goto label_242;
label_33:
        num4 = 51;
        if (flag)
          goto label_38;
label_34:
        num4 = 52;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_36;
label_35:
        num4 = 53;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_37;
label_36:
        num4 = 55;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_37:
        num4 = 56;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApNotKmsChannel);
        goto label_242;
label_38:
        num4 = 58;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpKmSaddress + WmIfunctions._ppKmsName + "...");
label_39:
        num4 = 59;
        string str1 = Strings.UCase(WmIfunctions._ppKmsName);
        // ISSUE: variable of the null type
        __Null local1 = null;
        Type Type = typeof (Strings);
        string MemberName = "UCase";
        object[] Arguments = new object[1];
        int index = 0;
        object Instance = objectValue;
        object obj2 = NewLateBinding.LateGet(Instance, (Type) null, "KeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
        Arguments[index] = obj2;
        object[] objArray1 = Arguments;
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] CopyBack;
        bool[] flagArray1 = CopyBack = new bool[1]{ true };
        object obj3 = NewLateBinding.LateGet((object) local1, Type, MemberName, Arguments, (string[]) local2, (Type[]) local3, CopyBack);
        if (flagArray1[0])
          NewLateBinding.LateSetComplex(Instance, (Type) null, "KeyManagementServiceMachine", new object[1]
          {
            objArray1[0]
          }, (string[]) null, (Type[]) null, true, false);
        object Right = obj3;
        int num5 = 0;
        if (!Operators.ConditionalCompareObjectEqual((object) str1, Right, num5 != 0))
          goto label_46;
label_42:
        num4 = 60;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_44;
label_43:
        num4 = 61;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_45;
label_44:
        num4 = 63;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_45:
        num4 = 64;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
        goto label_59;
label_46:
        num4 = 66;
        object[] objArray2;
        bool[] flagArray2;
        NewLateBinding.LateCall(objectValue, (Type) null, "SetKeyManagementServiceMachine", objArray2 = new object[1]
        {
          (object) WmIfunctions._ppKmsName
        }, (string[]) null, (Type[]) null, flagArray2 = new bool[1]
        {
          true
        }, true);
        if (flagArray2[0])
          WmIfunctions._ppKmsName = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (string));
label_48:
        num4 = 67;
        if (Information.Err().Number == 0)
          goto label_55;
label_49:
        num4 = 68;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_51;
label_50:
        num4 = 69;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_52;
label_51:
        num4 = 71;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_52:
        num4 = 72;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_53:
        num4 = 73;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_54:
        num4 = 74;
        Information.Err().Clear();
        goto label_59;
label_55:
        num4 = 76;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_57;
label_56:
        num4 = 77;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_58;
label_57:
        num4 = 79;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_58:
        num4 = 80;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_59:
        num4 = 81;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpKmSport + Conversions.ToString(WmIfunctions._ppKmsPort) + "...");
label_60:
        num4 = 82;
        if (!Operators.ConditionalCompareObjectEqual((object) WmIfunctions._ppKmsPort, NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServicePort", new object[0], (string[]) null, (Type[]) null, (bool[]) null), false))
          goto label_65;
label_61:
        num4 = 83;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_63;
label_62:
        num4 = 84;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_64;
label_63:
        num4 = 86;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_64:
        num4 = 87;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSkip);
        goto label_242;
label_65:
        num4 = 89;
        NewLateBinding.LateCall(objectValue, (Type) null, "SetKeyManagementServicePort", new object[1]
        {
          (object) Conversions.ToString(WmIfunctions._ppKmsPort)
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
label_66:
        num4 = 90;
        if (Information.Err().Number == 0)
          goto label_73;
label_67:
        num4 = 91;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_69;
label_68:
        num4 = 92;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_70;
label_69:
        num4 = 94;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_70:
        num4 = 95;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_71:
        num4 = 96;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_72:
        num4 = 97;
        Information.Err().Clear();
        goto label_242;
label_73:
        num4 = 99;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_75;
label_74:
        num4 = 100;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_76;
label_75:
        num4 = 102;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_76:
        num4 = 103;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
        goto label_242;
label_77:
        num4 = 19;
        if (flag)
          goto label_82;
label_78:
        num4 = 20;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_80;
label_79:
        num4 = 21;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_81;
label_80:
        num4 = 23;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_81:
        num4 = 24;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApNotKmsChannel);
        goto label_242;
label_82:
        num4 = 26;
        WmIfunctions.AddLineToProtocol(Lang.WmiaPpLicenseStatus + WmIfunctions.GetLicenseStatusDescription(Conversions.ToUInteger(NewLateBinding.LateGet(objectValue, (Type) null, "LicenseStatus", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
label_83:
        num4 = 27;
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "", false))
          goto label_85;
label_84:
        num4 = 28;
        addedLine = Lang.WmiaPpKmsHostDefault;
        goto label_86;
label_85:
        num4 = 30;
        addedLine = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_86:
        num4 = 31;
        addedLine = addedLine + ":" + Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "KeyManagementServicePort", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
label_87:
        num4 = 32;
        WmIfunctions.AddLineToProtocol(Lang.WmiaPpKmsHostMachine + addedLine);
label_88:
        num4 = 33;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApActivating);
label_89:
        num4 = 34;
        NewLateBinding.LateCall(objectValue, (Type) null, "Activate", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
label_90:
        num4 = 35;
        if (Information.Err().Number == 0)
          goto label_98;
label_91:
        num4 = 36;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_93;
label_92:
        num4 = 37;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_94;
label_93:
        num4 = 39;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_94:
        num4 = 40;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_95:
        num4 = 41;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApActFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_96:
        num4 = 42;
        MyProject.Forms.Form1.Errorcodetxt = Strings.LCase(Conversion.Hex(Information.Err().Number));
label_97:
        num4 = 43;
        Information.Err().Clear();
        goto label_242;
label_98:
        num4 = 45;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_100;
label_99:
        num4 = 46;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_101;
label_100:
        num4 = 48;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_101:
        num4 = 49;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApActSuccessful);
        goto label_242;
label_102:
        num4 = 105;
        if (flag)
          goto label_107;
label_103:
        num4 = 106;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_105;
label_104:
        num4 = 107;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_106;
label_105:
        num4 = 109;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_106:
        num4 = 110;
        WmIfunctions.AddLineToProtocol(Lang.WmiaApNotKmsChannel);
        goto label_242;
label_107:
        num4 = 112;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCpkpKmSaddress + "...");
label_108:
        num4 = 113;
        NewLateBinding.LateCall(objectValue, (Type) null, "ClearKeyManagementServiceMachine", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
label_109:
        num4 = 114;
        if (Information.Err().Number == 0)
          goto label_116;
label_110:
        num4 = 115;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_112;
label_111:
        num4 = 116;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_113;
label_112:
        num4 = 118;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_113:
        num4 = 119;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_114:
        num4 = 120;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_115:
        num4 = 121;
        Information.Err().Clear();
        goto label_120;
label_116:
        num4 = 123;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_118;
label_117:
        num4 = 124;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_119;
label_118:
        num4 = 126;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_119:
        num4 = (int) sbyte.MaxValue;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
label_120:
        num4 = 128;
        WmIfunctions.AddLineToProtocol(Lang.WmiaCpkpKmSport + "...");
label_121:
        num4 = 129;
        NewLateBinding.LateCall(objectValue, (Type) null, "ClearKeyManagementServicePort", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
label_122:
        num4 = 130;
        if (Information.Err().Number == 0)
          goto label_129;
label_123:
        num4 = 131;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_125;
label_124:
        num4 = 132;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_126;
label_125:
        num4 = 134;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_126:
        num4 = 135;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_127:
        num4 = 136;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSpkpFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_128:
        num4 = 137;
        Information.Err().Clear();
        goto label_242;
label_129:
        num4 = 139;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_131;
label_130:
        num4 = 140;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_132;
label_131:
        num4 = 142;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_132:
        num4 = 143;
        WmIfunctions.AddLineToProtocol(Lang.WmiaSgkmspSuccessful);
        goto label_242;
label_133:
        num4 = 145;
        if (!(((int) WmIfunctions._ppChangeMode & 1) == 0 & flag))
          goto label_138;
label_134:
        num4 = 146;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkAlreadyGvlk);
label_135:
        num4 = 147;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_137;
label_136:
        num4 = 148;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_242;
label_137:
        num4 = 150;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
        goto label_242;
label_138:
        num4 = 152;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_140;
label_139:
        num4 = 153;
        int num6 = WmIfunctions.GetWindowsGvlk(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
        goto label_141;
label_140:
        num4 = 155;
        num6 = WmIfunctions.GetOfficeGvlk(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_141:
        num4 = 156;
        int num7 = num6;
label_142:
        num4 = 158;
        if (num7 != 0)
          goto label_172;
label_143:
        num4 = 159;
        if (((int) WmIfunctions._ppChangeMode & 4) == 0)
          goto label_168;
label_144:
        num4 = 160;
        if (MyProject.Forms.Form1.OwnKeyInstallNoDialog)
          goto label_151;
label_145:
        num4 = 161;
        string defGvlk1 = "";
label_146:
        num4 = 162;
        if (Operators.CompareString(MyProject.Forms.Form1.OwnKeyInstallNoDialogKey, "", false) == 0)
          goto label_148;
label_147:
        num4 = 163;
        defGvlk1 = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
label_148:
        num4 = 164;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_150;
label_149:
        num4 = 165;
        string str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkForcedHeader, Lang.EnterGvlkProductInfoUndefined, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkNotExist, defGvlk1);
        goto label_154;
label_150:
        num4 = 167;
        str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkNormalHeader, Lang.EnterGvlkProductInfoUndefined, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkNotExist, defGvlk1);
        goto label_154;
label_151:
        num4 = 169;
        if (!MyProject.Forms.Form1.OwnKeyInstallNoDialogMyKey)
          goto label_153;
label_152:
        num4 = 170;
        str2 = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
        goto label_154;
label_153:
        num4 = 172;
        str2 = WmIfunctions._targetGvlk;
label_154:
        num4 = 173;
        if (Operators.CompareString(str2, "", false) != 0)
          goto label_159;
label_155:
        num4 = 174;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_157;
label_156:
        num4 = 175;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_158;
label_157:
        num4 = 177;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_158:
        num4 = 178;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkCanceledByUser);
        goto label_242;
label_159:
        num4 = 180;
        WmIfunctions._targetGvlk = str2;
label_160:
        num4 = 181;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_162;
label_161:
        num4 = 182;
        addedLine = Lang.WmiaGvlkReinstall;
        goto label_163;
label_162:
        num4 = 184;
        addedLine = Lang.WmiaGvlkInstall;
label_163:
        num4 = 185;
        addedLine = addedLine + Lang.WmiaOwnGvlkKey + WmIfunctions._targetGvlk;
label_164:
        num4 = 186;
        WmIfunctions.AddLineToProtocol(addedLine);
label_165:
        num4 = 187;
        WmIfunctions.AddLineToProtocol(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "  ", NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), (object) " ...")));
label_166:
        num4 = 188;
        int num8 = WmIfunctions.InstallKey(usedService, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_167:
        num4 = 189;
        if (num8 == 0)
          goto label_242;
        else
          goto label_243;
label_168:
        num4 = 194;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_170;
label_169:
        num4 = 195;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_171;
label_170:
        num4 = 197;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_171:
        num4 = 198;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkNotFound);
        goto label_242;
label_172:
        num4 = 200;
        if (num7 >= 0)
          goto label_204;
label_173:
        num4 = 201;
        if (((int) WmIfunctions._ppChangeMode & 4) == 0)
          goto label_198;
label_174:
        num4 = 202;
        if (MyProject.Forms.Form1.OwnKeyInstallNoDialog)
          goto label_181;
label_175:
        num4 = 203;
        string defGvlk2 = "";
label_176:
        num4 = 204;
        if (Operators.CompareString(MyProject.Forms.Form1.OwnKeyInstallNoDialogKey, "", false) == 0)
          goto label_178;
label_177:
        num4 = 205;
        defGvlk2 = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
label_178:
        num4 = 206;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_180;
label_179:
        num4 = 207;
        str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkForcedHeader, Lang.EnterGvlkProductInfoUnsupported, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkNotExist, defGvlk2);
        goto label_184;
label_180:
        num4 = 209;
        str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkNormalHeader, Lang.EnterGvlkProductInfoUnsupported, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkNotExist, defGvlk2);
        goto label_184;
label_181:
        num4 = 211;
        if (!MyProject.Forms.Form1.OwnKeyInstallNoDialogMyKey)
          goto label_183;
label_182:
        num4 = 212;
        str2 = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
        goto label_184;
label_183:
        num4 = 214;
        str2 = WmIfunctions._targetGvlk;
label_184:
        num4 = 215;
        if (Operators.CompareString(str2, "", false) != 0)
          goto label_189;
label_185:
        num4 = 216;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_187;
label_186:
        num4 = 217;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_188;
label_187:
        num4 = 219;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_188:
        num4 = 220;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkCanceledByUser);
        goto label_242;
label_189:
        num4 = 222;
        WmIfunctions._targetGvlk = str2;
label_190:
        num4 = 223;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_192;
label_191:
        num4 = 224;
        addedLine = Lang.WmiaGvlkReinstall;
        goto label_193;
label_192:
        num4 = 226;
        addedLine = Lang.WmiaGvlkInstall;
label_193:
        num4 = 227;
        addedLine = addedLine + Lang.WmiaOwnGvlkKey + WmIfunctions._targetGvlk;
label_194:
        num4 = 228;
        WmIfunctions.AddLineToProtocol(addedLine);
label_195:
        num4 = 229;
        WmIfunctions.AddLineToProtocol("  " + WmIfunctions._targetName + " ...");
label_196:
        num4 = 230;
        num8 = WmIfunctions.InstallKey(usedService, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_197:
        num4 = 231;
        if (num8 == 0)
          goto label_242;
        else
          goto label_245;
label_198:
        num4 = 236;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_200;
label_199:
        num4 = 237;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_201;
label_200:
        num4 = 239;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_201:
        num4 = 240;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkNotSupport1);
label_202:
        num4 = 241;
        WmIfunctions.AddLineToProtocol("  " + WmIfunctions._targetName + Lang.WmiaGvlkNotSupport2);
label_203:
        num4 = 242;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkNotSupport3);
        goto label_242;
label_204:
        num4 = 244;
        if (((int) WmIfunctions._ppChangeMode & 2) == 0)
          goto label_234;
label_205:
        num4 = 245;
        if (!MyProject.Forms.Form1.OwnKeyInstallYesDialog)
          goto label_209;
label_206:
        num4 = 246;
        WmIfunctions._targetGvlk = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
label_207:
        num4 = 247;
        if (Operators.CompareString(MyProject.Forms.Form1.OwnKeyInstallYesDialogProductName, "", false) == 0)
          goto label_209;
label_208:
        num4 = 248;
        NewLateBinding.LateSet(objectValue, (Type) null, "Name", new object[1]
        {
          (object) MyProject.Forms.Form1.OwnKeyInstallYesDialogProductName
        }, (string[]) null, (Type[]) null);
label_209:
        num4 = 249;
        if (!MyProject.Forms.Form1.OwnKeyInstallYesDialog)
          goto label_211;
label_210:
        num4 = 250;
        WmIfunctions._targetGvlk = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
label_211:
        num4 = 251;
        if (MyProject.Forms.Form1.OwnKeyInstallNoDialog)
          goto label_215;
label_212:
        num4 = 252;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_214;
label_213:
        num4 = 253;
        str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkForcedHeader, Lang.EnterGvlkProductInfoSupported, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkExist, WmIfunctions._targetGvlk);
        goto label_218;
label_214:
        num4 = (int) byte.MaxValue;
        str2 = WmIfunctions.GetOwnGvlk(Lang.EnterGvlkNormalHeader, Lang.EnterGvlkProductInfoSupported, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Description", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "PartialProductKey", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Lang.EnterGvlkWarningLblGvlkExist, WmIfunctions._targetGvlk);
        goto label_218;
label_215:
        num4 = 257;
        if (!MyProject.Forms.Form1.OwnKeyInstallNoDialogMyKey)
          goto label_217;
label_216:
        num4 = 258;
        str2 = MyProject.Forms.Form1.OwnKeyInstallNoDialogKey;
        goto label_218;
label_217:
        num4 = 260;
        str2 = WmIfunctions._targetGvlk;
label_218:
        num4 = 261;
        if (Operators.CompareString(str2, "", false) != 0)
          goto label_223;
label_219:
        num4 = 262;
        if (((int) WmIfunctions.DefineProductGroup(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) & 1) == 0)
          goto label_221;
label_220:
        num4 = 263;
        checked { ++WmIfunctions.WindowsOperationCounters.Skipped; }
        goto label_222;
label_221:
        num4 = 265;
        checked { ++WmIfunctions.OfficeOperationCounters.Skipped; }
label_222:
        num4 = 266;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkCanceledByUser);
        goto label_242;
label_223:
        num4 = 268;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_225;
label_224:
        num4 = 269;
        addedLine = Lang.WmiaGvlkReinstall;
        goto label_226;
label_225:
        num4 = 271;
        addedLine = Lang.WmiaGvlkInstall;
label_226:
        num4 = 272;
        if (Operators.CompareString(WmIfunctions._targetGvlk, str2, false) != 0)
          goto label_228;
label_227:
        num4 = 273;
        addedLine = addedLine + Lang.WmiaGvlkKey + WmIfunctions._targetGvlk;
        goto label_230;
label_228:
        num4 = 275;
        WmIfunctions._targetGvlk = str2;
label_229:
        num4 = 276;
        addedLine = addedLine + Lang.WmiaOwnGvlkKey + WmIfunctions._targetGvlk;
label_230:
        num4 = 277;
        WmIfunctions.AddLineToProtocol(addedLine);
label_231:
        num4 = 278;
        WmIfunctions.AddLineToProtocol("  " + WmIfunctions._targetName + " ...");
label_232:
        num4 = 279;
        num8 = WmIfunctions.InstallKey(usedService, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_233:
        num4 = 280;
        if (num8 == 0)
          goto label_242;
        else
          goto label_247;
label_234:
        num4 = 285;
        if (((int) WmIfunctions._ppChangeMode & 1) == 0)
          goto label_236;
label_235:
        num4 = 286;
        addedLine = Lang.WmiaGvlkReinstall;
        goto label_237;
label_236:
        num4 = 288;
        addedLine = Lang.WmiaGvlkInstall;
label_237:
        num4 = 289;
        addedLine = addedLine + Lang.WmiaGvlkKey + WmIfunctions._targetGvlk;
label_238:
        num4 = 290;
        WmIfunctions.AddLineToProtocol(addedLine);
label_239:
        num4 = 291;
        WmIfunctions.AddLineToProtocol("  " + WmIfunctions._targetName + " ...");
label_240:
        num4 = 292;
        num8 = WmIfunctions.InstallKey(usedService, Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
label_241:
        num4 = 293;
        if (num8 != 0)
          goto label_249;
label_242:
        num4 = 320;
        goto label_6;
label_243:
        num4 = 190;
        obj1 = (object) null;
label_244:
        int num9 = 191;
        num2 = num8;
        goto label_262;
label_245:
        num4 = 232;
        obj1 = (object) null;
label_246:
        num9 = 233;
        num2 = num8;
        goto label_262;
label_247:
        num4 = 281;
        obj1 = (object) null;
label_248:
        num9 = 282;
        num2 = num8;
        goto label_262;
label_249:
        num4 = 294;
        obj1 = (object) null;
label_250:
        num9 = 295;
        num2 = num8;
        goto label_262;
label_251:
        num4 = 9;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_252:
        num4 = 10;
        num2 = Information.Err().Number;
        goto label_262;
label_253:
        num4 = 321;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
label_255:
        num4 = 322;
        obj1 = (object) null;
label_256:
        num4 = 323;
        num2 = 0;
        goto label_262;
label_258:
        num3 = num4;
        switch (num1)
        {
          case 1:
            int num10 = num3 + 1;
            num3 = 0;
            switch (num10)
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
              case 11:
              case 192:
              case 234:
              case 283:
              case 296:
              case 324:
                goto label_262;
              case 7:
                goto label_5;
              case 8:
                goto label_8;
              case 9:
                goto label_251;
              case 10:
                goto label_252;
              case 12:
                goto label_9;
              case 13:
                goto label_10;
              case 14:
                goto label_11;
              case 15:
                goto label_12;
              case 16:
                goto label_13;
              case 17:
                goto label_14;
              case 18:
              case 25:
              case 44:
              case 50:
              case 57:
              case 88:
              case 98:
              case 104:
              case 111:
              case 138:
              case 144:
              case 149:
              case 151:
              case 157:
              case 179:
              case 193:
              case 199:
              case 221:
              case 235:
              case 243:
              case 267:
              case 284:
              case 297:
              case 317:
              case 319:
              case 320:
                goto label_242;
              case 19:
                goto label_77;
              case 20:
                goto label_78;
              case 21:
                goto label_79;
              case 22:
              case 24:
                goto label_81;
              case 23:
                goto label_80;
              case 26:
                goto label_82;
              case 27:
                goto label_83;
              case 28:
                goto label_84;
              case 29:
              case 31:
                goto label_86;
              case 30:
                goto label_85;
              case 32:
                goto label_87;
              case 33:
                goto label_88;
              case 34:
                goto label_89;
              case 35:
                goto label_90;
              case 36:
                goto label_91;
              case 37:
                goto label_92;
              case 38:
              case 40:
                goto label_94;
              case 39:
                goto label_93;
              case 41:
                goto label_95;
              case 42:
                goto label_96;
              case 43:
                goto label_97;
              case 45:
                goto label_98;
              case 46:
                goto label_99;
              case 47:
              case 49:
                goto label_101;
              case 48:
                goto label_100;
              case 51:
                goto label_33;
              case 52:
                goto label_34;
              case 53:
                goto label_35;
              case 54:
              case 56:
                goto label_37;
              case 55:
                goto label_36;
              case 58:
                goto label_38;
              case 59:
                goto label_39;
              case 60:
                goto label_42;
              case 61:
                goto label_43;
              case 62:
              case 64:
                goto label_45;
              case 63:
                goto label_44;
              case 65:
              case 75:
              case 81:
                goto label_59;
              case 66:
                goto label_46;
              case 67:
                goto label_48;
              case 68:
                goto label_49;
              case 69:
                goto label_50;
              case 70:
              case 72:
                goto label_52;
              case 71:
                goto label_51;
              case 73:
                goto label_53;
              case 74:
                goto label_54;
              case 76:
                goto label_55;
              case 77:
                goto label_56;
              case 78:
              case 80:
                goto label_58;
              case 79:
                goto label_57;
              case 82:
                goto label_60;
              case 83:
                goto label_61;
              case 84:
                goto label_62;
              case 85:
              case 87:
                goto label_64;
              case 86:
                goto label_63;
              case 89:
                goto label_65;
              case 90:
                goto label_66;
              case 91:
                goto label_67;
              case 92:
                goto label_68;
              case 93:
              case 95:
                goto label_70;
              case 94:
                goto label_69;
              case 96:
                goto label_71;
              case 97:
                goto label_72;
              case 99:
                goto label_73;
              case 100:
                goto label_74;
              case 101:
              case 103:
                goto label_76;
              case 102:
                goto label_75;
              case 105:
                goto label_102;
              case 106:
                goto label_103;
              case 107:
                goto label_104;
              case 108:
              case 110:
                goto label_106;
              case 109:
                goto label_105;
              case 112:
                goto label_107;
              case 113:
                goto label_108;
              case 114:
                goto label_109;
              case 115:
                goto label_110;
              case 116:
                goto label_111;
              case 117:
              case 119:
                goto label_113;
              case 118:
                goto label_112;
              case 120:
                goto label_114;
              case 121:
                goto label_115;
              case 122:
              case 128:
                goto label_120;
              case 123:
                goto label_116;
              case 124:
                goto label_117;
              case 125:
              case (int) sbyte.MaxValue:
                goto label_119;
              case 126:
                goto label_118;
              case 129:
                goto label_121;
              case 130:
                goto label_122;
              case 131:
                goto label_123;
              case 132:
                goto label_124;
              case 133:
              case 135:
                goto label_126;
              case 134:
                goto label_125;
              case 136:
                goto label_127;
              case 137:
                goto label_128;
              case 139:
                goto label_129;
              case 140:
                goto label_130;
              case 141:
              case 143:
                goto label_132;
              case 142:
                goto label_131;
              case 145:
                goto label_133;
              case 146:
                goto label_134;
              case 147:
                goto label_135;
              case 148:
                goto label_136;
              case 150:
                goto label_137;
              case 152:
                goto label_138;
              case 153:
                goto label_139;
              case 154:
              case 156:
                goto label_141;
              case 155:
                goto label_140;
              case 158:
                goto label_142;
              case 159:
                goto label_143;
              case 160:
                goto label_144;
              case 161:
                goto label_145;
              case 162:
                goto label_146;
              case 163:
                goto label_147;
              case 164:
                goto label_148;
              case 165:
                goto label_149;
              case 166:
              case 168:
              case 171:
              case 173:
                goto label_154;
              case 167:
                goto label_150;
              case 169:
                goto label_151;
              case 170:
                goto label_152;
              case 172:
                goto label_153;
              case 174:
                goto label_155;
              case 175:
                goto label_156;
              case 176:
              case 178:
                goto label_158;
              case 177:
                goto label_157;
              case 180:
                goto label_159;
              case 181:
                goto label_160;
              case 182:
                goto label_161;
              case 183:
              case 185:
                goto label_163;
              case 184:
                goto label_162;
              case 186:
                goto label_164;
              case 187:
                goto label_165;
              case 188:
                goto label_166;
              case 189:
                goto label_167;
              case 190:
                goto label_243;
              case 191:
                goto label_244;
              case 194:
                goto label_168;
              case 195:
                goto label_169;
              case 196:
              case 198:
                goto label_171;
              case 197:
                goto label_170;
              case 200:
                goto label_172;
              case 201:
                goto label_173;
              case 202:
                goto label_174;
              case 203:
                goto label_175;
              case 204:
                goto label_176;
              case 205:
                goto label_177;
              case 206:
                goto label_178;
              case 207:
                goto label_179;
              case 208:
              case 210:
              case 213:
              case 215:
                goto label_184;
              case 209:
                goto label_180;
              case 211:
                goto label_181;
              case 212:
                goto label_182;
              case 214:
                goto label_183;
              case 216:
                goto label_185;
              case 217:
                goto label_186;
              case 218:
              case 220:
                goto label_188;
              case 219:
                goto label_187;
              case 222:
                goto label_189;
              case 223:
                goto label_190;
              case 224:
                goto label_191;
              case 225:
              case 227:
                goto label_193;
              case 226:
                goto label_192;
              case 228:
                goto label_194;
              case 229:
                goto label_195;
              case 230:
                goto label_196;
              case 231:
                goto label_197;
              case 232:
                goto label_245;
              case 233:
                goto label_246;
              case 236:
                goto label_198;
              case 237:
                goto label_199;
              case 238:
              case 240:
                goto label_201;
              case 239:
                goto label_200;
              case 241:
                goto label_202;
              case 242:
                goto label_203;
              case 244:
                goto label_204;
              case 245:
                goto label_205;
              case 246:
                goto label_206;
              case 247:
                goto label_207;
              case 248:
                goto label_208;
              case 249:
                goto label_209;
              case 250:
                goto label_210;
              case 251:
                goto label_211;
              case 252:
                goto label_212;
              case 253:
                goto label_213;
              case 254:
              case 256:
              case 259:
              case 261:
                goto label_218;
              case (int) byte.MaxValue:
                goto label_214;
              case 257:
                goto label_215;
              case 258:
                goto label_216;
              case 260:
                goto label_217;
              case 262:
                goto label_219;
              case 263:
                goto label_220;
              case 264:
              case 266:
                goto label_222;
              case 265:
                goto label_221;
              case 268:
                goto label_223;
              case 269:
                goto label_224;
              case 270:
              case 272:
                goto label_226;
              case 271:
                goto label_225;
              case 273:
                goto label_227;
              case 274:
              case 277:
                goto label_230;
              case 275:
                goto label_228;
              case 276:
                goto label_229;
              case 278:
                goto label_231;
              case 279:
                goto label_232;
              case 280:
                goto label_233;
              case 281:
                goto label_247;
              case 282:
                goto label_248;
              case 285:
                goto label_234;
              case 286:
                goto label_235;
              case 287:
              case 289:
                goto label_237;
              case 288:
                goto label_236;
              case 290:
                goto label_238;
              case 291:
                goto label_239;
              case 292:
                goto label_240;
              case 293:
                goto label_241;
              case 294:
                goto label_249;
              case 295:
                goto label_250;
              case 298:
                goto label_15;
              case 299:
                goto label_16;
              case 300:
                goto label_17;
              case 301:
                goto label_18;
              case 302:
                goto label_19;
              case 303:
                goto label_20;
              case 304:
              case 306:
                goto label_22;
              case 305:
                goto label_21;
              case 307:
                goto label_23;
              case 308:
                goto label_24;
              case 309:
                goto label_25;
              case 310:
                goto label_26;
              case 311:
              case 313:
                goto label_28;
              case 312:
                goto label_27;
              case 314:
                goto label_29;
              case 315:
                goto label_30;
              case 316:
                goto label_31;
              case 318:
                goto label_32;
              case 321:
                goto label_253;
              case 322:
                goto label_255;
              case 323:
                goto label_256;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_258;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_262:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private static string GetOwnGvlk(string frmHeader, string infHeader, string prNameData, string prDescData, string prPartKey, string warnData, string defGvlk)
    {
      Cursor cursor = MyProject.Forms.Form1.Cursor;
      MyProject.Forms.EnterGvlk.Text = frmHeader;
      MyProject.Forms.EnterGvlk.ProductInfo.Text = infHeader;
      MyProject.Forms.EnterGvlk.ProductNameData.Text = prNameData;
      MyProject.Forms.EnterGvlk.ProductDescriptionData.Text = prDescData;
      MyProject.Forms.EnterGvlk.PartialKey.Text = prPartKey;
      MyProject.Forms.EnterGvlk.StartPosition = FormStartPosition.Manual;
      WmIfunctions._enterGvlkPosition = MyProject.Forms.Form1.Location;
      checked { WmIfunctions._enterGvlkPosition.Y += 40; }
      checked { WmIfunctions._enterGvlkPosition.X -= 15; }
      MyProject.Forms.EnterGvlk.Location = WmIfunctions._enterGvlkPosition;
      MyProject.Forms.EnterGvlk.WarningLbl.Text = warnData;
      MyProject.Forms.EnterGvlk.EnteredGVLK.Text = defGvlk;
      int num = (int) MyProject.Forms.EnterGvlk.ShowDialog();
      string str = Strings.UCase(Strings.Trim(MyProject.Forms.EnterGvlk.EnteredGVLK.Text));
      MyProject.Forms.Form1.Cursor = cursor;
      return str;
    }

    private static int InstallKey(string service, string productName)
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
        if (Operators.CompareString(service, "SoftwareLicensingProduct", false) != 0)
          goto label_21;
label_2:
        num4 = 3;
        string str = "SELECT Version FROM SoftwareLicensingService";
label_3:
        num4 = 4;
        object[] objArray1;
        bool[] flagArray1;
        object obj1 = NewLateBinding.LateGet(WmIfunctions._objWmiService, (Type) null, "ExecQuery", objArray1 = new object[1]
        {
          (object) str
        }, (string[]) null, (Type[]) null, flagArray1 = new bool[1]
        {
          true
        });
        if (flagArray1[0])
          str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (string));
        object obj2 = RuntimeHelpers.GetObjectValue(obj1);
label_6:
        num4 = 5;
        if (Information.Err().Number == 0)
          goto label_9;
label_7:
        num4 = 6;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_8:
        num4 = 7;
        num2 = Information.Err().Number;
        goto label_55;
label_9:
        num4 = 9;
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj2)))
          goto label_12;
label_10:
        num4 = 10;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrcolServices);
label_11:
        num4 = 11;
        num2 = -2147217392;
        goto label_55;
label_12:
        num4 = 13;
        IEnumerator enumerator1 = ((IEnumerable) obj2).GetEnumerator();
        goto label_16;
label_14:
        num4 = 14;
        if (Information.Err().Number != 0)
          goto label_19;
label_15:
        num4 = 18;
label_16:
        object Instance;
        if (enumerator1.MoveNext())
        {
          Instance = RuntimeHelpers.GetObjectValue(enumerator1.Current);
          goto label_14;
        }
label_17:
        num4 = 19;
        if (enumerator1 is IDisposable)
        {
          (enumerator1 as IDisposable).Dispose();
          goto label_30;
        }
        else
          goto label_30;
label_19:
        num4 = 15;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_20:
        num4 = 16;
        num2 = Information.Err().Number;
        goto label_55;
label_21:
        num4 = 21;
        if (Operators.CompareString(service, "OfficeSoftwareProtectionProduct", false) != 0)
          goto label_46;
label_22:
        num4 = 22;
        IEnumerator enumerator2 = ((IEnumerable) NewLateBinding.LateGet(WmIfunctions._objWmiService, (Type) null, "InstancesOf", new object[1]
        {
          (object) "OfficeSoftwareProtectionService"
        }, (string[]) null, (Type[]) null, (bool[]) null)).GetEnumerator();
label_23:
        if (enumerator2.MoveNext())
          Instance = RuntimeHelpers.GetObjectValue(enumerator2.Current);
        else
          goto label_28;
label_25:
        num4 = 23;
        if (Information.Err().Number == 0)
          goto label_28;
label_26:
        num4 = 24;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrRunTime + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_27:
        num4 = 25;
        num2 = Information.Err().Number;
        goto label_55;
label_28:
        num4 = 29;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
label_30:
        num4 = 35;
        object[] objArray2;
        bool[] flagArray2;
        NewLateBinding.LateCall(Instance, (Type) null, "InstallProductKey", objArray2 = new object[1]
        {
          (object) WmIfunctions._targetGvlk
        }, (string[]) null, (Type[]) null, flagArray2 = new bool[1]
        {
          true
        }, true);
        if (flagArray2[0])
          WmIfunctions._targetGvlk = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (string));
label_32:
        num4 = 36;
        if (Information.Err().Number == 0)
          goto label_39;
label_33:
        num4 = 37;
        if (((int) WmIfunctions.DefineProductGroup(productName) & 1) == 0)
          goto label_35;
label_34:
        num4 = 38;
        checked { ++WmIfunctions.WindowsOperationCounters.Failed; }
        goto label_36;
label_35:
        num4 = 40;
        checked { ++WmIfunctions.OfficeOperationCounters.Failed; }
label_36:
        num4 = 41;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_37:
        num4 = 42;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkFailed + Strings.LCase(Conversion.Hex(Information.Err().Number)));
label_38:
        num4 = 43;
        Information.Err().Clear();
        goto label_43;
label_39:
        num4 = 45;
        if (((int) WmIfunctions.DefineProductGroup(productName) & 1) == 0)
          goto label_41;
label_40:
        num4 = 46;
        checked { ++WmIfunctions.WindowsOperationCounters.Successful; }
        goto label_42;
label_41:
        num4 = 48;
        checked { ++WmIfunctions.OfficeOperationCounters.Successful; }
label_42:
        num4 = 49;
        WmIfunctions.AddLineToProtocol(Lang.WmiaGvlkSuccessful);
label_43:
        num4 = 50;
        obj2 = (object) null;
label_44:
        num4 = 51;
        Instance = (object) null;
label_45:
        num4 = 52;
        num2 = 0;
        goto label_55;
label_46:
        num4 = 31;
        WmIfunctions._ppOperationStatus = -2147217392L;
label_47:
        num4 = 32;
        WmIfunctions.AddLineToProtocol(Lang.WmiaErrUndefined);
label_48:
        num4 = 33;
        num2 = -2147217392;
        goto label_55;
label_51:
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
                goto label_6;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
              case 12:
              case 17:
              case 26:
              case 34:
              case 53:
                goto label_55;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_14;
              case 15:
                goto label_19;
              case 16:
                goto label_20;
              case 18:
                goto label_15;
              case 19:
                goto label_17;
              case 20:
              case 30:
              case 35:
                goto label_30;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_25;
              case 24:
                goto label_26;
              case 25:
                goto label_27;
              case 27:
              case 29:
                goto label_28;
              case 28:
                num4 = 28;
                goto label_23;
              case 31:
                goto label_46;
              case 32:
                goto label_47;
              case 33:
                goto label_48;
              case 36:
                goto label_32;
              case 37:
                goto label_33;
              case 38:
                goto label_34;
              case 39:
              case 41:
                goto label_36;
              case 40:
                goto label_35;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
              case 50:
                goto label_43;
              case 45:
                goto label_39;
              case 46:
                goto label_40;
              case 47:
              case 49:
                goto label_42;
              case 48:
                goto label_41;
              case 51:
                goto label_44;
              case 52:
                goto label_45;
            }
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_51;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_55:
      if (num3 != 0)
        ProjectData.ClearProjectError();
      return num2;
    }

    private static byte DefineProductGroup(string prodName)
    {
      byte num = 0;
      if (Strings.InStr(prodName, "Windows", CompareMethod.Text) > 0)
        num = (byte) 1;
      else if (Strings.InStr(prodName, "Office 14", CompareMethod.Text) > 0)
        num = (byte) 2;
      else if (Strings.InStr(prodName, "Office 15", CompareMethod.Text) > 0 | Strings.InStr(prodName, "Office 16", CompareMethod.Text) > 0)
        num = (byte) 4;
      return num;
    }

    private static string GetLicenseStatusDescription(uint licStatus)
    {
      string str;
      switch (licStatus)
      {
        case 0:
          str = "Unlicensed";
          break;
        case 1:
          str = "Licensed";
          break;
        case 2:
          str = "Out-of-Box (OOB) Grace";
          break;
        case 3:
          str = "Out-of-Tolerance (OOT) Grace";
          break;
        case 4:
          str = "Non Genuine Grace";
          break;
        case 5:
          str = "Notification";
          break;
        case 6:
          str = "Extended Grace";
          break;
        default:
          str = "Undefined";
          break;
      }
      return str;
    }

    private static bool IsKmsChannel(string prodName, string prodDescription)
    {
      bool flag = false;
      if (Strings.InStr(prodName, "Windows", CompareMethod.Text) > 0)
      {
        if (Strings.InStr(prodDescription, "VOLUME_KMSCLIENT", CompareMethod.Binary) > 0)
          flag = true;
      }
      else if (Strings.InStr(prodName, "Office", CompareMethod.Text) > 0)
      {
        if (Strings.InStr(prodName, "KMS_Client", CompareMethod.Text) > 0)
          flag = true;
      }
      else
        flag = false;
      return flag;
    }

    private static int GetWindowsGvlk(string productName, string productDescription)
    {
      string[,] strArray1 = new string[24, 4]
      {
        {
          "Windows(R) 7, Embedded edition",
          "2",
          "Windows Embedded POSREady 7",
          "YBYF6-BHCR3-JPKRB-CDW7B-F9BK4"
        },
        {
          "Windows(R) 7, Professional edition",
          "0",
          "Windows 7 Professional",
          "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4"
        },
        {
          "Windows(R) 7, ProfessionalN edition",
          "0",
          "Windows 7 Professional N",
          "MRPKT-YTG23-K7D7T-X2JMM-QY7MG"
        },
        {
          "Windows(R) 7, Enterprise edition",
          "3",
          "Windows 7 Enterprise",
          "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH"
        },
        {
          "Windows(R) 7, EnterpriseN edition",
          "3",
          "Windows 7 Enterprise N",
          "YDRBP-3D83W-TY26F-D46B2-XCKRJ"
        },
        {
          "Windows(R) 7, EnterpriseE edition",
          "3",
          "Windows 7 Enterprise E",
          "C29WB-22CC8-VJ326-GHFJW-H9DH4"
        },
        {
          "Windows(R), Core edition",
          "0",
          "Windows 8 Core",
          "BN3D2-R7TKB-3YPBD-8DRP2-27GG4"
        },
        {
          "Windows(R), CoreSingleLanguage edition",
          "0",
          "Windows 8 Core Single Language",
          "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ"
        },
        {
          "Windows(R), Professional edition",
          "0",
          "Windows 8 Professional",
          "NG4HW-VH26C-733KW-K6F98-J8CK4"
        },
        {
          "Windows(R), ProfessionalN edition",
          "0",
          "Windows 8 Professional N",
          "XCVCF-2NXM9-723PB-MHCB7-2RYQQ"
        },
        {
          "Windows(R), ProfessionalWMC edition",
          "0",
          "Windows 8 Professional WMC",
          "GNBB8-YVD74-QJHX6-27H4K-8QHDG"
        },
        {
          "Windows(R), Enterprise edition",
          "1",
          "Windows 8 Enterprise",
          "32JNW-9KQ84-P47T8-D8GGY-CWCK7"
        },
        {
          "Windows(R), EnterpriseEval edition",
          "3",
          "Windows 8 Enterprise Evaluation",
          "32JNW-9KQ84-P47T8-D8GGY-CWCK7"
        },
        {
          "Windows(R), EnterpriseN edition",
          "1",
          "Windows 8 Enterprise N",
          "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT"
        },
        {
          "Windows(R) Web Server, ServerWeb edition",
          "2",
          "Server 2008 R2 Web",
          "6TPJF-RBVHG-WBW2R-86QPH-6RTM4"
        },
        {
          "Windows Server(R), ServerStandard edition",
          "2",
          "Server 2008 R2 Standard",
          "YC6KT-GKW9T-YTKYR-T4X34-R7VHC"
        },
        {
          "Windows Server(R), ServerEnterprise edition",
          "2",
          "Server 2008 R2 Enterprise",
          "489J6-VHDMP-X63PK-3K798-CPX3Y"
        },
        {
          "Windows Server(R), ServerDatacenter edition",
          "2",
          "Server 2008 R2 Datacenter",
          "74YFP-3QFB3-KQT8W-PMXWJ-7M648"
        },
        {
          "Windows(R), ServerStandard edition",
          "0",
          "Server 2012 Standard",
          "XC9B7-NBPP2-83J2H-RHMBY-92BT4"
        },
        {
          "Windows(R), ServerDatacenter edition",
          "0",
          "Server 2012 Datacenter",
          "48HP8-DN98B-MYWDG-T2DCC-8W83P"
        },
        {
          "Windows(R), ServerStandardEval edition",
          "2",
          "Server 2012 Standard Evaluation",
          "XC9B7-NBPP2-83J2H-RHMBY-92BT4"
        },
        {
          "Windows(R), ServerDatacenterEval edition",
          "2",
          "Server 2012 Datacenter Evaluation",
          "48HP8-DN98B-MYWDG-T2DCC-8W83P"
        },
        {
          "Windows(R), ServerMultiPointStandard edition",
          "2",
          "Server 2012 MultiPoint Standard",
          "HM7DN-YVMH3-46JC3-XYTG7-CYQJJ"
        },
        {
          "Windows(R), ServerMultiPointPremium edition",
          "2",
          "Server 2012 MultiPoint Premium",
          "XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G"
        }
      };
      string[,] strArray2 = new string[4, 4]
      {
        {
          "<none>",
          "RETAIL channel",
          "VOLUME_MAK channel",
          "VOLUME_KMSCLIENT channel"
        },
        {
          "<none>",
          "<none>",
          "VOLUME_MAK channel",
          "VOLUME_KMSCLIENT channel"
        },
        {
          "TIMEBASED_EVAL channel",
          "RETAIL channel",
          "VOLUME_MAK channel",
          "VOLUME_KMSCLIENT channel"
        },
        {
          "TIMEBASED_EVAL channel",
          "<none>",
          "VOLUME_MAK channel",
          "VOLUME_KMSCLIENT channel"
        }
      };
      WmIfunctions._targetName = "";
      WmIfunctions._targetGvlk = "";
      int num = 0;
      int upperBound1 = strArray1.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        if (Strings.InStr(productName, strArray1[index1, 0], CompareMethod.Text) > 0)
        {
          WmIfunctions._targetName = strArray1[index1, 2];
          num = -1;
          int integer = Conversions.ToInteger(strArray1[index1, 1]);
          int upperBound2 = strArray2.GetUpperBound(1);
          int index2 = 0;
          while (index2 <= upperBound2)
          {
            if (Strings.InStr(productDescription, strArray2[integer, index2], CompareMethod.Text) <= 0)
            {
              checked { ++index2; }
            }
            else
            {
              WmIfunctions._targetGvlk = strArray1[index1, 3];
              num = 1;
              goto label_9;
            }
          }
        }
        checked { ++index1; }
      }
label_9:
      return num;
    }

    private static int GetOfficeGvlk(string productName)
    {
      string[,] strArray1 = new string[45, 4]
      {
        {
          "Office 14, OfficeProPlus",
          "0",
          "Office 2010 Professional Plus",
          "VYBBJ-TRJPB-QFQRF-QFT4D-H3GVB"
        },
        {
          "Office 14, OfficeStandard",
          "0",
          "Office 2010 Standard",
          "V7QKV-4XVVR-XYV4D-F7DFM-8R6BM"
        },
        {
          "Office 14, OfficeSmallBusBasics",
          "0",
          "Office 2010 Small Business Basics",
          "D6QFG-VBYP2-XQHM7-J97RH-VVRCK"
        },
        {
          "Office 14, OfficeAccess",
          "0",
          "Access 2010",
          "V7Y44-9T38C-R2VJK-666HK-T7DDX"
        },
        {
          "Office 14, OfficeExcel",
          "0",
          "KMS_Client edition",
          "H62QG-HXVKF-PP4HP-66KMR-CW9BM"
        },
        {
          "Office 14, OfficeInfoPath",
          "0",
          "InfoPath 2010",
          "K96W8-67RPQ-62T9Y-J8FQJ-BT37T"
        },
        {
          "Office 14, OfficeOneNote",
          "0",
          "OneNote 2010",
          "Q4Y4M-RHWJM-PY37F-MTKWH-D3XHX"
        },
        {
          "Office 14, OfficeOutlook",
          "0",
          "Outlook 2010",
          "7YDC2-CWM8M-RRTJC-8MDVC-X3DWQ"
        },
        {
          "Office 14, OfficePowerPoint",
          "0",
          "PowerPoint 2010",
          "RC8FX-88JRY-3PF7C-X8P67-P4VTT"
        },
        {
          "Office 14, OfficeProjectStd",
          "0",
          "Project 2010 Standard",
          "4HP3K-88W3F-W2K3D-6677X-F9PGB"
        },
        {
          "Office 14, OfficeProjectPro",
          "0",
          "Project 2010 Professional",
          "YGX6F-PGV49-PGW3J-9BTGG-VHKC6"
        },
        {
          "Office 14, OfficePublisher",
          "0",
          "Publisher 2010",
          "BFK7F-9MYHM-V68C7-DRQ66-83YTP"
        },
        {
          "Office 14, OfficeGroove",
          "0",
          "SharePoint Workspace (Groove) 2010",
          "QYYW6-QP4CB-MBV6G-HYMCJ-4T3J4"
        },
        {
          "Office 14, OfficeVisioStd",
          "0",
          "Visio 2010 Standard",
          "767HD-QGMWX-8QTDB-9G3R2-KHFGJ"
        },
        {
          "Office 14, OfficeVisioPro",
          "0",
          "Visio 2010 Professional",
          "7MCW8-VRQVK-G677T-PDJCM-Q8TCP"
        },
        {
          "Office 14, OfficeVisioPrem",
          "0",
          "Visio 2010 Premium",
          "D9DWC-HPYVV-JGF4P-BTWQB-WX8BJ"
        },
        {
          "Office 14, OfficeWord",
          "0",
          "Word 2010",
          "HVHB3-C6FV7-KQX9W-YQG79-CRY7T"
        },
        {
          "Office 15, OfficeStandard",
          "1",
          "Office 2013 Standard",
          "KBKQT-2NMXY-JJWGP-M62JB-92CD4"
        },
        {
          "Office 15, OfficeProPlus",
          "1",
          "Office 2013 Professional Plus",
          "YC7DK-G2NP3-2QQC3-J6H88-GVGXT"
        },
        {
          "Office 15, OfficeAccess",
          "1",
          "Access 2013",
          "NG2JY-H4JBT-HQXYP-78QH9-4JM2D"
        },
        {
          "Office 15, OfficeExcel",
          "1",
          "Excel 2013",
          "VGPNG-Y7HQW-9RHP7-TKPV3-BG7GB"
        },
        {
          "Office 15, OfficeInfoPath",
          "1",
          "InfoPath 2013",
          "DKT8B-N7VXH-D963P-Q4PHY-F8894"
        },
        {
          "Office 15, OfficeLync",
          "1",
          "Lync 2013",
          "2MG3G-3BNTT-3MFW9-KDQW3-TCK7R"
        },
        {
          "Office 15, OfficeOneNote",
          "1",
          "OneNote 2013",
          "TGN6P-8MMBC-37P2F-XHXXK-P34VW"
        },
        {
          "Office 15, OfficeOutlook",
          "1",
          "Outlook 2013",
          "QPN8Q-BJBTJ-334K3-93TGY-2PMBT"
        },
        {
          "Office 15, OfficePowerPoint",
          "1",
          "PowerPoint 2013",
          "4NT99-8RJFH-Q2VDH-KYG2C-4RD4F"
        },
        {
          "Office 15, OfficeProjectStd",
          "1",
          "Project 2013 Standard",
          "6NTH3-CW976-3G3Y2-JK3TX-8QHTT"
        },
        {
          "Office 15, OfficeProjectPro",
          "1",
          "Project 2013 Professional",
          "FN8TT-7WMH6-2D4X9-M337T-2342K"
        },
        {
          "Office 15, OfficePublisher",
          "1",
          "Publisher 2013",
          "PN2WF-29XG2-T9HJ7-JQPJR-FCXK4"
        },
        {
          "Office 15, OfficeVisioStd",
          "1",
          "Visio 2013 Standard",
          "J484Y-4NKBF-W2HMG-DBMJC-PGWR7"
        },
        {
          "Office 15, OfficeVisioPro",
          "1",
          "Visio 2013 Professional",
          "C2FG9-N6J68-H8BTJ-BW3QX-RM3B3"
        },
        {
          "Office 15, OfficeWord",
          "1",
          "Word 2013",
          "6Q7VD-NX8JD-WJ2VH-88V73-4GBJ7"
        },
        {
          "Office 16, Office16Standard",
          "1",
          "Office 2016 Standard",
          "JNRGM-WHDWX-FJJG3-K47QV-DRTFM"
        },
        {
          "Office 16, Office16ProjectStd",
          "1",
          "Office 2016 Project Standard",
          "GNFHQ-F6YQM-KQDGJ-327XX-KQBVC"
        },
        {
          "Office 16, Office16VisioStd",
          "1",
          "Office 2016 Visio Standard",
          "7WHWN-4T7MP-G96JF-G33KR-W8GF4"
        },
        {
          "Office 16, Office16ProPlus",
          "1",
          "Office 2016 Professional Plus",
          "XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99"
        },
        {
          "Office 16, Office16ProjectPro",
          "1",
          "Office 2016 Project Professional",
          "YG9NW-3K39V-2T3HJ-93F3Q-G83KT"
        },
        {
          "Office 16, Office16VisioPro",
          "1",
          "Office 2016 Visio Professional",
          "PD3PC-RHNGV-FXJ29-8JK7D-RJRJK"
        },
        {
          "Office 16, Office16Word",
          "1",
          "Office 2016 Word",
          "WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6"
        },
        {
          "Office 16, Office16Excel",
          "1",
          "Office 2016 Excel",
          "9C2PK-NWTVB-JMPW8-BFT28-7FTBF"
        },
        {
          "Office 16, Office16Access",
          "1",
          "Office 2016 Access",
          "GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW"
        },
        {
          "Office 16, Office16OneNote",
          "1",
          "Office 2016 OneNote",
          "DR92N-9HTF2-97XKM-XW2WJ-XW3J6"
        },
        {
          "Office 16, Office16Outlook",
          "1",
          "Office 2016 Outlook",
          "R69KK-NTPKF-7M3Q4-QYBHW-6MT9B"
        },
        {
          "Office 16, Office16PowerPoint",
          "1",
          "Office 2016 PowerPoint",
          "J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6"
        },
        {
          "Office 16, Office16Publisher",
          "1",
          "Office 2016 Publisher",
          "F47MM-N3XJP-TQXJ9-BP99D-8K837"
        }
      };
      string[,] strArray2 = new string[2, 2]
      {
        {
          "MAK edition",
          "KMS_Client edition"
        },
        {
          "VL_MAK edition",
          "VL_KMS_Client edition"
        }
      };
      int num = 0;
      WmIfunctions._targetName = "";
      WmIfunctions._targetGvlk = "";
      int upperBound1 = strArray1.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        if (Strings.InStr(productName, strArray1[index1, 0], CompareMethod.Text) > 0)
        {
          WmIfunctions._targetName = strArray1[index1, 2];
          int integer = Conversions.ToInteger(strArray1[index1, 1]);
          int upperBound2 = strArray2.GetUpperBound(1);
          int index2 = 0;
          while (index2 <= upperBound2)
          {
            if (Strings.InStr(productName, strArray2[integer, index2], CompareMethod.Text) <= 0)
            {
              checked { ++index2; }
            }
            else
            {
              WmIfunctions._targetGvlk = strArray1[index1, 3];
              num = 1;
              goto label_9;
            }
          }
        }
        checked { ++index1; }
      }
label_9:
      return num;
    }

    private static string GetLicenseReason(int licReason)
    {
      string str1 = Lang.LMsgErrorHeader + "0x" + Strings.LCase(Conversion.Hex(licReason)) + " ";
      string str2;
      switch (licReason)
      {
        case -1073434368:
          str2 = str1 + Lang.LMsgErrorC004B100;
          break;
        case -1073430527:
          str2 = str1 + Lang.LMsgErrorC004C001;
          break;
        case -1073430525:
          str2 = str1 + Lang.LMsgErrorC004C003;
          break;
        case -1073430520:
          str2 = str1 + Lang.LMsgErrorC004C008;
          break;
        case -1073430505:
          str2 = str1 + Lang.LMsgErrorC004C017;
          break;
        case -1073430496:
          str2 = str1 + Lang.LMsgErrorC004C020;
          break;
        case -1073430495:
          str2 = str1 + Lang.LMsgErrorC004C021;
          break;
        case -1073418231:
          str2 = str1 + Lang.LMsgErrorC004F009;
          break;
        case -1073418225:
          str2 = str1 + Lang.LMsgErrorC004F00F;
          break;
        case -1073418220:
          str2 = str1 + Lang.LMsgErrorC004F014;
          break;
        case -1073418196:
          str2 = str1 + Lang.LMsgErrorC004F02C;
          break;
        case -1073418187:
          str2 = str1 + Lang.LMsgErrorC004F035;
          break;
        case -1073418184:
          str2 = str1 + Lang.LMsgErrorC004F038;
          break;
        case -1073418183:
          str2 = str1 + Lang.LMsgErrorC004F039;
          break;
        case -1073418175:
          str2 = str1 + Lang.LMsgErrorC004F041;
          break;
        case -1073418174:
          str2 = str1 + Lang.LMsgErrorC004F042;
          break;
        case -1073418160:
          str2 = str1 + Lang.LMsgErrorC004F050;
          break;
        case -1073418159:
          str2 = str1 + Lang.LMsgErrorC004F051;
          break;
        case -1073418140:
          str2 = str1 + Lang.LMsgErrorC004F064;
          break;
        case -1073418139:
          str2 = str1 + Lang.LMsgErrorC004F065;
          break;
        case -1073418138:
          str2 = str1 + Lang.LMsgErrorC004F066;
          break;
        case -1073418133:
          str2 = str1 + Lang.LMsgErrorC004F06B;
          break;
        case -1073418124:
          str2 = str1 + Lang.LMsgErrorC004F074;
          break;
        case -1073418123:
          str2 = str1 + Lang.LMsgErrorC004F075;
          break;
        case -1073417728:
          str2 = str1 + Lang.LMsgErrorC004F200;
          break;
        case -1073417468:
          str2 = str1 + Lang.LMsgErrorC004F304;
          break;
        case -1073417467:
          str2 = str1 + Lang.LMsgErrorC004F305;
          break;
        case -1073417462:
          str2 = str1 + Lang.LMsgErrorC004F30A;
          break;
        case -1073417459:
          str2 = str1 + Lang.LMsgErrorC004F30D;
          break;
        case -1073417458:
          str2 = str1 + Lang.LMsgErrorC004F30E;
          break;
        case -1073417457:
          str2 = str1 + Lang.LMsgErrorC004F30F;
          break;
        case -1073417456:
          str2 = str1 + Lang.LMsgErrorC004F310;
          break;
        case -1073417455:
          str2 = str1 + Lang.LMsgErrorC004F311;
          break;
        case -1073417454:
          str2 = str1 + Lang.LMsgErrorC004F312;
          break;
        default:
          str2 = Conversions.ToString(Operators.ConcatenateObject((object) str1, Lang.LMsgErrorUndefined));
          break;
      }
      return str2;
    }

    private static object FormatInterval(uint inInterval)
    {
      uint num1 = inInterval;
      string str1 = Conversions.ToString(num1 / 1440U);
      string str2 = Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? str1 + " d " : str1 + " дн ";
      uint num2 = num1 % 1440U;
      uint num3 = num2 / 60U;
      string str3 = str2 + Conversions.ToString(num3);
      string str4 = (Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? str3 + " h " : str3 + " час ") + Conversions.ToString(num2 % 60U);
      return Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? (object) (str4 + " min") : (object) (str4 + " мин");
    }

    private static object FormatIntervalDays(uint inInterval)
    {
      object Left1 = (object) inInterval;
      object Right1 = Operators.IntDivideObject(Left1, (object) 1440);
      object Left2 = Strings.Len(RuntimeHelpers.GetObjectValue(Right1)) != 1 ? (Strings.Len(RuntimeHelpers.GetObjectValue(Right1)) != 2 ? RuntimeHelpers.GetObjectValue(Right1) : Operators.ConcatenateObject((object) "  ", Right1)) : Operators.ConcatenateObject((object) "    ", Right1);
      object Left3 = Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? Operators.ConcatenateObject(Left2, (object) " d ") : Operators.ConcatenateObject(Left2, (object) " дн ");
      object Left4 = Operators.ModObject(Left1, (object) 1440);
      object Right2 = Operators.IntDivideObject(Left4, (object) 60);
      object Left5 = Strings.Len(RuntimeHelpers.GetObjectValue(Right2)) != 1 ? Operators.ConcatenateObject(Left3, Right2) : Operators.ConcatenateObject(Operators.ConcatenateObject(Left3, (object) "0"), Right2);
      object Left6 = Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? Operators.ConcatenateObject(Left5, (object) " h ") : Operators.ConcatenateObject(Left5, (object) " час ");
      object Right3 = Operators.ModObject(Left4, (object) 60);
      object Left7 = Strings.Len(RuntimeHelpers.GetObjectValue(Right3)) != 1 ? Operators.ConcatenateObject(Left6, Right3) : Operators.ConcatenateObject(Operators.ConcatenateObject(Left6, (object) "0"), Right3);
      return RuntimeHelpers.GetObjectValue(Operators.CompareString(MyProject.Forms.Form1.TargetLang, "RU", false) != 0 ? Operators.ConcatenateObject(Left7, (object) " min") : Operators.ConcatenateObject(Left7, (object) " мин"));
    }

    private static void AddLineToProtocol(string addedLine)
    {
      MyProject.Forms.Form1.MyPrintLine(addedLine);
      WmIfunctions.WmiaProtocol = (string[]) Utils.CopyArray((Array) WmIfunctions.WmiaProtocol, (Array) new string[checked (WmIfunctions.WmiaProtocolLineCount + 1 + 1)]);
      WmIfunctions.WmiaProtocol[WmIfunctions.WmiaProtocolLineCount] = addedLine;
      checked { ++WmIfunctions.WmiaProtocolLineCount; }
    }

    public static void SetCumulativeCount(bool cumulativeFlag = false)
    {
      WmIfunctions.OfficeOperationCounters.Successful = 0;
      WmIfunctions.OfficeOperationCounters.Failed = 0;
      WmIfunctions.OfficeOperationCounters.Skipped = 0;
      WmIfunctions.WindowsOperationCounters.Successful = 0;
      WmIfunctions.WindowsOperationCounters.Failed = 0;
      WmIfunctions.WindowsOperationCounters.Skipped = 0;
      WmIfunctions._cumulativeCounter = cumulativeFlag;
    }

    private static void ClearCounters()
    {
      if (WmIfunctions._cumulativeCounter)
        return;
      WmIfunctions.OfficeOperationCounters.Successful = 0;
      WmIfunctions.OfficeOperationCounters.Failed = 0;
      WmIfunctions.OfficeOperationCounters.Skipped = 0;
      WmIfunctions.WindowsOperationCounters.Successful = 0;
      WmIfunctions.WindowsOperationCounters.Failed = 0;
      WmIfunctions.WindowsOperationCounters.Skipped = 0;
    }

    public struct Counters
    {
      public int Successful;
      public int Failed;
      public int Skipped;
    }
  }
}
