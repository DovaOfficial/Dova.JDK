/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/swing/text/NavigationFilter;", "public")]
public partial class NavigationFilter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NavigationFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/NavigationFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NavigationFilter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moveDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NavigationFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NavigationFilter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/NavigationFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "public")]
	public void setDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "public")]
	public void moveDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Ljavax/swing/text/NavigationFilter$FilterBypass;", "public abstract static")]
	public partial class FilterBypass
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FilterBypass()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/NavigationFilter$FilterBypass;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FilterBypass", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDot", "(ILjavax/swing/text/Position$Bias;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moveDot", "(ILjavax/swing/text/Position$Bias;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCaret", "()Ljavax/swing/text/Caret;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FilterBypass(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public FilterBypass() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/NavigationFilter$FilterBypass;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public abstract")]
		public void setDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public abstract")]
		public void moveDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Caret;", "public abstract")]
		public Dova.JDK.javax.swing.text.Caret getCaret()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Caret>(ret);
		}
	}
}
