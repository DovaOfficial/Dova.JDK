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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/FactoryURLClassLoader;", "final")]
public partial class FactoryURLClassLoader
	: Dova.JDK.java.net.URLClassLoader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FactoryURLClassLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/FactoryURLClassLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/security/AccessControlContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/net/URL;Ljava/security/AccessControlContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FactoryURLClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/security/AccessControlContext;)V", "")]
	public FactoryURLClassLoader(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.net.URL> arg1, Dova.JDK.java.lang.ClassLoader arg2, Dova.JDK.java.security.AccessControlContext arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([Ljava/net/URL;Ljava/security/AccessControlContext;)V", "")]
	public FactoryURLClassLoader(JavaArray<Dova.JDK.java.net.URL> arg0, Dova.JDK.java.security.AccessControlContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/FactoryURLClassLoader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "public final")]
	public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}
}
