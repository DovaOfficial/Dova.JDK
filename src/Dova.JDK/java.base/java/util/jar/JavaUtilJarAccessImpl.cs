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
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/jar/JavaUtilJarAccessImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSource", "(Ljava/util/jar/JarFile;Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrustedAttributes", "(Ljava/util/jar/Manifest;Ljava/lang/String;)Ljava/util/jar/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInitializing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureInitialization", "(Ljava/util/jar/JarFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entryNames", "(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entries2", "(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSources", "(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEagerValidation", "(Ljava/util/jar/JarFile;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifestDigests", "(Ljava/util/jar/JarFile;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entryFor", "(Ljava/util/jar/JarFile;Ljava/lang/String;)Ljava/util/jar/JarEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jarFileHasClassPathAttribute", "(Ljava/util/jar/JarFile;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaUtilJarAccessImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public JavaUtilJarAccessImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/jar/JavaUtilJarAccessImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;", "public")]
	public Dova.JDK.java.security.CodeSource getCodeSource(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/Manifest;Ljava/lang/String;)Ljava/util/jar/Attributes;", "public")]
	public Dova.JDK.java.util.jar.Attributes getTrustedAttributes(Dova.JDK.java.util.jar.Manifest arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Attributes>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInitializing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public")]
	public void ensureInitialization(Dova.JDK.java.util.jar.JarFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration entryNames(Dova.JDK.java.util.jar.JarFile arg0, JavaArray<Dova.JDK.java.security.CodeSource> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration entries2(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;", "public")]
	public JavaArray<Dova.JDK.java.security.CodeSource> getCodeSources(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.net.URL arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSource>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Z)V", "public")]
	public void setEagerValidation(Dova.JDK.java.util.jar.JarFile arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getManifestDigests(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/lang/String;)Ljava/util/jar/JarEntry;", "public")]
	public Dova.JDK.java.util.jar.JarEntry entryFor(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Z", "public")]
	public bool jarFileHasClassPathAttribute(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}
}
