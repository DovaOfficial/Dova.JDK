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

namespace Dova.JDK.sun.jvmstat.perfdata.monitor.v1_0;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/v1_0/PerfDataBufferPrologue;", "public")]
public partial class PerfDataBufferPrologue
	: Dova.JDK.sun.jvmstat.perfdata.monitor.AbstractPerfDataBufferPrologue
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PerfDataBufferPrologue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/v1_0/PerfDataBufferPrologue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPORTED_MAJOR_VERSION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPORTED_MINOR_VERSION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_USED_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_USED_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_OVERFLOW_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_OVERFLOW_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_MODTIMESTAMP_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_MODTIMESTAMP_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_PROLOG_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_BUFFER_SIZE_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_BUFFER_USED_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_OVERFLOW_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERFDATA_MODTIMESTAMP_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "usedBuffer", "()Ljava/nio/IntBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsAccessible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sizeBuffer", "()Ljava/nio/IntBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overflowBuffer", "()Ljava/nio/IntBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modificationTimeStampBuffer", "()Ljava/nio/LongBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUsed", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOverflow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModificationTimeStamp", "()J"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTED_MAJOR_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTED_MINOR_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_USED_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_USED_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_OVERFLOW_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_OVERFLOW_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_MODTIMESTAMP_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_MODTIMESTAMP_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int PERFDATA_PROLOG_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String PERFDATA_BUFFER_SIZE_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String PERFDATA_BUFFER_USED_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String PERFDATA_OVERFLOW_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String PERFDATA_MODTIMESTAMP_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PerfDataBufferPrologue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
	public PerfDataBufferPrologue(Dova.JDK.java.nio.ByteBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/v1_0/PerfDataBufferPrologue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isAccessible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBufferSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/IntBuffer;", "public")]
	public Dova.JDK.java.nio.IntBuffer usedBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.IntBuffer>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool supportsAccessible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/IntBuffer;", "public")]
	public Dova.JDK.java.nio.IntBuffer sizeBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.IntBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/IntBuffer;", "public")]
	public Dova.JDK.java.nio.IntBuffer overflowBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.IntBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/LongBuffer;", "public")]
	public Dova.JDK.java.nio.LongBuffer modificationTimeStampBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.LongBuffer>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getUsed()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOverflow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getModificationTimeStamp()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}
}
