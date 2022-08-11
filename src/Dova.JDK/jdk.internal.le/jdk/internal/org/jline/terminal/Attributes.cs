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

namespace Dova.JDK.jdk.@internal.org.jline.terminal;

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes;", "public")]
public partial class Attributes
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Attributes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iflag", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oflag", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cflag", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lflag", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cchars", "Ljava/util/EnumMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/terminal/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/EnumSet;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/EnumSet;Ljava/util/function/Function;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljdk/internal/org/jline/terminal/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "display", "(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputFlag", "(Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlFlag", "(Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setControlFlag", "(Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalFlag", "(Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocalFlag", "(Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setControlChar", "(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlFlags", "()Ljava/util/EnumSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setControlFlags", "(Ljava/util/EnumSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setControlFlags", "(Ljava/util/EnumSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputFlags", "()Ljava/util/EnumSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputFlags", "(Ljava/util/EnumSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputFlags", "(Ljava/util/EnumSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalFlags", "()Ljava/util/EnumSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocalFlags", "(Ljava/util/EnumSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocalFlags", "(Ljava/util/EnumSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputFlags", "()Ljava/util/EnumSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputFlags", "(Ljava/util/EnumSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputFlags", "(Ljava/util/EnumSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlChars", "()Ljava/util/EnumMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setControlChars", "(Ljava/util/EnumMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlChar", "(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputFlag", "(Ljdk/internal/org/jline/terminal/Attributes$InputFlag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputFlag", "(Ljdk/internal/org/jline/terminal/Attributes$InputFlag;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputFlag", "(Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
	public Dova.JDK.java.util.EnumSet iflag_Property
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

	[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
	public Dova.JDK.java.util.EnumSet oflag_Property
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

	[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
	public Dova.JDK.java.util.EnumSet cflag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
	public Dova.JDK.java.util.EnumSet lflag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumMap;", "final")]
	public Dova.JDK.java.util.EnumMap cchars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Attributes(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Attributes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes;)V", "public")]
	public Attributes(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String append(Dova.JDK.java.util.EnumSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Ljava/util/function/Function;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String append(Dova.JDK.java.util.EnumSet arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes;)V", "public")]
	public void copy(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String display(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;Z)V", "public")]
	public void setOutputFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;)Z", "public")]
	public bool getControlFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;Z)V", "public")]
	public void setControlFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;)Z", "public")]
	public bool getLocalFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;Z)V", "public")]
	public void setLocalFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;I)V", "public")]
	public void setControlChar(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/EnumSet;", "public")]
	public Dova.JDK.java.util.EnumSet getControlFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;)V", "public")]
	public void setControlFlags(Dova.JDK.java.util.EnumSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Z)V", "public")]
	public void setControlFlags(Dova.JDK.java.util.EnumSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/EnumSet;", "public")]
	public Dova.JDK.java.util.EnumSet getInputFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;)V", "public")]
	public void setInputFlags(Dova.JDK.java.util.EnumSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Z)V", "public")]
	public void setInputFlags(Dova.JDK.java.util.EnumSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/EnumSet;", "public")]
	public Dova.JDK.java.util.EnumSet getLocalFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;)V", "public")]
	public void setLocalFlags(Dova.JDK.java.util.EnumSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Z)V", "public")]
	public void setLocalFlags(Dova.JDK.java.util.EnumSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/EnumSet;", "public")]
	public Dova.JDK.java.util.EnumSet getOutputFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;)V", "public")]
	public void setOutputFlags(Dova.JDK.java.util.EnumSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EnumSet;Z)V", "public")]
	public void setOutputFlags(Dova.JDK.java.util.EnumSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/EnumMap;", "public")]
	public Dova.JDK.java.util.EnumMap getControlChars()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EnumMap;)V", "public")]
	public void setControlChars(Dova.JDK.java.util.EnumMap arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$ControlChar;)I", "public")]
	public int getControlChar(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$InputFlag;)Z", "public")]
	public bool getInputFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$InputFlag;Z)V", "public")]
	public void setInputFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;)Z", "public")]
	public bool getOutputFlag(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
	public partial class InputFlag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InputFlag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNBRK", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRKINT", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNPAR", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARMRK", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INPCK", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTRIP", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INLCR", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNCR", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICRNL", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IXON", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IXOFF", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IXANY", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMAXBEL", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IUTF8", "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IGNBRK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag BRKINT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IGNPAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag PARMRK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag INPCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag ISTRIP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag INLCR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IGNCR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag ICRNL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IXON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IXOFF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IXANY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IMAXBEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag IUTF8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InputFlag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public InputFlag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes$InputFlag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$InputFlag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.InputFlag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
	public partial class OutputFlag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OutputFlag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPOST", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLCR", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OXTABS", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONOEOT", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OCRNL", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONOCR", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLRET", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFILL", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NLDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BSDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VTDLY", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFDEL", "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag OPOST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag ONLCR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag OXTABS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag ONOEOT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag OCRNL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag ONOCR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag ONLRET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag OFILL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag NLDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag TABDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag CRDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag FFDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag BSDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag VTDLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag OFDEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OutputFlag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OutputFlag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$OutputFlag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.OutputFlag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
	public partial class ControlFlag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ControlFlag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CIGNORE", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS5", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS6", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS7", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS8", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CSTOPB", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CREAD", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARENB", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARODD", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HUPCL", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLOCAL", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CCTS_OFLOW", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRTS_IFLOW", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CDTR_IFLOW", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CDSR_OFLOW", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CCAR_OFLOW", "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CIGNORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CS5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CS6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CS7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CS8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CSTOPB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CREAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag PARENB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag PARODD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag HUPCL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CLOCAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CCTS_OFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CRTS_IFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CDTR_IFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CDSR_OFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag CCAR_OFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ControlFlag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ControlFlag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$ControlFlag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlFlag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
	public partial class LocalFlag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalFlag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHOKE", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHOE", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHOK", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHO", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHONL", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHOPRT", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECHOCTL", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISIG", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICANON", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALTWERASE", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IEXTEN", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTPROC", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOSTOP", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLUSHO", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOKERNINFO", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PENDIN", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOFLSH", "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHOKE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHOE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHOK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHONL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHOPRT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ECHOCTL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ISIG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ICANON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag ALTWERASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag IEXTEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag EXTPROC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag TOSTOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag FLUSHO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag NOKERNINFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag PENDIN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag NOFLSH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalFlag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public LocalFlag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$LocalFlag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.LocalFlag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
	public partial class ControlChar
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ControlChar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VEOF", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VEOL", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VEOL2", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERASE", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VWERASE", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VKILL", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VREPRINT", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VINTR", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VQUIT", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSUSP", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VDSUSP", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSTART", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSTOP", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VLNEXT", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VDISCARD", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VMIN", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VTIME", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSTATUS", "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VEOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VEOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VEOL2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VERASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VWERASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VKILL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VREPRINT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VINTR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VQUIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VSUSP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VDSUSP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VSTART_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VSTOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VLNEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VDISCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VMIN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VTIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar VSTATUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ControlChar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ControlChar(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/Attributes$ControlChar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/terminal/Attributes$ControlChar;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes.ControlChar>>(ret);
		}
	}
}
