using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrDiameter2Dia Interface
///</summary>
namespace vCSViperCSObjComLib.WrDiameter2Dia 
{

	[NVP_Manifest(
		Id = "7C0184D9-8B0E-4575-9536-F88D5B3F4C64", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrDiameter2Dia.WrDiameter2Dia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrDiameter2Dia", 
		NodeName = "_WrDiameter2Dia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrDiameter2Dia_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrDiameter2Dia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrDiameter2Dia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5CB970CE-D0EF-4AFF-A65F-841D0EA3CA4A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrDiameter2Dia.WrDiameter2Dia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrDiameter2Dia", 
		NodeName = "_WrDiameter2Dia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrDiameter2Dia_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrDiameter2Dia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrDiameter2Dia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
