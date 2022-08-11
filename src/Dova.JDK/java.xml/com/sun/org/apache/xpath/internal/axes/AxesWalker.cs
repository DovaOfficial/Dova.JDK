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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.axes;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "public")]
public partial class AxesWalker
	: Dova.JDK.com.sun.org.apache.xpath.@internal.axes.PredicatedNodeTest
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.com.sun.org.apache.xpath.@internal.axes.PathComponent
	, Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AxesWalker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_dtm", "Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_root", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_currentNode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_isFresh", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_nextWalker", "Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_prevWalker", "Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_axis", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_traverser", "Lcom/sun/org/apache/xml/internal/dtm/DTMAxisTraverser;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xpath/internal/axes/LocPathIterator;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lcom/sun/org/apache/xpath/internal/compiler/Compiler;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deepEquals", "(Lcom/sun/org/apache/xpath/internal/Expression;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextNode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wi", "()Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAxis", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDTM", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentNode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRoot", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocOrdered", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnalysisBits", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpression", "(Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextNode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastPos", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnNextNode", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callVisitors", "(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findClone", "(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;Ljava/util/List;)Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneDeep", "(Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;Ljava/util/List;)Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNextWalker", "(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrevWalker", "(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextWalker", "()Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrevWalker", "()Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultDTM", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression", "()Lcom/sun/org/apache/xpath/internal/Expression;"));
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTM;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM m_dtm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "transient")]
	public int m_root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private transient")]
	public int m_currentNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "transient")]
	public bool m_isFresh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker m_nextWalker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker m_prevWalker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int m_axis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTMAxisTraverser;", "protected")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisTraverser m_traverser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisTraverser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AxesWalker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/LocPathIterator;I)V", "public")]
	public AxesWalker(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.LocPathIterator arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/compiler/Compiler;II)V", "public")]
	public void init(Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.Compiler arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRoot()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)Z", "public")]
	public bool deepEquals(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int nextNode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;", "public final")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.WalkingIterator wi()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.WalkingIterator>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void detach()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAxis()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTM;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM getDTM(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getCurrentNode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRoot(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDocOrdered()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAnalysisBits()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)V", "public")]
	public void setExpression(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getNextNode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)I", "public")]
	public int getLastPos(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int returnNextNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V", "public")]
	public void callVisitors(Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPathVisitor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;Ljava/util/List;)Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker findClone(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/WalkingIterator;Ljava/util/List;)Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker cloneDeep(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.WalkingIterator arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;)V", "public")]
	public void setNextWalker(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;)V", "public")]
	public void setPrevWalker(Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker getNextWalker()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/axes/AxesWalker;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker getPrevWalker()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.axes.AxesWalker>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;)V", "public")]
	public void setDefaultDTM(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression getExpression()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}
}
