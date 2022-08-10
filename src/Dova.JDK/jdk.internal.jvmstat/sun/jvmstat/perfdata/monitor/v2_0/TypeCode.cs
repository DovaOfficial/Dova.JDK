/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public")]
public partial class TypeCode
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeCode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "value", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BOOLEAN", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHAR", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FLOAT", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DOUBLE", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BYTE", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SHORT", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INT", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LONG", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OBJECT", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARRAY", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VOID", "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "basicTypes", "[Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeCode", "(Ljava/lang/String;C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toChar", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toTypeCode", "(C)Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toTypeCode", "(B)Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("C", "private final")]
	public char value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode INT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static final")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "private static")]
	public static JavaArray<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode> basicTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeCode(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;C)V", "private")]
	public TypeCode(Dova.JDK.java.lang.String arg0, char arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int toChar()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(C)Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode toTypeCode(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
	}

	[JniSignatureAttribute("(B)Lsun/jvmstat/perfdata/monitor/v2_0/TypeCode;", "public static")]
	public static Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode toTypeCode(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.jvmstat.perfdata.monitor.v2_0.TypeCode>(ret);
	}
}
