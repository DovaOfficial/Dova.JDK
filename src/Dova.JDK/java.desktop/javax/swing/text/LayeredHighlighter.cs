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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/LayeredHighlighter;", "public abstract")]
public partial class LayeredHighlighter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.text.Highlighter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LayeredHighlighter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/LayeredHighlighter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintLayeredHighlights", "(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LayeredHighlighter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public LayeredHighlighter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/LayeredHighlighter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)V", "public abstract")]
	public void paintLayeredHighlights(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, Dova.JDK.java.awt.Shape arg3, Dova.JDK.javax.swing.text.JTextComponent arg4, Dova.JDK.javax.swing.text.View arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("Ljavax/swing/text/LayeredHighlighter$LayerPainter;", "public abstract static")]
	public partial class LayerPainter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.text.Highlighter.HighlightPainter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LayerPainter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/LayeredHighlighter$LayerPainter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintLayer", "(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)Ljava/awt/Shape;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LayerPainter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public LayerPainter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/LayeredHighlighter$LayerPainter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)Ljava/awt/Shape;", "public abstract")]
		public Dova.JDK.java.awt.Shape paintLayer(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, Dova.JDK.java.awt.Shape arg3, Dova.JDK.javax.swing.text.JTextComponent arg4, Dova.JDK.javax.swing.text.View arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}
	}
}
