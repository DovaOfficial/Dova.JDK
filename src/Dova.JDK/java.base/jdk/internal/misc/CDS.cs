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

namespace Dova.JDK.jdk.@internal.misc;

[JniSignatureAttribute("Ljdk/internal/misc/CDS;", "public")]
public partial class CDS
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CDS()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/misc/CDS;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isDumpingClassList", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isDumpingArchive", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isSharingEnabled", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECT_HOLDER_CLASS_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DELEGATING_HOLDER_CLASS_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BASIC_FORMS_HOLDER_CLASS_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INVOKERS_HOLDER_CLASS_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "excludeFlags", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CDS", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "dumpSharedArchive", "(ZLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "generateLambdaFormHolderClasses", "([Ljava/lang/String;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "initializeFromArchive", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDumpingClassList", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDumpingArchive", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSharingEnabled", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "logLambdaFormInvoker", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isBasicTypeChar", "(C)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isValidHolderName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isValidMethodType", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "validateInputLines", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "dumpClassList", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "containsExcludedFlags", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "drainOutput", "(Ljava/io/InputStream;JLjava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "dumpDynamicArchive", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDumpingClassList0", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDumpingArchive0", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isSharingEnabled0", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineArchivedModules", "(Ljava/lang/ClassLoader;Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getRandomSeedForDumping", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "traceLambdaFormInvoker", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "traceSpeciesType", "(Ljava/lang/String;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool isDumpingClassList_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool isDumpingArchive_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool isSharingEnabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String DIRECT_HOLDER_CLASS_NAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String DELEGATING_HOLDER_CLASS_NAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String BASIC_FORMS_HOLDER_CLASS_NAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String INVOKERS_HOLDER_CLASS_NAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> excludeFlags_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CDS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CDS() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/misc/CDS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ZLjava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String dumpSharedArchive(bool arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)[Ljava/lang/Object;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Object> generateLambdaFormHolderClasses(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public static native")]
	public static void initializeFromArchive(Dova.JDK.java.lang.Class arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDumpingClassList()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDumpingArchive()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isSharingEnabled()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static native")]
	public static void logLambdaFormInvoker(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(C)Z", "private static")]
	public static bool isBasicTypeChar(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isValidHolderName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isValidMethodType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "private static")]
	public static void validateInputLines(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static native")]
	public static void dumpClassList(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool containsExcludedFlags(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;JLjava/lang/String;Ljava/util/List;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String drainOutput(Dova.JDK.java.io.InputStream arg0, long arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static native")]
	public static void dumpDynamicArchive(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Z", "private static native")]
	public static bool isDumpingClassList0()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static native")]
	public static bool isDumpingArchive0()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static native")]
	public static bool isSharingEnabled0()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/ClassLoader;)V", "public static native")]
	public static void defineArchivedModules(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "public static native")]
	public static long getRandomSeedForDumping()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public static")]
	public static void traceLambdaFormInvoker(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public static")]
	public static void traceSpeciesType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
	}
}