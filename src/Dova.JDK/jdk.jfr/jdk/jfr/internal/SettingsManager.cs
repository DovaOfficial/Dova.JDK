/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/SettingsManager;", "final")]
public partial class SettingsManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SettingsManager()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/SettingsManager;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "availableSettings", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SettingsManager", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEnabled", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSettings", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createSettingsMap", "(Ljava/util/List;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEventControl", "(Ljdk/jfr/internal/EventControl;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateRetransform", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeInternalSettings", "(Ljava/util/Map;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInternalSetting", "(Ljdk/jfr/internal/EventControl;)Ljdk/jfr/internal/SettingsManager$InternalSetting;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map availableSettings_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SettingsManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SettingsManager() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SettingsManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isEnabled(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "")]
	public void setSettings(Dova.JDK.java.util.List arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map createSettingsMap(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/EventControl;)V", "")]
	public void setEventControl(Dova.JDK.jdk.jfr.@internal.EventControl arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public void updateRetransform(Dova.JDK.java.util.List arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection makeInternalSettings(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/EventControl;)Ljdk/jfr/internal/SettingsManager$InternalSetting;", "private")]
	public Dova.JDK.jdk.jfr.@internal.SettingsManager.InternalSetting getInternalSetting(Dova.JDK.jdk.jfr.@internal.EventControl arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SettingsManager.InternalSetting>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SettingsManager$InternalSetting;", "private static")]
	public partial class InternalSetting
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalSetting()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/SettingsManager$InternalSetting;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "identifier", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "enabledMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "allMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "enabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InternalSetting", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljdk/jfr/internal/SettingsManager$InternalSetting;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "finish", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEnabled", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSettingsId", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addToMap", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getValues", "(Ljava/lang/String;)Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String identifier_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map enabledMap_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map allMap_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool enabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalSetting(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public InternalSetting(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SettingsManager$InternalSetting;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/SettingsManager$InternalSetting;)V", "public")]
		public void add(Dova.JDK.jdk.jfr.@internal.SettingsManager.InternalSetting arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public void add(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void finish()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEnabled()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSettingsId()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", "private")]
		public void addToMap(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set getValues(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}
}