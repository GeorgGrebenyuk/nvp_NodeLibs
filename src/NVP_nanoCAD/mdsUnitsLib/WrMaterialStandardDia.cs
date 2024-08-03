using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMaterialStandardDia Interface
///</summary>
namespace mdsUnitsLib.WrMaterialStandardDia 
{

	[NVP_Manifest(
		Id = "203FFD37-AA32-4CA4-B741-4ADF32AA150E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrMaterialStandardDia.WrMaterialStandardDia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrMaterialStandardDia", 
		NodeName = "_WrMaterialStandardDia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMaterialStandardDia_Constructor : INode 
	{
		public mdsUnitsLib.IWrMaterialStandardDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IWrMaterialStandardDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F84B7296-FBE2-43C9-B102-5FB833886F68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrMaterialStandardDia.WrMaterialStandardDia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrMaterialStandardDia", 
		NodeName = "_WrMaterialStandardDia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMaterialStandardDia_ConstructorCast : INode 
	{
		public mdsUnitsLib.IWrMaterialStandardDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IWrMaterialStandardDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
