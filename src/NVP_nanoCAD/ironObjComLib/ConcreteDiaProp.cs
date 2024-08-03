using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IConcreteDiaProp Interface
///</summary>
namespace ironObjComLib.ConcreteDiaProp 
{

	[NVP_Manifest(
		Id = "10090289-A296-426B-8B2A-3E430E742A54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteDiaProp.ConcreteDiaProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteDiaProp", 
		NodeName = "_ConcreteDiaProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteDiaProp_Constructor : INode 
	{
		public ironObjComLib.IConcreteDiaProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IConcreteDiaProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "80635E7F-D8CF-4D2A-882A-8796C5AC4D59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteDiaProp.ConcreteDiaProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteDiaProp", 
		NodeName = "_ConcreteDiaProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteDiaProp_ConstructorCast : INode 
	{
		public ironObjComLib.IConcreteDiaProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IConcreteDiaProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
