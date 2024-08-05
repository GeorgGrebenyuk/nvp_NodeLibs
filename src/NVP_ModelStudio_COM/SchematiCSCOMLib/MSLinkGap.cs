using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSLinkGap Interface
///</summary>
namespace SchematiCSCOMLib.MSLinkGap 
{

	[NVP_Manifest(
		Id = "98322FC0-BD5E-4296-9D4F-760DC0E2E91F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.MSLinkGap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "_MSLinkGap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkGap_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSLinkGap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSLinkGap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "115A44DA-7FDA-4048-A9DA-629ED8C45B76", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.MSLinkGap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "_MSLinkGap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkGap_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSLinkGap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSLinkGap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C9488A6F-2888-4772-BFF1-6ACEB342CC8F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("MSLinkGap", typeof(object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitPosition);

		}
	}


	[NVP_Manifest(
		Id = "E4475CAE-F02F-4959-9378-5A2EDF034FE1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.Set_UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "Set_UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Modifier")]
	[NodeInput("MSLinkGap", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class Set_UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB216988-5289-4A61-AB19-DBA9511F58C3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.GapLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "GapLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина", 
		ViewType = "Data")]
	[NodeInput("MSLinkGap", typeof(object))]

	///<summary>
	///Длина
	///</summary>
	public class GapLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GapLength);

		}
	}


	[NVP_Manifest(
		Id = "581774B7-55EB-4CE1-A1D7-6CFDE93A39F9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLinkGap.Set_GapLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLinkGap", 
		NodeName = "Set_GapLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина", 
		ViewType = "Modifier")]
	[NodeInput("MSLinkGap", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина
	///</summary>
	public class Set_GapLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GapLength = inputs[1].Value;
			return null;
		}
	}
}
