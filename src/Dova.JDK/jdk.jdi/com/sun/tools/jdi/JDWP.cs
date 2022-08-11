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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP;", "")]
public partial class JDWP
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JDWP()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JDWP(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public JDWP() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$InvokeOptions;", "static")]
	public partial class InvokeOptions
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvokeOptions()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$InvokeOptions;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_SINGLE_THREADED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_NONVIRTUAL", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVOKE_SINGLE_THREADED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVOKE_NONVIRTUAL_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvokeOptions(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public InvokeOptions() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$InvokeOptions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$SuspendPolicy;", "static")]
	public partial class SuspendPolicy
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SuspendPolicy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$SuspendPolicy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EVENT_THREAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NONE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int EVENT_THREAD_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int ALL_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SuspendPolicy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SuspendPolicy() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$SuspendPolicy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StepSize;", "static")]
	public partial class StepSize
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StepSize()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StepSize;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MIN_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int LINE_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StepSize(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StepSize() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StepSize;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StepDepth;", "static")]
	public partial class StepDepth
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StepDepth()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StepDepth;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTO", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OUT", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INTO_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int OVER_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int OUT_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StepDepth(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StepDepth() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StepDepth;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Tag;", "static")]
	public partial class Tag
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Tag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_GROUP", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_LOADER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_OBJECT", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ARRAY_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int BYTE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int CHAR_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int OBJECT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int FLOAT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int DOUBLE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int LONG_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int SHORT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int VOID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_GROUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_LOADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_OBJECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Tag() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Tag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$TypeTag;", "static")]
	public partial class TypeTag
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$TypeTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INTERFACE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int ARRAY_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TypeTag() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$TypeTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassStatus;", "static")]
	public partial class ClassStatus
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassStatus()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassStatus;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERIFIED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREPARED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIALIZED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VERIFIED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int PREPARED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INITIALIZED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int ERROR_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassStatus(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ClassStatus() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassStatus;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$SuspendStatus;", "static")]
	public partial class SuspendStatus
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SuspendStatus()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$SuspendStatus;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUSPEND_STATUS_SUSPENDED", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SUSPEND_STATUS_SUSPENDED_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SuspendStatus(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SuspendStatus() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$SuspendStatus;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadStatus;", "static")]
	public partial class ThreadStatus
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ThreadStatus()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadStatus;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZOMBIE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNNING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLEEPING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WAIT", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ZOMBIE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int RUNNING_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int SLEEPING_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int MONITOR_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int WAIT_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ThreadStatus(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ThreadStatus() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadStatus;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventKind;", "static")]
	public partial class EventKind
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SINGLE_STEP", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAKPOINT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRAME_POP", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEPTION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USER_DEFINED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_START", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_DEATH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_END", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_PREPARE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_UNLOAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_LOAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_ACCESS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_MODIFICATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEPTION_CATCH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_ENTRY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_EXIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_EXIT_WITH_RETURN_VALUE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOR_CONTENDED_ENTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOR_CONTENDED_ENTERED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOR_WAIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOR_WAITED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_START", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_INIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_DEATH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_DISCONNECTED", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SINGLE_STEP_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int BREAKPOINT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int FRAME_POP_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int EXCEPTION_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int USER_DEFINED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_START_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_DEATH_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_END_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_PREPARE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_UNLOAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_LOAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int FIELD_ACCESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int FIELD_MODIFICATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int EXCEPTION_CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int METHOD_ENTRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int METHOD_EXIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int METHOD_EXIT_WITH_RETURN_VALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MONITOR_CONTENDED_ENTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MONITOR_CONTENDED_ENTERED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MONITOR_WAIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MONITOR_WAITED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VM_START_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VM_INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VM_DEATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VM_DISCONNECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EventKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public EventKind() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Error;", "static")]
	public partial class Error
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Error()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Error;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_THREAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_THREAD_GROUP", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_PRIORITY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_NOT_SUSPENDED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_SUSPENDED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD_NOT_ALIVE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_OBJECT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_CLASS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_NOT_PREPARED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_METHODID", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_LOCATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_FIELDID", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_FRAMEID", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_MORE_FRAMES", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPAQUE_FRAME", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_CURRENT_FRAME", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_MISMATCH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_SLOT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUPLICATE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_FOUND", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_MODULE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_MONITOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_MONITOR_OWNER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERRUPT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_CLASS_FORMAT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CIRCULAR_CLASS_DEFINITION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAILS_VERIFICATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_METHOD_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEMA_CHANGE_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_TYPESTATE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIERARCHY_CHANGE_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELETE_METHOD_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSUPPORTED_VERSION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMES_DONT_MATCH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_MODIFIERS_CHANGE_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_MODIFIERS_CHANGE_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_ATTRIBUTE_CHANGE_NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_IMPLEMENTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL_POINTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSENT_INFORMATION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_EVENT_TYPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILLEGAL_ARGUMENT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OUT_OF_MEMORY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_DENIED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_DEAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNATTACHED_THREAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_TAG", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALREADY_INVOKING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_INDEX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_LENGTH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_STRING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_CLASS_LOADER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_ARRAY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSPORT_LOAD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSPORT_INIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_METHOD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_COUNT", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NONE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_THREAD_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_THREAD_GROUP_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_PRIORITY_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_NOT_SUSPENDED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_SUSPENDED_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int THREAD_NOT_ALIVE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_OBJECT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_CLASS_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_NOT_PREPARED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_METHODID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_LOCATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_FIELDID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_FRAMEID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NO_MORE_FRAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int OPAQUE_FRAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NOT_CURRENT_FRAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int TYPE_MISMATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_SLOT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int DUPLICATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NOT_FOUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_MODULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_MONITOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NOT_MONITOR_OWNER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INTERRUPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_CLASS_FORMAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CIRCULAR_CLASS_DEFINITION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int FAILS_VERIFICATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ADD_METHOD_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SCHEMA_CHANGE_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_TYPESTATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int HIERARCHY_CHANGE_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int DELETE_METHOD_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int UNSUPPORTED_VERSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NAMES_DONT_MATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_MODIFIERS_CHANGE_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int METHOD_MODIFIERS_CHANGE_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CLASS_ATTRIBUTE_CHANGE_NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NOT_IMPLEMENTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NULL_POINTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ABSENT_INFORMATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_EVENT_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ILLEGAL_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int OUT_OF_MEMORY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ACCESS_DENIED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int VM_DEAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INTERNAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int UNATTACHED_THREAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_TAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ALREADY_INVOKING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[50]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[50], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[51]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[51], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[52]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[52], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_CLASS_LOADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[53]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[53], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[54]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[54], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int TRANSPORT_LOAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[55]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[55], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int TRANSPORT_INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[56]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[56], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int NATIVE_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[57]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[57], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INVALID_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[58]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[58], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Error(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Error() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Error;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event;", "static")]
	public partial class Event
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Event()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Event(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Event() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite;", "static")]
		public partial class Composite
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Composite()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suspendPolicy", "B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "events", "[Lcom/sun/tools/jdi/JDWP$Event$Composite$Events;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("B", "final")]
			public byte suspendPolicy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$Event$Composite$Events;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events> events_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Composite(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
			public Composite(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events;", "static")]
			public partial class Events
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Events()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventKind", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aEventsCommon", "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$EventsCommon;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte eventKind_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$EventsCommon;", "")]
				public Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon aEventsCommon_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Events(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
				public Events(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMStart;", "static")]
				public partial class VMStart
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static VMStart()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMStart;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public VMStart(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public VMStart(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMStart;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$EventsCommon;", "abstract static")]
				public partial class EventsCommon
					: Dova.JDK.java.lang.Object
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static EventsCommon()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$EventsCommon;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public EventsCommon(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "")]
					public EventsCommon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$EventsCommon;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "abstract")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$SingleStep;", "static")]
				public partial class SingleStep
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static SingleStep()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$SingleStep;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public SingleStep(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public SingleStep(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$SingleStep;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Breakpoint;", "static")]
				public partial class Breakpoint
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Breakpoint()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Breakpoint;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Breakpoint(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public Breakpoint(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Breakpoint;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodEntry;", "static")]
				public partial class MethodEntry
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MethodEntry()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodEntry;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MethodEntry(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MethodEntry(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodEntry;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExit;", "static")]
				public partial class MethodExit
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MethodExit()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExit;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MethodExit(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MethodExit(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExit;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExitWithReturnValue;", "static")]
				public partial class MethodExitWithReturnValue
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MethodExitWithReturnValue()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExitWithReturnValue;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Lcom/sun/tools/jdi/ValueImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ValueImpl value_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MethodExitWithReturnValue(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MethodExitWithReturnValue(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MethodExitWithReturnValue;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEnter;", "static")]
				public partial class MonitorContendedEnter
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MonitorContendedEnter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEnter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MonitorContendedEnter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MonitorContendedEnter(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEnter;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEntered;", "static")]
				public partial class MonitorContendedEntered
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MonitorContendedEntered()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEntered;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MonitorContendedEntered(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MonitorContendedEntered(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorContendedEntered;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWait;", "static")]
				public partial class MonitorWait
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MonitorWait()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWait;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeout", "J"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long timeout_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MonitorWait(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MonitorWait(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWait;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWaited;", "static")]
				public partial class MonitorWaited
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MonitorWaited()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWaited;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timed_out", "Z"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "final")]
					public bool timed_out_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MonitorWaited(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public MonitorWaited(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$MonitorWaited;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Exception;", "static")]
				public partial class Exception
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Exception()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Exception;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exception", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "catchLocation", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl exception_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location catchLocation_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Exception(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public Exception(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$Exception;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadStart;", "static")]
				public partial class ThreadStart
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ThreadStart()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadStart;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ThreadStart(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public ThreadStart(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadStart;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadDeath;", "static")]
				public partial class ThreadDeath
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ThreadDeath()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadDeath;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ThreadDeath(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public ThreadDeath(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ThreadDeath;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassPrepare;", "static")]
				public partial class ClassPrepare
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ClassPrepare()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassPrepare;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("B", "final")]
					public byte refTypeTag_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[3]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[3], value);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long typeID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "final")]
					public Dova.JDK.java.lang.String signature_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int status_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ClassPrepare(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public ClassPrepare(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassPrepare;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassUnload;", "static")]
				public partial class ClassUnload
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ClassUnload()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassUnload;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Ljava/lang/String;", "final")]
					public Dova.JDK.java.lang.String signature_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ClassUnload(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public ClassUnload(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$ClassUnload;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldAccess;", "static")]
				public partial class FieldAccess
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FieldAccess()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldAccess;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("B", "final")]
					public byte refTypeTag_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[4]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[4], value);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long typeID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long fieldID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FieldAccess(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public FieldAccess(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldAccess;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldModification;", "static")]
				public partial class FieldModification
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FieldModification()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldModification;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueToBe", "Lcom/sun/tools/jdi/ValueImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location location_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("B", "final")]
					public byte refTypeTag_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[4]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[4], value);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long typeID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long fieldID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ValueImpl valueToBe_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FieldModification(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public FieldModification(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$FieldModification;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMDeath;", "static")]
				public partial class VMDeath
					: Dova.JDK.com.sun.tools.jdi.JDWP.Event.Composite.Events.EventsCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static VMDeath()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMDeath;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventKind", "()B"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int requestID_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public VMDeath(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public VMDeath(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Event$Composite$Events$VMDeath;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()B", "")]
					public byte eventKind()
					{
						var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}
				}
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ModuleReference;", "static")]
	public partial class ModuleReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ModuleReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ModuleReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ModuleReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;", "static")]
		public partial class ClassLoader
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoader()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassLoader(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.ClassLoader process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ModuleReference$ClassLoader;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.ClassLoader waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;", "static")]
		public partial class Name
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Name()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String name_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Name(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Name(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.Name process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ModuleReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.Name waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ModuleReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ModuleReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassObjectReference;", "static")]
	public partial class ClassObjectReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassObjectReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassObjectReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassObjectReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ClassObjectReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassObjectReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;", "static")]
		public partial class ReflectedType
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReflectedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("B", "final")]
			public byte refTypeTag_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long typeID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReflectedType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ReflectedType(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassObjectReference.ReflectedType process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassObjectReference.ReflectedType>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassObjectReference$ReflectedType;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassObjectReference.ReflectedType waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassObjectReference.ReflectedType>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame;", "static")]
	public partial class StackFrame
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackFrame()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackFrame(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public StackFrame() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;", "static")]
		public partial class PopFrames
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PopFrames()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PopFrames(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public PopFrames(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.PopFrames process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.PopFrames>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$PopFrames;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.PopFrames waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.PopFrames>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;", "static")]
		public partial class ThisObject
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ThisObject()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objectThis", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl objectThis_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ThisObject(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ThisObject(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.ThisObject process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.ThisObject>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$ThisObject;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.ThisObject waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.ThisObject>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;", "static")]
		public partial class SetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;)Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;)Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues.SlotInfo> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.SetValues.SlotInfo> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;", "static")]
			public partial class SlotInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static SlotInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slot", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slotValue", "Lcom/sun/tools/jdi/ValueImpl;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/tools/jdi/ValueImpl;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("I", "final")]
				public int slot_Property
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

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ValueImpl slotValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public SlotInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(ILcom/sun/tools/jdi/ValueImpl;)V", "")]
				public SlotInfo(int arg0, Dova.JDK.com.sun.tools.jdi.ValueImpl arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$SetValues$SlotInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;", "static")]
		public partial class GetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "[Lcom/sun/tools/jdi/ValueImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;)Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> values_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public GetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;)Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues.SlotInfo> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, long arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.StackFrame.GetValues.SlotInfo> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;", "static")]
			public partial class SlotInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static SlotInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slot", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sigbyte", "B"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IB)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("I", "final")]
				public int slot_Property
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

				[JniSignatureAttribute("B", "final")]
				public byte sigbyte_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public SlotInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(IB)V", "")]
				public SlotInfo(int arg0, byte arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StackFrame$GetValues$SlotInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest;", "static")]
	public partial class EventRequest
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventRequest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EventRequest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public EventRequest() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;", "static")]
		public partial class ClearAllBreakpoints
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClearAllBreakpoints()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClearAllBreakpoints(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClearAllBreakpoints(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.ClearAllBreakpoints process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.ClearAllBreakpoints>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$ClearAllBreakpoints;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.ClearAllBreakpoints waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.ClearAllBreakpoints>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;", "static")]
		public partial class Clear
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Clear()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;BI)Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;BI)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Clear(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Clear(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;BI)Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Clear process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, byte arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Clear>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$Clear;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Clear waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Clear>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;BI)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, byte arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set;", "static")]
		public partial class Set
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Set()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestID", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;BB[Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;BB[Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int requestID_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Set(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Set(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;BB[Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, byte arg1, byte arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;BB[Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, byte arg1, byte arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
			public partial class Modifier
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Modifier()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modKind", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aModifierCommon", "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BLcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte modKind_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;", "")]
				public Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon aModifierCommon_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Modifier(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(BLcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;)V", "")]
				public Modifier(byte arg0, Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;", "abstract static")]
				public partial class ModifierCommon
					: Dova.JDK.java.lang.Object
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ModifierCommon()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ModifierCommon(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "")]
					public ModifierCommon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ModifierCommon;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "abstract")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$SourceNameMatch;", "static")]
				public partial class SourceNameMatch
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static SourceNameMatch()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$SourceNameMatch;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceNamePattern", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "final")]
					public Dova.JDK.java.lang.String sourceNamePattern_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public SourceNameMatch(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
					public SourceNameMatch(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$SourceNameMatch;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$InstanceOnly;", "static")]
				public partial class InstanceOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static InstanceOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$InstanceOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instance", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ObjectReferenceImpl;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl instance_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public InstanceOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ObjectReferenceImpl;)V", "")]
					public InstanceOnly(Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$InstanceOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Step;", "static")]
				public partial class Step
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Step()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Step;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;II)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int size_Property
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

					[JniSignatureAttribute("I", "final")]
					public int depth_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Step(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;II)V", "")]
					public Step(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Step;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, int arg1, int arg2)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$FieldOnly;", "static")]
				public partial class FieldOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FieldOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$FieldOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaring", "Lcom/sun/tools/jdi/ReferenceTypeImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;J)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ReferenceTypeImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl declaring_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("J", "final")]
					public long fieldID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FieldOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;J)V", "")]
					public FieldOnly(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$FieldOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0, long arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ExceptionOnly;", "static")]
				public partial class ExceptionOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ExceptionOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ExceptionOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionOrNull", "Lcom/sun/tools/jdi/ReferenceTypeImpl;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caught", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uncaught", "Z"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;ZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;ZZ)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ReferenceTypeImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl exceptionOrNull_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "final")]
					public bool caught_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
						}
					}

					[JniSignatureAttribute("Z", "final")]
					public bool uncaught_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ExceptionOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;ZZ)V", "")]
					public ExceptionOnly(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ExceptionOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;ZZ)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0, bool arg1, bool arg2)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$LocationOnly;", "static")]
				public partial class LocationOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LocationOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$LocationOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loc", "Lcom/sun/jdi/Location;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jdi/Location;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/jdi/Location;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
					public Dova.JDK.com.sun.jdi.Location loc_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LocationOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/jdi/Location;)V", "")]
					public LocationOnly(Dova.JDK.com.sun.jdi.Location arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$LocationOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/jdi/Location;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.jdi.Location arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassExclude;", "static")]
				public partial class ClassExclude
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ClassExclude()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassExclude;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classPattern", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "final")]
					public Dova.JDK.java.lang.String classPattern_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ClassExclude(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
					public ClassExclude(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassExclude;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassMatch;", "static")]
				public partial class ClassMatch
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ClassMatch()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassMatch;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classPattern", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "final")]
					public Dova.JDK.java.lang.String classPattern_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ClassMatch(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
					public ClassMatch(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassMatch;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassOnly;", "static")]
				public partial class ClassOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ClassOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Lcom/sun/tools/jdi/ReferenceTypeImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ReferenceTypeImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl clazz_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ClassOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;)V", "")]
					public ClassOnly(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ClassOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ThreadOnly;", "static")]
				public partial class ThreadOnly
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ThreadOnly()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ThreadOnly;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
					public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl thread_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ThreadOnly(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;)V", "")]
					public ThreadOnly(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$ThreadOnly;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Conditional;", "static")]
				public partial class Conditional
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Conditional()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Conditional;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exprID", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(I)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int exprID_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Conditional(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(I)V", "")]
					public Conditional(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Conditional;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(I)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(int arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Count;", "static")]
				public partial class Count
					: Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier.ModifierCommon
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Count()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Count;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_ID", "B"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(I)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;"));
					}

					[JniSignatureAttribute("B", "static final")]
					public static byte ALT_ID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("I", "final")]
					public int count_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Count(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(I)V", "")]
					public Count(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier$Count;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "")]
					public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("(I)Lcom/sun/tools/jdi/JDWP$EventRequest$Set$Modifier;", "static")]
					public static Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier create(int arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.EventRequest.Set.Modifier>(ret);
					}
				}
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference;", "static")]
	public partial class ClassLoaderReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassLoaderReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassLoaderReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ClassLoaderReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassLoaderReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;", "static")]
		public partial class VisibleClasses
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static VisibleClasses()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "[Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses$ClassInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses$ClassInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses.ClassInfo> classes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses.ClassInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public VisibleClasses(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public VisibleClasses(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassLoaderReference.VisibleClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses$ClassInfo;", "static")]
			public partial class ClassInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ClassInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses$ClassInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte refTypeTag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("J", "final")]
				public long typeID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ClassInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public ClassInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassLoaderReference$VisibleClasses$ClassInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayReference;", "static")]
	public partial class ArrayReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ArrayReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;", "static")]
		public partial class SetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;I[Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;I[Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;I[Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.SetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1, int arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.SetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;I[Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1, int arg2, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;", "static")]
		public partial class GetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;II)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/util/List;", "final")]
			public Dova.JDK.java.util.List values_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public GetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.GetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1, int arg2, int arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.GetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;II)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1, int arg2, int arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;", "static")]
		public partial class Length
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Length()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arrayLength", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int arrayLength_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Length(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Length(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.Length process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.Length>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayReference$Length;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.Length waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayReference.Length>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference;", "static")]
	public partial class ThreadGroupReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ThreadGroupReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ThreadGroupReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ThreadGroupReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadGroupReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;", "static")]
		public partial class Children
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Children()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childThreads", "[Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childGroups", "[Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl> childThreads_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl> childGroups_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Children(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Children(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Children process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Children>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Children;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Children waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Children>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;", "static")]
		public partial class Parent
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Parent()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parentGroup", "Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl parentGroup_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Parent(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Parent(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Parent process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Parent>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Parent;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Parent waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Parent>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;", "static")]
		public partial class Name
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Name()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupName", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String groupName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Name(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Name(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Name process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadGroupReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Name waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadGroupReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference;", "static")]
	public partial class ThreadReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ThreadReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ThreadReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ThreadReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;", "static")]
		public partial class ForceEarlyReturn
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForceEarlyReturn()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForceEarlyReturn(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ForceEarlyReturn(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ForceEarlyReturn process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ValueImpl arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ForceEarlyReturn>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ForceEarlyReturn;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ForceEarlyReturn waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ForceEarlyReturn>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ValueImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ValueImpl arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;", "static")]
		public partial class OwnedMonitorsStackDepthInfo
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OwnedMonitorsStackDepthInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owned", "[Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo$monitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo$monitor;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo.monitor> owned_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo.monitor>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OwnedMonitorsStackDepthInfo(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public OwnedMonitorsStackDepthInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitorsStackDepthInfo>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo$monitor;", "static")]
			public partial class monitor
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static monitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo$monitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "monitor", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack_depth", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl monitor_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int stack_depth_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public monitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public monitor(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitorsStackDepthInfo$monitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;", "static")]
		public partial class SuspendCount
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SuspendCount()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suspendCount", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int suspendCount_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SuspendCount(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SuspendCount(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.SuspendCount process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.SuspendCount>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$SuspendCount;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.SuspendCount waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.SuspendCount>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;", "static")]
		public partial class Interrupt
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Interrupt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Interrupt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Interrupt(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Interrupt process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Interrupt>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Interrupt;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Interrupt waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Interrupt>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;", "static")]
		public partial class Stop
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Stop()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Stop(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Stop(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Stop process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Stop>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Stop;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Stop waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Stop>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;", "static")]
		public partial class CurrentContendedMonitor
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CurrentContendedMonitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "monitor", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl monitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CurrentContendedMonitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public CurrentContendedMonitor(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.CurrentContendedMonitor process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.CurrentContendedMonitor>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$CurrentContendedMonitor;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.CurrentContendedMonitor waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.CurrentContendedMonitor>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;", "static")]
		public partial class OwnedMonitors
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OwnedMonitors()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owned", "[Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl> owned_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OwnedMonitors(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public OwnedMonitors(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitors process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitors>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$OwnedMonitors;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitors waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.OwnedMonitors>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;", "static")]
		public partial class FrameCount
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FrameCount()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameCount", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int frameCount_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FrameCount(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public FrameCount(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.FrameCount process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.FrameCount>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$FrameCount;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.FrameCount waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.FrameCount>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;", "static")]
		public partial class Frames
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Frames()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frames", "[Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames$Frame;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames$Frame;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames.Frame> frames_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames.Frame>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Frames(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Frames(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, int arg2, int arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Frames>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;II)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1, int arg2, int arg3)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames$Frame;", "static")]
			public partial class Frame
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Frame()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames$Frame;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long frameID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lcom/sun/jdi/Location;", "final")]
				public Dova.JDK.com.sun.jdi.Location location_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Frame(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public Frame(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Frames$Frame;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;", "static")]
		public partial class ThreadGroup
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ThreadGroup()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl group_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ThreadGroup(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ThreadGroup(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ThreadGroup process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ThreadGroup>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$ThreadGroup;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ThreadGroup waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.ThreadGroup>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;", "static")]
		public partial class Status
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Status()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threadStatus", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suspendStatus", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int threadStatus_Property
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

			[JniSignatureAttribute("I", "final")]
			public int suspendStatus_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Status(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Status(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Status process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Status>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Status;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Status waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Status>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;", "static")]
		public partial class Resume
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resume()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Resume(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Resume(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Resume process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Resume>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Resume;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Resume waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Resume>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;", "static")]
		public partial class Suspend
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Suspend()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Suspend(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Suspend(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Suspend process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Suspend>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Suspend;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Suspend waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Suspend>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;", "static")]
		public partial class Name
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Name()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threadName", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String threadName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Name(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Name(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Name process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ThreadReference$Name;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Name waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ThreadReference.Name>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StringReference;", "static")]
	public partial class StringReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StringReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StringReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StringReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public StringReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StringReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$StringReference$Value;", "static")]
		public partial class Value
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Value()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$StringReference$Value;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringValue", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$StringReference$Value;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StringReference$Value;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String stringValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Value(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Value(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$StringReference$Value;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$StringReference$Value;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StringReference.Value process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StringReference.Value>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$StringReference$Value;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.StringReference.Value waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.StringReference.Value>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference;", "static")]
	public partial class ObjectReference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ObjectReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ObjectReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ObjectReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;", "static")]
		public partial class ReferringObjects
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReferringObjects()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "referringObjects", "[Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;I)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl> referringObjects_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReferringObjects(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ReferringObjects(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;I)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferringObjects process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferringObjects>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferringObjects;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferringObjects waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferringObjects>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;", "static")]
		public partial class IsCollected
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static IsCollected()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCollected", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool isCollected_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public IsCollected(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public IsCollected(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.IsCollected process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.IsCollected>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$IsCollected;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.IsCollected waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.IsCollected>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;", "static")]
		public partial class EnableCollection
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EnableCollection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EnableCollection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public EnableCollection(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.EnableCollection process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.EnableCollection>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$EnableCollection;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.EnableCollection waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.EnableCollection>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;", "static")]
		public partial class DisableCollection
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DisableCollection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DisableCollection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public DisableCollection(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.DisableCollection process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.DisableCollection>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$DisableCollection;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.DisableCollection waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.DisableCollection>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;", "static")]
		public partial class InvokeMethod
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvokeMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnValue", "Lcom/sun/tools/jdi/ValueImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exception", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ClassTypeImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ClassTypeImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ValueImpl returnValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl exception_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvokeMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public InvokeMethod(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ClassTypeImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.InvokeMethod process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg3, long arg4, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg5, int arg6)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.InvokeMethod waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/ClassTypeImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg3, long arg4, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg5, int arg6)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;", "static")]
		public partial class MonitorInfo
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MonitorInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entryCount", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "waiters", "[Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl owner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int entryCount_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl> waiters_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MonitorInfo(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public MonitorInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.MonitorInfo process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.MonitorInfo>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$MonitorInfo;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.MonitorInfo waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.MonitorInfo>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;", "static")]
		public partial class SetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;)Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;)Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues.FieldValue> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.SetValues.FieldValue> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;", "static")]
			public partial class FieldValue
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Lcom/sun/tools/jdi/ValueImpl;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLcom/sun/tools/jdi/ValueImpl;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ValueImpl value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldValue(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(JLcom/sun/tools/jdi/ValueImpl;)V", "")]
				public FieldValue(long arg0, Dova.JDK.com.sun.tools.jdi.ValueImpl arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$SetValues$FieldValue;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;", "static")]
		public partial class GetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "[Lcom/sun/tools/jdi/ValueImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;)Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> values_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public GetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;)Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues.Field> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;[Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.GetValues.Field> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;", "static")]
			public partial class Field
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Field()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Field(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(J)V", "")]
				public Field(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$GetValues$Field;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;", "static")]
		public partial class ReferenceType
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReferenceType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("B", "final")]
			public byte refTypeTag_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long typeID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReferenceType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ReferenceType(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferenceType process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferenceType>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ObjectReference$ReferenceType;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferenceType waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ObjectReference.ReferenceType>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ObjectReferenceImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Field;", "static")]
	public partial class Field
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Field()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Field;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Field(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Field() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Field;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method;", "static")]
	public partial class Method
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Method()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Method(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Method() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;", "static")]
		public partial class VariableTableWithGeneric
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static VariableTableWithGeneric()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argCnt", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slots", "[Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric$SlotInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int argCnt_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric$SlotInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric.SlotInfo> slots_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric.SlotInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public VariableTableWithGeneric(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public VariableTableWithGeneric(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTableWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric$SlotInfo;", "static")]
			public partial class SlotInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static SlotInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric$SlotInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "codeIndex", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slot", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long codeIndex_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String genericSignature_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int length_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int slot_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public SlotInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public SlotInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$VariableTableWithGeneric$SlotInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;", "static")]
		public partial class IsObsolete
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static IsObsolete()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isObsolete", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool isObsolete_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public IsObsolete(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public IsObsolete(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.IsObsolete process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.IsObsolete>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$IsObsolete;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.IsObsolete waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.IsObsolete>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;", "static")]
		public partial class Bytecodes
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Bytecodes()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytes", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[B", "final")]
			public JavaArray<byte> bytes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Bytecodes(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Bytecodes(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.Bytecodes process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.Bytecodes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$Bytecodes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.Bytecodes waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.Bytecodes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$VariableTable;", "static")]
		public partial class VariableTable
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static VariableTable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$VariableTable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argCnt", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slots", "[Lcom/sun/tools/jdi/JDWP$Method$VariableTable$SlotInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$VariableTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$VariableTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int argCnt_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$Method$VariableTable$SlotInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable.SlotInfo> slots_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable.SlotInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public VariableTable(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public VariableTable(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$VariableTable;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$VariableTable;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$VariableTable;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.VariableTable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$VariableTable$SlotInfo;", "static")]
			public partial class SlotInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static SlotInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$VariableTable$SlotInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "codeIndex", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slot", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long codeIndex_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("I", "final")]
				public int length_Property
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

				[JniSignatureAttribute("I", "final")]
				public int slot_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public SlotInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public SlotInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$VariableTable$SlotInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$LineTable;", "static")]
		public partial class LineTable
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LineTable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$LineTable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lines", "[Lcom/sun/tools/jdi/JDWP$Method$LineTable$LineInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$LineTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$LineTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("J", "final")]
			public long start_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long end_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$Method$LineTable$LineInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable.LineInfo> lines_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable.LineInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LineTable(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public LineTable(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$LineTable;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/JDWP$Method$LineTable;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$Method$LineTable;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.Method.LineTable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;J)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$Method$LineTable$LineInfo;", "static")]
			public partial class LineInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LineInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$Method$LineTable$LineInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineCodeIndex", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineNumber", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long lineCodeIndex_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int lineNumber_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LineInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public LineInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$Method$LineTable$LineInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$InterfaceType;", "static")]
	public partial class InterfaceType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InterfaceType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$InterfaceType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InterfaceType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public InterfaceType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$InterfaceType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;", "static")]
		public partial class InvokeMethod
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvokeMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnValue", "Lcom/sun/tools/jdi/ValueImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exception", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/InterfaceTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/InterfaceTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ValueImpl returnValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl exception_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvokeMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public InvokeMethod(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/InterfaceTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.InterfaceType.InvokeMethod process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.InterfaceTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.InterfaceType.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$InterfaceType$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.InterfaceType.InvokeMethod waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.InterfaceType.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/InterfaceTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.InterfaceTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayType;", "static")]
	public partial class ArrayType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ArrayType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;", "static")]
		public partial class NewInstance
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NewInstance()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newArray", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayTypeImpl;I)Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayTypeImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl newArray_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NewInstance(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public NewInstance(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayTypeImpl;I)Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayType.NewInstance process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayTypeImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayType.NewInstance>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ArrayType$NewInstance;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ArrayType.NewInstance waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ArrayType.NewInstance>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ArrayTypeImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ArrayTypeImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType;", "static")]
	public partial class ClassType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ClassType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;", "static")]
		public partial class NewInstance
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NewInstance()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newObject", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exception", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl newObject_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl exception_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NewInstance(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public NewInstance(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.NewInstance process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.NewInstance>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$NewInstance;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.NewInstance waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.NewInstance>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;", "static")]
		public partial class InvokeMethod
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvokeMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnValue", "Lcom/sun/tools/jdi/ValueImpl;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exception", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ValueImpl returnValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl exception_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvokeMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public InvokeMethod(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;Lcom/sun/tools/jdi/ThreadReferenceImpl;J[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg2, long arg3, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg4, int arg5)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;", "static")]
		public partial class SetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;[Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;)Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;[Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;[Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;)Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues.FieldValue> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$SetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;[Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.SetValues.FieldValue> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;", "static")]
			public partial class FieldValue
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Lcom/sun/tools/jdi/ValueImpl;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLcom/sun/tools/jdi/ValueImpl;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ValueImpl value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldValue(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(JLcom/sun/tools/jdi/ValueImpl;)V", "")]
				public FieldValue(long arg0, Dova.JDK.com.sun.tools.jdi.ValueImpl arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType$SetValues$FieldValue;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;", "static")]
		public partial class Superclass
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Superclass()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superclass", "Lcom/sun/tools/jdi/ClassTypeImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;)Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassTypeImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ClassTypeImpl superclass_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ClassTypeImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Superclass(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Superclass(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;)Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.Superclass process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.Superclass>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ClassType$Superclass;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.Superclass waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.Superclass>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ClassTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ClassTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType;", "static")]
	public partial class ReferenceType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReferenceType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReferenceType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ReferenceType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;", "static")]
		public partial class Module
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Module()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "module", "Lcom/sun/tools/jdi/ModuleReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ModuleReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl module_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Module(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Module(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Module process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Module>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Module;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Module waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Module>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;", "static")]
		public partial class ConstantPool
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ConstantPool()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytes", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int count_Property
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

			[JniSignatureAttribute("[B", "final")]
			public JavaArray<byte> bytes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ConstantPool(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ConstantPool(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ConstantPool process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ConstantPool>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ConstantPool;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ConstantPool waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ConstantPool>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;", "static")]
		public partial class ClassFileVersion
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassFileVersion()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "majorVersion", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minorVersion", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int majorVersion_Property
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

			[JniSignatureAttribute("I", "final")]
			public int minorVersion_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassFileVersion(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassFileVersion(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassFileVersion process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassFileVersion>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassFileVersion;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassFileVersion waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassFileVersion>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;", "static")]
		public partial class Instances
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Instances()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instances", "[Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;I)Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl> instances_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Instances(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Instances(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;I)Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Instances process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Instances>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Instances;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Instances waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Instances>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;", "static")]
		public partial class MethodsWithGeneric
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodsWithGeneric()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declared", "[Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric$MethodInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric$MethodInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric.MethodInfo> declared_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric.MethodInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MethodsWithGeneric(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public MethodsWithGeneric(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.MethodsWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric$MethodInfo;", "static")]
			public partial class MethodInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric$MethodInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modBits", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long methodID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String genericSignature_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int modBits_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public MethodInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$MethodsWithGeneric$MethodInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;", "static")]
		public partial class FieldsWithGeneric
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldsWithGeneric()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declared", "[Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric$FieldInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric$FieldInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric.FieldInfo> declared_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric.FieldInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldsWithGeneric(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public FieldsWithGeneric(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.FieldsWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric$FieldInfo;", "static")]
			public partial class FieldInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric$FieldInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modBits", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String genericSignature_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int modBits_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public FieldInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$FieldsWithGeneric$FieldInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;", "static")]
		public partial class SignatureWithGeneric
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SignatureWithGeneric()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String signature_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String genericSignature_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SignatureWithGeneric(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SignatureWithGeneric(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SignatureWithGeneric process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SignatureWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SignatureWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SignatureWithGeneric waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SignatureWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;", "static")]
		public partial class SourceDebugExtension
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SourceDebugExtension()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extension", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String extension_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SourceDebugExtension(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SourceDebugExtension(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceDebugExtension process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceDebugExtension>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceDebugExtension;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceDebugExtension waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceDebugExtension>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;", "static")]
		public partial class ClassObject
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassObject()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classObject", "Lcom/sun/tools/jdi/ClassObjectReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassObjectReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ClassObjectReferenceImpl classObject_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ClassObjectReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassObject(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassObject(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassObject process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassObject>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassObject;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassObject waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassObject>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;", "static")]
		public partial class Interfaces
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Interfaces()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "[Lcom/sun/tools/jdi/InterfaceTypeImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/InterfaceTypeImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.InterfaceTypeImpl> interfaces_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.InterfaceTypeImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Interfaces(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Interfaces(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Interfaces process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Interfaces>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Interfaces;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Interfaces waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Interfaces>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;", "static")]
		public partial class Status
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Status()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int status_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Status(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Status(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Status process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Status>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Status;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Status waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Status>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;", "static")]
		public partial class NestedTypes
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NestedTypes()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "[Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes$TypeInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes$TypeInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes.TypeInfo> classes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes.TypeInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NestedTypes(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public NestedTypes(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.NestedTypes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes$TypeInfo;", "static")]
			public partial class TypeInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TypeInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes$TypeInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte refTypeTag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("J", "final")]
				public long typeID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public TypeInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public TypeInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$NestedTypes$TypeInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;", "static")]
		public partial class SourceFile
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SourceFile()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceFile", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String sourceFile_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SourceFile(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SourceFile(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceFile process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceFile>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$SourceFile;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceFile waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.SourceFile>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;", "static")]
		public partial class GetValues
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GetValues()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "[Lcom/sun/tools/jdi/ValueImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;[Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;)Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;[Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ValueImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> values_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GetValues(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public GetValues(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;[Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;)Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues.Field> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;[Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.GetValues.Field> arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;", "static")]
			public partial class Field
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Field()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Field(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(J)V", "")]
				public Field(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$GetValues$Field;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;", "static")]
		public partial class Methods
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Methods()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declared", "[Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods$MethodInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods$MethodInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods.MethodInfo> declared_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods.MethodInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Methods(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Methods(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Methods>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods$MethodInfo;", "static")]
			public partial class MethodInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods$MethodInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modBits", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long methodID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("I", "final")]
				public int modBits_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public MethodInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Methods$MethodInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;", "static")]
		public partial class Fields
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Fields()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declared", "[Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields$FieldInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields$FieldInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields.FieldInfo> declared_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields.FieldInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Fields(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Fields(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Fields>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields$FieldInfo;", "static")]
			public partial class FieldInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields$FieldInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modBits", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("J", "final")]
				public long fieldID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("I", "final")]
				public int modBits_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public FieldInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Fields$FieldInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;", "static")]
		public partial class Modifiers
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Modifiers()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modBits", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int modBits_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Modifiers(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Modifiers(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Modifiers process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Modifiers>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Modifiers;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Modifiers waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Modifiers>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;", "static")]
		public partial class ClassLoader
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoader()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassLoaderReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ClassLoaderReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassLoader(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassLoader process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$ClassLoader;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassLoader waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;", "static")]
		public partial class Signature
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Signature()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String signature_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Signature(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Signature(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Signature process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Signature>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$ReferenceType$Signature;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Signature waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ReferenceType.Signature>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine;", "static")]
	public partial class VirtualMachine
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VirtualMachine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_SET", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COMMAND_SET_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VirtualMachine(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public VirtualMachine() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;", "static")]
		public partial class AllModules
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AllModules()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modules", "[Lcom/sun/tools/jdi/ModuleReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ModuleReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl> modules_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ModuleReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AllModules(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public AllModules(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllModules process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllModules>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllModules;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllModules waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllModules>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;", "static")]
		public partial class InstanceCounts
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InstanceCounts()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "counts", "[J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[J", "final")]
			public JavaArray<long> counts_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InstanceCounts(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public InstanceCounts(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.InstanceCounts process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.InstanceCounts>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$InstanceCounts;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.InstanceCounts waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.InstanceCounts>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/ReferenceTypeImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;", "static")]
		public partial class AllClassesWithGeneric
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AllClassesWithGeneric()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "[Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric$ClassInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric$ClassInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric.ClassInfo> classes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric.ClassInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AllClassesWithGeneric(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public AllClassesWithGeneric(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClassesWithGeneric>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric$ClassInfo;", "static")]
			public partial class ClassInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ClassInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric$ClassInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte refTypeTag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("J", "final")]
				public long typeID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String genericSignature_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int status_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ClassInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public ClassInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClassesWithGeneric$ClassInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;", "static")]
		public partial class SetDefaultStratum
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SetDefaultStratum()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SetDefaultStratum(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public SetDefaultStratum(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.SetDefaultStratum process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.SetDefaultStratum>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$SetDefaultStratum;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.SetDefaultStratum waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.SetDefaultStratum>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;", "static")]
		public partial class RedefineClasses
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RedefineClasses()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RedefineClasses(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public RedefineClasses(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses.ClassDef> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.RedefineClasses.ClassDef> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;", "static")]
			public partial class ClassDef
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ClassDef()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refType", "Lcom/sun/tools/jdi/ReferenceTypeImpl;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classfile", "[B"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ReferenceTypeImpl;[B)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ReferenceTypeImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl refType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[B", "final")]
				public JavaArray<byte> classfile_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ClassDef(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/ReferenceTypeImpl;[B)V", "")]
				public ClassDef(Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$RedefineClasses$ClassDef;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;", "static")]
		public partial class CapabilitiesNew
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CapabilitiesNew()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canWatchFieldModification", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canWatchFieldAccess", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetBytecodes", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetSyntheticAttribute", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetOwnedMonitorInfo", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetCurrentContendedMonitor", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetMonitorInfo", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canRedefineClasses", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canAddMethod", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canUnrestrictedlyRedefineClasses", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canPopFrames", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canUseInstanceFilters", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetSourceDebugExtension", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canRequestVMDeathEvent", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canSetDefaultStratum", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetInstanceInfo", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canRequestMonitorEvents", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetMonitorFrameInfo", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canUseSourceNameFilters", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetConstantPool", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canForceEarlyReturn", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved22", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved23", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved24", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved25", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved26", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved27", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved28", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved29", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved30", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved31", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reserved32", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool canWatchFieldModification_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canWatchFieldAccess_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetBytecodes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetSyntheticAttribute_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool canGetOwnedMonitorInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetCurrentContendedMonitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetMonitorInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canRedefineClasses_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canAddMethod_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canUnrestrictedlyRedefineClasses_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canPopFrames_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canUseInstanceFilters_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetSourceDebugExtension_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canRequestVMDeathEvent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canSetDefaultStratum_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetInstanceInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canRequestMonitorEvents_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetMonitorFrameInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canUseSourceNameFilters_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetConstantPool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canForceEarlyReturn_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved22_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved23_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved24_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved25_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[25]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[25], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved26_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved27_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved28_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved29_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved30_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved31_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[31]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[31], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool reserved32_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[32]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[32], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CapabilitiesNew(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public CapabilitiesNew(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CapabilitiesNew process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CapabilitiesNew>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CapabilitiesNew;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CapabilitiesNew waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CapabilitiesNew>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;", "static")]
		public partial class ReleaseEvents
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReleaseEvents()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReleaseEvents(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ReleaseEvents(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ReleaseEvents process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ReleaseEvents>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ReleaseEvents;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ReleaseEvents waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ReleaseEvents>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;", "static")]
		public partial class HoldEvents
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static HoldEvents()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public HoldEvents(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public HoldEvents(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.HoldEvents process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.HoldEvents>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$HoldEvents;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.HoldEvents waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.HoldEvents>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;", "static")]
		public partial class DisposeObjects
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DisposeObjects()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DisposeObjects(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public DisposeObjects(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects.Request> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;[Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.DisposeObjects.Request> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;", "static")]
			public partial class Request
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Request()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refCnt", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/ObjectReferenceImpl;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("Lcom/sun/tools/jdi/ObjectReferenceImpl;", "final")]
				public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl @object_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int refCnt_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Request(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/ObjectReferenceImpl;I)V", "")]
				public Request(Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$DisposeObjects$Request;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public void write(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;", "static")]
		public partial class ClassPaths
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassPaths()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseDir", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classpaths", "[Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootclasspaths", "[Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String baseDir_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Ljava/lang/String;", "final")]
			public JavaArray<Dova.JDK.java.lang.String> classpaths_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Ljava/lang/String;", "final")]
			public JavaArray<Dova.JDK.java.lang.String> bootclasspaths_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassPaths(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassPaths(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassPaths process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassPaths>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassPaths;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassPaths waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassPaths>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;", "static")]
		public partial class Capabilities
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Capabilities()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canWatchFieldModification", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canWatchFieldAccess", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetBytecodes", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetSyntheticAttribute", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetOwnedMonitorInfo", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetCurrentContendedMonitor", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canGetMonitorInfo", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool canWatchFieldModification_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canWatchFieldAccess_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetBytecodes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetSyntheticAttribute_Property
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

			[JniSignatureAttribute("Z", "final")]
			public bool canGetOwnedMonitorInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetCurrentContendedMonitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool canGetMonitorInfo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Capabilities(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Capabilities(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Capabilities process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Capabilities>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Capabilities;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Capabilities waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Capabilities>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;", "static")]
		public partial class CreateString
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CreateString()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringObject", "Lcom/sun/tools/jdi/StringReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/jdi/StringReferenceImpl;", "final")]
			public Dova.JDK.com.sun.tools.jdi.StringReferenceImpl stringObject_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.StringReferenceImpl>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CreateString(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public CreateString(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CreateString process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CreateString>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$CreateString;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CreateString waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.CreateString>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;", "static")]
		public partial class Exit
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Exit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;I)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Exit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Exit(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;I)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Exit process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Exit>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Exit;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Exit waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Exit>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;I)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;", "static")]
		public partial class Resume
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resume()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Resume(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Resume(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Resume process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Resume>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Resume;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Resume waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Resume>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;", "static")]
		public partial class Suspend
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Suspend()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Suspend(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Suspend(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Suspend process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Suspend>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Suspend;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Suspend waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Suspend>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;", "static")]
		public partial class IDSizes
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static IDSizes()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldIDSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodIDSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objectIDSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "referenceTypeIDSize", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameIDSize", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("I", "final")]
			public int fieldIDSize_Property
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

			[JniSignatureAttribute("I", "final")]
			public int methodIDSize_Property
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

			[JniSignatureAttribute("I", "final")]
			public int objectIDSize_Property
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

			[JniSignatureAttribute("I", "final")]
			public int referenceTypeIDSize_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int frameIDSize_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public IDSizes(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public IDSizes(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.IDSizes process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.IDSizes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$IDSizes;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.IDSizes waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.IDSizes>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;", "static")]
		public partial class Dispose
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispose()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Dispose(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Dispose(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Dispose process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Dispose>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Dispose;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Dispose waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Dispose>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;", "static")]
		public partial class TopLevelThreadGroups
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TopLevelThreadGroups()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groups", "[Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ThreadGroupReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl> groups_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadGroupReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TopLevelThreadGroups(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public TopLevelThreadGroups(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.TopLevelThreadGroups process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.TopLevelThreadGroups>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$TopLevelThreadGroups;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.TopLevelThreadGroups waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.TopLevelThreadGroups>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;", "static")]
		public partial class AllThreads
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AllThreads()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threads", "[Lcom/sun/tools/jdi/ThreadReferenceImpl;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/ThreadReferenceImpl;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl> threads_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AllThreads(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public AllThreads(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllThreads process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllThreads>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllThreads;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllThreads waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllThreads>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;", "static")]
		public partial class AllClasses
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AllClasses()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "[Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses$ClassInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses$ClassInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses.ClassInfo> classes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses.ClassInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AllClasses(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public AllClasses(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.AllClasses>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses$ClassInfo;", "static")]
			public partial class ClassInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ClassInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses$ClassInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte refTypeTag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("J", "final")]
				public long typeID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String signature_Property
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

				[JniSignatureAttribute("I", "final")]
				public int status_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ClassInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public ClassInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$AllClasses$ClassInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;", "static")]
		public partial class ClassesBySignature
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassesBySignature()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "[Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature$ClassInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature$ClassInfo;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature.ClassInfo> classes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature.ClassInfo>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassesBySignature(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public ClassesBySignature(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.ClassesBySignature>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Ljava/lang/String;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature$ClassInfo;", "static")]
			public partial class ClassInfo
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ClassInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature$ClassInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypeTag", "B"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeID", "J"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				}

				[JniSignatureAttribute("B", "final")]
				public byte refTypeTag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("J", "final")]
				public long typeID_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("I", "final")]
				public int status_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ClassInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
				public ClassInfo(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$ClassesBySignature$ClassInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;", "static")]
		public partial class Version
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Version()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jdwpMajor", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jdwpMinor", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vmVersion", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vmName", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "process", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueCommand", "(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;"));
			}

			[JniSignatureAttribute("I", "static final")]
			public static int COMMAND_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String description_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int jdwpMajor_Property
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

			[JniSignatureAttribute("I", "final")]
			public int jdwpMinor_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String vmVersion_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String vmName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Version(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)V", "private")]
			public Version(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Version process(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Version>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/JDWP$VirtualMachine$Version;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Version waitForReply(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0, Dova.JDK.com.sun.tools.jdi.PacketStream arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.VirtualMachine.Version>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdi/VirtualMachineImpl;)Lcom/sun/tools/jdi/PacketStream;", "static")]
			public static Dova.JDK.com.sun.tools.jdi.PacketStream enqueueCommand(Dova.JDK.com.sun.tools.jdi.VirtualMachineImpl arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
			}
		}
	}
}
