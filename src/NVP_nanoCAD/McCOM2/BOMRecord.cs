using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single line of BOM table
///</summary>
namespace McCOM2.BOMRecord 
{

	[NVP_Manifest(
		Id = "A89471C7-1539-4BC0-86ED-74F43263CA90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.BOMRecord_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "_BOMRecord_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMRecord_Constructor : INode 
	{
		public McCOM2.IBOMRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOMRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6F25D148-FC4F-4EFE-AF84-DFAD71A1FC95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.BOMRecord_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "_BOMRecord_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMRecord_ConstructorCast : INode 
	{
		public McCOM2.IBOMRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOMRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C1766329-C675-422E-AB97-51AE2D212263", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.Properties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "Properties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c5", 
		ViewType = "Data")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005c5
	///</summary>
	public class Properties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Properties);

		}
	}


	[NVP_Manifest(
		Id = "164B8472-8D78-4A87-89C0-77E0F1FA38FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005c6", 
		ViewType = "Modifier")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005c6
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16D05CD5-086E-41D2-9CE2-7E30D422E8D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.Order", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "Order", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d6", 
		ViewType = "Data")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005d6
	///</summary>
	public class Order : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Order);

		}
	}


	[NVP_Manifest(
		Id = "45A84C60-7590-4083-90E0-D089FF7DBBDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMRecord.Set_Order", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMRecord", 
		NodeName = "Set_Order", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d6", 
		ViewType = "Modifier")]
	[NodeInput("BOMRecord", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005d6
	///</summary>
	public class Set_Order : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Order = inputs[1].Value;
			return null;
		}
	}
}
