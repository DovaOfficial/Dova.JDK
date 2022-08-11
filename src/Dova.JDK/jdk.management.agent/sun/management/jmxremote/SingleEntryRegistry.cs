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

namespace Dova.JDK.sun.management.jmxremote;

[JniSignatureAttribute("Lsun/management/jmxremote/SingleEntryRegistry;", "public")]
public partial class SingleEntryRegistry
	: Dova.JDK.sun.rmi.registry.RegistryImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SingleEntryRegistry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/management/jmxremote/SingleEntryRegistry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Ljava/rmi/Remote;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;Ljava/rmi/Remote;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/lang/String;Ljava/rmi/Remote;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/rmi/Remote;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/rmi/Remote;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "singleRegistryFilter", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/Remote;", "private final")]
	public Dova.JDK.java.rmi.Remote @object_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SingleEntryRegistry(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/rmi/Remote;)V", "")]
	public SingleEntryRegistry(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.rmi.Remote arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/lang/String;Ljava/rmi/Remote;)V", "")]
	public SingleEntryRegistry(int arg0, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg1, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.rmi.Remote arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/management/jmxremote/SingleEntryRegistry;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> list()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/rmi/Remote;", "public")]
	public Dova.JDK.java.rmi.Remote lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/rmi/Remote;)V", "public")]
	public void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.rmi.Remote arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/rmi/Remote;)V", "public")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.rmi.Remote arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "private static")]
	public static Dova.JDK.java.io.ObjectInputFilter.Status singleRegistryFilter(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void unbind(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
