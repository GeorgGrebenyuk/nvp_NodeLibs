using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECArcSurface Interface
///</summary>
namespace ironObjComLib.WrAECArcSurface 
{

	[NVP_Manifest(
		Id = "DB67FD89-3D46-4D2B-B3F0-79A1B1C09495", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.WrAECArcSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "_WrAECArcSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcSurface_Constructor : INode 
	{
		public ironObjComLib.IWrAECArcSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECArcSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "84D1E160-071D-41C9-B570-1E9BF27C0570", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.WrAECArcSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "_WrAECArcSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcSurface_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECArcSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECArcSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3BC7EBB7-A063-4066-9FED-7135B66EF241", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_RADIUS", 
		ViewType = "Data")]
	[NodeInput("WrAECArcSurface", typeof(object))]

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
		Id = "A3A42587-4125-476C-B6E2-C70BBC5B5A00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_RADIUS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcSurface", typeof(object))]
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
		Id = "2FACCFAD-E09F-4AF9-B7E2-5F50109327BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_ANGLE", 
		ViewType = "Data")]
	[NodeInput("WrAECArcSurface", typeof(object))]

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
		Id = "35BFA980-DB83-4B09-A9B7-9AF9C79E7813", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECArcSurface.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECArcSurface", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DIM_ANGLE", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcSurface", typeof(object))]
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
