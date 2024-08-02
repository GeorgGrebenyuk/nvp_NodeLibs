using NVP.API.Nodes;

namespace Renga.Selection 
{
		[NodeInput("dynamic", typeof(object))]
		public class Selection_Constructor : INode 
		{
		public Renga.ISelection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ISelection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Selection_ConstructorCast : INode 
		{
		public Renga.ISelection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ISelection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Selection", typeof(object))]
		public class GetSelectedObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetSelectedObjects();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Selection", typeof(object))]
		public class SetSelectedObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetSelectedObjects();
				return null;
			}
		}
}
