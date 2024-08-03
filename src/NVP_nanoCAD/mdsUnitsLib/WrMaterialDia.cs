using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMaterialDia Interface
///</summary>
namespace mdsUnitsLib.WrMaterialDia 
{

	[NVP_Manifest(
		Id = "0E10A6C7-EDB4-469B-A354-F576090C03F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrMaterialDia.WrMaterialDia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrMaterialDia", 
		NodeName = "_WrMaterialDia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMaterialDia_Constructor : INode 
	{
		public mdsUnitsLib.IWrMaterialDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IWrMaterialDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9285DB26-27BE-4920-931E-380CCD9329C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrMaterialDia.WrMaterialDia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrMaterialDia", 
		NodeName = "_WrMaterialDia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMaterialDia_ConstructorCast : INode 
	{
		public mdsUnitsLib.IWrMaterialDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IWrMaterialDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
