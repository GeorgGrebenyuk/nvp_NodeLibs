using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IIrnClassProp Interface
///</summary>
namespace ironObjComLib.IrnClassProp 
{

	[NVP_Manifest(
		Id = "5173BCA7-7BD5-4CDB-8E61-298113D58C19", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.IrnClassProp.IrnClassProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.IrnClassProp", 
		NodeName = "_IrnClassProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IrnClassProp_Constructor : INode 
	{
		public ironObjComLib.IIrnClassProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IIrnClassProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D86E8AD4-9AC8-43BE-94A5-6625E6A45A1B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.IrnClassProp.IrnClassProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.IrnClassProp", 
		NodeName = "_IrnClassProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IrnClassProp_ConstructorCast : INode 
	{
		public ironObjComLib.IIrnClassProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IIrnClassProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
