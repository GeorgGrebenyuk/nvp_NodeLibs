using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IOwnershipLink Interface
///</summary>
namespace mdsURSLib.OwnershipLink 
{

	[NVP_Manifest(
		Id = "C8C239EF-1AEC-48A6-8A08-F2EE312F3F93", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.OwnershipLink.OwnershipLink_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.OwnershipLink", 
		NodeName = "_OwnershipLink_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OwnershipLink_Constructor : INode 
	{
		public mdsURSLib.IOwnershipLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IOwnershipLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CBD8A0DE-9153-4EA9-8F2F-3EAE385E9AB4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.OwnershipLink.OwnershipLink_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.OwnershipLink", 
		NodeName = "_OwnershipLink_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OwnershipLink_ConstructorCast : INode 
	{
		public mdsURSLib.IOwnershipLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IOwnershipLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
