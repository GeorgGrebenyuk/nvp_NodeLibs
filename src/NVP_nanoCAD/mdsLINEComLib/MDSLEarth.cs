using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLEarth Interface
///</summary>
namespace mdsLINEComLib.MDSLEarth 
{

	[NVP_Manifest(
		Id = "2FAF4A00-528D-4413-85FB-6386719A7045", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.MDSLEarth_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "_MDSLEarth_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLEarth_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLEarth _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLEarth;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4EF8F503-C293-4BC9-AF04-98DB8F6E6C73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.MDSLEarth_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "_MDSLEarth_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLEarth_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLEarth _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLEarth;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3AFB6353-8D3A-462A-99B5-C025D59A003B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "D53405D5-901E-4E1D-863A-B6A76FE9ACD1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FCF4FE49-5523-49CD-9DBD-4503289310B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.GetElevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "GetElevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method GetHeight
	///</summary>
	public class GetElevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetElevation);

		}
	}


	[NVP_Manifest(
		Id = "92E639A0-BE2B-4905-8B50-863897A31BCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.GetPointsCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "GetPointsCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetPointCount", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method GetPointCount
	///</summary>
	public class GetPointsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPointsCount);

		}
	}


	[NVP_Manifest(
		Id = "93DC84E3-6DFE-4E7F-8994-FD6A130198EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.GetPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "GetPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetHeightAtPoint", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Result", typeof(System.Object))]

	///<summary>
	///method GetHeightAtPoint
	///</summary>
	public class GetPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74917E47-2F61-4468-9ED8-708B4A977010", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.GetStation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "GetStation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetStation", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method GetStation
	///</summary>
	public class GetStation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetStation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9BA453BC-7041-4E53-B5CD-A19B4F42E30E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLEarth.owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLEarth", 
		NodeName = "owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}
}
