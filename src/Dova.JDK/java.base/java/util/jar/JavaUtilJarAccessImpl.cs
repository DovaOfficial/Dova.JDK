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

namespace Dova.JDK.java.util.jar;

[JniSignatureAttribute("Ljava/util/jar/JavaUtilJarAccessImpl;", "")]
public partial class JavaUtilJarAccessImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.access.JavaUtilJarAccess
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaUtilJarAccessImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/jar/JavaUtilJarAccessImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JavaUtilJarAccessImpl", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCodeSource", "(Ljava/util/jar/JarFile;Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTrustedAttributes", "(Ljava/util/jar/Manifest;Ljava/lang/String;)Ljava/util/jar/Attributes;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isInitializing", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ensureInitialization", "(Ljava/util/jar/JarFile;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "entryNames", "(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "entries2", "(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCodeSources", "(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEagerValidation", "(Ljava/util/jar/JarFile;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getManifestDigests", "(Ljava/util/jar/JarFile;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "entryFor", "(Ljava/util/jar/JarFile;Ljava/lang/String;)Ljava/util/jar/JarEntry;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "jarFileHasClassPathAttribute", "(Ljava/util/jar/JarFile;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaUtilJarAccessImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public JavaUtilJarAccessImpl() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/jar/JavaUtilJarAccessImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;", "public")]
	public Dova.JDK.java.security.CodeSource getCodeSource(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/Manifest;Ljava/lang/String;)Ljava/util/jar/Attributes;", "public")]
	public Dova.JDK.java.util.jar.Attributes getTrustedAttributes(Dova.JDK.java.util.jar.Manifest arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Attributes>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInitializing()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public")]
	public void ensureInitialization(Dova.JDK.java.util.jar.JarFile arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration entryNames(Dova.JDK.java.util.jar.JarFile arg0, JavaArray<Dova.JDK.java.security.CodeSource> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration entries2(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;", "public")]
	public JavaArray<Dova.JDK.java.security.CodeSource> getCodeSources(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.net.URL arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSource>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Z)V", "public")]
	public void setEagerValidation(Dova.JDK.java.util.jar.JarFile arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getManifestDigests(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/lang/String;)Ljava/util/jar/JarEntry;", "public")]
	public Dova.JDK.java.util.jar.JarEntry entryFor(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Z", "public")]
	public bool jarFileHasClassPathAttribute(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}
}
