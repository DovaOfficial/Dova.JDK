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

namespace Dova.JDK.sun.java2d.marlin;

[JniSignatureAttribute("Lsun/java2d/marlin/DoubleArrayCache;", "final")]
public partial class DoubleArrayCache
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.marlin.MarlinConst
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoubleArrayCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DoubleArrayCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clean", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bucketCapacity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refBuckets", "Ljava/lang/ref/WeakReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stats", "Lsun/java2d/marlin/ArrayCacheConst$CacheStats;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fill", "([DIID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "check", "([DIID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createRef", "(I)Lsun/java2d/marlin/DoubleArrayCache$Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLogPrefix", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuckets", "()[Lsun/java2d/marlin/DoubleArrayCache$Bucket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCacheBucket", "(I)Lsun/java2d/marlin/DoubleArrayCache$Bucket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createArray", "(I)[D"));
	}

	[JniSignatureAttribute("Z", "final")]
	public bool clean_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int bucketCapacity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private")]
	public Dova.JDK.java.lang.@ref.WeakReference refBuckets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/ArrayCacheConst$CacheStats;", "final")]
	public Dova.JDK.sun.java2d.marlin.ArrayCacheConst.CacheStats stats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.ArrayCacheConst.CacheStats>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DoubleArrayCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZI)V", "")]
	public DoubleArrayCache(bool arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DoubleArrayCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([DIID)V", "static")]
	public static void fill(JavaArray<double> arg0, int arg1, int arg2, double arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([DIID)V", "static")]
	public static void check(JavaArray<double> arg0, int arg1, int arg2, double arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)Lsun/java2d/marlin/DoubleArrayCache$Reference;", "")]
	public Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Reference createRef(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Reference>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getLogPrefix(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/java2d/marlin/DoubleArrayCache$Bucket;", "private")]
	public JavaArray<Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Bucket> getBuckets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Bucket>>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/java2d/marlin/DoubleArrayCache$Bucket;", "")]
	public Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Bucket getCacheBucket(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Bucket>(ret);
	}

	[JniSignatureAttribute("(I)[D", "static")]
	public static JavaArray<double> createArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/DoubleArrayCache$Bucket;", "static final")]
	public partial class Bucket
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Bucket()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DoubleArrayCache$Bucket;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arraySize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clean", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arrays", "[[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stats", "Lsun/java2d/marlin/ArrayCacheConst$BucketStats;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZIILsun/java2d/marlin/ArrayCacheConst$BucketStats;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "()[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putArray", "([D)V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int tail_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int arraySize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool clean_Property
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

		[JniSignatureAttribute("[[D", "private final")]
		public JavaArray<JavaArray<double>> arrays_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<double>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/ArrayCacheConst$BucketStats;", "private final")]
		public Dova.JDK.sun.java2d.marlin.ArrayCacheConst.BucketStats stats_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.ArrayCacheConst.BucketStats>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Bucket(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZIILsun/java2d/marlin/ArrayCacheConst$BucketStats;)V", "")]
		public Bucket(bool arg0, int arg1, int arg2, Dova.JDK.sun.java2d.marlin.ArrayCacheConst.BucketStats arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DoubleArrayCache$Bucket;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[D", "")]
		public JavaArray<double> getArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("([D)V", "")]
		public void putArray(JavaArray<double> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/DoubleArrayCache$Reference;", "static final")]
	public partial class Reference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Reference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DoubleArrayCache$Reference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initial", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clean", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cache", "Lsun/java2d/marlin/DoubleArrayCache;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/marlin/DoubleArrayCache;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(I)[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putArray", "([D)[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putArray", "([DII)[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "widenArray", "([DII)[D"));
		}

		[JniSignatureAttribute("[D", "final")]
		public JavaArray<double> initial_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool clean_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DoubleArrayCache;", "private final")]
		public Dova.JDK.sun.java2d.marlin.DoubleArrayCache cache_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DoubleArrayCache>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Reference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/DoubleArrayCache;I)V", "")]
		public Reference(Dova.JDK.sun.java2d.marlin.DoubleArrayCache arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DoubleArrayCache$Reference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)[D", "")]
		public JavaArray<double> getArray(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("([D)[D", "")]
		public JavaArray<double> putArray(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("([DII)[D", "")]
		public JavaArray<double> putArray(JavaArray<double> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("([DII)[D", "")]
		public JavaArray<double> widenArray(JavaArray<double> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}
	}
}
