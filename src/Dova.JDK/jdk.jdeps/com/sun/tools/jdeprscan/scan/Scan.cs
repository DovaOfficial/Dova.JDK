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

namespace Dova.JDK.com.sun.tools.jdeprscan.scan;

[JniSignatureAttribute("Lcom/sun/tools/jdeprscan/scan/Scan;", "public")]
public partial class Scan
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Scan()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeprscan/scan/Scan;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "err", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classPath", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "db", "Lcom/sun/tools/jdeprscan/DeprDB;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verbose", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finder", "Lcom/sun/tools/jdeprscan/scan/ClassFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classesNotFound", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorOccurred", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descTypePattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTypePattern", "Ljava/util/regex/Pattern;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/util/List;Lcom/sun/tools/jdeprscan/DeprDB;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nameFromDescType", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClass", "(Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInterfaces", "(Ljava/util/Deque;Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHasMethodParmType", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printField", "(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHasField", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHasMethodRetType", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHasOverriddenMethod", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSuper", "(Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkInterfaces", "(Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClasses", "(Lcom/sun/tools/classfile/ClassFile;Lcom/sun/tools/jdeprscan/scan/CPEntries;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethodRef", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkFieldRef", "(Lcom/sun/tools/classfile/ClassFile;Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkFields", "(Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethods", "(Lcom/sun/tools/classfile/ClassFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorNoFile", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorException", "(Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printFieldType", "(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanJar", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanDir", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClassName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClassFile", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorNoClass", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberPresent", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorNoMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nameFromRefType", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveMember", "(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printMethod", "(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dep", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printType", "(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeKind", "(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream err_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List classPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeprscan/DeprDB;", "final")]
	public Dova.JDK.com.sun.tools.jdeprscan.DeprDB db_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeprscan.DeprDB>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool verbose_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeprscan/scan/ClassFinder;", "final")]
	public Dova.JDK.com.sun.tools.jdeprscan.scan.ClassFinder finder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeprscan.scan.ClassFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "final")]
	public Dova.JDK.java.util.Set classesNotFound_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool errorOccurred_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "")]
	public Dova.JDK.java.util.regex.Pattern descTypePattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "")]
	public Dova.JDK.java.util.regex.Pattern refTypePattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Scan(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/util/List;Lcom/sun/tools/jdeprscan/DeprDB;Z)V", "public")]
	public Scan(Dova.JDK.java.io.PrintStream arg0, Dova.JDK.java.io.PrintStream arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.jdeprscan.DeprDB arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeprscan/scan/Scan;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String nameFromDescType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void processClass(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Deque;Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void addInterfaces(Dova.JDK.java.util.Deque arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printHasMethodParmType(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printField(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printHasField(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printHasMethodRetType(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printHasOverriddenMethod(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void checkSuper(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void checkInterfaces(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Lcom/sun/tools/jdeprscan/scan/CPEntries;)V", "")]
	public void checkClasses(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/String;)V", "")]
	public void checkMethodRef(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;)V", "")]
	public void checkFieldRef(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void checkFields(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)V", "")]
	public void checkMethods(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void errorNoFile(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)V", "")]
	public void errorException(Dova.JDK.java.lang.Exception arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printFieldType(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, bool arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool scanJar(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool scanDir(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool processClassName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool processClassFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void errorNoClass(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
	public bool isMemberPresent(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
	public void errorNoMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String nameFromRefType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String resolveMember(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void printMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, bool arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String dep(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/classfile/ClassFile;Ljava/lang/String;Z)V", "")]
	public void printType(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String typeKind(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
