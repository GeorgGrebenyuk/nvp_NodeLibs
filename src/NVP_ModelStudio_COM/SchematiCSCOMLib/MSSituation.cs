using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSSituation Interface
///</summary>
namespace SchematiCSCOMLib.MSSituation 
{

	[NVP_Manifest(
		Id = "3C6BB2D6-574E-4766-8BDD-85C91C99F7BB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSituation.MSSituation_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSituation", 
		NodeName = "_MSSituation_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSSituation_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSSituation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSSituation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BF10D1CE-E229-4ACF-8821-161D19A0BE85", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSituation.MSSituation_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSituation", 
		NodeName = "_MSSituation_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSSituation_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSSituation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSSituation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "65AF9933-77CE-46BB-9D04-7A4A8D4A1052", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSituation.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSituation", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MSSituation", typeof(object))]

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
		Id = "35228AEA-4A17-47C2-ACFE-C1CD254AF0D8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSituation.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSituation", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MSSituation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
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
}
