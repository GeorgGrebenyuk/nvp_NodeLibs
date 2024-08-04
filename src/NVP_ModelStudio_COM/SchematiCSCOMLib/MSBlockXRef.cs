using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSBlockXRef Interface
///</summary>
namespace SchematiCSCOMLib.MSBlockXRef 
{

	[NVP_Manifest(
		Id = "7C90DF2E-6F9F-439E-89AD-033877FD467C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSBlockXRef.MSBlockXRef_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSBlockXRef", 
		NodeName = "_MSBlockXRef_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSBlockXRef_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSBlockXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSBlockXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C61FB4CF-4B9A-4CA5-8B57-222CE9ADB6A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSBlockXRef.MSBlockXRef_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSBlockXRef", 
		NodeName = "_MSBlockXRef_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSBlockXRef_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSBlockXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSBlockXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "DAE2C0E5-B02D-4321-A612-B65716229D54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSBlockXRef.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSBlockXRef", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MSBlockXRef", typeof(object))]

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
		Id = "EB03DB3A-31C2-4110-A298-A12A30DB8C0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSBlockXRef.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSBlockXRef", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MSBlockXRef", typeof(object))]
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
