using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECPlate Interface
///</summary>
namespace ironObjComLib.WrAECPlate 
{

	[NVP_Manifest(
		Id = "5969CAF6-19FC-4548-9788-CC8904B5DBB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECPlate.WrAECPlate_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECPlate", 
		NodeName = "_WrAECPlate_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECPlate_Constructor : INode 
	{
		public ironObjComLib.IWrAECPlate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECPlate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3DB38CE0-B4E5-4A2E-B3B1-4FC9B9398FE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECPlate.WrAECPlate_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECPlate", 
		NodeName = "_WrAECPlate_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECPlate_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECPlate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECPlate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "098B45C4-BC26-42C7-9B3D-B84D66A00998", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECPlate.Thick", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECPlate", 
		NodeName = "Thick", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Data")]
	[NodeInput("WrAECPlate", typeof(object))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Thick : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thick);

		}
	}


	[NVP_Manifest(
		Id = "D099F0DE-0176-43D9-A9BC-3DDF486EC085", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECPlate.Set_Thick", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECPlate", 
		NodeName = "Set_Thick", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECPlate", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Set_Thick : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thick = inputs[1].Value;
			return null;
		}
	}
}
