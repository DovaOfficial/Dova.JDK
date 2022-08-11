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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/Repository;", "public final")]
public partial class Repository
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Repository()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/Repository;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_REPO_CREATION_RETRIES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jvm", "Ljdk/jfr/internal/JVM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Ljdk/jfr/internal/Repository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JFR_REPOSITORY_LOCATION_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanupDirectories", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseLocation", "Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "repository", "Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkFilename", "Ljdk/jfr/internal/management/ChunkFilename;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureRepository", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newChunk", "()Ljdk/jfr/internal/RepositoryChunk;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBasePath", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRepository", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRealBasePath", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tryToUseAsRepository", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepositoryPath", "()Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRepository", "()Ljdk/jfr/internal/Repository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseLocation", "()Ljdk/jfr/internal/SecuritySupport$SafePath;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_REPO_CREATION_RETRIES_Property
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

	[JniSignatureAttribute("Ljdk/jfr/internal/JVM;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.JVM jvm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.JVM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Repository;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Repository instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Repository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String JFR_REPOSITORY_LOCATION_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set cleanupDirectories_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SafePath;", "private")]
	public Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath baseLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SafePath;", "private")]
	public Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath repository_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/management/ChunkFilename;", "private")]
	public Dova.JDK.jdk.jfr.@internal.management.ChunkFilename chunkFilename_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.management.ChunkFilename>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Repository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Repository() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/Repository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "synchronized")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void ensureRepository()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/RepositoryChunk;", "synchronized")]
	public Dova.JDK.jdk.jfr.@internal.RepositoryChunk newChunk()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.RepositoryChunk>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "public synchronized")]
	public void setBasePath(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath createRepository(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath createRealBasePath(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z", "private static")]
	public static bool tryToUseAsRepository(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/SecuritySupport$SafePath;", "public synchronized")]
	public Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath getRepositoryPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/Repository;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.Repository getRepository()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Repository>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/SecuritySupport$SafePath;", "public synchronized")]
	public Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath getBaseLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}
}
