using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Specifies system settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesSystem 
{

	[NVP_Manifest(
		Id = "361C68A3-5628-4AAD-B161-12424672D959", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.nanoCADPreferencesSystem_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "_nanoCADPreferencesSystem_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSystem_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesSystem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesSystem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A8E4E091-023C-49A6-8DC7-79715FE89FEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.nanoCADPreferencesSystem_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "_nanoCADPreferencesSystem_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSystem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesSystem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesSystem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2D5AE8E6-905C-42FC-B269-6A3E3DE5D18C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Returns the Application object.
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
		Id = "A1F1327A-DCDF-462C-81ED-C3D001DCCC95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_SingleDocumentMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_SingleDocumentMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether single or multiple drawings can be open at the same time.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	public class Set_SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleDocumentMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E9B5204-D4EC-4F96-AB27-E7A98A4890BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.SingleDocumentMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "SingleDocumentMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether single or multiple drawings can be open at the same time.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	public class SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleDocumentMode);

		}
	}


	[NVP_Manifest(
		Id = "4942F522-0CC8-452B-8658-0F1709353153", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_DisplayOLEScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_DisplayOLEScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	public class Set_DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayOLEScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FE522C0-5D03-4F3B-8B57-5AEB791ADFBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.DisplayOLEScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "DisplayOLEScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	public class DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayOLEScale);

		}
	}


	[NVP_Manifest(
		Id = "E03771E4-5AA5-4107-B668-FD89C8F082D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_StoreSQLIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_StoreSQLIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the SQL index is stored in drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	public class Set_StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StoreSQLIndex = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EDAB5393-DD6F-480D-96EE-097A97C4891C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.StoreSQLIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "StoreSQLIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the SQL index is stored in drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	public class StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StoreSQLIndex);

		}
	}


	[NVP_Manifest(
		Id = "CA06B586-1AEE-421D-A3DC-40CE3F594989", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_TablesReadOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_TablesReadOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to database tables are read-only.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	public class Set_TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TablesReadOnly = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "70600F6A-6812-4EFA-9586-06113EB3864F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.TablesReadOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "TablesReadOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether to database tables are read-only.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	public class TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TablesReadOnly);

		}
	}


	[NVP_Manifest(
		Id = "88D63495-7E49-47A1-B893-2C4D05E946E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_EnableStartupDialog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_EnableStartupDialog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a Startup dialog box displays automatically when the application starts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	public class Set_EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableStartupDialog = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2FE0EBE5-38B9-41EC-93F0-CF37FB781031", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.EnableStartupDialog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "EnableStartupDialog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a Startup dialog box displays automatically when the application starts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	public class EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableStartupDialog);

		}
	}


	[NVP_Manifest(
		Id = "E30F53DE-1016-4229-87B8-7D049FB0E61F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_BeepOnError", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_BeepOnError", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a beep sounds automatically when user input results in an error.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("BeepOnError", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	public class Set_BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BeepOnError = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E3EF7001-95AC-4E3F-99A4-32555FD258F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.BeepOnError", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "BeepOnError", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a beep sounds automatically when user input results in an error.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	public class BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BeepOnError);

		}
	}


	[NVP_Manifest(
		Id = "BD0AFC0B-C99B-46BD-85F0-86D5C5809ED5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_ShowWarningMessages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_ShowWarningMessages", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether all warning dialog boxes display.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	public class Set_ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowWarningMessages = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24FBD25A-E17D-4F8E-8E79-2C3AD7F80974", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.ShowWarningMessages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "ShowWarningMessages", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether all warning dialog boxes display.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	public class ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowWarningMessages);

		}
	}


	[NVP_Manifest(
		Id = "9EC16CB8-A8F4-4EF1-AD22-BB471A9C4E6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.Set_LoadAcadLspInAllDocuments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "Set_LoadAcadLspInAllDocuments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("pALID", typeof(System.Object))]

	///<summary>
	///Not implemented.
	///</summary>
	public class Set_LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadAcadLspInAllDocuments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "14756227-8B1B-4F48-976A-10EA97D6B1FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSystem.LoadAcadLspInAllDocuments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSystem", 
		NodeName = "LoadAcadLspInAllDocuments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Not implemented.
	///</summary>
	public class LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LoadAcadLspInAllDocuments);

		}
	}
}
