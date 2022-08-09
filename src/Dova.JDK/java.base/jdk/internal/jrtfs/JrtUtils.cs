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

namespace Dova.JDK.jdk.@internal.jrtfs;

[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtUtils;", "final")]
public partial class JrtUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JrtUtils()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/jrtfs/JrtUtils;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "regexMetaChars", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "globMetaChars", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EOL", "C"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JrtUtils", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "next", "(Ljava/lang/String;I)C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "toRegexPattern", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isGlobMeta", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isRegexMeta", "(C)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String regexMetaChars_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String globMetaChars_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char EOL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JrtUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public JrtUtils() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;I)C", "private static")]
	public static char next(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toRegexPattern(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(C)Z", "private static")]
	public static bool isGlobMeta(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "private static")]
	public static bool isRegexMeta(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}
}