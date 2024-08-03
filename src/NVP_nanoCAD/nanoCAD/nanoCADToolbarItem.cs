using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///A single button item on an toolbar
///</summary>
namespace nanoCAD.nanoCADToolbarItem 
{

	[NVP_Manifest(
		Id = "758B985B-2BEE-488B-9555-A63C37303FD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.nanoCADToolbarItem_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "_nanoCADToolbarItem_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbarItem_Constructor : INode 
	{
		public nanoCAD.InanoCADToolbarItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADToolbarItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D4E0A911-C8E5-47C6-A862-BDA391662389", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.nanoCADToolbarItem_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "_nanoCADToolbarItem_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbarItem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADToolbarItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADToolbarItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ADC963AF-2F46-4070-B52B-35EAEE7F353A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "3DD62B74-9AD4-4484-A451-50411219A9CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the parent of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "330D632D-3A6F-4DC0-B2B7-208453D5AEE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "A7B2526C-6D37-48E4-A3E4-3F058A5C591A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B9B6CF8D-A8C1-44B7-A256-5FB769395209", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "F7AA54FF-E724-4871-91F4-6019AF108C6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Set_TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Set_TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the tag string of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
		Id = "A2EF3E8A-F048-4DC8-AA76-E69BFDD14968", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "CA5C936D-6646-449F-BFF8-90249E376080", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Flyout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Flyout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the toolbar associated with a flyout toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Gets the toolbar associated with a flyout toolbar item
	///</summary>
	public class Flyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Flyout);

		}
	}


	[NVP_Manifest(
		Id = "3D7F463E-774E-4F64-9A19-9D63D8BCC2BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Macro", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Macro", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "5AAE4DA9-CB39-4224-AA83-1481F4A4D412", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Set_Macro", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Set_Macro", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
		Id = "D72B10D1-4DB7-4BA2-BBFF-E5CDD59804A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the index of the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "A42A68B0-B3B6-46BA-9061-28870F35A066", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "F04C17AD-9448-4FD2-9C57-75484F55A1FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Set_HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Set_HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
		Id = "2E28F6DB-18E3-4FCB-BB19-D50088B79588", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.GetBitmaps", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "GetBitmaps", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the large and small bitmaps used as icons for the toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]

	///<summary>
	///Gets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	public class GetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBitmaps(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "944F9456-6C1D-4595-BDFC-5CF7DE6F4C5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.SetBitmaps", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "SetBitmaps", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the large and small bitmaps used as icons for the toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]

	///<summary>
	///Sets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	public class SetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBitmaps(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A04D5ACA-99E3-47A1-8A14-2F19316B5EBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.AttachToolbarToFlyout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "AttachToolbarToFlyout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Attaches a toolbar to a toolbar button defined as a flyout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("MenuGroupName", typeof(System.String))]
	[NodeInput("ToolbarName", typeof(System.String))]

	///<summary>
	///Attaches a toolbar to a toolbar button defined as a flyout
	///</summary>
	public class AttachToolbarToFlyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttachToolbarToFlyout(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A1123E0F-F621-47BA-9F6A-C43D11B8CB07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

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
		Id = "A3C630A4-43AE-431D-8150-91B665757C8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.CommandDisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "CommandDisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CommandDisplayName);

		}
	}


	[NVP_Manifest(
		Id = "E875D064-CA52-427F-A302-319CA3C53FEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbarItem.Set_CommandDisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbarItem", 
		NodeName = "Set_CommandDisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CommandDisplayName = inputs[1].Value;
			return null;
		}
	}
}
