using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWireBreakDlgWrapper Interface
///</summary>
namespace mdsLINEComLib.WireBreakDlgWrapper 
{

	[NVP_Manifest(
		Id = "C9094AB3-587B-4884-BDD3-E74B485C6E07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.WireBreakDlgWrapper.WireBreakDlgWrapper_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.WireBreakDlgWrapper", 
		NodeName = "_WireBreakDlgWrapper_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WireBreakDlgWrapper_Constructor : INode 
	{
		public mdsLINEComLib.IWireBreakDlgWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IWireBreakDlgWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "27A481DC-79B3-4195-B86E-8A75AECE17B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.WireBreakDlgWrapper.WireBreakDlgWrapper_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.WireBreakDlgWrapper", 
		NodeName = "_WireBreakDlgWrapper_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WireBreakDlgWrapper_ConstructorCast : INode 
	{
		public mdsLINEComLib.IWireBreakDlgWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IWireBreakDlgWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
