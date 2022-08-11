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

namespace Dova.JDK.jdk.tools.jlink.@internal;

[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform;", "public final")]
public partial class Platform
	: Dova.JDK.java.lang.Record
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Platform()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Platform;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "os", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arch", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Ljdk/tools/jlink/internal/Platform;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/internal/Platform$OperatingSystem;Ljdk/tools/jlink/internal/Platform$Architecture;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runtime", "()Ljdk/tools/jlink/internal/Platform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "os", "()Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runtimeOS", "()Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is64Bit", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "runtimeArch", "()Ljdk/tools/jlink/internal/Platform$Architecture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parsePlatform", "(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toArch", "(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$Architecture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arch", "()Ljdk/tools/jlink/internal/Platform$Architecture;"));
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "private final")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem os_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "private final")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture arch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform;", "public static final")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Platform(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/Platform$OperatingSystem;Ljdk/tools/jlink/internal/Platform$Architecture;)V", "public")]
	public Platform(Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem os, Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture arch) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], os, arch))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/Platform;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform;", "public static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform runtime()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem os()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "private static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem runtimeOS()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool is64Bit()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform$Architecture;", "private static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture runtimeArch()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform;", "public static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform parsePlatform(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$Architecture;", "private static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture toArch(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Platform$Architecture;", "public")]
	public Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture arch()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
	public partial class OperatingSystem
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OperatingSystem()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Platform$OperatingSystem;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WINDOWS", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINUX", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MACOS", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AIX", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/tools/jlink/internal/Platform$OperatingSystem;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem WINDOWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem LINUX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem MACOS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem AIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem UNKNOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OperatingSystem(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OperatingSystem(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/Platform$OperatingSystem;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "public static")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Platform$OperatingSystem;", "private static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.OperatingSystem>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
	public partial class Architecture
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Architecture()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Platform$Architecture;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "X86", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "x64", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARM", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AARCH64", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Ljdk/tools/jlink/internal/Platform$Architecture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/tools/jlink/internal/Platform$Architecture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/tools/jlink/internal/Platform$Architecture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$Architecture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/tools/jlink/internal/Platform$Architecture;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture X86_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture x64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture ARM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture AARCH64_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Platform$Architecture;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture UNKNOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/tools/jlink/internal/Platform$Architecture;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Architecture(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Architecture(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/Platform$Architecture;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Platform$Architecture;", "public static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/internal/Platform$Architecture;", "public static")]
		public static Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Platform$Architecture;", "private static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Platform.Architecture>>(ret);
		}
	}
}
