using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECWallBase Interface
///</summary>
namespace ironObjComLib.WrAECWallBase 
{

	[NVP_Manifest(
		Id = "88896EA4-E877-4D62-B04B-5C8122B2F282", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.WrAECWallBase_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "_WrAECWallBase_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECWallBase_Constructor : INode 
	{
		public ironObjComLib.IWrAECWallBase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECWallBase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8F227A96-8609-420C-A2AE-62646FC36C45", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.WrAECWallBase_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "_WrAECWallBase_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECWallBase_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECWallBase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECWallBase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5F8E23BF-56A2-4D0B-8401-314BF099DFFF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.Thick", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "Thick", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Data")]
	[NodeInput("WrAECWallBase", typeof(object))]

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
		Id = "D3E7A4EE-DCA3-4B7E-954A-1BCA8D76FAD2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.Set_Thick", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "Set_Thick", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECWallBase", typeof(object))]
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


	[NVP_Manifest(
		Id = "D25AB15D-64DE-483F-ABBB-550C3CF07279", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_HEIGHT", 
		ViewType = "Data")]
	[NodeInput("WrAECWallBase", typeof(object))]

	///<summary>
	///property AEC_PART_HEIGHT
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
		Id = "E3F30813-0DFB-4EFF-8D7A-C9D4422C72F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECWallBase.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECWallBase", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_HEIGHT", 
		ViewType = "Modifier")]
	[NodeInput("WrAECWallBase", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AEC_PART_HEIGHT
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
}
