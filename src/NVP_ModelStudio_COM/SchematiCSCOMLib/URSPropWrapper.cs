using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IURSPropWrapper Interface
///</summary>
namespace SchematiCSCOMLib.URSPropWrapper 
{

	[NVP_Manifest(
		Id = "7B978FB3-04CF-43D1-A8D9-B423B20F51C4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.URSPropWrapper.URSPropWrapper_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.URSPropWrapper", 
		NodeName = "_URSPropWrapper_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSPropWrapper_Constructor : INode 
	{
		public SchematiCSCOMLib.IURSPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IURSPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BBCB47D9-50EE-4D15-ABE5-44C5D2198ED9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.URSPropWrapper.URSPropWrapper_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.URSPropWrapper", 
		NodeName = "_URSPropWrapper_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSPropWrapper_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IURSPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IURSPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
