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

namespace Dova.JDK.com.sun.tools.javac.file;

[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "public")]
public partial class Locations
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Locations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsInfo", "Lcom/sun/tools/javac/file/FSInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warn", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleNameReader", "Lcom/sun/tools/javac/jvm/ModuleNameReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathFactory", "Ljavax/tools/StandardJavaFileManager$PathFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaHome", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "thisSystemModules", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileSystems", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeables", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsEnv", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handlersForLocation", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handlersForOption", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Lcom/sun/tools/javac/util/Log;ZLcom/sun/tools/javac/file/FSInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/util/Collection;Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljavax/tools/JavaFileManager$Location;Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "(Ljavax/tools/JavaFileManager$Location;)Lcom/sun/tools/javac/file/Locations$LocationHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArchive", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathFactory", "(Ljavax/tools/StandardJavaFileManager$PathFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasExplicitLocation", "(Ljavax/tools/JavaFileManager$Location;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefaultBootClassPath", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefaultSystemModulesPath", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMultiReleaseValue", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathEntries", "(Ljava/lang/String;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathEntries", "(Ljava/lang/String;Ljava/nio/file/Path;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initHandlers", "()V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/FSInfo;", "private")]
	public Dova.JDK.com.sun.tools.javac.file.FSInfo fsInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.FSInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool warn_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ModuleNameReader;", "private")]
	public Dova.JDK.com.sun.tools.javac.jvm.ModuleNameReader moduleNameReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ModuleNameReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager$PathFactory;", "private")]
	public Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory pathFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "static final")]
	public static Dova.JDK.java.nio.file.Path javaHome_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "static final")]
	public static Dova.JDK.java.nio.file.Path thisSystemModules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map fileSystems_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List closeables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map fsEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map handlersForLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map handlersForOption_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Locations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Locations() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log;ZLcom/sun/tools/javac/file/FSInfo;)V", "")]
	public void update(Dova.JDK.com.sun.tools.javac.util.Log arg0, bool arg1, Dova.JDK.com.sun.tools.javac.file.FSInfo arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/nio/file/Path;)Z", "private")]
	public bool contains(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/nio/file/Path;)Z", "")]
	public bool contains(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/util/Collection;", "")]
	public Dova.JDK.java.util.Collection getLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "static")]
	public static Dova.JDK.java.nio.file.Path normalize(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;", "transient")]
	public Dova.JDK.java.nio.file.Path getPath(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Lcom/sun/tools/javac/file/Locations$LocationHandler;", "protected")]
	public Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler getHandler(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "private")]
	public bool isArchive(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V", "")]
	public void setLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.Iterable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
	public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
	public void setLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Iterable arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/tools/StandardJavaFileManager$PathFactory;)V", "")]
	public void setPathFactory(Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Z", "")]
	public bool hasLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
	public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
	public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String inferModuleName(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "")]
	public Dova.JDK.java.lang.Iterable listLocationsForModules(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Z", "")]
	public bool hasExplicitLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/nio/file/Path;", "")]
	public Dova.JDK.java.nio.file.Path getOutputLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isDefaultBootClassPath()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isDefaultSystemModulesPath()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setMultiReleaseValue(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable getPathEntries(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/file/Path;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable getPathEntries(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void initHandlers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$LocationHandler;", "protected abstract static")]
	public partial class LocationHandler
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$LocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExplicit", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public LocationHandler() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$LocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "abstract")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isSet()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "abstract")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String inferModuleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "abstract")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Z", "abstract")]
		public bool isExplicit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "abstract")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "abstract")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$BootClassPathLocationHandler;", "private")]
	public partial class BootClassPathLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BootClassPathLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$BootClassPathLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchPath", "Ljava/util/Collection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optionValues", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDefault", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefault", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canonicalize", "(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/main/Option;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazy", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePath", "()Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "systemClasses", "()Ljava/util/Collection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Ljava/util/Collection;", "private")]
		public Dova.JDK.java.util.Collection searchPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map optionValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isDefault_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BootClassPathLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "")]
		public BootClassPathLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$BootClassPathLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isDefault()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/main/Option;", "private")]
		public Dova.JDK.com.sun.tools.javac.main.Option canonicalize(Dova.JDK.com.sun.tools.javac.main.Option arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void lazy()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/file/Locations$SearchPath;", "")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath computePath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "private")]
		public Dova.JDK.java.util.Collection systemClasses()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$SystemModulesLocationHandler;", "private")]
	public partial class SystemModulesLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemModulesLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$SystemModulesLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemJavaHome", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modules", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleTable", "Lcom/sun/tools/javac/file/Locations$ModuleTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPaths", "(Ljava/lang/Iterable;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSystemModules", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCurrentPlatform", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
		public Dova.JDK.java.nio.file.Path systemJavaHome_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
		public Dova.JDK.java.nio.file.Path modules_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable moduleTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SystemModulesLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "")]
		public SystemModulesLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$SystemModulesLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "private")]
		public void update(Dova.JDK.java.nio.file.Path arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List checkPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void initSystemModules()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "private")]
		public bool isCurrentPlatform(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$BasicLocationHandler;", "private abstract static")]
	public partial class BasicLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$BasicLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Ljavax/tools/JavaFileManager$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "explicit", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSingletonDirectory", "(Ljava/lang/Iterable;)Ljava/nio/file/Path;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExplicit", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDirectory", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileManager$Location;", "final")]
		public Dova.JDK.javax.tools.JavaFileManager.Location location_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set options_Property
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
		public bool @explicit_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V", "protected transient")]
		public BasicLocationHandler(Dova.JDK.javax.tools.JavaFileManager.Location arg0, JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$BasicLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/nio/file/Path;", "protected")]
		public Dova.JDK.java.nio.file.Path checkSingletonDirectory(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isExplicit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "protected")]
		public Dova.JDK.java.nio.file.Path checkDirectory(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ClassPathLocationHandler;", "private")]
	public partial class ClassPathLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.SimpleLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassPathLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ClassPathLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazy", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPath", "()Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePath", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassPathLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "")]
		public ClassPathLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ClassPathLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "private")]
		public void lazy()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/file/Locations$SearchPath;", "protected")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath createPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "protected")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath computePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$SimpleLocationHandler;", "private")]
	public partial class SimpleLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$SimpleLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchPath", "Ljava/util/Collection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPath", "()Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePath", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Ljava/util/Collection;", "protected")]
		public Dova.JDK.java.util.Collection searchPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V", "transient")]
		public SimpleLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0, Dova.JDK.javax.tools.JavaFileManager.Location arg1, JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$SimpleLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/file/Locations$SearchPath;", "protected")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath createPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "protected")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath computePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$OutputLocationHandler;", "private")]
	public partial class OutputLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OutputLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$OutputLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputDir", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleTable", "Lcom/sun/tools/javac/file/Locations$ModuleTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
		public Dova.JDK.java.nio.file.Path outputDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable moduleTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool listed_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OutputLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V", "transient")]
		public OutputLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0, Dova.JDK.javax.tools.JavaFileManager.Location arg1, JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$OutputLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleSourcePathLocationHandler;", "private")]
	public partial class ModuleSourcePathLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleSourcePathLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ModuleSourcePathLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleTable", "Lcom/sun/tools/javac/file/Locations$ModuleTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paths", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkModuleInfo", "Ljava/util/function/Predicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/util/Map;Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFromPattern", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandBraces", "(Ljava/lang/String;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSeparator", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initModuleTable", "(Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchingBrace", "(Ljava/lang/String;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initForModule", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPaths", "(Ljava/lang/Iterable;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable moduleTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List paths_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
		public Dova.JDK.java.util.function.Predicate checkModuleInfo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleSourcePathLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "")]
		public ModuleSourcePathLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ModuleSourcePathLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "")]
		public void add(Dova.JDK.java.util.Map arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void init(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isSet()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void initFromPattern(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)V", "private")]
		public void expandBraces(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(C)Z", "private")]
		public bool isSeparator(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Map;)V", "private")]
		public void initModuleTable(Dova.JDK.java.util.Map arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)I", "")]
		public int getMatchingBrace(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void initForModule(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List checkPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$PatchModulesLocationHandler;", "private")]
	public partial class PatchModulesLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.BasicLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PatchModulesLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$PatchModulesLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleTable", "Lcom/sun/tools/javac/file/Locations$ModuleTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable moduleTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PatchModulesLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "")]
		public PatchModulesLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$PatchModulesLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isSet()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;", "private")]
	public partial class ModulePathLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.SimpleLocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModulePathLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleTable", "Lcom/sun/tools/javac/file/Locations$ModuleTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initModuleLocations", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkValidModulePathEntry", "(Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPaths", "(Ljava/lang/Iterable;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModuleName", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable moduleTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModulePathLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;Ljavax/tools/JavaFileManager$Location;[Lcom/sun/tools/javac/main/Option;)V", "transient")]
		public ModulePathLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0, Dova.JDK.javax.tools.JavaFileManager.Location arg1, JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void initModuleLocations()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "private")]
		public void checkValidModulePathEntry(Dova.JDK.java.nio.file.Path arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List checkPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
		public bool isModuleName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "public")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "public")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileManager$Location;", "public")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler$ModulePathIterator;", "")]
		public partial class ModulePathIterator
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.Iterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ModulePathIterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler$ModulePathIterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathIter", "Ljava/util/Iterator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathIndex", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanDirectory", "(Ljava/nio/file/Path;)Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanFile", "(Ljava/nio/file/Path;)Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readModuleName", "(Ljava/nio/file/Path;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/Pair;"));
			}

			[JniSignatureAttribute("Ljava/util/Iterator;", "")]
			public Dova.JDK.java.util.Iterator pathIter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "")]
			public int pathIndex_Property
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

			[JniSignatureAttribute("Ljava/util/Set;", "")]
			public Dova.JDK.java.util.Set next_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;", "final")]
			public Dova.JDK.com.sun.tools.javac.file.Locations.ModulePathLocationHandler this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModulePathLocationHandler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ModulePathIterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler;)V", "")]
			public ModulePathIterator(Dova.JDK.com.sun.tools.javac.file.Locations.ModulePathLocationHandler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ModulePathLocationHandler$ModulePathIterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "public")]
			public bool hasNext()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object next_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Set;", "public")]
			public Dova.JDK.java.util.Set next_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Set;", "private")]
			public Dova.JDK.java.util.Set scanDirectory(Dova.JDK.java.nio.file.Path arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Set;", "private")]
			public Dova.JDK.java.util.Set scanFile(Dova.JDK.java.nio.file.Path arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String readModuleName(Dova.JDK.java.nio.file.Path arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/Pair;", "private")]
			public Dova.JDK.com.sun.tools.javac.util.Pair inferModuleName(Dova.JDK.java.nio.file.Path arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleTable;", "private")]
	public partial class ModuleTable
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleTable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ModuleTable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locations", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "explicitLocations", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePaths", "(Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map nameMap_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map pathMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleTable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "private")]
		public ModuleTable(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ModuleTable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;)V", "")]
		public void add(Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;", "")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler get(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;", "")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler get(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set locations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set explicitLocations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;)V", "")]
		public void updatePaths(Dova.JDK.com.sun.tools.javac.file.Locations.ModuleLocationHandler arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;", "private")]
	public partial class ModuleLocationHandler
		: Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler
		, Dova.JDK.javax.tools.JavaFileManager.Location
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleLocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Lcom/sun/tools/javac/file/Locations$LocationHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "output", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "explicit", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchPath", "Ljava/util/Collection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;Lcom/sun/tools/javac/file/Locations$LocationHandler;Ljava/lang/String;Ljava/lang/String;Ljava/util/Collection;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOutputLocation", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaths", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExplicit", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathsForModule", "(Ljava/lang/String;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaths", "()Ljava/util/Collection;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$LocationHandler;", "private final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler parent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String moduleName_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool output_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool @explicit_Property
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

		[JniSignatureAttribute("Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection searchPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleLocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;Lcom/sun/tools/javac/file/Locations$LocationHandler;Ljava/lang/String;Ljava/lang/String;Ljava/util/Collection;Z)V", "")]
		public ModuleLocationHandler(Dova.JDK.com.sun.tools.javac.file.Locations arg0, Dova.JDK.com.sun.tools.javac.file.Locations.LocationHandler arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.Collection arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$ModuleLocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "")]
		public bool contains(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isOutputLocation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Z", "")]
		public bool handleOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String inferModuleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "")]
		public void setPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isExplicit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)V", "")]
		public void setPathsForModule(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "")]
		public Dova.JDK.java.util.Collection getPaths()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations$SearchPath;", "private")]
	public partial class SearchPath
		: Dova.JDK.java.util.LinkedHashSet
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SearchPath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/Locations$SearchPath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandJarClassPaths", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canonicalValues", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "emptyPathDefault", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/file/Locations;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/Locations;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFile", "(Ljava/nio/file/Path;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFiles", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFiles", "(Ljava/lang/Iterable;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFiles", "(Ljava/lang/String;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFiles", "(Ljava/lang/Iterable;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDirectories", "(Ljava/lang/String;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDirectories", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandJarClassPaths", "(Z)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDirectory", "(Ljava/nio/file/Path;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addJarClassPath", "(Ljava/nio/file/Path;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyPathDefault", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/Locations$SearchPath;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool expandJarClassPaths_Property
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

		[JniSignatureAttribute("Ljava/util/Set;", "private final transient")]
		public Dova.JDK.java.util.Set canonicalValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private transient")]
		public Dova.JDK.java.nio.file.Path emptyPathDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/Locations;", "final")]
		public Dova.JDK.com.sun.tools.javac.file.Locations this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SearchPath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/Locations;)V", "private")]
		public SearchPath(Dova.JDK.com.sun.tools.javac.file.Locations arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/Locations$SearchPath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/file/Path;Z)V", "public")]
		public void addFile(Dova.JDK.java.nio.file.Path arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addFiles(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addFiles(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addFiles(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addFiles(Dova.JDK.java.lang.Iterable arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addDirectories(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath addDirectories(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath expandJarClassPaths(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Z)V", "private")]
		public void addDirectory(Dova.JDK.java.nio.file.Path arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Z)V", "private")]
		public void addJarClassPath(Dova.JDK.java.nio.file.Path arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/Locations$SearchPath;", "public")]
		public Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath emptyPathDefault(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.Locations.SearchPath>(ret);
		}
	}
}
