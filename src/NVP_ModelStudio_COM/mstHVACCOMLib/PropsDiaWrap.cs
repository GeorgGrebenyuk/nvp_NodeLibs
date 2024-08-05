using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IPropsDiaWrap Interface
///</summary>
namespace mstHVACCOMLib.PropsDiaWrap 
{

	[NVP_Manifest(
		Id = "A8ACE50D-A00D-4C03-BF8B-CDCB0163E830", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.PropsDiaWrap.PropsDiaWrap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_Constructor : INode 
	{
		public mstHVACCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstHVACCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "886D5518-7E26-4851-BE15-4977B827615A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.PropsDiaWrap.PropsDiaWrap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.PropsDiaWrap", 
		NodeName = "_PropsDiaWrap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_ConstructorCast : INode 
	{
		public mstHVACCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstHVACCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
