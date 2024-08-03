using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///A single menu item on an pull-down menu
///</summary>
namespace nanoCAD.nanoCADPopupMenuItem 
{

	[NVP_Manifest(
		Id = "326C7603-248E-4249-BDBA-16A926EB08E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.nanoCADPopupMenuItem_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "_nanoCADPopupMenuItem_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenuItem_Constructor : INode 
	{
		public nanoCAD.InanoCADPopupMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPopupMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "04ABF6FA-BC64-4A73-A62E-CABFCAB41B09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.nanoCADPopupMenuItem_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "_nanoCADPopupMenuItem_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenuItem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPopupMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPopupMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5AF8933E-73AF-4C52-BD3B-B20672177FD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
		Id = "299A6B6C-A0C1-47F5-8F31-C96CFACA81A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the parent of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Gets the parent of the object
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Id = "7E4699D5-B55D-497D-96DB-1DC3F23B1400", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Label", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Label", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the content and formatting of menu items as they appear to the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the content and formatting of menu items as they appear to the user
	///</summary>
	public class Label : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Label);

		}
	}


	[NVP_Manifest(
		Id = "3F4A4174-8F48-43B9-A8F0-3E5EE307327B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_Label", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_Label", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the content and formatting of menu items as they appear to the user", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bstrLabel", typeof(System.String))]

	///<summary>
	///Specifies the content and formatting of menu items as they appear to the user
	///</summary>
	public class Set_Label : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Label = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E0BD36BD-51E1-4C43-9E3A-FA98015FFF91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the tag string of the object
	///</summary>
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}


	[NVP_Manifest(
		Id = "CE7A32BC-5D93-450F-AC18-371D6E5E93DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the tag string of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bstrTag", typeof(System.String))]

	///<summary>
	///Specifies the tag string of the object
	///</summary>
	public class Set_TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TagString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6E71CBE7-8B91-490D-9204-429CA08D076E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Enable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Enable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables the popup menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Enables the popup menu or toolbar item
	///</summary>
	public class Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enable);

		}
	}


	[NVP_Manifest(
		Id = "F2DF9D1D-8305-47FE-9F24-76836EAF4406", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_Enable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_Enable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables the popup menu or toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Enables the popup menu or toolbar item
	///</summary>
	public class Set_Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF2D74FD-8C92-40E1-B53B-03AE952AD0F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Check", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Check", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the check status for the popup menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the check status for the popup menu item
	///</summary>
	public class Check : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Check);

		}
	}


	[NVP_Manifest(
		Id = "A0F6703F-BD73-4BEB-A06A-8F36546E69E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_Check", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_Check", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the check status for the popup menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Specifies the check status for the popup menu item
	///</summary>
	public class Set_Check : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Check = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FC489DCB-9B6D-4BA2-B33A-70E96D70D5DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "616D6B43-6713-4E05-A27B-EA6B77D7DACC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.SubMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "SubMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the popup menu associated with a sub menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Gets the popup menu associated with a sub menu
	///</summary>
	public class SubMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubMenu);

		}
	}


	[NVP_Manifest(
		Id = "09280484-BEB0-43A6-93DB-112648E4F261", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Macro", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Macro", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	public class Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Macro);

		}
	}


	[NVP_Manifest(
		Id = "0F6E3419-2139-46AC-8A06-D55E121A2C31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_Macro", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_Macro", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bstrMacro", typeof(System.String))]

	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	public class Set_Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Macro = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "836D414F-7BDF-45E4-9177-16A401528329", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the index of the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the index of the menu or toolbar item
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Id = "A0BB2DAE-9478-43B3-8F2E-BA63E2C90AFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Caption", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Caption", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Gets the text that the user sees displayed for the application or a menu item
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
		Id = "25C1445F-57BC-4593-935A-7E5D123E1C14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HelpString);

		}
	}


	[NVP_Manifest(
		Id = "20D2DA2A-CA25-4881-8077-E403AC45E71B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bstrHelp", typeof(System.String))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class Set_HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HelpString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D232AA63-A35C-4310-BC6E-870A90B7EC9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Deletes a specified object
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A71FAB09-9D38-44CD-8593-241996C91557", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.EndSubMenuLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "EndSubMenuLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the submenu level for the menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the submenu level for the menu item
	///</summary>
	public class EndSubMenuLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndSubMenuLevel);

		}
	}


	[NVP_Manifest(
		Id = "D65A2E27-F579-4077-8833-915F5A130D05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenuItem.Set_EndSubMenuLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenuItem", 
		NodeName = "Set_EndSubMenuLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the submenu level for the menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("level", typeof(System.Int32))]

	///<summary>
	///Specifies the submenu level for the menu item
	///</summary>
	public class Set_EndSubMenuLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndSubMenuLevel = inputs[1].Value;
			return null;
		}
	}
}
