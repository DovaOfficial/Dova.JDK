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

namespace Dova.JDK.javax.swing.plaf;

[JniSignatureAttribute("Ljavax/swing/plaf/TextUI;", "public abstract")]
public partial class TextUI
	: Dova.JDK.javax.swing.plaf.ComponentUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/TextUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootView", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "damageRange", "(Ljavax/swing/text/JTextComponent;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "damageRange", "(Ljavax/swing/text/JTextComponent;IILjavax/swing/text/Position$Bias;Ljavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToolTipText2D", "(Ljavax/swing/text/JTextComponent;Ljava/awt/geom/Point2D;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditorKit", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(Ljavax/swing/text/JTextComponent;I)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView2D", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel2D", "(Ljavax/swing/text/JTextComponent;Ljava/awt/geom/Point2D;[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToolTipText", "(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TextUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public TextUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/TextUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/View;", "public abstract")]
	public Dova.JDK.javax.swing.text.View getRootView(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I", "public abstract")]
	public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;II)V", "public abstract")]
	public void damageRange(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;IILjavax/swing/text/Position$Bias;Ljavax/swing/text/Position$Bias;)V", "public abstract")]
	public void damageRange(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.Position.Bias arg3, Dova.JDK.javax.swing.text.Position.Bias arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/geom/Point2D;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getToolTipText2D(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/EditorKit;", "public abstract")]
	public Dova.JDK.javax.swing.text.EditorKit getEditorKit(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)I", "public abstract")]
	public int viewToModel(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.Point arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;[Ljavax/swing/text/Position$Bias;)I", "public abstract")]
	public int viewToModel(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.Point arg1, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;)Ljava/awt/Rectangle;", "public abstract")]
	public Dova.JDK.java.awt.Rectangle modelToView(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)Ljava/awt/Rectangle;", "public abstract")]
	public Dova.JDK.java.awt.Rectangle modelToView(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;)Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D modelToView2D(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/geom/Point2D;[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int viewToModel2D(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.geom.Point2D arg1, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getToolTipText(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.Point arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
