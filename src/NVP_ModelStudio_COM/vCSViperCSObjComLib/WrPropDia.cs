using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrPropDia Interface
///</summary>
namespace vCSViperCSObjComLib.WrPropDia 
{

	[NVP_Manifest(
		Id = "1B07C8DA-5325-4CF8-B8EB-56A2620EC8AE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrPropDia.WrPropDia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrPropDia", 
		NodeName = "_WrPropDia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrPropDia_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrPropDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrPropDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D520A3E0-E3F8-4860-986A-C1DB340308C7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrPropDia.WrPropDia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrPropDia", 
		NodeName = "_WrPropDia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrPropDia_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrPropDia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrPropDia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
