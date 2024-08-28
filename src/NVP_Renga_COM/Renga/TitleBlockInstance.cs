using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.TitleBlockInstance 
{

	[NVP_Manifest(
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
