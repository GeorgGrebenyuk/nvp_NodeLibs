using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of XRecord objects are used to store and manage arbitrary data
///</summary>
namespace OdaX.AcadXRecord 
{

	[NVP_Manifest(
		Id = "DD642315-6B06-40E8-8D8E-54227B7A08CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.AcadXRecord_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "_AcadXRecord_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXRecord_Constructor : INode 
	{
		public OdaX.IAcadXRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadXRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "38F2DA7C-510E-4A5F-9ADE-886B4E95510B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.AcadXRecord_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "_AcadXRecord_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXRecord_ConstructorCast : INode 
	{
		public OdaX.IAcadXRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadXRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CDE09BC5-7BFC-487B-AB9B-E6A295758D2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadXRecord", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "2F4CF837-75C9-40C0-9217-A77D11999024", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C8D0A418-09C9-4D78-B427-0D414C7E35D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.GetXRecordData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "GetXRecordData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "XRecordData) associated with a dictionary", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("XRecordDataType", typeof(System.Object))]
	[NodeInput("XRecordDataValue", typeof(System.Object))]

	///<summary>
	///XRecordData) associated with a dictionary
	///</summary>
	public class GetXRecordData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetXRecordData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3E5C1ACA-3E8E-4FF7-8F25-FB7F6802906A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.SetXRecordData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "SetXRecordData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "XRecordData) associated with a dictionary", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("XRecordDataType", typeof(System.Object))]
	[NodeInput("XRecordDataValue", typeof(System.Object))]

	///<summary>
	///XRecordData) associated with a dictionary
	///</summary>
	public class SetXRecordData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetXRecordData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9CED11C8-D84D-4F36-BD2F-614E317B14CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.TranslateIDs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "TranslateIDs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the translation of any contained object IDs during deepClone or wblockClone operations", 
		ViewType = "Data")]
	[NodeInput("AcadXRecord", typeof(object))]

	///<summary>
	///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
	///</summary>
	public class TranslateIDs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateIDs);

		}
	}


	[NVP_Manifest(
		Id = "7212825A-EE5F-499C-9624-5AB22B39DDAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXRecord.Set_TranslateIDs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXRecord", 
		NodeName = "Set_TranslateIDs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the translation of any contained object IDs during deepClone or wblockClone operations", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("xlateIds", typeof(System.Object))]

	///<summary>
	///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
	///</summary>
	public class Set_TranslateIDs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TranslateIDs = inputs[1].Value;
			return null;
		}
	}
}
