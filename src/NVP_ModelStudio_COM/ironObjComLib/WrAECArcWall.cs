using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECArcWall Interface
///</summary>
namespace ironObjComLib.WrAECArcWall 
{

	[NVP_Manifest(
		Id = "53722CE4-5C3E-48D5-97E5-BFB885EC1B85", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.WrAECArcWall_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "_WrAECArcWall_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcWall_Constructor : INode 
	{
		public ironObjComLib.IWrAECArcWall _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECArcWall;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AB6373DB-9061-472F-AF6F-CC771235D6D9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.WrAECArcWall_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "_WrAECArcWall_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcWall_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECArcWall _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECArcWall;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "845A6189-0D24-4BC7-ABC0-59E956811766", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_RADIUS", 
		ViewType = "Data")]
	[NodeInput("WrAECArcWall", typeof(object))]

	///<summary>
	///property DIM_RADIUS
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "A8E9FBFF-05CF-4C80-A3A2-DECA1C162C4B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_RADIUS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcWall", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DIM_RADIUS
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "04260DEA-93D8-4485-9F01-772329AC312A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_ANGLE", 
		ViewType = "Data")]
	[NodeInput("WrAECArcWall", typeof(object))]

	///<summary>
	///property DIM_ANGLE
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Id = "067DD706-020E-4A6B-A0C6-434C70C19DB0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcWall.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcWall", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_ANGLE", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcWall", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DIM_ANGLE
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}
}
