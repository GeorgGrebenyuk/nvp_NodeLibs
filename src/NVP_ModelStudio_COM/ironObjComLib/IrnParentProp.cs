using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IIrnParentProp Interface
///</summary>
namespace ironObjComLib.IrnParentProp 
{

	[NVP_Manifest(
		Id = "7A4A631B-75B1-4081-ABDD-C07E82D1EC13", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.IrnParentProp.IrnParentProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.IrnParentProp", 
		NodeName = "_IrnParentProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IrnParentProp_Constructor : INode 
	{
		public ironObjComLib.IIrnParentProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IIrnParentProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B61D751A-D02A-4890-B0BC-2001C8C1CD97", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.IrnParentProp.IrnParentProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.IrnParentProp", 
		NodeName = "_IrnParentProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IrnParentProp_ConstructorCast : INode 
	{
		public ironObjComLib.IIrnParentProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IIrnParentProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
