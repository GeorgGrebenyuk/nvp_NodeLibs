using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Application interface
///</summary>
namespace nanoCAD.nanoCADApplication 
{

	[NVP_Manifest(
		Id = "9AF24B4D-F81A-49FA-BE27-EBB6A9FF3903", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.nanoCADApplication_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "_nanoCADApplication_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADApplication_Constructor : INode 
	{
		public nanoCAD.InanoCADApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A2E2C29B-50BA-4559-A7AB-05F624096070", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.nanoCADApplication_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "_nanoCADApplication_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADApplication_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CAB78A92-2F39-4841-9006-219376B930AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Id = "5826C159-FB4B-4F19-8A43-967677C28F3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Visible", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4280EF22-7D76-4CB7-8871-6F0E15721DB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "AE293B2C-2A09-4157-8CAB-B023196FA955", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_Caption", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_Caption", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("bstrCaption", typeof(System.String))]

	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	public class Set_Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Caption = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3735A7EC-EDA4-44FC-BA8A-FAAAF5DE93A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Caption", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Caption", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	public class Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caption);

		}
	}


	[NVP_Manifest(
		Id = "A7AC7B6B-1702-48D4-9715-F75FF853378C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "C8B8F6AD-93BD-4B7C-9FD7-9E270745B1A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ActiveDocument", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ActiveDocument", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "drawing file)", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///drawing file)
	///</summary>
	public class ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDocument);

		}
	}


	[NVP_Manifest(
		Id = "046A1C9C-2E7E-4D75-986E-082E7F7EE8B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_ActiveDocument", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_ActiveDocument", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "drawing file)", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]

	///<summary>
	///drawing file)
	///</summary>
	public class Set_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A504B11A-5509-4724-98E1-141F3BCA1A8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.FullName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "FullName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the name of the application or document, including the path", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the name of the application or document, including the path
	///</summary>
	public class FullName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullName);

		}
	}


	[NVP_Manifest(
		Id = "C28EE3B8-C62A-42D1-AC44-1BD8D2C93C48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "FC1B3CA4-EE48-46F3-BD97-CF793DDEDE5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Height", typeof(System.Int32))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B361332-A7D6-435F-A23E-AB1FC5480DFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.WindowLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "WindowLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the left edge of the application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	public class WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowLeft);

		}
	}


	[NVP_Manifest(
		Id = "714D2B0B-351A-449B-885E-CC4674956C28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_WindowLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_WindowLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the left edge of the application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("left", typeof(System.Int32))]

	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	public class Set_WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B263FC2-7912-480C-9A92-538023221C47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the path of the document, application, or external reference", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the path of the document, application, or external reference
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Id = "2E78FC8F-1656-47F5-868D-CC8694D44EF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.LocaleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "LocaleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the locale ID of the current session", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the locale ID of the current session
	///</summary>
	public class LocaleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LocaleId);

		}
	}


	[NVP_Manifest(
		Id = "10E4D9D6-274A-4311-9C79-A046DBD40817", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.WindowTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "WindowTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the top edge of the application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	public class WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTop);

		}
	}


	[NVP_Manifest(
		Id = "8E85ED4E-D0C0-424D-9928-ADE588D32EB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_WindowTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_WindowTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the top edge of the application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]

	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	public class Set_WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "48FFDEDA-6890-4882-B2E3-E7FF00711D4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Version", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Version", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the version of the application you are using", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the version of the application you are using
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	[NVP_Manifest(
		Id = "EB2CE12D-FF8F-4EB4-B286-6F6FF439315C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "CA33DEAE-B1E0-44EA-BC70-09FE13612773", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Width", typeof(System.Int32))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97CA48F9-91D8-4CE9-896E-B40D386A518A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.StatusId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "StatusId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the current active status of the viewport", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("VportObj", typeof(System.Object))]

	///<summary>
	///Gets the current active status of the viewport
	///</summary>
	public class StatusId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StatusId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "269093AF-DA6E-4540-AE24-C4AC7342F8A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates the object to the drawing screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Updates the object to the drawing screen
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ABFC548F-5DAC-4545-863A-9AE1145F162E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Quit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Quit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Closes the drawing file and exits the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Closes the drawing file and exits the application
	///</summary>
	public class Quit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quit();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "37F89BCF-BC59-4243-B9EA-0BB41BEEB018", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Documents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Documents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the documents collection.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the documents collection.
	///</summary>
	public class Documents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documents);

		}
	}


	[NVP_Manifest(
		Id = "2640D02E-3E8C-49E9-AA9B-DC05D1E343CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.WindowState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "WindowState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the state of the application or document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowState);

		}
	}


	[NVP_Manifest(
		Id = "DE218054-B46C-492E-9B22-E1EED31569B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Set_WindowState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Set_WindowState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the state of the application or document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("nanoCAD.AcWindowState", typeof(System.Object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class Set_WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowState = ((nanoCAD.AcWindowState)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1CC53CDD-9B11-4A13-B0B6-56AB225E1352", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomExtents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomExtents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to the drawing extents", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to the drawing extents
	///</summary>
	public class ZoomExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomExtents();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "641E8BFC-C69E-4044-AFF5-DE563F46ED89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to display the entire drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to display the entire drawing
	///</summary>
	public class ZoomAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomAll();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9850D986-9C1B-4494-BF3D-62E7941D15E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to a specified center point and magnification", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Magnify", typeof(System.Double))]

	///<summary>
	///Zooms the current viewport to a specified center point and magnification
	///</summary>
	public class ZoomCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomCenter(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E12D8D41-9451-45FA-A73A-804E9AA1ACE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomScaled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomScaled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to given scale factor", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]
	[NodeInput("nanoCAD.AcZoomScaleType", typeof(System.Object))]

	///<summary>
	///Zooms the current viewport to given scale factor
	///</summary>
	public class ZoomScaled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomScaled(inputs[1].Value,((nanoCAD.AcZoomScaleType)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C33E3660-37FC-4F25-ABFC-87F2B965DC14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to the area specified by two opposite corners of a rectangle", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Zooms the current viewport to the area specified by two opposite corners of a rectangle
	///</summary>
	public class ZoomWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomWindow(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A5AB4F2-B745-428B-AD42-1DBB6C73B959", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomPickWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomPickWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to a window defined by points picked on the screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to a window defined by points picked on the screen
	///</summary>
	public class ZoomPickWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPickWindow();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7F181E86-6928-4868-A431-6E252106F1CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.GetState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "GetState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves an AcadState object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Retrieves an AcadState object.
	///</summary>
	public class GetState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetState);

		}
	}


	[NVP_Manifest(
		Id = "0FA72F5F-4B04-407B-BEB9-CC6836E3E183", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ZoomPrevious", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ZoomPrevious", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Zooms the current viewport to its previous extents", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to its previous extents
	///</summary>
	public class ZoomPrevious : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPrevious();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9D6A7792-0EE0-49CC-AC34-ACE97DEC4AD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.HWND", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "HWND", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the window handle of the application window frame", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the window handle of the application window frame
	///</summary>
	public class HWND : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HWND);

		}
	}


	[NVP_Manifest(
		Id = "DC7E1E68-264E-4730-A95C-71274A4048B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Utility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Utility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Utility object for the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the Utility object for the application
	///</summary>
	public class Utility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Utility);

		}
	}


	[NVP_Manifest(
		Id = "4605611B-4581-4567-94CD-C3CC812EBE2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.SendCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "SendCommand", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sends a command string from a VB or VBA application to the document for processing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Command", typeof(System.String))]

	///<summary>
	///Sends a command string from a VB or VBA application to the document for processing
	///</summary>
	public class SendCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SendCommand(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "63EBC094-7E1E-437B-959E-F6B802DA5558", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Services", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Services", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns sevices collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns sevices collection
	///</summary>
	public class Services : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Services);

		}
	}


	[NVP_Manifest(
		Id = "ABDD7E3D-D365-40E8-99DA-31C4EF561E2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.AllUsersAppData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "AllUsersAppData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the AllUsersAppData", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the AllUsersAppData
	///</summary>
	public class AllUsersAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllUsersAppData);

		}
	}


	[NVP_Manifest(
		Id = "2B8547D9-315A-4B89-9169-F24A2765567D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.CurUserAppData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "CurUserAppData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the CurUserAppData", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the CurUserAppData
	///</summary>
	public class CurUserAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurUserAppData);

		}
	}


	[NVP_Manifest(
		Id = "95302440-2FE2-4955-A677-90F463CC82D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Profile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Profile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the root Profile section", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the root Profile section
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}


	[NVP_Manifest(
		Id = "A46B4D1B-F871-40A4-951F-70622301BEAD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Help", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Help", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Invokes help with topic", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("topic", typeof(System.String))]

	///<summary>
	///Invokes help with topic
	///</summary>
	public class Help : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Help(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5034CD38-D0F5-4C4A-941C-6DA0BCCF4646", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.NewParam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "NewParam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates tepmorary param structure", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Creates tepmorary param structure
	///</summary>
	public class NewParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewParam);

		}
	}


	[NVP_Manifest(
		Id = "E9C87DD4-1959-4C86-B8CC-6783D44F5383", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.LoadModule", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "LoadModule", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Loads the specified application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the specified application
	///</summary>
	public class LoadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadModule(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B2EF715D-989A-4CA8-B26D-811FE40D9474", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.UnloadModule", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "UnloadModule", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Unloads the specified application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Unloads the specified application
	///</summary>
	public class UnloadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadModule(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "505F750B-1AB4-48EF-BDA3-113FEE4BB134", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ListModules", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ListModules", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the currently loaded applications", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the currently loaded applications
	///</summary>
	public class ListModules : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListModules);

		}
	}


	[NVP_Manifest(
		Id = "9EFE4C47-8F4D-41F7-B4CD-AE9223C6EE72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.LoadArx", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "LoadArx", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Loads the specified NRX application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the specified NRX application
	///</summary>
	public class LoadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadArx(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AFC8C61-1090-44F0-949D-E81E5436A9D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.UnloadArx", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "UnloadArx", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Unloads the specified NRX application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Unloads the specified NRX application
	///</summary>
	public class UnloadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadArx(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE0381EE-2BE2-4F8E-84B4-6594BFF47C9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ListArx", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ListArx", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the currently loaded NRX applications", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the currently loaded NRX applications
	///</summary>
	public class ListArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListArx);

		}
	}


	[NVP_Manifest(
		Id = "0ACF4D02-2B17-4F76-88AC-E933EB20BE0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Put_ActiveDocument", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Put_ActiveDocument", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "drawing file)", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]

	///<summary>
	///drawing file)
	///</summary>
	public class Put_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "587E115F-8202-4798-83C8-17AB757D5C20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.Preferences", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "Preferences", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Preferences object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the Preferences object.
	///</summary>
	public class Preferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preferences);

		}
	}


	[NVP_Manifest(
		Id = "4166D73F-B1F2-4E62-BB64-CFB84C13BD40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.MenuGroups", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "MenuGroups", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the current MenuGroups collection.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the current MenuGroups collection.
	///</summary>
	public class MenuGroups : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuGroups);

		}
	}


	[NVP_Manifest(
		Id = "74A6BDA3-7E02-4958-B0E5-4B4C2E7FF7EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.MenuBar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "MenuBar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the current MenuBar object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the current MenuBar object.
	///</summary>
	public class MenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuBar);

		}
	}


	[NVP_Manifest(
		Id = "19241DB1-C099-411B-B86A-1427E98DAB23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.RunMacro", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "RunMacro", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Runs a VBA macro from the Application object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("MacroPath", typeof(System.String))]

	///<summary>
	///Runs a VBA macro from the Application object
	///</summary>
	public class RunMacro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunMacro(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "513354EC-7FAE-4579-AA4B-AF26EBB9349C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.ApplyProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "ApplyProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Apply profile changes", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Apply profile changes
	///</summary>
	public class ApplyProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApplyProfile();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "90800139-6229-4563-AE21-A674B5471D3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADApplication.GetInterfaceObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADApplication", 
		NodeName = "GetInterfaceObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Loads an object using its program ID.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("ProgID", typeof(System.String))]

	///<summary>
	///Loads an object using its program ID.
	///</summary>
	public class GetInterfaceObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInterfaceObject(inputs[1].Value));

		}
	}
}
