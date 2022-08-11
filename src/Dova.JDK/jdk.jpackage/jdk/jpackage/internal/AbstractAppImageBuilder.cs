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

[JniSignatureAttribute("Ljdk/jpackage/internal/AbstractAppImageBuilder;", "public abstract")]
public partial class AbstractAppImageBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractAppImageBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/AbstractAppImageBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appLayout", "Ljdk/jpackage/internal/ApplicationLayout;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLauncherIconType", "(Ljava/util/Map;)Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createIconResource", "(Ljava/lang/String;Ljdk/jpackage/internal/BundlerParamInfo;Ljava/util/Map;Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareApplicationFiles", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeCfgFile", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppLayout", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyApplication", "(Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
	public Dova.JDK.java.nio.file.Path root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/ApplicationLayout;", "protected final")]
	public Dova.JDK.jdk.jpackage.@internal.ApplicationLayout appLayout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractAppImageBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public")]
	public AbstractAppImageBuilder(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/AbstractAppImageBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "private static")]
	public static Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType getLauncherIconType(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jpackage/internal/BundlerParamInfo;Ljava/util/Map;Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;", "public static")]
	public static Dova.JDK.jdk.jpackage.@internal.OverridableResource createIconResource(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public abstract")]
	public void prepareApplicationFiles(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "protected")]
	public void writeCfgFile(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ApplicationLayout getAppLayout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "protected")]
	public void copyApplication(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "private static final")]
	public partial class IconType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultOrResourceDirIcon", "Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CustomIcon", "Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoIcon", "Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;"));
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType DefaultOrResourceDirIcon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType CustomIcon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType NoIcon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public IconType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "public static")]
		public static Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/AbstractAppImageBuilder$IconType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.AbstractAppImageBuilder.IconType>>(ret);
		}
	}
}
