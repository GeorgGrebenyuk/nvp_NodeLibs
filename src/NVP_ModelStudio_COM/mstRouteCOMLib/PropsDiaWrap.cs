using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IPropsDiaWrap Interface
///</summary>
namespace mstRouteCOMLib.PropsDiaWrap 
{

	[NVP_Manifest(
		Id = "2754B391-7DB0-4E4B-BD6F-3A47DF2BB941", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.PropsDiaWrap.PropsDiaWrap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_Constructor : INode 
	{
		public mstRouteCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "56F216C0-BD7B-4F9C-9421-7968C21572E0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.PropsDiaWrap.PropsDiaWrap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_ConstructorCast : INode 
	{
		public mstRouteCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
