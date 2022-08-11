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

namespace Dova.JDK.jdk.tools.jmod;

[JniSignatureAttribute("Ljdk/tools/jmod/JmodOutputStream;", "")]
public partial class JmodOutputStream
	: Dova.JDK.java.io.OutputStream
	, Dova.JDK.java.lang.AutoCloseable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JmodOutputStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jmod/JmodOutputStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zos", "Ljava/util/zip/ZipOutputStream;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newOutputStream", "(Ljava/nio/file/Path;)Ljdk/tools/jmod/JmodOutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEntry", "(Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)Ljava/util/zip/ZipEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeEntry", "(Ljava/io/InputStream;Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeEntry", "([BLjdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeEntry", "(Ljava/io/InputStream;Ljdk/internal/jmod/JmodFile$Entry;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map entries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/zip/ZipOutputStream;", "private final")]
	public Dova.JDK.java.util.zip.ZipOutputStream zos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipOutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JmodOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "private")]
	public JmodOutputStream(Dova.JDK.java.io.OutputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jmod/JmodOutputStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)Z", "public")]
	public bool contains(Dova.JDK.jdk.@internal.jmod.JmodFile.Section arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void write(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/tools/jmod/JmodOutputStream;", "static")]
	public static Dova.JDK.jdk.tools.jmod.JmodOutputStream newOutputStream(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jmod.JmodOutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)Ljava/util/zip/ZipEntry;", "private")]
	public Dova.JDK.java.util.zip.ZipEntry newEntry(Dova.JDK.jdk.@internal.jmod.JmodFile.Section arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)V", "public")]
	public void writeEntry(Dova.JDK.java.io.InputStream arg0, Dova.JDK.jdk.@internal.jmod.JmodFile.Section arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BLjdk/internal/jmod/JmodFile$Section;Ljava/lang/String;)V", "public")]
	public void writeEntry(JavaArray<byte> arg0, Dova.JDK.jdk.@internal.jmod.JmodFile.Section arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljdk/internal/jmod/JmodFile$Entry;)V", "public")]
	public void writeEntry(Dova.JDK.java.io.InputStream arg0, Dova.JDK.jdk.@internal.jmod.JmodFile.Entry arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}
}
