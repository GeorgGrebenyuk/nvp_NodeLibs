using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional Ole functionality
///</summary>
namespace OdaX.OdaOle 
{

	[NVP_Manifest(
		Id = "AC8CF970-4F48-437E-8744-35FF9654B4E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaOle.OdaOle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaOle", 
		NodeName = "_OdaOle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaOle_Constructor : INode 
	{
		public OdaX.IOdaOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F6DCFD05-A928-4B9F-AC14-52ACADC55A40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaOle.OdaOle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaOle", 
		NodeName = "_OdaOle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaOle_ConstructorCast : INode 
	{
		public OdaX.IOdaOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "34CB444D-9A60-4E5E-8FCC-8348DEF50225", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaOle.LinkName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaOle", 
		NodeName = "LinkName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Filename and item to which this OLE object is linked", 
		ViewType = "Data")]
	[NodeInput("OdaOle", typeof(object))]

	///<summary>
	///Filename and item to which this OLE object is linked
	///</summary>
	public class LinkName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkName);

		}
	}


	[NVP_Manifest(
		Id = "CC58FF5B-6A33-44FD-9C1F-CD773543CC83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaOle.LinkPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaOle", 
		NodeName = "LinkPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Filename to which this OLE object is linked", 
		ViewType = "Data")]
	[NodeInput("OdaOle", typeof(object))]

	///<summary>
	///Filename to which this OLE object is linked
	///</summary>
	public class LinkPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkPath);

		}
	}
}
