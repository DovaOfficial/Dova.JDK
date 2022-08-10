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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "public")]
public partial class KeyStroke
	: Dova.JDK.java.awt.AWTKeyStroke
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyStroke()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/KeyStroke;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "KeyStroke", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "KeyStroke", "(CIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(IIZ)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(Ljava/lang/String;)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(C)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(II)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(CZ)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStroke", "(Ljava/lang/Character;I)Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStrokeForEvent", "(Ljava/awt/event/KeyEvent;)Ljavax/swing/KeyStroke;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyStroke(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public KeyStroke() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(CIIZ)V", "private")]
	public KeyStroke(char arg0, int arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/KeyStroke;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IIZ)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(C)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(CZ)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(char arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Character;I)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStroke(Dova.JDK.java.lang.Character arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Ljavax/swing/KeyStroke;", "public static")]
	public static Dova.JDK.javax.swing.KeyStroke getKeyStrokeForEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}
}
