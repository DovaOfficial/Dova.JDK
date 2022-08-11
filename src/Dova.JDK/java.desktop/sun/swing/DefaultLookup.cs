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

namespace Dova.JDK.sun.swing;

[JniSignatureAttribute("Lsun/swing/DefaultLookup;", "public")]
public partial class DefaultLookup
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultLookup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/DefaultLookup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_LOOKUP_KEY", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "currentDefaultThread", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "currentDefaultLookup", "Lsun/swing/DefaultLookup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "isLookupSet", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBoolean", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBoolean", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefault", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDefaultLookup", "(Lsun/swing/DefaultLookup;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInsets", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljava/awt/Insets;)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInsets", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBorder", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBorder", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljavax/swing/border/Border;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIcon", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIcon", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getColor", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljava/awt/Color;)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getColor", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/awt/Color;"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object DEFAULT_LOOKUP_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private static")]
	public static Dova.JDK.java.lang.Thread currentDefaultThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/DefaultLookup;", "private static")]
	public static Dova.JDK.sun.swing.DefaultLookup currentDefaultLookup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.DefaultLookup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool isLookupSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultLookup(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultLookup() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/swing/DefaultLookup;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object get(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Z", "public static")]
	public static bool getBoolean(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Z)Z", "public static")]
	public static bool getBoolean(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)I", "public static")]
	public static int getInt(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;I)I", "public static")]
	public static int getInt(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDefault(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/DefaultLookup;)V", "public static")]
	public static void setDefaultLookup(Dova.JDK.sun.swing.DefaultLookup arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljava/awt/Insets;)Ljava/awt/Insets;", "public static")]
	public static Dova.JDK.java.awt.Insets getInsets(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.awt.Insets arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/awt/Insets;", "public static")]
	public static Dova.JDK.java.awt.Insets getInsets(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border getBorder(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljavax/swing/border/Border;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border getBorder(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.border.Border arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;Ljava/awt/Color;)Ljava/awt/Color;", "public static")]
	public static Dova.JDK.java.awt.Color getColor(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.awt.Color arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/ComponentUI;Ljava/lang/String;)Ljava/awt/Color;", "public static")]
	public static Dova.JDK.java.awt.Color getColor(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.ComponentUI arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}
}
