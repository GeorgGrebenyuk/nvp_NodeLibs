using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mdsUnitsLib.MDSGrounding 
{

	[NVP_Manifest(
		Id = "E8038E18-1C16-4764-9C88-3469BC0B5E50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.MDSGrounding_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "_MDSGrounding_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSGrounding_Constructor : INode 
	{
		public mdsUnitsLib.IMDSGrounding _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSGrounding;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C9C08ACC-00EE-408D-9F4B-D17C0AEDA383", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.MDSGrounding_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "_MDSGrounding_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSGrounding_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSGrounding _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSGrounding;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2508AF14-DB0F-4BB5-AE0A-66CB98A08A83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.GetLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "GetLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина полосы", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]

	///<summary>
	///Длина полосы
	///</summary>
	public class GetLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLength);

		}
	}


	[NVP_Manifest(
		Id = "93523808-D7A9-4253-9E7F-0ADBF293849D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.GetLengthSeparated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "GetLengthSeparated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина полосы, разделенная по отметке", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]
	[NodeInput("fLevel", typeof(System.Double))]

	///<summary>
	///Длина полосы, разделенная по отметке
	///</summary>
	public class GetLengthSeparated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthSeparated(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "A7CA2D08-71D6-4BD3-9B65-B8085243D956", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь поверхности полосы", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]

	///<summary>
	///Площадь поверхности полосы
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea);

		}
	}


	[NVP_Manifest(
		Id = "E489C260-47AB-4E44-8A65-2F30050EAB94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSGrounding.GetAreaSeparated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSGrounding", 
		NodeName = "GetAreaSeparated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь поверхности полосы, разделенная по отметке", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]
	[NodeInput("fLevel", typeof(System.Double))]

	///<summary>
	///Площадь поверхности полосы, разделенная по отметке
	///</summary>
	public class GetAreaSeparated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAreaSeparated(inputs[1].Value));

		}
	}
}
