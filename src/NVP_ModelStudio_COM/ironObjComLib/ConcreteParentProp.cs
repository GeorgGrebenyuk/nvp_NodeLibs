using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IConcreteParentProp Interface
///</summary>
namespace ironObjComLib.ConcreteParentProp 
{

	[NVP_Manifest(
		Id = "765521F1-9FA5-4098-B0D8-5FEB5808D9B4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteParentProp.ConcreteParentProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteParentProp", 
		NodeName = "_ConcreteParentProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteParentProp_Constructor : INode 
	{
		public ironObjComLib.IConcreteParentProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IConcreteParentProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "46F3EEDC-438A-4E7B-A606-D3899D230D47", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.ConcreteParentProp.ConcreteParentProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.ConcreteParentProp", 
		NodeName = "_ConcreteParentProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ConcreteParentProp_ConstructorCast : INode 
	{
		public ironObjComLib.IConcreteParentProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IConcreteParentProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
