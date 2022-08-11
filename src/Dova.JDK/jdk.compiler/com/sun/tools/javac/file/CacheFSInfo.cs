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

namespace Dova.JDK.com.sun.tools.javac.file;

[JniSignatureAttribute("Lcom/sun/tools/javac/file/CacheFSInfo;", "public")]
public partial class CacheFSInfo
	: Dova.JDK.com.sun.tools.javac.file.FSInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CacheFSInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/CacheFSInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canonicalPathCache", "Ljava/util/concurrent/ConcurrentHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeCache", "Ljava/util/concurrent/ConcurrentHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jarClassPathCache", "Ljava/util/concurrent/ConcurrentHashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/nio/file/Path;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exists", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectory", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalFile", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFile", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "preRegister", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maybeReadAttributes", "(Ljava/nio/file/Path;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJarClassPath", "(Ljava/nio/file/Path;)Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "protected final")]
	public Dova.JDK.java.util.concurrent.ConcurrentHashMap canonicalPathCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "protected final")]
	public Dova.JDK.java.util.concurrent.ConcurrentHashMap attributeCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "protected final")]
	public Dova.JDK.java.util.concurrent.ConcurrentHashMap jarClassPathCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CacheFSInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CacheFSInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/CacheFSInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Optional;", "protected")]
	public Dova.JDK.java.util.Optional getAttributes(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool exists(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool isDirectory(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path getCanonicalFile(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool isFile(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearCache()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "public static")]
	public static void preRegister(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Optional;", "protected")]
	public Dova.JDK.java.util.Optional maybeReadAttributes(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getJarClassPath(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
