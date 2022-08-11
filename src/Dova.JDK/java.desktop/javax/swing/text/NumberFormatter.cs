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

[JniSignatureAttribute("Ljavax/swing/text/NumberFormatter;", "public")]
public partial class NumberFormatter
	: Dova.JDK.javax.swing.text.InternationalFormatter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NumberFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/NumberFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specialChars", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/text/NumberFormat;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecimalSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinusSign", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPositiveSign", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFormat", "(Ljava/text/Format;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringToValue", "(Ljava/lang/String;Ljava/text/Format;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertValueToValueClass", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toggleSignIfNecessary", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldFrom", "(II)Ljava/text/NumberFormat$Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toggleSign", "(Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toggleExponentSign", "(IC)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLiteral", "(Ljava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNavigatable", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalInsertText", "(Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String specialChars_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NumberFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NumberFormatter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/text/NumberFormat;)V", "public")]
	public NumberFormatter(Dova.JDK.java.text.NumberFormat arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/NumberFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "")]
	public void replace(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.AttributeSet arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()C", "private")]
	public char getDecimalSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()C", "private")]
	public char getMinusSign()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/text/DecimalFormatSymbols;", "private")]
	public Dova.JDK.java.text.DecimalFormatSymbols getDecimalFormatSymbols()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormatSymbols>(ret);
	}

	[JniSignatureAttribute("()C", "private")]
	public char getPositiveSign()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/text/Format;)V", "public")]
	public void setFormat(Dova.JDK.java.text.Format arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/text/Format;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object stringToValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.text.Format arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object convertValueToValueClass(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IC)Z", "private")]
	public bool toggleSignIfNecessary(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/text/NumberFormat$Field;", "private")]
	public Dova.JDK.java.text.NumberFormat.Field getFieldFrom(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat.Field>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object toggleSign(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IC)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object toggleExponentSign(int arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Z", "")]
	public bool isLiteral(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isNavigatable(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isLegalInsertText(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}
}
