using NVP.API.Nodes;

namespace Renga.ExportedObject3DCollection 
{
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3DCollection_Constructor : INode 
	{
		public Renga.IExportedObject3DCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IExportedObject3DCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3DCollection_ConstructorCast : INode 
	{
		public Renga.IExportedObject3DCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IExportedObject3DCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ExportedObject3DCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ExportedObject3DCollection", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}
}
