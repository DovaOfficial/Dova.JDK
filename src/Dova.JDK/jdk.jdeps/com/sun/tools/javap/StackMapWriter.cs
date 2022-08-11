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

namespace Dova.JDK.com.sun.tools.javap;

[JniSignatureAttribute("Lcom/sun/tools/javap/StackMapWriter;", "public")]
public partial class StackMapWriter
	: Dova.JDK.com.sun.tools.javap.InstructionDetailWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StackMapWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/StackMapWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "map", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriter", "Lcom/sun/tools/javap/ClassWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "empty", "[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javap/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/lang/String;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/tools/classfile/Code_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javap/Context;)Lcom/sun/tools/javap/StackMapWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeDetails", "(Lcom/sun/tools/classfile/Instruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeDetails", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeInitialDetails", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStackMap", "(Lcom/sun/tools/classfile/StackMapTable_attribute;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/ClassWriter;", "private")]
	public Dova.JDK.com.sun.tools.javap.ClassWriter classWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.ClassWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;", "private final")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> empty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StackMapWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javap/Context;)V", "protected")]
	public StackMapWriter(Dova.JDK.com.sun.tools.javap.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/StackMapWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V", "")]
	public void print(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V", "")]
	public void print(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute;)V", "public")]
	public void reset(Dova.JDK.com.sun.tools.classfile.Code_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javap/Context;)Lcom/sun/tools/javap/StackMapWriter;", "static")]
	public static Dova.JDK.com.sun.tools.javap.StackMapWriter instance(Dova.JDK.com.sun.tools.javap.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.StackMapWriter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;)V", "public")]
	public void writeDetails(Dova.JDK.com.sun.tools.classfile.Instruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void writeDetails(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void writeInitialDetails()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute;)V", "")]
	public void setStackMap(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/StackMapWriter$CustomVerificationTypeInfo;", "static")]
	public partial class CustomVerificationTypeInfo
		: Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CustomVerificationTypeInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/StackMapWriter$CustomVerificationTypeInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CustomVerificationTypeInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public CustomVerificationTypeInfo(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/StackMapWriter$CustomVerificationTypeInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/StackMapWriter$StackMapBuilder;", "")]
	public partial class StackMapBuilder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackMapBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/StackMapWriter$StackMapBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javap/StackMapWriter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javap/StackMapWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Integer;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javap/StackMapWriter;", "final")]
		public Dova.JDK.com.sun.tools.javap.StackMapWriter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.StackMapWriter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackMapBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javap/StackMapWriter;)V", "")]
		public StackMapBuilder(Dova.JDK.com.sun.tools.javap.StackMapWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/StackMapWriter$StackMapBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_full_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.full_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_full_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.full_frame arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Integer;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.java.lang.Integer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/StackMapWriter$StackMap;", "static")]
	public partial class StackMap
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/StackMapWriter$StackMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locals", "[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V"));
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;", "private final")]
		public JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> locals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;", "private final")]
		public JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> stack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V", "")]
		public StackMap(JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> arg0, JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/StackMapWriter$StackMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
