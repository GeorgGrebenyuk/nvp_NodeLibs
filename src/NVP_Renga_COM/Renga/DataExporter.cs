using NVP.API.Nodes;

namespace Renga.DataExporter 
{
		[NodeInput("dynamic", typeof(object))]
		public class DataExporter_Constructor : INode 
		{
		public Renga.IDataExporter _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IDataExporter;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class DataExporter_ConstructorCast : INode 
		{
		public Renga.IDataExporter _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IDataExporter;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("DataExporter", typeof(object))]
		public class GetObjects3D : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetObjects3D);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("DataExporter", typeof(object))]
		public class GetGrids : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetGrids);

			}
		}
}
