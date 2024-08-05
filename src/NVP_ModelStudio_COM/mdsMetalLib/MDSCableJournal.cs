using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSCableJournal Interface
///</summary>
namespace mdsMetalLib.MDSCableJournal 
{

	[NVP_Manifest(
		Id = "28DBB955-6DAD-4151-8929-6BA81858B7BF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCableJournal.MDSCableJournal_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCableJournal", 
		NodeName = "_MDSCableJournal_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCableJournal_Constructor : INode 
	{
		public mdsMetalLib.IMDSCableJournal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSCableJournal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "50BAF180-3EF0-4E6C-BA0E-6A31F7E9011F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCableJournal.MDSCableJournal_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCableJournal", 
		NodeName = "_MDSCableJournal_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCableJournal_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSCableJournal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSCableJournal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8B8F5AD4-FF96-42F0-81B2-3ED2CF564668", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCableJournal.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCableJournal", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSCableJournal", typeof(object))]

	///<summary>
	///Параметры
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
		Id = "68BCDE40-8505-4B50-B2C8-0287AF3CEDEE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCableJournal.GetLengthByConstruction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCableJournal", 
		NodeName = "GetLengthByConstruction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вычисление длины кабеля, проходящего по заданной конструкции", 
		ViewType = "Data")]
	[NodeInput("MDSCableJournal", typeof(object))]
	[NodeInput("ConstructionParam", typeof(System.String))]
	[NodeInput("ConstructionType", typeof(System.String))]

	///<summary>
	///Вычисление длины кабеля, проходящего по заданной конструкции
	///</summary>
	public class GetLengthByConstruction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthByConstruction(inputs[1].Value,inputs[2].Value));

		}
	}
}
