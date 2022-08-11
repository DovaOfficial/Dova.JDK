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

namespace Dova.JDK.jdk.nio.zipfs;

[JniSignatureAttribute("Ljdk/nio/zipfs/ZipDirectoryStream;", "")]
public partial class ZipDirectoryStream
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.nio.file.DirectoryStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZipDirectoryStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/nio/zipfs/ZipDirectoryStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zipfs", "Ljdk/nio/zipfs/ZipFileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "Ljdk/nio/zipfs/ZipPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Ljava/nio/file/DirectoryStream$Filter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isClosed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "itr", "Ljava/util/Iterator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/nio/zipfs/ZipPath;Ljava/nio/file/DirectoryStream$Filter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
	}

	[JniSignatureAttribute("Ljdk/nio/zipfs/ZipFileSystem;", "private final")]
	public Dova.JDK.jdk.nio.zipfs.ZipFileSystem zipfs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.nio.zipfs.ZipFileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/nio/zipfs/ZipPath;", "private final")]
	public Dova.JDK.jdk.nio.zipfs.ZipPath dir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.nio.zipfs.ZipPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/DirectoryStream$Filter;", "private final")]
	public Dova.JDK.java.nio.file.DirectoryStream.Filter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.DirectoryStream.Filter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool isClosed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Iterator;", "private volatile")]
	public Dova.JDK.java.util.Iterator itr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZipDirectoryStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/nio/zipfs/ZipPath;Ljava/nio/file/DirectoryStream$Filter;)V", "")]
	public ZipDirectoryStream(Dova.JDK.jdk.nio.zipfs.ZipPath arg0, Dova.JDK.java.nio.file.DirectoryStream.Filter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/nio/zipfs/ZipDirectoryStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public synchronized")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}
}
