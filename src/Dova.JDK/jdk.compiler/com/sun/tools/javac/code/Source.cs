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

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public final")]
public partial class Source
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Source()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/code/Source;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK1_2", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK1_3", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK1_4", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK5", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK6", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK7", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK8", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK9", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK10", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK11", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK12", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK13", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK14", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK15", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK16", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK17", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK18", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sourceKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "tab", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Source;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Source", "(Ljava/lang/String;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/code/Source;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lookup", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/Source;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/code/Source;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "requiredTarget", "()Lcom/sun/tools/javac/jvm/Target;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toSourceVersion", "(Lcom/sun/tools/javac/code/Source;)Ljavax/lang/model/SourceVersion;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK1_2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK1_3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK1_4_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK6_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK8_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK9_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK10_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK11_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK12_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK13_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK14_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK15_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK16_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK17_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source JDK18_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key sourceKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map tab_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source MIN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source MAX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Source DEFAULT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Source;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source> VALUES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Source(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
	public Source(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Source;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source> values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Source valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Source lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/Source;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Source instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source> _values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/jvm/Target;", "public")]
	public Dova.JDK.com.sun.tools.javac.jvm.Target requiredTarget()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Target>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Source;)Ljavax/lang/model/SourceVersion;", "public static")]
	public static Dova.JDK.javax.lang.model.SourceVersion toSourceVersion(Dova.JDK.com.sun.tools.javac.code.Source arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
	public partial class Feature
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Feature()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/code/Source$Feature;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIAMOND", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODULES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EFFECTIVELY_FINAL_VARIABLES_IN_TRY_WITH_RESOURCES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEPRECATION_ON_IMPORT", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "POLY", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LAMBDA", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_REFERENCES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_METHODS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "STATIC_INTERFACE_METHODS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "STATIC_INTERFACE_METHODS_INVOKE", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "STRICT_METHOD_CLASH_CHECK", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EFFECTIVELY_FINAL_IN_INNER_CLASSES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_ANNOTATIONS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ANNOTATIONS_AFTER_TYPE_PARAMS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REPEATED_ANNOTATIONS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INTERSECTION_TYPES_IN_CAST", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GRAPH_INFERENCE", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FUNCTIONAL_INTERFACE_MOST_SPECIFIC", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "POST_APPLICABILITY_VARARGS_ACCESS_CHECK", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAP_CAPTURES_TO_BOUNDS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_SAFE_VARARGS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIAMOND_WITH_ANONYMOUS_CLASS_CREATION", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNDERSCORE_IDENTIFIER", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_INTERFACE_METHODS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOCAL_VARIABLE_TYPE_INFERENCE", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VAR_SYNTAX_IMPLICIT_LAMBDAS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IMPORT_ON_DEMAND_OBSERVABLE_PACKAGES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SWITCH_MULTIPLE_CASE_LABELS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SWITCH_RULE", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SWITCH_EXPRESSION", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TEXT_BLOCKS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PATTERN_MATCHING_IN_INSTANCEOF", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REIFIABLE_TYPES_INSTANCEOF", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RECORDS", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SEALED_CLASSES", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CASE_NULL", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PATTERN_SWITCH", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REDUNDANT_STRICTFP", "Lcom/sun/tools/javac/code/Source$Feature;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "minLevel", "Lcom/sun/tools/javac/code/Source;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "maxLevel", "Lcom/sun/tools/javac/code/Source;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "optFragment", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "optKind", "Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Source$Feature;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Feature", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/Source;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Feature", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Source$Feature$DiagKind;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Feature", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Feature", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Source$Feature$DiagKind;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/code/Source$Feature;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source$Feature;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "error", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fragment", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/code/Source$Feature;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "allowedInSource", "(Lcom/sun/tools/javac/code/Source;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isPlural", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nameFragment", "()Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature DIAMOND_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature MODULES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature EFFECTIVELY_FINAL_VARIABLES_IN_TRY_WITH_RESOURCES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature DEPRECATION_ON_IMPORT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature POLY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature LAMBDA_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature METHOD_REFERENCES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature DEFAULT_METHODS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature STATIC_INTERFACE_METHODS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature STATIC_INTERFACE_METHODS_INVOKE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature STRICT_METHOD_CLASH_CHECK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature EFFECTIVELY_FINAL_IN_INNER_CLASSES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature TYPE_ANNOTATIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature ANNOTATIONS_AFTER_TYPE_PARAMS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature REPEATED_ANNOTATIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature INTERSECTION_TYPES_IN_CAST_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature GRAPH_INFERENCE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature FUNCTIONAL_INTERFACE_MOST_SPECIFIC_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature POST_APPLICABILITY_VARARGS_ACCESS_CHECK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature MAP_CAPTURES_TO_BOUNDS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature PRIVATE_SAFE_VARARGS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature DIAMOND_WITH_ANONYMOUS_CLASS_CREATION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature UNDERSCORE_IDENTIFIER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature PRIVATE_INTERFACE_METHODS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature LOCAL_VARIABLE_TYPE_INFERENCE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature VAR_SYNTAX_IMPLICIT_LAMBDAS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature IMPORT_ON_DEMAND_OBSERVABLE_PACKAGES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature SWITCH_MULTIPLE_CASE_LABELS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature SWITCH_RULE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature SWITCH_EXPRESSION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature TEXT_BLOCKS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature PATTERN_MATCHING_IN_INSTANCEOF_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature REIFIABLE_TYPES_INSTANCEOF_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature RECORDS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature SEALED_CLASSES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature CASE_NULL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature PATTERN_SWITCH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature REDUNDANT_STRICTFP_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Source minLevel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Source maxLevel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "private final")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment optFragment_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind optKind_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Source$Feature;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Feature(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/Source;)V", "private")]
		public Feature(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Source arg2, Dova.JDK.com.sun.tools.javac.code.Source arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Source$Feature$DiagKind;)V", "private")]
		public Feature(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Source arg2, Dova.JDK.com.sun.tools.javac.code.Source arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;)V", "private")]
		public Feature(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Source arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Source$Feature$DiagKind;)V", "private")]
		public Feature(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Source arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Source$Feature;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source$Feature;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source$Feature;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Source.Feature valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error error(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment fragment(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source$Feature;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Source;)Z", "public")]
		public bool allowedInSource(Dova.JDK.com.sun.tools.javac.code.Source arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPlural()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment nameFragment()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "static final")]
		public partial class DiagKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DiagKind()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/code/Source$Feature$DiagKind;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NORMAL", "Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PLURAL", "Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DiagKind", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind NORMAL_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind PLURAL_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind> VALUES_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DiagKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public DiagKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Source$Feature$DiagKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind> values()
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Source$Feature$DiagKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind> _values()
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Source.Feature.DiagKind>>(ret);
			}
		}
	}
}
