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

namespace Dova.JDK.java.nio;

[JniSignatureAttribute("Ljava/nio/DirectCharBufferS;", "")]
public partial class DirectCharBufferS
	: Dova.JDK.java.nio.CharBuffer
	, Dova.JDK.sun.nio.ch.DirectBuffer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DirectCharBufferS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/DirectCharBufferS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNALIGNED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "att", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/ch/DirectBuffer;IIIIILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "base", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(C)Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(IC)Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subSequence_0", "(II)Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subSequence_1", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirect", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleaner", "()Ljdk/internal/ref/Cleaner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attachment", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "address", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReadOnly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "(II)Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "(II)Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "()Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_0", "()Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_1", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asReadOnlyBuffer", "()Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compact", "()Ljava/nio/CharBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "order", "()Ljava/nio/ByteOrder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ix", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnchecked", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charRegionOrder", "()Ljava/nio/ByteOrder;"));
	}

	[JniSignatureAttribute("Z", "protected static final")]
	public static bool UNALIGNED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object att_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DirectCharBufferS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/nio/ch/DirectBuffer;IIIIILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public DirectCharBufferS(Dova.JDK.sun.nio.ch.DirectBuffer arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/DirectCharBufferS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object @base()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()C", "public")]
	public char get()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char get(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer put(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("(IC)Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer put(int arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer subSequence_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public volatile")]
	public Dova.JDK.java.lang.CharSequence subSequence_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDirect()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/ref/Cleaner;", "public")]
	public Dova.JDK.jdk.@internal.@ref.Cleaner cleaner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object attachment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long address()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReadOnly()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer slice_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer slice_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer duplicate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer duplicate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer asReadOnlyBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/CharBuffer;", "public")]
	public Dova.JDK.java.nio.CharBuffer compact()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.CharBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "public")]
	public Dova.JDK.java.nio.ByteOrder order()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}

	[JniSignatureAttribute("(I)J", "private")]
	public long ix(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "")]
	public char getUnchecked(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "")]
	public Dova.JDK.java.nio.ByteOrder charRegionOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}
}
