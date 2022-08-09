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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XCreateWindowParams;", "public")]
public partial class XCreateWindowParams
	: Dova.JDK.java.util.HashMap
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XCreateWindowParams()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XCreateWindowParams;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XCreateWindowParams", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XCreateWindowParams", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Object;I)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Object;Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Object;J)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "delete", "(Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putIfNull", "(Ljava/lang/Object;J)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putIfNull", "(Ljava/lang/Object;I)Lsun/awt/X11/XCreateWindowParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putIfNull", "(Ljava/lang/Object;Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XCreateWindowParams(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XCreateWindowParams() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public XCreateWindowParams(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XCreateWindowParams;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;I)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams add(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams add(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams add(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "private")]
	public void init(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams delete(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams putIfNull(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams putIfNull(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Lsun/awt/X11/XCreateWindowParams;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowParams putIfNull(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowParams>(ret);
	}
}
