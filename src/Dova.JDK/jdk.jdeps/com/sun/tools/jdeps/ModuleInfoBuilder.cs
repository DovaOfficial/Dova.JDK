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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/ModuleInfoBuilder;", "public")]
public partial class ModuleInfoBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleInfoBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ModuleInfoBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Lcom/sun/tools/jdeps/JdepsConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputdir", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "open", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dependencyFinder", "Lcom/sun/tools/jdeps/DependencyFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "analyzer", "Lcom/sun/tools/jdeps/Analyzer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "automaticToNormalModule", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsConfiguration;Ljava/util/List;Ljava/nio/file/Path;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(ZLjava/io/PrintWriter;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modules", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "descriptors", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "automaticModules", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printModuleInfo", "(Ljava/io/PrintWriter;Ljava/lang/module/ModuleDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMissingDeps", "(Lcom/sun/tools/jdeps/Analyzer$Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toNormalModule", "(Lcom/sun/tools/jdeps/Module;Ljava/util/Set;Z)Lcom/sun/tools/jdeps/Module;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeRequiresTransitive", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeModuleInfo", "(Ljava/nio/file/Path;Ljava/lang/module/ModuleDescriptor;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration;", "final")]
	public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "final")]
	public Dova.JDK.java.nio.file.Path outputdir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool open_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/DependencyFinder;", "final")]
	public Dova.JDK.com.sun.tools.jdeps.DependencyFinder dependencyFinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.DependencyFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer;", "final")]
	public Dova.JDK.com.sun.tools.jdeps.Analyzer analyzer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map automaticToNormalModule_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModuleInfoBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsConfiguration;Ljava/util/List;Ljava/nio/file/Path;Z)V", "public")]
	public ModuleInfoBuilder(Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.nio.file.Path arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ModuleInfoBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ZLjava/io/PrintWriter;Z)Z", "public")]
	public bool run(bool arg0, Dova.JDK.java.io.PrintWriter arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String toString(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream modules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream descriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set automaticModules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintWriter;Ljava/lang/module/ModuleDescriptor;)V", "private")]
	public void printModuleInfo(Dova.JDK.java.io.PrintWriter arg0, Dova.JDK.java.lang.module.ModuleDescriptor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Analyzer$Visitor;)V", "")]
	public void visitMissingDeps(Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Module;Ljava/util/Set;Z)Lcom/sun/tools/jdeps/Module;", "private")]
	public Dova.JDK.com.sun.tools.jdeps.Module toNormalModule(Dova.JDK.com.sun.tools.jdeps.Module arg0, Dova.JDK.java.util.Set arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Module>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map computeRequiresTransitive()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/module/ModuleDescriptor;)V", "")]
	public void writeModuleInfo(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.module.ModuleDescriptor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}
}
