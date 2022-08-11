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

namespace Dova.JDK.com.sun.management.@internal;

[JniSignatureAttribute("Lcom/sun/management/internal/GcInfoBuilder;", "public")]
public partial class GcInfoBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GcInfoBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/management/internal/GcInfoBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gc", "Ljava/lang/management/GarbageCollectorMXBean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "poolNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allItemNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gcInfoCompositeType", "Ljavax/management/openmbean/CompositeType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gcExtItemCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gcExtItemNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gcExtItemDescs", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gcExtItemTypes", "[C"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/management/GarbageCollectorMXBean;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastGcInfo", "()Lcom/sun/management/GcInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoolNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumGcExtAttributes", "(Ljava/lang/management/GarbageCollectorMXBean;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillGcAttributeInfo", "(Ljava/lang/management/GarbageCollectorMXBean;I[Ljava/lang/String;[C[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastGcInfo0", "(Ljava/lang/management/GarbageCollectorMXBean;I[Ljava/lang/Object;[C[Ljava/lang/management/MemoryUsage;[Ljava/lang/management/MemoryUsage;)Lcom/sun/management/GcInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGcInfoCompositeType", "()Ljavax/management/openmbean/CompositeType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGcExtItemCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemNames", "()[Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/management/GarbageCollectorMXBean;", "private final")]
	public Dova.JDK.java.lang.management.GarbageCollectorMXBean gc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.management.GarbageCollectorMXBean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> poolNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> allItemNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/openmbean/CompositeType;", "private")]
	public Dova.JDK.javax.management.openmbean.CompositeType gcInfoCompositeType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.CompositeType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int gcExtItemCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> gcExtItemNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> gcExtItemDescs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "private final")]
	public JavaArray<char> gcExtItemTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GcInfoBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/management/GarbageCollectorMXBean;[Ljava/lang/String;)V", "")]
	public GcInfoBuilder(Dova.JDK.java.lang.management.GarbageCollectorMXBean arg0, JavaArray<Dova.JDK.java.lang.String> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/management/internal/GcInfoBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/management/GcInfo;", "")]
	public Dova.JDK.com.sun.management.GcInfo getLastGcInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.GcInfo>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getPoolNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/management/GarbageCollectorMXBean;)I", "private native")]
	public int getNumGcExtAttributes(Dova.JDK.java.lang.management.GarbageCollectorMXBean arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/management/GarbageCollectorMXBean;I[Ljava/lang/String;[C[Ljava/lang/String;)V", "private native")]
	public void fillGcAttributeInfo(Dova.JDK.java.lang.management.GarbageCollectorMXBean arg0, int arg1, JavaArray<Dova.JDK.java.lang.String> arg2, JavaArray<char> arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/management/GarbageCollectorMXBean;I[Ljava/lang/Object;[C[Ljava/lang/management/MemoryUsage;[Ljava/lang/management/MemoryUsage;)Lcom/sun/management/GcInfo;", "private native")]
	public Dova.JDK.com.sun.management.GcInfo getLastGcInfo0(Dova.JDK.java.lang.management.GarbageCollectorMXBean arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<char> arg3, JavaArray<Dova.JDK.java.lang.management.MemoryUsage> arg4, JavaArray<Dova.JDK.java.lang.management.MemoryUsage> arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.GcInfo>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/openmbean/CompositeType;", "synchronized")]
	public Dova.JDK.javax.management.openmbean.CompositeType getGcInfoCompositeType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.CompositeType>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getGcExtItemCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "synchronized")]
	public JavaArray<Dova.JDK.java.lang.String> getItemNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}
}
