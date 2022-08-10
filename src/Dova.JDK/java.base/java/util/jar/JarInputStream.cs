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

namespace Dova.JDK.java.util.jar;

[JniSignatureAttribute("Ljava/util/jar/JarInputStream;", "public")]
public partial class JarInputStream
	: Dova.JDK.java.util.zip.ZipInputStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JarInputStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/jar/JarInputStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "man", "Ljava/util/jar/Manifest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "first", "Ljava/util/jar/JarEntry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "jv", "Ljava/util/jar/JarVerifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mev", "Lsun/security/util/ManifestEntryVerifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "doVerify", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tryManifest", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "JarInputStream", "(Ljava/io/InputStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "JarInputStream", "(Ljava/io/InputStream;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "read", "([BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkManifest", "(Ljava/util/jar/JarEntry;)Ljava/util/jar/JarEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextJarEntry", "()Ljava/util/jar/JarEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextEntry", "()Ljava/util/zip/ZipEntry;"));
	}

	[JniSignatureAttribute("Ljava/util/jar/Manifest;", "private")]
	public Dova.JDK.java.util.jar.Manifest man_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/jar/JarEntry;", "private")]
	public Dova.JDK.java.util.jar.JarEntry first_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/jar/JarVerifier;", "private")]
	public Dova.JDK.java.util.jar.JarVerifier jv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarVerifier>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/ManifestEntryVerifier;", "private")]
	public Dova.JDK.sun.security.util.ManifestEntryVerifier mev_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ManifestEntryVerifier>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool doVerify_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool tryManifest_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JarInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public JarInputStream(Dova.JDK.java.io.InputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Z)V", "public")]
	public JarInputStream(Dova.JDK.java.io.InputStream arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/jar/JarInputStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BII)I", "public")]
	public int read(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
	public Dova.JDK.java.util.jar.Manifest getManifest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarEntry;)Ljava/util/jar/JarEntry;", "private")]
	public Dova.JDK.java.util.jar.JarEntry checkManifest(Dova.JDK.java.util.jar.JarEntry arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/jar/JarEntry;", "public")]
	public Dova.JDK.java.util.jar.JarEntry getNextJarEntry()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", "protected")]
	public Dova.JDK.java.util.zip.ZipEntry createZipEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipEntry>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/zip/ZipEntry;", "public")]
	public Dova.JDK.java.util.zip.ZipEntry getNextEntry()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipEntry>(ret);
	}
}
