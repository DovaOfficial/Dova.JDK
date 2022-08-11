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

[JniSignatureAttribute("Ljavax/swing/LayoutStyle;", "public abstract")]
public partial class LayoutStyle
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LayoutStyle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/LayoutStyle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Ljavax/swing/LayoutStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredGap", "(Ljavax/swing/JComponent;Ljavax/swing/JComponent;Ljavax/swing/LayoutStyle$ComponentPlacement;ILjava/awt/Container;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContainerGap", "(Ljavax/swing/JComponent;ILjava/awt/Container;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setInstance", "(Ljavax/swing/LayoutStyle;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LayoutStyle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LayoutStyle() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/LayoutStyle;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/LayoutStyle;", "public static")]
	public static Dova.JDK.javax.swing.LayoutStyle getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.LayoutStyle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/JComponent;Ljavax/swing/LayoutStyle$ComponentPlacement;ILjava/awt/Container;)I", "public abstract")]
	public int getPreferredGap(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.JComponent arg1, Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement arg2, int arg3, Dova.JDK.java.awt.Container arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;ILjava/awt/Container;)I", "public abstract")]
	public int getContainerGap(Dova.JDK.javax.swing.JComponent arg0, int arg1, Dova.JDK.java.awt.Container arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/LayoutStyle;)V", "public static")]
	public static void setInstance(Dova.JDK.javax.swing.LayoutStyle arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static final")]
	public partial class ComponentPlacement
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComponentPlacement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/LayoutStyle$ComponentPlacement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RELATED", "Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRELATED", "Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDENT", "Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/swing/LayoutStyle$ComponentPlacement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/swing/LayoutStyle$ComponentPlacement;"));
		}

		[JniSignatureAttribute("Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static final")]
		public static Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement RELATED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static final")]
		public static Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement UNRELATED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static final")]
		public static Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement INDENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/swing/LayoutStyle$ComponentPlacement;", "private static final")]
		public static JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComponentPlacement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ComponentPlacement(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/LayoutStyle$ComponentPlacement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static")]
		public static JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/LayoutStyle$ComponentPlacement;", "public static")]
		public static Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/LayoutStyle$ComponentPlacement;", "private static")]
		public static JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.LayoutStyle.ComponentPlacement>>(ret);
		}
	}
}
