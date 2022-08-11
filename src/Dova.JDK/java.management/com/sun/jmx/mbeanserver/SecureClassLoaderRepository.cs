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

namespace Dova.JDK.com.sun.jmx.mbeanserver;

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/SecureClassLoaderRepository;", "final")]
public partial class SecureClassLoaderRepository
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.management.loading.ClassLoaderRepository
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SecureClassLoaderRepository()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/SecureClassLoaderRepository;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clr", "Ljavax/management/loading/ClassLoaderRepository;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/loading/ClassLoaderRepository;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClassBefore", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClassWithout", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
	}

	[JniSignatureAttribute("Ljavax/management/loading/ClassLoaderRepository;", "private final")]
	public Dova.JDK.javax.management.loading.ClassLoaderRepository clr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.loading.ClassLoaderRepository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SecureClassLoaderRepository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/management/loading/ClassLoaderRepository;)V", "public")]
	public SecureClassLoaderRepository(Dova.JDK.javax.management.loading.ClassLoaderRepository arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/SecureClassLoaderRepository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public final")]
	public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public final")]
	public Dova.JDK.java.lang.Class loadClassBefore(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public final")]
	public Dova.JDK.java.lang.Class loadClassWithout(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}
}
