using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Enum value helper
///</summary>
namespace nanoCAD.EnuVal 
{

	[NVP_Manifest(
		Id = "745CB46C-CD68-4434-9567-972EC263A318", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.EnuVal.EnuVal_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.EnuVal", 
		NodeName = "_EnuVal_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EnuVal_Constructor : INode 
	{
		public nanoCAD.IEnuVal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IEnuVal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6FDFEAD7-E4B0-4A47-90E3-6D859F61C943", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.EnuVal.EnuVal_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.EnuVal", 
		NodeName = "_EnuVal_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EnuVal_ConstructorCast : INode 
	{
		public nanoCAD.IEnuVal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IEnuVal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "768243ED-F1FE-493B-A350-1C45387C8172", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.EnuVal.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.EnuVal", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves the enum name value", 
		ViewType = "Data")]
	[NodeInput("EnuVal", typeof(object))]

	///<summary>
	///Retrieves the enum name value
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}
}
