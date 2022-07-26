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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/BorderFactory;", "public")]
public partial class BorderFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BorderFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/BorderFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedRaisedBevel", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedLoweredBevel", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedSoftRaisedBevel", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedSoftLoweredBevel", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedEtchedBorder", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedRaisedEtchedBorder", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "emptyBorder", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedDashedBorder", "Ljavax/swing/border/Border;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSharedBevel", "(I)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRaisedSoftBevelBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLoweredSoftBevelBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDashedBorder", "(Ljava/awt/Paint;FFFZ)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDashedBorder", "(Ljava/awt/Paint;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDashedBorder", "(Ljava/awt/Paint;FF)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createStrokeBorder", "(Ljava/awt/BasicStroke;Ljava/awt/Paint;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createStrokeBorder", "(Ljava/awt/BasicStroke;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLineBorder", "(Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLineBorder", "(Ljava/awt/Color;IZ)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLineBorder", "(Ljava/awt/Color;I)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRaisedBevelBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLoweredBevelBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createBevelBorder", "(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createBevelBorder", "(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createBevelBorder", "(I)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSoftBevelBorder", "(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSoftBevelBorder", "(I)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSoftBevelBorder", "(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEtchedBorder", "(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEtchedBorder", "(I)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEtchedBorder", "(Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEtchedBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljava/lang/String;)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljavax/swing/border/Border;)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljavax/swing/border/Border;Ljava/lang/String;IILjava/awt/Font;)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljavax/swing/border/Border;Ljava/lang/String;II)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljavax/swing/border/Border;Ljava/lang/String;IILjava/awt/Font;Ljava/awt/Color;)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTitledBorder", "(Ljavax/swing/border/Border;Ljava/lang/String;)Ljavax/swing/border/TitledBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEmptyBorder", "(IIII)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEmptyBorder", "()Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createCompoundBorder", "(Ljavax/swing/border/Border;Ljavax/swing/border/Border;)Ljavax/swing/border/CompoundBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createCompoundBorder", "()Ljavax/swing/border/CompoundBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createMatteBorder", "(IIIILjavax/swing/Icon;)Ljavax/swing/border/MatteBorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createMatteBorder", "(IIIILjava/awt/Color;)Ljavax/swing/border/MatteBorder;"));
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "static final")]
	public static Dova.JDK.javax.swing.border.Border sharedRaisedBevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "static final")]
	public static Dova.JDK.javax.swing.border.Border sharedLoweredBevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static")]
	public static Dova.JDK.javax.swing.border.Border sharedSoftRaisedBevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static")]
	public static Dova.JDK.javax.swing.border.Border sharedSoftLoweredBevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "static final")]
	public static Dova.JDK.javax.swing.border.Border sharedEtchedBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static")]
	public static Dova.JDK.javax.swing.border.Border sharedRaisedEtchedBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "static final")]
	public static Dova.JDK.javax.swing.border.Border emptyBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static")]
	public static Dova.JDK.javax.swing.border.Border sharedDashedBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BorderFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public BorderFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/BorderFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljavax/swing/border/Border;", "static")]
	public static Dova.JDK.javax.swing.border.Border createSharedBevel(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createRaisedSoftBevelBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createLoweredSoftBevelBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Paint;FFFZ)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createDashedBorder(Dova.JDK.java.awt.Paint arg0, float arg1, float arg2, float arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Paint;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createDashedBorder(Dova.JDK.java.awt.Paint arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Paint;FF)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createDashedBorder(Dova.JDK.java.awt.Paint arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/BasicStroke;Ljava/awt/Paint;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createStrokeBorder(Dova.JDK.java.awt.BasicStroke arg0, Dova.JDK.java.awt.Paint arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/BasicStroke;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createStrokeBorder(Dova.JDK.java.awt.BasicStroke arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createLineBorder(Dova.JDK.java.awt.Color arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;IZ)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createLineBorder(Dova.JDK.java.awt.Color arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;I)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createLineBorder(Dova.JDK.java.awt.Color arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createRaisedBevelBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createLoweredBevelBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.Color arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createBevelBorder(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createSoftBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createSoftBevelBorder(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createSoftBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.Color arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEtchedBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEtchedBorder(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;Ljava/awt/Color;)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEtchedBorder(Dova.JDK.java.awt.Color arg0, Dova.JDK.java.awt.Color arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEtchedBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.javax.swing.border.Border arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;Ljava/lang/String;IILjava/awt/Font;)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.javax.swing.border.Border arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, Dova.JDK.java.awt.Font arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;Ljava/lang/String;II)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.javax.swing.border.Border arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;Ljava/lang/String;IILjava/awt/Font;Ljava/awt/Color;)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.javax.swing.border.Border arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, Dova.JDK.java.awt.Font arg4, Dova.JDK.java.awt.Color arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;Ljava/lang/String;)Ljavax/swing/border/TitledBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.TitledBorder createTitledBorder(Dova.JDK.javax.swing.border.Border arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.TitledBorder>(ret);
	}

	[JniSignatureAttribute("(IIII)Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEmptyBorder(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/Border;", "public static")]
	public static Dova.JDK.javax.swing.border.Border createEmptyBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/border/Border;Ljavax/swing/border/Border;)Ljavax/swing/border/CompoundBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.CompoundBorder createCompoundBorder(Dova.JDK.javax.swing.border.Border arg0, Dova.JDK.javax.swing.border.Border arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.CompoundBorder>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/border/CompoundBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.CompoundBorder createCompoundBorder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.CompoundBorder>(ret);
	}

	[JniSignatureAttribute("(IIIILjavax/swing/Icon;)Ljavax/swing/border/MatteBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.MatteBorder createMatteBorder(int arg0, int arg1, int arg2, int arg3, Dova.JDK.javax.swing.Icon arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.MatteBorder>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Color;)Ljavax/swing/border/MatteBorder;", "public static")]
	public static Dova.JDK.javax.swing.border.MatteBorder createMatteBorder(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.MatteBorder>(ret);
	}
}
