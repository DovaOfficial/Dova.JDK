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

namespace Dova.JDK.com.sun.java.accessibility.util;

[JniSignatureAttribute("Lcom/sun/java/accessibility/util/TopLevelWindowMulticaster;", "")]
public partial class TopLevelWindowMulticaster
	: Dova.JDK.java.awt.AWTEventMulticaster
	, Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TopLevelWindowMulticaster()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/accessibility/util/TopLevelWindowMulticaster;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TopLevelWindowMulticaster", "(Ljava/util/EventListener;Ljava/util/EventListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Lcom/sun/java/accessibility/util/TopLevelWindowListener;Lcom/sun/java/accessibility/util/TopLevelWindowListener;)Lcom/sun/java/accessibility/util/TopLevelWindowListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Lcom/sun/java/accessibility/util/TopLevelWindowListener;Lcom/sun/java/accessibility/util/TopLevelWindowListener;)Lcom/sun/java/accessibility/util/TopLevelWindowListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "topLevelWindowCreated", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "topLevelWindowDestroyed", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "addInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "removeInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TopLevelWindowMulticaster(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)V", "protected")]
	public TopLevelWindowMulticaster(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/TopLevelWindowMulticaster;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/java/accessibility/util/TopLevelWindowListener;Lcom/sun/java/accessibility/util/TopLevelWindowListener;)Lcom/sun/java/accessibility/util/TopLevelWindowListener;", "public static")]
	public static Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener add(Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener arg0, Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/accessibility/util/TopLevelWindowListener;Lcom/sun/java/accessibility/util/TopLevelWindowListener;)Lcom/sun/java/accessibility/util/TopLevelWindowListener;", "public static")]
	public static Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener remove(Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener arg0, Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public")]
	public void topLevelWindowCreated(Dova.JDK.java.awt.Window arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public")]
	public void topLevelWindowDestroyed(Dova.JDK.java.awt.Window arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener addInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener removeInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}
}
