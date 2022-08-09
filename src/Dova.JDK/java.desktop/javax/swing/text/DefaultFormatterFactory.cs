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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatterFactory;", "public")]
public partial class DefaultFormatterFactory
	: Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatterFactory
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultFormatterFactory()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/text/DefaultFormatterFactory;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "defaultFormat", "Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "displayFormat", "Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "editFormat", "Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nullFormat", "Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultFormatterFactory", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultFormatterFactory", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultFormatterFactory", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultFormatterFactory", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultFormatterFactory", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFormatter", "(Ljavax/swing/JFormattedTextField;)Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNullFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEditFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDisplayFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDefaultFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDefaultFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDisplayFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEditFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNullFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/JFormattedTextField$AbstractFormatter;", "private")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter defaultFormat_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/JFormattedTextField$AbstractFormatter;", "private")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter displayFormat_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/JFormattedTextField$AbstractFormatter;", "private")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter editFormat_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/JFormattedTextField$AbstractFormatter;", "private")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter nullFormat_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultFormatterFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public DefaultFormatterFactory(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg1, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg2, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public DefaultFormatterFactory(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg1, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public DefaultFormatterFactory(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0, Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public DefaultFormatterFactory(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultFormatterFactory() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultFormatterFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField;)Ljavax/swing/JFormattedTextField$AbstractFormatter;", "public")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter getFormatter(Dova.JDK.javax.swing.JFormattedTextField arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JFormattedTextField$AbstractFormatter;", "public")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter getNullFormatter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JFormattedTextField$AbstractFormatter;", "public")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter getEditFormatter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JFormattedTextField$AbstractFormatter;", "public")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter getDisplayFormatter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JFormattedTextField$AbstractFormatter;", "public")]
	public Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter getDefaultFormatter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public void setDefaultFormatter(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public void setDisplayFormatter(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public void setEditFormatter(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", "public")]
	public void setNullFormatter(Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}
}
