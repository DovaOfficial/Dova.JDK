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

[JniSignatureAttribute("Ljava/util/jar/JarVerifier;", "")]
public partial class JarVerifier
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JarVerifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/jar/JarVerifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verifiedSigners", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sigFileSigners", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sigFileData", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingBlocks", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signerCache", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parsingBlockOrSF", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parsingMeta", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anyToVerify", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baos", "Ljava/io/ByteArrayOutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manDig", "Lsun/security/util/ManifestDigester;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifestRawBytes", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifestName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eagerValidation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "csdomain", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifestDigests", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signersToAlgs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "urlToCodeSourceMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signerToCodeSource", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastURL", "Ljava/net/URL;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastURLMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "emptySigner", "[Ljava/security/CodeSigner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signerMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jarCodeSigners", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(ILsun/security/util/ManifestEntryVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(I[BIILsun/security/util/ManifestEntryVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSource", "(Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSource", "(Ljava/net/URL;Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSigners", "(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)[Ljava/security/CodeSigner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSigners", "(Ljava/lang/String;)[Ljava/security/CodeSigner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrustedManifestEntry", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginEntry", "(Ljava/util/jar/JarEntry;Lsun/security/util/ManifestEntryVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doneWithMeta", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nothingToVerify", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entryNames", "(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsignedEntryNames", "(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entries2", "(Ljava/util/jar/JarFile;Ljava/util/Enumeration;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodeSources", "(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUnsignedCS", "(Ljava/net/URL;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEagerValidation", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifestDigests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCerts", "(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCerts", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processEntry", "(Lsun/security/util/ManifestEntryVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapSignersToCertArray", "([Ljava/security/CodeSigner;)[Ljava/security/cert/Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapSignersToCodeSource", "(Ljava/net/URL;[Ljava/security/CodeSigner;)Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJarCodeSigners", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapSignersToCodeSources", "(Ljava/net/URL;Ljava/util/List;Z)[Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signerMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findMatchingSigners", "(Ljava/security/CodeSource;)[Ljava/security/CodeSigner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSigningRelated", "(Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable verifiedSigners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable sigFileSigners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable sigFileData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList pendingBlocks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList signerCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool parsingBlockOrSF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool parsingMeta_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool anyToVerify_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljava/io/ByteArrayOutputStream;", "private")]
	public Dova.JDK.java.io.ByteArrayOutputStream baos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ByteArrayOutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/ManifestDigester;", "private volatile")]
	public Dova.JDK.sun.security.util.ManifestDigester manDig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ManifestDigester>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> manifestRawBytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String manifestName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool eagerValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object csdomain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List manifestDigests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map signersToAlgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map urlToCodeSourceMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map signerToCodeSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/URL;", "private")]
	public Dova.JDK.java.net.URL lastURL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map lastURLMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/security/CodeSigner;", "private")]
	public JavaArray<Dova.JDK.java.security.CodeSigner> emptySigner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map signerMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List jarCodeSigners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JarVerifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public")]
	public JarVerifier(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/jar/JarVerifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILsun/security/util/ManifestEntryVerifier;)V", "public")]
	public void update(int arg0, Dova.JDK.sun.security.util.ManifestEntryVerifier arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(I[BIILsun/security/util/ManifestEntryVerifier;)V", "public")]
	public void update(int arg0, JavaArray<byte> arg1, int arg2, int arg3, Dova.JDK.sun.security.util.ManifestEntryVerifier arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;)Ljava/security/CodeSource;", "public")]
	public Dova.JDK.java.security.CodeSource getCodeSource(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)Ljava/security/CodeSource;", "public")]
	public Dova.JDK.java.security.CodeSource getCodeSource(Dova.JDK.java.net.URL arg0, Dova.JDK.java.util.jar.JarFile arg1, Dova.JDK.java.util.jar.JarEntry arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)[Ljava/security/CodeSigner;", "public")]
	public JavaArray<Dova.JDK.java.security.CodeSigner> getCodeSigners(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.util.jar.JarEntry arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/security/CodeSigner;", "public")]
	public JavaArray<Dova.JDK.java.security.CodeSigner> getCodeSigners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isTrustedManifestEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarEntry;Lsun/security/util/ManifestEntryVerifier;)V", "public")]
	public void beginEntry(Dova.JDK.java.util.jar.JarEntry arg0, Dova.JDK.sun.security.util.ManifestEntryVerifier arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void doneWithMeta()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool nothingToVerify()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;[Ljava/security/CodeSource;)Ljava/util/Enumeration;", "public synchronized")]
	public Dova.JDK.java.util.Enumeration entryNames(Dova.JDK.java.util.jar.JarFile arg0, JavaArray<Dova.JDK.java.security.CodeSource> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;)Ljava/util/Enumeration;", "private")]
	public Dova.JDK.java.util.Enumeration unsignedEntryNames(Dova.JDK.java.util.jar.JarFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/util/Enumeration;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration entries2(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.util.Enumeration arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/net/URL;)[Ljava/security/CodeSource;", "public synchronized")]
	public JavaArray<Dova.JDK.java.security.CodeSource> getCodeSources(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.net.URL arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSource>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/security/CodeSource;", "static")]
	public static Dova.JDK.java.security.CodeSource getUnsignedCS(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEagerValidation(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
	public Dova.JDK.java.util.List getManifestDigests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)[Ljava/security/cert/Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getCerts(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.util.jar.JarEntry arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/security/cert/Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.Certificate> getCerts(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/ManifestEntryVerifier;)V", "private")]
	public void processEntry(Dova.JDK.sun.security.util.ManifestEntryVerifier arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("([Ljava/security/CodeSigner;)[Ljava/security/cert/Certificate;", "private static")]
	public static JavaArray<Dova.JDK.java.security.cert.Certificate> mapSignersToCertArray(JavaArray<Dova.JDK.java.security.CodeSigner> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;[Ljava/security/CodeSigner;)Ljava/security/CodeSource;", "private synchronized")]
	public Dova.JDK.java.security.CodeSource mapSignersToCodeSource(Dova.JDK.java.net.URL arg0, JavaArray<Dova.JDK.java.security.CodeSigner> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private synchronized")]
	public Dova.JDK.java.util.List getJarCodeSigners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/util/List;Z)[Ljava/security/CodeSource;", "private")]
	public JavaArray<Dova.JDK.java.security.CodeSource> mapSignersToCodeSources(Dova.JDK.java.net.URL arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSource>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private synchronized")]
	public Dova.JDK.java.util.Map signerMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/CodeSource;)[Ljava/security/CodeSigner;", "private")]
	public JavaArray<Dova.JDK.java.security.CodeSigner> findMatchingSigners(Dova.JDK.java.security.CodeSource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool isSigningRelated(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/util/jar/JarVerifier$VerifierCodeSource;", "private static")]
	public partial class VerifierCodeSource
		: Dova.JDK.java.security.CodeSource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VerifierCodeSource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/jar/JarVerifier$VerifierCodeSource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vlocation", "Ljava/net/URL;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vsigners", "[Ljava/security/CodeSigner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vcerts", "[Ljava/security/cert/Certificate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "csdomain", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/net/URL;[Ljava/security/CodeSigner;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/net/URL;[Ljava/security/cert/Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameDomain", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateSigners", "()[Ljava/security/CodeSigner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateCertificates", "()[Ljava/security/cert/Certificate;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/net/URL;", "")]
		public Dova.JDK.java.net.URL vlocation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/security/CodeSigner;", "")]
		public JavaArray<Dova.JDK.java.security.CodeSigner> vsigners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/security/cert/Certificate;", "")]
		public JavaArray<Dova.JDK.java.security.cert.Certificate> vcerts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object csdomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VerifierCodeSource(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/net/URL;[Ljava/security/CodeSigner;)V", "")]
		public VerifierCodeSource(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.net.URL arg1, JavaArray<Dova.JDK.java.security.CodeSigner> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/net/URL;[Ljava/security/cert/Certificate;)V", "")]
		public VerifierCodeSource(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.net.URL arg1, JavaArray<Dova.JDK.java.security.cert.Certificate> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/jar/JarVerifier$VerifierCodeSource;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "")]
		public bool isSameDomain(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Ljava/security/CodeSigner;", "private")]
		public JavaArray<Dova.JDK.java.security.CodeSigner> getPrivateSigners()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.CodeSigner>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/security/cert/Certificate;", "private")]
		public JavaArray<Dova.JDK.java.security.cert.Certificate> getPrivateCertificates()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.Certificate>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/jar/JarVerifier$VerifierStream;", "static")]
	public partial class VerifierStream
		: Dova.JDK.java.io.InputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VerifierStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/jar/JarVerifier$VerifierStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "is", "Ljava/io/InputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jv", "Ljava/util/jar/JarVerifier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mev", "Lsun/security/util/ManifestEntryVerifier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numLeft", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/jar/Manifest;Ljava/util/jar/JarEntry;Ljava/io/InputStream;Ljava/util/jar/JarVerifier;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		}

		[JniSignatureAttribute("Ljava/io/InputStream;", "private")]
		public Dova.JDK.java.io.InputStream @is_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/jar/JarVerifier;", "private")]
		public Dova.JDK.java.util.jar.JarVerifier jv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarVerifier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/util/ManifestEntryVerifier;", "private")]
		public Dova.JDK.sun.security.util.ManifestEntryVerifier mev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ManifestEntryVerifier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long numLeft_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VerifierStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/jar/Manifest;Ljava/util/jar/JarEntry;Ljava/io/InputStream;Ljava/util/jar/JarVerifier;)V", "")]
		public VerifierStream(Dova.JDK.java.util.jar.Manifest arg0, Dova.JDK.java.util.jar.JarEntry arg1, Dova.JDK.java.io.InputStream arg2, Dova.JDK.java.util.jar.JarVerifier arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/jar/JarVerifier$VerifierStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)I", "public")]
		public int read(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int read()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void ensureOpen()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}
}
