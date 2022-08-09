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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/BalancedDTDGrammar;", "final")]
public partial class BalancedDTDGrammar
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.DTDGrammar
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BalancedDTDGrammar()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dtd/BalancedDTDGrammar;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fMixed", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fDepth", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fOpStack", "[S"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fGroupIndexStack", "[[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fGroupIndexStackSizes", "[I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BalancedDTDGrammar", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDDescription;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "separator", "(SLcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "element", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initializeContentModelStacks", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addToCurrentGroup", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addContentSpecNodes", "(II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "startContentModel", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "startGroup", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pcdata", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "occurrence", "(SLcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "endGroup", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addContentSpecToElement", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLElementDecl;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "endDTD", "(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fMixed_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int fDepth_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("[S", "private")]
	public JavaArray<short> fOpStack_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[[I", "private")]
	public JavaArray<JavaArray<int>> fGroupIndexStack_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> fGroupIndexStackSizes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BalancedDTDGrammar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDDescription;)V", "public")]
	public BalancedDTDGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDDescription arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dtd/BalancedDTDGrammar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(SLcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void separator(short arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void element(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initializeContentModelStacks()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void addToCurrentGroup(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int addContentSpecNodes(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void startContentModel(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void startGroup(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void pcdata(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(SLcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void occurrence(short arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void endGroup(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLElementDecl;)V", "protected final")]
	public void addContentSpecToElement(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLElementDecl arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "public final")]
	public void endDTD(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}
}