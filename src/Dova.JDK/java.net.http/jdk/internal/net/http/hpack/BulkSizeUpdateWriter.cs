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

namespace Dova.JDK.jdk.@internal.net.http.hpack;

[JniSignatureAttribute("Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;", "final")]
public partial class BulkSizeUpdateWriter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.net.http.hpack.BinaryRepresentationWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BulkSizeUpdateWriter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "writer", "Ljdk/internal/net/http/hpack/SizeUpdateWriter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "maxSizes", "Ljava/util/Iterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "writing", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "configured", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BulkSizeUpdateWriter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljdk/internal/net/http/hpack/HeaderTable;Ljava/nio/ByteBuffer;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reset_0", "()Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reset_1", "()Ljdk/internal/net/http/hpack/BinaryRepresentationWriter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "maxHeaderTableSizes", "(Ljava/lang/Iterable;)Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/SizeUpdateWriter;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.hpack.SizeUpdateWriter writer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.SizeUpdateWriter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Iterator;", "private")]
	public Dova.JDK.java.util.Iterator maxSizes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool writing_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool configured_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BulkSizeUpdateWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public BulkSizeUpdateWriter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/HeaderTable;Ljava/nio/ByteBuffer;)Z", "public")]
	public bool write(Dova.JDK.jdk.@internal.net.http.hpack.HeaderTable arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;", "public")]
	public Dova.JDK.jdk.@internal.net.http.hpack.BulkSizeUpdateWriter reset_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.BulkSizeUpdateWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/BinaryRepresentationWriter;", "public volatile")]
	public Dova.JDK.jdk.@internal.net.http.hpack.BinaryRepresentationWriter reset_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.BinaryRepresentationWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljdk/internal/net/http/hpack/BulkSizeUpdateWriter;", "")]
	public Dova.JDK.jdk.@internal.net.http.hpack.BulkSizeUpdateWriter maxHeaderTableSizes(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.BulkSizeUpdateWriter>(ret);
	}
}