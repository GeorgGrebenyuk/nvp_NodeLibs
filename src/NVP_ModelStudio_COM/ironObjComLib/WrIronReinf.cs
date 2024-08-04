using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronReinf Interface
///</summary>
namespace ironObjComLib.WrIronReinf 
{

	[NVP_Manifest(
		Id = "0EDF103D-8DEE-446B-811A-F3666170B392", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.WrIronReinf_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "_WrIronReinf_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronReinf_Constructor : INode 
	{
		public ironObjComLib.IWrIronReinf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronReinf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "35A0779B-D0B6-4DCD-9F74-BBE386925780", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.WrIronReinf_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "_WrIronReinf_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronReinf_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronReinf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronReinf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B34F7FE6-974A-4E44-9788-C34E56F79FDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "34E7A22A-5A25-4B20-AF2C-52DAF1EEC097", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "59D4300C-4B13-4C9F-9092-1AD0717D00CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Parent
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
		Id = "9C48C443-C46E-4207-8999-ACDD14881A5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Parent
	///</summary>
	public class Set_Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DD958B07-B818-4996-91C4-3D22C39CC2D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Name
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
		Id = "64C69080-0FAF-4B9D-A35D-97814A08AF25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
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
		Id = "2EAFD304-C31C-431C-BADC-9F30BBCFF079", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Class", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Class
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Id = "1B76AA88-3678-40A8-BF20-683B357A9568", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Diameter
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Id = "D4C4C741-5582-4DA1-98EB-7B9677AF9D37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.MinBendAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "MinBendAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinBendAngle", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property MinBendAngle
	///</summary>
	public class MinBendAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinBendAngle);

		}
	}


	[NVP_Manifest(
		Id = "48D96BD6-C9F6-452D-871D-5FFA253998C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_MinBendAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_MinBendAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinBendAngle", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinBendAngle
	///</summary>
	public class Set_MinBendAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinBendAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8BC65B42-DC43-4B90-9C46-241B44177CEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.MinBendDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "MinBendDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinBendDiameter", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property MinBendDiameter
	///</summary>
	public class MinBendDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinBendDiameter);

		}
	}


	[NVP_Manifest(
		Id = "A086B078-951F-4D57-91AA-6B255ACA75E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_MinBendDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_MinBendDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinBendDiameter", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinBendDiameter
	///</summary>
	public class Set_MinBendDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinBendDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7DB849DC-36BA-403D-BEDB-534EADD43C0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.RunWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "RunWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RunWeight", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property RunWeight
	///</summary>
	public class RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RunWeight);

		}
	}


	[NVP_Manifest(
		Id = "747C0986-6A5B-462A-82D7-1F04A00F7565", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_RunWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_RunWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RunWeight", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RunWeight
	///</summary>
	public class Set_RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "958A2DE0-83B9-466C-B123-B65A530D0041", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.SecArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "SecArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SecArea", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property SecArea
	///</summary>
	public class SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecArea);

		}
	}


	[NVP_Manifest(
		Id = "EB2C73F9-FFD8-480C-807F-3CBB54D6C467", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_SecArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_SecArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SecArea", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property SecArea
	///</summary>
	public class Set_SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecArea = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CCE92C20-6996-436E-8E6A-E12660D3481B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Length
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Id = "E575A2C3-7999-4E70-AA0D-F4EC88A37577", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Length
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E13A1B65-AF30-4DF9-BC69-613D1264C43D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronReinf.Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronReinf", 
		NodeName = "Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Weight", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}
}
