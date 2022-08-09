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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/Analyzer;", "public")]
public partial class Analyzer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.org.objectweb.asm.Opcodes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Analyzer()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/analysis/Analyzer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "interpreter", "Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "insnList", "Ljdk/internal/org/objectweb/asm/tree/InsnList;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "insnListSize", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "handlers", "[Ljava/util/List;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "frames", "[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "subroutines", "[Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "inInstructionsToProcess", "[Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "instructionsToProcess", "[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "numInstructionsToProcess", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Analyzer", "(Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "merge", "(ILjdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "merge", "(ILjdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;[Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getHandlers", "(I)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFrames", "()[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findSubroutine", "(ILjdk/internal/org/objectweb/asm/tree/analysis/Subroutine;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeInitialFrame", "(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newControlFlowEdge", "(II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newControlFlowExceptionEdge", "(ILjdk/internal/org/objectweb/asm/tree/TryCatchBlockNode;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newControlFlowExceptionEdge", "(II)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newFrame", "(II)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newFrame", "(Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "analyze", "(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Interpreter interpreter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Interpreter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/InsnList;", "private")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.InsnList insnList_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.InsnList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int insnListSize_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("[Ljava/util/List;", "private")]
	public JavaArray<Dova.JDK.java.util.List> handlers_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.List>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "private")]
	public JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame> frames_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;", "private")]
	public JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Subroutine> subroutines_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Subroutine>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> inInstructionsToProcess_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> instructionsToProcess_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int numInstructionsToProcess_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Analyzer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;)V", "public")]
	public Analyzer(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Interpreter arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/analysis/Analyzer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;)V", "private")]
	public void merge(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Subroutine arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/tree/analysis/Subroutine;[Z)V", "private")]
	public void merge(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Subroutine arg3, JavaArray<bool> arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)V", "protected")]
	public void init(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.MethodNode arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getHandlers(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "public")]
	public JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame> getFrames()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>>(ret);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/tree/analysis/Subroutine;Ljava/util/List;)V", "private")]
	public void findSubroutine(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Subroutine arg1, Dova.JDK.java.util.List arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "private")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame computeInitialFrame(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.MethodNode arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void newControlFlowEdge(int arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/tree/TryCatchBlockNode;)Z", "protected")]
	public bool newControlFlowExceptionEdge(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.TryCatchBlockNode arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "protected")]
	public bool newControlFlowExceptionEdge(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "protected")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame newFrame(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;)Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "protected")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame newFrame(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/org/objectweb/asm/tree/MethodNode;)[Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;", "public")]
	public JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame> analyze(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.MethodNode arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame>>(ret);
	}
}
