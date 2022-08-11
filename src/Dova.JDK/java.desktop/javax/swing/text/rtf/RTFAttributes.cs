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

namespace Dova.JDK.javax.swing.text.rtf;

[JniSignatureAttribute("Ljavax/swing/text/rtf/RTFAttributes;", "")]
public partial class RTFAttributes
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RTFAttributes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/rtf/RTFAttributes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "attributes", "[Ljavax/swing/text/rtf/RTFAttribute;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "attributesByKeyword", "()Ljava/util/Dictionary;"));
	}

	[JniSignatureAttribute("[Ljavax/swing/text/rtf/RTFAttribute;", "static")]
	public static JavaArray<Dova.JDK.javax.swing.text.rtf.RTFAttribute> attributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.rtf.RTFAttribute>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RTFAttributes(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public RTFAttributes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/rtf/RTFAttributes;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Dictionary;", "static")]
	public static Dova.JDK.java.util.Dictionary attributesByKeyword()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Dictionary>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/rtf/RTFAttributes$BooleanAttribute;", "static")]
	public partial class BooleanAttribute
		: Dova.JDK.javax.swing.text.rtf.RTFAttributes.GenericAttribute
		, Dova.JDK.javax.swing.text.rtf.RTFAttribute
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BooleanAttribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/rtf/RTFAttributes$BooleanAttribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rtfDefault", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "swingDefault", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "True", "Ljava/lang/Boolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "False", "Ljava/lang/Boolean;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;ZZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefault", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeValue", "(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool rtfDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool swingDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Boolean;", "protected static final")]
		public static Dova.JDK.java.lang.Boolean True_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Boolean;", "protected static final")]
		public static Dova.JDK.java.lang.Boolean False_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BooleanAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;ZZ)V", "public")]
		public BooleanAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;)V", "public")]
		public BooleanAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/rtf/RTFAttributes$BooleanAttribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;I)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool setDefault(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z", "public")]
		public bool writeValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.rtf.RTFGenerator arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;", "static")]
	public partial class NumericAttribute
		: Dova.JDK.javax.swing.text.rtf.RTFAttributes.GenericAttribute
		, Dova.JDK.javax.swing.text.rtf.RTFAttribute
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumericAttribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rtfDefault", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "swingDefault", "Ljava/lang/Number;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scale", "F"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Number;IF)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefault", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeValue", "(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NewTwips", "(ILjava/lang/Object;Ljava/lang/String;FI)Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NewTwips", "(ILjava/lang/Object;Ljava/lang/String;I)Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;"));
		}

		[JniSignatureAttribute("I", "")]
		public int rtfDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Number;", "")]
		public Dova.JDK.java.lang.Number swingDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "")]
		public float scale_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumericAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Number;IF)V", "public")]
		public NumericAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Number arg3, int arg4, float arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;II)V", "public")]
		public NumericAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;)V", "protected")]
		public NumericAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;I)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool setDefault(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z", "public")]
		public bool writeValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.rtf.RTFGenerator arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;FI)Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;", "public static")]
		public static Dova.JDK.javax.swing.text.rtf.RTFAttributes.NumericAttribute NewTwips(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, float arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.rtf.RTFAttributes.NumericAttribute>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;I)Ljavax/swing/text/rtf/RTFAttributes$NumericAttribute;", "public static")]
		public static Dova.JDK.javax.swing.text.rtf.RTFAttributes.NumericAttribute NewTwips(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.rtf.RTFAttributes.NumericAttribute>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/rtf/RTFAttributes$AssertiveAttribute;", "static")]
	public partial class AssertiveAttribute
		: Dova.JDK.javax.swing.text.rtf.RTFAttributes.GenericAttribute
		, Dova.JDK.javax.swing.text.rtf.RTFAttribute
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AssertiveAttribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/rtf/RTFAttributes$AssertiveAttribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "swingValue", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefault", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeValue", "(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object swingValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AssertiveAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;I)V", "public")]
		public AssertiveAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V", "public")]
		public AssertiveAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Object arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;)V", "public")]
		public AssertiveAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/rtf/RTFAttributes$AssertiveAttribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;I)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "public")]
		public bool setDefault(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z", "public")]
		public bool writeValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.rtf.RTFGenerator arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/rtf/RTFAttributes$GenericAttribute;", "abstract static")]
	public partial class GenericAttribute
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GenericAttribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/rtf/RTFAttributes$GenericAttribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "domain", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "swingName", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rtfName", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/rtf/RTFGenerator;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "domain", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefault", "(Ljavax/swing/text/MutableAttributeSet;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeValue", "(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rtfName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "swingName", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("I", "")]
		public int domain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object swingName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String rtfName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GenericAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/Object;Ljava/lang/String;)V", "protected")]
		public GenericAttribute(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/rtf/RTFAttributes$GenericAttribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;I)Z", "abstract")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "abstract")]
		public bool set(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/rtf/RTFGenerator;Z)Z", "public")]
		public bool write(Dova.JDK.javax.swing.text.AttributeSet arg0, Dova.JDK.javax.swing.text.rtf.RTFGenerator arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int domain()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/MutableAttributeSet;)Z", "abstract")]
		public bool setDefault(Dova.JDK.javax.swing.text.MutableAttributeSet arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/text/rtf/RTFGenerator;Z)Z", "public")]
		public bool writeValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.text.rtf.RTFGenerator arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String rtfName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object swingName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
