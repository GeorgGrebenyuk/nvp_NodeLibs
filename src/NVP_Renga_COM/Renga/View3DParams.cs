using NVP.API.Nodes;

namespace Renga.View3DParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class View3DParams_Constructor : INode 
		{
		public Renga.IView3DParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IView3DParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class View3DParams_ConstructorCast : INode 
		{
		public Renga.IView3DParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IView3DParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("View3DParams", typeof(object))]
		public class Camera : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Camera);

			}
		}
}
