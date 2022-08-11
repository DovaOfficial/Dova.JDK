/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.hpack;

[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman;", "public final")]
public partial class QuickHuffman
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static QuickHuffman()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "codes", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOS_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOS_LSB", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOS_MSB", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "root", "Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buildTrie", "()Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addEOS", "(Ljdk/internal/net/http/hpack/QuickHuffman$Node;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addChar", "(Ljdk/internal/net/http/hpack/QuickHuffman$Node;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addLeaf", "(Ljdk/internal/net/http/hpack/QuickHuffman$Node;CIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "codeValueOf", "(C)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "codeLengthOf", "(C)J"));
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> codes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int EOS_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int EOS_LSB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long EOS_MSB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "private static final")]
	public static Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public QuickHuffman(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public QuickHuffman() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/QuickHuffman;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "private static")]
	public static Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node buildTrie()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/QuickHuffman$Node;III)V", "private static")]
	public static void addEOS(Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/QuickHuffman$Node;III)V", "private static")]
	public static void addChar(Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/QuickHuffman$Node;CIIZ)V", "private static")]
	public static void addLeaf(Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node arg0, char arg1, int arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(C)J", "private static")]
	public static long codeValueOf(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)J", "private static")]
	public static long codeLengthOf(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;", "static final")]
	public partial class TemporaryNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TemporaryNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eosPath", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "children", "[Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLength", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildren", "()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureChildrenExist", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEOSPath", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEOSPath", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreateChild_0", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreateChild_1", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSymbol", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_0", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_1", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;"));
		}

		[JniSignatureAttribute("C", "private")]
		public char symbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool eosPath_Property
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

		[JniSignatureAttribute("[Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;", "private")]
		public JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode> children_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int length_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TemporaryNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TemporaryNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setLength(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()C", "public")]
		public char getSymbol()
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLeaf()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public")]
		public JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node> getChildren()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void ensureChildrenExist()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setEOSPath(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEOSPath()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode getOrCreateChild_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode>(ret);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getOrCreateChild_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}

		[JniSignatureAttribute("(C)V", "public")]
		public void setSymbol(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getChild_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$TemporaryNode;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode getChild_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.TemporaryNode>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "abstract static interface")]
	public partial interface Node
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLength", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildren", "()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEOSPath", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEOSPath", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreateChild", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSymbol", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public abstract")]
		void setLength(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()C", "public abstract")]
		char getSymbol()
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isLeaf()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public abstract")]
		JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node> getChildren()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>>(ret);
		}

		[JniSignatureAttribute("(Z)V", "public abstract")]
		void setEOSPath(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isEOSPath()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public abstract")]
		Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getOrCreateChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}

		[JniSignatureAttribute("(C)V", "public abstract")]
		void setSymbol(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public abstract")]
		Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;", "static final")]
	public partial class ImmutableNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImmutableNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eosPath", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "children", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZI[Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(CZI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyOf", "(Ljdk/internal/net/http/hpack/QuickHuffman$Node;)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLength", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildren_0", "()[Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildren_1", "()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEOSPath", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEOSPath", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreateChild_0", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrCreateChild_1", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSymbol", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_0", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_1", "(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
		}

		[JniSignatureAttribute("C", "private final")]
		public char symbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool eosPath_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int length_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List children_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImmutableNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZI[Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;)V", "private")]
		public ImmutableNode(bool arg0, int arg1, JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(CZI)V", "private")]
		public ImmutableNode(char arg0, bool arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/hpack/QuickHuffman$Node;)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;", "public static")]
		public static Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode copyOf(Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode>(ret);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setLength(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()C", "public")]
		public char getSymbol()
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLeaf()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;", "public")]
		public JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode> getChildren_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode>>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public volatile")]
		public JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node> getChildren_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>>(ret);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setEOSPath(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEOSPath()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getOrCreateChild_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode getOrCreateChild_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode>(ret);
		}

		[JniSignatureAttribute("(C)V", "public")]
		public void setSymbol(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$ImmutableNode;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode getChild_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.ImmutableNode>(ret);
		}

		[JniSignatureAttribute("(I)Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node getChild_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$Writer;", "static final")]
	public partial class Writer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Writer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Writer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman$Writer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "UPDATER", "Ljdk/internal/net/http/hpack/HPACK$BufferUpdateConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Ljava/lang/CharSequence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padded", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferLen", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "from_0", "(Ljava/lang/CharSequence;II)Ljdk/internal/net/http/hpack/Huffman$Writer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "from_1", "(Ljava/lang/CharSequence;II)Ljdk/internal/net/http/hpack/QuickHuffman$Writer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/nio/ByteBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_0", "()Ljdk/internal/net/http/hpack/Huffman$Writer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_1", "()Ljdk/internal/net/http/hpack/QuickHuffman$Writer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthOf", "(Ljava/lang/CharSequence;II)I"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/HPACK$BufferUpdateConsumer;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.hpack.HPACK.BufferUpdateConsumer UPDATER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.HPACK.BufferUpdateConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/CharSequence;", "private")]
		public Dova.JDK.java.lang.CharSequence source_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool padded_Property
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

		[JniSignatureAttribute("I", "private")]
		public int pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int end_Property
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

		[JniSignatureAttribute("J", "private")]
		public long buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int bufferLen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Writer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Writer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/QuickHuffman$Writer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljdk/internal/net/http/hpack/Huffman$Writer;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Writer from_0(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Writer>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljdk/internal/net/http/hpack/QuickHuffman$Writer;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Writer from_1(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Writer>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public")]
		public bool write(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/Huffman$Writer;", "public volatile")]
		public Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Writer reset_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Writer>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/net/http/hpack/QuickHuffman$Writer;", "public")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Writer reset_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Writer>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II)I", "public")]
		public int lengthOf(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$Reader;", "static final")]
	public partial class Reader
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.hpack.Huffman.Reader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Reader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/hpack/QuickHuffman$Reader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "UPDATER", "Ljdk/internal/net/http/hpack/HPACK$BufferUpdateConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curr", "Ljdk/internal/net/http/hpack/QuickHuffman$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferLen", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "done", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/nio/ByteBuffer;Ljava/lang/Appendable;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/HPACK$BufferUpdateConsumer;", "private final")]
		public Dova.JDK.jdk.@internal.net.http.hpack.HPACK.BufferUpdateConsumer UPDATER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.HPACK.BufferUpdateConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/net/http/hpack/QuickHuffman$Node;", "private")]
		public Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node curr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.hpack.QuickHuffman.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int bufferLen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int len_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool done_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Reader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Reader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/hpack/QuickHuffman$Reader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Appendable;Z)V", "public")]
		public void read(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Appendable arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "public")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}
}
