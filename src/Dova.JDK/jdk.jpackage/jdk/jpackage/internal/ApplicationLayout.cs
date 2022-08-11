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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout;", "public final")]
public partial class ApplicationLayout
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.jpackage.@internal.PathGroup.Facade
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ApplicationLayout()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/ApplicationLayout;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "Ljdk/jpackage/internal/PathGroup;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jpackage/internal/PathGroup;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appModsDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "platformAppImage", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAt_0", "(Ljava/nio/file/Path;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAt_1", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "launchersDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runtimeDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pathGroup", "()Ljdk/jpackage/internal/PathGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "windowsAppImage", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "linuxAppImage", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "macAppImage", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destktopIntegrationDirectory", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "javaRuntime", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "linuxUsrTreePackageImage", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runtimeHomeDirectory", "()Ljava/nio/file/Path;"));
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/PathGroup;", "private final")]
	public Dova.JDK.jdk.jpackage.@internal.PathGroup data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.PathGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ApplicationLayout(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "")]
	public ApplicationLayout(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup;)V", "private")]
	public ApplicationLayout(Dova.JDK.jdk.jpackage.@internal.PathGroup arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/ApplicationLayout;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path appModsDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "public static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout platformAppImage()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object resolveAt_0(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/ApplicationLayout;", "public")]
	public Dova.JDK.jdk.jpackage.@internal.ApplicationLayout resolveAt_1(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path appDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path contentDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path launchersDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path runtimeDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/PathGroup;", "public")]
	public Dova.JDK.jdk.jpackage.@internal.PathGroup pathGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.PathGroup>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout windowsAppImage()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout linuxAppImage()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout macAppImage()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path destktopIntegrationDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "public static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout javaRuntime()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Ljdk/jpackage/internal/ApplicationLayout;", "public static")]
	public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout linuxUsrTreePackageImage(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path runtimeHomeDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "static final")]
	public partial class PathRole
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PathRole()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/ApplicationLayout$PathRole;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNTIME", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNTIME_HOME", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APP", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAUNCHERS", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESKTOP", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULES", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINUX_APPLAUNCHER_LIB", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTENT", "Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jpackage/internal/ApplicationLayout$PathRole;"));
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole RUNTIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole RUNTIME_HOME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole APP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole LAUNCHERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole DESKTOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole MODULES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole LINUX_APPLAUNCHER_LIB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole CONTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PathRole(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public PathRole(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/ApplicationLayout$PathRole;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "public static")]
		public static Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/ApplicationLayout$PathRole;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout.PathRole>>(ret);
		}
	}
}
