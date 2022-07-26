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

[JniSignatureAttribute("Ljavax/swing/text/Highlighter;", "public abstract interface")]
public partial interface Highlighter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Highlighter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Highlighter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deinstall", "(Ljavax/swing/text/JTextComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "(Ljavax/swing/text/JTextComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHighlight", "(IILjavax/swing/text/Highlighter$HighlightPainter;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeHighlight", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeHighlight", "(Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllHighlights", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighlights", "()[Ljavax/swing/text/Highlighter$Highlight;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;)V"));
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)V", "public abstract")]
	void deinstall(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)V", "public abstract")]
	void install(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/Highlighter$HighlightPainter;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object addHighlight(int arg0, int arg1, Dova.JDK.javax.swing.text.Highlighter.HighlightPainter arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
	void removeHighlight(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)V", "public abstract")]
	void changeHighlight(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void removeAllHighlights()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()[Ljavax/swing/text/Highlighter$Highlight;", "public abstract")]
	JavaArray<Dova.JDK.javax.swing.text.Highlighter.Highlight> getHighlights()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Highlighter.Highlight>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public abstract")]
	void paint(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/text/Highlighter$Highlight;", "public abstract static interface")]
	public partial interface Highlight
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Highlight()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Highlighter$Highlight;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPainter", "()Ljavax/swing/text/Highlighter$HighlightPainter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Highlighter$HighlightPainter;", "public abstract")]
		Dova.JDK.javax.swing.text.Highlighter.HighlightPainter getPainter()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Highlighter.HighlightPainter>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/Highlighter$HighlightPainter;", "public abstract static interface")]
	public partial interface HighlightPainter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HighlightPainter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Highlighter$HighlightPainter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;)V", "public abstract")]
		void paint(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, Dova.JDK.java.awt.Shape arg3, Dova.JDK.javax.swing.text.JTextComponent arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		}
	}
}
