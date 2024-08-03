using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IDataLink Interface
///</summary>
namespace mdsURSLib.DataLinkArg 
{

	[NVP_Manifest(
		Id = "BF3B01E9-9E6D-4C2D-B997-2AFE7A346AD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.DataLinkArg.DataLinkArg_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.DataLinkArg", 
		NodeName = "_DataLinkArg_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DataLinkArg_Constructor : INode 
	{
		public mdsURSLib.IDataLinkArg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IDataLinkArg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C09ACAE1-8364-422E-BA25-6A8879F83883", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.DataLinkArg.DataLinkArg_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.DataLinkArg", 
		NodeName = "_DataLinkArg_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DataLinkArg_ConstructorCast : INode 
	{
		public mdsURSLib.IDataLinkArg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IDataLinkArg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
