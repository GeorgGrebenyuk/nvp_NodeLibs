using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSLinkSegment Interface
///</summary>
namespace SchematiCSCOMLib.MSLinkSegment 
{

	[NVP_Manifest(
		Id = "C1B4857D-C345-4072-AC08-508F4190E74D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkSegment.MSLinkSegment_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkSegment", 
		NodeName = "_MSLinkSegment_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkSegment_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSLinkSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSLinkSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B045835B-E9B8-484B-B2FE-E2F133134196", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkSegment.MSLinkSegment_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkSegment", 
		NodeName = "_MSLinkSegment_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkSegment_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSLinkSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSLinkSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FFB7FDBA-27DC-4684-BB79-D836348CF238", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkSegment.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkSegment", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры сегмента", 
		ViewType = "Data")]
	[NodeInput("MSLinkSegment", typeof(object))]

	///<summary>
	///Параметры сегмента
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}
}
