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

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/NimbusIcon;", "")]
public partial class NimbusIcon
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.plaf.synth.SynthIcon
	, Dova.JDK.javax.swing.plaf.UIResource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NimbusIcon()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/plaf/nimbus/NimbusIcon;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "width", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "height", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "prefix", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "key", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NimbusIcon", "(Ljava/lang/String;Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "scale", "(Ljavax/swing/plaf/synth/SynthContext;I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "paintFilter", "(Ljavax/swing/Painter;)Ljavax/swing/Painter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "paintIcon", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIconWidth", "(Ljavax/swing/plaf/synth/SynthContext;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIconHeight", "(Ljavax/swing/plaf/synth/SynthContext;)I"));
	}

	[JniSignatureAttribute("I", "private")]
	public int width_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int height_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String prefix_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String key_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NimbusIcon(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;II)V", "")]
	public NimbusIcon(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/NimbusIcon;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;I)I", "private")]
	public int scale(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Painter;)Ljavax/swing/Painter;", "private static")]
	public static Dova.JDK.javax.swing.Painter paintFilter(Dova.JDK.javax.swing.Painter arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Painter>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
	public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", "public")]
	public void paintIcon(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;)I", "public")]
	public int getIconWidth(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;)I", "public")]
	public int getIconHeight(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}
}
