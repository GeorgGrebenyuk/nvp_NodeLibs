using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mdsUnitsLib.MDSUnitsFactory 
{

	[NVP_Manifest(
		Id = "EC1B6099-7508-4153-9CF7-5E8454872E45", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSUnitsFactory.MDSUnitsFactory_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSUnitsFactory", 
		NodeName = "_MDSUnitsFactory_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSUnitsFactory_Constructor : INode 
	{
		public mdsUnitsLib.IMDSUnitsFactory _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSUnitsFactory;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "920A3EA7-7046-42B5-8BC9-9342866848D8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSUnitsFactory.MDSUnitsFactory_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSUnitsFactory", 
		NodeName = "_MDSUnitsFactory_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSUnitsFactory_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSUnitsFactory _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSUnitsFactory;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E39F4A5D-FBEB-4010-B550-9E0E2BE57A6A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSUnitsFactory.CreateUnit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSUnitsFactory", 
		NodeName = "CreateUnit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Создание компонента оборудования", 
		ViewType = "Data")]
	[NodeInput("MDSUnitsFactory", typeof(object))]
	[NodeInput("BS_StringXPG", typeof(System.String))]
	[NodeInput("ptPosvar", typeof(System.Object))]
	[NodeInput("varvecX", typeof(System.Object))]
	[NodeInput("varvecY", typeof(System.Object))]
	[NodeInput("varvecZ", typeof(System.Object))]

	///<summary>
	///Создание компонента оборудования
	///</summary>
	public class CreateUnit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateUnit(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}
}
