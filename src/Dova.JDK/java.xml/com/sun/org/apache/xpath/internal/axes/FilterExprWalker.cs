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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.axes;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;", "public")]
public partial class FilterExprWalker
	: Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FilterExprWalker()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_expr", "Lcom/sun/org/apache/xpath/internal/Expression;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_exprObj", "Lcom/sun/org/apache/xpath/internal/objects/XNodeSet;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_mustHardReset", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_canDetachNodeset", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FilterExprWalker", "(Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Lcom/sun/org/apache/xpath/internal/compiler/Compiler;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "deepEquals", "(Lcom/sun/org/apache/xpath/internal/Expression;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "detach", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAxis", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fixupVariables", "(Ljava/util/List;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "acceptNode", "(I)S"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRoot", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isDocOrdered", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAnalysisBits", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNextNode", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLastPos", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "callPredicateVisitors", "(Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInnerExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setInnerExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/Expression;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression m_expr_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/objects/XNodeSet;", "private transient")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XNodeSet m_exprObj_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XNodeSet>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool m_mustHardReset_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool m_canDetachNodeset_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FilterExprWalker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;)V", "public")]
	public FilterExprWalker(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.WalkingIterator arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/compiler/Compiler;II)V", "public")]
	public void init(Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.Compiler arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)Z", "public")]
	public bool deepEquals(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void detach()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAxis()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;I)V", "public")]
	public void fixupVariables(Dova.JDK.java.util.List arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short acceptNode(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRoot(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDocOrdered()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAnalysisBits()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNextNode()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)I", "public")]
	public int getLastPos(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V", "public")]
	public void callPredicateVisitors(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathVisitor arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getInnerExpression()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
	public void setInnerExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker$filterExprOwner;", "")]
	public partial class filterExprOwner
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static filterExprOwner()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker$filterExprOwner;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "filterExprOwner", "(Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;", "final")]
		public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.FilterExprWalker this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.FilterExprWalker>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public filterExprOwner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker;)V", "")]
		public filterExprOwner(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.FilterExprWalker arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/axes/FilterExprWalker$filterExprOwner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
		public void setExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
		public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getExpression()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
		}
	}
}