using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Assembly command
///</summary>
namespace nanoCAD.ACommand 
{

	[NVP_Manifest(
		Id = "6DC50756-9C5F-4E57-8D9C-B0E6CC54977E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.ACommand_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "_ACommand_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ACommand_Constructor : INode 
	{
		public nanoCAD.IACommand _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IACommand;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AA5750A4-40CF-496A-A459-74A469085906", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.ACommand_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "_ACommand_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ACommand_ConstructorCast : INode 
	{
		public nanoCAD.IACommand _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IACommand;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5C49D8A2-09EA-4675-9D03-8A1902EB7837", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "command type", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///command type
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
		Id = "E8287005-FB2C-4F13-974D-265CB65D9E2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.ID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "ID", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "command type", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///command type
	///</summary>
	public class ID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ID);

		}
	}


	[NVP_Manifest(
		Id = "CE188152-6089-42C7-864C-19CD8CCAA03B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.Set_ID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "Set_ID", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "command type", 
		ViewType = "Modifier")]
	[NodeInput("ACommand", typeof(object))]
	[NodeInput("ID", typeof(System.Object))]

	///<summary>
	///command type
	///</summary>
	public class Set_ID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ID = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6ACDE4B-4E3A-4D47-98C0-A1D26228A882", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.InternalName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "InternalName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "internal name", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///internal name
	///</summary>
	public class InternalName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InternalName);

		}
	}


	[NVP_Manifest(
		Id = "202F8F9F-7AB7-452E-9097-BC5AC6F7D276", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.DispName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "DispName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "disp name", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///disp name
	///</summary>
	public class DispName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DispName);

		}
	}


	[NVP_Manifest(
		Id = "720D4222-AA82-4A0E-819C-3E02922ED628", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "weight", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}


	[NVP_Manifest(
		Id = "21DB8937-2C39-4A15-B461-7AD6BE655C2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.LaunchWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "LaunchWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "launch weight", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///launch weight
	///</summary>
	public class LaunchWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LaunchWeight);

		}
	}


	[NVP_Manifest(
		Id = "C3D0D8A8-8C2E-4700-AD29-83E56FEC74E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.StatusString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "StatusString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "StatusString", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///StatusString
	///</summary>
	public class StatusString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StatusString);

		}
	}


	[NVP_Manifest(
		Id = "EEBCB85F-03F5-4F7F-9D22-7969F2E0CE53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.ToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "ToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "tooltip string", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///tooltip string
	///</summary>
	public class ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToolTip);

		}
	}


	[NVP_Manifest(
		Id = "57A23B12-D06C-49B5-ADD7-BD972D6BE4D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.Caps", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "Caps", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "caps", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///caps
	///</summary>
	public class Caps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caps);

		}
	}


	[NVP_Manifest(
		Id = "F2F0D55B-D9E3-497E-AAB8-1EC1B714AF8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.MenuText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "MenuText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "menu string", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///menu string
	///</summary>
	public class MenuText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuText);

		}
	}


	[NVP_Manifest(
		Id = "A2511D86-F191-4EE4-800B-8C78F0ED96ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.MenuGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "MenuGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "menu group", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///menu group
	///</summary>
	public class MenuGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuGroup);

		}
	}


	[NVP_Manifest(
		Id = "F517BFB7-A2BB-4E20-9F19-123C7FCFC7FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ACommand.Run", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ACommand", 
		NodeName = "Run", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Run command", 
		ViewType = "Modifier")]
	[NodeInput("ACommand", typeof(object))]
	[NodeInput("helper", typeof(System.Object))]

	///<summary>
	///Run command
	///</summary>
	public class Run : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Run(inputs[1].Value);
			return null;
		}
	}
}
