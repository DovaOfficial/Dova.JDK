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

[JniSignatureAttribute("Ljdk/jpackage/internal/PathGroup;", "final")]
public partial class PathGroup
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PathGroup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/PathGroup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljdk/jpackage/internal/PathGroup;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copy", "(Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup$TransformHandler;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copy", "(ZLjava/util/List;Ljava/util/List;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "roots", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljava/lang/Object;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paths", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljdk/jpackage/internal/PathGroup;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAt", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/PathGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sizeInBytes", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizedPaths", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPath", "(Ljava/lang/Object;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizedPath", "(Ljava/nio/file/Path;)Ljava/util/Map$Entry;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map entries_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PathGroup(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "")]
	public PathGroup(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/PathGroup;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V", "")]
	public void transform(Dova.JDK.jdk.jpackage.@internal.PathGroup arg0, Dova.JDK.jdk.jpackage.@internal.PathGroup.TransformHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup;)V", "")]
	public void copy(Dova.JDK.jdk.jpackage.@internal.PathGroup arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup;Ljdk/jpackage/internal/PathGroup$TransformHandler;Z)V", "private static")]
	public static void copy(Dova.JDK.jdk.jpackage.@internal.PathGroup arg0, Dova.JDK.jdk.jpackage.@internal.PathGroup arg1, Dova.JDK.jdk.jpackage.@internal.PathGroup.TransformHandler arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ZLjava/util/List;Ljava/util/List;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V", "private static")]
	public static void copy(bool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.jdk.jpackage.@internal.PathGroup.TransformHandler arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List roots()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/nio/file/Path;", "")]
	public Dova.JDK.java.nio.file.Path getPath(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List paths()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup;)V", "")]
	public void move(Dova.JDK.jdk.jpackage.@internal.PathGroup arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/PathGroup;", "")]
	public Dova.JDK.jdk.jpackage.@internal.PathGroup resolveAt(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.PathGroup>(ret);
	}

	[JniSignatureAttribute("()J", "")]
	public long sizeInBytes()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List normalizedPaths()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/Path;)V", "")]
	public void setPath(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Map$Entry;", "private static")]
	public static Dova.JDK.java.util.Map.Entry normalizedPath(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map.Entry>(ret);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/PathGroup$TransformHandler;", "abstract static interface")]
	public partial interface TransformHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TransformHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/PathGroup$TransformHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDirectory", "(Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public abstract")]
		void createDirectory(Dova.JDK.java.nio.file.Path arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "public abstract")]
		void copyFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/PathGroup$Facade;", "abstract static interface")]
	public partial interface Facade
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Facade()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/PathGroup$Facade;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljdk/jpackage/internal/PathGroup$Facade;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljdk/jpackage/internal/PathGroup$Facade;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "roots", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paths", "()Ljava/util/Collection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljdk/jpackage/internal/PathGroup$Facade;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAt", "(Ljava/nio/file/Path;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pathGroup", "()Ljdk/jpackage/internal/PathGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sizeInBytes", "()J"));
		}

		[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup$Facade;Ljdk/jpackage/internal/PathGroup$TransformHandler;)V", "public")]
		void transform(Dova.JDK.jdk.jpackage.@internal.PathGroup.Facade arg0, Dova.JDK.jdk.jpackage.@internal.PathGroup.TransformHandler arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup$Facade;)V", "public")]
		void copy(Dova.JDK.jdk.jpackage.@internal.PathGroup.Facade arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		Dova.JDK.java.util.List roots()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
		Dova.JDK.java.util.Collection paths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jpackage/internal/PathGroup$Facade;)V", "public")]
		void move(Dova.JDK.jdk.jpackage.@internal.PathGroup.Facade arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object resolveAt(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jpackage/internal/PathGroup;", "public abstract")]
		Dova.JDK.jdk.jpackage.@internal.PathGroup pathGroup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.PathGroup>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		long sizeInBytes()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}
}
