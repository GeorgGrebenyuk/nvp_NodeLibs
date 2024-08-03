using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.TitleBlockInstance 
{

	[NVP_Manifest(
		Id = "C3919400-483F-4E1A-BDC3-16D2DD5705EA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.TitleBlockInstance_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "_TitleBlockInstance_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class TitleBlockInstance_Constructor : INode 
	{
		public Renga.ITitleBlockInstance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ITitleBlockInstance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5E0CCFD9-A334-4467-BDB4-6F6E17E27FB7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.TitleBlockInstance_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "_TitleBlockInstance_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class TitleBlockInstance_ConstructorCast : INode 
	{
		public Renga.ITitleBlockInstance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ITitleBlockInstance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E654EB8E-FB8C-4735-917F-E79C3DA21832", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("TitleBlockInstance", typeof(object))]

	///<summary>
	///
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
		Id = "9C860076-A45A-4F45-A46D-0B4A12DA5242", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.RowCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "RowCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("TitleBlockInstance", typeof(object))]

	///<summary>
	///
	///</summary>
	public class RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowCount);

		}
	}


	[NVP_Manifest(
		Id = "EDFE06CA-D2AA-4AA2-81E3-C81F2E4AF268", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.ColumnCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "ColumnCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("TitleBlockInstance", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ColumnCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnCount);

		}
	}


	[NVP_Manifest(
		Id = "B948A04C-D4F6-4C68-9CB9-3C7315B38FE1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.TitleBlockInstance.GetCellValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.TitleBlockInstance", 
		NodeName = "GetCellValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("TitleBlockInstance", typeof(object))]
	[NodeInput("columnIndex", typeof(System.Int32))]
	[NodeInput("rowIndex", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellValue(inputs[1].Value,inputs[2].Value));

		}
	}
}
