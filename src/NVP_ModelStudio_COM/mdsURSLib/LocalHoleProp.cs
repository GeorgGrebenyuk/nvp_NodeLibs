using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ILocalHoleProp Interface
///</summary>
namespace mdsURSLib.LocalHoleProp 
{

	[NVP_Manifest(
		Id = "60CB88A7-4E18-401B-9251-312E4DDC9AE6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.LocalHoleProp.LocalHoleProp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.LocalHoleProp", 
		NodeName = "_LocalHoleProp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LocalHoleProp_Constructor : INode 
	{
		public mdsURSLib.ILocalHoleProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.ILocalHoleProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D457EE0C-EA9B-4442-824F-8BE639DE5F9D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.LocalHoleProp.LocalHoleProp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.LocalHoleProp", 
		NodeName = "_LocalHoleProp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LocalHoleProp_ConstructorCast : INode 
	{
		public mdsURSLib.ILocalHoleProp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.ILocalHoleProp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
