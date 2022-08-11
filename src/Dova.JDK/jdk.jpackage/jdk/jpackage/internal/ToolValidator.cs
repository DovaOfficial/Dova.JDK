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

[JniSignatureAttribute("Ljdk/jpackage/internal/ToolValidator;", "public final")]
public partial class ToolValidator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ToolValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/ToolValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toolPath", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimalVersion", "Ljava/lang/Comparable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "versionParser", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toolNotFoundErrorHandler", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toolOldVersionErrorHandler", "Ljava/util/function/BiFunction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "()Ljdk/jpackage/internal/ConfigException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCommandLine", "([Ljava/lang/String;)Ljdk/jpackage/internal/ToolValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setToolNotFoundErrorHandler", "(Ljava/util/function/BiFunction;)Ljdk/jpackage/internal/ToolValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setToolOldVersionErrorHandler", "(Ljava/util/function/BiFunction;)Ljdk/jpackage/internal/ToolValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMinimalVersion", "(Ljava/lang/Comparable;)Ljdk/jpackage/internal/ToolValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVersionParser", "(Ljava/util/function/Function;)Ljdk/jpackage/internal/ToolValidator;"));
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
	public Dova.JDK.java.nio.file.Path toolPath_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List args_Property
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

	[JniSignatureAttribute("Ljava/lang/Comparable;", "private")]
	public Dova.JDK.java.lang.Comparable minimalVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private")]
	public Dova.JDK.java.util.function.Function versionParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "private")]
	public Dova.JDK.java.util.function.BiFunction toolNotFoundErrorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "private")]
	public Dova.JDK.java.util.function.BiFunction toolOldVersionErrorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ToolValidator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public ToolValidator(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "")]
	public ToolValidator(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/ToolValidator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ConfigException;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ConfigException validate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ConfigException>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljdk/jpackage/internal/ToolValidator;", "transient")]
	public Dova.JDK.jdk.jpackage.@internal.ToolValidator setCommandLine(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ToolValidator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljdk/jpackage/internal/ToolValidator;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ToolValidator setToolNotFoundErrorHandler(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ToolValidator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BiFunction;)Ljdk/jpackage/internal/ToolValidator;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ToolValidator setToolOldVersionErrorHandler(Dova.JDK.java.util.function.BiFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ToolValidator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Comparable;)Ljdk/jpackage/internal/ToolValidator;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ToolValidator setMinimalVersion(Dova.JDK.java.lang.Comparable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ToolValidator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljdk/jpackage/internal/ToolValidator;", "")]
	public Dova.JDK.jdk.jpackage.@internal.ToolValidator setVersionParser(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ToolValidator>(ret);
	}
}
