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

namespace Dova.JDK.sun.security.util;

[JniSignatureAttribute("Lsun/security/util/DomainName;", "")]
public partial class DomainName
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DomainName()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMatch", "(Ljava/lang/String;)Lsun/security/util/DomainName$Match;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registeredDomain", "(Ljava/lang/String;)Lsun/security/util/RegisteredDomain;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map cache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DomainName(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DomainName() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/util/DomainName;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Match;", "private static")]
	public static Dova.JDK.sun.security.util.DomainName.Match getMatch(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/RegisteredDomain;", "public static")]
	public static Dova.JDK.sun.security.util.RegisteredDomain registeredDomain(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain>(ret);
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$Match;", "private abstract static interface")]
	public partial interface Match
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Match()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$Match;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Lsun/security/util/DomainName$Rule$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registeredDomain", "()Lsun/security/util/RegisteredDomain;"));
		}

		[JniSignatureAttribute("()Lsun/security/util/DomainName$Rule$Type;", "public abstract")]
		Dova.JDK.sun.security.util.DomainName.Rule.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/RegisteredDomain;", "public abstract")]
		Dova.JDK.sun.security.util.RegisteredDomain registeredDomain()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$Rules;", "private static")]
	public partial class Rules
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rules()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$Rules;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ruleSets", "Ljava/util/LinkedList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasExceptions", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/lang/String;)Lsun/security/util/DomainName$Match;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRules", "(Ljava/lang/String;Ljava/util/zip/ZipInputStream;)Lsun/security/util/DomainName$Rules;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRules", "(Ljava/lang/String;)Lsun/security/util/DomainName$Rules;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRuleSet", "(I)Lsun/security/util/DomainName$Rules$RuleSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTopLevelDomain", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPubSuffixStream", "()Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRules", "(Ljava/lang/String;)Lsun/security/util/DomainName$Rules;"));
		}

		[JniSignatureAttribute("Ljava/util/LinkedList;", "private final")]
		public Dova.JDK.java.util.LinkedList ruleSets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool hasExceptions_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Rules(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;)V", "private")]
		public Rules(Dova.JDK.java.io.InputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$Rules;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Match;", "")]
		public Dova.JDK.sun.security.util.DomainName.Match match(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/zip/ZipInputStream;)Lsun/security/util/DomainName$Rules;", "private static")]
		public static Dova.JDK.sun.security.util.DomainName.Rules getRules(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.zip.ZipInputStream arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rules>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Rules;", "static")]
		public static Dova.JDK.sun.security.util.DomainName.Rules getRules(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rules>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/security/util/DomainName$Rules$RuleSet;", "private")]
		public Dova.JDK.sun.security.util.DomainName.Rules.RuleSet getRuleSet(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rules.RuleSet>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String getTopLevelDomain(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/InputStream;", "private static")]
		public static Dova.JDK.java.io.InputStream getPubSuffixStream()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Rules;", "private static")]
		public static Dova.JDK.sun.security.util.DomainName.Rules createRules(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rules>(ret);
		}

		[JniSignatureAttribute("Lsun/security/util/DomainName$Rules$RuleSet;", "private static")]
		public partial class RuleSet
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RuleSet()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$Rules$RuleSet;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numLabels", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rules", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasExceptions", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTHS", "[Lsun/security/util/RegisteredDomain$Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "split", "(Ljava/lang/String;)Ljava/util/LinkedList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/lang/String;)Lsun/security/util/DomainName$Match;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "labels", "(Ljava/lang/String;I)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "numLabels", "(Ljava/lang/String;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRule", "(ILjava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchNormal", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchWildcard", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchOther", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchException", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;"));
			}

			[JniSignatureAttribute("I", "private final")]
			public int numLabels_Property
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

			[JniSignatureAttribute("Ljava/util/Set;", "private final")]
			public Dova.JDK.java.util.Set rules_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "")]
			public bool hasExceptions_Property
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

			[JniSignatureAttribute("[Lsun/security/util/RegisteredDomain$Type;", "private static final")]
			public static JavaArray<Dova.JDK.sun.security.util.RegisteredDomain.Type> AUTHS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.RegisteredDomain.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RuleSet(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(I)V", "")]
			public RuleSet(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$Rules$RuleSet;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/LinkedList;", "private static")]
			public static Dova.JDK.java.util.LinkedList split(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Match;", "")]
			public Dova.JDK.sun.security.util.DomainName.Match match(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)I", "private static")]
			public static int labels(Dova.JDK.java.lang.String arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/String;)I", "private static")]
			public static int numLabels(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("(ILjava/lang/String;)V", "")]
			public void addRule(int arg0, Dova.JDK.java.lang.String arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;", "private")]
			public Dova.JDK.sun.security.util.DomainName.Match matchNormal(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;", "private")]
			public Dova.JDK.sun.security.util.DomainName.Match matchWildcard(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;", "private")]
			public Dova.JDK.sun.security.util.DomainName.Match matchOther(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule;)Lsun/security/util/DomainName$Match;", "private")]
			public Dova.JDK.sun.security.util.DomainName.Match matchException(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Match>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$OtherMatch;", "private static")]
	public partial class OtherMatch
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.util.DomainName.Match
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OtherMatch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$OtherMatch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rule", "Lsun/security/util/DomainName$Rule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numLabels", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/util/LinkedList;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/DomainName$Rule;ILjava/util/LinkedList;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Lsun/security/util/DomainName$Rule$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registeredDomain", "()Lsun/security/util/RegisteredDomain;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuffixes", "(I)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lsun/security/util/DomainName$Rule;", "private final")]
		public Dova.JDK.sun.security.util.DomainName.Rule rule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int numLabels_Property
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

		[JniSignatureAttribute("Ljava/util/LinkedList;", "private final")]
		public Dova.JDK.java.util.LinkedList target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OtherMatch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/DomainName$Rule;ILjava/util/LinkedList;)V", "")]
		public OtherMatch(Dova.JDK.sun.security.util.DomainName.Rule arg0, int arg1, Dova.JDK.java.util.LinkedList arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$OtherMatch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/util/DomainName$Rule$Type;", "public")]
		public Dova.JDK.sun.security.util.DomainName.Rule.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/RegisteredDomain;", "public")]
		public Dova.JDK.sun.security.util.RegisteredDomain registeredDomain()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getSuffixes(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$CommonMatch;", "private static")]
	public partial class CommonMatch
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.util.DomainName.Match
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CommonMatch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$CommonMatch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "domain", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicSuffix", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredDomain", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rule", "Lsun/security/util/DomainName$Rule;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Lsun/security/util/DomainName$Rule$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registeredDomain", "()Lsun/security/util/RegisteredDomain;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String domain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int publicSuffix_Property
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

		[JniSignatureAttribute("I", "private")]
		public int registeredDomain_Property
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

		[JniSignatureAttribute("Lsun/security/util/DomainName$Rule;", "private final")]
		public Dova.JDK.sun.security.util.DomainName.Rule rule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CommonMatch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule;I)V", "")]
		public CommonMatch(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$CommonMatch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/util/DomainName$Rule$Type;", "public")]
		public Dova.JDK.sun.security.util.DomainName.Rule.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/RegisteredDomain;", "public")]
		public Dova.JDK.sun.security.util.RegisteredDomain registeredDomain()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$RegisteredDomainImpl;", "private static")]
	public partial class RegisteredDomainImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.util.RegisteredDomain
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RegisteredDomainImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$RegisteredDomainImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/security/util/RegisteredDomain$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicSuffix", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/util/RegisteredDomain$Type;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Lsun/security/util/RegisteredDomain$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "publicSuffix", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/util/RegisteredDomain$Type;", "private final")]
		public Dova.JDK.sun.security.util.RegisteredDomain.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String publicSuffix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RegisteredDomainImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/RegisteredDomain$Type;Ljava/lang/String;)V", "")]
		public RegisteredDomainImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.RegisteredDomain.Type arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$RegisteredDomainImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/util/RegisteredDomain$Type;", "public")]
		public Dova.JDK.sun.security.util.RegisteredDomain.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String publicSuffix()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$OtherRule;", "private static")]
	public partial class OtherRule
		: Dova.JDK.sun.security.util.DomainName.Rule
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OtherRule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$OtherRule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "labels", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/util/RegisteredDomain$Type;Ljava/util/List;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "")]
		public Dova.JDK.java.util.List labels_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OtherRule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/RegisteredDomain$Type;Ljava/util/List;)V", "")]
		public OtherRule(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.RegisteredDomain.Type arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$OtherRule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/util/DomainName$Rule;", "private static")]
	public partial class Rule
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$Rule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "domain", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/security/util/DomainName$Rule$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auth", "Lsun/security/util/RegisteredDomain$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/util/DomainName$Rule$Type;Lsun/security/util/RegisteredDomain$Type;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String domain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "")]
		public Dova.JDK.sun.security.util.DomainName.Rule.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/util/RegisteredDomain$Type;", "")]
		public Dova.JDK.sun.security.util.RegisteredDomain.Type auth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.RegisteredDomain.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Rule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/DomainName$Rule$Type;Lsun/security/util/RegisteredDomain$Type;)V", "")]
		public Rule(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.DomainName.Rule.Type arg1, Dova.JDK.sun.security.util.RegisteredDomain.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$Rule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "static final")]
		public partial class Type
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Type()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/DomainName$Rule$Type;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEPTION", "Lsun/security/util/DomainName$Rule$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Lsun/security/util/DomainName$Rule$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER", "Lsun/security/util/DomainName$Rule$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WILDCARD", "Lsun/security/util/DomainName$Rule$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/util/DomainName$Rule$Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/util/DomainName$Rule$Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/util/DomainName$Rule$Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/util/DomainName$Rule$Type;"));
			}

			[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "public static final")]
			public static Dova.JDK.sun.security.util.DomainName.Rule.Type EXCEPTION_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "public static final")]
			public static Dova.JDK.sun.security.util.DomainName.Rule.Type NORMAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "public static final")]
			public static Dova.JDK.sun.security.util.DomainName.Rule.Type OTHER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lsun/security/util/DomainName$Rule$Type;", "public static final")]
			public static Dova.JDK.sun.security.util.DomainName.Rule.Type WILDCARD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lsun/security/util/DomainName$Rule$Type;", "private static final")]
			public static JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Type(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/security/util/DomainName$Rule$Type;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lsun/security/util/DomainName$Rule$Type;", "public static")]
			public static JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/DomainName$Rule$Type;", "public static")]
			public static Dova.JDK.sun.security.util.DomainName.Rule.Type valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.DomainName.Rule.Type>(ret);
			}

			[JniSignatureAttribute("()[Lsun/security/util/DomainName$Rule$Type;", "private static")]
			public static JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.DomainName.Rule.Type>>(ret);
			}
		}
	}
}
