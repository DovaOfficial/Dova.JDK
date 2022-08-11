/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.lang.instrument;

[JniSignatureAttribute("Ljava/lang/instrument/Instrumentation;", "public abstract interface")]
public partial interface Instrumentation
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Instrumentation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/instrument/Instrumentation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTransformer", "(Ljava/lang/instrument/ClassFileTransformer;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTransformer", "(Ljava/lang/instrument/ClassFileTransformer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTransformer", "(Ljava/lang/instrument/ClassFileTransformer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNativeMethodPrefix", "(Ljava/lang/instrument/ClassFileTransformer;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRetransformClassesSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRedefineClassesSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNativeMethodPrefixSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModifiableModule", "(Ljava/lang/Module;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModifiableClass", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retransformClasses", "([Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefineClasses", "([Ljava/lang/instrument/ClassDefinition;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllLoadedClasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitiatedClasses", "(Ljava/lang/ClassLoader;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectSize", "(Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToBootstrapClassLoaderSearch", "(Ljava/util/jar/JarFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToSystemClassLoaderSearch", "(Ljava/util/jar/JarFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefineModule", "(Ljava/lang/Module;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/ClassFileTransformer;Z)V", "public abstract")]
	void addTransformer(Dova.JDK.java.lang.instrument.ClassFileTransformer arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/ClassFileTransformer;)V", "public abstract")]
	void addTransformer(Dova.JDK.java.lang.instrument.ClassFileTransformer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/ClassFileTransformer;)Z", "public abstract")]
	bool removeTransformer(Dova.JDK.java.lang.instrument.ClassFileTransformer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/ClassFileTransformer;Ljava/lang/String;)V", "public abstract")]
	void setNativeMethodPrefix(Dova.JDK.java.lang.instrument.ClassFileTransformer arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isRetransformClassesSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isRedefineClassesSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isNativeMethodPrefixSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Module;)Z", "public abstract")]
	bool isModifiableModule(Dova.JDK.java.lang.Module arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isModifiableClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)V", "public abstract transient")]
	void retransformClasses(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/instrument/ClassDefinition;)V", "public abstract transient")]
	void redefineClasses(JavaArray<Dova.JDK.java.lang.instrument.ClassDefinition> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Class> getAllLoadedClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)[Ljava/lang/Class;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Class> getInitiatedClasses(Dova.JDK.java.lang.ClassLoader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)J", "public abstract")]
	long getObjectSize(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public abstract")]
	void appendToBootstrapClassLoaderSearch(Dova.JDK.java.util.jar.JarFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public abstract")]
	void appendToSystemClassLoaderSearch(Dova.JDK.java.util.jar.JarFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Module;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V", "public abstract")]
	void redefineModule(Dova.JDK.java.lang.Module arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.Set arg4, Dova.JDK.java.util.Map arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5);
	}
}
