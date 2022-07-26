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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/ModuleGraphBuilder;", "public")]
public partial class ModuleGraphBuilder
	: Dova.JDK.com.sun.tools.jdeps.Graph.Builder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleGraphBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ModuleGraphBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "config", "Lcom/sun/tools/jdeps/JdepsConfiguration;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Lcom/sun/tools/jdeps/Graph;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requiresTransitive", "(Lcom/sun/tools/jdeps/Module;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduced", "()Lcom/sun/tools/jdeps/Graph;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModule", "(Lcom/sun/tools/jdeps/Module;)Lcom/sun/tools/jdeps/ModuleGraphBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNodes", "(Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addEdge", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNode", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildGraph", "(Ljava/util/Map;)Lcom/sun/tools/jdeps/Graph;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildGraph", "()Lcom/sun/tools/jdeps/Graph;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration;", "final")]
	public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration config_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModuleGraphBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsConfiguration;)V", "")]
	public ModuleGraphBuilder(Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ModuleGraphBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Graph;", "public volatile")]
	public Dova.JDK.com.sun.tools.jdeps.Graph build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Graph>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Module;)Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream requiresTransitive(Dova.JDK.com.sun.tools.jdeps.Module arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Graph;", "public")]
	public Dova.JDK.com.sun.tools.jdeps.Graph reduced()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Graph>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Module;)Lcom/sun/tools/jdeps/ModuleGraphBuilder;", "")]
	public Dova.JDK.com.sun.tools.jdeps.ModuleGraphBuilder addModule(Dova.JDK.com.sun.tools.jdeps.Module arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ModuleGraphBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)V", "public volatile")]
	public void addNodes(Dova.JDK.java.util.Set arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public volatile")]
	public void addEdge(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
	public void addNode(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Lcom/sun/tools/jdeps/Graph;", "private")]
	public Dova.JDK.com.sun.tools.jdeps.Graph buildGraph(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Graph>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Graph;", "public")]
	public Dova.JDK.com.sun.tools.jdeps.Graph buildGraph()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Graph>(ret);
	}
}
