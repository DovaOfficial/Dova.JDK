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

namespace Dova.JDK.javax.swing.text.html;

[JniSignatureAttribute("Ljavax/swing/text/html/FormSubmitEvent;", "public")]
public partial class FormSubmitEvent
	: Dova.JDK.javax.swing.text.html.HTMLFrameHyperlinkEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FormSubmitEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/FormSubmitEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/FormSubmitEvent$MethodType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getData", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "private")]
	public Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType method_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FormSubmitEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/FormSubmitEvent$MethodType;Ljava/lang/String;)V", "")]
	public FormSubmitEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.javax.swing.text.Element arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType arg5, Dova.JDK.java.lang.String arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/FormSubmitEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public")]
	public Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType getMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public static final")]
	public partial class MethodType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/FormSubmitEvent$MethodType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET", "Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POST", "Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/swing/text/html/FormSubmitEvent$MethodType;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType GET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType POST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "private static final")]
		public static JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public MethodType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/FormSubmitEvent$MethodType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public static")]
		public static JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "public static")]
		public static Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/text/html/FormSubmitEvent$MethodType;", "private static")]
		public static JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.FormSubmitEvent.MethodType>>(ret);
		}
	}
}
