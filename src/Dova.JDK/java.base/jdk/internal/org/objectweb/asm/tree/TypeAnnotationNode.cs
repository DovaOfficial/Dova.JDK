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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.tree;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/TypeAnnotationNode;", "public")]
public partial class TypeAnnotationNode
	: Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AnnotationNode
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeAnnotationNode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/TypeAnnotationNode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeRef", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljdk/internal/org/objectweb/asm/TypePath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("I", "public")]
	public int typeRef_Property
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

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/TypePath;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.TypePath typePath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.TypePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeAnnotationNode(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;)V", "public")]
	public TypeAnnotationNode(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.TypePath arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(IILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;)V", "public")]
	public TypeAnnotationNode(int arg0, int arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.TypePath arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/TypeAnnotationNode;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
