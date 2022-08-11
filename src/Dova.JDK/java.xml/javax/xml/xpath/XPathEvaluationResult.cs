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

namespace Dova.JDK.javax.xml.xpath;

[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult;", "public abstract interface")]
public partial interface XPathEvaluationResult
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathEvaluationResult()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/xpath/XPathEvaluationResult;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("()Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public abstract")]
	Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType type()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object value()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
	public partial class XPathResultType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XPathResultType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANY", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NUMBER", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NODESET", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NODE", "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qnameType", "Ljavax/xml/namespace/QName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clsType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjavax/xml/namespace/QName;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getQNameType", "(Ljava/lang/Class;)Ljavax/xml/namespace/QName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAcceptedNumberSubType", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsClassType", "(Ljava/lang/Class;)Z"));
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType ANY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType NODESET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static final")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType NODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/namespace/QName;", "final")]
		public Dova.JDK.javax.xml.@namespace.QName qnameType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "final")]
		public Dova.JDK.java.lang.Class clsType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "private static final")]
		public static JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XPathResultType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjavax/xml/namespace/QName;Ljava/lang/Class;)V", "private")]
		public XPathResultType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.javax.xml.@namespace.QName arg2, Dova.JDK.java.lang.Class arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static")]
		public static JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "public static")]
		public static Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", "private static")]
		public static JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.xml.xpath.XPathEvaluationResult.XPathResultType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/xml/namespace/QName;", "public static")]
		public static Dova.JDK.javax.xml.@namespace.QName getQNameType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
		public bool isAcceptedNumberSubType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
		public bool equalsClassType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}
	}
}
