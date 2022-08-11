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

namespace Dova.JDK.sun.net.www.protocol.jar;

[JniSignatureAttribute("Lsun/net/www/protocol/jar/JarFileFactory;", "")]
public partial class JarFileFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.net.www.protocol.jar.URLJarFile.URLJarFileCloseController
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JarFileFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/jar/JarFileFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fileCache", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "urlCache", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/net/www/protocol/jar/JarFileFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/net/URL;Z)Ljava/util/jar/JarFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/net/URL;)Ljava/util/jar/JarFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lsun/net/www/protocol/jar/JarFileFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "(Ljava/util/jar/JarFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermission", "(Ljava/util/jar/JarFile;)Ljava/security/Permission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCachedJarFile", "(Ljava/net/URL;)Ljava/util/jar/JarFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "urlKey", "(Ljava/net/URL;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnection", "(Ljava/util/jar/JarFile;)Ljava/net/URLConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreate", "(Ljava/net/URL;Z)Ljava/util/jar/JarFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeIfNotCached", "(Ljava/net/URL;Ljava/util/jar/JarFile;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheIfAbsent", "(Ljava/net/URL;Ljava/util/jar/JarFile;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap fileCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap urlCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/net/www/protocol/jar/JarFileFactory;", "private static final")]
	public static Dova.JDK.sun.net.www.protocol.jar.JarFileFactory instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.jar.JarFileFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JarFileFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public JarFileFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/jar/JarFileFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/URL;Z)Ljava/util/jar/JarFile;", "")]
	public Dova.JDK.java.util.jar.JarFile get(Dova.JDK.java.net.URL arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/util/jar/JarFile;", "public")]
	public Dova.JDK.java.util.jar.JarFile get(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/www/protocol/jar/JarFileFactory;", "public static")]
	public static Dova.JDK.sun.net.www.protocol.jar.JarFileFactory getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.jar.JarFileFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public")]
	public void close(Dova.JDK.java.util.jar.JarFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/security/Permission;", "private")]
	public Dova.JDK.java.security.Permission getPermission(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Permission>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/util/jar/JarFile;", "private")]
	public Dova.JDK.java.util.jar.JarFile getCachedJarFile(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String urlKey(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/net/URLConnection;", "")]
	public Dova.JDK.java.net.URLConnection getConnection(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Z)Ljava/util/jar/JarFile;", "")]
	public Dova.JDK.java.util.jar.JarFile getOrCreate(Dova.JDK.java.net.URL arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/util/jar/JarFile;)Z", "")]
	public bool closeIfNotCached(Dova.JDK.java.net.URL arg0, Dova.JDK.java.util.jar.JarFile arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/util/jar/JarFile;)Z", "")]
	public bool cacheIfAbsent(Dova.JDK.java.net.URL arg0, Dova.JDK.java.util.jar.JarFile arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}
}
