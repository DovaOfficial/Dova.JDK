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

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/Query;", "public")]
public partial class Query
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Query()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/Query;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINUS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TIMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIV", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(J)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(I)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(Ljava/lang/Number;)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(Ljava/lang/String;)Ljavax/management/StringValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(F)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(D)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "value", "(Z)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "match", "(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "in", "(Ljavax/management/ValueExp;[Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "attr", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/management/AttributeValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "attr", "(Ljava/lang/String;)Ljavax/management/AttributeValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lt", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "or", "(Ljavax/management/QueryExp;Ljavax/management/QueryExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "between", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "and", "(Ljavax/management/QueryExp;Ljavax/management/QueryExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "not", "(Ljavax/management/QueryExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "minus", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "plus", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "div", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "times", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "geq", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "leq", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classattr", "()Ljavax/management/AttributeValueExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initialSubString", "(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anySubString", "(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "finalSubString", "(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "escapeString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "gt", "(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int GT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int GE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int EQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PLUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MINUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TIMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Query(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Query() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/Query;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Number;)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(Dova.JDK.java.lang.Number arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/management/StringValueExp;", "public static")]
	public static Dova.JDK.javax.management.StringValueExp value(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.StringValueExp>(ret);
	}

	[JniSignatureAttribute("(F)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(float arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(D)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Z)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp value(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp match(Dova.JDK.javax.management.AttributeValueExp arg0, Dova.JDK.javax.management.StringValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;[Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp @in(Dova.JDK.javax.management.ValueExp arg0, JavaArray<Dova.JDK.javax.management.ValueExp> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/management/AttributeValueExp;", "public static")]
	public static Dova.JDK.javax.management.AttributeValueExp attr(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/management/AttributeValueExp;", "public static")]
	public static Dova.JDK.javax.management.AttributeValueExp attr(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp eq(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp lt(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/QueryExp;Ljavax/management/QueryExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp or(Dova.JDK.javax.management.QueryExp arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp between(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1, Dova.JDK.javax.management.ValueExp arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/QueryExp;Ljavax/management/QueryExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp and(Dova.JDK.javax.management.QueryExp arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/QueryExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp not(Dova.JDK.javax.management.QueryExp arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp minus(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp plus(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp div(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/ValueExp;", "public static")]
	public static Dova.JDK.javax.management.ValueExp times(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp isInstanceOf(Dova.JDK.javax.management.StringValueExp arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp geq(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp leq(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/AttributeValueExp;", "public static")]
	public static Dova.JDK.javax.management.AttributeValueExp classattr()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.AttributeValueExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp initialSubString(Dova.JDK.javax.management.AttributeValueExp arg0, Dova.JDK.javax.management.StringValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp anySubString(Dova.JDK.javax.management.AttributeValueExp arg0, Dova.JDK.javax.management.StringValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/AttributeValueExp;Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp finalSubString(Dova.JDK.javax.management.AttributeValueExp arg0, Dova.JDK.javax.management.StringValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String escapeString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ValueExp;Ljavax/management/ValueExp;)Ljavax/management/QueryExp;", "public static")]
	public static Dova.JDK.javax.management.QueryExp gt(Dova.JDK.javax.management.ValueExp arg0, Dova.JDK.javax.management.ValueExp arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
	}
}
