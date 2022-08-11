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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.patterns;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;", "public")]
public partial class StepPattern
	: Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.NodeTest
	, Dova.JDK.com.sun.org.apache.xpath.@internal.axes.SubContextList
	, Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StepPattern()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_axis", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_targetString", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_relativePathPattern", "Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_predicates", "[Lcom/sun/org/apache/xpath/internal/Expression;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_MATCHES", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;Ljava/lang/String;II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Lcom/sun/org/apache/xpath/internal/XPathContext;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Lcom/sun/org/apache/xpath/internal/XPathContext;ILcom/sun/org/apache/xml/internal/dtm/DTM;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deepEquals", "(Lcom/sun/org/apache/xpath/internal/Expression;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcTargetString", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callSubtreeVisitors", "(Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcScore", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPredicateCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPredicate", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executePredicates", "(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/dtm/DTM;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executeRelativePathPattern", "(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/dtm/DTM;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkProximityPosition", "(Lcom/sun/org/apache/xpath/internal/XPathContext;ILcom/sun/org/apache/xml/internal/dtm/DTM;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRelativePathPattern", "(Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRelativePathPattern", "()Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPredicates", "()[Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPredicates", "([Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAxis", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchScore", "(Lcom/sun/org/apache/xpath/internal/XPathContext;I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixupVariables", "(Ljava/util/List;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callVisitors", "(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canTraverseOutsideSubtree", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastPos", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProximityPosition", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProximityPosition", "(Lcom/sun/org/apache/xpath/internal/XPathContext;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAxis", "()I"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int m_axis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String m_targetString_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern m_relativePathPattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xpath/internal/Expression;", "")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression> m_predicates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_MATCHES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StepPattern(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;II)V", "public")]
	public StepPattern(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(III)V", "public")]
	public StepPattern(int arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject execute(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject execute(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;ILcom/sun/org/apache/xml/internal/dtm/DTM;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject execute(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, int arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)Z", "public")]
	public bool deepEquals(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getExpression()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void calcTargetString()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V", "protected")]
	public void callSubtreeVisitors(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathVisitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void calcScore()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getPredicateCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getPredicate(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/dtm/DTM;I)Z", "protected final")]
	public bool executePredicates(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/dtm/DTM;I)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject executeRelativePathPattern(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;ILcom/sun/org/apache/xml/internal/dtm/DTM;II)Z", "private final")]
	public bool checkProximityPosition(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, int arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTargetString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;)V", "public")]
	public void setRelativePathPattern(Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern getRelativePathPattern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression> getPredicates()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
	public void setPredicates(JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setAxis(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;I)D", "public")]
	public double getMatchScore(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;I)V", "public")]
	public void fixupVariables(Dova.JDK.java.util.List arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V", "public")]
	public void callVisitors(Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPathVisitor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canTraverseOutsideSubtree()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)I", "public")]
	public int getLastPos(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)I", "public")]
	public int getProximityPosition(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;IZ)I", "private final")]
	public int getProximityPosition(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
	public void setExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAxis()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern$PredOwner;", "")]
	public partial class PredOwner
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PredOwner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern$PredOwner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int m_index_Property
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

		[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;", "final")]
		public Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PredOwner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;I)V", "")]
		public PredOwner(Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/patterns/StepPattern$PredOwner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
		public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
		public void setExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
