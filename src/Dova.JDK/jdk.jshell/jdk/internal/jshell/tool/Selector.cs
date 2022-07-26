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

namespace Dova.JDK.jdk.@internal.jshell.tool;

[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "")]
public partial class Selector
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Selector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALWAYS", "Ljdk/internal/jshell/tool/Selector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OLD_ALWAYS", "Ljdk/internal/jshell/tool/Selector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANY", "Ljdk/internal/jshell/tool/Selector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "selectorMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bits", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cc", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ca", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cw", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cr", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cu", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ce", "Ljava/util/EnumSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpackEnumSets", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectorToString", "(Ljava/lang/StringBuilder;Ljava/util/EnumSet;Ljava/util/EnumSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asBits", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromPreJDK14", "(Ljdk/internal/jshell/tool/Selector;Z)Ljdk/internal/jshell/tool/Selector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "includedIn", "(Ljdk/internal/jshell/tool/Selector;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "covers", "(Ljdk/internal/jshell/tool/Selector;)Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector ALWAYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector OLD_ALWAYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector ANY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map selectorMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long bits_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String text_Property
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

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet cc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet ca_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet cw_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet cr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet cu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet ce_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Selector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;)V", "")]
	public Selector(Dova.JDK.java.util.EnumSet arg0, Dova.JDK.java.util.EnumSet arg1, Dova.JDK.java.util.EnumSet arg2, Dova.JDK.java.util.EnumSet arg3, Dova.JDK.java.util.EnumSet arg4, Dova.JDK.java.util.EnumSet arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;Ljava/util/EnumSet;)V", "")]
	public Selector(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.EnumSet arg1, Dova.JDK.java.util.EnumSet arg2, Dova.JDK.java.util.EnumSet arg3, Dova.JDK.java.util.EnumSet arg4, Dova.JDK.java.util.EnumSet arg5, Dova.JDK.java.util.EnumSet arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;)V", "")]
	public Selector(Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg2, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;)V", "")]
	public Selector(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.util.Collection arg2, Dova.JDK.java.util.Collection arg3, Dova.JDK.java.util.Collection arg4, Dova.JDK.java.util.Collection arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(J)V", "")]
	public Selector(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void unpackEnumSets()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/util/EnumSet;Ljava/util/EnumSet;)V", "private")]
	public void selectorToString(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.util.EnumSet arg1, Dova.JDK.java.util.EnumSet arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()J", "")]
	public long asBits()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector;Z)Ljdk/internal/jshell/tool/Selector;", "static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector fromPreJDK14(Dova.JDK.jdk.@internal.jshell.tool.Selector arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector;)Z", "")]
	public bool includedIn(Dova.JDK.jdk.@internal.jshell.tool.Selector arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector;)Z", "")]
	public bool covers(Dova.JDK.jdk.@internal.jshell.tool.Selector arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
	public partial class FormatCase
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatCase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatCase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPORT", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARDECL", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARINIT", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPRESSION", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARVALUE", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASSIGNMENT", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATEMENT", "Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUSPICIOUS", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatCase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase IMPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase ENUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase RECORD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase VARDECL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase VARINIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase VARVALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet SUSPICIOUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatCase;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatCase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatCase(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatCase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatCase;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatCase;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
	public partial class FormatAction
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADDED", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIED", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPLACED", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVERWROTE", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROPPED", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USED", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction ADDED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction MODIFIED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction REPLACED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction OVERWROTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction DROPPED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction USED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatAction;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatAction(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatAction;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatAction;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatWhen;", "public static final")]
	public partial class FormatWhen
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatWhen()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatWhen;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMARY", "Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPDATE", "Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatWhen;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen PRIMARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatWhen;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen UPDATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
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

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatWhen;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatWhen(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatWhen(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatWhen;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatWhen;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatWhen;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatWhen;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static final")]
	public partial class FormatResolve
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatResolve()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatResolve;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OK", "Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFINED", "Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOTDEFINED", "Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve DEFINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve NOTDEFINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
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

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatResolve;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatResolve(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatResolve(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatResolve;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatResolve;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatResolve;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static final")]
	public partial class FormatUnresolved
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatUnresolved()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED0", "Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED1", "Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED2", "Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved UNRESOLVED0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved UNRESOLVED1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved UNRESOLVED2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
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

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatUnresolved(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatUnresolved(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatUnresolved;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static final")]
	public partial class FormatErrors
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatErrors()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$FormatErrors;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR0", "Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR1", "Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR2", "Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors ERROR0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors ERROR1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors ERROR2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String doc_Property
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

		[JniSignatureAttribute("Ljava/util/EnumSet;", "static final")]
		public static Dova.JDK.java.util.EnumSet ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int COUNT_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$FormatErrors;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatErrors(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public FormatErrors(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$FormatErrors;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$FormatErrors;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$FormatErrors;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$BitUnpacker;", "private")]
	public partial class BitUnpacker
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BitUnpacker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$BitUnpacker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/Selector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/Selector;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpack", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpackEnumbits", "(Ljava/lang/Class;[Ljava/lang/Enum;)Ljava/util/EnumSet;"));
		}

		[JniSignatureAttribute("J", "")]
		public long b_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BitUnpacker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector;)V", "private")]
		public BitUnpacker(Dova.JDK.jdk.@internal.jshell.tool.Selector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$BitUnpacker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void unpack()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Enum;)Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet unpackEnumbits(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder;", "static")]
	public partial class SelectorBuilder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SelectorBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$SelectorBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectorText", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fcase", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "faction", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fwhen", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fresolve", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "funresolved", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ferrors", "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljdk/internal/jshell/tool/Selector$SelectorInstanceWithDoc;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSelector", "()Ljdk/internal/jshell/tool/Selector;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String selectorText_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector fcase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector faction_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector fwhen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector fresolve_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector funresolved_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector ferrors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorBuilder.SelectorCollector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SelectorBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public SelectorBuilder(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$SelectorBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$SelectorInstanceWithDoc;)V", "")]
		public void add(Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorInstanceWithDoc arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector toSelector()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;", "private static")]
		public partial class SelectorCollector
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SelectorCollector()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "all", "Ljava/util/EnumSet;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "set", "Ljava/util/EnumSet;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/Enum;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()Ljava/util/EnumSet;"));
			}

			[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
			public Dova.JDK.java.util.EnumSet all_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/EnumSet;", "")]
			public Dova.JDK.java.util.EnumSet set__Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SelectorCollector(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
			public SelectorCollector(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$SelectorBuilder$SelectorCollector;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Enum;)V", "")]
			public void add(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
			public Dova.JDK.java.util.EnumSet get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
	public partial class SelectorKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SelectorKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$SelectorKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACTION", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHEN", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLVE", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERRORS", "Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "all", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "k", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind CASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind ACTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind WHEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind RESOLVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind UNRESOLVED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind ERRORS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet all_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class k_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/Selector$SelectorKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SelectorKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;)V", "private")]
		public SelectorKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Selector$SelectorKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/Selector$SelectorKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$SelectorInstanceWithDoc;", "abstract static interface")]
	public partial interface SelectorInstanceWithDoc
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SelectorInstanceWithDoc()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Selector$SelectorInstanceWithDoc;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljdk/internal/jshell/tool/Selector$SelectorKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Selector$SelectorKind;", "public abstract")]
		Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind kind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.SelectorKind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String doc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
