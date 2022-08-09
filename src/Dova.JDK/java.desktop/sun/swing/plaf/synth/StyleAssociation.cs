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

namespace Dova.JDK.sun.swing.plaf.synth;

[JniSignatureAttribute("Lsun/swing/plaf/synth/StyleAssociation;", "public")]
public partial class StyleAssociation
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StyleAssociation()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/plaf/synth/StyleAssociation;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_style", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_pattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_matcher", "Ljava/util/regex/Matcher;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_id", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "StyleAssociation", "(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "matches", "(Ljava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getID", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getStyle", "()Ljavax/swing/plaf/synth/SynthStyle;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createStyleAssociation", "(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;I)Lsun/swing/plaf/synth/StyleAssociation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createStyleAssociation", "(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;)Lsun/swing/plaf/synth/StyleAssociation;"));
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle _style_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private")]
	public Dova.JDK.java.util.regex.Pattern _pattern_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/regex/Matcher;", "private")]
	public Dova.JDK.java.util.regex.Matcher _matcher_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Matcher>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int _id_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StyleAssociation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;I)V", "private")]
	public StyleAssociation(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.plaf.synth.SynthStyle arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/StyleAssociation;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Z", "public synchronized")]
	public bool matches(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getID()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthStyle;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle getStyle()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;I)Lsun/swing/plaf/synth/StyleAssociation;", "public static")]
	public static Dova.JDK.sun.swing.plaf.synth.StyleAssociation createStyleAssociation(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.plaf.synth.SynthStyle arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.StyleAssociation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/plaf/synth/SynthStyle;)Lsun/swing/plaf/synth/StyleAssociation;", "public static")]
	public static Dova.JDK.sun.swing.plaf.synth.StyleAssociation createStyleAssociation(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.plaf.synth.SynthStyle arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.StyleAssociation>(ret);
	}
}