using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrDiameter1Dia Interface
///</summary>
namespace vCSViperCSObjComLib.WrDiameter1Dia 
{

	[NVP_Manifest(
		Id = "11D99581-FB00-4158-9B35-4080A9290000", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrDiameter1Dia.WrDiameter1Dia_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrDiameter1Dia", 
		NodeName = "_WrDiameter1Dia_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrDiameter1Dia_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrDiameter1Dia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrDiameter1Dia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E4A975BD-023B-43AC-919D-A729CF493A9B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrDiameter1Dia.WrDiameter1Dia_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrDiameter1Dia", 
		NodeName = "_WrDiameter1Dia_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrDiameter1Dia_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrDiameter1Dia _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrDiameter1Dia;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
