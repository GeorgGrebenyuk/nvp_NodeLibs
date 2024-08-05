using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrTypeDia Interface
///</summary>
namespace mdsUnitsLib.WrTypeDia 
{

	[NVP_Manifest(
		Id = "AEB3A0CF-65C8-4D51-8CF0-361E884FBC7D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrTypeDia.WrTypeDia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrTypeDia", 
		NodeName = "_WrTypeDia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrTypeDia_Constructor : INode 
	{
		public mdsUnitsLib.IWrTypeDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IWrTypeDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "47A45440-365E-429C-A6A8-3A606129F9AD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrTypeDia.WrTypeDia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrTypeDia", 
		NodeName = "_WrTypeDia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrTypeDia_ConstructorCast : INode 
	{
		public mdsUnitsLib.IWrTypeDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IWrTypeDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
