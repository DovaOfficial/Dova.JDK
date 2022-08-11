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

namespace Dova.JDK.jdk.@internal.net.http.hpack;

[JniSignatureAttribute("Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;", "final")]
public partial class LiteralWithIndexingWriter
	: Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LiteralWithIndexingWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableUpdated", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/CharSequence;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/CharSequence;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "index_0", "(I)Ljdk/internal/net/http/hpack/IndexNameValueWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "index_1", "(I)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name_0", "(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/IndexNameValueWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name_1", "(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value_0", "(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/IndexNameValueWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value_1", "(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljdk/internal/net/http/hpack/HeaderTable;Ljava/nio/ByteBuffer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_0", "()Ljdk/internal/net/http/hpack/BinaryRepresentationWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_1", "()Ljdk/internal/net/http/hpack/IndexNameValueWriter;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool tableUpdated_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/CharSequence;", "private")]
	public Dova.JDK.java.lang.CharSequence name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/CharSequence;", "private")]
	public Dova.JDK.java.lang.CharSequence value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LiteralWithIndexingWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public LiteralWithIndexingWriter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/IndexNameValueWriter;", "volatile")]
	public Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter index_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;", "")]
	public Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter index_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/IndexNameValueWriter;", "volatile")]
	public Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter name_0(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;", "")]
	public Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter name_1(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/IndexNameValueWriter;", "volatile")]
	public Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter value_0(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljdk/internal/net/http/hpack/LiteralWithIndexingWriter;", "")]
	public Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter value_1(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.LiteralWithIndexingWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/HeaderTable;Ljava/nio/ByteBuffer;)Z", "public")]
	public bool write(Dova.JDK.jdk.@internal.net.http.hpack.HeaderTable arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/BinaryRepresentationWriter;", "public volatile")]
	public Dova.JDK.jdk.@internal.net.http.hpack.BinaryRepresentationWriter reset_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.BinaryRepresentationWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/IndexNameValueWriter;", "public")]
	public Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter reset_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.IndexNameValueWriter>(ret);
	}
}
