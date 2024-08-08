using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Menu group
///</summary>
namespace nanoCAD.nanoCADMenuGroup 
{

	[NVP_Manifest(
		Id = "4419807C-843B-44BB-AC00-D989DC96012C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.nanoCADMenuGroup_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "_nanoCADMenuGroup_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroup_Constructor : INode 
	{
		public nanoCAD.InanoCADMenuGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADMenuGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7B7713AA-0A58-4E60-A0D0-D5A43866A585", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.nanoCADMenuGroup_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "_nanoCADMenuGroup_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroup_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADMenuGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADMenuGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F9153E4F-F77B-4AFC-9248-1BBC392AE82A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Id = "8861ED2F-E20C-4893-885D-302250D476E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the parent of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Id = "24C8836B-4698-4F19-BAA0-0E8DF72E9BA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Id = "2F862344-E977-4869-9140-03D72483C249", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Id = "F7F6DA47-3935-4A14-A32D-B98DF0444D56", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.MenuFileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "MenuFileName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the menu file name where the menu group is located", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the menu file name where the menu group is located
	///</summary>
	public class MenuFileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuFileName);

		}
	}


	[NVP_Manifest(
		Id = "E6E426F8-C9D5-45A4-8F86-9367E92E9CF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Menus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Menus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the PopupMenus collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the PopupMenus collection
	///</summary>
	public class Menus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Menus);

		}
	}


	[NVP_Manifest(
		Id = "FE8BB4DA-5579-4D7C-AB4A-990AB9EBA836", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Toolbars", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Toolbars", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Toolbars collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the Toolbars collection
	///</summary>
	public class Toolbars : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Toolbars);

		}
	}


	[NVP_Manifest(
		Id = "885127DC-8885-48F9-99F7-61E25C040866", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Unload", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Unload", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Unloads the menu group or external reference", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Unloads the menu group or external reference
	///</summary>
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BE1040F-D39C-44E1-BC12-C13430A4CE5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.Save", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "Save", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves the document or menu group", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("nanoCAD.AcMenuFileType", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save(((nanoCAD.AcMenuFileType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0F878A8F-ED46-455A-B5C5-269ACADA375B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADMenuGroup.SaveAs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADMenuGroup", 
		NodeName = "SaveAs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves the document or menu group to a specified file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("MenuFileName", typeof(System.String))]
	[NodeInput("nanoCAD.AcMenuFileType", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,((nanoCAD.AcMenuFileType)inputs[2].Value));
			return null;
		}
	}
}
