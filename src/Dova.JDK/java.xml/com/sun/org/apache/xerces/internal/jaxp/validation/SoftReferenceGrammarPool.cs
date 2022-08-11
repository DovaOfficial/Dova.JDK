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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool;", "final")]
public partial class SoftReferenceGrammarPool
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftReferenceGrammarPool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO_LENGTH_GRAMMAR_ARRAY", "[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammars", "[Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPoolIsLocked", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fReferenceQueue", "Ljava/lang/ref/ReferenceQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clean", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeEntry", "(Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveInitialGrammarSet", "(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheGrammars", "(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlockPool", "()V"));
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int TABLE_SIZE_Property
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

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "protected static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> ZERO_LENGTH_GRAMMAR_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;", "protected")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry> fGrammars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fPoolIsLocked_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int fGrammarCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "protected final")]
	public Dova.JDK.java.lang.@ref.ReferenceQueue fReferenceQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SoftReferenceGrammarPool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SoftReferenceGrammarPool() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public SoftReferenceGrammarPool(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z", "public")]
	public bool equals(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)I", "public")]
	public int hashCode(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void clean()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar removeEntry(Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public void putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar getGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar removeGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z", "public")]
	public bool containsGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> retrieveInitialGrammarSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public void cacheGrammars(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar retrieveGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void lockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void unlockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;", "static final")]
	public partial class Entry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Entry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hash", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bucket", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "desc", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "grammar", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$SoftGrammarReference;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;Ljava/lang/ref/ReferenceQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int hash_Property
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

		[JniSignatureAttribute("I", "public")]
		public int bucket_Property
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

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry prev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription desc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$SoftGrammarReference;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.SoftGrammarReference grammar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.SoftGrammarReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IILcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;Ljava/lang/ref/ReferenceQueue;)V", "protected")]
		public Entry(int arg0, int arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry arg4, Dova.JDK.java.lang.@ref.ReferenceQueue arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$SoftGrammarReference;", "static final")]
	public partial class SoftGrammarReference
		: Dova.JDK.java.lang.@ref.SoftReference
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SoftGrammarReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$SoftGrammarReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entry", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Ljava/lang/ref/ReferenceQueue;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry entry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SoftGrammarReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$Entry;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Ljava/lang/ref/ReferenceQueue;)V", "protected")]
		public SoftGrammarReference(Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.SoftReferenceGrammarPool.Entry arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg1, Dova.JDK.java.lang.@ref.ReferenceQueue arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SoftReferenceGrammarPool$SoftGrammarReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
