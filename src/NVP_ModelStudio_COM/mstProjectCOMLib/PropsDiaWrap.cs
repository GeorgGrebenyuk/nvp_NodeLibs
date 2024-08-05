using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IPropsDiaWrap Interface
///</summary>
namespace mstProjectCOMLib.PropsDiaWrap 
{

	[NVP_Manifest(
		Id = "E14FC383-AC14-498A-9FFC-3E9A54392D22", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.PropsDiaWrap.PropsDiaWrap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_Constructor : INode 
	{
		public mstProjectCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstProjectCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2B92A974-1A3C-4DE3-89EB-3328CB76DB29", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.PropsDiaWrap.PropsDiaWrap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_ConstructorCast : INode 
	{
		public mstProjectCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstProjectCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
