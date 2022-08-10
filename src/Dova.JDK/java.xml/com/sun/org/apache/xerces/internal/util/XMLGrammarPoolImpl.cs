/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl;", "public")]
public partial class XMLGrammarPoolImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLGrammarPoolImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TABLE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammars", "[Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fPoolIsLocked", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fGrammarCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XMLGrammarPoolImpl", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XMLGrammarPoolImpl", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "containsGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "retrieveInitialGrammarSet", "(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cacheGrammars", "(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "retrieveGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lockPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unlockPool", "()V"));
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int TABLE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;", "protected")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLGrammarPoolImpl.Entry> fGrammars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLGrammarPoolImpl.Entry>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fPoolIsLocked_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "protected")]
	public int fGrammarCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLGrammarPoolImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLGrammarPoolImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public XMLGrammarPoolImpl(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl;";
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

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public void putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar getGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar removeGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z", "public")]
	public bool containsGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> retrieveInitialGrammarSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public void cacheGrammars(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar retrieveGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void lockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void unlockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;", "protected static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hash", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "desc", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "grammar", "Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "next", "Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Entry", "(ILcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int hash_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription desc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar grammar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLGrammarPoolImpl.Entry next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLGrammarPoolImpl.Entry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;)V", "protected")]
		public Entry(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLGrammarPoolImpl.Entry arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/util/XMLGrammarPoolImpl$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
