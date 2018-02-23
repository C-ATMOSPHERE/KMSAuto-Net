﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.My.MyProject
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KMSAuto_Net.My
{
  [HideModuleName]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  [StandardModule]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public AutoMode m_AutoMode;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public EnterGvlk m_EnterGvlk;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Form1 m_Form1;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public FormHelp m_FormHelp;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public FormKmsHelp m_FormKmsHelp;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public GetHwidKms m_GetHwidKms;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public HookSetting m_HookSetting;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public KmsSetting m_KmsSetting;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public NoAutoSettings m_NoAutoSettings;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public OfficeConvert m_OfficeConvert;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public TapSettings m_TapSettings;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Utilities m_Utilities;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public WinDivertSettings m_WinDivertSettings;

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return Activator.CreateInstance<T>();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          TargetInvocationException invocationException;
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", invocationException.InnerException.Message), invocationException.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }

      public AutoMode AutoMode
      {
        get
        {
          this.m_AutoMode = MyProject.MyForms.Create__Instance__<AutoMode>(this.m_AutoMode);
          return this.m_AutoMode;
        }
        set
        {
          if (value == this.m_AutoMode)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<AutoMode>(ref this.m_AutoMode);
        }
      }

      public EnterGvlk EnterGvlk
      {
        get
        {
          this.m_EnterGvlk = MyProject.MyForms.Create__Instance__<EnterGvlk>(this.m_EnterGvlk);
          return this.m_EnterGvlk;
        }
        set
        {
          if (value == this.m_EnterGvlk)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<EnterGvlk>(ref this.m_EnterGvlk);
        }
      }

      public Form1 Form1
      {
        get
        {
          this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
          return this.m_Form1;
        }
        set
        {
          if (value == this.m_Form1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form1>(ref this.m_Form1);
        }
      }

      public FormHelp FormHelp
      {
        get
        {
          this.m_FormHelp = MyProject.MyForms.Create__Instance__<FormHelp>(this.m_FormHelp);
          return this.m_FormHelp;
        }
        set
        {
          if (value == this.m_FormHelp)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<FormHelp>(ref this.m_FormHelp);
        }
      }

      public FormKmsHelp FormKmsHelp
      {
        get
        {
          this.m_FormKmsHelp = MyProject.MyForms.Create__Instance__<FormKmsHelp>(this.m_FormKmsHelp);
          return this.m_FormKmsHelp;
        }
        set
        {
          if (value == this.m_FormKmsHelp)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<FormKmsHelp>(ref this.m_FormKmsHelp);
        }
      }

      public GetHwidKms GetHwidKms
      {
        get
        {
          this.m_GetHwidKms = MyProject.MyForms.Create__Instance__<GetHwidKms>(this.m_GetHwidKms);
          return this.m_GetHwidKms;
        }
        set
        {
          if (value == this.m_GetHwidKms)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<GetHwidKms>(ref this.m_GetHwidKms);
        }
      }

      public HookSetting HookSetting
      {
        get
        {
          this.m_HookSetting = MyProject.MyForms.Create__Instance__<HookSetting>(this.m_HookSetting);
          return this.m_HookSetting;
        }
        set
        {
          if (value == this.m_HookSetting)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<HookSetting>(ref this.m_HookSetting);
        }
      }

      public KmsSetting KmsSetting
      {
        get
        {
          this.m_KmsSetting = MyProject.MyForms.Create__Instance__<KmsSetting>(this.m_KmsSetting);
          return this.m_KmsSetting;
        }
        set
        {
          if (value == this.m_KmsSetting)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<KmsSetting>(ref this.m_KmsSetting);
        }
      }

      public NoAutoSettings NoAutoSettings
      {
        get
        {
          this.m_NoAutoSettings = MyProject.MyForms.Create__Instance__<NoAutoSettings>(this.m_NoAutoSettings);
          return this.m_NoAutoSettings;
        }
        set
        {
          if (value == this.m_NoAutoSettings)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<NoAutoSettings>(ref this.m_NoAutoSettings);
        }
      }

      public OfficeConvert OfficeConvert
      {
        get
        {
          this.m_OfficeConvert = MyProject.MyForms.Create__Instance__<OfficeConvert>(this.m_OfficeConvert);
          return this.m_OfficeConvert;
        }
        set
        {
          if (value == this.m_OfficeConvert)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<OfficeConvert>(ref this.m_OfficeConvert);
        }
      }

      public TapSettings TapSettings
      {
        get
        {
          this.m_TapSettings = MyProject.MyForms.Create__Instance__<TapSettings>(this.m_TapSettings);
          return this.m_TapSettings;
        }
        set
        {
          if (value == this.m_TapSettings)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<TapSettings>(ref this.m_TapSettings);
        }
      }

      public Utilities Utilities
      {
        get
        {
          this.m_Utilities = MyProject.MyForms.Create__Instance__<Utilities>(this.m_Utilities);
          return this.m_Utilities;
        }
        set
        {
          if (value == this.m_Utilities)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Utilities>(ref this.m_Utilities);
        }
      }

      public WinDivertSettings WinDivertSettings
      {
        get
        {
          this.m_WinDivertSettings = MyProject.MyForms.Create__Instance__<WinDivertSettings>(this.m_WinDivertSettings);
          return this.m_WinDivertSettings;
        }
        set
        {
          if (value == this.m_WinDivertSettings)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<WinDivertSettings>(ref this.m_WinDivertSettings);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        return (object) instance != null ? instance : Activator.CreateInstance<T>();
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
