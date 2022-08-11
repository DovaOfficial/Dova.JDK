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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency;", "public abstract interface")]
public partial interface Dependency
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Dependency()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependency;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lcom/sun/tools/classfile/Dependency$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrigin", "()Lcom/sun/tools/classfile/Dependency$Location;"));
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Location;", "public abstract")]
	Dova.JDK.com.sun.tools.classfile.Dependency.Location getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Location;", "public abstract")]
	Dova.JDK.com.sun.tools.classfile.Dependency.Location getOrigin()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Location;", "public abstract static interface")]
	public partial interface Location
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Location()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependency$Location;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getPackageName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getClassName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Finder;", "public abstract static interface")]
	public partial interface Finder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Finder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependency$Finder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDependencies", "(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;", "public abstract")]
		Dova.JDK.java.lang.Iterable findDependencies(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Filter;", "public abstract static interface")]
	public partial interface Filter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Filter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependency$Filter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Lcom/sun/tools/classfile/Dependency;)Z"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency;)Z", "public abstract")]
		bool accepts(Dova.JDK.com.sun.tools.classfile.Dependency arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
