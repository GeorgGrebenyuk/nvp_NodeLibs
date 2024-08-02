using NVP.API.Nodes;

namespace Renga.Drawing 
{
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


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]
	public class ExportToDxf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDxf(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]
	public class ExportToDwg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDwg(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]
	public class ExportToPdf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToPdf(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]
	public class ExportToOpenXps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToOpenXps(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	public class TitleBlockInstanceCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleBlockInstanceCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetTitleBlockInstance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTitleBlockInstance(inputs[1]));

		}
	}
}
