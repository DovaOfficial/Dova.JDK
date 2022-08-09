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

namespace Dova.JDK.com.sun.jmx.mbeanserver;

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/DescriptorCache;", "public")]
public partial class DescriptorCache
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DescriptorCache()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/DescriptorCache;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Lcom/sun/jmx/mbeanserver/DescriptorCache;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "map", "Ljava/util/WeakHashMap;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DescriptorCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljavax/management/ImmutableDescriptor;)Ljavax/management/ImmutableDescriptor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljavax/management/JMX;)Lcom/sun/jmx/mbeanserver/DescriptorCache;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Lcom/sun/jmx/mbeanserver/DescriptorCache;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "union", "([Ljavax/management/Descriptor;)Ljavax/management/ImmutableDescriptor;"));
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/DescriptorCache;", "private static final")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache instance_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private final")]
	public Dova.JDK.java.util.WeakHashMap map_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DescriptorCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DescriptorCache() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/DescriptorCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/ImmutableDescriptor;)Ljavax/management/ImmutableDescriptor;", "public")]
	public Dova.JDK.javax.management.ImmutableDescriptor get(Dova.JDK.javax.management.ImmutableDescriptor arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ImmutableDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/JMX;)Lcom/sun/jmx/mbeanserver/DescriptorCache;", "public static")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache getInstance(Dova.JDK.javax.management.JMX arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/DescriptorCache;", "static")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache getInstance()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.DescriptorCache>(ret);
	}

	[JniSignatureAttribute("([Ljavax/management/Descriptor;)Ljavax/management/ImmutableDescriptor;", "public transient")]
	public Dova.JDK.javax.management.ImmutableDescriptor union(JavaArray<Dova.JDK.javax.management.Descriptor> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ImmutableDescriptor>(ret);
	}
}
