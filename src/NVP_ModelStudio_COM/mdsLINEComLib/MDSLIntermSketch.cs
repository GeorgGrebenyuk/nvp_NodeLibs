using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Графическое представление промежуточной опоры
///</summary>
namespace mdsLINEComLib.MDSLIntermSketch 
{

	[NVP_Manifest(
		Id = "37A1B275-B020-4F55-86A8-9D4581FFE860", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLIntermSketch.MDSLIntermSketch_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLIntermSketch", 
		NodeName = "_MDSLIntermSketch_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLIntermSketch_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLIntermSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLIntermSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A02FA53E-D2E0-4562-B5BC-BEF8A64DB890", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLIntermSketch.MDSLIntermSketch_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLIntermSketch", 
		NodeName = "_MDSLIntermSketch_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLIntermSketch_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLIntermSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLIntermSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
