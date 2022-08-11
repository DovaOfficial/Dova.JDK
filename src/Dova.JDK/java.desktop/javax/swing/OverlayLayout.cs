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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/OverlayLayout;", "public")]
public partial class OverlayLayout
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.LayoutManager2
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OverlayLayout()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/OverlayLayout;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/awt/Container;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xChildren", "[Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yChildren", "[Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xTotal", "Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yTotal", "Ljavax/swing/SizeRequirements;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkContainer", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkRequests", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/awt/Component;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateLayout", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentX", "(Ljava/awt/Container;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentY", "(Ljava/awt/Container;)F"));
	}

	[JniSignatureAttribute("Ljava/awt/Container;", "private")]
	public Dova.JDK.java.awt.Container target_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/swing/SizeRequirements;", "private")]
	public JavaArray<Dova.JDK.javax.swing.SizeRequirements> xChildren_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.SizeRequirements>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/swing/SizeRequirements;", "private")]
	public JavaArray<Dova.JDK.javax.swing.SizeRequirements> yChildren_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.SizeRequirements>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SizeRequirements;", "private")]
	public Dova.JDK.javax.swing.SizeRequirements xTotal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SizeRequirements;", "private")]
	public Dova.JDK.javax.swing.SizeRequirements yTotal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OverlayLayout(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public OverlayLayout(Dova.JDK.java.awt.Container arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/OverlayLayout;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Container;", "public final")]
	public Dova.JDK.java.awt.Container getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "")]
	public void checkContainer(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkRequests()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void removeLayoutComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/Component;)V", "public")]
	public void addLayoutComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;)V", "public")]
	public void addLayoutComponent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void layoutContainer(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void invalidateLayout(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension maximumLayoutSize(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
	public float getLayoutAlignmentX(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
	public float getLayoutAlignmentY(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}
}
