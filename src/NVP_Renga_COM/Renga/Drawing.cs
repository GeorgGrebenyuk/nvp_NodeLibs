using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Drawing 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Drawing_Constructor : INode 
	{
		public Renga.IDrawing _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDrawing;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Drawing_ConstructorCast : INode 
	{
		public Renga.IDrawing _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDrawing;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

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
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("Renga.AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToDxf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDxf(inputs[1].Value,((Renga.AutocadVersion)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("Renga.AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToDwg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDwg(inputs[1].Value,((Renga.AutocadVersion)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToPdf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToPdf(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToOpenXps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToOpenXps(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TitleBlockInstanceCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleBlockInstanceCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTitleBlockInstance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTitleBlockInstance(inputs[1].Value));

		}
	}
}
