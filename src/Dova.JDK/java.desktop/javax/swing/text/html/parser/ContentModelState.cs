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

namespace Dova.JDK.javax.swing.text.html.parser;

[JniSignatureAttribute("Ljavax/swing/text/html/parser/ContentModelState;", "")]
public partial class ContentModelState
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ContentModelState()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/parser/ContentModelState;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "model", "Ljavax/swing/text/html/parser/ContentModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "value", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "next", "Ljavax/swing/text/html/parser/ContentModelState;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ContentModelState", "(Ljava/lang/Object;Ljavax/swing/text/html/parser/ContentModelState;J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ContentModelState", "(Ljava/lang/Object;Ljavax/swing/text/html/parser/ContentModelState;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ContentModelState", "(Ljavax/swing/text/html/parser/ContentModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "first", "()Ljavax/swing/text/html/parser/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "advance", "(Ljava/lang/Object;)Ljavax/swing/text/html/parser/ContentModelState;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "terminate", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModel", "()Ljavax/swing/text/html/parser/ContentModel;"));
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/parser/ContentModel;", "")]
	public Dova.JDK.javax.swing.text.html.parser.ContentModel model_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.parser.ContentModel>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "")]
	public long value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/parser/ContentModelState;", "")]
	public Dova.JDK.javax.swing.text.html.parser.ContentModelState next_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.parser.ContentModelState>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ContentModelState(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/html/parser/ContentModelState;J)V", "")]
	public ContentModelState(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.html.parser.ContentModelState arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/html/parser/ContentModelState;)V", "")]
	public ContentModelState(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.html.parser.ContentModelState arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/parser/ContentModel;)V", "public")]
	public ContentModelState(Dova.JDK.javax.swing.text.html.parser.ContentModel arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/parser/ContentModelState;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/text/html/parser/Element;", "public")]
	public Dova.JDK.javax.swing.text.html.parser.Element first()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.parser.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/swing/text/html/parser/ContentModelState;", "public")]
	public Dova.JDK.javax.swing.text.html.parser.ContentModelState advance(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.parser.ContentModelState>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool terminate()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/parser/ContentModel;", "public")]
	public Dova.JDK.javax.swing.text.html.parser.ContentModel getModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.parser.ContentModel>(ret);
	}
}
