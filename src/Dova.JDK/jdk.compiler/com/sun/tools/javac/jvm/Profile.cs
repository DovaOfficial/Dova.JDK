/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.jvm;

[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Profile;", "public")]
public partial class Profile
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Profile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/Profile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT1", "Lcom/sun/tools/javac/jvm/Profile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT2", "Lcom/sun/tools/javac/jvm/Profile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT3", "Lcom/sun/tools/javac/jvm/Profile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lcom/sun/tools/javac/jvm/Profile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "profileKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targets", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/jvm/Profile;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ILcom/sun/tools/javac/jvm/Target;[Lcom/sun/tools/javac/jvm/Target;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(I)Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/jvm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "(Lcom/sun/tools/javac/jvm/Target;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Profile;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile COMPACT1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Profile;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile COMPACT2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Profile;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile COMPACT3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Profile;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key profileKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "final")]
	public Dova.JDK.java.util.Set targets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/javac/jvm/Profile;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Profile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public Profile(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ILcom/sun/tools/javac/jvm/Target;[Lcom/sun/tools/javac/jvm/Target;)V", "private transient")]
	public Profile(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, Dova.JDK.com.sun.tools.javac.jvm.Target arg4, JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Target> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/Profile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/jvm/Profile;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/Profile;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/jvm/Profile;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile lookup(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/Profile;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/jvm/Profile;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.jvm.Profile instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Profile>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/jvm/Profile;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.jvm.Profile>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Target;)Z", "public")]
	public bool isValid(Dova.JDK.com.sun.tools.javac.jvm.Target arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}
}
