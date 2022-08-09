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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.commons;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;", "public")]
public partial class JSRInlinerAdapter
	: Dova.JDK.jdk.@internal.org.objectweb.asm.tree.MethodNode
	, Dova.JDK.jdk.@internal.org.objectweb.asm.Opcodes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JSRInlinerAdapter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mainSubroutineInsns", "Ljava/util/BitSet;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "subroutinesInsns", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "sharedSubroutineInsns", "Ljava/util/BitSet;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JSRInlinerAdapter", "(Ljdk/internal/org/objectweb/asm/MethodVisitor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JSRInlinerAdapter", "(ILjdk/internal/org/objectweb/asm/MethodVisitor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitJumpInsn", "(ILjdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findSubroutinesInsns", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "emitCode", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findSubroutineInsns", "(ILjava/util/BitSet;Ljava/util/BitSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findReachableInsns", "(ILjava/util/BitSet;Ljava/util/BitSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "emitInstantiation", "(Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;Ljava/util/List;Ljdk/internal/org/objectweb/asm/tree/InsnList;Ljava/util/List;Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("Ljava/util/BitSet;", "private final")]
	public Dova.JDK.java.util.BitSet mainSubroutineInsns_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map subroutinesInsns_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/BitSet;", "final")]
	public Dova.JDK.java.util.BitSet sharedSubroutineInsns_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JSRInlinerAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/MethodVisitor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
	public JSRInlinerAdapter(Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/MethodVisitor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "protected")]
	public JSRInlinerAdapter(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, JavaArray<Dova.JDK.java.lang.String> arg6) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void visitJumpInsn(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void findSubroutinesInsns()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void emitCode()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(ILjava/util/BitSet;Ljava/util/BitSet;)V", "private")]
	public void findSubroutineInsns(int arg0, Dova.JDK.java.util.BitSet arg1, Dova.JDK.java.util.BitSet arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/util/BitSet;Ljava/util/BitSet;)V", "private")]
	public void findReachableInsns(int arg0, Dova.JDK.java.util.BitSet arg1, Dova.JDK.java.util.BitSet arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;Ljava/util/List;Ljdk/internal/org/objectweb/asm/tree/InsnList;Ljava/util/List;Ljava/util/List;)V", "private")]
	public void emitInstantiation(Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation arg0, Dova.JDK.java.util.List arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.InsnList arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;", "private")]
	public partial class Instantiation
		: Dova.JDK.java.util.AbstractMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Instantiation()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "parent", "Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "subroutineInsns", "Ljava/util/BitSet;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "clonedLabels", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "returnLabel", "Ljdk/internal/org/objectweb/asm/tree/LabelNode;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Instantiation", "(Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;Ljava/util/BitSet;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_0", "(Ljava/lang/Object;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_1", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "entrySet", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClonedLabel", "(Ljdk/internal/org/objectweb/asm/tree/LabelNode;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findOwner", "(I)Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClonedLabelForJumpInsn", "(Ljdk/internal/org/objectweb/asm/tree/LabelNode;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;", "final")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation parent_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/BitSet;", "final")]
		public Dova.JDK.java.util.BitSet subroutineInsns_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map clonedLabels_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/LabelNode;", "final")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode returnLabel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;", "final")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Instantiation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter;Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;Ljava/util/BitSet;)V", "")]
		public Instantiation(Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation arg1, Dova.JDK.java.util.BitSet arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;", "public")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode get_0(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_1(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set entrySet()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/LabelNode;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;", "")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode getClonedLabel(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode>(ret);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/org/objectweb/asm/commons/JSRInlinerAdapter$Instantiation;", "")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation findOwner(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.commons.JSRInlinerAdapter.Instantiation>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/LabelNode;)Ljdk/internal/org/objectweb/asm/tree/LabelNode;", "")]
		public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode getClonedLabelForJumpInsn(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.LabelNode>(ret);
		}
	}
}